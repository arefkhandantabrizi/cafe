using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;
using HomeCafe.DataBase;
using HomeCafe.My_Custom_Classes;
using Telerik.WinControls.UI.Localization;
using Telerik.WinControls.UI;
using Telerik.WinControls;

namespace HomeCafe.Reports
{
    public partial class FrmDebtReport : Form
    {
        private readonly Font _font = new Font("IRANSansDNFaNum", 10.0f, FontStyle.Regular);
        public FrmDebtReport()
        {
            InitializeComponent();
            RadGridLocalizationProvider.CurrentProvider = new MyPersianRadGridLocalizationProvider();
            Grid_ReportByDebt.ColumnChooser.Shown += ColumnChooser_Shown;
        }

        private void ColumnChooser_Shown(object sender, EventArgs e)
        {
            Grid_ReportByDebt.ColumnChooser.ColumnChooserControl.ColumnChooserElement.Font = _font;
        }

        private void Grid_ReportByDebt_ColumnChooserItemElementCreating(object sender, ColumnChooserItemElementCreatingEventArgs e)
        {
            e.ItemElement.Font = _font;
            e.GridViewElement.Font = _font;
        }

        private void Grid_ReportByDebt_ConditionalFormattingFormShown(object sender, EventArgs e)
        {
            var form = (ConditionalFormattingForm)sender;
            SetFormFont(form.Controls);
        }

        private readonly Font _f = new Font("IRANSansDNFaNum", 9.0f, FontStyle.Regular);
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

        private void Grid_ReportByDebt_ContextMenuOpening(object sender, ContextMenuOpeningEventArgs e)
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

        private void Grid_ReportByDebt_CreateCell(object sender, GridViewCreateCellEventArgs e)
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

        private void Grid_ReportByDebt_ViewCellFormatting(object sender, CellFormattingEventArgs e)
        {
            e.CellElement.Font = _font;
        }

        private void frm_DebtReport_Load(object sender, EventArgs e)
        {
            var report = new Report(new MyDatabase());
            var result = report.GetReportByDebt();
            
            if (!report.CheckEmptyGrid())
            {
                Grid_ReportByDebt.DataSource = null;
                return;
            }
            Grid_ReportByDebt.DataSource = result;
            FormatGrid();
        }

        private void FormatGrid()
        {
            Grid_ReportByDebt.Columns[0].TextAlignment = ContentAlignment.MiddleCenter;
            Grid_ReportByDebt.Columns[1].TextAlignment = ContentAlignment.MiddleCenter;
            Grid_ReportByDebt.Columns[1].DataType = typeof(decimal);
            Grid_ReportByDebt.Columns[1].FormatString = @"{0:n0}";
            Grid_ReportByDebt.Columns[2].TextAlignment = ContentAlignment.MiddleCenter;
            Grid_ReportByDebt.Columns[3].TextAlignment = ContentAlignment.MiddleCenter;
        }
    }
}
