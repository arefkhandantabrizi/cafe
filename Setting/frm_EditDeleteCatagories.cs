using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using System.Data.SqlClient;
using HomeCafe.DataBase;
using HomeCafe.Index_and_Login;

namespace HomeCafe.Setting
{
    public partial class frm_EditDeleteCatagories : RadForm
    {
        InputLanguage original;
        public RadForm Error;
        Alert.Alert f1;
        string search;
        public frm_EditDeleteCatagories()
        {
            InitializeComponent();
            this.ThemeName = "TelerikMetro";
        }

        private void combo_Catagories_TextChanged(object sender, EventArgs e)
        {
            combo_Catagories.DropDownListElement.AutoCompleteSuggest.SuggestMode = SuggestMode.Contains;
            if (combo_Catagories.Items.Contains(combo_Catagories.Text))
            {
                search = combo_Catagories.Text;
                txt_EditCatagories.Enabled = true;
                btn_Delete.Enabled = true;
                this.AcceptButton = btn_Delete;
            }
            else
            {
        
                txt_EditCatagories.Enabled = false;
                btn_Delete.Enabled = false;
            }
        }

        private void frm_EditCatagories_Load(object sender, EventArgs e)
        {
            this.Text = "       "+"اصلاح / حذف دسته" + "                  " + "کاربر:" + "   " + FrmLogin.FormUser;
            btn_Delete.Enabled = false;
            btn_Edit.Enabled = false;
            try
            {
                MyDatabase db_FillCombo = new MyDatabase();
                combo_Catagories.DataSource = db_FillCombo.Select("select * from catagories where isDeleted='false' or isDeleted is  null ");
                combo_Catagories.DisplayMember = "name";
                combo_Catagories.ValueMember = "id";
                combo_Catagories.SelectedIndex = -1;

                db_FillCombo.Conn.Close();
                db_FillCombo.Conn.Dispose();
            }
            catch
            {

                Error = new Alert.Alert("Error", "." + "مشکل در برقراری ارتباط با پایگاه داده");
                Error.TopMost = true;
                Error.Show();
            }
        }

        private void combo_Catagories_Enter(object sender, EventArgs e)
        {
            original = InputLanguage.CurrentInputLanguage;
            var culture = System.Globalization.CultureInfo.GetCultureInfo("fa-IR");
            var language = InputLanguage.FromCulture(culture);
            if (InputLanguage.InstalledInputLanguages.IndexOf(language) >= 0)
                InputLanguage.CurrentInputLanguage = language;
            else
                InputLanguage.CurrentInputLanguage = InputLanguage.DefaultInputLanguage;
        }

        private void combo_Catagories_Leave(object sender, EventArgs e)
        {
            InputLanguage.CurrentInputLanguage = original;
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            
            bool flag = true;

            try
            {
                if (combo_Catagories.Items.Contains(txt_EditCatagories.Text))
                {
                    flag=false;
                    Error = new Alert.Alert("Error", "." + "نام دسته تکراری است");
                    Error.TopMost = true;
                    Error.Show();

                }
                                        
                if (flag)
                {
                    MyDatabase db_Update = new MyDatabase();
                    db_Update.Update("update catagories set name=N'" + txt_EditCatagories.Text + "' where name=N'" + combo_Catagories.Text + "' ");

                    this.EditCatagories_Alert.CaptionText = "توجه";
                    this.EditCatagories_Alert.ContentText = "." + "دسته مورد نظر با موفقیت بروز رسانی شد";
                    this.EditCatagories_Alert.Popup.AlertElement.ContentElement.Font = new Font("B kamran", 16.0f);
                    this.EditCatagories_Alert.Popup.AlertElement.CaptionElement.TextAndButtonsElement.TextElement.Font = new Font("B kamran", 14.0f);

                    this.EditCatagories_Alert.Popup.AlertElement.ContentElement.TextAlignment = ContentAlignment.MiddleRight;
                    this.EditCatagories_Alert.Popup.AlertElement.CaptionElement.TextAndButtonsElement.TextAlignment = ContentAlignment.TopRight;

                    EditCatagories_Alert.Show();
                    
                    db_Update.Conn.Close();
                    db_Update.Conn.Dispose();

                    MyDatabase db_ReFill = new MyDatabase();
                    combo_Catagories.DataSource = db_ReFill.Select("select * from catagories where isDeleted= 'false ' or isDeleted is null  ");
                    combo_Catagories.DisplayMember = "name";
                    combo_Catagories.ValueMember = "id";
                    combo_Catagories.SelectedIndex = -1;

                    db_ReFill.Conn.Close();
                    db_ReFill.Conn.Dispose();
                }
            

               
            }
            catch
            {
                Error = new Alert.Alert("Error", "." + "مشکل در برقراری ارتباط با پایگاه داده");
                Error.TopMost = true;
                Error.Show();
            }
        }

        private void txt_EditCatagories_Enter(object sender, EventArgs e)
        {
            original = InputLanguage.CurrentInputLanguage;
            var culture = System.Globalization.CultureInfo.GetCultureInfo("fa-IR");
            var language = InputLanguage.FromCulture(culture);
            if (InputLanguage.InstalledInputLanguages.IndexOf(language) >= 0)
                InputLanguage.CurrentInputLanguage = language;
            else
                InputLanguage.CurrentInputLanguage = InputLanguage.DefaultInputLanguage;
        }

        private void txt_EditCatagories_Leave(object sender, EventArgs e)
        {
            InputLanguage.CurrentInputLanguage = original;
        }

        private void txt_EditCatagories_TextChanged(object sender, EventArgs e)
        {
            if (txt_EditCatagories.Text.Length > 0)
            {
                btn_Edit.Enabled = true;
                btn_Delete.Enabled = false;
                this.AcceptButton = btn_Edit;
            }
            else
            {
                btn_Edit.Enabled = false;
                btn_Delete.Enabled = true;
                this.AcceptButton = btn_Delete;
            }

        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {

             

                f1 = new Alert.Alert("Warning", "آیا مایل به حذف دسته فعلی می باشید؟" + " بعد از حذف امکان بازگشت وجود ندارد " );
                f1.TopMost = true;
                f1.BtnNo.Visible = true;
                f1.Show();
               
                f1.BtnOk.Click += new EventHandler(btn_Ok_Click);
                f1.BtnNo.Click += new EventHandler(btn_No_Click);

                MyDatabase db_ReFill = new MyDatabase();
                combo_Catagories.DataSource = db_ReFill.Select("select * from catagories where isDeleted= 'false ' or isDeleted is null  ");
                combo_Catagories.DisplayMember = "name";
                combo_Catagories.ValueMember = "id";
                combo_Catagories.SelectedIndex = -1;

                db_ReFill.Conn.Close();
                db_ReFill.Conn.Dispose();
               
               
            }
            catch 
            {
                Error = new Alert.Alert("Error", "." + "مشکل در برقراری ارتباط با پایگاه داده");
                Error.TopMost = true;
                Error.Show();
            }
        }

        void btn_No_Click(object sender, EventArgs e)
        {
            f1.Close();
            //throw new NotImplementedException();
        }

    

        void btn_Ok_Click(object sender, EventArgs e)
        {
             
            try
            {
                MyDatabase db_DeleteCatagories = new MyDatabase();
                db_DeleteCatagories.Update(" UPDATE catagories set isDeleted='true' where name=N'"+search+"' ");

           
                this.EditCatagories_Alert.CaptionText = "توجه";
                this.EditCatagories_Alert.ContentText = "." + "دسته مورد نظر با موفقیت حذف شد";
                this.EditCatagories_Alert.Popup.AlertElement.ContentElement.Font = new Font("B kamran", 16.0f);
                this.EditCatagories_Alert.Popup.AlertElement.CaptionElement.TextAndButtonsElement.TextElement.Font = new Font("B kamran", 14.0f);

                this.EditCatagories_Alert.Popup.AlertElement.ContentElement.TextAlignment = ContentAlignment.MiddleRight;
                this.EditCatagories_Alert.Popup.AlertElement.CaptionElement.TextAndButtonsElement.TextAlignment = ContentAlignment.TopRight;

                EditCatagories_Alert.Show();
                
                db_DeleteCatagories.Conn.Close();
                db_DeleteCatagories.Conn.Dispose();
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
