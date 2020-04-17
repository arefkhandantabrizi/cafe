using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;
using HomeCafe.DataBase;
using HomeCafe.My_Custom_Classes;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using Telerik.WinControls.UI.Localization;

namespace HomeCafe.Warehouse
{
    public partial class FrmEditDeleteVendor : Form 
    {
        private readonly IFixLanguageAndForms _fixLanguageAndForms;
        private readonly Font _font = new Font("IRANSansDNFaNum", 10.0f, FontStyle.Regular);

        public FrmEditDeleteVendor(IFixLanguageAndForms fixLanguageAndForms)
        {
            _fixLanguageAndForms = fixLanguageAndForms;
            InitializeComponent();
            RadGridLocalizationProvider.CurrentProvider = new MyPersianRadGridLocalizationProvider();
            Grid_Vendor.ColumnChooser.Shown += ColumnChooser_Shown;

        }

        private void ColumnChooser_Shown(object sender, EventArgs e)
        {
            Grid_Vendor.ColumnChooser.ColumnChooserControl.ColumnChooserElement.Font = _font;
        }

        private void frm_EditDeleteVendor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'newven.ven' table. You can move, or remove it, as needed.
            venTableAdapter.Fill(newven.ven);
            // TODO: This line of code loads data into the 'vendor._vendor' table. You can move, or remove it, as needed.

            var venderFill = new Vendor(new MyDatabase());

            foreach (var name in venderFill.FillName())
            {
                combo_Vendor.Items.Add(name);
            }

            combo_Vendor.SelectedIndex = -1;

            if (Grid_Vendor.RowCount <= 0) return;
            combo_Vendor.Text = string.Format("{0}", Grid_Vendor.CurrentRow.Cells[1].Value);
            txt_Address.Text = string.Format("{0}", Grid_Vendor.CurrentRow.Cells[3].Value);
            txt_PhoneNo.Value = Grid_Vendor.CurrentRow.Cells[2].Value.ToString();
        }

        private void Grid_Vendor_CellFormatting(object sender, CellFormattingEventArgs e)
        {
            e.CellElement.Font = _font;
        }

        private void Grid_Vendor_ColumnChooserItemElementCreating(object sender, ColumnChooserItemElementCreatingEventArgs e)
        {
            e.ItemElement.Font = _font;
            e.GridViewElement.Font = _font;
        }

        private void Grid_Vendor_ConditionalFormattingFormShown(object sender, EventArgs e)
        {
            ConditionalFormattingForm form = (ConditionalFormattingForm)sender;
            SetFormFont(form.Controls);
        }

        private static readonly Font F = new Font("IRANSansDNFaNum", 9.0f, FontStyle.Regular);
        private static void SetFormFont(IEnumerable controls)
        {
            foreach (Control c in controls)
            {
                c.Font = F;
                if (c.HasChildren)
                {
                    SetFormFont(c.Controls);
                }
            }


        }

        private void Grid_Vendor_ContextMenuOpening(object sender, ContextMenuOpeningEventArgs e)
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

        private void Grid_Vendor_CreateCell(object sender, GridViewCreateCellEventArgs e)
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

        private void Grid_Vendor_ViewCellFormatting(object sender, CellFormattingEventArgs e)
        {
            e.CellElement.Font = _font;
        }

        private void combo_Vendor_Enter(object sender, EventArgs e)
        {
            _fixLanguageAndForms.FixLanguage();

        }

        private void combo_Vendor_Leave(object sender, EventArgs e)
        {
            _fixLanguageAndForms.OriginalLanguage();
        }

        private void txt_Address_Enter(object sender, EventArgs e)
        {
            _fixLanguageAndForms.FixLanguage();
        }

        private void txt_Address_Leave(object sender, EventArgs e)
        {
            _fixLanguageAndForms.OriginalLanguage();
        }

        private void combo_Vendor_TextChanged(object sender, EventArgs e)
        {
            combo_Vendor.DropDownListElement.AutoCompleteSuggest.SuggestMode = SuggestMode.Contains;
            btn_Update.Enabled = !combo_Vendor.Items.Contains(combo_Vendor.Text.Trim());
          
        }

        private void Grid_Vendor_CurrentRowChanged(object sender, CurrentRowChangedEventArgs e)
        {
            if (Grid_Vendor.RowCount <= 0) return;
            combo_Vendor.Text = string.Format("{0}", Grid_Vendor.CurrentRow.Cells[1].Value);
            txt_Address.Text = string.Format("{0}", Grid_Vendor.CurrentRow.Cells[3].Value);
            if (txt_PhoneNo != null) txt_PhoneNo.Value = Grid_Vendor.CurrentRow.Cells[2].Value.ToString();
        }

        private void txt_PhoneNo_TextChanged(object sender, EventArgs e)
        {
            btn_Update.Enabled = true;
        }

        private void txt_Address_TextChanged(object sender, EventArgs e)
        {
            btn_Update.Enabled = true;
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            var vendor = new Vendor(new MyDatabase())
            {
                Name = combo_Vendor.Text.Trim(),
                PhoneNumber = txt_PhoneNo.Value.ToString(), 
                Address = txt_Address.Text.Trim(),
                Id = Convert.ToInt32(Grid_Vendor.CurrentRow.Cells[0].Value.ToString())
            };

            var result = vendor.UpDate();

            if(!result) return;
            
            Alert_EditDeleteVendor.CaptionText = "توجه";
            Alert_EditDeleteVendor.ContentText = "." + "اطلاعات با موفقیت بروز شد";
            Alert_EditDeleteVendor.Popup.AlertElement.ContentElement.Font = new Font("IRANSansDNFaNum", 12.0f, FontStyle.Regular);
            Alert_EditDeleteVendor.Popup.AlertElement.CaptionElement.TextAndButtonsElement.TextElement.Font = new Font("IRANSansDNFaNum", 11.0f, FontStyle.Regular);
            Alert_EditDeleteVendor.Popup.AlertElement.ContentElement.TextAlignment = ContentAlignment.MiddleRight;
            Alert_EditDeleteVendor.Popup.AlertElement.CaptionElement.TextAndButtonsElement.TextAlignment = ContentAlignment.TopRight;
            Alert_EditDeleteVendor.Show();

            venTableAdapter.Fill(newven.ven);

            combo_Vendor.Items.Clear();

            var venderFill = new Vendor(new MyDatabase());

            foreach (var name in venderFill.FillName())
            {
                combo_Vendor.Items.Add(name);
            }

            combo_Vendor.SelectedIndex = -1;

            if (Grid_Vendor.RowCount <= 0) return;
            combo_Vendor.Text = string.Format("{0}", Grid_Vendor.CurrentRow.Cells[1].Value);
            txt_Address.Text = string.Format("{0}", Grid_Vendor.CurrentRow.Cells[3].Value);
            txt_PhoneNo.Value = Grid_Vendor.CurrentRow.Cells[2].Value.ToString();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            var vendor = new Vendor(new MyDatabase())
            {
                Id = Convert.ToInt32(Grid_Vendor.CurrentRow.Cells[0].Value.ToString())
            };

            var result = vendor.Delete();
            if (!result) return;

            Alert_EditDeleteVendor.CaptionText = "توجه";
            Alert_EditDeleteVendor.ContentText = "." + "نامین کننده مورد نظر با موفقیت حذف شد";
            Alert_EditDeleteVendor.Popup.AlertElement.ContentElement.Font = new Font("IRANSansDNFaNum", 12.0f, FontStyle.Regular);
            Alert_EditDeleteVendor.Popup.AlertElement.CaptionElement.TextAndButtonsElement.TextElement.Font = new Font("IRANSansDNFaNum", 11.0f, FontStyle.Regular);
            Alert_EditDeleteVendor.Popup.AlertElement.ContentElement.TextAlignment = ContentAlignment.MiddleRight;
            Alert_EditDeleteVendor.Popup.AlertElement.CaptionElement.TextAndButtonsElement.TextAlignment = ContentAlignment.TopRight;
            Alert_EditDeleteVendor.Show();

            venTableAdapter.Fill(newven.ven);

            combo_Vendor.Items.Clear();

            var venderFill = new Vendor(new MyDatabase());

            foreach (var name in venderFill.FillName())
            {
                combo_Vendor.Items.Add(name);
            }

            combo_Vendor.SelectedIndex = -1;

            if (Grid_Vendor.RowCount <= 0) return;
            combo_Vendor.Text = string.Format("{0}", Grid_Vendor.CurrentRow.Cells[1].Value);
            txt_Address.Text = string.Format("{0}", Grid_Vendor.CurrentRow.Cells[3].Value);
            txt_PhoneNo.Value = Grid_Vendor.CurrentRow.Cells[2].Value.ToString();

        }
    
    }
}
