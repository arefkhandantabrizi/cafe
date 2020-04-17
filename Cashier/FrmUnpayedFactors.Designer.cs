namespace HomeCafe.Cashier
{
    partial class FrmUnpayedFactors
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn1 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn2 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn3 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn4 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition2 = new Telerik.WinControls.UI.TableViewDefinition();
            Telerik.WinControls.UI.RadPrintWatermark radPrintWatermark1 = new Telerik.WinControls.UI.RadPrintWatermark();
            Telerik.WinControls.UI.RadPrintWatermark radPrintWatermark2 = new Telerik.WinControls.UI.RadPrintWatermark();
            this.Panel_Invoice = new Telerik.WinControls.UI.RadPanel();
            this.Group_Invoice = new Telerik.WinControls.UI.RadGroupBox();
            this.GridInvoice = new Telerik.WinControls.UI.RadGridView();
            this.unpayedfactorsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cafeDataSet1 = new HomeCafe.CafeDataSet1();
            this.Panel_Items = new Telerik.WinControls.UI.RadPanel();
            this.Group_Items = new Telerik.WinControls.UI.RadGroupBox();
            this.GridItems = new Telerik.WinControls.UI.RadGridView();
            this.btn_Print = new Telerik.WinControls.UI.RadButton();
            this.btn_CheckOut = new Telerik.WinControls.UI.RadButton();
            this.btn_Delete = new Telerik.WinControls.UI.RadButton();
            this.radPrintDocument1 = new Telerik.WinControls.UI.RadPrintDocument();
            this.Alert_UnpayedFactor = new Telerik.WinControls.UI.RadDesktopAlert(this.components);
            this.radMenuButtonItem1 = new Telerik.WinControls.UI.RadMenuButtonItem();
            this.unpayedfactorsTableAdapter1 = new HomeCafe.CafeDataSet1TableAdapters.unpayedfactorsTableAdapter();
            this.radPrintDocument2 = new Telerik.WinControls.UI.RadPrintDocument();
            this.telerikMetroTheme1 = new Telerik.WinControls.Themes.TelerikMetroTheme();
            ((System.ComponentModel.ISupportInitialize)(this.Panel_Invoice)).BeginInit();
            this.Panel_Invoice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Group_Invoice)).BeginInit();
            this.Group_Invoice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridInvoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridInvoice.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unpayedfactorsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cafeDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Panel_Items)).BeginInit();
            this.Panel_Items.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Group_Items)).BeginInit();
            this.Group_Items.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridItems.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Print)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_CheckOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Delete)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel_Invoice
            // 
            this.Panel_Invoice.Controls.Add(this.Group_Invoice);
            this.Panel_Invoice.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_Invoice.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Panel_Invoice.Location = new System.Drawing.Point(0, 0);
            this.Panel_Invoice.Name = "Panel_Invoice";
            this.Panel_Invoice.Size = new System.Drawing.Size(889, 229);
            this.Panel_Invoice.TabIndex = 0;
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
            this.Group_Invoice.Size = new System.Drawing.Size(889, 229);
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
            this.GridInvoice.Font = new System.Drawing.Font("IRANSansDNFaNum", 9.75F);
            this.GridInvoice.ForeColor = System.Drawing.SystemColors.ControlText;
            this.GridInvoice.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.GridInvoice.Location = new System.Drawing.Point(2, 35);
            // 
            // 
            // 
            this.GridInvoice.MasterTemplate.AllowAddNewRow = false;
            this.GridInvoice.MasterTemplate.AllowDeleteRow = false;
            this.GridInvoice.MasterTemplate.AllowSearchRow = true;
            this.GridInvoice.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "نام محل";
            gridViewTextBoxColumn1.HeaderText = "نام محل";
            gridViewTextBoxColumn1.IsAutoGenerated = true;
            gridViewTextBoxColumn1.Name = "نام محل";
            gridViewTextBoxColumn1.ReadOnly = true;
            gridViewTextBoxColumn1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn1.Width = 104;
            gridViewDecimalColumn1.DataType = typeof(int);
            gridViewDecimalColumn1.EnableExpressionEditor = false;
            gridViewDecimalColumn1.FieldName = "location_id";
            gridViewDecimalColumn1.HeaderText = "location_id";
            gridViewDecimalColumn1.IsAutoGenerated = true;
            gridViewDecimalColumn1.IsVisible = false;
            gridViewDecimalColumn1.Name = "location_id";
            gridViewDecimalColumn1.VisibleInColumnChooser = false;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "نام میز";
            gridViewTextBoxColumn2.HeaderText = "نام میز";
            gridViewTextBoxColumn2.IsAutoGenerated = true;
            gridViewTextBoxColumn2.Name = "نام میز";
            gridViewTextBoxColumn2.ReadOnly = true;
            gridViewTextBoxColumn2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn2.Width = 93;
            gridViewDecimalColumn2.DataType = typeof(int);
            gridViewDecimalColumn2.EnableExpressionEditor = false;
            gridViewDecimalColumn2.FieldName = "table_id";
            gridViewDecimalColumn2.HeaderText = "table_id";
            gridViewDecimalColumn2.IsAutoGenerated = true;
            gridViewDecimalColumn2.IsVisible = false;
            gridViewDecimalColumn2.Name = "table_id";
            gridViewDecimalColumn2.VisibleInColumnChooser = false;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "customer_id";
            gridViewTextBoxColumn3.HeaderText = "شماره اشتراک";
            gridViewTextBoxColumn3.IsAutoGenerated = true;
            gridViewTextBoxColumn3.Name = "customer_id";
            gridViewTextBoxColumn3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn3.Width = 172;
            gridViewDecimalColumn3.DataType = typeof(int);
            gridViewDecimalColumn3.EnableExpressionEditor = false;
            gridViewDecimalColumn3.FieldName = "id";
            gridViewDecimalColumn3.HeaderText = "شماره فاکتور";
            gridViewDecimalColumn3.IsAutoGenerated = true;
            gridViewDecimalColumn3.Name = "id";
            gridViewDecimalColumn3.ReadOnly = true;
            gridViewDecimalColumn3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewDecimalColumn3.Width = 108;
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "date";
            gridViewTextBoxColumn4.HeaderText = "تاریخ صدور فاکتور";
            gridViewTextBoxColumn4.IsAutoGenerated = true;
            gridViewTextBoxColumn4.Name = "date";
            gridViewTextBoxColumn4.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn4.Width = 207;
            gridViewDecimalColumn4.DataType = typeof(long);
            gridViewDecimalColumn4.DecimalPlaces = 0;
            gridViewDecimalColumn4.EnableExpressionEditor = false;
            gridViewDecimalColumn4.FieldName = "مبلغ قابل پرداخت";
            gridViewDecimalColumn4.FormatString = "{0:n0}";
            gridViewDecimalColumn4.HeaderText = "مبلغ قابل پرداخت";
            gridViewDecimalColumn4.IsAutoGenerated = true;
            gridViewDecimalColumn4.Name = "مبلغ قابل پرداخت";
            gridViewDecimalColumn4.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewDecimalColumn4.ThousandsSeparator = true;
            gridViewDecimalColumn4.Width = 185;
            this.GridInvoice.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewDecimalColumn1,
            gridViewTextBoxColumn2,
            gridViewDecimalColumn2,
            gridViewTextBoxColumn3,
            gridViewDecimalColumn3,
            gridViewTextBoxColumn4,
            gridViewDecimalColumn4});
            this.GridInvoice.MasterTemplate.DataSource = this.unpayedfactorsBindingSource1;
            this.GridInvoice.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.GridInvoice.Name = "GridInvoice";
            this.GridInvoice.ReadOnly = true;
            this.GridInvoice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.GridInvoice.ShowGroupPanel = false;
            this.GridInvoice.Size = new System.Drawing.Size(885, 192);
            this.GridInvoice.TabIndex = 0;
            this.GridInvoice.ThemeName = "TelerikMetro";
            this.GridInvoice.CreateCell += new Telerik.WinControls.UI.GridViewCreateCellEventHandler(this.GridInvoice_CreateCell);
            this.GridInvoice.CellFormatting += new Telerik.WinControls.UI.CellFormattingEventHandler(this.GridInvoice_CellFormatting);
            this.GridInvoice.ViewCellFormatting += new Telerik.WinControls.UI.CellFormattingEventHandler(this.GridInvoice_ViewCellFormatting);
            this.GridInvoice.CurrentRowChanged += new Telerik.WinControls.UI.CurrentRowChangedEventHandler(this.GridInvoice_CurrentRowChanged);
            this.GridInvoice.ColumnChooserItemElementCreating += new Telerik.WinControls.UI.ColumnChooserItemElementCreatingEventHandler(this.GridInvoice_ColumnChooserItemElementCreating);
            this.GridInvoice.ConditionalFormattingFormShown += new System.EventHandler(this.GridInvoice_ConditionalFormattingFormShown);
            this.GridInvoice.ContextMenuOpening += new Telerik.WinControls.UI.ContextMenuOpeningEventHandler(this.GridInvoice_ContextMenuOpening);
            // 
            // unpayedfactorsBindingSource1
            // 
            this.unpayedfactorsBindingSource1.DataMember = "unpayedfactors";
            this.unpayedfactorsBindingSource1.DataSource = this.cafeDataSet1;
            // 
            // cafeDataSet1
            // 
            this.cafeDataSet1.DataSetName = "CafeDataSet1";
            this.cafeDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Panel_Items
            // 
            this.Panel_Items.Controls.Add(this.Group_Items);
            this.Panel_Items.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_Items.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Panel_Items.Location = new System.Drawing.Point(0, 229);
            this.Panel_Items.Name = "Panel_Items";
            this.Panel_Items.Size = new System.Drawing.Size(889, 226);
            this.Panel_Items.TabIndex = 1;
            this.Panel_Items.ThemeName = "TelerikMetro";
            // 
            // Group_Items
            // 
            this.Group_Items.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.Group_Items.Controls.Add(this.GridItems);
            this.Group_Items.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Group_Items.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Group_Items.HeaderText = "جزئیات فاکتور";
            this.Group_Items.Location = new System.Drawing.Point(0, 0);
            this.Group_Items.Name = "Group_Items";
            this.Group_Items.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Group_Items.Size = new System.Drawing.Size(889, 226);
            this.Group_Items.TabIndex = 1;
            this.Group_Items.Text = "جزئیات فاکتور";
            this.Group_Items.ThemeName = "TelerikMetro";
            ((Telerik.WinControls.UI.GroupBoxHeader)(this.Group_Items.GetChildAt(0).GetChildAt(1))).Font = new System.Drawing.Font("IRANSansDNFaNum", 9.75F);
            // 
            // GridItems
            // 
            this.GridItems.AutoSizeRows = true;
            this.GridItems.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GridItems.Location = new System.Drawing.Point(2, 34);
            // 
            // 
            // 
            this.GridItems.MasterTemplate.AllowAddNewRow = false;
            this.GridItems.MasterTemplate.AllowDeleteRow = false;
            this.GridItems.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.GridItems.MasterTemplate.ViewDefinition = tableViewDefinition2;
            this.GridItems.Name = "GridItems";
            this.GridItems.ShowGroupPanel = false;
            this.GridItems.Size = new System.Drawing.Size(885, 190);
            this.GridItems.TabIndex = 1;
            this.GridItems.ThemeName = "TelerikMetro";
            this.GridItems.CreateCell += new Telerik.WinControls.UI.GridViewCreateCellEventHandler(this.GridItems_CreateCell);
            this.GridItems.CellFormatting += new Telerik.WinControls.UI.CellFormattingEventHandler(this.GridItems_CellFormatting);
            this.GridItems.ViewCellFormatting += new Telerik.WinControls.UI.CellFormattingEventHandler(this.GridItems_ViewCellFormatting);
            this.GridItems.ColumnChooserItemElementCreating += new Telerik.WinControls.UI.ColumnChooserItemElementCreatingEventHandler(this.GridItems_ColumnChooserItemElementCreating);
            this.GridItems.ConditionalFormattingFormShown += new System.EventHandler(this.GridItems_ConditionalFormattingFormShown);
            this.GridItems.ContextMenuOpening += new Telerik.WinControls.UI.ContextMenuOpeningEventHandler(this.GridItems_ContextMenuOpening);
            // 
            // btn_Print
            // 
            this.btn_Print.Font = new System.Drawing.Font("IRANSansDNFaNum", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_Print.Location = new System.Drawing.Point(12, 479);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Size = new System.Drawing.Size(110, 38);
            this.btn_Print.TabIndex = 9;
            this.btn_Print.Text = "چاپ فاکتور";
            this.btn_Print.ThemeName = "TelerikMetro";
            this.btn_Print.Click += new System.EventHandler(this.btn_Print_Click);
            // 
            // btn_CheckOut
            // 
            this.btn_CheckOut.Font = new System.Drawing.Font("IRANSansDNFaNum", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_CheckOut.Location = new System.Drawing.Point(128, 479);
            this.btn_CheckOut.Name = "btn_CheckOut";
            this.btn_CheckOut.Size = new System.Drawing.Size(110, 38);
            this.btn_CheckOut.TabIndex = 10;
            this.btn_CheckOut.Text = "تسویه حساب";
            this.btn_CheckOut.ThemeName = "TelerikMetro";
            this.btn_CheckOut.Click += new System.EventHandler(this.btn_CheckOut_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Font = new System.Drawing.Font("IRANSansDNFaNum", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_Delete.Location = new System.Drawing.Point(244, 479);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(110, 38);
            this.btn_Delete.TabIndex = 11;
            this.btn_Delete.Text = "ابطال فاکتور";
            this.btn_Delete.ThemeName = "TelerikMetro";
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // radPrintDocument1
            // 
            this.radPrintDocument1.DocumentName = "";
            this.radPrintDocument1.FooterFont = new System.Drawing.Font("B Kamran", 8F);
            this.radPrintDocument1.HeaderFont = new System.Drawing.Font("B Kamran", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.radPrintDocument1.Logo = global::HomeCafe.Properties.Resources.LKView;
            this.radPrintDocument1.Margins = new System.Drawing.Printing.Margins(5, 1, 30, 30);
            this.radPrintDocument1.Watermark = radPrintWatermark1;
            this.radPrintDocument1.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.radPrintDocument1_BeginPrint);
            this.radPrintDocument1.EndPrint += new System.Drawing.Printing.PrintEventHandler(this.radPrintDocument1_EndPrint);
            // 
            // Alert_UnpayedFactor
            // 
            this.Alert_UnpayedFactor.CanMove = false;
            this.Alert_UnpayedFactor.ContentImage = global::HomeCafe.Properties.Resources.success_Alert;
            this.Alert_UnpayedFactor.OptionItems.AddRange(new Telerik.WinControls.RadItem[] {
            this.radMenuButtonItem1});
            this.Alert_UnpayedFactor.ThemeName = "TelerikMetro";
            // 
            // radMenuButtonItem1
            // 
            this.radMenuButtonItem1.Name = "radMenuButtonItem1";
            this.radMenuButtonItem1.Text = "یس";
            // 
            // unpayedfactorsTableAdapter1
            // 
            this.unpayedfactorsTableAdapter1.ClearBeforeFill = true;
            // 
            // radPrintDocument2
            // 
            this.radPrintDocument2.FooterFont = new System.Drawing.Font("B Kamran", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.radPrintDocument2.HeaderFont = new System.Drawing.Font("B Kamran", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.radPrintDocument2.Margins = new System.Drawing.Printing.Margins(5, 1, 30, 30);
            this.radPrintDocument2.Watermark = radPrintWatermark2;
            // 
            // FrmUnpayedFactors
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(889, 529);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_CheckOut);
            this.Controls.Add(this.btn_Print);
            this.Controls.Add(this.Panel_Items);
            this.Controls.Add(this.Panel_Invoice);
            this.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmUnpayedFactors";
            this.Text = "FrmUnpayedFactors";
            this.Load += new System.EventHandler(this.frm_UnpayedFactors_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Panel_Invoice)).EndInit();
            this.Panel_Invoice.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Group_Invoice)).EndInit();
            this.Group_Invoice.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridInvoice.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridInvoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unpayedfactorsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cafeDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Panel_Items)).EndInit();
            this.Panel_Items.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Group_Items)).EndInit();
            this.Group_Items.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridItems.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Print)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_CheckOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Delete)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadPanel Panel_Invoice;
        private Telerik.WinControls.UI.RadPanel Panel_Items;
        private Telerik.WinControls.UI.RadGroupBox Group_Invoice;
        private Telerik.WinControls.UI.RadGridView GridInvoice;
        private Telerik.WinControls.UI.RadGroupBox Group_Items;
        private Telerik.WinControls.UI.RadGridView GridItems;
        private Telerik.WinControls.UI.RadButton btn_Print;
        private Telerik.WinControls.UI.RadButton btn_CheckOut;
        private Telerik.WinControls.UI.RadButton btn_Delete;
        private Telerik.WinControls.UI.RadPrintDocument radPrintDocument1;
        private Telerik.WinControls.UI.RadDesktopAlert Alert_UnpayedFactor;
        private CafeDataSet1 cafeDataSet1;
        private System.Windows.Forms.BindingSource unpayedfactorsBindingSource1;
        private CafeDataSet1TableAdapters.unpayedfactorsTableAdapter unpayedfactorsTableAdapter1;
        private Telerik.WinControls.UI.RadMenuButtonItem radMenuButtonItem1;
        private Telerik.WinControls.UI.RadPrintDocument radPrintDocument2;
        private Telerik.WinControls.Themes.TelerikMetroTheme telerikMetroTheme1;
    }
}