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
    public partial class FrmReportByGoods : Form
    {
        private readonly IFixLanguageAndForms _fixLanguageAndForms;
        private readonly Font _font = new Font("IRANSansDNFaNum", 10.0f, FontStyle.Regular);
        public FrmReportByGoods(IFixLanguageAndForms fixLanguageAndForms)
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
                var calendar1 = calendarBehavior.Calendar;
                var calendarElement1 = calendar1.CalendarElement;
                calendarElement1.CalendarNavigationElement.Font = headerFont;
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
            Grid_ReportByGoods.ColumnChooser.Shown += ColumnChooser_Shown;
        }

        private void ColumnChooser_Shown(object sender, EventArgs e)
        {
            Grid_ReportByGoods.ColumnChooser.ColumnChooserControl.ColumnChooserElement.Font = _font;
        } 

        private void frm_ReportByGoods_Load(object sender, EventArgs e)
        {
            combo_Products.Enabled = false;
            btn_Show.Enabled = false;
            txt_EndDate.Enabled = false;

            var report = new Report(new MyDatabase());
            
            combo_Catagories.DataSource = report.FillCatagory();
            combo_Catagories.SelectedIndex = -1;
          
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
                 combo_Products.Enabled = true;
                 var report = new Report(new MyDatabase())
                 {
                     Catagory = combo_Catagories.Text.Trim()
                 };
                 combo_Products.DataSource = report.FillProduct();
                 combo_Products.SelectedIndex = -1;
             }
             else
             {
                 combo_Products.Enabled = false;
             }
        }

        private void btn_Show_Click(object sender, EventArgs e)
        {
            var report = new Report(new MyDatabase())
            {
                Product = combo_Products.Text.Trim(),
                Catagory = combo_Catagories.Text.Trim(),
                StartDate = txt_StartDate.Text,
                EndDate = txt_EndDate.Text,
                CatagoryAndProduct = Radio_Selection.IsChecked,
                Duration = ckb_Date.IsChecked,
                AllProduct = Radio_ShowAll.IsChecked,
                WholeSale = Radio_WithoutTime.IsChecked
            };

            var result = report.GetReportByProdct();
            
            if (!report.CheckEmptyGrid())
            {
                Grid_ReportByGoods.DataSource = null;
                return;
            }
            
            Grid_ReportByGoods.DataSource = result;
            
            if (!Radio_WithoutTime.IsChecked)
            {
                FormatGrid();
            }
            FormatGridWithoutTime();
        }

        private void combo_Products_Enter(object sender, EventArgs e)
        {
            _fixLanguageAndForms.FixLanguage();
        }

        private void combo_Products_Leave(object sender, EventArgs e)
        {
            _fixLanguageAndForms.OriginalLanguage();
        }

        private void combo_Products_TextChanged(object sender, EventArgs e)
        {
            combo_Products.DropDownListElement.AutoCompleteSuggest.SuggestMode = SuggestMode.Contains;
            btn_Show.Enabled = combo_Products.Items.Contains(combo_Products.Text.Trim());
        }

        private void Grid_ReportByGoods_ColumnChooserItemElementCreating(object sender, ColumnChooserItemElementCreatingEventArgs e)
        {
            e.ItemElement.Font = _font;
            e.GridViewElement.Font = _font;
        }

        private void Grid_ReportByGoods_ConditionalFormattingFormShown(object sender, EventArgs e)
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

        private void Grid_ReportByGoods_ContextMenuOpening(object sender, ContextMenuOpeningEventArgs e)
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

        private void Grid_ReportByGoods_CreateCell(object sender, GridViewCreateCellEventArgs e)
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

        private void Grid_ReportByGoods_ViewCellFormatting(object sender, CellFormattingEventArgs e)
        {
            e.CellElement.Font = _font;
        }

        private void ckb_Date_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            txt_EndDate.Enabled = ckb_Date.IsChecked;
        }

        private void Radio_ShowAll_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            if (Radio_ShowAll.IsChecked)
            {
                combo_Products.Enabled = false;
                combo_Catagories.Enabled = false;
                btn_Show.Enabled = true;
            }
            else
            {
                Grid_ReportByGoods.DataSource = null;
            }
        }

        private void Radio_WithoutTime_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            if (Radio_WithoutTime.IsChecked)
            {
                combo_Products.Enabled = false;
                combo_Catagories.Enabled = false;
                btn_Show.Enabled = true;
            }
            else
            {
                Grid_ReportByGoods.DataSource = null;
            }
        }

        private void Radio_Selection_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            if (Radio_Selection.IsChecked)
            {
               combo_Catagories.Enabled = true;
            }
            else
            {
                Grid_ReportByGoods.DataSource = null;
                combo_Catagories.Text = "";
                combo_Products.Text = null;
            }
        }

        private void FormatGrid()
        {
            Grid_ReportByGoods.Columns[0].TextAlignment = ContentAlignment.MiddleCenter;
            Grid_ReportByGoods.Columns[1].TextAlignment = ContentAlignment.MiddleCenter;
            Grid_ReportByGoods.Columns[2].TextAlignment = ContentAlignment.MiddleCenter;
            Grid_ReportByGoods.Columns[3].TextAlignment = ContentAlignment.MiddleCenter;
        }

        private void FormatGridWithoutTime()
        {
            Grid_ReportByGoods.Columns[0].TextAlignment = ContentAlignment.MiddleCenter;
            Grid_ReportByGoods.Columns[1].TextAlignment = ContentAlignment.MiddleCenter;
            Grid_ReportByGoods.Columns[2].TextAlignment = ContentAlignment.MiddleCenter;
        }  

    }
}
