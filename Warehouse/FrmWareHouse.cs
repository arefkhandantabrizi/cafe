using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using HomeCafe.DataBase;
using HomeCafe.Index_and_Login;
using HomeCafe.My_Custom_Classes;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace HomeCafe.Warehouse
{
    public partial class FrmWareHouse : RadForm
    {
      
        public RadForm Error;
        InputLanguage original;
        int id;
        public FrmWareHouse()
        {
            InitializeComponent();
            txt_PurchDate.Value = DateTime.Today.AddDays(0);
            txt_ExpDate.Culture = PersianCultureHelper.GetFixedPersianCulture();
            txt_ExpDate.DateTimePickerElement.Calendar.FocusedDate = DateTime.Now;
            txt_PurchDate.Culture = PersianCultureHelper.GetFixedPersianCulture();
            txt_ExpDate.Value = DateTime.Today.AddDays(0);
            txt_PurchDate.DateTimePickerElement.Calendar.FocusedDate = DateTime.Now;
            txt_Expence.MaskType = MaskType.Numeric;
            txt_Expence.Mask = @"C0";
            var headerFont = new Font("IRANSansDNFaNum", 10.0f, FontStyle.Regular);
            var datesFont = new Font("IRANSansDNFaNum", 10.0f, FontStyle.Regular);
            var calendarBehavior = txt_PurchDate.DateTimePickerElement.GetCurrentBehavior() as RadDateTimePickerCalendar;
            if (calendarBehavior != null)
            {
                var calendar = calendarBehavior.Calendar;
                var calendarElement = calendar.CalendarElement;
                calendarElement.CalendarNavigationElement.Font = headerFont;
            }
            if (calendarBehavior != null)
            {
                var monthView = calendarBehavior.Calendar.CalendarElement.CalendarVisualElement as MonthViewElement;
                if (monthView != null)
                    foreach (var radElement in monthView.TableElement.Children)
                    {
                        var item = (RadItem) radElement;
                        item.Font = datesFont;
                    }
            }
            var calendarBehavior1 = txt_ExpDate.DateTimePickerElement.GetCurrentBehavior() as RadDateTimePickerCalendar;
            if (calendarBehavior1 != null)
            {
                var calendar1 = calendarBehavior1.Calendar;
                var calendarElement1 = calendar1.CalendarElement;
                calendarElement1.CalendarNavigationElement.Font = headerFont;
            }
            if (calendarBehavior1 != null)
            {
                var monthView1 = calendarBehavior1.Calendar.CalendarElement.CalendarVisualElement as MonthViewElement;
                if (monthView1 != null)
                    foreach (var radElement in monthView1.TableElement.Children)
                    {
                        var item = (RadItem) radElement;
                        item.Font = datesFont;
                    }
            }
        }

        private void frm_WareHouse_Load(object sender, EventArgs e)
        {
            txt_ExpDate.DateTimePickerElement.Calendar.FocusedDate = DateTime.Now;
            Text = string.Format("مدیریت انبار                 " + "کاربر:" + " {0}", FrmLogin.FormUser); 
            btn_Save.Enabled = false;
            try
            {
                MyDatabase db_fillvendor=new MyDatabase();
                combo_Vendor.DataSource = db_fillvendor.Select("select * from vendor where isDeleted='"+false+"' or isDeleted is NULL");
                combo_Vendor.DisplayMember = "name";
                combo_Vendor.ValueMember = "id";
                db_fillvendor.Conn.Close();
                db_fillvendor.Conn.Dispose();
            }
            catch 
            {
                Error = new Alert.Alert("Error", "." + "مشکل در برقراری ارتباط با پایگاه داده");
                Error.TopMost = true;
                Error.Show();
            }
        }

        private void txt_GoodsName_Enter(object sender, EventArgs e)
        {
            original = InputLanguage.CurrentInputLanguage;
            var culture = CultureInfo.GetCultureInfo("fa-IR");
            var language = InputLanguage.FromCulture(culture);
            if (InputLanguage.InstalledInputLanguages.IndexOf(language) >= 0)
                InputLanguage.CurrentInputLanguage = language;
            else
                InputLanguage.CurrentInputLanguage = InputLanguage.DefaultInputLanguage;
        }

        private void txt_GoodsName_Leave(object sender, EventArgs e)
        {
            InputLanguage.CurrentInputLanguage = original;
        }

        private void txt_GoodsName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char.IsLetter(e.KeyChar)) && (e.KeyChar == (char)Keys.Back) && (e.KeyChar == (char)Keys.Space) && !(char.IsDigit(e.KeyChar)))
                 e.Handled = true;
        }

        private void txt_GoodsName_TextChanged(object sender, EventArgs e)
        {
            if (txt_GoodsName.Text.Length > 0 && txt_WeightCount.Text.Length > 0 && txt_Expence.Text.Length > 0 && txt_PurchDate.Text.Length > 0 && txt_ExpDate.Text.Length > 0)
                btn_Save.Enabled = true;
            else
                btn_Save.Enabled = false;
        }

        private void txt_Expence_Enter(object sender, EventArgs e)
        {
            original = InputLanguage.CurrentInputLanguage;
            var culture = CultureInfo.GetCultureInfo("fa-IR");
            var language = InputLanguage.FromCulture(culture);
            if (InputLanguage.InstalledInputLanguages.IndexOf(language) >= 0)
                InputLanguage.CurrentInputLanguage = language;
            else
                InputLanguage.CurrentInputLanguage = InputLanguage.DefaultInputLanguage;
        }

        private void txt_Expence_Leave(object sender, EventArgs e)
        {
            InputLanguage.CurrentInputLanguage = original;
        }

        private void txt_Expence_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (!(char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            //    e.Handled = true;
        }

        private void btn_Weight_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            if (btn_Weight.IsChecked)
            {
                panel_WeightUnit.Visible = true;
            }
            else
            {
                panel_WeightUnit.Visible = false;
            }

        }

        private void txt_WeightCount_Enter(object sender, EventArgs e)
        {
            original = InputLanguage.CurrentInputLanguage;
            var culture = CultureInfo.GetCultureInfo("fa-IR");
            var language = InputLanguage.FromCulture(culture);
            if (InputLanguage.InstalledInputLanguages.IndexOf(language) >= 0)
                InputLanguage.CurrentInputLanguage = language;
            else
                InputLanguage.CurrentInputLanguage = InputLanguage.DefaultInputLanguage;
        }

        private void txt_WeightCount_Leave(object sender, EventArgs e)
        {
            InputLanguage.CurrentInputLanguage = original;
        }

        private void txt_WeightCount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                e.Handled = true;
        }

        private void txt_Expence_TextChanged(object sender, EventArgs e)
        {
            if (txt_GoodsName.Text.Length > 0 && txt_WeightCount.Text.Length > 0 && txt_Expence.Text.Length > 0 && txt_PurchDate.Text.Length > 0 && txt_ExpDate.Text.Length > 0)
                btn_Save.Enabled = true;
            else
                btn_Save.Enabled = false;
            
        }


        private void btn_Save_Click(object sender, EventArgs e)
        {
            string selectedunit;
         
            MyDatabase db_SaveGoods = new MyDatabase();
           
            if (btn_Weight.IsChecked)
            {
                if (btn_Gr.IsChecked)
                    selectedunit = "گرم";
                else
                    selectedunit = "کیلوگرم";
            }
            else
                selectedunit = null;
            try
            {

                SqlDataReader dr;
                MyDatabase dbfindvendor = new MyDatabase();
                dr = dbfindvendor.Select("select id from vendor where name=N'" + combo_Vendor.Text.Trim() + "'");
                while (dr.Read())
                {
                    id = Int32.Parse(dr[0].ToString());
                }

                int a = (Int32.Parse(txt_Expence.MaskedEditBoxElement.Value.ToString()) / 100);
                db_SaveGoods.Insert("Insert into warehouse_man (name,weight_count,exp_date,per_date,expence,debt,weight_unit,username,isDeleted,vendor_id)"
                    + "values(N'" + txt_GoodsName.Text.Trim() + "',N'" + float.Parse(txt_WeightCount.Text.Trim()) + "',N'" + txt_ExpDate.Text.Trim() + "'" +
                ",N'" + txt_PurchDate.Text.Trim() + "',N'" + a + "',N'" + ckb_Payed.Checked + "',N'" + selectedunit + "',N'" + FrmLogin.FormUser + "','false',N'" + id + "' )");

                dr.Close();
                dr.Dispose();
                dbfindvendor.Conn.Close();
                dbfindvendor.Conn.Dispose();


                WareHouse_Alert.CaptionText = "توجه";
                WareHouse_Alert.ContentText = "." + "اطلاعات با موفقیت ثبت شد";
                WareHouse_Alert.Popup.AlertElement.ContentElement.Font = new Font("B kamran", 16.0f);
                WareHouse_Alert.Popup.AlertElement.CaptionElement.TextAndButtonsElement.TextElement.Font = new Font("B kamran", 14.0f);

                WareHouse_Alert.Popup.AlertElement.ContentElement.TextAlignment = ContentAlignment.MiddleRight;
                WareHouse_Alert.Popup.AlertElement.CaptionElement.TextAndButtonsElement.TextAlignment = ContentAlignment.TopRight;

                WareHouse_Alert.Show();


            }
            catch
            {
                Error = new Alert.Alert("Error", "." + "مشکل در برقراری ارتباط با پایگاه داده");
                Error.TopMost = true;
                Error.Show();
            }

        }

        private void txt_WeightCount_TextChanged(object sender, EventArgs e)
        {
            if (txt_GoodsName.Text.Length > 0 && txt_WeightCount.Text.Length > 0 && txt_Expence.Text.Length > 0 && txt_PurchDate.Text.Length > 0 && txt_ExpDate.Text.Length > 0)
                btn_Save.Enabled = true;
            else
                btn_Save.Enabled = false;
        }

        private void combo_Vendor_Enter(object sender, EventArgs e)
        {
            original = InputLanguage.CurrentInputLanguage;
            var culture = CultureInfo.GetCultureInfo("fa-IR");
            var language = InputLanguage.FromCulture(culture);
            if (InputLanguage.InstalledInputLanguages.IndexOf(language) >= 0)
                InputLanguage.CurrentInputLanguage = language;
            else
                InputLanguage.CurrentInputLanguage = InputLanguage.DefaultInputLanguage;
        }

        private void combo_Vendor_Leave(object sender, EventArgs e)
        {
            InputLanguage.CurrentInputLanguage = original;
        }

        private void combo_Vendor_TextChanged(object sender, EventArgs e)
        {
            combo_Vendor.DropDownListElement.AutoCompleteSuggest.SuggestMode = SuggestMode.Contains;
            if (combo_Vendor.Items.Contains(combo_Vendor.Text.Trim()))
            {
                if (txt_GoodsName.Text.Length > 0 && txt_WeightCount.Text.Length > 0 && txt_Expence.Text.Length > 0 && txt_PurchDate.Text.Length > 0 && txt_ExpDate.Text.Length > 0)
                    btn_Save.Enabled = true;
            }
            else
                btn_Save.Enabled = false;
           
        }

  
    }
}
