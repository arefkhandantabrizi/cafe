using System.ComponentModel;
using System.Windows.Forms;
using HomeCafe.warehouseTableAdapters;
using Telerik.WinControls.UI;

namespace HomeCafe.Warehouse
{
    partial class FrmEditWareHouse
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
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn1 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn2 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn3 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumn1 = new Telerik.WinControls.UI.GridViewCheckBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            Telerik.WinControls.UI.RadListDataItem radListDataItem1 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem2 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem3 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem4 = new Telerik.WinControls.UI.RadListDataItem();
            this.Grid_WareHouse = new Telerik.WinControls.UI.RadGridView();
            this.view1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.warehouse = new HomeCafe.warehouse();
            this.txt_GoodsName = new Telerik.WinControls.UI.RadMaskedEditBox();
            this.lb_GoodsName = new Telerik.WinControls.UI.RadLabel();
            this.txt_ExpDate = new Telerik.WinControls.UI.RadDateTimePicker();
            this.lb_ExpDate = new Telerik.WinControls.UI.RadLabel();
            this.txt_PurchDate = new Telerik.WinControls.UI.RadDateTimePicker();
            this.lb_PurchDate = new Telerik.WinControls.UI.RadLabel();
            this.txt_Expence = new Telerik.WinControls.UI.RadMaskedEditBox();
            this.lb_Expence = new Telerik.WinControls.UI.RadLabel();
            this.panel_WeightUnit = new Telerik.WinControls.UI.RadPanel();
            this.btn_Gr = new Telerik.WinControls.UI.RadRadioButton();
            this.btn_Kgr = new Telerik.WinControls.UI.RadRadioButton();
            this.ckb_Payed = new Telerik.WinControls.UI.RadCheckBox();
            this.txt_WeightCount = new Telerik.WinControls.UI.RadMaskedEditBox();
            this.btn_Count = new Telerik.WinControls.UI.RadRadioButton();
            this.btn_Weight = new Telerik.WinControls.UI.RadRadioButton();
            this.btn_Delete = new Telerik.WinControls.UI.RadButton();
            this.btn_Edit = new Telerik.WinControls.UI.RadButton();
            this.EditWareHouse_Alert = new Telerik.WinControls.UI.RadDesktopAlert(this.components);
            this.view_1TableAdapter = new HomeCafe.warehouseTableAdapters.View_1TableAdapter();
            this.combo_Vendor = new Telerik.WinControls.UI.RadDropDownList();
            this.lb_Vendor = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_WareHouse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_WareHouse.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_GoodsName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lb_GoodsName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ExpDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lb_ExpDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_PurchDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lb_PurchDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Expence)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lb_Expence)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_WeightUnit)).BeginInit();
            this.panel_WeightUnit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Gr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Kgr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckb_Payed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_WeightCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Count)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Weight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Delete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.combo_Vendor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lb_Vendor)).BeginInit();
            this.SuspendLayout();
            // 
            // Grid_WareHouse
            // 
            this.Grid_WareHouse.AutoSizeRows = true;
            this.Grid_WareHouse.BackColor = System.Drawing.Color.White;
            this.Grid_WareHouse.Cursor = System.Windows.Forms.Cursors.Default;
            this.Grid_WareHouse.Dock = System.Windows.Forms.DockStyle.Top;
            this.Grid_WareHouse.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold);
            this.Grid_WareHouse.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Grid_WareHouse.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Grid_WareHouse.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            this.Grid_WareHouse.MasterTemplate.AllowAddNewRow = false;
            this.Grid_WareHouse.MasterTemplate.AllowColumnReorder = false;
            this.Grid_WareHouse.MasterTemplate.AllowDeleteRow = false;
            this.Grid_WareHouse.MasterTemplate.AllowSearchRow = true;
            this.Grid_WareHouse.MasterTemplate.AutoExpandGroups = true;
            this.Grid_WareHouse.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewDecimalColumn1.DataType = typeof(int);
            gridViewDecimalColumn1.EnableExpressionEditor = false;
            gridViewDecimalColumn1.FieldName = "id";
            gridViewDecimalColumn1.HeaderText = "id";
            gridViewDecimalColumn1.IsAutoGenerated = true;
            gridViewDecimalColumn1.IsVisible = false;
            gridViewDecimalColumn1.Name = "id";
            gridViewDecimalColumn1.VisibleInColumnChooser = false;
            gridViewDecimalColumn1.Width = 66;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "نام";
            gridViewTextBoxColumn1.HeaderText = "نام";
            gridViewTextBoxColumn1.IsAutoGenerated = true;
            gridViewTextBoxColumn1.Name = "نام";
            gridViewTextBoxColumn1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn1.Width = 114;
            gridViewDecimalColumn2.DataType = typeof(double);
            gridViewDecimalColumn2.EnableExpressionEditor = false;
            gridViewDecimalColumn2.FieldName = "وزن / تعداد";
            gridViewDecimalColumn2.HeaderText = "وزن / تعداد";
            gridViewDecimalColumn2.IsAutoGenerated = true;
            gridViewDecimalColumn2.Name = "وزن / تعداد";
            gridViewDecimalColumn2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewDecimalColumn2.Width = 114;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "تاریخ خرید";
            gridViewTextBoxColumn2.HeaderText = "تاریخ خرید";
            gridViewTextBoxColumn2.IsAutoGenerated = true;
            gridViewTextBoxColumn2.Name = "تاریخ خرید";
            gridViewTextBoxColumn2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn2.Width = 114;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "تاریخ انقضا";
            gridViewTextBoxColumn3.HeaderText = "تاریخ انقضا";
            gridViewTextBoxColumn3.IsAutoGenerated = true;
            gridViewTextBoxColumn3.Name = "تاریخ انقضا";
            gridViewTextBoxColumn3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn3.Width = 114;
            gridViewDecimalColumn3.DataType = typeof(long);
            gridViewDecimalColumn3.EnableExpressionEditor = false;
            gridViewDecimalColumn3.FieldName = "هزینه";
            gridViewDecimalColumn3.HeaderText = "هزینه";
            gridViewDecimalColumn3.IsAutoGenerated = true;
            gridViewDecimalColumn3.Name = "هزینه";
            gridViewDecimalColumn3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewDecimalColumn3.Width = 114;
            gridViewCheckBoxColumn1.EnableExpressionEditor = false;
            gridViewCheckBoxColumn1.FieldName = "بدهی";
            gridViewCheckBoxColumn1.HeaderText = "بدهی";
            gridViewCheckBoxColumn1.IsAutoGenerated = true;
            gridViewCheckBoxColumn1.MinWidth = 20;
            gridViewCheckBoxColumn1.Name = "بدهی";
            gridViewCheckBoxColumn1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewCheckBoxColumn1.Width = 114;
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "واحد وزن";
            gridViewTextBoxColumn4.HeaderText = "واحد وزن";
            gridViewTextBoxColumn4.IsAutoGenerated = true;
            gridViewTextBoxColumn4.Name = "واحد وزن";
            gridViewTextBoxColumn4.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn4.Width = 114;
            gridViewTextBoxColumn5.EnableExpressionEditor = false;
            gridViewTextBoxColumn5.FieldName = "تامین کننده";
            gridViewTextBoxColumn5.HeaderText = "تامین کننده";
            gridViewTextBoxColumn5.IsAutoGenerated = true;
            gridViewTextBoxColumn5.Name = "تامین کننده";
            gridViewTextBoxColumn5.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn5.Width = 106;
            this.Grid_WareHouse.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn1,
            gridViewTextBoxColumn1,
            gridViewDecimalColumn2,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewDecimalColumn3,
            gridViewCheckBoxColumn1,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5});
            this.Grid_WareHouse.MasterTemplate.DataSource = this.view1BindingSource;
            this.Grid_WareHouse.MasterTemplate.PageSize = 7;
            this.Grid_WareHouse.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.Grid_WareHouse.Name = "Grid_WareHouse";
            this.Grid_WareHouse.ReadOnly = true;
            this.Grid_WareHouse.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Grid_WareHouse.Size = new System.Drawing.Size(918, 276);
            this.Grid_WareHouse.TabIndex = 0;
            this.Grid_WareHouse.ThemeName = "TelerikMetro";
            this.Grid_WareHouse.CreateCell += new Telerik.WinControls.UI.GridViewCreateCellEventHandler(this.Grid_WareHouse_CreateCell);
            this.Grid_WareHouse.ViewCellFormatting += new Telerik.WinControls.UI.CellFormattingEventHandler(this.Grid_WareHouse_ViewCellFormatting);
            this.Grid_WareHouse.SelectionChanged += new System.EventHandler(this.Grid_WareHouse_SelectionChanged);
            this.Grid_WareHouse.ColumnChooserItemElementCreating += new Telerik.WinControls.UI.ColumnChooserItemElementCreatingEventHandler(this.Grid_WareHouse_ColumnChooserItemElementCreating);
            this.Grid_WareHouse.ConditionalFormattingFormShown += new System.EventHandler(this.Grid_WareHouse_ConditionalFormattingFormShown);
            this.Grid_WareHouse.GroupSummaryEvaluate += new Telerik.WinControls.UI.GroupSummaryEvaluateEventHandler(this.Grid_WareHouse_GroupSummaryEvaluate);
            this.Grid_WareHouse.ContextMenuOpening += new Telerik.WinControls.UI.ContextMenuOpeningEventHandler(this.Grid_WareHouse_ContextMenuOpening);
            // 
            // view1BindingSource
            // 
            this.view1BindingSource.DataMember = "View_1";
            this.view1BindingSource.DataSource = this.warehouse;
            // 
            // warehouse
            // 
            this.warehouse.DataSetName = "warehouse";
            this.warehouse.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txt_GoodsName
            // 
            this.txt_GoodsName.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_GoodsName.Location = new System.Drawing.Point(527, 283);
            this.txt_GoodsName.Name = "txt_GoodsName";
            this.txt_GoodsName.NullText = "   ";
            this.txt_GoodsName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_GoodsName.Size = new System.Drawing.Size(309, 35);
            this.txt_GoodsName.TabIndex = 3;
            this.txt_GoodsName.TabStop = false;
            this.txt_GoodsName.ThemeName = "TelerikMetro";
            this.txt_GoodsName.TextChanged += new System.EventHandler(this.txt_GoodsName_TextChanged);
            this.txt_GoodsName.Enter += new System.EventHandler(this.txt_GoodsName_Enter);
            this.txt_GoodsName.Leave += new System.EventHandler(this.txt_GoodsName_Leave);
            // 
            // lb_GoodsName
            // 
            this.lb_GoodsName.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lb_GoodsName.Location = new System.Drawing.Point(843, 285);
            this.lb_GoodsName.Name = "lb_GoodsName";
            this.lb_GoodsName.Size = new System.Drawing.Size(52, 30);
            this.lb_GoodsName.TabIndex = 2;
            this.lb_GoodsName.Text = "نام کالا: ";
            this.lb_GoodsName.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // txt_ExpDate
            // 
            this.txt_ExpDate.Culture = new System.Globalization.CultureInfo("fa-IR");
            this.txt_ExpDate.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_ExpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_ExpDate.Location = new System.Drawing.Point(527, 394);
            this.txt_ExpDate.Name = "txt_ExpDate";
            this.txt_ExpDate.Size = new System.Drawing.Size(309, 35);
            this.txt_ExpDate.TabIndex = 5;
            this.txt_ExpDate.TabStop = false;
            this.txt_ExpDate.Text = "03/23/2019";
            this.txt_ExpDate.ThemeName = "TelerikMetro";
            this.txt_ExpDate.Value = new System.DateTime(2019, 3, 23, 20, 43, 24, 699);
            // 
            // lb_ExpDate
            // 
            this.lb_ExpDate.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lb_ExpDate.Location = new System.Drawing.Point(843, 394);
            this.lb_ExpDate.Name = "lb_ExpDate";
            this.lb_ExpDate.Size = new System.Drawing.Size(70, 30);
            this.lb_ExpDate.TabIndex = 4;
            this.lb_ExpDate.Text = "تاریخ انقضا:";
            this.lb_ExpDate.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // txt_PurchDate
            // 
            this.txt_PurchDate.Culture = new System.Globalization.CultureInfo("fa-IR");
            this.txt_PurchDate.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_PurchDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_PurchDate.Location = new System.Drawing.Point(527, 338);
            this.txt_PurchDate.Name = "txt_PurchDate";
            this.txt_PurchDate.Size = new System.Drawing.Size(309, 35);
            this.txt_PurchDate.TabIndex = 7;
            this.txt_PurchDate.TabStop = false;
            this.txt_PurchDate.Text = "03/23/2019";
            this.txt_PurchDate.ThemeName = "TelerikMetro";
            this.txt_PurchDate.Value = new System.DateTime(2019, 3, 23, 20, 43, 24, 699);
            // 
            // lb_PurchDate
            // 
            this.lb_PurchDate.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lb_PurchDate.Location = new System.Drawing.Point(843, 343);
            this.lb_PurchDate.Name = "lb_PurchDate";
            this.lb_PurchDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lb_PurchDate.Size = new System.Drawing.Size(68, 30);
            this.lb_PurchDate.TabIndex = 6;
            this.lb_PurchDate.Text = "تاریخ خرید: ";
            this.lb_PurchDate.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // txt_Expence
            // 
            this.txt_Expence.Culture = new System.Globalization.CultureInfo("fa-IR");
            this.txt_Expence.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_Expence.Location = new System.Drawing.Point(49, 283);
            this.txt_Expence.Name = "txt_Expence";
            this.txt_Expence.Size = new System.Drawing.Size(361, 35);
            this.txt_Expence.TabIndex = 9;
            this.txt_Expence.TabStop = false;
            this.txt_Expence.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txt_Expence.ThemeName = "TelerikMetro";
            this.txt_Expence.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Expence_KeyPress);
            this.txt_Expence.TextChanged += new System.EventHandler(this.txt_Expence_TextChanged);
            this.txt_Expence.Enter += new System.EventHandler(this.txt_Expence_Enter);
            this.txt_Expence.Leave += new System.EventHandler(this.txt_Expence_Leave);
            // 
            // lb_Expence
            // 
            this.lb_Expence.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lb_Expence.Location = new System.Drawing.Point(417, 285);
            this.lb_Expence.Name = "lb_Expence";
            this.lb_Expence.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lb_Expence.Size = new System.Drawing.Size(40, 30);
            this.lb_Expence.TabIndex = 8;
            this.lb_Expence.Text = "هزینه:";
            this.lb_Expence.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // panel_WeightUnit
            // 
            this.panel_WeightUnit.Controls.Add(this.btn_Gr);
            this.panel_WeightUnit.Controls.Add(this.btn_Kgr);
            this.panel_WeightUnit.Location = new System.Drawing.Point(49, 324);
            this.panel_WeightUnit.Name = "panel_WeightUnit";
            this.panel_WeightUnit.Size = new System.Drawing.Size(84, 100);
            this.panel_WeightUnit.TabIndex = 18;
            this.panel_WeightUnit.ThemeName = "TelerikMetro";
            this.panel_WeightUnit.Visible = false;
            // 
            // btn_Gr
            // 
            this.btn_Gr.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_Gr.Location = new System.Drawing.Point(39, 13);
            this.btn_Gr.Name = "btn_Gr";
            this.btn_Gr.Size = new System.Drawing.Size(44, 30);
            this.btn_Gr.TabIndex = 10;
            this.btn_Gr.TabStop = false;
            this.btn_Gr.Text = "گرم";
            this.btn_Gr.ThemeName = "TelerikMetro";
            // 
            // btn_Kgr
            // 
            this.btn_Kgr.CheckState = System.Windows.Forms.CheckState.Checked;
            this.btn_Kgr.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_Kgr.Location = new System.Drawing.Point(21, 49);
            this.btn_Kgr.Name = "btn_Kgr";
            this.btn_Kgr.Size = new System.Drawing.Size(62, 30);
            this.btn_Kgr.TabIndex = 11;
            this.btn_Kgr.Text = "کیلوگرم";
            this.btn_Kgr.ThemeName = "TelerikMetro";
            this.btn_Kgr.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            // 
            // ckb_Payed
            // 
            this.ckb_Payed.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ckb_Payed.Location = new System.Drawing.Point(362, 406);
            this.ckb_Payed.Name = "ckb_Payed";
            this.ckb_Payed.Size = new System.Drawing.Size(102, 30);
            this.ckb_Payed.TabIndex = 17;
            this.ckb_Payed.Text = "پرداخت نشده؟";
            this.ckb_Payed.ThemeName = "TelerikMetro";
            // 
            // txt_WeightCount
            // 
            this.txt_WeightCount.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_WeightCount.Location = new System.Drawing.Point(139, 348);
            this.txt_WeightCount.Name = "txt_WeightCount";
            this.txt_WeightCount.Size = new System.Drawing.Size(270, 35);
            this.txt_WeightCount.TabIndex = 16;
            this.txt_WeightCount.TabStop = false;
            this.txt_WeightCount.ThemeName = "TelerikMetro";
            this.txt_WeightCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_WeightCount_KeyPress);
            this.txt_WeightCount.Enter += new System.EventHandler(this.txt_WeightCount_Enter);
            this.txt_WeightCount.Leave += new System.EventHandler(this.txt_WeightCount_Leave);
            // 
            // btn_Count
            // 
            this.btn_Count.CheckState = System.Windows.Forms.CheckState.Checked;
            this.btn_Count.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_Count.Location = new System.Drawing.Point(416, 334);
            this.btn_Count.Name = "btn_Count";
            this.btn_Count.Size = new System.Drawing.Size(50, 30);
            this.btn_Count.TabIndex = 15;
            this.btn_Count.Text = "تعداد";
            this.btn_Count.ThemeName = "TelerikMetro";
            this.btn_Count.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            // 
            // btn_Weight
            // 
            this.btn_Weight.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_Weight.Location = new System.Drawing.Point(417, 370);
            this.btn_Weight.Name = "btn_Weight";
            this.btn_Weight.Size = new System.Drawing.Size(47, 30);
            this.btn_Weight.TabIndex = 14;
            this.btn_Weight.TabStop = false;
            this.btn_Weight.Text = "وزن";
            this.btn_Weight.ThemeName = "TelerikMetro";
            this.btn_Weight.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.btn_Weight_ToggleStateChanged);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Enabled = false;
            this.btn_Delete.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_Delete.Location = new System.Drawing.Point(39, 452);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(110, 39);
            this.btn_Delete.TabIndex = 19;
            this.btn_Delete.Text = "حذف";
            this.btn_Delete.ThemeName = "TelerikMetro";
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Enabled = false;
            this.btn_Edit.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_Edit.Location = new System.Drawing.Point(166, 452);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(110, 39);
            this.btn_Edit.TabIndex = 20;
            this.btn_Edit.Text = "اصلاح";
            this.btn_Edit.ThemeName = "TelerikMetro";
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // EditWareHouse_Alert
            // 
            this.EditWareHouse_Alert.CanMove = false;
            this.EditWareHouse_Alert.ContentImage = global::HomeCafe.Properties.Resources.success_Alert;
            this.EditWareHouse_Alert.Opacity = 1F;
            this.EditWareHouse_Alert.ThemeName = "TelerikMetro";
            // 
            // view_1TableAdapter
            // 
            this.view_1TableAdapter.ClearBeforeFill = true;
            // 
            // combo_Vendor
            // 
            this.combo_Vendor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.combo_Vendor.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            radListDataItem1.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            radListDataItem1.Text = "یک نفره";
            radListDataItem2.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            radListDataItem2.Text = "دو نفره";
            radListDataItem3.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            radListDataItem3.Text = "سینگل";
            radListDataItem4.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            radListDataItem4.Text = "دوبل";
            this.combo_Vendor.Items.Add(radListDataItem1);
            this.combo_Vendor.Items.Add(radListDataItem2);
            this.combo_Vendor.Items.Add(radListDataItem3);
            this.combo_Vendor.Items.Add(radListDataItem4);
            this.combo_Vendor.Location = new System.Drawing.Point(527, 453);
            this.combo_Vendor.Name = "combo_Vendor";
            this.combo_Vendor.Size = new System.Drawing.Size(309, 35);
            this.combo_Vendor.TabIndex = 163;
            this.combo_Vendor.ThemeName = "TelerikMetro";
            this.combo_Vendor.TextChanged += new System.EventHandler(this.combo_Vendor_TextChanged);
            ((Telerik.WinControls.UI.RadDropDownListElement)(this.combo_Vendor.GetChildAt(0))).RightToLeft = true;
            ((Telerik.WinControls.UI.RadDropDownListElement)(this.combo_Vendor.GetChildAt(0))).Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            // 
            // lb_Vendor
            // 
            this.lb_Vendor.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lb_Vendor.Location = new System.Drawing.Point(843, 455);
            this.lb_Vendor.Name = "lb_Vendor";
            this.lb_Vendor.Size = new System.Drawing.Size(70, 30);
            this.lb_Vendor.TabIndex = 162;
            this.lb_Vendor.Text = "تامین کننده:";
            this.lb_Vendor.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // FrmEditWareHouse
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(918, 550);
            this.Controls.Add(this.combo_Vendor);
            this.Controls.Add(this.lb_Vendor);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.panel_WeightUnit);
            this.Controls.Add(this.ckb_Payed);
            this.Controls.Add(this.txt_WeightCount);
            this.Controls.Add(this.btn_Count);
            this.Controls.Add(this.btn_Weight);
            this.Controls.Add(this.txt_Expence);
            this.Controls.Add(this.lb_Expence);
            this.Controls.Add(this.txt_PurchDate);
            this.Controls.Add(this.lb_PurchDate);
            this.Controls.Add(this.txt_ExpDate);
            this.Controls.Add(this.lb_ExpDate);
            this.Controls.Add(this.txt_GoodsName);
            this.Controls.Add(this.lb_GoodsName);
            this.Controls.Add(this.Grid_WareHouse);
            this.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmEditWareHouse";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "FrmEditWareHouse";
            this.Load += new System.EventHandler(this.frm_EditWareHouse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid_WareHouse.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_WareHouse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_GoodsName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lb_GoodsName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ExpDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lb_ExpDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_PurchDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lb_PurchDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Expence)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lb_Expence)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_WeightUnit)).EndInit();
            this.panel_WeightUnit.ResumeLayout(false);
            this.panel_WeightUnit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Gr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Kgr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckb_Payed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_WeightCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Count)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Weight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Delete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.combo_Vendor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lb_Vendor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RadGridView Grid_WareHouse;
        private RadMaskedEditBox txt_GoodsName;
        private RadLabel lb_GoodsName;
        private RadDateTimePicker txt_ExpDate;
        private RadLabel lb_ExpDate;
        private RadDateTimePicker txt_PurchDate;
        private RadLabel lb_PurchDate;
        private RadMaskedEditBox txt_Expence;
        private RadLabel lb_Expence;
        private RadPanel panel_WeightUnit;
        private RadRadioButton btn_Gr;
        private RadRadioButton btn_Kgr;
        private RadCheckBox ckb_Payed;
        private RadMaskedEditBox txt_WeightCount;
        private RadRadioButton btn_Count;
        private RadRadioButton btn_Weight;
        private RadButton btn_Delete;
        private RadButton btn_Edit;
        private RadDesktopAlert EditWareHouse_Alert;
        private warehouse warehouse;
        private BindingSource view1BindingSource;
        private View_1TableAdapter view_1TableAdapter;
        private RadDropDownList combo_Vendor;
        private RadLabel lb_Vendor;
    }
}