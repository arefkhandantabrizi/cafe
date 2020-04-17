namespace HomeCafe.Reports
{
    partial class FrmReportByBestSellingCatagories
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
            this.Panel_SelectDate = new Telerik.WinControls.UI.RadPanel();
            this.ckb_Date = new Telerik.WinControls.UI.RadCheckBox();
            this.txt_EndDate = new Telerik.WinControls.UI.RadDateTimePicker();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.txt_StartDate = new Telerik.WinControls.UI.RadDateTimePicker();
            this.lb_Catagories = new Telerik.WinControls.UI.RadLabel();
            this.combo_Catagories = new Telerik.WinControls.UI.RadDropDownList();
            this.btn_Show = new Telerik.WinControls.UI.RadButton();
            this.Grid_ReportByCategoris = new Telerik.WinControls.UI.RadGridView();
            this.Panel_Grid = new Telerik.WinControls.UI.RadPanel();
            this.telerikMetroTheme1 = new Telerik.WinControls.Themes.TelerikMetroTheme();
            ((System.ComponentModel.ISupportInitialize)(this.Panel_SelectDate)).BeginInit();
            this.Panel_SelectDate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ckb_Date)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_EndDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_StartDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lb_Catagories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.combo_Catagories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Show)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_ReportByCategoris)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_ReportByCategoris.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Panel_Grid)).BeginInit();
            this.Panel_Grid.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_SelectDate
            // 
            this.Panel_SelectDate.BackColor = System.Drawing.Color.White;
            this.Panel_SelectDate.Controls.Add(this.ckb_Date);
            this.Panel_SelectDate.Controls.Add(this.txt_EndDate);
            this.Panel_SelectDate.Controls.Add(this.radLabel2);
            this.Panel_SelectDate.Controls.Add(this.radLabel1);
            this.Panel_SelectDate.Controls.Add(this.txt_StartDate);
            this.Panel_SelectDate.Controls.Add(this.lb_Catagories);
            this.Panel_SelectDate.Controls.Add(this.combo_Catagories);
            this.Panel_SelectDate.Controls.Add(this.btn_Show);
            this.Panel_SelectDate.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_SelectDate.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Panel_SelectDate.Location = new System.Drawing.Point(0, 0);
            this.Panel_SelectDate.Name = "Panel_SelectDate";
            this.Panel_SelectDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Panel_SelectDate.Size = new System.Drawing.Size(953, 156);
            this.Panel_SelectDate.TabIndex = 4;
            this.Panel_SelectDate.ThemeName = "TelerikMetro";
            // 
            // ckb_Date
            // 
            this.ckb_Date.Font = new System.Drawing.Font("IRANSansDNFaNum", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ckb_Date.ForeColor = System.Drawing.SystemColors.GrayText;
            this.ckb_Date.Location = new System.Drawing.Point(205, 25);
            this.ckb_Date.Name = "ckb_Date";
            this.ckb_Date.Size = new System.Drawing.Size(128, 24);
            this.ckb_Date.TabIndex = 177;
            this.ckb_Date.Text = "انتخاب بازه فروش :";
            this.ckb_Date.ThemeName = "TelerikMetro";
            this.ckb_Date.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.ckb_Date_ToggleStateChanged);
            // 
            // txt_EndDate
            // 
            this.txt_EndDate.Culture = new System.Globalization.CultureInfo("fa-IR");
            this.txt_EndDate.Font = new System.Drawing.Font("IRANSansDNFaNum", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_EndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_EndDate.Location = new System.Drawing.Point(12, 103);
            this.txt_EndDate.Name = "txt_EndDate";
            this.txt_EndDate.Size = new System.Drawing.Size(284, 29);
            this.txt_EndDate.TabIndex = 176;
            this.txt_EndDate.TabStop = false;
            this.txt_EndDate.Text = "07/13/2019";
            this.txt_EndDate.ThemeName = "TelerikMetro";
            this.txt_EndDate.Value = new System.DateTime(2019, 7, 13, 15, 17, 15, 236);
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("IRANSansDNFaNum", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.radLabel2.Location = new System.Drawing.Point(302, 106);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(31, 24);
            this.radLabel2.TabIndex = 175;
            this.radLabel2.Text = "الی :";
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("IRANSansDNFaNum", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.radLabel1.Location = new System.Drawing.Point(310, 61);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(22, 24);
            this.radLabel1.TabIndex = 174;
            this.radLabel1.Text = "از :";
            // 
            // txt_StartDate
            // 
            this.txt_StartDate.Culture = new System.Globalization.CultureInfo("fa-IR");
            this.txt_StartDate.Font = new System.Drawing.Font("IRANSansDNFaNum", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_StartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_StartDate.Location = new System.Drawing.Point(12, 61);
            this.txt_StartDate.Name = "txt_StartDate";
            this.txt_StartDate.Size = new System.Drawing.Size(284, 29);
            this.txt_StartDate.TabIndex = 173;
            this.txt_StartDate.TabStop = false;
            this.txt_StartDate.Text = "07/13/2019";
            this.txt_StartDate.ThemeName = "TelerikMetro";
            this.txt_StartDate.Value = new System.DateTime(2019, 7, 13, 14, 56, 48, 780);
            // 
            // lb_Catagories
            // 
            this.lb_Catagories.Font = new System.Drawing.Font("IRANSansDNFaNum", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lb_Catagories.Location = new System.Drawing.Point(845, 25);
            this.lb_Catagories.Name = "lb_Catagories";
            this.lb_Catagories.Size = new System.Drawing.Size(57, 24);
            this.lb_Catagories.TabIndex = 170;
            this.lb_Catagories.Text = "نام دسته:";
            this.lb_Catagories.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            this.lb_Catagories.ThemeName = "TelerikMetro";
            // 
            // combo_Catagories
            // 
            this.combo_Catagories.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.combo_Catagories.Font = new System.Drawing.Font("IRANSansDNFaNum", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.combo_Catagories.Location = new System.Drawing.Point(554, 23);
            this.combo_Catagories.Name = "combo_Catagories";
            this.combo_Catagories.Size = new System.Drawing.Size(285, 31);
            this.combo_Catagories.TabIndex = 168;
            this.combo_Catagories.ThemeName = "TelerikMetro";
            this.combo_Catagories.TextChanged += new System.EventHandler(this.combo_Catagories_TextChanged);
            this.combo_Catagories.Enter += new System.EventHandler(this.combo_Catagories_Enter);
            this.combo_Catagories.Leave += new System.EventHandler(this.combo_Catagories_Leave);
            ((Telerik.WinControls.UI.RadDropDownListElement)(this.combo_Catagories.GetChildAt(0))).RightToLeft = true;
            ((Telerik.WinControls.UI.RadDropDownListElement)(this.combo_Catagories.GetChildAt(0))).Font = new System.Drawing.Font("IRANSansDNFaNum", 9.75F);
            ((Telerik.WinControls.UI.RadDropDownListElement)(this.combo_Catagories.GetChildAt(0).GetChildAt(3))).Font = new System.Drawing.Font("IRANSansDNFaNum", 9.75F);
            ((Telerik.WinControls.UI.RadDropDownListElement)(this.combo_Catagories.GetChildAt(0).GetChildAt(3))).Visibility = Telerik.WinControls.ElementVisibility.Hidden;
            // 
            // btn_Show
            // 
            this.btn_Show.Font = new System.Drawing.Font("IRANSansDNFaNum", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_Show.Location = new System.Drawing.Point(397, 25);
            this.btn_Show.Name = "btn_Show";
            this.btn_Show.Size = new System.Drawing.Size(110, 38);
            this.btn_Show.TabIndex = 166;
            this.btn_Show.Text = "نمایش";
            this.btn_Show.ThemeName = "TelerikMetro";
            this.btn_Show.Click += new System.EventHandler(this.btn_Show_Click);
            // 
            // Grid_ReportByCategoris
            // 
            this.Grid_ReportByCategoris.AutoSizeRows = true;
            this.Grid_ReportByCategoris.BackColor = System.Drawing.SystemColors.Control;
            this.Grid_ReportByCategoris.Cursor = System.Windows.Forms.Cursors.Default;
            this.Grid_ReportByCategoris.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Grid_ReportByCategoris.Font = new System.Drawing.Font("IRANSansDNFaNum", 9.75F);
            this.Grid_ReportByCategoris.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Grid_ReportByCategoris.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Grid_ReportByCategoris.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            this.Grid_ReportByCategoris.MasterTemplate.AllowAddNewRow = false;
            this.Grid_ReportByCategoris.MasterTemplate.AllowDeleteRow = false;
            this.Grid_ReportByCategoris.MasterTemplate.AllowEditRow = false;
            this.Grid_ReportByCategoris.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.Grid_ReportByCategoris.MasterTemplate.EnableGrouping = false;
            this.Grid_ReportByCategoris.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.Grid_ReportByCategoris.Name = "Grid_ReportByCategoris";
            this.Grid_ReportByCategoris.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Grid_ReportByCategoris.ShowGroupPanel = false;
            this.Grid_ReportByCategoris.ShowGroupPanelScrollbars = false;
            this.Grid_ReportByCategoris.ShowNoDataText = false;
            this.Grid_ReportByCategoris.Size = new System.Drawing.Size(953, 367);
            this.Grid_ReportByCategoris.TabIndex = 0;
            this.Grid_ReportByCategoris.ThemeName = "TelerikMetro";
            this.Grid_ReportByCategoris.CreateCell += new Telerik.WinControls.UI.GridViewCreateCellEventHandler(this.Grid_ReportByCategoris_CreateCell);
            this.Grid_ReportByCategoris.ViewCellFormatting += new Telerik.WinControls.UI.CellFormattingEventHandler(this.Grid_ReportByCategoris_ViewCellFormatting);
            this.Grid_ReportByCategoris.ColumnChooserItemElementCreating += new Telerik.WinControls.UI.ColumnChooserItemElementCreatingEventHandler(this.Grid_ReportByCategoris_ColumnChooserItemElementCreating);
            this.Grid_ReportByCategoris.ConditionalFormattingFormShown += new System.EventHandler(this.Grid_ReportByCategoris_ConditionalFormattingFormShown);
            this.Grid_ReportByCategoris.ContextMenuOpening += new Telerik.WinControls.UI.ContextMenuOpeningEventHandler(this.Grid_ReportByCategoris_ContextMenuOpening);
            // 
            // Panel_Grid
            // 
            this.Panel_Grid.Controls.Add(this.Grid_ReportByCategoris);
            this.Panel_Grid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Panel_Grid.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Panel_Grid.Location = new System.Drawing.Point(0, 122);
            this.Panel_Grid.Name = "Panel_Grid";
            this.Panel_Grid.Size = new System.Drawing.Size(953, 367);
            this.Panel_Grid.TabIndex = 5;
            this.Panel_Grid.ThemeName = "TelerikMetro";
            // 
            // FrmReportByBestSellingCatagories
            // 
            this.AcceptButton = this.btn_Show;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(953, 489);
            this.Controls.Add(this.Panel_SelectDate);
            this.Controls.Add(this.Panel_Grid);
            this.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmReportByBestSellingCatagories";
            this.Text = "FrmReportByBestSellingCatagories";
            this.Load += new System.EventHandler(this.frm_ReportByBestSellingCatagories_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Panel_SelectDate)).EndInit();
            this.Panel_SelectDate.ResumeLayout(false);
            this.Panel_SelectDate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ckb_Date)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_EndDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_StartDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lb_Catagories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.combo_Catagories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Show)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_ReportByCategoris.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_ReportByCategoris)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Panel_Grid)).EndInit();
            this.Panel_Grid.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadPanel Panel_SelectDate;
        private Telerik.WinControls.UI.RadCheckBox ckb_Date;
        private Telerik.WinControls.UI.RadDateTimePicker txt_EndDate;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadDateTimePicker txt_StartDate;
        private Telerik.WinControls.UI.RadLabel lb_Catagories;
        private Telerik.WinControls.UI.RadDropDownList combo_Catagories;
        private Telerik.WinControls.UI.RadButton btn_Show;
        private Telerik.WinControls.UI.RadGridView Grid_ReportByCategoris;
        private Telerik.WinControls.UI.RadPanel Panel_Grid;
        private Telerik.WinControls.Themes.TelerikMetroTheme telerikMetroTheme1;
    }
}