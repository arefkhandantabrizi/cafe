namespace HomeCafe.Reports
{
    partial class FrmReportByGoods
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
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition3 = new Telerik.WinControls.UI.TableViewDefinition();
            this.Panel_SelectDate = new Telerik.WinControls.UI.RadPanel();
            this.Radio_Selection = new Telerik.WinControls.UI.RadRadioButton();
            this.Radio_WithoutTime = new Telerik.WinControls.UI.RadRadioButton();
            this.Radio_ShowAll = new Telerik.WinControls.UI.RadRadioButton();
            this.ckb_Date = new Telerik.WinControls.UI.RadCheckBox();
            this.txt_EndDate = new Telerik.WinControls.UI.RadDateTimePicker();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.txt_StartDate = new Telerik.WinControls.UI.RadDateTimePicker();
            this.combo_Products = new Telerik.WinControls.UI.RadDropDownList();
            this.lb_Products = new Telerik.WinControls.UI.RadLabel();
            this.lb_Catagories = new Telerik.WinControls.UI.RadLabel();
            this.combo_Catagories = new Telerik.WinControls.UI.RadDropDownList();
            this.btn_Show = new Telerik.WinControls.UI.RadButton();
            this.Grid_ReportByGoods = new Telerik.WinControls.UI.RadGridView();
            this.Panel_Grid = new Telerik.WinControls.UI.RadPanel();
            ((System.ComponentModel.ISupportInitialize)(this.Panel_SelectDate)).BeginInit();
            this.Panel_SelectDate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Radio_Selection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Radio_WithoutTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Radio_ShowAll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckb_Date)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_EndDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_StartDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.combo_Products)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lb_Products)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lb_Catagories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.combo_Catagories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Show)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_ReportByGoods)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_ReportByGoods.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Panel_Grid)).BeginInit();
            this.Panel_Grid.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_SelectDate
            // 
            this.Panel_SelectDate.BackColor = System.Drawing.Color.White;
            this.Panel_SelectDate.Controls.Add(this.Radio_Selection);
            this.Panel_SelectDate.Controls.Add(this.Radio_WithoutTime);
            this.Panel_SelectDate.Controls.Add(this.Radio_ShowAll);
            this.Panel_SelectDate.Controls.Add(this.ckb_Date);
            this.Panel_SelectDate.Controls.Add(this.txt_EndDate);
            this.Panel_SelectDate.Controls.Add(this.radLabel2);
            this.Panel_SelectDate.Controls.Add(this.radLabel1);
            this.Panel_SelectDate.Controls.Add(this.txt_StartDate);
            this.Panel_SelectDate.Controls.Add(this.combo_Products);
            this.Panel_SelectDate.Controls.Add(this.lb_Products);
            this.Panel_SelectDate.Controls.Add(this.lb_Catagories);
            this.Panel_SelectDate.Controls.Add(this.combo_Catagories);
            this.Panel_SelectDate.Controls.Add(this.btn_Show);
            this.Panel_SelectDate.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_SelectDate.Font = new System.Drawing.Font("IRANSansDNFaNum", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Panel_SelectDate.Location = new System.Drawing.Point(0, 0);
            this.Panel_SelectDate.Name = "Panel_SelectDate";
            this.Panel_SelectDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Panel_SelectDate.Size = new System.Drawing.Size(953, 221);
            this.Panel_SelectDate.TabIndex = 2;
            this.Panel_SelectDate.ThemeName = "TelerikMetro";
            // 
            // Radio_Selection
            // 
            this.Radio_Selection.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Radio_Selection.DisplayStyle = Telerik.WinControls.DisplayStyle.Text;
            this.Radio_Selection.Font = new System.Drawing.Font("IRANSansDNFaNum", 9.75F);
            this.Radio_Selection.Location = new System.Drawing.Point(773, 12);
            this.Radio_Selection.Name = "Radio_Selection";
            this.Radio_Selection.Size = new System.Drawing.Size(156, 24);
            this.Radio_Selection.TabIndex = 181;
            this.Radio_Selection.Text = "انتخاب دسته و محصول\r\n";
            this.Radio_Selection.ThemeName = "TelerikMetro";
            this.Radio_Selection.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            this.Radio_Selection.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.Radio_Selection_ToggleStateChanged);
            // 
            // Radio_WithoutTime
            // 
            this.Radio_WithoutTime.Font = new System.Drawing.Font("IRANSansDNFaNum", 9.75F);
            this.Radio_WithoutTime.Location = new System.Drawing.Point(592, 163);
            this.Radio_WithoutTime.Name = "Radio_WithoutTime";
            this.Radio_WithoutTime.Size = new System.Drawing.Size(337, 24);
            this.Radio_WithoutTime.TabIndex = 180;
            this.Radio_WithoutTime.TabStop = false;
            this.Radio_WithoutTime.Text = "نمایش کل فروش محصولات بدون درنظر گرفتن زمان فروش";
            this.Radio_WithoutTime.ThemeName = "TelerikMetro";
            this.Radio_WithoutTime.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.Radio_WithoutTime_ToggleStateChanged);
            // 
            // Radio_ShowAll
            // 
            this.Radio_ShowAll.Font = new System.Drawing.Font("IRANSansDNFaNum", 9.75F);
            this.Radio_ShowAll.Location = new System.Drawing.Point(785, 129);
            this.Radio_ShowAll.Name = "Radio_ShowAll";
            this.Radio_ShowAll.Size = new System.Drawing.Size(144, 24);
            this.Radio_ShowAll.TabIndex = 179;
            this.Radio_ShowAll.TabStop = false;
            this.Radio_ShowAll.Text = "نمایش تمام محصولات";
            this.Radio_ShowAll.ThemeName = "TelerikMetro";
            this.Radio_ShowAll.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.Radio_ShowAll_ToggleStateChanged);
            // 
            // ckb_Date
            // 
            this.ckb_Date.Font = new System.Drawing.Font("IRANSansDNFaNum", 9.75F);
            this.ckb_Date.ForeColor = System.Drawing.SystemColors.GrayText;
            this.ckb_Date.Location = new System.Drawing.Point(208, 31);
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
            this.txt_EndDate.Font = new System.Drawing.Font("IRANSansDNFaNum", 9.75F);
            this.txt_EndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_EndDate.Location = new System.Drawing.Point(12, 112);
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
            this.radLabel2.Font = new System.Drawing.Font("IRANSansDNFaNum", 9.75F);
            this.radLabel2.Location = new System.Drawing.Point(302, 115);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(31, 24);
            this.radLabel2.TabIndex = 175;
            this.radLabel2.Text = "الی :";
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("IRANSansDNFaNum", 9.75F);
            this.radLabel1.Location = new System.Drawing.Point(310, 70);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(22, 24);
            this.radLabel1.TabIndex = 174;
            this.radLabel1.Text = "از :";
            // 
            // txt_StartDate
            // 
            this.txt_StartDate.Culture = new System.Globalization.CultureInfo("fa-IR");
            this.txt_StartDate.Font = new System.Drawing.Font("IRANSansDNFaNum", 9.75F);
            this.txt_StartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_StartDate.Location = new System.Drawing.Point(12, 70);
            this.txt_StartDate.Name = "txt_StartDate";
            this.txt_StartDate.Size = new System.Drawing.Size(284, 29);
            this.txt_StartDate.TabIndex = 173;
            this.txt_StartDate.TabStop = false;
            this.txt_StartDate.Text = "07/13/2019";
            this.txt_StartDate.ThemeName = "TelerikMetro";
            this.txt_StartDate.Value = new System.DateTime(2019, 7, 13, 14, 56, 48, 780);
            // 
            // combo_Products
            // 
            this.combo_Products.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.combo_Products.Font = new System.Drawing.Font("IRANSansDNFaNum", 9.75F);
            this.combo_Products.Location = new System.Drawing.Point(567, 92);
            this.combo_Products.Name = "combo_Products";
            this.combo_Products.Size = new System.Drawing.Size(285, 31);
            this.combo_Products.TabIndex = 169;
            this.combo_Products.ThemeName = "TelerikMetro";
            this.combo_Products.TextChanged += new System.EventHandler(this.combo_Products_TextChanged);
            this.combo_Products.Enter += new System.EventHandler(this.combo_Products_Enter);
            this.combo_Products.Leave += new System.EventHandler(this.combo_Products_Leave);
            ((Telerik.WinControls.UI.RadDropDownListElement)(this.combo_Products.GetChildAt(0))).RightToLeft = true;
            ((Telerik.WinControls.UI.RadDropDownListElement)(this.combo_Products.GetChildAt(0))).Font = new System.Drawing.Font("IRANSansDNFaNum", 9.75F);
            ((Telerik.WinControls.UI.RadDropDownListElement)(this.combo_Products.GetChildAt(0).GetChildAt(3))).Font = new System.Drawing.Font("IRANSansDNFaNum", 9.75F);
            ((Telerik.WinControls.UI.RadDropDownListElement)(this.combo_Products.GetChildAt(0).GetChildAt(3))).Visibility = Telerik.WinControls.ElementVisibility.Hidden;
            // 
            // lb_Products
            // 
            this.lb_Products.Font = new System.Drawing.Font("IRANSansDNFaNum", 9.75F);
            this.lb_Products.Location = new System.Drawing.Point(858, 94);
            this.lb_Products.Name = "lb_Products";
            this.lb_Products.Size = new System.Drawing.Size(76, 24);
            this.lb_Products.TabIndex = 171;
            this.lb_Products.Text = "نام محصول :";
            this.lb_Products.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            this.lb_Products.ThemeName = "TelerikMetro";
            // 
            // lb_Catagories
            // 
            this.lb_Catagories.Font = new System.Drawing.Font("IRANSansDNFaNum", 9.75F);
            this.lb_Catagories.Location = new System.Drawing.Point(858, 52);
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
            this.combo_Catagories.Font = new System.Drawing.Font("IRANSansDNFaNum", 9.75F);
            this.combo_Catagories.Location = new System.Drawing.Point(567, 50);
            this.combo_Catagories.Name = "combo_Catagories";
            this.combo_Catagories.Size = new System.Drawing.Size(285, 31);
            this.combo_Catagories.TabIndex = 168;
            this.combo_Catagories.ThemeName = "TelerikMetro";
            this.combo_Catagories.TextChanged += new System.EventHandler(this.combo_Catagories_TextChanged);
            this.combo_Catagories.Enter += new System.EventHandler(this.combo_Catagories_Enter);
            this.combo_Catagories.Leave += new System.EventHandler(this.combo_Catagories_Leave);
            ((Telerik.WinControls.UI.RadDropDownListElement)(this.combo_Catagories.GetChildAt(0))).RightToLeft = true;
            ((Telerik.WinControls.UI.RadDropDownListElement)(this.combo_Catagories.GetChildAt(0))).Font = new System.Drawing.Font("IRANSansDNFaNum", 9.75F);
            ((Telerik.WinControls.UI.RadDropDownListArrowButtonElement)(this.combo_Catagories.GetChildAt(0).GetChildAt(2).GetChildAt(1))).Font = new System.Drawing.Font("IRANSansDNFaNum", 9.75F);
            ((Telerik.WinControls.UI.RadDropDownListElement)(this.combo_Catagories.GetChildAt(0).GetChildAt(3))).Font = new System.Drawing.Font("IRANSansDNFaNum", 9.75F);
            ((Telerik.WinControls.UI.RadDropDownListElement)(this.combo_Catagories.GetChildAt(0).GetChildAt(3))).Visibility = Telerik.WinControls.ElementVisibility.Hidden;
            // 
            // btn_Show
            // 
            this.btn_Show.Font = new System.Drawing.Font("IRANSansDNFaNum", 9.75F);
            this.btn_Show.Location = new System.Drawing.Point(397, 25);
            this.btn_Show.Name = "btn_Show";
            this.btn_Show.Size = new System.Drawing.Size(110, 38);
            this.btn_Show.TabIndex = 166;
            this.btn_Show.Text = "نمایش";
            this.btn_Show.ThemeName = "TelerikMetro";
            this.btn_Show.Click += new System.EventHandler(this.btn_Show_Click);
            // 
            // Grid_ReportByGoods
            // 
            this.Grid_ReportByGoods.AutoSizeRows = true;
            this.Grid_ReportByGoods.BackColor = System.Drawing.SystemColors.Control;
            this.Grid_ReportByGoods.Cursor = System.Windows.Forms.Cursors.Default;
            this.Grid_ReportByGoods.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Grid_ReportByGoods.Font = new System.Drawing.Font("IRANSansDNFaNum", 9.75F);
            this.Grid_ReportByGoods.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Grid_ReportByGoods.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Grid_ReportByGoods.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            this.Grid_ReportByGoods.MasterTemplate.AllowAddNewRow = false;
            this.Grid_ReportByGoods.MasterTemplate.AllowDeleteRow = false;
            this.Grid_ReportByGoods.MasterTemplate.AllowEditRow = false;
            this.Grid_ReportByGoods.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.Grid_ReportByGoods.MasterTemplate.EnableGrouping = false;
            this.Grid_ReportByGoods.MasterTemplate.ViewDefinition = tableViewDefinition3;
            this.Grid_ReportByGoods.Name = "Grid_ReportByGoods";
            this.Grid_ReportByGoods.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Grid_ReportByGoods.ShowGroupPanel = false;
            this.Grid_ReportByGoods.ShowGroupPanelScrollbars = false;
            this.Grid_ReportByGoods.ShowNoDataText = false;
            this.Grid_ReportByGoods.Size = new System.Drawing.Size(953, 304);
            this.Grid_ReportByGoods.TabIndex = 0;
            this.Grid_ReportByGoods.ThemeName = "TelerikMetro";
            this.Grid_ReportByGoods.CreateCell += new Telerik.WinControls.UI.GridViewCreateCellEventHandler(this.Grid_ReportByGoods_CreateCell);
            this.Grid_ReportByGoods.ViewCellFormatting += new Telerik.WinControls.UI.CellFormattingEventHandler(this.Grid_ReportByGoods_ViewCellFormatting);
            this.Grid_ReportByGoods.ColumnChooserItemElementCreating += new Telerik.WinControls.UI.ColumnChooserItemElementCreatingEventHandler(this.Grid_ReportByGoods_ColumnChooserItemElementCreating);
            this.Grid_ReportByGoods.ConditionalFormattingFormShown += new System.EventHandler(this.Grid_ReportByGoods_ConditionalFormattingFormShown);
            this.Grid_ReportByGoods.ContextMenuOpening += new Telerik.WinControls.UI.ContextMenuOpeningEventHandler(this.Grid_ReportByGoods_ContextMenuOpening);
            // 
            // Panel_Grid
            // 
            this.Panel_Grid.Controls.Add(this.Grid_ReportByGoods);
            this.Panel_Grid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Panel_Grid.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Panel_Grid.Location = new System.Drawing.Point(0, 185);
            this.Panel_Grid.Name = "Panel_Grid";
            this.Panel_Grid.Size = new System.Drawing.Size(953, 304);
            this.Panel_Grid.TabIndex = 3;
            this.Panel_Grid.ThemeName = "TelerikMetro";
            // 
            // FrmReportByGoods
            // 
            this.AcceptButton = this.btn_Show;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(953, 489);
            this.Controls.Add(this.Panel_SelectDate);
            this.Controls.Add(this.Panel_Grid);
            this.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmReportByGoods";
            this.Text = "FrmReportByGoods";
            this.Load += new System.EventHandler(this.frm_ReportByGoods_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Panel_SelectDate)).EndInit();
            this.Panel_SelectDate.ResumeLayout(false);
            this.Panel_SelectDate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Radio_Selection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Radio_WithoutTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Radio_ShowAll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckb_Date)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_EndDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_StartDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.combo_Products)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lb_Products)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lb_Catagories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.combo_Catagories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Show)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_ReportByGoods.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_ReportByGoods)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Panel_Grid)).EndInit();
            this.Panel_Grid.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadPanel Panel_SelectDate;
        private Telerik.WinControls.UI.RadButton btn_Show;
        private Telerik.WinControls.UI.RadGridView Grid_ReportByGoods;
        private Telerik.WinControls.UI.RadPanel Panel_Grid;
        private Telerik.WinControls.UI.RadDropDownList combo_Products;
        private Telerik.WinControls.UI.RadLabel lb_Products;
        private Telerik.WinControls.UI.RadLabel lb_Catagories;
        private Telerik.WinControls.UI.RadDropDownList combo_Catagories;
        private Telerik.WinControls.UI.RadDateTimePicker txt_StartDate;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadDateTimePicker txt_EndDate;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadCheckBox ckb_Date;
        private Telerik.WinControls.UI.RadRadioButton Radio_WithoutTime;
        private Telerik.WinControls.UI.RadRadioButton Radio_ShowAll;
        private Telerik.WinControls.UI.RadRadioButton Radio_Selection;
    }
}