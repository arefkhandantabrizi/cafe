using System.ComponentModel;
using Telerik.WinControls.UI;

namespace HomeCafe.Warehouse
{
    partial class FrmWareHouse
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
            Telerik.WinControls.UI.RadListDataItem radListDataItem1 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem2 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem3 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem4 = new Telerik.WinControls.UI.RadListDataItem();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmWareHouse));
            this.lb_GoodsName = new Telerik.WinControls.UI.RadLabel();
            this.txt_GoodsName = new Telerik.WinControls.UI.RadMaskedEditBox();
            this.lb_ExpDate = new Telerik.WinControls.UI.RadLabel();
            this.lb_PurchDate = new Telerik.WinControls.UI.RadLabel();
            this.txt_ExpDate = new Telerik.WinControls.UI.RadDateTimePicker();
            this.txt_PurchDate = new Telerik.WinControls.UI.RadDateTimePicker();
            this.txt_Expence = new Telerik.WinControls.UI.RadMaskedEditBox();
            this.lb_Expence = new Telerik.WinControls.UI.RadLabel();
            this.btn_Weight = new Telerik.WinControls.UI.RadRadioButton();
            this.btn_Count = new Telerik.WinControls.UI.RadRadioButton();
            this.txt_WeightCount = new Telerik.WinControls.UI.RadMaskedEditBox();
            this.btn_Kgr = new Telerik.WinControls.UI.RadRadioButton();
            this.btn_Gr = new Telerik.WinControls.UI.RadRadioButton();
            this.ckb_Payed = new Telerik.WinControls.UI.RadCheckBox();
            this.panel_WeightUnit = new Telerik.WinControls.UI.RadPanel();
            this.btn_Save = new Telerik.WinControls.UI.RadButton();
            this.WareHouse_Alert = new Telerik.WinControls.UI.RadDesktopAlert(this.components);
            this.lb_Vendor = new Telerik.WinControls.UI.RadLabel();
            this.combo_Vendor = new Telerik.WinControls.UI.RadDropDownList();
            ((System.ComponentModel.ISupportInitialize)(this.lb_GoodsName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_GoodsName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lb_ExpDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lb_PurchDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ExpDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_PurchDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Expence)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lb_Expence)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Weight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Count)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_WeightCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Kgr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Gr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckb_Payed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_WeightUnit)).BeginInit();
            this.panel_WeightUnit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Save)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lb_Vendor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.combo_Vendor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_GoodsName
            // 
            this.lb_GoodsName.Font = new System.Drawing.Font("IRANSansDNFaNum", 9.75F);
            this.lb_GoodsName.Location = new System.Drawing.Point(322, 15);
            this.lb_GoodsName.Name = "lb_GoodsName";
            this.lb_GoodsName.Size = new System.Drawing.Size(50, 24);
            this.lb_GoodsName.TabIndex = 0;
            this.lb_GoodsName.Text = "نام کالا: ";
            this.lb_GoodsName.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // txt_GoodsName
            // 
            this.txt_GoodsName.Font = new System.Drawing.Font("IRANSansDNFaNum", 9.75F);
            this.txt_GoodsName.Location = new System.Drawing.Point(15, 10);
            this.txt_GoodsName.Name = "txt_GoodsName";
            this.txt_GoodsName.Size = new System.Drawing.Size(299, 29);
            this.txt_GoodsName.TabIndex = 1;
            this.txt_GoodsName.TabStop = false;
            this.txt_GoodsName.ThemeName = "TelerikMetro";
            this.txt_GoodsName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_GoodsName_KeyPress);
            this.txt_GoodsName.TextChanged += new System.EventHandler(this.txt_GoodsName_TextChanged);
            this.txt_GoodsName.Enter += new System.EventHandler(this.txt_GoodsName_Enter);
            this.txt_GoodsName.Leave += new System.EventHandler(this.txt_GoodsName_Leave);
            // 
            // lb_ExpDate
            // 
            this.lb_ExpDate.Font = new System.Drawing.Font("IRANSansDNFaNum", 9.75F);
            this.lb_ExpDate.Location = new System.Drawing.Point(320, 115);
            this.lb_ExpDate.Name = "lb_ExpDate";
            this.lb_ExpDate.Size = new System.Drawing.Size(71, 24);
            this.lb_ExpDate.TabIndex = 2;
            this.lb_ExpDate.Text = "تاریخ انقضا:";
            this.lb_ExpDate.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // lb_PurchDate
            // 
            this.lb_PurchDate.Font = new System.Drawing.Font("IRANSansDNFaNum", 9.75F);
            this.lb_PurchDate.Location = new System.Drawing.Point(318, 65);
            this.lb_PurchDate.Name = "lb_PurchDate";
            this.lb_PurchDate.Size = new System.Drawing.Size(75, 24);
            this.lb_PurchDate.TabIndex = 1;
            this.lb_PurchDate.Text = "تاریخ خرید: ";
            this.lb_PurchDate.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // txt_ExpDate
            // 
            this.txt_ExpDate.Culture = new System.Globalization.CultureInfo("fa-IR");
            this.txt_ExpDate.Font = new System.Drawing.Font("IRANSansDNFaNum", 9.75F);
            this.txt_ExpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_ExpDate.Location = new System.Drawing.Point(15, 110);
            this.txt_ExpDate.Name = "txt_ExpDate";
            this.txt_ExpDate.Size = new System.Drawing.Size(299, 29);
            this.txt_ExpDate.TabIndex = 3;
            this.txt_ExpDate.TabStop = false;
            this.txt_ExpDate.Text = "03/23/2019";
            this.txt_ExpDate.ThemeName = "TelerikMetro";
            this.txt_ExpDate.Value = new System.DateTime(2019, 3, 23, 20, 43, 24, 699);
            // 
            // txt_PurchDate
            // 
            this.txt_PurchDate.Culture = new System.Globalization.CultureInfo("fa-IR");
            this.txt_PurchDate.Font = new System.Drawing.Font("IRANSansDNFaNum", 9.75F);
            this.txt_PurchDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_PurchDate.Location = new System.Drawing.Point(15, 60);
            this.txt_PurchDate.Name = "txt_PurchDate";
            this.txt_PurchDate.Size = new System.Drawing.Size(299, 29);
            this.txt_PurchDate.TabIndex = 2;
            this.txt_PurchDate.TabStop = false;
            this.txt_PurchDate.Text = "03/23/2019";
            this.txt_PurchDate.ThemeName = "TelerikMetro";
            this.txt_PurchDate.Value = new System.DateTime(2019, 3, 23, 20, 43, 24, 699);
            // 
            // txt_Expence
            // 
            this.txt_Expence.Culture = new System.Globalization.CultureInfo("fa-IR");
            this.txt_Expence.Font = new System.Drawing.Font("IRANSansDNFaNum", 9.75F);
            this.txt_Expence.Location = new System.Drawing.Point(15, 207);
            this.txt_Expence.Name = "txt_Expence";
            this.txt_Expence.Size = new System.Drawing.Size(299, 29);
            this.txt_Expence.TabIndex = 4;
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
            this.lb_Expence.Font = new System.Drawing.Font("IRANSansDNFaNum", 9.75F);
            this.lb_Expence.Location = new System.Drawing.Point(321, 209);
            this.lb_Expence.Name = "lb_Expence";
            this.lb_Expence.Size = new System.Drawing.Size(41, 24);
            this.lb_Expence.TabIndex = 5;
            this.lb_Expence.Text = "هزینه:";
            this.lb_Expence.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // btn_Weight
            // 
            this.btn_Weight.Font = new System.Drawing.Font("IRANSansDNFaNum", 9.75F);
            this.btn_Weight.Location = new System.Drawing.Point(329, 297);
            this.btn_Weight.Name = "btn_Weight";
            this.btn_Weight.Size = new System.Drawing.Size(44, 24);
            this.btn_Weight.TabIndex = 6;
            this.btn_Weight.TabStop = false;
            this.btn_Weight.Text = "وزن";
            this.btn_Weight.ThemeName = "TelerikMetro";
            this.btn_Weight.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.btn_Weight_ToggleStateChanged);
            // 
            // btn_Count
            // 
            this.btn_Count.CheckState = System.Windows.Forms.CheckState.Checked;
            this.btn_Count.Font = new System.Drawing.Font("IRANSansDNFaNum", 9.75F);
            this.btn_Count.Location = new System.Drawing.Point(321, 261);
            this.btn_Count.Name = "btn_Count";
            this.btn_Count.Size = new System.Drawing.Size(52, 24);
            this.btn_Count.TabIndex = 5;
            this.btn_Count.Text = "تعداد";
            this.btn_Count.ThemeName = "TelerikMetro";
            this.btn_Count.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            // 
            // txt_WeightCount
            // 
            this.txt_WeightCount.Font = new System.Drawing.Font("IRANSansDNFaNum", 9.75F);
            this.txt_WeightCount.Location = new System.Drawing.Point(105, 275);
            this.txt_WeightCount.Name = "txt_WeightCount";
            this.txt_WeightCount.Size = new System.Drawing.Size(209, 29);
            this.txt_WeightCount.TabIndex = 9;
            this.txt_WeightCount.TabStop = false;
            this.txt_WeightCount.ThemeName = "TelerikMetro";
            this.txt_WeightCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_WeightCount_KeyPress);
            this.txt_WeightCount.TextChanged += new System.EventHandler(this.txt_WeightCount_TextChanged);
            this.txt_WeightCount.Enter += new System.EventHandler(this.txt_WeightCount_Enter);
            this.txt_WeightCount.Leave += new System.EventHandler(this.txt_WeightCount_Leave);
            // 
            // btn_Kgr
            // 
            this.btn_Kgr.CheckState = System.Windows.Forms.CheckState.Checked;
            this.btn_Kgr.Font = new System.Drawing.Font("IRANSansDNFaNum", 9.75F);
            this.btn_Kgr.Location = new System.Drawing.Point(17, 49);
            this.btn_Kgr.Name = "btn_Kgr";
            this.btn_Kgr.Size = new System.Drawing.Size(63, 24);
            this.btn_Kgr.TabIndex = 11;
            this.btn_Kgr.Text = "کیلوگرم";
            this.btn_Kgr.ThemeName = "TelerikMetro";
            this.btn_Kgr.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            // 
            // btn_Gr
            // 
            this.btn_Gr.Font = new System.Drawing.Font("IRANSansDNFaNum", 9.75F);
            this.btn_Gr.Location = new System.Drawing.Point(38, 13);
            this.btn_Gr.Name = "btn_Gr";
            this.btn_Gr.Size = new System.Drawing.Size(42, 24);
            this.btn_Gr.TabIndex = 10;
            this.btn_Gr.TabStop = false;
            this.btn_Gr.Text = "گرم";
            this.btn_Gr.ThemeName = "TelerikMetro";
            // 
            // ckb_Payed
            // 
            this.ckb_Payed.Font = new System.Drawing.Font("IRANSansDNFaNum", 9.75F);
            this.ckb_Payed.Location = new System.Drawing.Point(267, 333);
            this.ckb_Payed.Name = "ckb_Payed";
            this.ckb_Payed.Size = new System.Drawing.Size(105, 24);
            this.ckb_Payed.TabIndex = 12;
            this.ckb_Payed.Text = "پرداخت نشده؟";
            this.ckb_Payed.ThemeName = "TelerikMetro";
            // 
            // panel_WeightUnit
            // 
            this.panel_WeightUnit.Controls.Add(this.btn_Gr);
            this.panel_WeightUnit.Controls.Add(this.btn_Kgr);
            this.panel_WeightUnit.Location = new System.Drawing.Point(15, 248);
            this.panel_WeightUnit.Name = "panel_WeightUnit";
            this.panel_WeightUnit.Size = new System.Drawing.Size(84, 100);
            this.panel_WeightUnit.TabIndex = 13;
            this.panel_WeightUnit.ThemeName = "TelerikMetro";
            this.panel_WeightUnit.Visible = false;
            // 
            // btn_Save
            // 
            this.btn_Save.Enabled = false;
            this.btn_Save.Font = new System.Drawing.Font("IRANSansDNFaNum", 9.75F);
            this.btn_Save.Location = new System.Drawing.Point(15, 370);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(110, 39);
            this.btn_Save.TabIndex = 14;
            this.btn_Save.Text = "ثبت";
            this.btn_Save.ThemeName = "TelerikMetro";
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // WareHouse_Alert
            // 
            this.WareHouse_Alert.CanMove = false;
            this.WareHouse_Alert.CaptionText = "توجه";
            this.WareHouse_Alert.ContentImage = global::HomeCafe.Properties.Resources.success_Alert;
            this.WareHouse_Alert.Opacity = 1F;
            this.WareHouse_Alert.ShowOptionsButton = false;
            this.WareHouse_Alert.ThemeName = "TelerikMetro";
            // 
            // lb_Vendor
            // 
            this.lb_Vendor.Font = new System.Drawing.Font("IRANSansDNFaNum", 9.75F);
            this.lb_Vendor.Location = new System.Drawing.Point(319, 163);
            this.lb_Vendor.Name = "lb_Vendor";
            this.lb_Vendor.Size = new System.Drawing.Size(72, 24);
            this.lb_Vendor.TabIndex = 15;
            this.lb_Vendor.Text = "تامین کننده:";
            this.lb_Vendor.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // combo_Vendor
            // 
            this.combo_Vendor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.combo_Vendor.Font = new System.Drawing.Font("IRANSansDNFaNum", 9.75F);
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
            this.combo_Vendor.Location = new System.Drawing.Point(15, 158);
            this.combo_Vendor.Name = "combo_Vendor";
            this.combo_Vendor.Size = new System.Drawing.Size(299, 31);
            this.combo_Vendor.TabIndex = 161;
            this.combo_Vendor.ThemeName = "TelerikMetro";
            this.combo_Vendor.TextChanged += new System.EventHandler(this.combo_Vendor_TextChanged);
            this.combo_Vendor.Enter += new System.EventHandler(this.combo_Vendor_Enter);
            this.combo_Vendor.Leave += new System.EventHandler(this.combo_Vendor_Leave);
            ((Telerik.WinControls.UI.RadDropDownListElement)(this.combo_Vendor.GetChildAt(0))).RightToLeft = true;
            ((Telerik.WinControls.UI.RadDropDownListElement)(this.combo_Vendor.GetChildAt(0))).Font = new System.Drawing.Font("IRANSansDNFaNum", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            ((Telerik.WinControls.UI.StackLayoutElement)(this.combo_Vendor.GetChildAt(0).GetChildAt(2))).Font = new System.Drawing.Font("IRANSansDNFaNum", 9.75F);
            ((Telerik.WinControls.UI.RadDropDownListElement)(this.combo_Vendor.GetChildAt(0).GetChildAt(3))).Font = new System.Drawing.Font("IRANSansDNFaNum", 9.75F);
            ((Telerik.WinControls.UI.RadDropDownListElement)(this.combo_Vendor.GetChildAt(0).GetChildAt(3))).Visibility = Telerik.WinControls.ElementVisibility.Hidden;
            // 
            // FrmWareHouse
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(390, 419);
            this.Controls.Add(this.combo_Vendor);
            this.Controls.Add(this.lb_Vendor);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.panel_WeightUnit);
            this.Controls.Add(this.ckb_Payed);
            this.Controls.Add(this.txt_WeightCount);
            this.Controls.Add(this.btn_Count);
            this.Controls.Add(this.btn_Weight);
            this.Controls.Add(this.txt_Expence);
            this.Controls.Add(this.lb_Expence);
            this.Controls.Add(this.txt_PurchDate);
            this.Controls.Add(this.txt_ExpDate);
            this.Controls.Add(this.lb_PurchDate);
            this.Controls.Add(this.lb_ExpDate);
            this.Controls.Add(this.txt_GoodsName);
            this.Controls.Add(this.lb_GoodsName);
            this.Font = new System.Drawing.Font("IRANSansDNFaNum", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmWareHouse";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "";
            this.ThemeName = "TelerikMetro";
            this.Load += new System.EventHandler(this.frm_WareHouse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lb_GoodsName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_GoodsName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lb_ExpDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lb_PurchDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ExpDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_PurchDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Expence)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lb_Expence)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Weight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Count)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_WeightCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Kgr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Gr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckb_Payed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_WeightUnit)).EndInit();
            this.panel_WeightUnit.ResumeLayout(false);
            this.panel_WeightUnit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Save)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lb_Vendor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.combo_Vendor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RadLabel lb_GoodsName;
        private RadMaskedEditBox txt_GoodsName;
        private RadLabel lb_ExpDate;
        private RadLabel lb_PurchDate;
        private RadDateTimePicker txt_ExpDate;
        private RadDateTimePicker txt_PurchDate;
        private RadMaskedEditBox txt_Expence;
        private RadLabel lb_Expence;
        private RadRadioButton btn_Weight;
        private RadRadioButton btn_Count;
        private RadMaskedEditBox txt_WeightCount;
        private RadRadioButton btn_Kgr;
        private RadRadioButton btn_Gr;
        private RadCheckBox ckb_Payed;
        private RadPanel panel_WeightUnit;
        private RadButton btn_Save;
        private RadDesktopAlert WareHouse_Alert;
        private RadLabel lb_Vendor;
        private RadDropDownList combo_Vendor;
    }
}