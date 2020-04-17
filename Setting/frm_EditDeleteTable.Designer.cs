namespace HomeCafe.Setting
{
    partial class frm_EditDeleteTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_EditDeleteTable));
            this.lb_TableLocation = new Telerik.WinControls.UI.RadLabel();
            this.combo_LocationName = new Telerik.WinControls.UI.RadDropDownList();
            this.btn_Delete = new Telerik.WinControls.UI.RadButton();
            this.btn_Edit = new Telerik.WinControls.UI.RadButton();
            this.lb_TableName = new Telerik.WinControls.UI.RadLabel();
            this.combo_TableName = new Telerik.WinControls.UI.RadDropDownList();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.combo_TableNewName = new Telerik.WinControls.UI.RadDropDownList();
            this.Alert_EditDeleteTable = new Telerik.WinControls.UI.RadDesktopAlert(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.lb_TableLocation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.combo_LocationName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Delete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lb_TableName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.combo_TableName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.combo_TableNewName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_TableLocation
            // 
            this.lb_TableLocation.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lb_TableLocation.Location = new System.Drawing.Point(316, 14);
            this.lb_TableLocation.Name = "lb_TableLocation";
            this.lb_TableLocation.Size = new System.Drawing.Size(58, 30);
            this.lb_TableLocation.TabIndex = 15;
            this.lb_TableLocation.Text = " محل میز:";
            this.lb_TableLocation.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            this.lb_TableLocation.ThemeName = "TelerikMetro";
            // 
            // combo_LocationName
            // 
            this.combo_LocationName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.combo_LocationName.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.combo_LocationName.Location = new System.Drawing.Point(12, 12);
            this.combo_LocationName.Name = "combo_LocationName";
            this.combo_LocationName.Size = new System.Drawing.Size(298, 37);
            this.combo_LocationName.TabIndex = 14;
            this.combo_LocationName.ThemeName = "TelerikMetro";
            this.combo_LocationName.TextChanged += new System.EventHandler(this.combo_LocationName_TextChanged);
            this.combo_LocationName.Enter += new System.EventHandler(this.combo_LocationName_Enter);
            this.combo_LocationName.Leave += new System.EventHandler(this.combo_LocationName_Leave);
            ((Telerik.WinControls.UI.RadDropDownListElement)(this.combo_LocationName.GetChildAt(0))).RightToLeft = true;
            ((Telerik.WinControls.UI.RadDropDownListElement)(this.combo_LocationName.GetChildAt(0))).Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            ((Telerik.WinControls.UI.RadDropDownListElement)(this.combo_LocationName.GetChildAt(0).GetChildAt(3))).Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            ((Telerik.WinControls.UI.RadDropDownListElement)(this.combo_LocationName.GetChildAt(0).GetChildAt(3))).Visibility = Telerik.WinControls.ElementVisibility.Hidden;
            // 
            // btn_Delete
            // 
            this.btn_Delete.Enabled = false;
            this.btn_Delete.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_Delete.Location = new System.Drawing.Point(12, 144);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(110, 38);
            this.btn_Delete.TabIndex = 13;
            this.btn_Delete.Text = "حذف";
            this.btn_Delete.ThemeName = "TelerikMetro";
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Enabled = false;
            this.btn_Edit.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_Edit.Location = new System.Drawing.Point(128, 144);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(110, 38);
            this.btn_Edit.TabIndex = 16;
            this.btn_Edit.Text = "اصلاح";
            this.btn_Edit.ThemeName = "TelerikMetro";
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // lb_TableName
            // 
            this.lb_TableName.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lb_TableName.Location = new System.Drawing.Point(316, 57);
            this.lb_TableName.Name = "lb_TableName";
            this.lb_TableName.Size = new System.Drawing.Size(48, 30);
            this.lb_TableName.TabIndex = 18;
            this.lb_TableName.Text = "نام میز:";
            this.lb_TableName.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            this.lb_TableName.ThemeName = "TelerikMetro";
            // 
            // combo_TableName
            // 
            this.combo_TableName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.combo_TableName.Enabled = false;
            this.combo_TableName.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.combo_TableName.Location = new System.Drawing.Point(12, 55);
            this.combo_TableName.Name = "combo_TableName";
            this.combo_TableName.Size = new System.Drawing.Size(298, 37);
            this.combo_TableName.TabIndex = 17;
            this.combo_TableName.ThemeName = "TelerikMetro";
            this.combo_TableName.TextChanged += new System.EventHandler(this.combo_TableName_TextChanged);
            this.combo_TableName.Enter += new System.EventHandler(this.combo_TableName_Enter);
            this.combo_TableName.Leave += new System.EventHandler(this.combo_TableName_Leave);
            ((Telerik.WinControls.UI.RadDropDownListElement)(this.combo_TableName.GetChildAt(0))).RightToLeft = true;
            ((Telerik.WinControls.UI.RadDropDownListElement)(this.combo_TableName.GetChildAt(0))).Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            ((Telerik.WinControls.UI.RadDropDownListElement)(this.combo_TableName.GetChildAt(0).GetChildAt(3))).Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            ((Telerik.WinControls.UI.RadDropDownListElement)(this.combo_TableName.GetChildAt(0).GetChildAt(3))).Visibility = Telerik.WinControls.ElementVisibility.Hidden;
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.radLabel1.Location = new System.Drawing.Point(316, 100);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(74, 30);
            this.radLabel1.TabIndex = 20;
            this.radLabel1.Text = "نام جدید میز:";
            this.radLabel1.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            this.radLabel1.ThemeName = "TelerikMetro";
            // 
            // combo_TableNewName
            // 
            this.combo_TableNewName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.combo_TableNewName.Enabled = false;
            this.combo_TableNewName.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.combo_TableNewName.Location = new System.Drawing.Point(12, 98);
            this.combo_TableNewName.Name = "combo_TableNewName";
            this.combo_TableNewName.Size = new System.Drawing.Size(298, 37);
            this.combo_TableNewName.TabIndex = 19;
            this.combo_TableNewName.ThemeName = "TelerikMetro";
            this.combo_TableNewName.TextChanged += new System.EventHandler(this.combo_TableNewName_TextChanged);
            this.combo_TableNewName.Enter += new System.EventHandler(this.combo_TableNewName_Enter);
            this.combo_TableNewName.Leave += new System.EventHandler(this.combo_TableNewName_Leave);
            ((Telerik.WinControls.UI.RadDropDownListElement)(this.combo_TableNewName.GetChildAt(0))).RightToLeft = true;
            ((Telerik.WinControls.UI.RadDropDownListElement)(this.combo_TableNewName.GetChildAt(0))).Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            ((Telerik.WinControls.UI.RadDropDownListElement)(this.combo_TableNewName.GetChildAt(0).GetChildAt(3))).Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            ((Telerik.WinControls.UI.RadDropDownListElement)(this.combo_TableNewName.GetChildAt(0).GetChildAt(3))).Visibility = Telerik.WinControls.ElementVisibility.Hidden;
            // 
            // Alert_EditDeleteTable
            // 
            this.Alert_EditDeleteTable.CanMove = false;
            this.Alert_EditDeleteTable.ContentImage = global::HomeCafe.Properties.Resources.success_Alert;
            this.Alert_EditDeleteTable.ThemeName = "TelerikMetro";
            // 
            // frm_EditDeleteTable
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(386, 199);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.combo_TableNewName);
            this.Controls.Add(this.lb_TableName);
            this.Controls.Add(this.combo_TableName);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.lb_TableLocation);
            this.Controls.Add(this.combo_LocationName);
            this.Controls.Add(this.btn_Delete);
            this.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_EditDeleteTable";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "";
            this.ThemeName = "TelerikMetro";
            this.Load += new System.EventHandler(this.frm_EditDeleteTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lb_TableLocation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.combo_LocationName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Delete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lb_TableName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.combo_TableName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.combo_TableNewName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadLabel lb_TableLocation;
        private Telerik.WinControls.UI.RadDropDownList combo_LocationName;
        private Telerik.WinControls.UI.RadButton btn_Delete;
        private Telerik.WinControls.UI.RadButton btn_Edit;
        private Telerik.WinControls.UI.RadLabel lb_TableName;
        private Telerik.WinControls.UI.RadDropDownList combo_TableName;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadDropDownList combo_TableNewName;
        private Telerik.WinControls.UI.RadDesktopAlert Alert_EditDeleteTable;
    }
}