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
using HomeCafe.My_Custom_Classes;
using Telerik.WinControls.UI;
using Telerik.WinControls.UI.Localization;
using Telerik.WinControls;

namespace HomeCafe.Setting
{
    public partial class frm_EditDeleteProducts : Form
    {
        InputLanguage original;
        Alert.Alert Error;
        bool flag = true;
        bool sizeflag = true;
        int catID;
        
        static Font font = new Font("B kamran", 14.0f);
        string save_updator = FrmLogin.FormUser + "/" + "   " + "بروزرسانی";
        public frm_EditDeleteProducts()
        {
            InitializeComponent();
            RadGridLocalizationProvider.CurrentProvider = new MyPersianRadGridLocalizationProvider();
            Grid_EditDeleteProducts.ColumnChooser.Shown += new EventHandler(ColumnChooser_Shown);
            this.Grid_EditDeleteProducts.MasterTemplate.AutoExpandGroups = true;
            this.txt_Price.MaskType = Telerik.WinControls.UI.MaskType.Numeric;
            this.txt_Price.Mask = "C";
            Grid_EditDeleteProducts.Font = font;
        }

        void ColumnChooser_Shown(object sender, EventArgs e)
        {
            this.Grid_EditDeleteProducts.ColumnChooser.ColumnChooserControl.ColumnChooserElement.Font = font;
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

        private void combo_Catagories_TextChanged(object sender, EventArgs e)
        {
            combo_Catagories.DropDownListElement.AutoCompleteSuggest.SuggestMode = SuggestMode.Contains;
            if (combo_Catagories.Items.Contains(combo_Catagories.Text))
            {
                combo_Products.Enabled = true;
                btn_Edit.Enabled = true;
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

                    MyDatabase db_FillComboProducts = new MyDatabase();

                    combo_Products.DataSource = db_FillComboProducts.Select("select id,name from products where (isDeleted='false' or isDeleted is null) and cat_id=N'" + catID + "' ");


                    combo_Products.DisplayMember = "name";
                    combo_Products.ValueMember = "id";


                    db_FillComboProducts.Conn.Close();
                    db_FillComboProducts.Conn.Dispose();
                }
                catch
                {

                }
            }
            else
            {
                combo_Products.Enabled = false;
                btn_Edit.Enabled = false;
            }
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

        private void combo_Products_TextChanged(object sender, EventArgs e)
        {
            combo_Products.DropDownListElement.AutoCompleteSuggest.SuggestMode = SuggestMode.Contains;
            if (combo_Products.Text.Length > 0)
            {

                //ckb_Size.Enabled = true;
                txt_Price.Enabled = true;
            }
            else
            {
                //ckb_Size.Enabled = false;
                txt_Price.Enabled = false;
            }
            if (combo_Products.Items.Contains(combo_Products.Text))
            {
               
            }
        }

        private void frm_EditDeleteProducts_Load(object sender, EventArgs e)
        {
            combo_Products.Enabled = false;
            combo_Size.Enabled = false;
            ckb_Size.Enabled = false;
            txt_Price.Enabled = false;
            btn_Edit.Enabled = false;
            btn_Delete.Enabled = false;
            ckb_Size.Checked = false;
            this.txt_Price.MaskType = Telerik.WinControls.UI.MaskType.Numeric;
            this.txt_Price.Mask = "C";
            try
            {
                MyDatabase db_FillGrid = new MyDatabase();
                Grid_EditDeleteProducts.DataSource = db_FillGrid.Select("SELECT dbo.products.id, dbo.catagories.name AS [نام دسته],"+
                    " dbo.products.name AS [نام محصول], dbo.products.cat_id, dbo.products.price AS قیمت, dbo.products.isDeleted, "
                  + "  dbo.products.size AS سایز FROM dbo.products INNER JOIN   dbo.catagories ON dbo.products.cat_id = dbo.catagories.id where dbo.products.isDeleted='false' or dbo.products.isDeleted is null ");
                if (Grid_EditDeleteProducts.Columns.Count > 0)
                {


                    Grid_EditDeleteProducts.Columns[0].IsVisible = false;
                    Grid_EditDeleteProducts.Columns[0].VisibleInColumnChooser = false;
                    Grid_EditDeleteProducts.Columns[3].IsVisible = false;
                    Grid_EditDeleteProducts.Columns[3].VisibleInColumnChooser = false;
                    Grid_EditDeleteProducts.Columns[5].IsVisible = false;
                    Grid_EditDeleteProducts.Columns[5].VisibleInColumnChooser = false;

                    Grid_EditDeleteProducts.Columns[1].TextAlignment = ContentAlignment.MiddleCenter;
                    Grid_EditDeleteProducts.Columns[2].TextAlignment = ContentAlignment.MiddleCenter;
                    Grid_EditDeleteProducts.Columns[4].TextAlignment = ContentAlignment.MiddleCenter;
                    Grid_EditDeleteProducts.Columns[6].TextAlignment = ContentAlignment.MiddleCenter;


                    combo_Catagories.Text = Grid_EditDeleteProducts.CurrentRow.Cells[1].Value.ToString();
                    combo_Products.Text = Grid_EditDeleteProducts.CurrentRow.Cells[2].Value.ToString();
                    txt_Price.Text = Grid_EditDeleteProducts.CurrentRow.Cells[4].Value.ToString();
                    combo_Size.Text = Grid_EditDeleteProducts.CurrentRow.Cells[6].Value.ToString();
                    if (combo_Size.Text == "")
                    {
                        ckb_Size.Checked = false;
                        //combo_Size.Enabled = true;
                    }
                    else
                    {
                        ckb_Size.Checked = true;
                        ckb_Size.Enabled = true;
                    }


                    btn_Delete.Enabled = true;
                    btn_Edit.Enabled = true;
                }


                MyDatabase db_FillCombo = new MyDatabase();
                combo_Catagories.DataSource = db_FillCombo.Select("select * from catagories where isDeleted='false' or isDeleted is null ");
                combo_Catagories.DisplayMember = "name";
                combo_Catagories.ValueMember = "id";
              

                if (combo_Catagories.Items.Count == 0)
                {
                    Error = new Alert.Alert("Error", "." + "باید ابتدا دسته را وارد کنید");

                    Error.TopMost = true;
                    Error.BtnOk.Click += new EventHandler(btn_Ok_Click);

                    Error.Show();

                }
                db_FillCombo.Conn.Close();
                db_FillCombo.Conn.Dispose();

                MyDatabase db_FillComboProducts = new MyDatabase();

                combo_Products.DataSource = db_FillComboProducts.Select("select id,name from products where (isDeleted='false' or isDeleted is null) and cat_id=N'"+catID+"' ");


                combo_Products.DisplayMember = "name";
                combo_Products.ValueMember = "id";
              

                db_FillComboProducts.Conn.Close();
                db_FillComboProducts.Conn.Dispose();

                if (combo_Size.Items.Contains(combo_Size.Text))
                {
                    btn_Edit.Enabled = true;
                }
                else
                {
                    btn_Edit.Enabled = false;
                }
            }
            catch 
            {
                //MessageBox.Show(ex.ToString());
                Error = new Alert.Alert("Error", "." + "مشکل در برقراری ارتباط با پایگاه داده");
                Error.TopMost = true;
                Error.Show();
            }
        }

        void btn_Ok_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Grid_EditDeleteProducts_ColumnChooserItemElementCreating(object sender, ColumnChooserItemElementCreatingEventArgs e)
        {
            e.ItemElement.Font = font;
            e.GridViewElement.Font = font;
        }

        private void Grid_EditDeleteProducts_ConditionalFormattingFormShown(object sender, EventArgs e)
        {
            ConditionalFormattingForm form = (ConditionalFormattingForm)sender;
            SetFormFont(form.Controls);
        }
        static Font f = new Font("B kamran", 10.00f);
        private void SetFormFont(Control.ControlCollection controls)
        {
            foreach (Control c in controls)
            {
                c.Font = f;
                if (c.HasChildren)
                {
                    SetFormFont(c.Controls);
                }
            }
        }

        private void Grid_EditDeleteProducts_ContextMenuOpening(object sender, ContextMenuOpeningEventArgs e)
        {
            for (int i = 0; i < e.ContextMenu.Items.Count; i++)
            {
                e.ContextMenu.Items[i].Font = font;

                if (e.ContextMenu.Items[i].Text == "حالت متصل شده")
                {
                    e.ContextMenu.Items[i].Visibility = ElementVisibility.Collapsed;
                }

            }
        }

        private void Grid_EditDeleteProducts_CreateCell(object sender, GridViewCreateCellEventArgs e)
        {
            if (e.CellType == typeof(GridHeaderCellElement))
            {
                e.CellType = typeof(CustomHeaderCell);
            }
            if (e.CellType == typeof(GridHeaderCellElement))
            {

                e.CellType = typeof(CustomGridHeaderCellElement);

            }
        }

        private void Grid_EditDeleteProducts_ViewCellFormatting(object sender, CellFormattingEventArgs e)
        {
            e.CellElement.Font = font;
        }

        private void Grid_EditDeleteProducts_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                combo_Catagories.Text = Grid_EditDeleteProducts.CurrentRow.Cells[1].Value.ToString();
                combo_Products.Text = Grid_EditDeleteProducts.CurrentRow.Cells[2].Value.ToString();
                txt_Price.Text = Grid_EditDeleteProducts.CurrentRow.Cells[4].Value.ToString();
                if (Grid_EditDeleteProducts.CurrentRow.Cells[6].Value.ToString() != "" || Grid_EditDeleteProducts.CurrentRow.Cells[6].Value.ToString() != null)
                    combo_Size.Text = Grid_EditDeleteProducts.CurrentRow.Cells[6].Value.ToString();
                else
                {
                    combo_Size.Text = "";
                    ckb_Size.Checked = false;

                }
                    


                if (combo_Size.Text == "")
                {
                    ckb_Size.Checked = false;
                    //combo_Size.Enabled = true;
                }
                else
                {
                    ckb_Size.Checked = true;
                    ckb_Size.Enabled = true;
                }

            }
            catch
            {
              
                Error = new Alert.Alert("Error", "." + "مشکل در برقراری ارتباط با پایگاه داده");
                Error.TopMost = true;
                Error.Show();
            }
        }

        private void Grid_EditDeleteProducts_GroupSummaryEvaluate(object sender, GroupSummaryEvaluationEventArgs e)
        {
            if (e.Value == null )
            {
                e.Value = "فاقد سایز";
            }
            e.FormatString = String.Format("{0}", e.Value);
           
        }

        private void ckb_Size_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            if (ckb_Size.Checked == true)
            {
                combo_Size.Enabled = true;
                combo_Size.SelectedIndex = 1;
            }
            else
            {
                combo_Size.Enabled = false;
                combo_Size.Text = "";
                combo_Size.NullText = "درصورت داشتن سایز از این قسمت استفاده کنید"+".";
                btn_Edit.Enabled = true;
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            int a = (Int32.Parse(txt_Price.MaskedEditBoxElement.Value.ToString()) / 100);
            try
            {
                MyDatabase db_update = new MyDatabase();
                db_update.Update("update products set name=N'" + combo_Products.Text + "',price=N'"+a+"',size=N'"+combo_Size.Text+"',cat_id=N'"+catID+"' where id='"+Int32.Parse(Grid_EditDeleteProducts.CurrentRow.Cells[0].Value.ToString())+"' ");
                this.Alert_EditDeleteProducts.CaptionText = "توجه";
                this.Alert_EditDeleteProducts.ContentText = "." + "محصول مورد نظر با موفقیت اصلاح شد";
                this.Alert_EditDeleteProducts.Popup.AlertElement.ContentElement.Font = new Font("B kamran", 16.0f);
                this.Alert_EditDeleteProducts.Popup.AlertElement.CaptionElement.TextAndButtonsElement.TextElement.Font = new Font("B kamran", 14.0f);

                this.Alert_EditDeleteProducts.Popup.AlertElement.ContentElement.TextAlignment = ContentAlignment.MiddleRight;
                this.Alert_EditDeleteProducts.Popup.AlertElement.CaptionElement.TextAndButtonsElement.TextAlignment = ContentAlignment.TopRight;
                Alert_EditDeleteProducts.Show();

                db_update.Conn.Close();
                db_update.Conn.Dispose();

                MyDatabase db_FillGrid = new MyDatabase();
                Grid_EditDeleteProducts.DataSource = db_FillGrid.Select("SELECT dbo.products.id, dbo.catagories.name AS [نام دسته]," +
                    " dbo.products.name AS [نام محصول], dbo.products.cat_id, dbo.products.price AS قیمت, dbo.products.isDeleted, "
                  + "  dbo.products.size AS سایز FROM dbo.products INNER JOIN   dbo.catagories ON dbo.products.cat_id = dbo.catagories.id where dbo.products.isDeleted='false' or dbo.products.isDeleted is null ");
                if (Grid_EditDeleteProducts.Columns.Count > 0)
                {


                    Grid_EditDeleteProducts.Columns[0].IsVisible = false;
                    Grid_EditDeleteProducts.Columns[0].VisibleInColumnChooser = false;
                    Grid_EditDeleteProducts.Columns[3].IsVisible = false;
                    Grid_EditDeleteProducts.Columns[3].VisibleInColumnChooser = false;
                    Grid_EditDeleteProducts.Columns[5].IsVisible = false;
                    Grid_EditDeleteProducts.Columns[5].VisibleInColumnChooser = false;

                    Grid_EditDeleteProducts.Columns[1].TextAlignment = ContentAlignment.MiddleCenter;
                    Grid_EditDeleteProducts.Columns[2].TextAlignment = ContentAlignment.MiddleCenter;
                    Grid_EditDeleteProducts.Columns[4].TextAlignment = ContentAlignment.MiddleCenter;
                    Grid_EditDeleteProducts.Columns[6].TextAlignment = ContentAlignment.MiddleCenter;


                    combo_Catagories.Text = Grid_EditDeleteProducts.CurrentRow.Cells[1].Value.ToString();
                    combo_Products.Text = Grid_EditDeleteProducts.CurrentRow.Cells[2].Value.ToString();
                    txt_Price.Text = Grid_EditDeleteProducts.CurrentRow.Cells[4].Value.ToString();
                    combo_Size.Text = Grid_EditDeleteProducts.CurrentRow.Cells[6].Value.ToString();
                    if (combo_Size.Text == "")
                    {
                        ckb_Size.Checked = false;
                        //combo_Size.Enabled = true;
                    }
                    else
                    {
                        ckb_Size.Checked = true;
                        ckb_Size.Enabled = true;
                    }


                    btn_Delete.Enabled = true;
                    btn_Edit.Enabled = true;

                    db_FillGrid.Conn.Close();
                    db_FillGrid.Conn.Dispose();
                }
            }
            catch
            {
                Error = new Alert.Alert("Error", "." + "مشکل در برقراری ارتباط با پایگاه داده");
                Error.TopMost = true;
                Error.Show();
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
            if (combo_Size.Items.Contains(combo_Size.Text))
            {
                btn_Edit.Enabled = true;
                sizeflag = true;
            }
            else
            {
                btn_Edit.Enabled = false;
            }
            if (sizeflag)
            {
                try
                {
                    
                    
                    MyDatabase db_search = new MyDatabase();
                    SqlDataReader dr_search = db_search.Select("select size from products where name=N'" + combo_Products.Text + "' and cat_id=N'"+catID+"' ");
                    while (dr_search.Read())
                    {
                        if (dr_search[0].ToString() == combo_Size.Text)
                        {
                            btn_Edit.Enabled = false;
                            break;
                        }
                    }
                    db_search.Conn.Close();
                    db_search.Conn.Dispose();
                    dr_search.Close();
                }
                catch
                {
                    Error = new Alert.Alert("Error", "." + "مشکل در برقراری ارتباط با پایگاه داده");
                    Error.TopMost = true;
                    Error.Show();
                }
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                MyDatabase db_update = new MyDatabase();
                db_update.Update("update products set isDeleted=N'true' where id='" + Int32.Parse(Grid_EditDeleteProducts.CurrentRow.Cells[0].Value.ToString()) + "' ");
                this.Alert_EditDeleteProducts.CaptionText = "توجه";
                this.Alert_EditDeleteProducts.ContentText = "." + "محصول مورد نظر حذف شد";
                this.Alert_EditDeleteProducts.Popup.AlertElement.ContentElement.Font = new Font("B kamran", 16.0f);
                this.Alert_EditDeleteProducts.Popup.AlertElement.CaptionElement.TextAndButtonsElement.TextElement.Font = new Font("B kamran", 14.0f);

                this.Alert_EditDeleteProducts.Popup.AlertElement.ContentElement.TextAlignment = ContentAlignment.MiddleRight;
                this.Alert_EditDeleteProducts.Popup.AlertElement.CaptionElement.TextAndButtonsElement.TextAlignment = ContentAlignment.TopRight;
                Alert_EditDeleteProducts.Show();

                db_update.Conn.Close();
                db_update.Conn.Dispose();

                MyDatabase db_FillGrid = new MyDatabase();
                Grid_EditDeleteProducts.DataSource = db_FillGrid.Select("SELECT dbo.products.id, dbo.catagories.name AS [نام دسته]," +
                    " dbo.products.name AS [نام محصول], dbo.products.cat_id, dbo.products.price AS قیمت, dbo.products.isDeleted, "
                  + "  dbo.products.size AS سایز FROM dbo.products INNER JOIN   dbo.catagories ON dbo.products.cat_id = dbo.catagories.id where dbo.products.isDeleted='false' or dbo.products.isDeleted is null ");
                if (Grid_EditDeleteProducts.Columns.Count > 0)
                {


                    Grid_EditDeleteProducts.Columns[0].IsVisible = false;
                    Grid_EditDeleteProducts.Columns[0].VisibleInColumnChooser = false;
                    Grid_EditDeleteProducts.Columns[3].IsVisible = false;
                    Grid_EditDeleteProducts.Columns[3].VisibleInColumnChooser = false;
                    Grid_EditDeleteProducts.Columns[5].IsVisible = false;
                    Grid_EditDeleteProducts.Columns[5].VisibleInColumnChooser = false;

                    Grid_EditDeleteProducts.Columns[1].TextAlignment = ContentAlignment.MiddleCenter;
                    Grid_EditDeleteProducts.Columns[2].TextAlignment = ContentAlignment.MiddleCenter;
                    Grid_EditDeleteProducts.Columns[4].TextAlignment = ContentAlignment.MiddleCenter;
                    Grid_EditDeleteProducts.Columns[6].TextAlignment = ContentAlignment.MiddleCenter;


                    combo_Catagories.Text = Grid_EditDeleteProducts.CurrentRow.Cells[1].Value.ToString();
                    combo_Products.Text = Grid_EditDeleteProducts.CurrentRow.Cells[2].Value.ToString();
                    txt_Price.Text = Grid_EditDeleteProducts.CurrentRow.Cells[4].Value.ToString();
                    combo_Size.Text = Grid_EditDeleteProducts.CurrentRow.Cells[6].Value.ToString();
                    if (combo_Size.Text == "")
                    {
                        ckb_Size.Checked = false;
                        //combo_Size.Enabled = true;
                    }
                    else
                    {
                        ckb_Size.Checked = true;
                        ckb_Size.Enabled = true;
                    }


                    btn_Delete.Enabled = true;
                    btn_Edit.Enabled = true;

                    db_FillGrid.Conn.Close();
                    db_FillGrid.Conn.Dispose();
                }
            }
            catch
            {
                Error = new Alert.Alert("Error", "." + "مشکل در برقراری ارتباط با پایگاه داده");
                Error.TopMost = true;
                Error.Show();
            }
        }

        private void txt_Price_TextChanged(object sender, EventArgs e)
        {
            if (txt_Price.Text.Trim().Length > 0)
            {
                btn_Edit.Enabled = true;
            }
            else
            {
                btn_Edit.Enabled = false;
            }

        }

    }
}
