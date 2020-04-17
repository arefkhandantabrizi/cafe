using System;
using System.Drawing;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using Telerik.WinControls;
using System.Linq;
using HomeCafe.DataBase;
using HomeCafe.Index_and_Login;
using HomeCafe.My_Custom_Classes;

namespace HomeCafe.Subscription
{
    public partial class FrmSubscription : RadForm
    {
        Alert.Alert _error;
        private readonly IFixLanguageAndForms _fixLanguageAndForms;
        private readonly IInputValidation _inputValidation;
        

        public FrmSubscription(IFixLanguageAndForms fixLanguageAndForms, IInputValidation inputValidation)
        {
            _fixLanguageAndForms = fixLanguageAndForms;
            _inputValidation = inputValidation;
            
            InitializeComponent();
            ThemeName = "TelerikMetro";
            combo_Birthday.Culture = PersianCultureHelper.GetFixedPersianCulture();
            combo_Birthday.Value = DateTime.Now;
            var headerFont = new Font("B Kamran", 14.0f, FontStyle.Bold);
            var datesFont = new Font("B Kamran", 14.0f, FontStyle.Bold);
            var calendarBehavior = combo_Birthday.DateTimePickerElement.GetCurrentBehavior() as RadDateTimePickerCalendar;
            if (calendarBehavior != null)
            {
                var calendar = calendarBehavior.Calendar;
                var calendarElement = calendar.CalendarElement;
                calendarElement.CalendarNavigationElement.Font = headerFont;
            }
            if (calendarBehavior == null) return;
            var monthView = calendarBehavior.Calendar.CalendarElement.CalendarVisualElement as MonthViewElement;
            if (monthView != null)
                foreach (var item in monthView.TableElement.Children.Cast<RadItem>())
                {
                    item.Font = datesFont;
                }
        }

        private void txt_Name_Enter(object sender, EventArgs e)
        {
            _fixLanguageAndForms.FixLanguage();  
        }

        private void txt_Name_Leave(object sender, EventArgs e)
        {
            _fixLanguageAndForms.OriginalLanguage();
        }

        private void txt_Name_KeyPress(object sender, KeyPressEventArgs e)
        {
           _inputValidation.LetterOnly(e);
        }

        private void frm_Subscription_Load(object sender, EventArgs e)
        {
           
            Text = string.Format("ثبت عضویت" + "         " + "کاربر:" + " " + "{0}", FrmLogin.FormUser);
            try
            {
                var dbFillLastUser = new MyDatabase();
                var drLastUser = dbFillLastUser.Select("select subscribe_num from subscribe ORDER BY id DESC");
                while (drLastUser.Read())
                {
                    txt_LastSubscription.Text= drLastUser[0].ToString();
                    break;
                }
                if (!drLastUser.HasRows)
                    txt_LastSubscription.Text = @"تا به حال مشترکی ثبت نشده است";
            }
            catch
            {
                _error = new Alert.Alert("Error", "." + "مشکل در برقراری ارتباط با پایگاه داده") {TopMost = true};
                _error.Show();
            }
        }

        private void txt_Name_TextChanged(object sender, EventArgs e)
        {
            if (txt_Name.Text.Trim().Length >= 3  && ((txt_PhoneNo.Text[1].ToString() == "0"
                && txt_PhoneNo.Text[2].ToString() == "9") && !txt_PhoneNo.Text.Contains('-')) &&
                 txt_Address.Text.Trim().Length > 3 && txt_Subscription.Text.Trim().Length > 0 )
            {
                btn_Save.Enabled = true;
            }
            else
            {
                btn_Save.Enabled = false;
            }
            

        }


        private void txt_Address_Enter(object sender, EventArgs e)
        {
            _fixLanguageAndForms.FixLanguage(); 
        }

        private void txt_Address_Leave(object sender, EventArgs e)
        {
            _fixLanguageAndForms.OriginalLanguage();
        }

        private void txt_Subscription_Enter(object sender, EventArgs e)
        {
            _fixLanguageAndForms.FixLanguage(); 
        }

        private void txt_Subscription_Leave(object sender, EventArgs e)
        {
            _fixLanguageAndForms.OriginalLanguage();
        }

        private void txt_Subscription_TextChanged(object sender, EventArgs e)
        {

            if (txt_Name.Text.Trim().Length >= 3 && ((txt_PhoneNo.Text[1].ToString() == "0"
                && txt_PhoneNo.Text[2].ToString() == "9") && !txt_PhoneNo.Text.Contains('-')) &&
                txt_Subscription.Text.Trim().Length > 0 && txt_Address.Text.Trim().Length > 3)
                btn_Save.Enabled = true;
            else
                btn_Save.Enabled = false;
        }

        private void txt_PhoneNo_TextChanged(object sender, EventArgs e)
        {
 
         if ( txt_PhoneNo.Text[1].ToString() == "0" && txt_PhoneNo.Text[2].ToString() == "9" &&
                txt_Name.Text.Trim().Length > 3 && txt_Subscription.Text.Trim().Length > 0 &&
                !txt_PhoneNo.Text.Contains('-') && txt_Address.Text.Trim().Length > 3)
                btn_Save.Enabled = true;

         //else if (txt_PhoneNo.Text.Equals("(----),---,----") && txt_Name.Text.Length > 0 
         //       && txt_Subscription.Text.Length > 0)
         //       btn_Save.Enabled = true;
           
          else
                btn_Save.Enabled = false;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            var customer = new Subscriber(new MyDatabase())
            {
                Name = txt_Name.Text.Trim(),
                BirthDate = combo_Birthday.Text,
                PhoneNumber = txt_PhoneNo.Value.ToString(),
                Adress = txt_Address.Text.Trim(),
                SubscriptionNumber = txt_Subscription.Text.Trim()
            };
            if (!customer.CheckSubscriptionNumber())
            {
                _error = new Alert.Alert("Error", "." + "شماره اشتراک تکراری است") { TopMost = true };
                _error.Show();
                return ;
            }
            var result = customer.Save();
            if (!result)
            {
                _error = new Alert.Alert("Error", "." + "مشکل در برقراری ارتباط با پایگاه داده") { TopMost = true };
                _error.Show();
                return;
            }
            txt_LastSubscription.Text = customer.SubscriptionNumber;
            Alert_Subscription.CaptionText = "توجه";
            Alert_Subscription.ContentText = "." + "مشترک مورد نظر با موفقیت ثبت شد";
            Alert_Subscription.Popup.AlertElement.ContentElement.Font = new Font("B kamran", 16.0f);
            Alert_Subscription.Popup.AlertElement.CaptionElement.TextAndButtonsElement.TextElement.Font = new Font("B kamran", 14.0f);
            Alert_Subscription.Popup.AlertElement.ContentElement.TextAlignment = ContentAlignment.MiddleRight;
            Alert_Subscription.Popup.AlertElement.CaptionElement.TextAndButtonsElement.TextAlignment = ContentAlignment.TopRight;
            Alert_Subscription.Show();

            txt_Name.Text = null;
            txt_Address.Text = null;
            txt_PhoneNo.ResetText();
            txt_Subscription.Text = null;
            combo_Birthday.Value = DateTime.Today;
        }

        private void txt_Address_TextChanged(object sender, EventArgs e)
        {
            if (txt_Name.Text.Trim().Length >= 3 && ((txt_PhoneNo.Text[1].ToString() == "0"
                && txt_PhoneNo.Text[2].ToString() == "9") && !txt_PhoneNo.Text.Contains('-')) &&
                txt_Subscription.Text.Trim().Length > 0 && txt_Address.Text.Trim().Length > 3)
                btn_Save.Enabled = true;
            else
                btn_Save.Enabled = false;
        }

       

        
    }
}
