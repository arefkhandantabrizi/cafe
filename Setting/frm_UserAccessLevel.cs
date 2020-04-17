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

namespace HomeCafe.Setting
{
    public partial class frm_UserAccessLevel : Form
    {
        static Font font = new Font("B kamran", 14.0f, FontStyle.Bold);
        bool flagload = false;
        Alert.Alert Error;
        int RoleId;
        int ID;
        InputLanguage original;
        bool flagAccessibility = false;
        bool flag = false;
        bool flagRole = false;
        public frm_UserAccessLevel()
        {
            InitializeComponent();
            
           
        }

        private void frm_UserAccessLevel_Load(object sender, EventArgs e)
        {
            int i = 0;
            try
            {
                
                List_AccessLevel.Font = font;

                MyDatabase db_fillRole = new MyDatabase();
                List_Role.DataSource = db_fillRole.Select("select id, rolename from role ");
               
                List_Role.DisplayMember = "rolename";
                List_Role.ValueMember = "id";

                MyDatabase db_fillcombo = new MyDatabase();
                combo_RoleName.DataSource = db_fillcombo.Select("select id, rolename from role ");

                combo_RoleName.DisplayMember = "rolename";
                combo_RoleName.ValueMember = "id";
                combo_RoleName.SelectedIndex = -1;

              
                MyDatabase db_fill = new MyDatabase();
                List_User.DataSource = db_fill.Select("select id, username from login where isDeleted=N'false' or isDeleted is null");
                List_User.DisplayMember = "username";
                List_User.ValueMember = "id";
                
                
                db_fill.Conn.Close();
                db_fill.Conn.Dispose();

                db_fillRole.Conn.Close();
                db_fillRole.Conn.Dispose();

                db_fillcombo.Conn.Close();
                db_fillcombo.Conn.Dispose();




                MyDatabase db_LoadAccessibility = new MyDatabase();
                DataTable visibility = db_LoadAccessibility.SelectDataTable("SELECT  dbo.accessibility.visibility FROM " +
                   " dbo.accessibility INNER JOIN  dbo.login ON dbo.accessibility.UserID = dbo.login.id where dbo.login.username=N'" + List_User.SelectedItem.Text + "'");
                i = 0;

                foreach (DataRow row in visibility.Rows)
                {


                    if (Convert.ToBoolean(visibility.Rows[i]["visibility"]) == true)
                    {
                        List_AccessLevel.Items[i].CheckState = Telerik.WinControls.Enumerations.ToggleState.On;

                    }
                    else
                    {
                        List_AccessLevel.Items[i].CheckState = Telerik.WinControls.Enumerations.ToggleState.Off;
                    }
                    i++;

                }
                db_LoadAccessibility.Conn.Close();
                db_LoadAccessibility.Conn.Dispose();
                visibility.Dispose();



                flagload = true;

                
               
             
          
            }
            catch
            {

                Error = new Alert.Alert("Error", "." + "مشکل در برقراری ارتباط با پایگاه داده ");
                Error.TopMost = true;
                Error.Show();
            }

        }

        private void List_User_ItemCreating(object sender, ListViewItemCreatingEventArgs e)
        {
            e.Item.Font = font;
        }

  
        private void List_AccessLevel_ItemMouseClick(object sender, ListViewItemEventArgs e)
        {
            if ( List_AccessLevel.SelectedItem.CheckState == Telerik.WinControls.Enumerations.ToggleState.On)

                List_AccessLevel.UncheckSelectedItems();
            else
                List_AccessLevel.CheckSelectedItems();
        }

        private void List_Role_ItemCreating(object sender, ListViewItemCreatingEventArgs e)
        {
            e.Item.Font = font;
        }

        private void List_Role_SelectedItemChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(List_Role.SelectedItem.Text);
            //if (List_Role.SelectedItem.Text== "مدیر")
            //{

        }

        private void List_Role_SelectedIndexChanged(object sender, EventArgs e)
        {

            flagRole = true;
            if (flag && flagRole)
                btn_SaveAccessLevel.Enabled = true;
            else
                btn_SaveAccessLevel.Enabled = false;

            //if (List_Role.SelectedIndex.ToString()=="0")
            //   List_AccessLevel.CheckAllItems();
            
            //else
            //   List_AccessLevel.UncheckAllItems();

    
  
       
    
           
        
           
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
            combo_RoleName.DropDownListElement.AutoCompleteSuggest.SuggestMode = SuggestMode.Contains;
            if (!combo_RoleName.Items.Contains(combo_RoleName.Text.Trim()))
            {
                btn_SaveRole.Enabled = true;
            }
            else
            {
                btn_SaveRole.Enabled = false;
            }
        }

        private void List_AccessLevel_SelectedIndexChanged(object sender, EventArgs e)
        {

                         

        }

        private void btn_SaveAccessLevel_Click(object sender, EventArgs e)
        {
           
            SqlDataReader dr_RoleID;
            string RoleID = null;
            try
            {
                MyDatabase db_SelectUserID = new MyDatabase();
                MyDatabase db_SelectRoleId = new MyDatabase();
                MyDatabase db_SearchAccessibilty = new MyDatabase();
                SqlDataReader dr_ID = db_SelectUserID.Select("select * from login where username=N'"+List_User.SelectedItem.Text+"'");
                dr_RoleID = db_SelectRoleId.Select("select id from role where rolename=N'"+List_Role.SelectedItem.Text+"'");
                while (dr_ID.Read())
                {
                    ID = Int32.Parse(dr_ID[0].ToString());
                    RoleID = dr_ID[4].ToString();
                }
                while (dr_RoleID.Read())
                {
                    RoleId=Int32.Parse(dr_RoleID[0].ToString());
                  
                }
              
                MyDatabase db_AddRole = new MyDatabase();
                db_AddRole.Update("update login set roleID=N'" + RoleId + "' where username=N'" + List_User.SelectedItem.Text + "'");
                

                db_AddRole.Conn.Close();
                db_AddRole.Conn.Dispose();
                    
             
                MyDatabase db_AddAccessibility=new MyDatabase();
                MyDatabase db_UpdateAccessibility = new MyDatabase();
                SqlDataReader CheckAccessibility=db_SearchAccessibilty.Select("select * from accessibility where UserID=N'" + ID + "'");
                if (CheckAccessibility.HasRows)
                {
                    flagAccessibility = true;
                }
                else
                    flagAccessibility = false;
                if (!flagAccessibility)
                {
                    for (int i = 0; i < List_AccessLevel.Items.Count; i++)
                    {

                        if (List_AccessLevel.Items[i].CheckState == Telerik.WinControls.Enumerations.ToggleState.On)
                        {
                            db_AddAccessibility.Insert("Insert into accessibility (pagename,visibility,UserID) values (N'" + List_AccessLevel.Items[i].Tag.ToString() + "',"
                             + "N'" + true + "',N'" + ID + "')");
                        }
                        else
                        {
                            db_AddAccessibility.Insert("Insert into accessibility (pagename,visibility,UserID) values (N'" + List_AccessLevel.Items[i].Tag.ToString() + "',"
                           + "N'" + false + "',N'" + ID + "')");
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < List_AccessLevel.Items.Count; i++)
                    {

                        if (List_AccessLevel.Items[i].CheckState == Telerik.WinControls.Enumerations.ToggleState.On)
                        {
                            db_UpdateAccessibility.Update("update accessibility set visibility=N'true' where pagename=N'" + List_AccessLevel.Items[i].Tag.ToString() + "' and UserID=N'" + ID + "' ");
                          
                        }
                        else
                        {
                            db_UpdateAccessibility.Update("update accessibility set visibility=N'false' where pagename=N'" + List_AccessLevel.Items[i].Tag.ToString() + "' and UserID=N'" + ID + "' ");
                            
                        }
                    }
                }

                this.Alert_Accessibility.CaptionText = "توجه";
                this.Alert_Accessibility.ContentText = "." + "سطح دسترسی کاربر مورد نظر با موفقیت ثبت شد";
                this.Alert_Accessibility.Popup.AlertElement.ContentElement.Font = new Font("B kamran", 16.0f);
                this.Alert_Accessibility.Popup.AlertElement.CaptionElement.TextAndButtonsElement.TextElement.Font = new Font("B kamran", 14.0f);

                this.Alert_Accessibility.Popup.AlertElement.ContentElement.TextAlignment = ContentAlignment.MiddleRight;
                this.Alert_Accessibility.Popup.AlertElement.CaptionElement.TextAndButtonsElement.TextAlignment = ContentAlignment.TopRight;
                Alert_Accessibility.Show();

                db_AddAccessibility.Conn.Close();
                db_AddAccessibility.Conn.Dispose();

                db_SelectRoleId.Conn.Close();
                db_SelectRoleId.Conn.Dispose();

                db_SelectUserID.Conn.Close();
                db_SelectUserID.Conn.Dispose();

                dr_ID.Close();
                dr_RoleID.Close();

            }
            catch
            {
                Error = new Alert.Alert("Error", "." + "مشکل در برقراری ارتباط با پایگاه داده");
                Error.TopMost = true;
                Error.Show();
            }
        }

        private void List_User_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = 0;
            flag = true;
            if (flag && flagRole)
                btn_SaveAccessLevel.Enabled = true;
            else
                btn_SaveAccessLevel.Enabled = false;
            if (flagload)
            {
                try
                {
                    MyDatabase db_loadRole = new MyDatabase();
                    SqlDataReader dr_LoadRole = db_loadRole.Select("SELECT  dbo.role.rolename FROM  dbo.login INNER JOIN "
                     + " dbo.role ON dbo.login.roleID = dbo.role.id where username=N'" + List_User.SelectedItem.Text + "'");
                    while (dr_LoadRole.Read())
                    {
                        for (i = 0; i < List_Role.Items.Count; i++)
                        {
                            if (List_Role.Items[i].Text == dr_LoadRole[0].ToString())
                            {
                                List_Role.SelectedItem = List_Role.Items[i];
                                break;
                            }
                        }

                    }
                    db_loadRole.Conn.Close();
                    db_loadRole.Conn.Dispose();
                    dr_LoadRole.Close();

                    MyDatabase db_LoadAccessibility = new MyDatabase();
                    DataTable visibility= db_LoadAccessibility.SelectDataTable("SELECT  dbo.accessibility.visibility FROM " +
                       " dbo.accessibility INNER JOIN  dbo.login ON dbo.accessibility.UserID = dbo.login.id where dbo.login.username=N'" + List_User.SelectedItem.Text + "'");
                    i = 0;
                    
                    foreach(DataRow row in visibility.Rows)
                    {
                      

                        if (Convert.ToBoolean(visibility.Rows[i]["visibility"]) == true)
                        {
                            List_AccessLevel.Items[i].CheckState = Telerik.WinControls.Enumerations.ToggleState.On;

                        }
                        else
                        {
                            List_AccessLevel.Items[i].CheckState = Telerik.WinControls.Enumerations.ToggleState.Off;
                        }
                        i++;

                    }
                    db_LoadAccessibility.Conn.Close();
                    db_LoadAccessibility.Conn.Dispose();
                    visibility.Dispose();
                }
                catch
                {
                    Error = new Alert.Alert("Error", "." + "مشکل در برقراری ارتباط با پایگاه داده");
                    Error.TopMost = true;
                    Error.Show();
                }
            }

        }

        private void btn_SaveRole_Click(object sender, EventArgs e)
        {
            try
            {
                MyDatabase db_SaveRole = new MyDatabase();
                db_SaveRole.Insert("Insert into role (rolename) values (N'" + combo_RoleName.Text + "') ");
               

                MyDatabase db_fillRole = new MyDatabase();
                List_Role.DataSource = db_fillRole.Select("select id, rolename from role ");

                List_Role.DisplayMember = "rolename";
                List_Role.ValueMember = "id";
                
                MyDatabase db_fillcomboRole = new MyDatabase();
                combo_RoleName.DataSource = db_fillcomboRole.Select("select id, rolename from role ");
                combo_RoleName.DisplayMember = "rolename";
                combo_RoleName.ValueMember = "id";
                combo_RoleName.SelectedIndex = -1;



                this.Alert_Accessibility.CaptionText = "توجه";
                this.Alert_Accessibility.ContentText = "." + "نقش مورد نظر با موفقیت ثبت شد";
                this.Alert_Accessibility.Popup.AlertElement.ContentElement.Font = new Font("B kamran", 16.0f);
                this.Alert_Accessibility.Popup.AlertElement.CaptionElement.TextAndButtonsElement.TextElement.Font = new Font("B kamran", 14.0f);

                this.Alert_Accessibility.Popup.AlertElement.ContentElement.TextAlignment = ContentAlignment.MiddleRight;
                this.Alert_Accessibility.Popup.AlertElement.CaptionElement.TextAndButtonsElement.TextAlignment = ContentAlignment.TopRight;
                Alert_Accessibility.Show();

                db_SaveRole.Conn.Close();
                db_SaveRole.Conn.Dispose();

                db_fillRole.Conn.Close();
                db_fillRole.Conn.Dispose();

                db_fillcomboRole.Conn.Close();
                db_fillcomboRole.Conn.Dispose();
            }
            catch
            {
                Error = new Alert.Alert("Error", "." + "مشکل در برقراری ارتباط با پایگاه داده");
                Error.TopMost = true;
                Error.Show();
            }
        }

        private void ckb_SelectAll_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            if (ckb_SelectAll.IsChecked == true)
            {
                List_AccessLevel.CheckAllItems();
                ckb_DeselectAll.IsChecked = false;
            }
                
        }

        private void ckb_DeselectAll_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            if (ckb_DeselectAll.IsChecked == true)
            {
                List_AccessLevel.UncheckAllItems();
                ckb_SelectAll.IsChecked = false;
            }
        }

    }
}
