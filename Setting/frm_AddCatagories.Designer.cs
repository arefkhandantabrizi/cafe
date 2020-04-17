namespace HomeCafe.Setting
{
    partial class frm_AddCatagories
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_AddCatagories));
            this.lb_Catagories = new Telerik.WinControls.UI.RadLabel();
            this.txt_Catagories = new Telerik.WinControls.UI.RadMaskedEditBox();
            this.btn_Save = new Telerik.WinControls.UI.RadButton();
            this.AddCatagories_Alert = new Telerik.WinControls.UI.RadDesktopAlert(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.lb_Catagories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Catagories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Save)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_Catagories
            // 
            this.lb_Catagories.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lb_Catagories.Location = new System.Drawing.Point(328, 30);
            this.lb_Catagories.Name = "lb_Catagories";
            this.lb_Catagories.Size = new System.Drawing.Size(61, 30);
            this.lb_Catagories.TabIndex = 0;
            this.lb_Catagories.Text = "نام دسته: ";
            this.lb_Catagories.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // txt_Catagories
            // 
            this.txt_Catagories.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_Catagories.Location = new System.Drawing.Point(13, 27);
            this.txt_Catagories.Name = "txt_Catagories";
            this.txt_Catagories.Size = new System.Drawing.Size(309, 35);
            this.txt_Catagories.TabIndex = 1;
            this.txt_Catagories.TabStop = false;
            this.txt_Catagories.ThemeName = "TelerikMetro";
            this.txt_Catagories.TextChanged += new System.EventHandler(this.txt_Catagories_TextChanged);
            this.txt_Catagories.Enter += new System.EventHandler(this.txt_Catagories_Enter);
            this.txt_Catagories.Leave += new System.EventHandler(this.txt_Catagories_Leave);
            // 
            // btn_Save
            // 
            this.btn_Save.Enabled = false;
            this.btn_Save.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_Save.Location = new System.Drawing.Point(13, 94);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(110, 38);
            this.btn_Save.TabIndex = 2;
            this.btn_Save.Text = "ثبت";
            this.btn_Save.ThemeName = "TelerikMetro";
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // AddCatagories_Alert
            // 
            this.AddCatagories_Alert.ContentImage = global::HomeCafe.Properties.Resources.success_Alert;
            this.AddCatagories_Alert.ThemeName = "TelerikMetro";
            // 
            // frm_AddCatagories
            // 
            this.AcceptButton = this.btn_Save;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(401, 144);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.txt_Catagories);
            this.Controls.Add(this.lb_Catagories);
            this.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_AddCatagories";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ThemeName = "TelerikMetro";
            this.Load += new System.EventHandler(this.frm_AddCatagories_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lb_Catagories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Catagories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Save)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadLabel lb_Catagories;
        private Telerik.WinControls.UI.RadMaskedEditBox txt_Catagories;
        private Telerik.WinControls.UI.RadButton btn_Save;
        private Telerik.WinControls.UI.RadDesktopAlert AddCatagories_Alert;
    }
}