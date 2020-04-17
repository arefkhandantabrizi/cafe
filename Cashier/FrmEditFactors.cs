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
    public partial class FrmEditFactors : Form
    {
        private readonly IFixLanguageAndForms _fixLanguageAndForms;
        private readonly Font _font = new Font("IRANSansDNFaNum", 10.0f, FontStyle.Regular);
        
        public FrmEditFactors(IFixLanguageAndForms fixLanguageAndForms)
        {
            _fixLanguageAndForms = fixLanguageAndForms;
            InitializeComponent();
            RadGridLocalizationProvider.CurrentProvider = new MyPersianRadGridLocalizationProvider();
            GridInvoice.ColumnChooser.Shown += ColumnChooser_Shown;
           
            txt_FactorDate.Culture = PersianCultureHelper.GetFixedPersianCulture();
            txt_FactorDate.Enabled = false;
            txt_FactorDate.DateTimePickerElement.Calendar.FocusedDate = DateTime.Now;
            txt_FactorDate.Value = DateTime.Today;
        }

        void ColumnChooser_Shown(object sender, EventArgs e)
        {
            GridInvoice.ColumnChooser.ColumnChooserControl.ColumnChooserElement.Font = _font;
        }

        private void frm_EditFactors_Load(object sender, EventArgs e)
        {
            combo_TableName.Enabled = false;

            var factor = new Factors(new MyDatabase())
            {
                Date = txt_FactorDate.Text
            };
            combo_LocationName.DataSource= factor.FillLocation();
            combo_LocationName.SelectedIndex = -1;

            GridInvoice.DataSource = factor.FillInvoiceGrid();

            if (GridInvoice.RowCount > 0)
            {
                FormaInvoiceGrid();
            }
            else
            {
                combo_LocationName.Enabled = false;
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

        private void GridInvoice_ContextMenuOpening(object sender, ContextMenuOpeningEventArgs e)
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

        private void combo_LocationName_TextChanged(object sender, EventArgs e)
        {
            combo_LocationName.DropDownListElement.AutoCompleteSuggest.SuggestMode = SuggestMode.Contains;
            if (combo_LocationName.Items.Contains(combo_LocationName.Text.Trim()))
            {
                var factor = new Factors(new MyDatabase())
                {
                    Location = combo_LocationName.Text.Trim()
                };
                combo_TableName.DataSource = factor.FillTable();
                combo_TableName.SelectedIndex = -1;
                combo_TableName.Enabled = true;
            }
            else
            {
                combo_TableName.Enabled = false;
            }
        }

        private void combo_LocationName_Enter(object sender, EventArgs e)
        {
           _fixLanguageAndForms.FixLanguage();
        }

        private void combo_LocationName_Leave(object sender, EventArgs e)
        {
           _fixLanguageAndForms.OriginalLanguage();
        }

        private void combo_TableName_TextChanged(object sender, EventArgs e)
        {
            btn_Update.Enabled = combo_TableName.Items.Contains(combo_TableName.Text.Trim());
        }

        private void combo_TableName_Enter(object sender, EventArgs e)
        {
            _fixLanguageAndForms.FixLanguage();
        }

        private void combo_TableName_Leave(object sender, EventArgs e)
        {
          _fixLanguageAndForms.OriginalLanguage();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            var factor = new Factors(new MyDatabase())
            {
                Location = combo_LocationName.Text.Trim(),
                Table = combo_TableName.Text.Trim(),
                InvoiceId = Convert.ToInt32(GridInvoice.CurrentRow.Cells[5].Value.ToString()), 
                Date = txt_FactorDate.Text
            };
            var result = factor.UpDateInvoice();
            if (!result) return;

            Alert_editFactor.CaptionText = "توجه";
            Alert_editFactor.ContentText = "." + "فاکتور مورد نظر با موفقیت بروز شد";
            Alert_editFactor.Popup.AlertElement.ContentElement.Font = _font;
            Alert_editFactor.Popup.AlertElement.CaptionElement.TextAndButtonsElement.TextElement.Font = _font;
            Alert_editFactor.Popup.AlertElement.ContentElement.TextAlignment = ContentAlignment.MiddleRight;
            Alert_editFactor.Popup.AlertElement.CaptionElement.TextAndButtonsElement.TextAlignment = ContentAlignment.TopRight;
            Alert_editFactor.Show();

            GridInvoice.DataSource = factor.FillInvoiceGrid();
           
            if (GridInvoice.RowCount > 0)
            {
                FormaInvoiceGrid();
            }
            else
            {
                combo_LocationName.Enabled = false;
            }
        }

        private void FormaInvoiceGrid()
        {
            GridInvoice.Columns[1].IsVisible = false;
            GridInvoice.Columns[1].VisibleInColumnChooser = false;
            GridInvoice.Columns[3].IsVisible = false;
            GridInvoice.Columns[3].VisibleInColumnChooser = false;


            GridInvoice.Columns[0].TextAlignment = ContentAlignment.MiddleCenter;
            GridInvoice.Columns[2].TextAlignment = ContentAlignment.MiddleCenter;
            GridInvoice.Columns[4].TextAlignment = ContentAlignment.MiddleCenter;
            GridInvoice.Columns[5].TextAlignment = ContentAlignment.MiddleCenter;
            GridInvoice.Columns[6].TextAlignment = ContentAlignment.MiddleCenter;
            GridInvoice.Columns[6].DataType = typeof(decimal);
            GridInvoice.Columns[6].FormatString = @"{0:n0}";
        }

    }
}
