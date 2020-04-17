using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;
using HomeCafe.DataBase;
using HomeCafe.My_Custom_Classes;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using Telerik.WinControls.UI.Localization;

namespace HomeCafe.Reports
{
    public partial class FrmReportByDate : Form
    {
        private readonly Font _font = new Font("IRANSansDNFaNum", 10.0f, FontStyle.Regular);
        private int _total;
        public FrmReportByDate()
        {
            InitializeComponent();
            RadGridLocalizationProvider.CurrentProvider = new MyPersianRadGridLocalizationProvider();
            txt_FactorDate.Culture = PersianCultureHelper.GetFixedPersianCulture();
            txt_FactorDate.DateTimePickerElement.Calendar.FocusedDate = DateTime.Now;

            txt_FactorDate.Value = DateTime.Today;
            var headerFont = _font;
            var datesFont = _font;
            var calendarBehavior = txt_FactorDate.DateTimePickerElement.GetCurrentBehavior() as RadDateTimePickerCalendar;
            if (calendarBehavior != null)
            {
                var calendar = calendarBehavior.Calendar;
                var calendarElement = calendar.CalendarElement;
                calendarElement.CalendarNavigationElement.Font = headerFont;
            }
            if (calendarBehavior != null)
            {
                var monthView = calendarBehavior.Calendar.CalendarElement.CalendarVisualElement as MonthViewElement;
                if (monthView != null)
                    foreach (var radElement in monthView.TableElement.Children)
                    {
                        var item = (RadItem) radElement;
                        item.Font = datesFont;
                    }
            }
            Grid_ReportByDate.ColumnChooser.Shown += ColumnChooser_Shown;
           

        }

        private void ColumnChooser_Shown(object sender, EventArgs e)
        {
            Grid_ReportByDate.ColumnChooser.ColumnChooserControl.ColumnChooserElement.Font = _font;
        }

        private void Grid_ReportByDate_ColumnChooserItemElementCreating(object sender, ColumnChooserItemElementCreatingEventArgs e)
        {
            e.ItemElement.Font = _font;
            e.GridViewElement.Font = _font;
        }

        private void Grid_ReportByDate_ConditionalFormattingFormShown(object sender, EventArgs e)
        {
            var form = (ConditionalFormattingForm)sender;
            SetFormFont(form.Controls);
        }
        private readonly Font _f = new Font("IRANSansDNFaNum", 9.00f, FontStyle.Regular);
        private void SetFormFont(IEnumerable controls)
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

        private void Grid_ReportByDate_ContextMenuOpening(object sender, ContextMenuOpeningEventArgs e)
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

        private void Grid_ReportByDate_CreateCell(object sender, GridViewCreateCellEventArgs e)
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

        private void Grid_ReportByDate_ViewCellFormatting(object sender, CellFormattingEventArgs e)
        {
            e.CellElement.Font = _font;
        }

        private void btn_Show_Click(object sender, EventArgs e)
        {
            _total = 0;
            var report = new Report(new MyDatabase())
            {
                StartDate = txt_FactorDate.Text
            };
           
            var result = report.GetReportByDate();

            if (!report.CheckEmptyGrid())
            {
                Grid_ReportByDate.DataSource = null;
                return;
            }
            Grid_ReportByDate.DataSource = result;

            FormatGrid();

            foreach (var row in ((GridDataView) Grid_ReportByDate.MasterTemplate.DataView).Indexer.Items)
            {
                _total += Convert.ToInt32(row.Cells[5].Value.ToString());
            }
            txt_Total.Value = _total;
        }

        private void btn_Print_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    PrintDialogsLocalizationProvider.CurrentProvider = new PersianDialogsLocalizationProvider();

            //    radPrintDocument1.AssociatedObject = Grid_ReportByDate;
            //    Grid_ReportByDate.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.None;

            //    var doc = new MyPrintDocument
            //    {
            //        HeaderHeight = 30,
            //        HeaderFont = new Font("B Kamran", 10, FontStyle.Bold),
            //        LeftHeader = string.Format("جمع کل: {0}", _total),
            //        MiddleHeader = "Middle header",
            //        RightHeader = "Right header",
            //        AssociatedObject = Grid_ReportByDate,
            //        PaperSize = {PaperName = "X roll 80mm"}
            //    };

            //    //this.radPrintDocument1.DefaultPageSettings.Landscape = true;
            //    Grid_ReportByDate.PrintStyle.FitWidthMode = PrintFitWidthMode.FitPageWidth;
            //    var dialog = new RadPrintPreviewDialog(doc)
            //    {
            //        Document = radPrintDocument1,
            //        ThemeName = "TelerikMetro"
            //    };

            //    dialog.SetZoom(1);
            //    //dialog.Document.LeftFooter = string.Format("جمع کل: {0}",txt_PriceToPay.Text);
            //    //dialog.Document.Logo = new Bitmap(HomeCafe.Properties.Resources.home_cafe_tablo12); 
            //    dialog.Document.LeftHeader = string.Format("جمع کل: {0} ريال", _total);
            //    dialog.Document.MiddleHeader = "هوم کافه";
            //    //dialog.Document.MiddleHeader = "[Logo]";
            //    dialog.Document.RightHeader = string.Format("{0} ", txt_FactorDate.Text);
            //    dialog.Document.HeaderFont = new Font("B Kamran", 12, FontStyle.Bold);
            //    dialog.Document.HeaderHeight = 20;

            //    dialog.FormElement.Font = _font;
            //    dialog.RightToLeft = RightToLeft.Yes;
            //    dialog.Font = _font;
            //    var style = new GridPrintStyle
            //    {
            //        FitWidthMode = PrintFitWidthMode.FitPageWidth,
            //        HeaderCellBackColor = Color.White,
            //        CellFont = new Font("B Kamran", 12, FontStyle.Bold),
            //        HeaderCellFont = new Font("B Kamran", 12, FontStyle.Bold)
            //    };
            //    Grid_ReportByDate.PrintStyle = style;

            //    style.PrintCellFormatting += style_PrintCellFormatting;
            //    radPrintDocument1.Print();
            //    //if (dialog.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            //    //{
            //    //    this.radPrintDocument1.Print();
            //    //}


            //}
            //catch 
            //{
            //    _error = new Alert.Alert("Error", "." + "از ارتباط چاپگر با کامپیوتر اطمینان حاصل کنید") {TopMost = true};
            //    _error.Show();
               
            //}
          
        }
        //void style_PrintCellFormatting(object sender, PrintCellFormattingEventArgs e)
        //{
        //    if (e.Row is GridViewTableHeaderRowInfo)
        //    {

        //        e.PrintCell.Font = new Font("B Kamran", 12, FontStyle.Bold);

        //    }
        //    if (e.Row is GridViewTableHeaderRowInfo && Grid_ReportByDate.RightToLeft == RightToLeft.Yes)
        //    {
        //        e.PrintCell.TextAlignment = ContentAlignment.TopCenter;
        //    }

        //}

        //private void radPrintDocument1_BeginPrint(object sender, PrintEventArgs e)
        //{
        //    Grid_ReportByDate.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.None;
        //    for (int start = Grid_ReportByDate.Columns.Count - 1; start >= 0; start--)
        //    {
        //        if (start == 1 || start == 4)
        //        {
        //            Grid_ReportByDate.Columns[start].IsVisible = false;
        //            Grid_ReportByDate.Columns[start].BestFit();
        //        }
        //        Grid_ReportByDate.Columns[start].BestFit();
        //    }
        //    foreach (var col in Grid_ReportByDate.Columns)
        //    {
        //        col.HeaderTextAlignment = ContentAlignment.TopCenter;
        //    }
        //}

        //private void radPrintDocument1_EndPrint(object sender, PrintEventArgs e)
        //{
        //    for (int start = Grid_ReportByDate.Columns.Count - 1; start >= 0; start--)
        //    {
        //        if (start == 1 || start == 4)
        //        {

        //            Grid_ReportByDate.Columns[start].IsVisible = true;

        //        }
        //    }
        //    Grid_ReportByDate.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;
        //}

        private void FormatGrid()
        {
            Grid_ReportByDate.Columns[0].TextAlignment = ContentAlignment.MiddleCenter;
            Grid_ReportByDate.Columns[1].TextAlignment = ContentAlignment.MiddleCenter;
            Grid_ReportByDate.Columns[1].MaxWidth = 190;
            Grid_ReportByDate.Columns[2].TextAlignment = ContentAlignment.MiddleCenter;
            Grid_ReportByDate.Columns[3].TextAlignment = ContentAlignment.MiddleCenter;
            Grid_ReportByDate.Columns[4].TextAlignment = ContentAlignment.MiddleCenter;
            Grid_ReportByDate.Columns[4].MaxWidth = 190;
            Grid_ReportByDate.Columns[5].TextAlignment = ContentAlignment.MiddleCenter;
            Grid_ReportByDate.Columns[5].DataType = typeof(decimal);
            Grid_ReportByDate.Columns[5].FormatString = @"{0:n0}";
        }
      
    }
}
