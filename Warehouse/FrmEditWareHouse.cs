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
using Telerik.WinControls.UI.Localization;

namespace HomeCafe.Warehouse
{
    public partial class FrmEditWareHouse : Form
    {
        InputLanguage original;
        public RadForm Error;
        static Font font = new Font("B kamran", 14.0f, FontStyle.Bold);
        string _saveUpdator = FrmLogin.FormUser + "/" + "   " + "بروزرسانی";
        public int Vendorid;
        public FrmEditWareHouse()
        {
            InitializeComponent();
            RadGridLocalizationProvider.CurrentProvider = new MyPersianRadGridLocalizationProvider();
            Grid_WareHouse.ColumnChooser.Shown += ColumnChooser_Shown;
            txt_ExpDate.Culture = PersianCultureHelper.GetFixedPersianCulture();
            txt_ExpDate.DateTimePickerElement.Calendar.FocusedDate = DateTime.Now;
            txt_ExpDate.Value = DateTime.Today.AddDays(0);
            txt_PurchDate.Culture = PersianCultureHelper.GetFixedPersianCulture();
            txt_PurchDate.DateTimePickerElement.Calendar.FocusedDate = DateTime.Now;
            txt_PurchDate.Value = DateTime.Today.AddDays(0);
            txt_Expence.MaskType = MaskType.Numeric;
            txt_Expence.Mask = "C0";
            Font headerFont = new Font("B Kamran", 14.0f, FontStyle.Bold);
            Font datesFont = new Font("B Kamran", 14.0f, FontStyle.Bold);
            RadDateTimePickerCalendar calendarBehavior = txt_PurchDate.DateTimePickerElement.GetCurrentBehavior() as RadDateTimePickerCalendar;
            RadCalendar calendar = calendarBehavior.Calendar;
            RadCalendarElement calendarElement = calendar.CalendarElement;
            calendarElement.CalendarNavigationElement.Font = headerFont;
            MonthViewElement monthView = calendarBehavior.Calendar.CalendarElement.CalendarVisualElement as MonthViewElement;
            foreach (RadItem item in monthView.TableElement.Children)
            {
                item.Font = datesFont;

            }
            RadDateTimePickerCalendar calendarBehavior1 = txt_ExpDate.DateTimePickerElement.GetCurrentBehavior() as RadDateTimePickerCalendar;
            RadCalendar calendar1 = calendarBehavior1.Calendar;
            RadCalendarElement calendarElement1 = calendar1.CalendarElement;
            calendarElement1.CalendarNavigationElement.Font = headerFont;
            MonthViewElement monthView1 = calendarBehavior1.Calendar.CalendarElement.CalendarVisualElement as MonthViewElement;
            foreach (RadItem item in monthView1.TableElement.Children)
            {
                item.Font = datesFont;

            }
        }

        void ColumnChooser_Shown(object sender, EventArgs e)
        {
            Grid_WareHouse.ColumnChooser.ColumnChooserControl.ColumnChooserElement.Font = font;
        }

        private void btn_Weight_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            if (btn_Weight.IsChecked)
                panel_WeightUnit.Visible = true;
            else
                panel_WeightUnit.Visible = false;
        }

        private void frm_EditWareHouse_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'warehouse.View_1' table. You can move, or remove it, as needed.
            view_1TableAdapter.Fill(warehouse.View_1);
            try
            {
                MyDatabase dbFillvendor = new MyDatabase();
                combo_Vendor.DataSource = dbFillvendor.Select("select * from vendor where isDeleted='" + false + "' or isDeleted is NULL");
                combo_Vendor.DisplayMember = "name";
                combo_Vendor.ValueMember = "id";
                dbFillvendor.Conn.Close();
                dbFillvendor.Conn.Dispose();
                //MyDatabase db_fill_warehouse_grid = new MyDatabase();

                //Grid_WareHouse.DataSource = db_fill_warehouse_grid.Select("SELECT     dbo.warehouse_man.id, dbo.warehouse_man.name AS نام, dbo.warehouse_man.weight_count AS [وزن / تعداد], dbo.warehouse_man.per_date AS [تاریخ خرید], "
                //            +" dbo.warehouse_man.exp_date AS [تاریخ انقضا], dbo.warehouse_man.expence AS هزینه, dbo.warehouse_man.debt AS بدهی, "
                //            +"   dbo.warehouse_man.weight_unit AS [واحد وزن], dbo.vendor.name AS [تامین کننده] "
                //            +"    FROM         dbo.warehouse_man INNER JOIN"
                //             +"      dbo.vendor ON dbo.warehouse_man.vendor_id = dbo.vendor.id "
                //            + "   where dbo.warehouse_isDeleted='false' or  dbo.warehouse_isDeleted is null  ");
               
                if (Grid_WareHouse.Columns.Count > 0)
                {
                    txt_GoodsName.Text = Grid_WareHouse.CurrentRow.Cells[1].Value.ToString();
                    if (Grid_WareHouse.CurrentRow.Cells[7].Value.ToString() == "")
                    {
                        btn_Count.IsChecked = true;
                    }
                    else
                    {
                        btn_Weight.IsChecked = true;

                        if (Grid_WareHouse.CurrentRow.Cells[7].Value.ToString() == "کیلوگرم")
                        {
                            btn_Kgr.IsChecked = true;
                        }
                        else
                            btn_Gr.IsChecked = true;
                    }
                    txt_WeightCount.Text = Grid_WareHouse.CurrentRow.Cells[2].Value.ToString();
                    txt_PurchDate.Text = Grid_WareHouse.CurrentRow.Cells[3].Value.ToString();
                    txt_ExpDate.Text = Grid_WareHouse.CurrentRow.Cells[4].Value.ToString();
                    txt_Expence.Text = Grid_WareHouse.CurrentRow.Cells[5].Value.ToString();
                    ckb_Payed.Checked = Grid_WareHouse.CurrentRow.Cells[6].Value.Equals(true);
                    combo_Vendor.Text = Grid_WareHouse.CurrentRow.Cells[8].Value.ToString();

                    //Grid_WareHouse.Columns[0].IsVisible = false;
                    //Grid_WareHouse.Columns[0].VisibleInColumnChooser = false;

                    //Grid_WareHouse.Columns[1].TextAlignment = ContentAlignment.MiddleCenter;
                    //Grid_WareHouse.Columns[2].TextAlignment = ContentAlignment.MiddleCenter;
                    //Grid_WareHouse.Columns[3].TextAlignment = ContentAlignment.MiddleCenter;
                    //Grid_WareHouse.Columns[4].TextAlignment = ContentAlignment.MiddleCenter;
                    //Grid_WareHouse.Columns[5].TextAlignment = ContentAlignment.MiddleCenter;         
                    //Grid_WareHouse.Columns[6].TextAlignment = ContentAlignment.MiddleCenter;
                    //Grid_WareHouse.Columns[7].TextAlignment = ContentAlignment.MiddleCenter;

                    //Grid_WareHouse.BestFitColumns();

                    btn_Edit.Enabled = true;
                    btn_Delete.Enabled = true;
                }
                //db_fill_warehouse_grid.Conn.Close();
                //db_fill_warehouse_grid.Conn.Dispose();
            }
            catch
            {
                Error = new Alert.Alert("Error", "." + "مشکل در برقراری ارتباط با پایگاه داده") {TopMost = true};
                Error.Show();
            }
        }

        private void Grid_WareHouse_ColumnChooserItemElementCreating(object sender, ColumnChooserItemElementCreatingEventArgs e)
        {
            e.ItemElement.Font = font;
            e.GridViewElement.Font = font;
        }

        private void Grid_WareHouse_CreateCell(object sender, GridViewCreateCellEventArgs e)
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

        private void Grid_WareHouse_ConditionalFormattingFormShown(object sender, EventArgs e)
        {
            ConditionalFormattingForm form = (ConditionalFormattingForm)sender;
            SetFormFont(form.Controls);
        }
        static Font f = new Font("B kamran", 10.00f, FontStyle.Bold);
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

        private void Grid_WareHouse_ContextMenuOpening(object sender, ContextMenuOpeningEventArgs e)
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

        private void Grid_WareHouse_ViewCellFormatting(object sender, CellFormattingEventArgs e)
        {
            e.CellElement.Font = font;
        }

        private void Grid_WareHouse_SelectionChanged(object sender, EventArgs e)
        {
           
            try
            {
                txt_GoodsName.Text = Grid_WareHouse.CurrentRow.Cells[1].Value.ToString();
                if (Grid_WareHouse.CurrentRow.Cells[7].Value.ToString() == "")
                {
                    btn_Count.IsChecked = true;
                }
                else
                {
                    btn_Weight.IsChecked = true;

                    if (Grid_WareHouse.CurrentRow.Cells[7].Value.ToString() == "کیلوگرم")
                    {
                        btn_Kgr.IsChecked = true;
                    }
                    else
                        btn_Gr.IsChecked = true;
                }
                txt_WeightCount.Text = Grid_WareHouse.CurrentRow.Cells[2].Value.ToString();
                txt_PurchDate.Text = Grid_WareHouse.CurrentRow.Cells[3].Value.ToString();
                txt_ExpDate.Text = Grid_WareHouse.CurrentRow.Cells[4].Value.ToString();
                txt_Expence.Text = Grid_WareHouse.CurrentRow.Cells[5].Value.ToString();
                ckb_Payed.Checked = Grid_WareHouse.CurrentRow.Cells[6].Value.Equals(true);
                combo_Vendor.Text = Grid_WareHouse.CurrentRow.Cells[8].Value.ToString();

            }
            catch
            {
                if (Grid_WareHouse.Columns.Count == 0)
                {
                    Error = new Alert.Alert("Error", "." + "مشکل در برقراری ارتباط با پایگاه داده");
                    Error.TopMost = true;
                    Error.Show();
                }
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            
            string selectedunit;
           

            if (btn_Weight.IsChecked)
            {
                if (btn_Gr.IsChecked)
                    selectedunit = "گرم";
                else
                    selectedunit = "کیلوگرم";
            }
            else
                selectedunit = null;
            int a=(Int32.Parse(txt_Expence.MaskedEditBoxElement.Value.ToString())/100);
            


            
            try
            {
                MyDatabase dbUpdate = new MyDatabase();
                dbUpdate.Update("update warehouse_man set name = N'"+ txt_GoodsName.Text + "' , weight_count = N'" + txt_WeightCount.Text + "' , exp_date = N'" + txt_ExpDate.Text + "' , per_date = N'" + txt_PurchDate.Text + "' ,"
                   + "expence = N'" + a + "' , debt =N'" + ckb_Payed.Checked + "' , vendor_id=N'"+Vendorid+"', weight_unit = N'" + selectedunit + "'  ,username =  N'" + _saveUpdator + "' where id='" + Int32.Parse(Grid_WareHouse.CurrentRow.Cells[0].Value.ToString()) + "' ");
              
                EditWareHouse_Alert.CaptionText = "توجه";
                EditWareHouse_Alert.ContentText = "." + "اطلاعات با موفقیت اصلاح شد";
                EditWareHouse_Alert.Popup.AlertElement.ContentElement.Font = new Font("B kamran", 16.0f);
                EditWareHouse_Alert.Popup.AlertElement.CaptionElement.TextAndButtonsElement.TextElement.Font = new Font("B kamran", 14.0f);

                EditWareHouse_Alert.Popup.AlertElement.ContentElement.TextAlignment = ContentAlignment.MiddleRight;
                EditWareHouse_Alert.Popup.AlertElement.CaptionElement.TextAndButtonsElement.TextAlignment = ContentAlignment.TopRight;
               

                EditWareHouse_Alert.Show();
                
               
                
                dbUpdate.Conn.Close();
                dbUpdate.Conn.Dispose();
                view_1TableAdapter.Fill(warehouse.View_1);
                //MyDatabase db_update_warehouse_grid = new MyDatabase();

                //Grid_WareHouse.DataSource = db_update_warehouse_grid.Select("SELECT     dbo.warehouse_man.id, dbo.warehouse_man.name AS نام, dbo.warehouse_man.weight_count AS [وزن / تعداد], dbo.warehouse_man.per_date AS [تاریخ خرید], "
                //            +" dbo.warehouse_man.exp_date AS [تاریخ انقضا], dbo.warehouse_man.expence AS هزینه, dbo.warehouse_man.debt AS بدهی, "
                //            +"   dbo.warehouse_man.weight_unit AS [واحد وزن], dbo.vendor.name AS [تامین کننده] "
                //            +"    FROM         dbo.warehouse_man INNER JOIN"
                //             +"      dbo.vendor ON dbo.warehouse_man.vendor_id = dbo.vendor.id "
                //            + "   where dbo.warehouse_isDeleted='false' or  dbo.warehouse_isDeleted is null  ");

                if (Grid_WareHouse.Columns.Count > 0)
                {


                    //Grid_WareHouse.Columns[0].IsVisible = false;
                    //Grid_WareHouse.Columns[0].VisibleInColumnChooser = false;

                    //Grid_WareHouse.Columns[1].TextAlignment = ContentAlignment.MiddleCenter;
                    //Grid_WareHouse.Columns[2].TextAlignment = ContentAlignment.MiddleCenter;
                    //Grid_WareHouse.Columns[3].TextAlignment = ContentAlignment.MiddleCenter;
                    //Grid_WareHouse.Columns[4].TextAlignment = ContentAlignment.MiddleCenter;
                    //Grid_WareHouse.Columns[5].TextAlignment = ContentAlignment.MiddleCenter;
                    //Grid_WareHouse.Columns[6].TextAlignment = ContentAlignment.MiddleCenter;
                    //Grid_WareHouse.Columns[7].TextAlignment = ContentAlignment.MiddleCenter;

                    //Grid_WareHouse.BestFitColumns();

                    btn_Edit.Enabled = true;
                    btn_Delete.Enabled = true;
                }
                //db_update_warehouse_grid.Conn.Close();
                //db_update_warehouse_grid.Conn.Dispose();

            }
            catch
            {
                //MessageBox.Show("1");
                Error = new Alert.Alert("Error", "." + "مشکل در برقراری ارتباط با پایگاه داده") {TopMost = true};
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

        private void txt_GoodsName_TextChanged(object sender, EventArgs e)
        {
            if (txt_GoodsName.Text.Length > 0 && txt_WeightCount.Text.Length > 0 && txt_Expence.Text.Length > 0 && txt_PurchDate.Text.Length > 0 && txt_ExpDate.Text.Length > 0)
                btn_Edit.Enabled = true;
            else
                btn_Edit.Enabled = false;
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
            if (!(char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                e.Handled = true;
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
                btn_Edit.Enabled = true;
            else
                btn_Edit.Enabled = false;
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
          _saveUpdator = FrmLogin.FormUser + "/" + "   " + "حذف";
            try
            {
                var dbDelete = new MyDatabase();
                dbDelete.Update("update warehouse_man  set isDeleted='true', username=N'" + _saveUpdator + "' where id= N'" + Int32.Parse(Grid_WareHouse.CurrentRow.Cells[0].Value.ToString()) + "'");
                
                EditWareHouse_Alert.CaptionText = "توجه";
                EditWareHouse_Alert.ContentText = "." + "ماده مورد نظر با موفقیت حذف شد";
                EditWareHouse_Alert.Popup.AlertElement.ContentElement.Font = new Font("B kamran", 16.0f);
                EditWareHouse_Alert.Popup.AlertElement.CaptionElement.TextAndButtonsElement.TextElement.Font = new Font("B kamran", 14.0f);

                EditWareHouse_Alert.Popup.AlertElement.ContentElement.TextAlignment = ContentAlignment.MiddleRight;
                EditWareHouse_Alert.Popup.AlertElement.CaptionElement.TextAndButtonsElement.TextAlignment = ContentAlignment.TopRight;


                EditWareHouse_Alert.Show();

                dbDelete.Conn.Close();
                dbDelete.Conn.Dispose();
                view_1TableAdapter.Fill(warehouse.View_1);
               // MyDatabase db_update_warehouse_grid = new MyDatabase();

               // Grid_WareHouse.DataSource = db_update_warehouse_grid.Select("SELECT     id, name AS نام, weight_count AS [وزن / تعداد], per_date AS [تاریخ خرید], exp_date AS [تاریخ انقضا],"
               //+ "expence AS هزینه, debt AS بدهی, weight_unit AS [واحد وزن] FROM         dbo.warehouse_man where isDeleted='false' or isDeleted is null  ");

                if (Grid_WareHouse.Columns.Count > 0)
                {


                    //Grid_WareHouse.Columns[0].IsVisible = false;
                    //Grid_WareHouse.Columns[0].VisibleInColumnChooser = false;

                    //Grid_WareHouse.Columns[1].TextAlignment = ContentAlignment.MiddleCenter;
                    //Grid_WareHouse.Columns[2].TextAlignment = ContentAlignment.MiddleCenter;
                    //Grid_WareHouse.Columns[3].TextAlignment = ContentAlignment.MiddleCenter;
                    //Grid_WareHouse.Columns[4].TextAlignment = ContentAlignment.MiddleCenter;
                    //Grid_WareHouse.Columns[5].TextAlignment = ContentAlignment.MiddleCenter;
                    //Grid_WareHouse.Columns[6].TextAlignment = ContentAlignment.MiddleCenter;
                    //Grid_WareHouse.Columns[].TextAlignment = ContentAlignment.MiddleCenter;

                    //Grid_WareHouse.BestFitColumns();

                    btn_Edit.Enabled = true;
                    btn_Delete.Enabled = true;
                }
                //db_update_warehouse_grid.Conn.Close();
                //db_update_warehouse_grid.Conn.Dispose();
            }
            catch
            {
                Error = new Alert.Alert("Error", "." + "مشکل در برقراری ارتباط با پایگاه داده");
                Error.TopMost = true;
                Error.Show();
            }
        }

        private void Grid_WareHouse_GroupSummaryEvaluate(object sender, GroupSummaryEvaluationEventArgs e)
        {
            if (e.Value == null || (string) e.Value == @"")
            {
                e.Value = "فاقد وزن";
            }
            e.FormatString = string.Format("{0}", e.Value);
        }

        private void combo_Vendor_TextChanged(object sender, EventArgs e)
        {
            combo_Vendor.DropDownListElement.AutoCompleteSuggest.SuggestMode = SuggestMode.Contains;
            if (combo_Vendor.Items.Contains(combo_Vendor.Text.Trim()))
            {
                try
                {
                    MyDatabase db_findid = new MyDatabase();
                    SqlDataReader dr = db_findid.Select("select id from vendor where name=N'" + combo_Vendor.Text.Trim() + "'");
                    while (dr.Read())
                    {
                        Vendorid = Int32.Parse(dr[0].ToString());
                    }
                    db_findid.Conn.Close();
                    db_findid.Conn.Dispose();
                    dr.Close();
                    dr.Dispose();


                    btn_Edit.Enabled = true;

                }
                catch
                {

                    Error = new Alert.Alert("Error", "." + "مشکل در برقراری ارتباط با پایگاه داده");
                    Error.TopMost = true;
                    Error.Show();
                }
            

            }
            else
                btn_Delete.Enabled = false;
        }



 

    }
}
