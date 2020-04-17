namespace HomeCafe.Cashier
{
    partial class FrmEditFactors
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.telerikMetroTheme1 = new Telerik.WinControls.Themes.TelerikMetroTheme();
            this.editBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.edit = new HomeCafe.edit();
            this.editTableAdapter = new HomeCafe.editTableAdapters.editTableAdapter();
            this.Panel_Invoice = new Telerik.WinControls.UI.RadPanel();
            this.Group_Invoice = new Telerik.WinControls.UI.RadGroupBox();
            this.GridInvoice = new Telerik.WinControls.UI.RadGridView();
            this.Panel_Table = new Telerik.WinControls.UI.RadPanel();
            this.GroupBox_Table = new Telerik.WinControls.UI.RadGroupBox();
            this.lb_TableName = new Telerik.WinControls.UI.RadLabel();
            this.combo_TableName = new Telerik.WinControls.UI.RadDropDownList();
            this.lb_TableLocation = new Telerik.WinControls.UI.RadLabel();
            this.combo_LocationName = new Telerik.WinControls.UI.RadDropDownList();
            this.txt_FactorDate = new Telerik.WinControls.UI.RadDateTimePicker();
            this.btn_Update = new Telerik.WinControls.UI.RadButton();
            this.Alert_editFactor = new Telerik.WinControls.UI.RadDesktopAlert(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.editBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Panel_Invoice)).BeginInit();
            this.Panel_Invoice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Group_Invoice)).BeginInit();
            this.Group_Invoice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridInvoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridInvoice.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Panel_Table)).BeginInit();
            this.Panel_Table.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GroupBox_Table)).BeginInit();
            this.GroupBox_Table.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lb_TableName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.combo_TableName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lb_TableLocation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.combo_LocationName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_FactorDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Update)).BeginInit();
            this.SuspendLayout();
            // 
            // editBindingSource
            // 
            this.editBindingSource.DataMember = "edit";
            this.editBindingSource.DataSource = this.edit;
            // 
            // edit
            // 
            this.edit.DataSetName = "edit";
            this.edit.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // editTableAdapter
            // 
            this.editTableAdapter.ClearBeforeFill = true;
            // 
            // Panel_Invoice
            // 
            this.Panel_Invoice.Controls.Add(this.Group_Invoice);
            this.Panel_Invoice.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_Invoice.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Panel_Invoice.Location = new System.Drawing.Point(0, 0);
            this.Panel_Invoice.Name = "Panel_Invoice";
            this.Panel_Invoice.Size = new System.Drawing.Size(934, 345);
            this.Panel_Invoice.TabIndex = 8;
            this.Panel_Invoice.ThemeName = "TelerikMetro";
            // 
            // Group_Invoice
            // 
            this.Group_Invoice.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.Group_Invoice.Controls.Add(this.GridInvoice);
            this.Group_Invoice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Group_Invoice.Font = new System.Drawing.Font("IRANSansDNFaNum", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Group_Invoice.HeaderText = "انتخاب فاکتور";
            this.Group_Invoice.Location = new System.Drawing.Point(0, 0);
            this.Group_Invoice.Name = "Group_Invoice";
            this.Group_Invoice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Group_Invoice.Size = new System.Drawing.Size(934, 345);
            this.Group_Invoice.TabIndex = 0;
            this.Group_Invoice.Text = "انتخاب فاکتور";
            this.Group_Invoice.ThemeName = "TelerikMetro";
            ((Telerik.WinControls.UI.GroupBoxHeader)(this.Group_Invoice.GetChildAt(0).GetChildAt(1))).Font = new System.Drawing.Font("IRANSansDNFaNum", 9.75F);
            // 
            // GridInvoice
            // 
            this.GridInvoice.AutoSizeRows = true;
            this.GridInvoice.BackColor = System.Drawing.Color.White;
            this.GridInvoice.Cursor = System.Windows.Forms.Cursors.Default;
            this.GridInvoice.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GridInvoice.Font = new System.Drawing.Font("IRANSansDNFaNum", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.GridInvoice.ForeColor = System.Drawing.SystemColors.ControlText;
            this.GridInvoice.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.GridInvoice.Location = new System.Drawing.Point(2, 36);
            // 
            // 
            // 
            this.GridInvoice.MasterTemplate.AllowAddNewRow = false;
            this.GridInvoice.MasterTemplate.AllowDeleteRow = false;
            this.GridInvoice.MasterTemplate.AllowSearchRow = true;
            this.GridInvoice.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.GridInvoice.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.GridInvoice.Name = "GridInvoice";
            this.GridInvoice.ReadOnly = true;
            this.GridInvoice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.GridInvoice.ShowGroupPanel = false;
            this.GridInvoice.Size = new System.Drawing.Size(930, 307);
            this.GridInvoice.TabIndex = 0;
            this.GridInvoice.ThemeName = "TelerikMetro";
            this.GridInvoice.CreateCell += new Telerik.WinControls.UI.GridViewCreateCellEventHandler(this.GridInvoice_CreateCell);
            this.GridInvoice.CellFormatting += new Telerik.WinControls.UI.CellFormattingEventHandler(this.GridInvoice_CellFormatting);
            this.GridInvoice.ViewCellFormatting += new Telerik.WinControls.UI.CellFormattingEventHandler(this.GridInvoice_ViewCellFormatting);
            this.GridInvoice.ColumnChooserItemElementCreating += new Telerik.WinControls.UI.ColumnChooserItemElementCreatingEventHandler(this.GridInvoice_ColumnChooserItemElementCreating);
            this.GridInvoice.ConditionalFormattingFormShown += new System.EventHandler(this.GridInvoice_ConditionalFormattingFormShown);
            this.GridInvoice.ContextMenuOpening += new Telerik.WinControls.UI.ContextMenuOpeningEventHandler(this.GridInvoice_ContextMenuOpening);
            // 
            // Panel_Table
            // 
            this.Panel_Table.Controls.Add(this.GroupBox_Table);
            this.Panel_Table.Location = new System.Drawing.Point(4, 351);
            this.Panel_Table.Name = "Panel_Table";
            this.Panel_Table.Size = new System.Drawing.Size(930, 101);
            this.Panel_Table.TabIndex = 7;
            this.Panel_Table.ThemeName = "TelerikMetro";
            // 
            // GroupBox_Table
            // 
            this.GroupBox_Table.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.GroupBox_Table.Controls.Add(this.lb_TableName);
            this.GroupBox_Table.Controls.Add(this.combo_TableName);
            this.GroupBox_Table.Controls.Add(this.lb_TableLocation);
            this.GroupBox_Table.Controls.Add(this.combo_LocationName);
            this.GroupBox_Table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupBox_Table.Font = new System.Drawing.Font("IRANSansDNFaNum", 9.75F);
            this.GroupBox_Table.HeaderText = "انتخاب میز";
            this.GroupBox_Table.Location = new System.Drawing.Point(0, 0);
            this.GroupBox_Table.Name = "GroupBox_Table";
            this.GroupBox_Table.Size = new System.Drawing.Size(930, 101);
            this.GroupBox_Table.TabIndex = 0;
            this.GroupBox_Table.Text = "انتخاب میز";
            this.GroupBox_Table.ThemeName = "TelerikMetro";
            ((Telerik.WinControls.UI.GroupBoxHeader)(this.GroupBox_Table.GetChildAt(0).GetChildAt(1))).Font = new System.Drawing.Font("IRANSansDNFaNum", 9.75F);
            // 
            // lb_TableName
            // 
            this.lb_TableName.Font = new System.Drawing.Font("IRANSansDNFaNum", 9.75F);
            this.lb_TableName.Location = new System.Drawing.Point(335, 37);
            this.lb_TableName.Name = "lb_TableName";
            this.lb_TableName.Size = new System.Drawing.Size(47, 24);
            this.lb_TableName.TabIndex = 26;
            this.lb_TableName.Text = "نام میز:";
            this.lb_TableName.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            this.lb_TableName.ThemeName = "TelerikMetro";
            // 
            // combo_TableName
            // 
            this.combo_TableName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.combo_TableName.Font = new System.Drawing.Font("IRANSansDNFaNum", 9.75F);
            this.combo_TableName.Location = new System.Drawing.Point(31, 35);
            this.combo_TableName.Name = "combo_TableName";
            this.combo_TableName.Size = new System.Drawing.Size(298, 31);
            this.combo_TableName.TabIndex = 25;
            this.combo_TableName.ThemeName = "TelerikMetro";
            this.combo_TableName.TextChanged += new System.EventHandler(this.combo_TableName_TextChanged);
            this.combo_TableName.Enter += new System.EventHandler(this.combo_TableName_Enter);
            this.combo_TableName.Leave += new System.EventHandler(this.combo_TableName_Leave);
            ((Telerik.WinControls.UI.RadDropDownListElement)(this.combo_TableName.GetChildAt(0))).RightToLeft = true;
            ((Telerik.WinControls.UI.RadDropDownListElement)(this.combo_TableName.GetChildAt(0))).Font = new System.Drawing.Font("IRANSansDNFaNum", 9.75F);
            ((Telerik.WinControls.UI.RadDropDownListElement)(this.combo_TableName.GetChildAt(0).GetChildAt(3))).Font = new System.Drawing.Font("IRANSansDNFaNum", 9.75F);
            ((Telerik.WinControls.UI.RadDropDownListElement)(this.combo_TableName.GetChildAt(0).GetChildAt(3))).Visibility = Telerik.WinControls.ElementVisibility.Hidden;
            // 
            // lb_TableLocation
            // 
            this.lb_TableLocation.Font = new System.Drawing.Font("IRANSansDNFaNum", 9.75F);
            this.lb_TableLocation.Location = new System.Drawing.Point(816, 37);
            this.lb_TableLocation.Name = "lb_TableLocation";
            this.lb_TableLocation.Size = new System.Drawing.Size(62, 24);
            this.lb_TableLocation.TabIndex = 24;
            this.lb_TableLocation.Text = " محل میز:";
            this.lb_TableLocation.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            this.lb_TableLocation.ThemeName = "TelerikMetro";
            // 
            // combo_LocationName
            // 
            this.combo_LocationName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.combo_LocationName.Font = new System.Drawing.Font("IRANSansDNFaNum", 9.75F);
            this.combo_LocationName.Location = new System.Drawing.Point(512, 35);
            this.combo_LocationName.Name = "combo_LocationName";
            this.combo_LocationName.Size = new System.Drawing.Size(298, 31);
            this.combo_LocationName.TabIndex = 23;
            this.combo_LocationName.ThemeName = "TelerikMetro";
            this.combo_LocationName.TextChanged += new System.EventHandler(this.combo_LocationName_TextChanged);
            this.combo_LocationName.Enter += new System.EventHandler(this.combo_LocationName_Enter);
            this.combo_LocationName.Leave += new System.EventHandler(this.combo_LocationName_Leave);
            ((Telerik.WinControls.UI.RadDropDownListElement)(this.combo_LocationName.GetChildAt(0))).RightToLeft = true;
            ((Telerik.WinControls.UI.RadDropDownListElement)(this.combo_LocationName.GetChildAt(0))).Font = new System.Drawing.Font("IRANSansDNFaNum", 9.75F);
            ((Telerik.WinControls.UI.RadDropDownListElement)(this.combo_LocationName.GetChildAt(0).GetChildAt(3))).Font = new System.Drawing.Font("IRANSansDNFaNum", 9.75F);
            ((Telerik.WinControls.UI.RadDropDownListElement)(this.combo_LocationName.GetChildAt(0).GetChildAt(3))).Visibility = Telerik.WinControls.ElementVisibility.Hidden;
            // 
            // txt_FactorDate
            // 
            this.txt_FactorDate.Culture = new System.Globalization.CultureInfo("fa-IR");
            this.txt_FactorDate.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_FactorDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_FactorDate.Location = new System.Drawing.Point(575, 458);
            this.txt_FactorDate.Name = "txt_FactorDate";
            this.txt_FactorDate.Size = new System.Drawing.Size(277, 35);
            this.txt_FactorDate.TabIndex = 10;
            this.txt_FactorDate.TabStop = false;
            this.txt_FactorDate.Text = "03/23/2019";
            this.txt_FactorDate.ThemeName = "TelerikMetro";
            this.txt_FactorDate.Value = new System.DateTime(2019, 3, 23, 20, 43, 24, 699);
            this.txt_FactorDate.Visible = false;
            // 
            // btn_Update
            // 
            this.btn_Update.Font = new System.Drawing.Font("IRANSansDNFaNum", 9.75F);
            this.btn_Update.Location = new System.Drawing.Point(12, 476);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(110, 38);
            this.btn_Update.TabIndex = 11;
            this.btn_Update.Text = "بروزرسانی";
            this.btn_Update.ThemeName = "TelerikMetro";
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // Alert_editFactor
            // 
            this.Alert_editFactor.CanMove = false;
            this.Alert_editFactor.ContentImage = global::HomeCafe.Properties.Resources.success_Alert;
            this.Alert_editFactor.ThemeName = "TelerikMetro";
            // 
            // FrmEditFactors
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(934, 526);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.txt_FactorDate);
            this.Controls.Add(this.Panel_Invoice);
            this.Controls.Add(this.Panel_Table);
            this.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmEditFactors";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "FrmEditFactors";
            this.Load += new System.EventHandler(this.frm_EditFactors_Load);
            ((System.ComponentModel.ISupportInitialize)(this.editBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Panel_Invoice)).EndInit();
            this.Panel_Invoice.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Group_Invoice)).EndInit();
            this.Group_Invoice.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridInvoice.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridInvoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Panel_Table)).EndInit();
            this.Panel_Table.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GroupBox_Table)).EndInit();
            this.GroupBox_Table.ResumeLayout(false);
            this.GroupBox_Table.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lb_TableName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.combo_TableName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lb_TableLocation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.combo_LocationName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_FactorDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Update)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.Themes.TelerikMetroTheme telerikMetroTheme1;
        private edit edit;
        private System.Windows.Forms.BindingSource editBindingSource;
        private editTableAdapters.editTableAdapter editTableAdapter;
        private Telerik.WinControls.UI.RadPanel Panel_Invoice;
        private Telerik.WinControls.UI.RadGroupBox Group_Invoice;
        private Telerik.WinControls.UI.RadGridView GridInvoice;
        private Telerik.WinControls.UI.RadPanel Panel_Table;
        private Telerik.WinControls.UI.RadGroupBox GroupBox_Table;
        private Telerik.WinControls.UI.RadLabel lb_TableName;
        private Telerik.WinControls.UI.RadDropDownList combo_TableName;
        private Telerik.WinControls.UI.RadLabel lb_TableLocation;
        private Telerik.WinControls.UI.RadDropDownList combo_LocationName;
        private Telerik.WinControls.UI.RadDateTimePicker txt_FactorDate;
        private Telerik.WinControls.UI.RadButton btn_Update;
        private Telerik.WinControls.UI.RadDesktopAlert Alert_editFactor;
    }
}