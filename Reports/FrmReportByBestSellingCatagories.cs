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
    public partial class FrmReportByBestSellingCatagories : Form
    {
        private readonly IFixLanguageAndForms _fixLanguageAndForms;
        private readonly Font _font = new Font("IRANSansDNFaNum", 10.0f, FontStyle.Regular);
        public FrmReportByBestSellingCatagories(IFixLanguageAndForms fixLanguageAndForms)
        {
            _fixLanguageAndForms = fixLanguageAndForms;
            InitializeComponent();
            RadGridLocalizationProvider.CurrentProvider = new MyPersianRadGridLocalizationProvider();
            txt_StartDate.Culture = PersianCultureHelper.GetFixedPersianCulture();
            txt_EndDate.Culture = PersianCultureHelper.GetFixedPersianCulture();
            txt_StartDate.Value = DateTime.Today;
            txt_EndDate.Value = DateTime.Today;
            var headerFont = _font;
            var datesFont = _font;
            var calendarBehavior = txt_StartDate.DateTimePickerElement.GetCurrentBehavior() as RadDateTimePickerCalendar;
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

            var calendarBehavior1 = txt_EndDate.DateTimePickerElement.GetCurrentBehavior() as RadDateTimePickerCalendar;
            if (calendarBehavior != null)
            {
                if (calendarBehavior1 != null)
                {
                    var calendar1 = calendarBehavior1.Calendar;
                    var calendarElement1 = calendar1.CalendarElement;
                    calendarElement1.CalendarNavigationElement.Font = headerFont;
                }
            }
            if (calendarBehavior1 != null)
            {
                var monthView1 = calendarBehavior1.Calendar.CalendarElement.CalendarVisualElement as MonthViewElement;
                if (monthView1 != null)
                    foreach (var radElement in monthView1.TableElement.Children)
                    {
                        var item = (RadItem) radElement;
                        item.Font = datesFont;
                    }
            }
            Grid_ReportByCategoris.ColumnChooser.Shown += ColumnChooser_Shown;
        }

        public void ColumnChooser_Shown(object sender, EventArgs e)
        {
            Grid_ReportByCategoris.ColumnChooser.ColumnChooserControl.ColumnChooserElement.Font = _font;
        }

        private void frm_ReportByBestSellingCatagories_Load(object sender, EventArgs e)
        {
            btn_Show.Enabled = false;
            txt_EndDate.Enabled = false;
            
            var fillCatagory = new Report(new MyDatabase());
            
            combo_Catagories.DataSource = fillCatagory.FillCatagory();
            combo_Catagories.SelectedIndex = -1;
           
        }

        private void Grid_ReportByCategoris_ColumnChooserItemElementCreating(object sender, ColumnChooserItemElementCreatingEventArgs e)
        {
            e.ItemElement.Font = _font;
            e.GridViewElement.Font = _font;
        }

        private void Grid_ReportByCategoris_ConditionalFormattingFormShown(object sender, EventArgs e)
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

        private void Grid_ReportByCategoris_ContextMenuOpening(object sender, ContextMenuOpeningEventArgs e)
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

        private void Grid_ReportByCategoris_CreateCell(object sender, GridViewCreateCellEventArgs e)
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

        private void Grid_ReportByCategoris_ViewCellFormatting(object sender, CellFormattingEventArgs e)
        {
            e.CellElement.Font = _font;
        }

        private void ckb_Date_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            txt_EndDate.Enabled = ckb_Date.IsChecked;
        }

        private void combo_Catagories_Enter(object sender, EventArgs e)
        {
           _fixLanguageAndForms.FixLanguage();
        }

        private void combo_Catagories_Leave(object sender, EventArgs e)
        {
            _fixLanguageAndForms.OriginalLanguage();
        }

        private void combo_Catagories_TextChanged(object sender, EventArgs e)
        {
              combo_Catagories.DropDownListElement.AutoCompleteSuggest.SuggestMode = SuggestMode.Contains;
            if (combo_Catagories.Items.Contains(combo_Catagories.Text.Trim()))
            {
                btn_Show.Enabled = true;

            }
            else
            {
                btn_Show.Enabled = false;
                Grid_ReportByCategoris.DataSource = null;
            }
        }

        private void btn_Show_Click(object sender, EventArgs e)
        {
            var report = new Report(new MyDatabase())
            {
                Catagory = combo_Catagories.Text,
                StartDate = txt_StartDate.Text,
                EndDate = txt_EndDate.Text,
                Duration = ckb_Date.Checked
            };
            var result = report.GetReportBySellingCatagories();
            if (!report.CheckEmptyGrid())
            {
                Grid_ReportByCategoris.DataSource = null;
                return;
            }
            Grid_ReportByCategoris.DataSource = result;
            Grid_ReportByCategoris.Columns[0].TextAlignment = ContentAlignment.MiddleCenter;
            Grid_ReportByCategoris.Columns[1].TextAlignment = ContentAlignment.MiddleCenter;
            Grid_ReportByCategoris.Columns[2].TextAlignment = ContentAlignment.MiddleCenter;
            Grid_ReportByCategoris.Columns[3].TextAlignment = ContentAlignment.MiddleCenter;
            result.Dispose();
         
        }
    }
}
