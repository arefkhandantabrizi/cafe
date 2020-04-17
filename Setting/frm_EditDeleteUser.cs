using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HomeCafe.DataBase;
using HomeCafe.Index_and_Login;
using Telerik.WinControls.UI;

namespace HomeCafe.Setting
{
    public partial class frm_EditDeleteUser : RadForm
    {
        InputLanguage original;
        Alert.Alert Error;
        public frm_EditDeleteUser()
        {
            InitializeComponent();
            this.ThemeName = "TelerikMetro";
        }

        private void frm_EditDeleteUser_Load(object sender, EventArgs e)
        {
            txt_PassWord.UseSystemPasswordChar = true;
            combo_UserName.Enabled = false;
            txt_PassWord.Enabled = false;
            btn_Delete.Enabled = false;
            btn_Edit.Enabled = false;
            this.Text = "        " + "اصلاح/ حذف کاربر" + "                  " + "کاربر:" + "   " + FrmLogin.FormUser;
            try
            {
                MyDatabase db_FillOldUserName = new MyDatabase();
                MyDatabase db_FillUserName = new MyDatabase();
                combo_OldUserName.DataSource = db_FillOldUserName.Select("select username,id from login where (isDeleted=N'false' or isDeleted is null)");
                combo_OldUserName.DisplayMember = "username";
                combo_OldUserName.ValueMember = "id";
                combo_OldUserName.SelectedIndex = -1;
                db_FillOldUserName.Conn.Close();
                db_FillOldUserName.Conn.Dispose();


                combo_UserName.DataSource = db_FillUserName.Select("select username,id from login where (isDeleted=N'false' or isDeleted is null)");
                combo_UserName.DisplayMember = "username";
                combo_UserName.ValueMember = "id";
                combo_UserName.SelectedIndex = -1;
                db_FillUserName.Conn.Close();
                db_FillUserName.Conn.Dispose();
            }
            catch
            {
                Error = new Alert.Alert("Error", "." + "مشکل در برقراری ارتباط با پایگاه داده");
                Error.TopMost = true;
                Error.Show();
            }
        }

        private void combo_OldUserName_Enter(object sender, EventArgs e)
        {
            original = InputLanguage.CurrentInputLanguage;
            var culture = System.Globalization.CultureInfo.GetCultureInfo("fa-IR");
            var language = InputLanguage.FromCulture(culture);
            if (InputLanguage.InstalledInputLanguages.IndexOf(language) >= 0)
                InputLanguage.CurrentInputLanguage = language;
            else
                InputLanguage.CurrentInputLanguage = InputLanguage.DefaultInputLanguage;
        }

        private void combo_OldUserName_Leave(object sender, EventArgs e)
        {
            InputLanguage.CurrentInputLanguage = original;
        }

        private void combo_OldUserName_TextChanged(object sender, EventArgs e)
        {
            combo_OldUserName.DropDownListElement.AutoCompleteSuggest.SuggestMode = SuggestMode.Contains;
            if (combo_OldUserName.Items.Contains(combo_OldUserName.Text.Trim()))
            {
                btn_Delete.Enabled = true;
                combo_UserName.Enabled = true;
            }
            else
            {
                btn_Delete.Enabled = false;
                combo_UserName.Enabled = false;
            }

        }

        private void combo_UserName_Enter(object sender, EventArgs e)
        {
            original = InputLanguage.CurrentInputLanguage;
            var culture = System.Globalization.CultureInfo.GetCultureInfo("fa-IR");
            var language = InputLanguage.FromCulture(culture);
            if (InputLanguage.InstalledInputLanguages.IndexOf(language) >= 0)
                InputLanguage.CurrentInputLanguage = language;
            else
                InputLanguage.CurrentInputLanguage = InputLanguage.DefaultInputLanguage;
        }

        private void combo_UserName_Leave(object sender, EventArgs e)
        {
            InputLanguage.CurrentInputLanguage = original;
        }

        private void combo_UserName_TextChanged(object sender, EventArgs e)
        {
            combo_UserName.DropDownListElement.AutoCompleteSuggest.SuggestMode = SuggestMode.Contains;
            if (combo_UserName.Text.Length > 0)
            {
              
                txt_PassWord.Enabled = true;
            }
            else
            {
                txt_PassWord.Enabled = false;
            }
        }

        private void txt_PassWord_Enter(object sender, EventArgs e)
        {
            original = InputLanguage.CurrentInputLanguage;
            var culture = System.Globalization.CultureInfo.GetCultureInfo("fa-IR");
            var language = InputLanguage.FromCulture(culture);
            if (InputLanguage.InstalledInputLanguages.IndexOf(language) >= 0)
                InputLanguage.CurrentInputLanguage = language;
            else
                InputLanguage.CurrentInputLanguage = InputLanguage.DefaultInputLanguage;
        }

        private void txt_PassWord_Leave(object sender, EventArgs e)
        {
            InputLanguage.CurrentInputLanguage = original;
        }

        private void txt_PassWord_TextChanged(object sender, EventArgs e)
        {
            if (txt_PassWord.TextLength > 0)
                btn_Edit.Enabled = true;
            else
                btn_Edit.Enabled = false;
        }

        private void ckb_PasswordShow_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            if (ckb_PasswordShow.Checked == true)
                txt_PassWord.UseSystemPasswordChar = false;
            else
                txt_PassWord.UseSystemPasswordChar = true;
           
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (combo_OldUserName.Text == FrmLogin.FormUser)
            {
                Error = new Alert.Alert("Error", "." + "نمی توانید کاربر قعلی سیستم را پاک کنید");
                Error.TopMost = true;
                Error.Show();
            }
            else
            {
                try
                {
                    MyDatabase db_DeleteUser = new MyDatabase();
                    db_DeleteUser.Update("update login set isDeleted=N'true' where username=N'"+combo_OldUserName.Text+"'");

                    this.Alert_EditDeletUser.CaptionText = "توجه";
                    this.Alert_EditDeletUser.ContentText = "." + "کاربر مورد نظر با موفقیت حذف شد";
                    this.Alert_EditDeletUser.Popup.AlertElement.ContentElement.Font = new Font("B kamran", 16.0f);
                    this.Alert_EditDeletUser.Popup.AlertElement.CaptionElement.TextAndButtonsElement.TextElement.Font = new Font("B kamran", 14.0f);

                    this.Alert_EditDeletUser.Popup.AlertElement.ContentElement.TextAlignment = ContentAlignment.MiddleRight;
                    this.Alert_EditDeletUser.Popup.AlertElement.CaptionElement.TextAndButtonsElement.TextAlignment = ContentAlignment.TopRight;
                    Alert_EditDeletUser.Show();

                    db_DeleteUser.Conn.Close();
                    db_DeleteUser.Conn.Dispose();

                    MyDatabase db_FillOldUserName = new MyDatabase();
                    MyDatabase db_FillUserName = new MyDatabase();
                    combo_OldUserName.DataSource = db_FillOldUserName.Select("select username,id from login where (isDeleted=N'false' or isDeleted is null)");
                    combo_OldUserName.DisplayMember = "username";
                    combo_OldUserName.ValueMember = "id";
                    combo_OldUserName.SelectedIndex = -1;
                    db_FillOldUserName.Conn.Close();
                    db_FillOldUserName.Conn.Dispose();


                    combo_UserName.DataSource = db_FillUserName.Select("select username,id from login where (isDeleted=N'false' or isDeleted is null)");
                    combo_UserName.DisplayMember = "username";
                    combo_UserName.ValueMember = "id";
                    combo_UserName.SelectedIndex = -1;
                    db_FillUserName.Conn.Close();
                    db_FillUserName.Conn.Dispose();
                }
                catch 
                {
                    Error = new Alert.Alert("Error", "." + "مشکل در برقراری ارتباط با پایگاه داده");
                    Error.TopMost = true;
                    Error.Show();
                }
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            try
            {
                MyDatabase db_EditUser = new MyDatabase();
                db_EditUser.Update("update login set username=N'"+combo_UserName.Text.Trim()+"',password=N'"+txt_PassWord.Text.Trim()+"'  where username=N'" + combo_OldUserName.Text + "'");

                this.Alert_EditDeletUser.CaptionText = "توجه";
                this.Alert_EditDeletUser.ContentText = "." + "مشخصات کاربر مورد نظر با موفقیت اصلاح شد";
                this.Alert_EditDeletUser.Popup.AlertElement.ContentElement.Font = new Font("B kamran", 16.0f);
                this.Alert_EditDeletUser.Popup.AlertElement.CaptionElement.TextAndButtonsElement.TextElement.Font = new Font("B kamran", 14.0f);

                this.Alert_EditDeletUser.Popup.AlertElement.ContentElement.TextAlignment = ContentAlignment.MiddleRight;
                this.Alert_EditDeletUser.Popup.AlertElement.CaptionElement.TextAndButtonsElement.TextAlignment = ContentAlignment.TopRight;
                Alert_EditDeletUser.Show();

                db_EditUser.Conn.Close();
                db_EditUser.Conn.Dispose();


                MyDatabase db_FillOldUserName = new MyDatabase();
                MyDatabase db_FillUserName = new MyDatabase();
                combo_OldUserName.DataSource = db_FillOldUserName.Select("select username,id from login where (isDeleted=N'false' or isDeleted is null)");
                combo_OldUserName.DisplayMember = "username";
                combo_OldUserName.ValueMember = "id";
                combo_OldUserName.SelectedIndex = -1;
                db_FillOldUserName.Conn.Close();
                db_FillOldUserName.Conn.Dispose();


                combo_UserName.DataSource = db_FillUserName.Select("select username,id from login where (isDeleted=N'false' or isDeleted is null)");
                combo_UserName.DisplayMember = "username";
                combo_UserName.ValueMember = "id";
                combo_UserName.SelectedIndex = -1;
                db_FillUserName.Conn.Close();
                db_FillUserName.Conn.Dispose();
            }
            catch
            {
                Error = new Alert.Alert("Error", "." + "مشکل در برقراری ارتباط با پایگاه داده");
                Error.TopMost = true;
                Error.Show();
            }
        }
    }
}
