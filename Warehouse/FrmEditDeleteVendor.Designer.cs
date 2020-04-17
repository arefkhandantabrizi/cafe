using System.ComponentModel;
using System.Windows.Forms;
using HomeCafe.newvenTableAdapters;
using Telerik.WinControls.UI;

namespace HomeCafe.Warehouse
{
    partial class FrmEditDeleteVendor
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
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn2 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition2 = new Telerik.WinControls.UI.TableViewDefinition();
            this.Grid_Vendor = new Telerik.WinControls.UI.RadGridView();
            this.venBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.newven = new HomeCafe.newven();
            this.btn_Update = new Telerik.WinControls.UI.RadButton();
            this.txt_PhoneNo = new Telerik.WinControls.UI.RadMaskedEditBox();
            this.lb_phoneno = new Telerik.WinControls.UI.RadLabel();
            this.txt_Address = new Telerik.WinControls.UI.RadTextBox();
            this.lb_address = new Telerik.WinControls.UI.RadLabel();
            this.combo_Vendor = new Telerik.WinControls.UI.RadDropDownList();
            this.lb_Vendor = new Telerik.WinControls.UI.RadLabel();
            this.btn_Delete = new Telerik.WinControls.UI.RadButton();
            this.venTableAdapter = new HomeCafe.newvenTableAdapters.venTableAdapter();
            this.Alert_EditDeleteVendor = new Telerik.WinControls.UI.RadDesktopAlert(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Vendor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Vendor.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.venBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newven)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Update)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_PhoneNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lb_phoneno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Address)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lb_address)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.combo_Vendor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lb_Vendor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Delete)).BeginInit();
            this.SuspendLayout();
            // 
            // Grid_Vendor
            // 
            this.Grid_Vendor.AutoSizeRows = true;
            this.Grid_Vendor.BackColor = System.Drawing.Color.White;
            this.Grid_Vendor.Cursor = System.Windows.Forms.Cursors.Default;
            this.Grid_Vendor.Dock = System.Windows.Forms.DockStyle.Top;
            this.Grid_Vendor.Font = new System.Drawing.Font("IRANSansDNFaNum", 9.75F);
            this.Grid_Vendor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Grid_Vendor.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Grid_Vendor.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            this.Grid_Vendor.MasterTemplate.AllowAddNewRow = false;
            this.Grid_Vendor.MasterTemplate.AllowDeleteRow = false;
            this.Grid_Vendor.MasterTemplate.AllowDragToGroup = false;
            this.Grid_Vendor.MasterTemplate.AllowSearchRow = true;
            this.Grid_Vendor.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewDecimalColumn2.DataType = typeof(int);
            gridViewDecimalColumn2.EnableExpressionEditor = false;
            gridViewDecimalColumn2.FieldName = "id";
            gridViewDecimalColumn2.HeaderText = "id";
            gridViewDecimalColumn2.IsAutoGenerated = true;
            gridViewDecimalColumn2.IsVisible = false;
            gridViewDecimalColumn2.Name = "id";
            gridViewDecimalColumn2.ReadOnly = true;
            gridViewDecimalColumn2.VisibleInColumnChooser = false;
            gridViewDecimalColumn2.Width = 117;
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "نام تامین کننده";
            gridViewTextBoxColumn4.HeaderText = "نام تامین کننده";
            gridViewTextBoxColumn4.IsAutoGenerated = true;
            gridViewTextBoxColumn4.Name = "نام تامین کننده";
            gridViewTextBoxColumn4.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn4.Width = 298;
            gridViewTextBoxColumn5.EnableExpressionEditor = false;
            gridViewTextBoxColumn5.FieldName = "تلفن تماس";
            gridViewTextBoxColumn5.HeaderText = "تلفن تماس";
            gridViewTextBoxColumn5.IsAutoGenerated = true;
            gridViewTextBoxColumn5.Name = "تلفن تماس";
            gridViewTextBoxColumn5.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn5.Width = 298;
            gridViewTextBoxColumn6.EnableExpressionEditor = false;
            gridViewTextBoxColumn6.FieldName = "آدرس";
            gridViewTextBoxColumn6.HeaderText = "آدرس";
            gridViewTextBoxColumn6.IsAutoGenerated = true;
            gridViewTextBoxColumn6.Name = "آدرس";
            gridViewTextBoxColumn6.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn6.Width = 302;
            this.Grid_Vendor.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn2,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6});
            this.Grid_Vendor.MasterTemplate.DataSource = this.venBindingSource;
            this.Grid_Vendor.MasterTemplate.ViewDefinition = tableViewDefinition2;
            this.Grid_Vendor.Name = "Grid_Vendor";
            this.Grid_Vendor.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Grid_Vendor.ShowGroupPanel = false;
            this.Grid_Vendor.Size = new System.Drawing.Size(917, 357);
            this.Grid_Vendor.TabIndex = 0;
            this.Grid_Vendor.ThemeName = "TelerikMetro";
            this.Grid_Vendor.CreateCell += new Telerik.WinControls.UI.GridViewCreateCellEventHandler(this.Grid_Vendor_CreateCell);
            this.Grid_Vendor.CellFormatting += new Telerik.WinControls.UI.CellFormattingEventHandler(this.Grid_Vendor_CellFormatting);
            this.Grid_Vendor.ViewCellFormatting += new Telerik.WinControls.UI.CellFormattingEventHandler(this.Grid_Vendor_ViewCellFormatting);
            this.Grid_Vendor.CurrentRowChanged += new Telerik.WinControls.UI.CurrentRowChangedEventHandler(this.Grid_Vendor_CurrentRowChanged);
            this.Grid_Vendor.ColumnChooserItemElementCreating += new Telerik.WinControls.UI.ColumnChooserItemElementCreatingEventHandler(this.Grid_Vendor_ColumnChooserItemElementCreating);
            this.Grid_Vendor.ConditionalFormattingFormShown += new System.EventHandler(this.Grid_Vendor_ConditionalFormattingFormShown);
            this.Grid_Vendor.ContextMenuOpening += new Telerik.WinControls.UI.ContextMenuOpeningEventHandler(this.Grid_Vendor_ContextMenuOpening);
            // 
            // venBindingSource
            // 
            this.venBindingSource.DataMember = "ven";
            this.venBindingSource.DataSource = this.newven;
            // 
            // newven
            // 
            this.newven.DataSetName = "newven";
            this.newven.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_Update
            // 
            this.btn_Update.Enabled = false;
            this.btn_Update.Font = new System.Drawing.Font("IRANSansDNFaNum", 9.75F);
            this.btn_Update.Location = new System.Drawing.Point(23, 484);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(110, 39);
            this.btn_Update.TabIndex = 175;
            this.btn_Update.Text = "اصلاح";
            this.btn_Update.ThemeName = "TelerikMetro";
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // txt_PhoneNo
            // 
            this.txt_PhoneNo.Culture = new System.Globalization.CultureInfo("fa-IR");
            this.txt_PhoneNo.Font = new System.Drawing.Font("IRANSansDNFaNum", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_PhoneNo.Location = new System.Drawing.Point(498, 407);
            this.txt_PhoneNo.Mask = "(0000)-000-0000";
            this.txt_PhoneNo.MaskType = Telerik.WinControls.UI.MaskType.Standard;
            this.txt_PhoneNo.Name = "txt_PhoneNo";
            this.txt_PhoneNo.PromptChar = '-';
            this.txt_PhoneNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_PhoneNo.Size = new System.Drawing.Size(328, 32);
            this.txt_PhoneNo.TabIndex = 171;
            this.txt_PhoneNo.TabStop = false;
            this.txt_PhoneNo.Text = "(----)---------";
            this.txt_PhoneNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_PhoneNo.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txt_PhoneNo.ThemeName = "TelerikMetro";
            this.txt_PhoneNo.TextChanged += new System.EventHandler(this.txt_PhoneNo_TextChanged);
            // 
            // lb_phoneno
            // 
            this.lb_phoneno.Font = new System.Drawing.Font("IRANSansDNFaNum", 9.75F);
            this.lb_phoneno.Location = new System.Drawing.Point(832, 412);
            this.lb_phoneno.Name = "lb_phoneno";
            this.lb_phoneno.Size = new System.Drawing.Size(70, 24);
            this.lb_phoneno.TabIndex = 174;
            this.lb_phoneno.Text = "شماره تلفن:";
            this.lb_phoneno.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            this.lb_phoneno.ThemeName = "TelerikMetro";
            // 
            // txt_Address
            // 
            this.txt_Address.AcceptsReturn = true;
            this.txt_Address.AutoScroll = true;
            this.txt_Address.Font = new System.Drawing.Font("IRANSansDNFaNum", 9.75F);
            this.txt_Address.Location = new System.Drawing.Point(23, 363);
            this.txt_Address.Multiline = true;
            this.txt_Address.Name = "txt_Address";
            // 
            // 
            // 
            this.txt_Address.RootElement.StretchVertically = true;
            this.txt_Address.Size = new System.Drawing.Size(357, 115);
            this.txt_Address.TabIndex = 172;
            this.txt_Address.ThemeName = "TelerikMetro";
            this.txt_Address.TextChanged += new System.EventHandler(this.txt_Address_TextChanged);
            this.txt_Address.Enter += new System.EventHandler(this.txt_Address_Enter);
            this.txt_Address.Leave += new System.EventHandler(this.txt_Address_Leave);
            // 
            // lb_address
            // 
            this.lb_address.Font = new System.Drawing.Font("IRANSansDNFaNum", 9.75F);
            this.lb_address.Location = new System.Drawing.Point(386, 365);
            this.lb_address.Name = "lb_address";
            this.lb_address.Size = new System.Drawing.Size(42, 24);
            this.lb_address.TabIndex = 173;
            this.lb_address.Text = "آدرس:";
            this.lb_address.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            this.lb_address.ThemeName = "TelerikMetro";
            // 
            // combo_Vendor
            // 
            this.combo_Vendor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.combo_Vendor.Font = new System.Drawing.Font("IRANSansDNFaNum", 9.75F);
            this.combo_Vendor.Location = new System.Drawing.Point(498, 363);
            this.combo_Vendor.Name = "combo_Vendor";
            this.combo_Vendor.Size = new System.Drawing.Size(331, 31);
            this.combo_Vendor.TabIndex = 170;
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
            this.lb_Vendor.Font = new System.Drawing.Font("IRANSansDNFaNum", 9.75F);
            this.lb_Vendor.Location = new System.Drawing.Point(835, 365);
            this.lb_Vendor.Name = "lb_Vendor";
            this.lb_Vendor.Size = new System.Drawing.Size(72, 24);
            this.lb_Vendor.TabIndex = 169;
            this.lb_Vendor.Text = "تامین کننده:";
            this.lb_Vendor.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // btn_Delete
            // 
            this.btn_Delete.Font = new System.Drawing.Font("IRANSansDNFaNum", 9.75F);
            this.btn_Delete.Location = new System.Drawing.Point(150, 484);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(110, 39);
            this.btn_Delete.TabIndex = 176;
            this.btn_Delete.Text = "حذف";
            this.btn_Delete.ThemeName = "TelerikMetro";
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // venTableAdapter
            // 
            this.venTableAdapter.ClearBeforeFill = true;
            // 
            // Alert_EditDeleteVendor
            // 
            this.Alert_EditDeleteVendor.CanMove = false;
            this.Alert_EditDeleteVendor.ContentImage = global::HomeCafe.Properties.Resources.success_Alert;
            this.Alert_EditDeleteVendor.ThemeName = "TelerikMetro";
            // 
            // FrmEditDeleteVendor
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(917, 535);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.txt_PhoneNo);
            this.Controls.Add(this.lb_phoneno);
            this.Controls.Add(this.txt_Address);
            this.Controls.Add(this.lb_address);
            this.Controls.Add(this.combo_Vendor);
            this.Controls.Add(this.lb_Vendor);
            this.Controls.Add(this.Grid_Vendor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmEditDeleteVendor";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "FrmEditDeleteVendor";
            this.Load += new System.EventHandler(this.frm_EditDeleteVendor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Vendor.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Vendor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.venBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newven)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Update)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_PhoneNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lb_phoneno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Address)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lb_address)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.combo_Vendor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lb_Vendor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Delete)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RadGridView Grid_Vendor;
        private RadButton btn_Update;
        private RadMaskedEditBox txt_PhoneNo;
        private RadLabel lb_phoneno;
        private RadTextBox txt_Address;
        private RadLabel lb_address;
        private RadDropDownList combo_Vendor;
        private RadLabel lb_Vendor;
        private RadButton btn_Delete;
        private newven newven;
        private BindingSource venBindingSource;
        private venTableAdapter venTableAdapter;
        private RadDesktopAlert Alert_EditDeleteVendor;
    }
}