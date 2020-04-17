namespace HomeCafe.Setting
{
    partial class frm_CreateBackUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_CreateBackUp));
            this.lb_BackUpName = new System.Windows.Forms.Label();
            this.Alert_CreateBackUp = new Telerik.WinControls.UI.RadDesktopAlert(this.components);
            this.btn_Create = new Telerik.WinControls.UI.RadButton();
            this.txt_BackUp = new Telerik.WinControls.UI.RadMaskedEditBox();
            this.object_694ec977_6e46_4cf8_8a94_5d47f4dbae62 = new Telerik.WinControls.RootRadElement();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Create)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_BackUp)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_BackUpName
            // 
            this.lb_BackUpName.AutoSize = true;
            this.lb_BackUpName.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lb_BackUpName.Location = new System.Drawing.Point(302, 14);
            this.lb_BackUpName.Name = "lb_BackUpName";
            this.lb_BackUpName.Size = new System.Drawing.Size(158, 26);
            this.lb_BackUpName.TabIndex = 4;
            this.lb_BackUpName.Text = "نام فایل پشتیبان را وارد کنید:";
            // 
            // Alert_CreateBackUp
            // 
            this.Alert_CreateBackUp.ContentImage = global::HomeCafe.Properties.Resources.success_Alert;
            this.Alert_CreateBackUp.ThemeName = "TelerikMetro";
            // 
            // btn_Create
            // 
            this.btn_Create.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_Create.Location = new System.Drawing.Point(12, 55);
            this.btn_Create.Name = "btn_Create";
            this.btn_Create.Size = new System.Drawing.Size(110, 38);
            this.btn_Create.TabIndex = 8;
            this.btn_Create.Text = "ساخت پشتیبان";
            this.btn_Create.ThemeName = "TelerikMetro";
            this.btn_Create.Click += new System.EventHandler(this.btn_Create_Click);
            // 
            // txt_BackUp
            // 
            this.txt_BackUp.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_BackUp.Location = new System.Drawing.Point(12, 14);
            this.txt_BackUp.Name = "txt_BackUp";
            this.txt_BackUp.Size = new System.Drawing.Size(284, 35);
            this.txt_BackUp.TabIndex = 1;
            this.txt_BackUp.TabStop = false;
            this.txt_BackUp.ThemeName = "TelerikMetro";
            this.txt_BackUp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_BackUp_KeyPress);
            this.txt_BackUp.TextChanged += new System.EventHandler(this.txt_BackUp_TextChanged);
            this.txt_BackUp.Enter += new System.EventHandler(this.txt_BackUp_Enter);
            this.txt_BackUp.Leave += new System.EventHandler(this.txt_BackUp_Leave);
            // 
            // object_694ec977_6e46_4cf8_8a94_5d47f4dbae62
            // 
            this.object_694ec977_6e46_4cf8_8a94_5d47f4dbae62.Name = "object_694ec977_6e46_4cf8_8a94_5d47f4dbae62";
            this.object_694ec977_6e46_4cf8_8a94_5d47f4dbae62.StretchHorizontally = true;
            this.object_694ec977_6e46_4cf8_8a94_5d47f4dbae62.StretchVertically = true;
            // 
            // frm_CreateBackUp
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(458, 105);
            this.Controls.Add(this.txt_BackUp);
            this.Controls.Add(this.btn_Create);
            this.Controls.Add(this.lb_BackUpName);
            this.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_CreateBackUp";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frm_CreateBackUp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btn_Create)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_BackUp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_BackUpName;
        private Telerik.WinControls.UI.RadDesktopAlert Alert_CreateBackUp;
        private Telerik.WinControls.UI.RadButton btn_Create;
        private Telerik.WinControls.UI.RadMaskedEditBox txt_BackUp;
        private Telerik.WinControls.RootRadElement object_694ec977_6e46_4cf8_8a94_5d47f4dbae62;
    }
}