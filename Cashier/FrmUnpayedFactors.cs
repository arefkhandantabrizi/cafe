using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using HomeCafe.DataBase;
using HomeCafe.My_Custom_Classes;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using Telerik.WinControls.UI.Localization;

namespace HomeCafe.Cashier
{
    public partial class FrmUnpayedFactors : Form
    {
        Alert.Alert _error;
        private readonly Font _font = new Font("IRANSansDNFaNum", 10.0f, FontStyle.Regular);
        public FrmUnpayedFactors()
        {
            InitializeComponent();
            RadGridLocalizationProvider.CurrentProvider = new MyPersianRadGridLocalizationProvider();
            GridInvoice.ColumnChooser.Shown += ColumnChooser_Shown;
            GridItems.ShowNoDataText = false;
            
        }

        private void ColumnChooser_Shown(object sender, EventArgs e)
        {
            GridInvoice.ColumnChooser.ColumnChooserControl.ColumnChooserElement.Font = _font;
        }

        private void frm_UnpayedFactors_Load(object sender, EventArgs e)
        {
            btn_CheckOut.Enabled = false;
            try
            {
                unpayedfactorsTableAdapter1.Fill(cafeDataSet1.unpayedfactors);

                if (GridInvoice.RowCount > 0)
                {
                    var result = new Items(new MyDatabase())
                    {
                        InvoiceId = Convert.ToInt32(GridInvoice.CurrentRow.Cells[5].Value.ToString())
                    };
                    GridItems.DataSource = result.FillItemGrid();

                    if (GridItems.RowCount <= 0) return;

                    FormatGridItem();

                    btn_Delete.Enabled = true;
                    btn_Print.Enabled = true;
                    GridItems.Enabled = true;
                }
                else
                {
                    btn_CheckOut.Enabled = false;
                    btn_Delete.Enabled = false;
                    btn_Print.Enabled = false;
                    GridItems.Enabled = false;
                }


            }
            catch
            {
                _error = new Alert.Alert("Error", "." + "مشکل در برقراری ارتباط با پایگاه داده") {TopMost = true};
                _error.Show();
            }
        }

        private void GridInvoice_CellFormatting(object sender, CellFormattingEventArgs e)
        {
            e.CellElement.Font = _font;
        }

        private void GridInvoice_ColumnChooserItemElementCreating(object sender, ColumnChooserItemElementCreatingEventArgs e)
        {
            e.ItemElement.Font = _font;
            e.GridViewElement.Font = _font;
        }

        private void GridInvoice_ConditionalFormattingFormShown(object sender, EventArgs e)
        {
            ConditionalFormattingForm form = (ConditionalFormattingForm)sender;
            SetFormFont(form.Controls);
        }
        private readonly Font _f = new Font("IRANSansDNFaNum", 9.00f, FontStyle.Regular);
        private void SetFormFont(Control.ControlCollection controls)
        {
            foreach (Control c in controls)
            {
                c.Font = _f;
                if (c.HasChildren)
                {
                    SetFormFont(c.Controls);
                }
            }

        
        }

        private void GridInvoice_ContextMenuOpening(object sender, ContextMenuOpeningEventArgs e)
        {
            for (int i = 0; i < e.ContextMenu.Items.Count; i++)
            {
                e.ContextMenu.Items[i].Font = _font;

                if (e.ContextMenu.Items[i].Text == @"حالت متصل شده")
                {
                    e.ContextMenu.Items[i].Visibility = ElementVisibility.Collapsed;
                }

            }
        }

        private void GridInvoice_CreateCell(object sender, GridViewCreateCellEventArgs e)
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

        private void GridInvoice_ViewCellFormatting(object sender, CellFormattingEventArgs e)
        {
            e.CellElement.Font = _font;
        }

        private void GridItems_CellFormatting(object sender, CellFormattingEventArgs e)
        {
            e.CellElement.Font = _font;
        }

        private void GridItems_ColumnChooserItemElementCreating(object sender, ColumnChooserItemElementCreatingEventArgs e)
        {
            e.ItemElement.Font = _font;
            e.GridViewElement.Font = _font;
        }

        private void GridItems_ConditionalFormattingFormShown(object sender, EventArgs e)
        {
            var form = (ConditionalFormattingForm)sender;
            SetFormFont(form.Controls);
        }

        private void GridItems_ContextMenuOpening(object sender, ContextMenuOpeningEventArgs e)
        {
            for (var i = 0; i < e.ContextMenu.Items.Count; i++)
            {
                e.ContextMenu.Items[i].Font = _font;

                if (e.ContextMenu.Items[i].Text == @"حالت متصل شده")
                {
                    e.ContextMenu.Items[i].Visibility = ElementVisibility.Collapsed;
                }

            }
        }

        private void GridItems_CreateCell(object sender, GridViewCreateCellEventArgs e)
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

        private void GridItems_ViewCellFormatting(object sender, CellFormattingEventArgs e)
        {
            e.CellElement.Font = _font;
        }

        private void GridInvoice_CurrentRowChanged(object sender, CurrentRowChangedEventArgs e)
        {
            try
            {
                if (GridInvoice.RowCount >= 1)
                {
                    var result = new Items(new MyDatabase())
                    {
                        InvoiceId = Convert.ToInt32(GridInvoice.CurrentRow.Cells[5].Value.ToString())
                    };
                    GridItems.DataSource = result.FillItemGrid();
                                                           
                    if (GridItems.RowCount <= 0) return;

                    FormatGridItem();
                    
                    btn_Delete.Enabled = true;
                    btn_Print.Enabled = true;
                    GridItems.Enabled = true;
                }
                else
                {
                    GridItems.DataSource = null;
                    GridInvoice.DataSource = null;
                    GridInvoice.Enabled = false;
                    btn_CheckOut.Enabled = false;
                    btn_Delete.Enabled = false;
                    btn_Print.Enabled = false;
                    GridItems.Enabled = false;
                }
                
            }
            catch 
            {
                _error = new Alert.Alert("Error", "." + "مشکل در برقراری ارتباط با پایگاه داده") { TopMost = true };
                _error.Show(); 
            }
        }

        private void btn_Print_Click(object sender, EventArgs e)
        {
            try
            {
                PrintDialogsLocalizationProvider.CurrentProvider = new PersianDialogsLocalizationProvider();

                radPrintDocument1.AssociatedObject = GridItems;
                GridItems.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.None;



                MyPrintDocument doc = new MyPrintDocument();
                doc.HeaderHeight = 30;
                doc.HeaderFont = new Font("B Kamran", 10, FontStyle.Bold);
                doc.LeftHeader = string.Format("جمع کل: {0}", GridInvoice.CurrentRow.Cells[7].Value);
                doc.MiddleHeader = "Middle header";
                doc.RightHeader = "Right header";


                doc.AssociatedObject = GridItems;
                doc.PaperSize.PaperName = "X roll 80mm";





                //this.radPrintDocument1.DefaultPageSettings.Landscape = true;
                GridItems.PrintStyle.FitWidthMode = PrintFitWidthMode.FitPageWidth;
                RadPrintPreviewDialog dialog = new RadPrintPreviewDialog(doc);

                dialog.Document = radPrintDocument1;
                dialog.ThemeName = "TelerikMetro";
                dialog.SetZoom(1);
                //dialog.Document.LeftFooter = string.Format("جمع کل: {0}",txt_PriceToPay.Text);
                //dialog.Document.Logo = new Bitmap(HomeCafe.Properties.Resources.home_cafe_tablo12); 
                dialog.Document.LeftHeader = string.Format("جمع کل: {0} ريال", GridInvoice.CurrentRow.Cells[7].Value);
                dialog.Document.MiddleHeader = "هوم کافه";
                //dialog.Document.MiddleHeader = "[Logo]";
                dialog.Document.RightHeader = string.Format("{0} : {1}", GridInvoice.CurrentRow.Cells[0].Value, GridInvoice.CurrentRow.Cells[2].Value);
                dialog.Document.HeaderFont = new Font("B Kamran", 12, FontStyle.Bold);
                dialog.Document.HeaderHeight = 20;

                dialog.FormElement.Font = _font;
                dialog.RightToLeft = RightToLeft.Yes;
                dialog.Font = _font;
                GridPrintStyle style = new GridPrintStyle();
                style.FitWidthMode = PrintFitWidthMode.FitPageWidth;
                style.HeaderCellBackColor = Color.White;
                style.CellFont = new Font("B Kamran", 12, FontStyle.Bold);
                style.HeaderCellFont = new Font("B Kamran", 12, FontStyle.Bold);
                GridItems.PrintStyle = style;

                style.PrintCellFormatting += style_PrintCellFormatting;
                radPrintDocument1.Print();
                //if (dialog.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
                //{
                //    this.radPrintDocument1.Print();
                //}
                GridItems.Columns[0].BestFit();
                GridItems.Columns[0].BestFit();
                btn_CheckOut.Enabled = true;
            }
            catch
            {
                _error = new Alert.Alert("Error", "." + "از ارتباط چاپگر با کامپیوتر اطمینان حاصل کنید") { TopMost = true };
                _error.Show();

            }
          

        }

        private void style_PrintCellFormatting(object sender, PrintCellFormattingEventArgs e)
        {
            if (e.Row is GridViewTableHeaderRowInfo)
            {

                e.PrintCell.Font = new Font("B Kamran", 12, FontStyle.Bold);

            }
            if (e.Row is GridViewTableHeaderRowInfo && GridItems.RightToLeft == RightToLeft.Yes)
            {
                e.PrintCell.TextAlignment = ContentAlignment.TopCenter;
            }

        }

        private void btn_CheckOut_Click(object sender, EventArgs e)
        {
            try
            {
                var factor = new Factors(new MyDatabase())
                {
                    InvoiceId = Convert.ToInt32(GridInvoice.CurrentRow.Cells[5].Value.ToString())
                };
                var result = factor.CheckOut();

                if (!result) return;

                Alert_UnpayedFactor.CaptionText = "توجه";
                Alert_UnpayedFactor.ContentText = "." + "فاکتور مورد نظر با موفقیت تسویه شد";
                Alert_UnpayedFactor.Popup.AlertElement.ContentElement.Font = _font;
                Alert_UnpayedFactor.Popup.AlertElement.CaptionElement.TextAndButtonsElement.TextElement.Font = _font;
                Alert_UnpayedFactor.Popup.AlertElement.ContentElement.TextAlignment = ContentAlignment.MiddleRight;
                Alert_UnpayedFactor.Popup.AlertElement.CaptionElement.TextAndButtonsElement.TextAlignment = ContentAlignment.TopLeft;
                Alert_UnpayedFactor.Show();
                
                if (GridInvoice.RowCount > 1)
                {
                    var item = new Items(new MyDatabase())
                    {
                        InvoiceId = Convert.ToInt32(GridInvoice.CurrentRow.Cells[5].Value.ToString())
                    };
                    GridItems.DataSource = item.FillItemGrid();

                    if (GridItems.RowCount > 0)
                    {
                        FormatGridItem();

                        btn_CheckOut.Enabled = true;
                        btn_Delete.Enabled = true;
                        btn_Print.Enabled = true;
                        GridItems.Enabled = true;

                    }
                    unpayedfactorsTableAdapter1.Fill(cafeDataSet1.unpayedfactors);
                }
                else
                {
                    GridInvoice.DataSource = null;
                    GridInvoice.Enabled = false;
                    GridItems.DataSource = null;
                    btn_CheckOut.Enabled = false;
                    btn_Delete.Enabled = false;
                    btn_Print.Enabled = false;
                    GridItems.Enabled = false;
                }
            }
            catch  
            {
                _error = new Alert.Alert("Error", "." + "مشکل در برقراری ارتباط با پایگاه داده") { TopMost = true };
                _error.Show(); 
            }
        }


        private void btn_No_Click(object sender, EventArgs e)
        {
          
          
            _error.Close();
        }

        void btn_Ok_Click(object sender, EventArgs e)
        {
            //try
            //{
                PrintDialogsLocalizationProvider.CurrentProvider = new PersianDialogsLocalizationProvider();

                radPrintDocument2.AssociatedObject = GridItems;
                GridItems.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.None;



                MyPrintDocument doc = new MyPrintDocument();
                doc.HeaderHeight = 30;
                doc.HeaderFont = new Font("B Kamran", 10, FontStyle.Bold);
                doc.LeftHeader = string.Format("جمع کل: {0}", GridInvoice.CurrentRow.Cells[7].Value);
                doc.MiddleHeader = "Middle header";
                doc.RightHeader = "Right header";


                doc.AssociatedObject = GridItems;
                doc.PaperSize.PaperName = "X roll 80mm";





                //this.radPrintDocument1.DefaultPageSettings.Landscape = true;
                GridItems.PrintStyle.FitWidthMode = PrintFitWidthMode.FitPageWidth;
                RadPrintPreviewDialog dialog = new RadPrintPreviewDialog(doc);

                dialog.Document = radPrintDocument2;
                dialog.ThemeName = "TelerikMetro";
                dialog.SetZoom(1);

                dialog.Document.LeftHeader = string.Format("جمع کل: {0} ريال", GridInvoice.CurrentRow.Cells[7].Value);
                dialog.Document.MiddleHeader = "هوم کافه";
                //dialog.Document.MiddleHeader = "[Logo]";

                dialog.Document.RightHeader = string.Format("شماره فاکتور: {0} ", GridInvoice.CurrentRow.Cells[5].Value);


                dialog.Document.HeaderFont = new Font("B Kamran", 12, FontStyle.Bold);
                dialog.Document.HeaderHeight = 20;

                dialog.FormElement.Font = _font;
                dialog.RightToLeft = RightToLeft.Yes;
                dialog.Font = _font;
                GridPrintStyle style = new GridPrintStyle();
                style.FitWidthMode = PrintFitWidthMode.FitPageWidth;
                style.HeaderCellBackColor = Color.White;
                style.CellFont = new Font("B Kamran", 12, FontStyle.Bold);
                style.HeaderCellFont = new Font("B Kamran", 12, FontStyle.Bold);
                GridItems.PrintStyle = style;

                style.PrintCellFormatting += style_PrintCellFormatting;
                radPrintDocument2.Print();
                //if (dialog.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
                //{
                //    this.radPrintDocument1.Print();
                //}
                GridItems.Columns[0].BestFit();
                GridItems.Columns[0].BestFit();

                unpayedfactorsTableAdapter1.Fill(cafeDataSet1.unpayedfactors);
            //}
            //catch 
            //{

            //    _error = new Alert("_error", "." + "از ارتباط چاپگر با کامپیوتر اطمینان حاصل کنید");
            //    _error.TopMost = true;
            //    _error.Show();
            //}
           



        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                var factor = new Factors(new MyDatabase())
                {
                    InvoiceId = Convert.ToInt32(GridInvoice.CurrentRow.Cells[5].Value.ToString())
                };
                var result = factor.CheckOut();

                if (!result) return;

                Alert_UnpayedFactor.CaptionText = "توجه";
                Alert_UnpayedFactor.ContentText = "." + "فاکتور مورد نظر با موفقیت باطل شد";
                Alert_UnpayedFactor.Popup.AlertElement.ContentElement.Font = _font; 
                Alert_UnpayedFactor.Popup.AlertElement.CaptionElement.TextAndButtonsElement.TextElement.Font = _font;
                Alert_UnpayedFactor.Popup.AlertElement.ContentElement.TextAlignment = ContentAlignment.MiddleRight;
                Alert_UnpayedFactor.Popup.AlertElement.CaptionElement.TextAndButtonsElement.TextAlignment = ContentAlignment.TopRight;
                Alert_UnpayedFactor.Show();

                unpayedfactorsTableAdapter1.Fill(cafeDataSet1.unpayedfactors);

                if (GridInvoice.RowCount >= 1)
                {
                    var item = new Items(new MyDatabase())
                    {
                        InvoiceId = Convert.ToInt32(GridInvoice.CurrentRow.Cells[5].Value.ToString())
                    };
                    GridItems.DataSource = item.FillItemGrid();

                    if (GridItems.RowCount <= 0) return;
                   
                    FormatGridItem();

                    btn_CheckOut.Enabled = true;
                    btn_Delete.Enabled = true;
                    btn_Print.Enabled = true;
                    GridItems.Enabled = true;
                }
                else
                {
                    GridItems.DataSource = null;
                    btn_CheckOut.Enabled = false;
                    btn_Delete.Enabled = false;
                    btn_Print.Enabled = false;
                    GridItems.Enabled = false;
                }

            }
            catch 
            {
                _error = new Alert.Alert("Error", "." + "مشکل در برقراری ارتباط با پایگاه داده") { TopMost = true };
                _error.Show(); 
            }
        }

        private void radPrintDocument1_BeginPrint(object sender, PrintEventArgs e)
        {
            GridItems.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.None;
            for (int start = GridItems.Columns.Count - 1; start >= 0; start--)
            {
                if (start == 4)
                {
                    GridItems.Columns[start].IsVisible = false;
                   
                }

                GridItems.Columns[start].BestFit();
               
          
            }
            foreach (var col in GridItems.Columns)
            {
                col.HeaderTextAlignment = ContentAlignment.TopCenter;
            }
           
        }

        private void radPrintDocument1_EndPrint(object sender, PrintEventArgs e)
        {
            
            for (int start = GridItems.Columns.Count - 1; start >= 0; start--)
            {
                if (start == 4)
                {
                    GridItems.Columns[start].IsVisible = true;
                    //this.GridItems.Columns[start].BestFit();
                }
                
            }
            GridItems.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;
          
        }

        private void FormatGridItem()
        {
            GridItems.Columns[0].TextAlignment = ContentAlignment.MiddleCenter;
            GridItems.Columns[1].TextAlignment = ContentAlignment.MiddleCenter;
            GridItems.Columns[2].TextAlignment = ContentAlignment.MiddleCenter;
            GridItems.Columns[3].TextAlignment = ContentAlignment.MiddleCenter;
            GridItems.Columns[4].TextAlignment = ContentAlignment.MiddleCenter;

            GridItems.Columns[4].MaxWidth = 195;
            GridItems.Columns[3].MaxWidth = 195;
            GridItems.Columns[2].MaxWidth = 195;
            GridItems.Columns[1].MaxWidth = 195;
            GridItems.Columns[0].MaxWidth = 195;

            GridItems.Columns[2].DataType = typeof(decimal);
            GridItems.Columns[2].FormatString = @"{0:n0}";

            GridItems.Columns[4].ReadOnly = true;
            GridItems.Columns[3].ReadOnly = true;
            GridItems.Columns[2].ReadOnly = true;
            GridItems.Columns[1].ReadOnly = true;
            GridItems.Columns[0].ReadOnly = true; 
        }
      
    }
}
