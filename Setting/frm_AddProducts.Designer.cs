namespace HomeCafe.Setting
{
    partial class frm_AddProducts
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
            Telerik.WinControls.UI.RadListDataItem radListDataItem1 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem2 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem3 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem4 = new Telerik.WinControls.UI.RadListDataItem();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_AddProducts));
            this.combo_Catagories = new Telerik.WinControls.UI.RadDropDownList();
            this.AddProducts_Alert = new Telerik.WinControls.UI.RadDesktopAlert(this.components);
            this.lb_Catagories = new Telerik.WinControls.UI.RadLabel();
            this.lb_Products = new Telerik.WinControls.UI.RadLabel();
            this.combo_Products = new Telerik.WinControls.UI.RadDropDownList();
            this.btn_Save = new Telerik.WinControls.UI.RadButton();
            this.ckb_Size = new Telerik.WinControls.UI.RadCheckBox();
            this.lb_Price = new Telerik.WinControls.UI.RadLabel();
            this.txt_Price = new Telerik.WinControls.UI.RadMaskedEditBox();
            this.combo_Size = new Telerik.WinControls.UI.RadDropDownList();
            ((System.ComponentModel.ISupportInitialize)(this.combo_Catagories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lb_Catagories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lb_Products)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.combo_Products)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Save)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckb_Size)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lb_Price)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Price)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.combo_Size)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // combo_Catagories
            // 
            this.combo_Catagories.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.combo_Catagories.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.combo_Catagories.Location = new System.Drawing.Point(12, 17);
            this.combo_Catagories.Name = "combo_Catagories";
            this.combo_Catagories.Size = new System.Drawing.Size(285, 35);
            this.combo_Catagories.TabIndex = 0;
            this.combo_Catagories.ThemeName = "TelerikMetro";
            this.combo_Catagories.TextChanged += new System.EventHandler(this.combo_Catagories_TextChanged);
            this.combo_Catagories.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.combo_Catagories_SelectedIndexChanged);
            this.combo_Catagories.Enter += new System.EventHandler(this.combo_Catagories_Enter);
            this.combo_Catagories.Leave += new System.EventHandler(this.combo_Catagories_Leave);
            ((Telerik.WinControls.UI.RadDropDownListElement)(this.combo_Catagories.GetChildAt(0))).RightToLeft = true;
            ((Telerik.WinControls.UI.RadDropDownListElement)(this.combo_Catagories.GetChildAt(0))).Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            // 
            // AddProducts_Alert
            // 
            this.AddProducts_Alert.ContentImage = global::HomeCafe.Properties.Resources.success_Alert;
            this.AddProducts_Alert.ThemeName = "TelerikMetro";
            // 
            // lb_Catagories
            // 
            this.lb_Catagories.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lb_Catagories.Location = new System.Drawing.Point(303, 19);
            this.lb_Catagories.Name = "lb_Catagories";
            this.lb_Catagories.Size = new System.Drawing.Size(57, 30);
            this.lb_Catagories.TabIndex = 2;
            this.lb_Catagories.Text = "نام دسته:";
            this.lb_Catagories.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            this.lb_Catagories.ThemeName = "TelerikMetro";
            // 
            // lb_Products
            // 
            this.lb_Products.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lb_Products.Location = new System.Drawing.Point(303, 61);
            this.lb_Products.Name = "lb_Products";
            this.lb_Products.Size = new System.Drawing.Size(74, 30);
            this.lb_Products.TabIndex = 3;
            this.lb_Products.Text = "نام محصول :";
            this.lb_Products.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            this.lb_Products.ThemeName = "TelerikMetro";
            // 
            // combo_Products
            // 
            this.combo_Products.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.combo_Products.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.combo_Products.Location = new System.Drawing.Point(12, 59);
            this.combo_Products.Name = "combo_Products";
            this.combo_Products.Size = new System.Drawing.Size(285, 35);
            this.combo_Products.TabIndex = 1;
            this.combo_Products.ThemeName = "TelerikMetro";
            this.combo_Products.TextChanged += new System.EventHandler(this.combo_Products_TextChanged);
            this.combo_Products.Enter += new System.EventHandler(this.combo_Products_Enter);
            this.combo_Products.Leave += new System.EventHandler(this.combo_Products_Leave);
            ((Telerik.WinControls.UI.RadDropDownListElement)(this.combo_Products.GetChildAt(0))).RightToLeft = true;
            ((Telerik.WinControls.UI.RadDropDownListElement)(this.combo_Products.GetChildAt(0))).Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            // 
            // btn_Save
            // 
            this.btn_Save.Enabled = false;
            this.btn_Save.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_Save.Location = new System.Drawing.Point(12, 192);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(110, 38);
            this.btn_Save.TabIndex = 7;
            this.btn_Save.Text = "ثبت";
            this.btn_Save.ThemeName = "TelerikMetro";
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // ckb_Size
            // 
            this.ckb_Size.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ckb_Size.Location = new System.Drawing.Point(303, 105);
            this.ckb_Size.Name = "ckb_Size";
            this.ckb_Size.Size = new System.Drawing.Size(82, 30);
            this.ckb_Size.TabIndex = 4;
            this.ckb_Size.Text = "سایز مختلف";
            this.ckb_Size.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.ckb_Size_ToggleStateChanged);
            // 
            // lb_Price
            // 
            this.lb_Price.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lb_Price.Location = new System.Drawing.Point(303, 154);
            this.lb_Price.Name = "lb_Price";
            this.lb_Price.Size = new System.Drawing.Size(50, 30);
            this.lb_Price.TabIndex = 9;
            this.lb_Price.Text = "قیمت :";
            this.lb_Price.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            this.lb_Price.ThemeName = "TelerikMetro";
            // 
            // txt_Price
            // 
            this.txt_Price.Culture = new System.Globalization.CultureInfo("fa-IR");
            this.txt_Price.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_Price.Location = new System.Drawing.Point(12, 149);
            this.txt_Price.Name = "txt_Price";
            this.txt_Price.Size = new System.Drawing.Size(285, 35);
            this.txt_Price.TabIndex = 6;
            this.txt_Price.TabStop = false;
            this.txt_Price.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txt_Price.ThemeName = "TelerikMetro";
            this.txt_Price.TextChanged += new System.EventHandler(this.txt_Price_TextChanged);
            this.txt_Price.Enter += new System.EventHandler(this.txt_Price_Enter);
            this.txt_Price.Leave += new System.EventHandler(this.txt_Price_Leave);
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
            this.combo_Size.Location = new System.Drawing.Point(12, 103);
            this.combo_Size.Name = "combo_Size";
            this.combo_Size.Size = new System.Drawing.Size(285, 35);
            this.combo_Size.TabIndex = 10;
            this.combo_Size.ThemeName = "TelerikMetro";
            this.combo_Size.TextChanged += new System.EventHandler(this.combo_Size_TextChanged);
            this.combo_Size.Enter += new System.EventHandler(this.combo_Size_Enter);
            this.combo_Size.Leave += new System.EventHandler(this.combo_Size_Leave);
            ((Telerik.WinControls.UI.RadDropDownListElement)(this.combo_Size.GetChildAt(0))).RightToLeft = true;
            ((Telerik.WinControls.UI.RadDropDownListElement)(this.combo_Size.GetChildAt(0))).Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            // 
            // frm_AddProducts
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(403, 238);
            this.Controls.Add(this.combo_Size);
            this.Controls.Add(this.txt_Price);
            this.Controls.Add(this.lb_Price);
            this.Controls.Add(this.ckb_Size);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.combo_Products);
            this.Controls.Add(this.lb_Products);
            this.Controls.Add(this.lb_Catagories);
            this.Controls.Add(this.combo_Catagories);
            this.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_AddProducts";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frm_AddProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.combo_Catagories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lb_Catagories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lb_Products)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.combo_Products)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Save)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckb_Size)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lb_Price)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Price)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.combo_Size)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadDropDownList combo_Catagories;
        private Telerik.WinControls.UI.RadDesktopAlert AddProducts_Alert;
        private Telerik.WinControls.UI.RadLabel lb_Catagories;
        private Telerik.WinControls.UI.RadLabel lb_Products;
        private Telerik.WinControls.UI.RadDropDownList combo_Products;
        private Telerik.WinControls.UI.RadButton btn_Save;
        private Telerik.WinControls.UI.RadCheckBox ckb_Size;
        private Telerik.WinControls.UI.RadLabel lb_Price;
        private Telerik.WinControls.UI.RadMaskedEditBox txt_Price;
        private Telerik.WinControls.UI.RadDropDownList combo_Size;
    }
}