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
    public partial class FrmReportBySubscribers : Form
    {
        private readonly Font _font = new Font("IRANSansDNFaNum", 10.0f, FontStyle.Regular);
        public FrmReportBySubscribers()
        {
            InitializeComponent();
            RadGridLocalizationProvider.CurrentProvider = new MyPersianRadGridLocalizationProvider();
            Grid_ReportBySubscribers.ColumnChooser.Shown += ColumnChooser_Shown;
        }

        void ColumnChooser_Shown(object sender, EventArgs e)
        {
            Grid_ReportBySubscribers.ColumnChooser.ColumnChooserControl.ColumnChooserElement.Font = _font;
        }

        private void Grid_ReportBySubscribers_ColumnChooserItemElementCreating(object sender, ColumnChooserItemElementCreatingEventArgs e)
        {
            e.ItemElement.Font = _font;
            e.GridViewElement.Font = _font;
        }

        private void Grid_ReportBySubscribers_ConditionalFormattingFormShown(object sender, EventArgs e)
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

        private void Grid_ReportBySubscribers_ContextMenuOpening(object sender, ContextMenuOpeningEventArgs e)
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

        private void Grid_ReportBySubscribers_CreateCell(object sender, GridViewCreateCellEventArgs e)
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

        private void Grid_ReportBySubscribers_ViewCellFormatting(object sender, CellFormattingEventArgs e)
        {
            e.CellElement.Font = _font;
        }

        private void frm_ReportBySubscribers_Load(object sender, EventArgs e)
        {
            var report = new Report(new MyDatabase());
            var result = report.GetReportBySubscribers();

            if (!report.CheckEmptyGrid())
            {
                Grid_ReportBySubscribers.DataSource = null;
                return;
            }
            Grid_ReportBySubscribers.DataSource = result;
            FormatGrid();
        }

        private void FormatGrid()
        {
            Grid_ReportBySubscribers.Columns[0].TextAlignment = ContentAlignment.MiddleCenter;
            Grid_ReportBySubscribers.Columns[1].TextAlignment = ContentAlignment.MiddleCenter;
            Grid_ReportBySubscribers.Columns[2].TextAlignment = ContentAlignment.MiddleCenter;
            Grid_ReportBySubscribers.Columns[3].TextAlignment = ContentAlignment.MiddleCenter;
            Grid_ReportBySubscribers.Columns[4].TextAlignment = ContentAlignment.MiddleCenter;
        }
    }
}
