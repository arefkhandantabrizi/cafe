using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using HomeCafe.DataBase;
using HomeCafe.Index_and_Login;
using Telerik.WinControls.UI;

namespace HomeCafe.Setting
{
    public partial class frm_AddCatagories : RadForm
    {
        InputLanguage original;
        public RadForm Error;
        public frm_AddCatagories()
        {
            InitializeComponent();
            this.ThemeName = "TelerikMetro";
        }

        private void txt_Catagories_Enter(object sender, EventArgs e)
        {
            txt_Catagories.Text = "";
            original = InputLanguage.CurrentInputLanguage;
            var culture = System.Globalization.CultureInfo.GetCultureInfo("fa-IR");
            var language = InputLanguage.FromCulture(culture);
            if (InputLanguage.InstalledInputLanguages.IndexOf(language) >= 0)
                InputLanguage.CurrentInputLanguage = language;
            else
                InputLanguage.CurrentInputLanguage = InputLanguage.DefaultInputLanguage;
        }

        private void txt_Catagories_Leave(object sender, EventArgs e)
        {
            InputLanguage.CurrentInputLanguage = original;
        }

        private void txt_Catagories_TextChanged(object sender, EventArgs e)
        {
            if (txt_Catagories.Text.Length > 0)
                btn_Save.Enabled = true;
            else
                btn_Save.Enabled = false;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            string name;
            string id;
            bool flag= true;
           
            try
            {
                MyDatabase db_SearchCatagories = new MyDatabase();
                MyDatabase db_SaveCatagories = new MyDatabase();
                SqlDataReader dr_Catogories = db_SearchCatagories.Select("select * from catagories");
                while (dr_Catogories.Read())
                {
                    id = dr_Catogories[0].ToString();
                    name = dr_Catogories[1].ToString();
                    if (txt_Catagories.Text == name )
                    {
                        flag=false;
                        Error = new Alert.Alert("Error", "." + "نام دسته تکراری است");
                        Error.TopMost = true;
                        Error.Show();
                        break;
                       
                    }
                    
                                    
                }

                if (flag)
                {
                    db_SaveCatagories.Insert("Insert into catagories (name,isDeleted) values(N'" + txt_Catagories.Text + "',N'"+false+"')");

                    this.AddCatagories_Alert.CaptionText = "توجه";
                    this.AddCatagories_Alert.ContentText = "." + "دسته مورد نظر با موفقیت ثبت شد";
                    this.AddCatagories_Alert.Popup.AlertElement.ContentElement.Font = new Font("B kamran", 16.0f);
                    this.AddCatagories_Alert.Popup.AlertElement.CaptionElement.TextAndButtonsElement.TextElement.Font = new Font("B kamran", 14.0f);

                    this.AddCatagories_Alert.Popup.AlertElement.ContentElement.TextAlignment = ContentAlignment.MiddleRight;
                    this.AddCatagories_Alert.Popup.AlertElement.CaptionElement.TextAndButtonsElement.TextAlignment = ContentAlignment.TopRight;

                    AddCatagories_Alert.Show();
                }
                db_SaveCatagories.Conn.Close();
                db_SaveCatagories.Conn.Dispose();
                db_SearchCatagories.Conn.Close();
                db_SearchCatagories.Conn.Dispose();
                dr_Catogories.Close();
                
            }
            catch
            {
 

                Error = new Alert.Alert("Error", "." + "مشکل در برقراری ارتباط با پایگاه داده");
                Error.TopMost = true;
                Error.Show();
            }
        }

        private void frm_AddCatagories_Load(object sender, EventArgs e)
        {
            txt_Catagories.NullText = "نام دسته را وارد کنید";
            this.Text ="        "+ "تعریف دسته" + "                  " + "کاربر:" + "   " + FrmLogin.FormUser;
        }
    }
}
