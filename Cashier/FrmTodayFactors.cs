using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;
using HomeCafe.DataBase;
using HomeCafe.My_Custom_Classes;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using Telerik.WinControls.UI.Localization;

namespace HomeCafe.Cashier
{
    public partial class FrmTodayFactors : Form
    {
        private readonly Font _font = new Font("IRANSansDNFaNum", 10.0f, FontStyle.Regular);
        public FrmTodayFactors()
        {
            InitializeComponent();
            RadGridLocalizationProvider.CurrentProvider = new MyPersianRadGridLocalizationProvider();
            Grid_Factor.ColumnChooser.Shown += ColumnChooser_Shown;
            txt_FactorDate.Culture = PersianCultureHelper.GetFixedPersianCulture();
            txt_FactorDate.Enabled = false;
            txt_FactorDate.DateTimePickerElement.Calendar.FocusedDate = DateTime.Now;
            txt_FactorDate.Value = DateTime.Today;
        }

        void ColumnChooser_Shown(object sender, EventArgs e)
        {
           Grid_Factor.ColumnChooser.ColumnChooserControl.ColumnChooserElement.Font = _font;
        }

        private void Grid_Factor_CellFormatting(object sender, CellFormattingEventArgs e)
        {
            e.CellElement.Font = _font;
        }

        private void Grid_Factor_ColumnChooserItemElementCreating(object sender, ColumnChooserItemElementCreatingEventArgs e)
        {
            e.ItemElement.Font = _font;
            e.GridViewElement.Font = _font;
        }

        private void Grid_Factor_ConditionalFormattingFormShown(object sender, EventArgs e)
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

        private void Grid_Factor_ContextMenuOpening(object sender, ContextMenuOpeningEventArgs e)
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

        private void Grid_Factor_CreateCell(object sender, GridViewCreateCellEventArgs e)
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

        private void Grid_Factor_ViewCellFormatting(object sender, CellFormattingEventArgs e)
        {
            e.CellElement.Font = _font;
        }

        private void frm_TodayFactors_Load(object sender, EventArgs e)
        {
            var factor = new Factors(new MyDatabase())
            {
                Date = txt_FactorDate.Text
            };
            var invoice = factor.FillInvoiceGrid();
            Grid_Factor.DataSource = invoice;
            if (Grid_Factor.RowCount > 0)
            {
                FormatGridFactor();

                var item = new Items(new MyDatabase())
                {
                    InvoiceId = Convert.ToInt32(Grid_Factor.CurrentRow.Cells[5].Value.ToString())
                };
                GridItems.DataSource = item.FillItemGrid();
                if (GridItems.RowCount > 0)
                {
                    FormatGridItem();

                }

            }
            else
            {
                GridItems.DataSource = null;

            }
          
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
            for (int i = 0; i < e.ContextMenu.Items.Count; i++)
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

        private void Grid_Factor_CurrentRowChanged(object sender, CurrentRowChangedEventArgs e)
        {
            if (Grid_Factor.RowCount > 0)
            {
                var item = new Items(new MyDatabase())
                {
                    InvoiceId = Convert.ToInt32(Grid_Factor.CurrentRow.Cells[5].Value.ToString())
                };
                GridItems.DataSource = item.FillItemGrid();
                if (GridItems.RowCount > 0)
                {
                    FormatGridItem();
                }
            }
            else
            {
                GridItems.DataSource = null;

            }
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

        private void FormatGridFactor()
        {
            Grid_Factor.Columns[1].IsVisible = false;
            Grid_Factor.Columns[1].VisibleInColumnChooser = false;
            Grid_Factor.Columns[3].IsVisible = false;
            Grid_Factor.Columns[3].VisibleInColumnChooser = false;


            Grid_Factor.Columns[0].TextAlignment = ContentAlignment.MiddleCenter;
            Grid_Factor.Columns[2].TextAlignment = ContentAlignment.MiddleCenter;
            Grid_Factor.Columns[4].TextAlignment = ContentAlignment.MiddleCenter;
            Grid_Factor.Columns[5].TextAlignment = ContentAlignment.MiddleCenter;
            Grid_Factor.Columns[6].TextAlignment = ContentAlignment.MiddleCenter;
            Grid_Factor.Columns[6].DataType = typeof(decimal);
            Grid_Factor.Columns[6].FormatString = @"{0:n0}";
        }

    }
}
