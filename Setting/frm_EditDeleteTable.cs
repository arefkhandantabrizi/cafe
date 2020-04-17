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
    public partial class frm_EditDeleteTable : RadForm
    {
        InputLanguage original;
        Alert.Alert Error;
        public frm_EditDeleteTable()
        {
            InitializeComponent();
        }

        private void frm_EditDeleteTable_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = string.Format("اصلاح/حذف میز    نام کاربری:  {0}", FrmLogin.FormUser);


                combo_TableName.Enabled = false;

              

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
            {

                try
                {
                    MyDatabase db_fillCombo = new MyDatabase();
                    combo_TableName.DataSource = db_fillCombo.Select("SELECT dbo.table_name.id, dbo.table_name.name " +
                                                        " FROM dbo.resource INNER JOIN " +
                                                        " dbo.table_name ON dbo.resource.ID = dbo.table_name.location_id" +
                                                        " WHERE     (dbo.resource.ResourceName = N'" + combo_LocationName.Text + "') and dbo.table_name.isDeleted=N'"+false+"' ");
                    combo_TableName.DisplayMember = "name";
                    combo_TableName.ValueMember = "id";
                    combo_TableName.SelectedIndex = -1;

                    db_fillCombo.Conn.Close();
                    db_fillCombo.Conn.Dispose();

                    combo_TableName.Enabled = true;
                }
                catch
                {
                    Error = new Alert.Alert("Error", "." + "مشکل در برقراری ارتباط با پایگاه داده");
                    Error.TopMost = true;
                    Error.Show();
                }
            }
            else 
            {
                combo_TableName.Enabled = false;
           
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
            if (combo_TableName.Items.Contains(combo_TableName.Text.Trim()))
            {
                btn_Delete.Enabled = true;
                combo_TableNewName.Enabled = true;

                MyDatabase db_fillCombo_TableNewName = new MyDatabase();
                combo_TableNewName.DataSource = db_fillCombo_TableNewName.Select("SELECT dbo.table_name.id, dbo.table_name.name " +
                                                    " FROM dbo.resource INNER JOIN " +
                                                    " dbo.table_name ON dbo.resource.ID = dbo.table_name.location_id" +
                                                    " WHERE     (dbo.resource.ResourceName = N'" + combo_LocationName.Text + "') and dbo.table_name.isDeleted=N'" + false + "' ");
                combo_TableNewName.DisplayMember = "name";
                combo_TableNewName.ValueMember = "id";
                combo_TableNewName.SelectedIndex = -1;

                db_fillCombo_TableNewName.Conn.Close();
                db_fillCombo_TableNewName.Conn.Dispose();

            }
            else
            {
                btn_Delete.Enabled = false;
                combo_TableNewName.Enabled = false;
            }
        }

        private void combo_TableNewName_Enter(object sender, EventArgs e)
        {
            original = InputLanguage.CurrentInputLanguage;
            var culture = System.Globalization.CultureInfo.GetCultureInfo("fa-IR");
            var language = InputLanguage.FromCulture(culture);
            if (InputLanguage.InstalledInputLanguages.IndexOf(language) >= 0)
                InputLanguage.CurrentInputLanguage = language;
            else
                InputLanguage.CurrentInputLanguage = InputLanguage.DefaultInputLanguage;
        }

        private void combo_TableNewName_Leave(object sender, EventArgs e)
        {
            InputLanguage.CurrentInputLanguage = original;
        }

        private void combo_TableNewName_TextChanged(object sender, EventArgs e)
        {
            combo_TableNewName.DropDownListElement.AutoCompleteSuggest.SuggestMode = SuggestMode.Contains;
            if (!combo_TableNewName.Items.Contains(combo_TableNewName.Text.Trim()) && combo_TableNewName.Text.Length > 0)
            {
                btn_Edit.Enabled = true;
            }
            else
            {
                btn_Edit.Enabled = false;
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                MyDatabase db_deletetabe = new MyDatabase();
                db_deletetabe.Update("update table_name set isDeleted=N'"+true+"' from  dbo.resource INNER JOIN " +
                                    "  dbo.table_name ON dbo.resource.ID = dbo.table_name.location_id " + 
                                    "WHERE (dbo.table_name.name = N'"+combo_TableName.Text+"') "+
                                    " AND (dbo.resource.ResourceName = N'"+combo_LocationName.Text+"') ");

                this.Alert_EditDeleteTable.CaptionText = "توجه";
                this.Alert_EditDeleteTable.ContentText = "." + "میز مورد نظر با موفقیت حذف شد";
                this.Alert_EditDeleteTable.Popup.AlertElement.ContentElement.Font = new Font("B kamran", 16.0f);
                this.Alert_EditDeleteTable.Popup.AlertElement.CaptionElement.TextAndButtonsElement.TextElement.Font = new Font("B kamran", 14.0f);

                this.Alert_EditDeleteTable.Popup.AlertElement.ContentElement.TextAlignment = ContentAlignment.MiddleRight;
                this.Alert_EditDeleteTable.Popup.AlertElement.CaptionElement.TextAndButtonsElement.TextAlignment = ContentAlignment.TopRight;
                Alert_EditDeleteTable.Show();

                db_deletetabe.Conn.Close();
                db_deletetabe.Conn.Dispose();

                MyDatabase db_fillCombo = new MyDatabase();
                combo_TableName.DataSource = db_fillCombo.Select("SELECT dbo.table_name.id, dbo.table_name.name " +
                                                    " FROM dbo.resource INNER JOIN " +
                                                    " dbo.table_name ON dbo.resource.ID = dbo.table_name.location_id" +
                                                    " WHERE     (dbo.resource.ResourceName = N'" + combo_LocationName.Text + "') and dbo.table_name.isDeleted=N'" + false + "' ");
                combo_TableName.DisplayMember = "name";
                combo_TableName.ValueMember = "id";
                combo_TableName.SelectedIndex = -1;

                db_fillCombo.Conn.Close();
                db_fillCombo.Conn.Dispose();
            }
            catch
            {
                Error = new Alert.Alert("Error", "." + "مشکل در برقراری ارتباط با پایگاه داده");
                Error.TopMost = true;
                Error.Show();
                
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            try
            {
                MyDatabase db_updatetabe = new MyDatabase();
                db_updatetabe.Update("update table_name set name=N'" + combo_TableNewName.Text.Trim() + "' from  dbo.resource INNER JOIN " +
                                    "  dbo.table_name ON dbo.resource.ID = dbo.table_name.location_id " +
                                    "WHERE (dbo.table_name.name = N'" + combo_TableName.Text + "') " +
                                    " AND (dbo.resource.ResourceName = N'" + combo_LocationName.Text + "') ");

                this.Alert_EditDeleteTable.CaptionText = "توجه";
                this.Alert_EditDeleteTable.ContentText = "." + "نام میز مورد نظر با موفقیت بروز رسانی شد";
                this.Alert_EditDeleteTable.Popup.AlertElement.ContentElement.Font = new Font("B kamran", 16.0f);
                this.Alert_EditDeleteTable.Popup.AlertElement.CaptionElement.TextAndButtonsElement.TextElement.Font = new Font("B kamran", 14.0f);

                this.Alert_EditDeleteTable.Popup.AlertElement.ContentElement.TextAlignment = ContentAlignment.MiddleRight;
                this.Alert_EditDeleteTable.Popup.AlertElement.CaptionElement.TextAndButtonsElement.TextAlignment = ContentAlignment.TopRight;
                Alert_EditDeleteTable.Show();

                db_updatetabe.Conn.Close();
                db_updatetabe.Conn.Dispose();

                MyDatabase db_fillCombo = new MyDatabase();
                combo_TableName.DataSource = db_fillCombo.Select("SELECT dbo.table_name.id, dbo.table_name.name " +
                                                    " FROM dbo.resource INNER JOIN " +
                                                    " dbo.table_name ON dbo.resource.ID = dbo.table_name.location_id" +
                                                    " WHERE     (dbo.resource.ResourceName = N'" + combo_LocationName.Text + "') and dbo.table_name.isDeleted=N'" + false + "' ");
                combo_TableName.DisplayMember = "name";
                combo_TableName.ValueMember = "id";
                combo_TableName.SelectedIndex = -1;

                db_fillCombo.Conn.Close();
                db_fillCombo.Conn.Dispose();
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
