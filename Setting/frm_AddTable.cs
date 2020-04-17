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
    public partial class frm_AddTable : RadForm
    {
        Alert.Alert Error;
        InputLanguage original;
        int ID;
        public frm_AddTable()
        {
            InitializeComponent();
            this.ThemeName = "TelerikMetro";
            this.Text = "تعریف میز" + "         " + "کاربر:   " + FrmLogin.FormUser;
        }

        private void frm_AddTable_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = string.Format("افزودن میز    نام کاربری:  {0}", FrmLogin.FormUser );

                MyDatabase db_fillCombo = new MyDatabase();
                combo_TableName.DataSource = db_fillCombo.Select("select name from table_name where isDeleted=N'" + false + "'group by name  ");
                combo_TableName.DisplayMember = "name";
                //combo_TableName.ValueMember = "id";
                combo_TableName.SelectedIndex = -1;

                db_fillCombo.Conn.Close();
                db_fillCombo.Conn.Dispose();

                MyDatabase db_filllocation = new MyDatabase();
                combo_LocationName.DataSource = db_filllocation.Select("select * from resource ");
                combo_LocationName.DisplayMember = "ResourceName";
                combo_LocationName.ValueMember = "ID";
                combo_LocationName.SelectedIndex = -1;

                db_filllocation.Conn.Close();
                db_filllocation.Conn.Dispose();

            }
            catch
            {
                Error = new Alert.Alert("Error", "." + "مشکل در برقراری ارتباط با پایگاه داده");
                Error.TopMost = true;
                Error.Show();
               
            }
        }

        private void combo_TableName_Enter(object sender, EventArgs e)
        {
            original = InputLanguage.CurrentInputLanguage;
            var culture = System.Globalization.CultureInfo.GetCultureInfo("fa-IR");
            var language = InputLanguage.FromCulture(culture);
            if (InputLanguage.InstalledInputLanguages.IndexOf(language) >= 0)
                InputLanguage.CurrentInputLanguage = language;
            else
                InputLanguage.CurrentInputLanguage = InputLanguage.DefaultInputLanguage;
        }

        private void combo_TableName_Leave(object sender, EventArgs e)
        {
            InputLanguage.CurrentInputLanguage = original;
        }

        private void combo_TableName_TextChanged(object sender, EventArgs e)
        {
            combo_TableName.DropDownListElement.AutoCompleteSuggest.SuggestMode = SuggestMode.Contains;
            //if(combo_TableName.Text.Length>0)
            //    btn_Save.Enabled = true;
            //else
            //    btn_Save.Enabled = false;
            ////if (combo_TableName.Items.Contains(combo_TableName.Text.Trim()))
            //{
            //    btn_Save.Enabled = false;
            //}
            //else
            //{
            //    btn_Save.Enabled = true;
            //}

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataReader dr;
                MyDatabase db_search = new MyDatabase();
                bool flag = true;
               
                dr = db_search.Select("SELECT dbo.resource.ResourceName, dbo.table_name.name "+
                    " FROM dbo.resource INNER JOIN " +
                    " dbo.table_name ON dbo.resource.ID = dbo.table_name.location_id ");

                while (dr.Read())
                {
                    if (combo_TableName.Text == dr[1].ToString() && combo_LocationName.Text == dr[0].ToString())
                    {
                        flag = false;
                    
                        break;
                    }
                    

                }
                db_search.Conn.Close();
                db_search.Conn.Dispose();
                dr.Close();
                MyDatabase db_newsearch = new MyDatabase();
                SqlDataReader read = db_newsearch.Select("SELECT ID " +
                    " FROM resource " +
                    " WHERE ResourceName = N'"+combo_LocationName.Text+"' ");
                while (read.Read())
                {
                    ID = Int32.Parse(read[0].ToString());
                   
                    break;
                }

                db_newsearch.Conn.Close();
                db_newsearch.Conn.Dispose();
                read.Close();
                read.Dispose();

                if (flag)
                {
                    MyDatabase db_insert = new MyDatabase();
                    db_insert.Insert("Insert into table_name (name,location_id,isDeleted) values(N'" + combo_TableName.Text.Trim() + "', N'" + ID + "',N'"+false+"')");
                    this.Alert_AddTable.CaptionText = "توجه";
                    this.Alert_AddTable.ContentText = "." + "میز مورد نظر با موفقیت ثبت شد";
                    this.Alert_AddTable.Popup.AlertElement.ContentElement.Font = new Font("B kamran", 16.0f);
                    this.Alert_AddTable.Popup.AlertElement.CaptionElement.TextAndButtonsElement.TextElement.Font = new Font("B kamran", 14.0f);

                    this.Alert_AddTable.Popup.AlertElement.ContentElement.TextAlignment = ContentAlignment.MiddleRight;
                    this.Alert_AddTable.Popup.AlertElement.CaptionElement.TextAndButtonsElement.TextAlignment = ContentAlignment.TopRight;
                    Alert_AddTable.Show();

                    db_insert.Conn.Close();
                    db_insert.Conn.Dispose();
                }
                else
                {
                    Error = new Alert.Alert("Error", "." + "نام میز تکراری است");
                    Error.TopMost = true;
                    Error.Show();
                }
            }
            catch
            {
                Error = new Alert.Alert("Error", "." + "مشکل در برقراری ارتباط با پایگاه داده");
                Error.TopMost = true;
                Error.Show();
            }

        }

        private void combo_LocationName_Enter(object sender, EventArgs e)
        {
            original = InputLanguage.CurrentInputLanguage;
            var culture = System.Globalization.CultureInfo.GetCultureInfo("fa-IR");
            var language = InputLanguage.FromCulture(culture);
            if (InputLanguage.InstalledInputLanguages.IndexOf(language) >= 0)
                InputLanguage.CurrentInputLanguage = language;
            else
                InputLanguage.CurrentInputLanguage = InputLanguage.DefaultInputLanguage;
        }

        private void combo_LocationName_Leave(object sender, EventArgs e)
        {
            InputLanguage.CurrentInputLanguage = original;
        }

        private void combo_LocationName_TextChanged(object sender, EventArgs e)
        {
            combo_LocationName.DropDownListElement.AutoCompleteSuggest.SuggestMode = SuggestMode.Contains;
            if (combo_LocationName.Items.Contains(combo_LocationName.Text.Trim())) 
                btn_Save.Enabled = true;
            else
                btn_Save.Enabled = false;
         
        }


    }
}
