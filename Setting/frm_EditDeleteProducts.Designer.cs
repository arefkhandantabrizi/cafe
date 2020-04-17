namespace HomeCafe.Setting
{
    partial class frm_EditDeleteProducts
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
            Telerik.WinControls.UI.RadListDataItem radListDataItem1 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem2 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem3 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem4 = new Telerik.WinControls.UI.RadListDataItem();
            this.Panel_EditGrid = new Telerik.WinControls.UI.RadPanel();
            this.Grid_EditDeleteProducts = new Telerik.WinControls.UI.RadGridView();
            this.Alert_EditDeleteProducts = new Telerik.WinControls.UI.RadDesktopAlert(this.components);
            this.combo_Size = new Telerik.WinControls.UI.RadDropDownList();
            this.txt_Price = new Telerik.WinControls.UI.RadMaskedEditBox();
            this.lb_Price = new Telerik.WinControls.UI.RadLabel();
            this.ckb_Size = new Telerik.WinControls.UI.RadCheckBox();
            this.combo_Products = new Telerik.WinControls.UI.RadDropDownList();
            this.lb_Products = new Telerik.WinControls.UI.RadLabel();
            this.lb_Catagories = new Telerik.WinControls.UI.RadLabel();
            this.combo_Catagories = new Telerik.WinControls.UI.RadDropDownList();
            this.btn_Delete = new Telerik.WinControls.UI.RadButton();
            this.btn_Edit = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.Panel_EditGrid)).BeginInit();
            this.Panel_EditGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_EditDeleteProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_EditDeleteProducts.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.combo_Size)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Price)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lb_Price)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckb_Size)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.combo_Products)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lb_Products)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lb_Catagories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.combo_Catagories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Delete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Edit)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel_EditGrid
            // 
            this.Panel_EditGrid.Controls.Add(this.Grid_EditDeleteProducts);
            this.Panel_EditGrid.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_EditGrid.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Panel_EditGrid.Location = new System.Drawing.Point(0, 0);
            this.Panel_EditGrid.Name = "Panel_EditGrid";
            this.Panel_EditGrid.Size = new System.Drawing.Size(911, 309);
            this.Panel_EditGrid.TabIndex = 0;
            // 
            // Grid_EditDeleteProducts
            // 
            this.Grid_EditDeleteProducts.AutoSizeRows = true;
            this.Grid_EditDeleteProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Grid_EditDeleteProducts.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Grid_EditDeleteProducts.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            this.Grid_EditDeleteProducts.MasterTemplate.AllowAddNewRow = false;
            this.Grid_EditDeleteProducts.MasterTemplate.AllowDeleteRow = false;
            this.Grid_EditDeleteProducts.MasterTemplate.AllowEditRow = false;
            this.Grid_EditDeleteProducts.MasterTemplate.AllowSearchRow = true;
            this.Grid_EditDeleteProducts.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.Grid_EditDeleteProducts.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.Grid_EditDeleteProducts.Name = "Grid_EditDeleteProducts";
            this.Grid_EditDeleteProducts.Size = new System.Drawing.Size(911, 309);
            this.Grid_EditDeleteProducts.TabIndex = 0;
            this.Grid_EditDeleteProducts.ThemeName = "TelerikMetro";
            this.Grid_EditDeleteProducts.CreateCell += new Telerik.WinControls.UI.GridViewCreateCellEventHandler(this.Grid_EditDeleteProducts_CreateCell);
            this.Grid_EditDeleteProducts.ViewCellFormatting += new Telerik.WinControls.UI.CellFormattingEventHandler(this.Grid_EditDeleteProducts_ViewCellFormatting);
            this.Grid_EditDeleteProducts.SelectionChanged += new System.EventHandler(this.Grid_EditDeleteProducts_SelectionChanged);
            this.Grid_EditDeleteProducts.ColumnChooserItemElementCreating += new Telerik.WinControls.UI.ColumnChooserItemElementCreatingEventHandler(this.Grid_EditDeleteProducts_ColumnChooserItemElementCreating);
            this.Grid_EditDeleteProducts.ConditionalFormattingFormShown += new System.EventHandler(this.Grid_EditDeleteProducts_ConditionalFormattingFormShown);
            this.Grid_EditDeleteProducts.GroupSummaryEvaluate += new Telerik.WinControls.UI.GroupSummaryEvaluateEventHandler(this.Grid_EditDeleteProducts_GroupSummaryEvaluate);
            this.Grid_EditDeleteProducts.ContextMenuOpening += new Telerik.WinControls.UI.ContextMenuOpeningEventHandler(this.Grid_EditDeleteProducts_ContextMenuOpening);
            // 
            // Alert_EditDeleteProducts
            // 
            this.Alert_EditDeleteProducts.CanMove = false;
            this.Alert_EditDeleteProducts.ContentImage = global::HomeCafe.Properties.Resources.success_Alert;
            this.Alert_EditDeleteProducts.ThemeName = "TelerikMetro";
            // 
            // combo_Size
            // 
            this.combo_Size.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.combo_Size.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            radListDataItem1.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            radListDataItem1.Text = "یک نفره";
            radListDataItem2.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            radListDataItem2.Text = "دو نفره";
            radListDataItem3.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            radListDataItem3.Text = "سینگل";
            radListDataItem4.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            radListDataItem4.Text = "دوبل";
            this.combo_Size.Items.Add(radListDataItem1);
            this.combo_Size.Items.Add(radListDataItem2);
            this.combo_Size.Items.Add(radListDataItem3);
            this.combo_Size.Items.Add(radListDataItem4);
            this.combo_Size.Location = new System.Drawing.Point(12, 331);
            this.combo_Size.Name = "combo_Size";
            this.combo_Size.Size = new System.Drawing.Size(315, 35);
            this.combo_Size.TabIndex = 18;
            this.combo_Size.ThemeName = "TelerikMetro";
            this.combo_Size.TextChanged += new System.EventHandler(this.combo_Size_TextChanged);
            this.combo_Size.Enter += new System.EventHandler(this.combo_Size_Enter);
            this.combo_Size.Leave += new System.EventHandler(this.combo_Size_Leave);
            ((Telerik.WinControls.UI.RadDropDownListElement)(this.combo_Size.GetChildAt(0))).RightToLeft = true;
            ((Telerik.WinControls.UI.RadDropDownListElement)(this.combo_Size.GetChildAt(0))).Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            // 
            // txt_Price
            // 
            this.txt_Price.Culture = new System.Globalization.CultureInfo("fa-IR");
            this.txt_Price.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_Price.Location = new System.Drawing.Point(12, 370);
            this.txt_Price.Name = "txt_Price";
            this.txt_Price.Size = new System.Drawing.Size(315, 35);
            this.txt_Price.TabIndex = 16;
            this.txt_Price.TabStop = false;
            this.txt_Price.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txt_Price.ThemeName = "TelerikMetro";
            this.txt_Price.TextChanged += new System.EventHandler(this.txt_Price_TextChanged);
            // 
            // lb_Price
            // 
            this.lb_Price.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lb_Price.Location = new System.Drawing.Point(333, 375);
            this.lb_Price.Name = "lb_Price";
            this.lb_Price.Size = new System.Drawing.Size(50, 30);
            this.lb_Price.TabIndex = 17;
            this.lb_Price.Text = "قیمت :";
            this.lb_Price.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            this.lb_Price.ThemeName = "TelerikMetro";
            // 
            // ckb_Size
            // 
            this.ckb_Size.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ckb_Size.Location = new System.Drawing.Point(333, 333);
            this.ckb_Size.Name = "ckb_Size";
            this.ckb_Size.Size = new System.Drawing.Size(82, 30);
            this.ckb_Size.TabIndex = 15;
            this.ckb_Size.Text = "سایز مختلف";
            this.ckb_Size.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.ckb_Size_ToggleStateChanged);
            // 
            // combo_Products
            // 
            this.combo_Products.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.combo_Products.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.combo_Products.Location = new System.Drawing.Point(529, 373);
            this.combo_Products.Name = "combo_Products";
            this.combo_Products.Size = new System.Drawing.Size(307, 35);
            this.combo_Products.TabIndex = 12;
            this.combo_Products.ThemeName = "TelerikMetro";
            this.combo_Products.TextChanged += new System.EventHandler(this.combo_Products_TextChanged);
            this.combo_Products.Enter += new System.EventHandler(this.combo_Products_Enter);
            this.combo_Products.Leave += new System.EventHandler(this.combo_Products_Leave);
            ((Telerik.WinControls.UI.RadDropDownListElement)(this.combo_Products.GetChildAt(0))).RightToLeft = true;
            ((Telerik.WinControls.UI.RadDropDownListElement)(this.combo_Products.GetChildAt(0))).Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            // 
            // lb_Products
            // 
            this.lb_Products.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lb_Products.Location = new System.Drawing.Point(842, 375);
            this.lb_Products.Name = "lb_Products";
            this.lb_Products.Size = new System.Drawing.Size(74, 30);
            this.lb_Products.TabIndex = 14;
            this.lb_Products.Text = "نام محصول :";
            this.lb_Products.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            this.lb_Products.ThemeName = "TelerikMetro";
            // 
            // lb_Catagories
            // 
            this.lb_Catagories.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lb_Catagories.Location = new System.Drawing.Point(842, 333);
            this.lb_Catagories.Name = "lb_Catagories";
            this.lb_Catagories.Size = new System.Drawing.Size(57, 30);
            this.lb_Catagories.TabIndex = 13;
            this.lb_Catagories.Text = "نام دسته:";
            this.lb_Catagories.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            this.lb_Catagories.ThemeName = "TelerikMetro";
            // 
            // combo_Catagories
            // 
            this.combo_Catagories.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.combo_Catagories.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.combo_Catagories.Location = new System.Drawing.Point(529, 331);
            this.combo_Catagories.Name = "combo_Catagories";
            this.combo_Catagories.Size = new System.Drawing.Size(307, 35);
            this.combo_Catagories.TabIndex = 11;
            this.combo_Catagories.ThemeName = "TelerikMetro";
            this.combo_Catagories.TextChanged += new System.EventHandler(this.combo_Catagories_TextChanged);
            this.combo_Catagories.Enter += new System.EventHandler(this.combo_Catagories_Enter);
            this.combo_Catagories.Leave += new System.EventHandler(this.combo_Catagories_Leave);
            ((Telerik.WinControls.UI.RadDropDownListElement)(this.combo_Catagories.GetChildAt(0))).RightToLeft = true;
            ((Telerik.WinControls.UI.RadDropDownListElement)(this.combo_Catagories.GetChildAt(0))).Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            // 
            // btn_Delete
            // 
            this.btn_Delete.Enabled = false;
            this.btn_Delete.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_Delete.Location = new System.Drawing.Point(12, 431);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(110, 38);
            this.btn_Delete.TabIndex = 19;
            this.btn_Delete.Text = "حذف";
            this.btn_Delete.ThemeName = "TelerikMetro";
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Enabled = false;
            this.btn_Edit.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_Edit.Location = new System.Drawing.Point(128, 431);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(110, 38);
            this.btn_Edit.TabIndex = 20;
            this.btn_Edit.Text = "اصلاح";
            this.btn_Edit.ThemeName = "TelerikMetro";
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // frm_EditDeleteProducts
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(911, 481);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.combo_Size);
            this.Controls.Add(this.txt_Price);
            this.Controls.Add(this.lb_Price);
            this.Controls.Add(this.ckb_Size);
            this.Controls.Add(this.combo_Products);
            this.Controls.Add(this.lb_Products);
            this.Controls.Add(this.lb_Catagories);
            this.Controls.Add(this.combo_Catagories);
            this.Controls.Add(this.Panel_EditGrid);
            this.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_EditDeleteProducts";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "frm_EditDeleteProducts";
            this.Load += new System.EventHandler(this.frm_EditDeleteProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Panel_EditGrid)).EndInit();
            this.Panel_EditGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Grid_EditDeleteProducts.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_EditDeleteProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.combo_Size)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Price)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lb_Price)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckb_Size)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.combo_Products)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lb_Products)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lb_Catagories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.combo_Catagories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Delete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Edit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadPanel Panel_EditGrid;
        private Telerik.WinControls.UI.RadGridView Grid_EditDeleteProducts;
        private Telerik.WinControls.UI.RadDesktopAlert Alert_EditDeleteProducts;
        private Telerik.WinControls.UI.RadDropDownList combo_Size;
        private Telerik.WinControls.UI.RadMaskedEditBox txt_Price;
        private Telerik.WinControls.UI.RadLabel lb_Price;
        private Telerik.WinControls.UI.RadCheckBox ckb_Size;
        private Telerik.WinControls.UI.RadDropDownList combo_Products;
        private Telerik.WinControls.UI.RadLabel lb_Products;
        private Telerik.WinControls.UI.RadLabel lb_Catagories;
        private Telerik.WinControls.UI.RadDropDownList combo_Catagories;
        private Telerik.WinControls.UI.RadButton btn_Delete;
        private Telerik.WinControls.UI.RadButton btn_Edit;
    }
}