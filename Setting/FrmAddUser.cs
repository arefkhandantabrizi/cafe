using System;
using System.Drawing;
using System.Windows.Forms;
using HomeCafe.DataBase;
using HomeCafe.Index_and_Login;
using Telerik.WinControls.UI;

namespace HomeCafe.Setting
{
    public partial class FrmAddUser : RadForm
    {
        InputLanguage _original;
        Alert.Alert _error;
        public FrmAddUser()
        {
            InitializeComponent();
            this.ThemeName = "TelerikMetro";
        }

        private void combo_UserName_Enter(object sender, EventArgs e)
        {
            _original = InputLanguage.CurrentInputLanguage;
            var culture = System.Globalization.CultureInfo.GetCultureInfo("fa-IR");
            var language = InputLanguage.FromCulture(culture);
            if (InputLanguage.InstalledInputLanguages.IndexOf(language) >= 0)
                InputLanguage.CurrentInputLanguage = language;
            else
                InputLanguage.CurrentInputLanguage = InputLanguage.DefaultInputLanguage;
        }

        private void combo_UserName_Leave(object sender, EventArgs e)
        {
            InputLanguage.CurrentInputLanguage = _original;
        }

        private void combo_UserName_TextChanged(object sender, EventArgs e)
        {
            combo_UserName.DropDownListElement.AutoCompleteSuggest.SuggestMode = SuggestMode.Contains;
            if (combo_UserName.Items.Contains(combo_UserName.Text.Trim()))
            {
                btn_Save.Enabled = false;
                txt_PassWord.Enabled = false;
            }
            else
            {
                txt_PassWord.Enabled = true;
            }
        }

        private void frm_AddUser_Load(object sender, EventArgs e)
        {
            this.Text = "        " + "تعریف کاربر" + "                  " + "کاربر:" + "   " + FrmLogin.FormUser;
            try
            {
                MyDatabase db_FillUserName = new MyDatabase();
                combo_UserName.DataSource = db_FillUserName.Select("select username,id from login where isDeleted='false' or isDeleted is null");
                combo_UserName.DisplayMember = "username";
                combo_UserName.ValueMember = "id";
                combo_UserName.SelectedIndex = -1;
                db_FillUserName.Conn.Close();
                db_FillUserName.Conn.Dispose();

                txt_PassWord.Enabled = false;
                btn_Save.Enabled = false;
            }
            catch
            {
                _error = new Alert.Alert("_error", "." + "مشکل در برقراری ارتباط با پایگاه داده");
                _error.TopMost = true;
                _error.Show();
            }
        }

        private void ckb_PasswordShow_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            if (ckb_PasswordShow.Checked == true)
                txt_PassWord.UseSystemPasswordChar = false;
            else
                txt_PassWord.UseSystemPasswordChar = true;
        }

        private void txt_PassWord_Enter(object sender, EventArgs e)
        {
            _original = InputLanguage.CurrentInputLanguage;
            var culture = System.Globalization.CultureInfo.GetCultureInfo("fa-IR");
            var language = InputLanguage.FromCulture(culture);
            if (InputLanguage.InstalledInputLanguages.IndexOf(language) >= 0)
                InputLanguage.CurrentInputLanguage = language;
            else
                InputLanguage.CurrentInputLanguage = InputLanguage.DefaultInputLanguage;
        }

        private void txt_PassWord_Leave(object sender, EventArgs e)
        {
            InputLanguage.CurrentInputLanguage = _original;
        }

        private void txt_PassWord_TextChanged(object sender, EventArgs e)
        {
            if (txt_PassWord.TextLength > 0)
                btn_Save.Enabled = true;
            else
                btn_Save.Enabled = false;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                MyDatabase db_Save = new MyDatabase();
                db_Save.Insert("Insert into login (username,password,isDeleted) values (N'"+combo_UserName.Text+"',"
                +"N'"+txt_PassWord.Text+"', N'false')");

                MessageBox.Show(db_Save.DetailedError);
                MessageBox.Show(db_Save.SqlCommandError);

                this.Alert_AddUser.CaptionText = "توجه";
                this.Alert_AddUser.ContentText = "." + "کاربر مورد نظر با موفقیت ثبت شد";
                this.Alert_AddUser.Popup.AlertElement.ContentElement.Font = new Font("B kamran", 16.0f);
                this.Alert_AddUser.Popup.AlertElement.CaptionElement.TextAndButtonsElement.TextElement.Font = new Font("B kamran", 14.0f);

                this.Alert_AddUser.Popup.AlertElement.ContentElement.TextAlignment = ContentAlignment.MiddleRight;
                this.Alert_AddUser.Popup.AlertElement.CaptionElement.TextAndButtonsElement.TextAlignment = ContentAlignment.TopRight;
                Alert_AddUser.Show();

                db_Save.Conn.Close();
                db_Save.Conn.Dispose();
            }
            catch
            {
                _error = new Alert.Alert("_error", "." + "مشکل در برقراری ارتباط با پایگاه داده");
                _error.TopMost = true;
                _error.Show();
            }
        }

    }
}
