namespace HomeCafe.Index_and_Login
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.btn_exit1 = new Telerik.WinControls.UI.RadButton();
            this.telerikMetroTheme1 = new Telerik.WinControls.Themes.TelerikMetroTheme();
            this.btn_enter1 = new Telerik.WinControls.UI.RadButton();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.lb_password = new System.Windows.Forms.Label();
            this.lb_username = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.telerikMetroTheme2 = new Telerik.WinControls.Themes.TelerikMetroTheme();
            ((System.ComponentModel.ISupportInitialize)(this.btn_exit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_enter1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_exit1
            // 
            this.btn_exit1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.btn_exit1, "btn_exit1");
            this.btn_exit1.Name = "btn_exit1";
            this.btn_exit1.ThemeName = "TelerikMetro";
            this.btn_exit1.Click += new System.EventHandler(this.btn_exit1_Click);
            // 
            // btn_enter1
            // 
            resources.ApplyResources(this.btn_enter1, "btn_enter1");
            this.btn_enter1.Name = "btn_enter1";
            this.btn_enter1.ThemeName = "TelerikMetro";
            this.btn_enter1.Click += new System.EventHandler(this.btn_enter1_Click);
            // 
            // txt_password
            // 
            this.txt_password.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.txt_password, "txt_password");
            this.txt_password.ForeColor = System.Drawing.Color.Black;
            this.txt_password.Name = "txt_password";
            this.txt_password.UseSystemPasswordChar = true;
            this.txt_password.TextChanged += new System.EventHandler(this.txt_password_TextChanged);
            this.txt_password.Enter += new System.EventHandler(this.txt_password_Enter);
            this.txt_password.Leave += new System.EventHandler(this.txt_password_Leave);
            // 
            // txt_username
            // 
            resources.ApplyResources(this.txt_username, "txt_username");
            this.txt_username.Name = "txt_username";
            this.txt_username.TextChanged += new System.EventHandler(this.txt_username_TextChanged);
            this.txt_username.Enter += new System.EventHandler(this.txt_username_Enter);
            this.txt_username.Leave += new System.EventHandler(this.txt_username_Leave);
            // 
            // lb_password
            // 
            resources.ApplyResources(this.lb_password, "lb_password");
            this.lb_password.Name = "lb_password";
            // 
            // lb_username
            // 
            resources.ApplyResources(this.lb_username, "lb_username");
            this.lb_username.Name = "lb_username";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::HomeCafe.Properties.Resources.WhatsApp_Image_2019_06_07_at_14_31_54;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // FrmLogin
            // 
            this.AcceptButton = this.btn_enter1;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.CancelButton = this.btn_exit1;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.btn_exit1);
            this.Controls.Add(this.btn_enter1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.lb_password);
            this.Controls.Add(this.lb_username);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmLogin";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ThemeName = "TelerikMetro";
            this.Load += new System.EventHandler(this.frm_login_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.btn_exit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_enter1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadButton btn_exit1;
        private Telerik.WinControls.Themes.TelerikMetroTheme telerikMetroTheme1;
        private Telerik.WinControls.UI.RadButton btn_enter1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Label lb_password;
        private System.Windows.Forms.Label lb_username;
        private Telerik.WinControls.Themes.TelerikMetroTheme telerikMetroTheme2;
    }
}
