namespace HomeCafe.Setting
{
    partial class frm_AddTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_AddTable));
            this.lb_TableName = new Telerik.WinControls.UI.RadLabel();
            this.combo_TableName = new Telerik.WinControls.UI.RadDropDownList();
            this.lb_TableLocation = new Telerik.WinControls.UI.RadLabel();
            this.combo_LocationName = new Telerik.WinControls.UI.RadDropDownList();
            this.btn_Save = new Telerik.WinControls.UI.RadButton();
            this.Alert_AddTable = new Telerik.WinControls.UI.RadDesktopAlert(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.lb_TableName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.combo_TableName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lb_TableLocation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.combo_LocationName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Save)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_TableName
            // 
            this.lb_TableName.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lb_TableName.Location = new System.Drawing.Point(316, 14);
            this.lb_TableName.Name = "lb_TableName";
            this.lb_TableName.Size = new System.Drawing.Size(48, 30);
            this.lb_TableName.TabIndex = 4;
            this.lb_TableName.Text = "نام میز:";
            this.lb_TableName.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            this.lb_TableName.ThemeName = "TelerikMetro";
            // 
            // combo_TableName
            // 
            this.combo_TableName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.combo_TableName.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.combo_TableName.Location = new System.Drawing.Point(12, 12);
            this.combo_TableName.Name = "combo_TableName";
            this.combo_TableName.Size = new System.Drawing.Size(298, 37);
            this.combo_TableName.TabIndex = 3;
            this.combo_TableName.ThemeName = "TelerikMetro";
            this.combo_TableName.TextChanged += new System.EventHandler(this.combo_TableName_TextChanged);
            this.combo_TableName.Enter += new System.EventHandler(this.combo_TableName_Enter);
            this.combo_TableName.Leave += new System.EventHandler(this.combo_TableName_Leave);
            ((Telerik.WinControls.UI.RadDropDownListElement)(this.combo_TableName.GetChildAt(0))).RightToLeft = true;
            ((Telerik.WinControls.UI.RadDropDownListElement)(this.combo_TableName.GetChildAt(0))).Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            ((Telerik.WinControls.UI.RadDropDownListElement)(this.combo_TableName.GetChildAt(0).GetChildAt(3))).Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            ((Telerik.WinControls.UI.RadDropDownListElement)(this.combo_TableName.GetChildAt(0).GetChildAt(3))).Visibility = Telerik.WinControls.ElementVisibility.Hidden;
            // 
            // lb_TableLocation
            // 
            this.lb_TableLocation.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lb_TableLocation.Location = new System.Drawing.Point(316, 57);
            this.lb_TableLocation.Name = "lb_TableLocation";
            this.lb_TableLocation.Size = new System.Drawing.Size(58, 30);
            this.lb_TableLocation.TabIndex = 10;
            this.lb_TableLocation.Text = " محل میز:";
            this.lb_TableLocation.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            this.lb_TableLocation.ThemeName = "TelerikMetro";
            // 
            // combo_LocationName
            // 
            this.combo_LocationName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.combo_LocationName.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.combo_LocationName.Location = new System.Drawing.Point(12, 55);
            this.combo_LocationName.Name = "combo_LocationName";
            this.combo_LocationName.Size = new System.Drawing.Size(298, 37);
            this.combo_LocationName.TabIndex = 9;
            this.combo_LocationName.ThemeName = "TelerikMetro";
            this.combo_LocationName.TextChanged += new System.EventHandler(this.combo_LocationName_TextChanged);
            this.combo_LocationName.Enter += new System.EventHandler(this.combo_LocationName_Enter);
            this.combo_LocationName.Leave += new System.EventHandler(this.combo_LocationName_Leave);
            ((Telerik.WinControls.UI.RadDropDownListElement)(this.combo_LocationName.GetChildAt(0))).RightToLeft = true;
            ((Telerik.WinControls.UI.RadDropDownListElement)(this.combo_LocationName.GetChildAt(0))).Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            ((Telerik.WinControls.UI.RadDropDownListElement)(this.combo_LocationName.GetChildAt(0).GetChildAt(3))).Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            ((Telerik.WinControls.UI.RadDropDownListElement)(this.combo_LocationName.GetChildAt(0).GetChildAt(3))).Visibility = Telerik.WinControls.ElementVisibility.Hidden;
            // 
            // btn_Save
            // 
            this.btn_Save.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_Save.Location = new System.Drawing.Point(12, 98);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(110, 38);
            this.btn_Save.TabIndex = 8;
            this.btn_Save.Text = "ثبت";
            this.btn_Save.ThemeName = "TelerikMetro";
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // Alert_AddTable
            // 
            this.Alert_AddTable.CanMove = false;
            this.Alert_AddTable.ContentImage = global::HomeCafe.Properties.Resources.success_Alert;
            this.Alert_AddTable.Opacity = 1F;
            this.Alert_AddTable.ThemeName = "TelerikMetro";
            // 
            // frm_AddTable
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(373, 141);
            this.Controls.Add(this.lb_TableLocation);
            this.Controls.Add(this.combo_LocationName);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.lb_TableName);
            this.Controls.Add(this.combo_TableName);
            this.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_AddTable";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "";
            this.ThemeName = "TelerikMetro";
            this.Load += new System.EventHandler(this.frm_AddTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lb_TableName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.combo_TableName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lb_TableLocation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.combo_LocationName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Save)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadLabel lb_TableName;
        private Telerik.WinControls.UI.RadDropDownList combo_TableName;
        private Telerik.WinControls.UI.RadButton btn_Save;
        private Telerik.WinControls.UI.RadDesktopAlert Alert_AddTable;
        private Telerik.WinControls.UI.RadLabel lb_TableLocation;
        private Telerik.WinControls.UI.RadDropDownList combo_LocationName;
    }
}