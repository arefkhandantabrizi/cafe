using System;
using System.Drawing;
using HomeCafe.DataBase;
using HomeCafe.Index_and_Login;
using HomeCafe.My_Custom_Classes;
using Telerik.WinControls.UI;

namespace HomeCafe.Warehouse
{
    public partial class FrmAddVendor : RadForm
    {
        private readonly IFixLanguageAndForms _fixLanguageAndForms;

        public FrmAddVendor(IFixLanguageAndForms fixLanguageAndForms)
        {
            _fixLanguageAndForms = fixLanguageAndForms;
            InitializeComponent();
        }

        private void combo_Vendor_Enter(object sender, EventArgs e)
        {
           _fixLanguageAndForms.FixLanguage();
        }

        private void combo_Vendor_Leave(object sender, EventArgs e)
        {
            _fixLanguageAndForms.OriginalLanguage();  
        }

        private void combo_Vendor_TextChanged(object sender, EventArgs e)
        {
            combo_Vendor.DropDownListElement.AutoCompleteSuggest.SuggestMode = SuggestMode.Contains;
            btn_Save.Enabled = !combo_Vendor.Items.Contains(combo_Vendor.Text.Trim());
        }

        private void frm_AddVendor_Load(object sender, EventArgs e)
        {
            Text = string.Format("افزودن تامین کننده" + "        " + "کاربر:" + " " + FrmLogin.FormUser);

            var venderFill = new Vendor(new MyDatabase());

            foreach (var name in venderFill.FillName())
            {
                combo_Vendor.Items.Add(name);
            }

            combo_Vendor.SelectedIndex = -1;

            btn_Save.Enabled = false;
        }

        private void txt_Address_Enter(object sender, EventArgs e)
        {
            _fixLanguageAndForms.FixLanguage();
        }

        private void txt_Address_Leave(object sender, EventArgs e)
        {
            _fixLanguageAndForms.OriginalLanguage();  
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            var vender = new Vendor(new MyDatabase())
            {
                Address = txt_Address.Text.Trim(),
                Name = combo_Vendor.Text.Trim(),
                PhoneNumber = txt_PhoneNo.Value.ToString() 
            };

            if(!vender.Save()) return;
                
            Vendor_Alert.CaptionText = "توجه";
            Vendor_Alert.ContentText = "." + "اطلاعات با موفقیت ثبت شد";
            Vendor_Alert.Popup.AlertElement.ContentElement.Font = new Font("IRANSansDNFaNum", 12.0f, FontStyle.Regular);
            Vendor_Alert.Popup.AlertElement.CaptionElement.TextAndButtonsElement.TextElement.Font = new Font("IRANSansDNFaNum", 11.0f, FontStyle.Regular);
            Vendor_Alert.Popup.AlertElement.ContentElement.TextAlignment = ContentAlignment.MiddleRight;
            Vendor_Alert.Popup.AlertElement.CaptionElement.TextAndButtonsElement.TextAlignment = ContentAlignment.TopLeft;
            Vendor_Alert.Show();

            combo_Vendor.Items.Clear();

            var venderFill = new Vendor(new MyDatabase());

            foreach (var name in venderFill.FillName())
            {
                combo_Vendor.Items.Add(name);
            }

            combo_Vendor.SelectedIndex = -1;
            txt_PhoneNo.Value = null;
            txt_Address.Text = null;
          
        }

    
    }
}
