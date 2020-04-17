namespace HomeCafe.Setting
{
    partial class frm_EditDeleteCatagories
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_EditDeleteCatagories));
            this.EditCatagories_Alert = new Telerik.WinControls.UI.RadDesktopAlert(this.components);
            this.lb_Catagories = new Telerik.WinControls.UI.RadLabel();
            this.combo_Catagories = new Telerik.WinControls.UI.RadDropDownList();
            this.btn_Edit = new Telerik.WinControls.UI.RadButton();
            this.lb_NewCatagories = new Telerik.WinControls.UI.RadLabel();
            this.txt_EditCatagories = new Telerik.WinControls.UI.RadMaskedEditBox();
            this.btn_Delete = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.lb_Catagories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.combo_Catagories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lb_NewCatagories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_EditCatagories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Delete)).BeginInit();
            this.SuspendLayout();
            // 
            // EditCatagories_Alert
            // 
            this.EditCatagories_Alert.CanMove = false;
            this.EditCatagories_Alert.ContentImage = global::HomeCafe.Properties.Resources.success_Alert;
            this.EditCatagories_Alert.Opacity = 1F;
            this.EditCatagories_Alert.ThemeName = "TelerikMetro";
            // 
            // lb_Catagories
            // 
            this.lb_Catagories.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lb_Catagories.Location = new System.Drawing.Point(342, 22);
            this.lb_Catagories.Name = "lb_Catagories";
            this.lb_Catagories.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lb_Catagories.Size = new System.Drawing.Size(61, 30);
            this.lb_Catagories.TabIndex = 0;
            this.lb_Catagories.Text = "نام دسته :";
            this.lb_Catagories.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // combo_Catagories
            // 
            this.combo_Catagories.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.combo_Catagories.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.combo_Catagories.Location = new System.Drawing.Point(28, 22);
            this.combo_Catagories.Name = "combo_Catagories";
            this.combo_Catagories.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.combo_Catagories.Size = new System.Drawing.Size(282, 35);
            this.combo_Catagories.TabIndex = 1;
            this.combo_Catagories.Text = "نام دسته مورد نظر برای اصلاح / حذف را وارد کنید";
            this.combo_Catagories.ThemeName = "TelerikMetro";
            this.combo_Catagories.TextChanged += new System.EventHandler(this.combo_Catagories_TextChanged);
            this.combo_Catagories.Enter += new System.EventHandler(this.combo_Catagories_Enter);
            this.combo_Catagories.Leave += new System.EventHandler(this.combo_Catagories_Leave);
            ((Telerik.WinControls.UI.RadDropDownListElement)(this.combo_Catagories.GetChildAt(0))).RightToLeft = true;
            ((Telerik.WinControls.UI.RadDropDownListElement)(this.combo_Catagories.GetChildAt(0))).Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            // 
            // btn_Edit
            // 
            this.btn_Edit.Enabled = false;
            this.btn_Edit.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_Edit.Location = new System.Drawing.Point(13, 123);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(115, 36);
            this.btn_Edit.TabIndex = 2;
            this.btn_Edit.Text = "اصلاح";
            this.btn_Edit.ThemeName = "TelerikMetro";
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // lb_NewCatagories
            // 
            this.lb_NewCatagories.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lb_NewCatagories.Location = new System.Drawing.Point(316, 73);
            this.lb_NewCatagories.Name = "lb_NewCatagories";
            this.lb_NewCatagories.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lb_NewCatagories.Size = new System.Drawing.Size(87, 30);
            this.lb_NewCatagories.TabIndex = 3;
            this.lb_NewCatagories.Text = "نام دسته جدید :";
            this.lb_NewCatagories.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // txt_EditCatagories
            // 
            this.txt_EditCatagories.Enabled = false;
            this.txt_EditCatagories.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_EditCatagories.Location = new System.Drawing.Point(28, 73);
            this.txt_EditCatagories.Name = "txt_EditCatagories";
            this.txt_EditCatagories.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_EditCatagories.Size = new System.Drawing.Size(281, 35);
            this.txt_EditCatagories.TabIndex = 4;
            this.txt_EditCatagories.TabStop = false;
            this.txt_EditCatagories.ThemeName = "TelerikMetro";
            this.txt_EditCatagories.TextChanged += new System.EventHandler(this.txt_EditCatagories_TextChanged);
            this.txt_EditCatagories.Enter += new System.EventHandler(this.txt_EditCatagories_Enter);
            this.txt_EditCatagories.Leave += new System.EventHandler(this.txt_EditCatagories_Leave);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Enabled = false;
            this.btn_Delete.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_Delete.Location = new System.Drawing.Point(134, 123);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(115, 36);
            this.btn_Delete.TabIndex = 5;
            this.btn_Delete.Text = "حذف";
            this.btn_Delete.ThemeName = "TelerikMetro";
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // frm_EditDeleteCatagories
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(415, 171);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.txt_EditCatagories);
            this.Controls.Add(this.lb_NewCatagories);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.combo_Catagories);
            this.Controls.Add(this.lb_Catagories);
            this.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_EditDeleteCatagories";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frm_EditCatagories_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lb_Catagories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.combo_Catagories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lb_NewCatagories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_EditCatagories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Delete)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadDesktopAlert EditCatagories_Alert;
        private Telerik.WinControls.UI.RadLabel lb_Catagories;
        private Telerik.WinControls.UI.RadDropDownList combo_Catagories;
        private Telerik.WinControls.UI.RadButton btn_Edit;
        private Telerik.WinControls.UI.RadLabel lb_NewCatagories;
        private Telerik.WinControls.UI.RadMaskedEditBox txt_EditCatagories;
        private Telerik.WinControls.UI.RadButton btn_Delete;
    }
}