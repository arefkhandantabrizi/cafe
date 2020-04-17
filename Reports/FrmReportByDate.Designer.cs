namespace HomeCafe.Reports
{
    partial class FrmReportByDate
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
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            Telerik.WinControls.UI.RadPrintWatermark radPrintWatermark1 = new Telerik.WinControls.UI.RadPrintWatermark();
            this.Panel_SelectDate = new Telerik.WinControls.UI.RadPanel();
            this.txt_Total = new Telerik.WinControls.UI.RadSpinEditor();
            this.lb_Total = new System.Windows.Forms.Label();
            this.btn_Print = new Telerik.WinControls.UI.RadButton();
            this.btn_Show = new Telerik.WinControls.UI.RadButton();
            this.lb_SalesDate = new System.Windows.Forms.Label();
            this.txt_FactorDate = new Telerik.WinControls.UI.RadDateTimePicker();
            this.Panel_Grid = new Telerik.WinControls.UI.RadPanel();
            this.Grid_ReportByDate = new Telerik.WinControls.UI.RadGridView();
            this.radPrintDocument1 = new Telerik.WinControls.UI.RadPrintDocument();
            this.telerikMetroTheme1 = new Telerik.WinControls.Themes.TelerikMetroTheme();
            ((System.ComponentModel.ISupportInitialize)(this.Panel_SelectDate)).BeginInit();
            this.Panel_SelectDate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Total)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Print)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Show)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_FactorDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Panel_Grid)).BeginInit();
            this.Panel_Grid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_ReportByDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_ReportByDate.MasterTemplate)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel_SelectDate
            // 
            this.Panel_SelectDate.BackColor = System.Drawing.Color.White;
            this.Panel_SelectDate.Controls.Add(this.txt_Total);
            this.Panel_SelectDate.Controls.Add(this.lb_Total);
            this.Panel_SelectDate.Controls.Add(this.btn_Print);
            this.Panel_SelectDate.Controls.Add(this.btn_Show);
            this.Panel_SelectDate.Controls.Add(this.lb_SalesDate);
            this.Panel_SelectDate.Controls.Add(this.txt_FactorDate);
            this.Panel_SelectDate.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_SelectDate.Font = new System.Drawing.Font("IRANSansDNFaNum", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Panel_SelectDate.Location = new System.Drawing.Point(0, 0);
            this.Panel_SelectDate.Name = "Panel_SelectDate";
            this.Panel_SelectDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Panel_SelectDate.Size = new System.Drawing.Size(953, 106);
            this.Panel_SelectDate.TabIndex = 0;
            this.Panel_SelectDate.ThemeName = "TelerikMetro";
            // 
            // txt_Total
            // 
            this.txt_Total.Font = new System.Drawing.Font("IRANSansDNFaNum", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_Total.Location = new System.Drawing.Point(26, 21);
            this.txt_Total.Maximum = new decimal(new int[] {
            1661992959,
            1808227885,
            5,
            0});
            this.txt_Total.Name = "txt_Total";
            this.txt_Total.ReadOnly = true;
            this.txt_Total.Size = new System.Drawing.Size(277, 32);
            this.txt_Total.TabIndex = 171;
            this.txt_Total.ThemeName = "TelerikMetro";
            this.txt_Total.ThousandsSeparator = true;
            ((Telerik.WinControls.UI.RadSpinElement)(this.txt_Total.GetChildAt(0))).Padding = new System.Windows.Forms.Padding(0, 2, 0, 3);
            ((Telerik.WinControls.UI.RadSpinElement)(this.txt_Total.GetChildAt(0))).RightToLeft = true;
            ((Telerik.WinControls.UI.RadTextBoxItem)(this.txt_Total.GetChildAt(0).GetChildAt(2).GetChildAt(0))).Text = "0";
            ((Telerik.WinControls.UI.RadTextBoxItem)(this.txt_Total.GetChildAt(0).GetChildAt(2).GetChildAt(0))).Visibility = Telerik.WinControls.ElementVisibility.Visible;
            ((Telerik.WinControls.UI.RadSpinElementUpButton)(this.txt_Total.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(0))).Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            ((Telerik.WinControls.UI.RadSpinElementDownButton)(this.txt_Total.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(1))).Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            // 
            // lb_Total
            // 
            this.lb_Total.AutoSize = true;
            this.lb_Total.Location = new System.Drawing.Point(309, 26);
            this.lb_Total.Name = "lb_Total";
            this.lb_Total.Size = new System.Drawing.Size(55, 21);
            this.lb_Total.TabIndex = 169;
            this.lb_Total.Text = "جمع کل:";
            // 
            // btn_Print
            // 
            this.btn_Print.Font = new System.Drawing.Font("IRANSansDNFaNum", 9.75F);
            this.btn_Print.Location = new System.Drawing.Point(415, 56);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Size = new System.Drawing.Size(110, 38);
            this.btn_Print.TabIndex = 167;
            this.btn_Print.Text = "چاپ";
            this.btn_Print.ThemeName = "TelerikMetro";
            this.btn_Print.Click += new System.EventHandler(this.btn_Print_Click);
            // 
            // btn_Show
            // 
            this.btn_Show.Font = new System.Drawing.Font("IRANSansDNFaNum", 9.75F);
            this.btn_Show.Location = new System.Drawing.Point(415, 12);
            this.btn_Show.Name = "btn_Show";
            this.btn_Show.Size = new System.Drawing.Size(110, 38);
            this.btn_Show.TabIndex = 166;
            this.btn_Show.Text = "نمایش";
            this.btn_Show.ThemeName = "TelerikMetro";
            this.btn_Show.Click += new System.EventHandler(this.btn_Show_Click);
            // 
            // lb_SalesDate
            // 
            this.lb_SalesDate.AutoSize = true;
            this.lb_SalesDate.Location = new System.Drawing.Point(833, 26);
            this.lb_SalesDate.Name = "lb_SalesDate";
            this.lb_SalesDate.Size = new System.Drawing.Size(77, 21);
            this.lb_SalesDate.TabIndex = 165;
            this.lb_SalesDate.Text = "تاریخ فروش:";
            // 
            // txt_FactorDate
            // 
            this.txt_FactorDate.Culture = new System.Globalization.CultureInfo("fa-IR");
            this.txt_FactorDate.Font = new System.Drawing.Font("IRANSansDNFaNum", 9.75F);
            this.txt_FactorDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_FactorDate.Location = new System.Drawing.Point(550, 24);
            this.txt_FactorDate.Name = "txt_FactorDate";
            this.txt_FactorDate.Size = new System.Drawing.Size(277, 29);
            this.txt_FactorDate.TabIndex = 10;
            this.txt_FactorDate.TabStop = false;
            this.txt_FactorDate.Text = "03/23/2019";
            this.txt_FactorDate.ThemeName = "TelerikMetro";
            this.txt_FactorDate.Value = new System.DateTime(2019, 3, 23, 20, 43, 24, 699);
            // 
            // Panel_Grid
            // 
            this.Panel_Grid.Controls.Add(this.Grid_ReportByDate);
            this.Panel_Grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Grid.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Panel_Grid.Location = new System.Drawing.Point(0, 106);
            this.Panel_Grid.Name = "Panel_Grid";
            this.Panel_Grid.Size = new System.Drawing.Size(953, 383);
            this.Panel_Grid.TabIndex = 1;
            this.Panel_Grid.ThemeName = "TelerikMetro";
            // 
            // Grid_ReportByDate
            // 
            this.Grid_ReportByDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Grid_ReportByDate.Font = new System.Drawing.Font("IRANSansDNFaNum", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Grid_ReportByDate.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            this.Grid_ReportByDate.MasterTemplate.AllowAddNewRow = false;
            this.Grid_ReportByDate.MasterTemplate.AllowDeleteRow = false;
            this.Grid_ReportByDate.MasterTemplate.AllowEditRow = false;
            this.Grid_ReportByDate.MasterTemplate.AllowSearchRow = true;
            this.Grid_ReportByDate.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.Grid_ReportByDate.MasterTemplate.EnableGrouping = false;
            this.Grid_ReportByDate.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.Grid_ReportByDate.Name = "Grid_ReportByDate";
            this.Grid_ReportByDate.ShowGroupPanel = false;
            this.Grid_ReportByDate.ShowGroupPanelScrollbars = false;
            this.Grid_ReportByDate.Size = new System.Drawing.Size(953, 383);
            this.Grid_ReportByDate.TabIndex = 0;
            this.Grid_ReportByDate.ThemeName = "TelerikMetro";
            this.Grid_ReportByDate.CreateCell += new Telerik.WinControls.UI.GridViewCreateCellEventHandler(this.Grid_ReportByDate_CreateCell);
            this.Grid_ReportByDate.ViewCellFormatting += new Telerik.WinControls.UI.CellFormattingEventHandler(this.Grid_ReportByDate_ViewCellFormatting);
            this.Grid_ReportByDate.ColumnChooserItemElementCreating += new Telerik.WinControls.UI.ColumnChooserItemElementCreatingEventHandler(this.Grid_ReportByDate_ColumnChooserItemElementCreating);
            this.Grid_ReportByDate.ConditionalFormattingFormShown += new System.EventHandler(this.Grid_ReportByDate_ConditionalFormattingFormShown);
            this.Grid_ReportByDate.ContextMenuOpening += new Telerik.WinControls.UI.ContextMenuOpeningEventHandler(this.Grid_ReportByDate_ContextMenuOpening);
            // 
            // radPrintDocument1
            // 
            this.radPrintDocument1.DocumentName = "";
            this.radPrintDocument1.FooterFont = new System.Drawing.Font("B Kamran", 8F);
            this.radPrintDocument1.HeaderFont = new System.Drawing.Font("B Kamran", 8F);
            this.radPrintDocument1.Logo = global::HomeCafe.Properties.Resources.LKView;
            this.radPrintDocument1.Margins = new System.Drawing.Printing.Margins(5, 1, 30, 30);
            this.radPrintDocument1.Watermark = radPrintWatermark1;
            // 
            // FrmReportByDate
            // 
            this.AcceptButton = this.btn_Show;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(953, 489);
            this.Controls.Add(this.Panel_Grid);
            this.Controls.Add(this.Panel_SelectDate);
            this.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmReportByDate";
            this.Text = "FrmReportByDate";
            ((System.ComponentModel.ISupportInitialize)(this.Panel_SelectDate)).EndInit();
            this.Panel_SelectDate.ResumeLayout(false);
            this.Panel_SelectDate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Total)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Print)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Show)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_FactorDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Panel_Grid)).EndInit();
            this.Panel_Grid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Grid_ReportByDate.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_ReportByDate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadPanel Panel_SelectDate;
        private Telerik.WinControls.UI.RadPanel Panel_Grid;
        private Telerik.WinControls.UI.RadGridView Grid_ReportByDate;
        private Telerik.WinControls.UI.RadDateTimePicker txt_FactorDate;
        private System.Windows.Forms.Label lb_SalesDate;
        private Telerik.WinControls.UI.RadButton btn_Show;
        private Telerik.WinControls.UI.RadButton btn_Print;
        private System.Windows.Forms.Label lb_Total;
        private Telerik.WinControls.UI.RadPrintDocument radPrintDocument1;
        private Telerik.WinControls.UI.RadSpinEditor txt_Total;
        private Telerik.WinControls.Themes.TelerikMetroTheme telerikMetroTheme1;
    }
}