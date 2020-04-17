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
    public partial class frm_AddProducts : RadForm
    {
        InputLanguage original;
        Alert.Alert error;
        bool flag = true;
        bool sizeflag = true;
        int catID;
        public frm_AddProducts()
        {
            InitializeComponent();
            this.ThemeName = "TelerikMetro";
        }

        private void frm_AddProducts_Load(object sender, EventArgs e)
        {
            combo_Products.NullText = "بعد از انتخاب دسته،نام محصول جدید را وارد کنید ";
            combo_Catagories.NullText = "نام دسته مورد نظر خود را وارد کنید";
            this.Text = "       "+"تعریف محصول" + "                  " + "کاربر:" + "   " + FrmLogin.FormUser;
           
            combo_Products.Enabled = false;
            combo_Size.Enabled = false;
            ckb_Size.Enabled = false;
            txt_Price.Enabled = false;
            btn_Save.Enabled = false;
            ckb_Size.Checked = false;
            this.txt_Price.MaskType = Telerik.WinControls.UI.MaskType.Numeric;
            this.txt_Price.Mask = "C";
            

            try
            {
                MyDatabase db_FillCombo = new MyDatabase();
                combo_Catagories.DataSource = db_FillCombo.Select("select * from catagories where isDeleted='false' or isDeleted is null ");
                combo_Catagories.DisplayMember = "name";
                combo_Catagories.ValueMember = "id";
                combo_Catagories.SelectedIndex = -1;

                if (combo_Catagories.Items.Count == 0)
                {
                    error = new Alert.Alert("Error", "." + "باید ابتدا دسته را وارد کنید");

                    error.TopMost = true;
                    error.BtnOk.Click += new EventHandler(btn_Ok_Click);

                    error.Show();
                    
                }
             
            }
            catch
            {
                //MessageBox.Show(ex.ToString());
                error = new Alert.Alert("Error", "." + "مشکل در برقراری ارتباط با پایگاه داده");
                error.TopMost = true;
                error.Show();
            }

        }

        void btn_Ok_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void combo_Products_Enter(object sender, EventArgs e)
        {
            original = InputLanguage.CurrentInputLanguage;
            var culture = System.Globalization.CultureInfo.GetCultureInfo("fa-IR");
            var language = InputLanguage.FromCulture(culture);
            if (InputLanguage.InstalledInputLanguages.IndexOf(language) >= 0)
                InputLanguage.CurrentInputLanguage = language;
            else
                InputLanguage.CurrentInputLanguage = InputLanguage.DefaultInputLanguage;

            
        
        }

        private void combo_Products_Leave(object sender, EventArgs e)
        {
            InputLanguage.CurrentInputLanguage = original;
        }

        private void combo_Catagories_TextChanged(object sender, EventArgs e)
        {
            combo_Catagories.DropDownListElement.AutoCompleteSuggest.SuggestMode = SuggestMode.Contains;
            if (combo_Catagories.Items.Contains(combo_Catagories.Text.Trim()))
            {
                combo_Products.Enabled = true;
                try
                {
                    MyDatabase db_find_catID = new MyDatabase();
                  
                    SqlDataReader dr;
                    dr = db_find_catID.Select("select id, name from catagories where name=N'" + combo_Catagories.Text + "'");
                    while (dr.Read())
                    {

                        if (dr[1].ToString() == combo_Catagories.Text)
                        {
                           
                            catID = Int32.Parse(dr[0].ToString());
                            break;

                        }



                    }
                     

                MyDatabase db_FillComboProducts = new MyDatabase();

                combo_Products.DataSource = db_FillComboProducts.Select("SELECT     dbo.products.name, dbo.products.id"
                                        +" FROM         dbo.products INNER JOIN"
                                        +" dbo.catagories ON dbo.products.cat_id = dbo.catagories.id"
                                        +" WHERE     (dbo.products.isDeleted = 0) AND (dbo.catagories.name = N'"+combo_Catagories.Text+"') OR"
                                        +" (dbo.products.isDeleted IS NULL)");


                combo_Products.DisplayMember = "name";
                combo_Products.ValueMember = "id";
                combo_Products.SelectedIndex = -1;

                db_FillComboProducts.Conn.Close();
                db_FillComboProducts.Conn.Dispose();
                    dr.Close();
                    db_find_catID.Conn.Close();
                    db_find_catID.Conn.Dispose();
                }
                catch
                {

                }


            }
            else
            {
                combo_Products.Enabled = false;
            }
        }

        private void txt_Size_Enter(object sender, EventArgs e)
        {
            original = InputLanguage.CurrentInputLanguage;
            var culture = System.Globalization.CultureInfo.GetCultureInfo("fa-IR");
            var language = InputLanguage.FromCulture(culture);
            if (InputLanguage.InstalledInputLanguages.IndexOf(language) >= 0)
                InputLanguage.CurrentInputLanguage = language;
            else
                InputLanguage.CurrentInputLanguage = InputLanguage.DefaultInputLanguage;
        }

        private void txt_Size_Leave(object sender, EventArgs e)
        {
            InputLanguage.CurrentInputLanguage = original;
        }

        private void txt_Price_Enter(object sender, EventArgs e)
        {
            original = InputLanguage.CurrentInputLanguage;
            var culture = System.Globalization.CultureInfo.GetCultureInfo("fa-IR");
            var language = InputLanguage.FromCulture(culture);
            if (InputLanguage.InstalledInputLanguages.IndexOf(language) >= 0)
                InputLanguage.CurrentInputLanguage = language;
            else
                InputLanguage.CurrentInputLanguage = InputLanguage.DefaultInputLanguage;
        }

        private void txt_Price_Leave(object sender, EventArgs e)
        {
            InputLanguage.CurrentInputLanguage = original;
        }

       

        private void ckb_Size_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            if (ckb_Size.Checked == true)
            {
               combo_Size.Enabled = true;
            }
            else
            {
                combo_Size.Enabled = false;
                combo_Size.Text = null;

            }
        }

        private void combo_Products_TextChanged(object sender, EventArgs e)
        {
            combo_Products.DropDownListElement.AutoCompleteSuggest.SuggestMode = SuggestMode.Contains;
            if (combo_Products.Text.Length > 0)
            {
              
                ckb_Size.Enabled = true;
                txt_Price.Enabled = true;
            }
            else
            {
               
                ckb_Size.Enabled = false;
                txt_Price.Enabled = false;
            }
            if (combo_Products.Items.Contains(combo_Products.Text.Trim()))
            {
                MyDatabase db_Fillckb_Size_Kind = new MyDatabase();

                SqlDataReader dr;
            dr = db_Fillckb_Size_Kind.Select("select size from products where name=N'" + combo_Products.Text + "'");
                while (dr.Read())
                {

                    if (dr[0].ToString() == null || dr[0].ToString() == "" )
                    {
                        flag = false;
                        break;

                    }
                    else
                        combo_Size.Text = dr[0].ToString();
                }
                if (flag)
                {
                    ckb_Size.Checked = true;
                    //combo_Size.Text = dr[0].ToString();
                }
                 



               
                dr.Close();
                db_Fillckb_Size_Kind.Conn.Close();
            }
         

        }

        private void combo_Size_Enter(object sender, EventArgs e)
        {
             original = InputLanguage.CurrentInputLanguage;
            var culture = System.Globalization.CultureInfo.GetCultureInfo("fa-IR");
            var language = InputLanguage.FromCulture(culture);
            if (InputLanguage.InstalledInputLanguages.IndexOf(language) >= 0)
                InputLanguage.CurrentInputLanguage = language;
            else
                InputLanguage.CurrentInputLanguage = InputLanguage.DefaultInputLanguage;

        }

        private void combo_Size_Leave(object sender, EventArgs e)
        {
              InputLanguage.CurrentInputLanguage = original;
        }

        private void combo_Size_TextChanged(object sender, EventArgs e)
        {
           combo_Size.DropDownListElement.AutoCompleteSuggest.SuggestMode = SuggestMode.Contains;
           if (combo_Size.Items.Contains(combo_Size.Text.Trim()))
           {
               //btn_Save.Enabled = true;
               txt_Price.Enabled = true;
               MyDatabase db_Fillckb_Size_Kind = new MyDatabase();

               SqlDataReader dr;
               dr = db_Fillckb_Size_Kind.Select("select size from products where name=N'" + combo_Products.Text + "'");
               while (dr.Read())
               {

                   if (dr[0].ToString() == combo_Size.Text)
                   {
                     
                       sizeflag = false;
                       break;

                   }
                   else
                       sizeflag = true;
                  


               }
               dr.Close();
               db_Fillckb_Size_Kind.Conn.Close();

           }
           else
           {
               if(ckb_Size.Checked)
                   txt_Price.Enabled = false;
               else
                   txt_Price.Enabled = true;
           }
        }

        private void txt_Price_TextChanged(object sender, EventArgs e)
        {
            if (Int32.Parse(txt_Price.Value.ToString()) > 0)
                btn_Save.Enabled = true;
            else
                btn_Save.Enabled = false;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            bool flagsave = true;
            try
            {
                MyDatabase db_Fillckb_Size_Kind = new MyDatabase();

                SqlDataReader dr;
                dr = db_Fillckb_Size_Kind.Select("select size, cat_id, name from products where name=N'" + combo_Products.Text + "'");
                while (dr.Read())
                {
                    if (ckb_Size.Checked == true)
                    {
                       
                        if ((dr[0].ToString() == combo_Size.Text) && dr[1].ToString() == catID.ToString() && dr[2].ToString() == combo_Products.Text)
                        {
                            error = new Alert.Alert("Error", "." + "نام محصول تکراری است");
                            error.TopMost = true;
                            error.Show();
                            flagsave = false;
                            break;
                        }
                    }
                    else
                    {
                       
                        if  (dr[1].ToString() == catID.ToString() && dr[2].ToString() == combo_Products.Text)
                        {

                            error = new Alert.Alert("Error", "." + "نام محصول تکراری است");
                            error.TopMost = true;
                            error.Show();
                            flagsave = false;
                            break;
                        }
                    }
                }

                db_Fillckb_Size_Kind.Conn.Close();
                db_Fillckb_Size_Kind.Conn.Dispose();
                dr.Close();
                dr.Dispose();

                if (flagsave)
                {
                    int a = (Int32.Parse(txt_Price.MaskedEditBoxElement.Value.ToString()) / 100);
                    MyDatabase db_save = new MyDatabase();
                    if (ckb_Size.Checked == true)
                    {
                        db_save.Insert("Insert into products (name,cat_id,isDeleted,price,size) values (N'" + combo_Products.Text + "'," +
                        "N'" + catID + "','false',N'" + a + "',N'" + combo_Size.Text.Trim() + "')");

                    }
                    else
                    {
                        db_save.Insert("Insert into products (name,cat_id,isDeleted,price) values (N'" + combo_Products.Text + "'," +
                                               "N'" + catID + "','false',N'" + a +"')");
                    }
                    this.AddProducts_Alert.CaptionText = "توجه";
                    this.AddProducts_Alert.ContentText = "." + "محصول مورد نظر با موفقیت ثبت شد";
                    this.AddProducts_Alert.Popup.AlertElement.ContentElement.Font = new Font("B kamran", 16.0f);
                    this.AddProducts_Alert.Popup.AlertElement.CaptionElement.TextAndButtonsElement.TextElement.Font = new Font("B kamran", 14.0f);

                    this.AddProducts_Alert.Popup.AlertElement.ContentElement.TextAlignment = ContentAlignment.MiddleRight;
                    this.AddProducts_Alert.Popup.AlertElement.CaptionElement.TextAndButtonsElement.TextAlignment = ContentAlignment.TopRight;
                    AddProducts_Alert.Show();
                }
                
            }
            catch
            {

                error = new Alert.Alert("Error", "." + "مشکل در برقراری ارتباط با پایگاه داده");
                error.TopMost = true;
                error.Show();
            }
        
           

             
        
        }
    
        

        private void combo_Catagories_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            if (combo_Catagories.Items.Contains(combo_Catagories.Text))
            {
                combo_Products.Enabled = true;
                try
                {
                    MyDatabase db_find_catID = new MyDatabase();

                    SqlDataReader dr;
                    dr = db_find_catID.Select("select id,name from catagories where name=N'" + combo_Catagories.Text + "'");
                    while (dr.Read())
                    {

                        if (dr[1].ToString() == combo_Catagories.Text)
                        {
                            catID = Int32.Parse(dr[0].ToString());
                            break;

                        }



                    }
                    dr.Close();
                    db_find_catID.Conn.Close();
                    db_find_catID.Conn.Dispose();
                }
                catch
                {

                }


            }
            else
            {
                combo_Products.Enabled = false;
            }
        }

    }
}
