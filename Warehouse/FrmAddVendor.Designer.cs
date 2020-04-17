using System.ComponentModel;
using Telerik.WinControls.UI;

namespace HomeCafe.Warehouse
{
    partial class FrmAddVendor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddVendor));
            this.combo_Vendor = new Telerik.WinControls.UI.RadDropDownList();
            this.lb_Vendor = new Telerik.WinControls.UI.RadLabel();
            this.txt_PhoneNo = new Telerik.WinControls.UI.RadMaskedEditBox();
            this.lb_phoneno = new Telerik.WinControls.UI.RadLabel();
            this.txt_Address = new Telerik.WinControls.UI.RadTextBox();
            this.lb_address = new Telerik.WinControls.UI.RadLabel();
            this.btn_Save = new Telerik.WinControls.UI.RadButton();
            this.Vendor_Alert = new Telerik.WinControls.UI.RadDesktopAlert(this.components);
            this.telerikMetroTheme1 = new Telerik.WinControls.Themes.TelerikMetroTheme();
            ((System.ComponentModel.ISupportInitialize)(this.combo_Vendor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lb_Vendor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_PhoneNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lb_phoneno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Address)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lb_address)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Save)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // combo_Vendor
            // 
            this.combo_Vendor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.combo_Vendor.Font = new System.Drawing.Font("IRANSansDNFaNum", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_Vendor.Location = new System.Drawing.Point(12, 12);
            this.combo_Vendor.Name = "combo_Vendor";
            this.combo_Vendor.Size = new System.Drawing.Size(299, 31);
            this.combo_Vendor.TabIndex = 0;
            this.combo_Vendor.ThemeName = "TelerikMetro";
            this.combo_Vendor.TextChanged += new System.EventHandler(this.combo_Vendor_TextChanged);
            this.combo_Vendor.Enter += new System.EventHandler(this.combo_Vendor_Enter);
            this.combo_Vendor.Leave += new System.EventHandler(this.combo_Vendor_Leave);
            ((Telerik.WinControls.UI.RadDropDownListElement)(this.combo_Vendor.GetChildAt(0))).RightToLeft = true;
            ((Telerik.WinControls.UI.RadDropDownListElement)(this.combo_Vendor.GetChildAt(0))).Font = new System.Drawing.Font("IRANSansDNFaNum", 9.75F);
            ((Telerik.WinControls.UI.RadDropDownListElement)(this.combo_Vendor.GetChildAt(0).GetChildAt(3))).Font = new System.Drawing.Font("IRANSansDNFaNum", 9.75F);
            ((Telerik.WinControls.UI.RadDropDownListElement)(this.combo_Vendor.GetChildAt(0).GetChildAt(3))).Visibility = Telerik.WinControls.ElementVisibility.Hidden;
            // 
            // lb_Vendor
            // 
            this.lb_Vendor.Font = new System.Drawing.Font("IRANSansDNFaNum", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lb_Vendor.Location = new System.Drawing.Point(319, 17);
            this.lb_Vendor.Name = "lb_Vendor";
            this.lb_Vendor.Size = new System.Drawing.Size(72, 24);
            this.lb_Vendor.TabIndex = 162;
            this.lb_Vendor.Text = "تامین کننده:";
            this.lb_Vendor.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // txt_PhoneNo
            // 
            this.txt_PhoneNo.Culture = new System.Globalization.CultureInfo("fa-IR");
            this.txt_PhoneNo.Font = new System.Drawing.Font("IRANSansDNFaNum", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_PhoneNo.Location = new System.Drawing.Point(12, 53);
            this.txt_PhoneNo.Mask = "(0000)-000-0000";
            this.txt_PhoneNo.MaskType = Telerik.WinControls.UI.MaskType.Standard;
            this.txt_PhoneNo.Name = "txt_PhoneNo";
            this.txt_PhoneNo.PromptChar = '-';
            this.txt_PhoneNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_PhoneNo.Size = new System.Drawing.Size(300, 32);
            this.txt_PhoneNo.TabIndex = 1;
            this.txt_PhoneNo.TabStop = false;
            this.txt_PhoneNo.Text = "(----)---------";
            this.txt_PhoneNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_PhoneNo.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txt_PhoneNo.ThemeName = "TelerikMetro";
            // 
            // lb_phoneno
            // 
            this.lb_phoneno.Font = new System.Drawing.Font("IRANSansDNFaNum", 9.75F);
            this.lb_phoneno.Location = new System.Drawing.Point(319, 53);
            this.lb_phoneno.Name = "lb_phoneno";
            this.lb_phoneno.Size = new System.Drawing.Size(70, 24);
            this.lb_phoneno.TabIndex = 167;
            this.lb_phoneno.Text = "شماره تلفن:";
            this.lb_phoneno.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            this.lb_phoneno.ThemeName = "TelerikMetro";
            // 
            // txt_Address
            // 
            this.txt_Address.AcceptsReturn = true;
            this.txt_Address.AutoScroll = true;
            this.txt_Address.Font = new System.Drawing.Font("IRANSansDNFaNum", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_Address.Location = new System.Drawing.Point(12, 94);
            this.txt_Address.Multiline = true;
            this.txt_Address.Name = "txt_Address";
            // 
            // 
            // 
            this.txt_Address.RootElement.StretchVertically = true;
            this.txt_Address.Size = new System.Drawing.Size(301, 47);
            this.txt_Address.TabIndex = 2;
            this.txt_Address.ThemeName = "TelerikMetro";
            this.txt_Address.Enter += new System.EventHandler(this.txt_Address_Enter);
            this.txt_Address.Leave += new System.EventHandler(this.txt_Address_Leave);
            // 
            // lb_address
            // 
            this.lb_address.Font = new System.Drawing.Font("IRANSansDNFaNum", 9.75F);
            this.lb_address.Location = new System.Drawing.Point(319, 94);
            this.lb_address.Name = "lb_address";
            this.lb_address.Size = new System.Drawing.Size(42, 24);
            this.lb_address.TabIndex = 166;
            this.lb_address.Text = "آدرس:";
            this.lb_address.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            this.lb_address.ThemeName = "TelerikMetro";
            // 
            // btn_Save
            // 
            this.btn_Save.Enabled = false;
            this.btn_Save.Font = new System.Drawing.Font("IRANSansDNFaNum", 9.75F);
            this.btn_Save.Location = new System.Drawing.Point(12, 150);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(110, 39);
            this.btn_Save.TabIndex = 3;
            this.btn_Save.Text = "ثبت";
            this.btn_Save.ThemeName = "TelerikMetro";
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // Vendor_Alert
            // 
            this.Vendor_Alert.CanMove = false;
            this.Vendor_Alert.CaptionText = "توجه";
            this.Vendor_Alert.ContentImage = global::HomeCafe.Properties.Resources.success_Alert;
            this.Vendor_Alert.Opacity = 1F;
            this.Vendor_Alert.ShowOptionsButton = false;
            this.Vendor_Alert.ThemeName = "TelerikMetro";
            // 
            // FrmAddVendor
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(389, 201);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.txt_PhoneNo);
            this.Controls.Add(this.lb_phoneno);
            this.Controls.Add(this.txt_Address);
            this.Controls.Add(this.lb_address);
            this.Controls.Add(this.combo_Vendor);
            this.Controls.Add(this.lb_Vendor);
            this.Font = new System.Drawing.Font("IRANSansDNFaNum", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAddVendor";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "";
            this.ThemeName = "TelerikMetro";
            this.Load += new System.EventHandler(this.frm_AddVendor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.combo_Vendor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lb_Vendor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_PhoneNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lb_phoneno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Address)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lb_address)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Save)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RadDropDownList combo_Vendor;
        private RadLabel lb_Vendor;
        private RadMaskedEditBox txt_PhoneNo;
        private RadLabel lb_phoneno;
        private RadTextBox txt_Address;
        private RadLabel lb_address;
        private RadButton btn_Save;
        private RadDesktopAlert Vendor_Alert;
        private Telerik.WinControls.Themes.TelerikMetroTheme telerikMetroTheme1;
    }
}