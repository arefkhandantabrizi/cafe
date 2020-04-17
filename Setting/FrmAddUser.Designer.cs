namespace HomeCafe.Setting
{
    partial class FrmAddUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddUser));
            this.lb_UserName = new Telerik.WinControls.UI.RadLabel();
            this.combo_UserName = new Telerik.WinControls.UI.RadDropDownList();
            this.lb_PassWord = new Telerik.WinControls.UI.RadLabel();
            this.Alert_AddUser = new Telerik.WinControls.UI.RadDesktopAlert(this.components);
            this.ckb_PasswordShow = new Telerik.WinControls.UI.RadCheckBox();
            this.btn_Save = new Telerik.WinControls.UI.RadButton();
            this.txt_PassWord = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.lb_UserName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.combo_UserName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lb_PassWord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckb_PasswordShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Save)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_UserName
            // 
            this.lb_UserName.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lb_UserName.Location = new System.Drawing.Point(318, 24);
            this.lb_UserName.Name = "lb_UserName";
            this.lb_UserName.Size = new System.Drawing.Size(67, 30);
            this.lb_UserName.TabIndex = 15;
            this.lb_UserName.Text = "نام کاربری:";
            this.lb_UserName.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            this.lb_UserName.ThemeName = "TelerikMetro";
            // 
            // combo_UserName
            // 
            this.combo_UserName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.combo_UserName.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.combo_UserName.Location = new System.Drawing.Point(5, 22);
            this.combo_UserName.Name = "combo_UserName";
            this.combo_UserName.Size = new System.Drawing.Size(307, 35);
            this.combo_UserName.TabIndex = 0;
            this.combo_UserName.ThemeName = "TelerikMetro";
            this.combo_UserName.TextChanged += new System.EventHandler(this.combo_UserName_TextChanged);
            this.combo_UserName.Enter += new System.EventHandler(this.combo_UserName_Enter);
            this.combo_UserName.Leave += new System.EventHandler(this.combo_UserName_Leave);
            ((Telerik.WinControls.UI.RadDropDownListElement)(this.combo_UserName.GetChildAt(0))).RightToLeft = true;
            ((Telerik.WinControls.UI.RadDropDownListElement)(this.combo_UserName.GetChildAt(0))).Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            // 
            // lb_PassWord
            // 
            this.lb_PassWord.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lb_PassWord.Location = new System.Drawing.Point(318, 68);
            this.lb_PassWord.Name = "lb_PassWord";
            this.lb_PassWord.Size = new System.Drawing.Size(56, 30);
            this.lb_PassWord.TabIndex = 16;
            this.lb_PassWord.Text = "رمز عبور:";
            this.lb_PassWord.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            this.lb_PassWord.ThemeName = "TelerikMetro";
            // 
            // Alert_AddUser
            // 
            this.Alert_AddUser.CanMove = false;
            this.Alert_AddUser.ContentImage = global::HomeCafe.Properties.Resources.success_Alert;
            this.Alert_AddUser.Opacity = 1F;
            this.Alert_AddUser.ThemeName = "TelerikMetro";
            // 
            // ckb_PasswordShow
            // 
            this.ckb_PasswordShow.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ckb_PasswordShow.Location = new System.Drawing.Point(5, 109);
            this.ckb_PasswordShow.Name = "ckb_PasswordShow";
            this.ckb_PasswordShow.Size = new System.Drawing.Size(109, 30);
            this.ckb_PasswordShow.TabIndex = 2;
            this.ckb_PasswordShow.Text = "نمایش رمز عبور";
            this.ckb_PasswordShow.ThemeName = "TelerikMetro";
            this.ckb_PasswordShow.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.ckb_PasswordShow_ToggleStateChanged);
            // 
            // btn_Save
            // 
            this.btn_Save.Enabled = false;
            this.btn_Save.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_Save.Location = new System.Drawing.Point(12, 156);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(110, 38);
            this.btn_Save.TabIndex = 3;
            this.btn_Save.Text = "ثبت";
            this.btn_Save.ThemeName = "TelerikMetro";
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // txt_PassWord
            // 
            this.txt_PassWord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txt_PassWord.Cursor = System.Windows.Forms.Cursors.Default;
            this.txt_PassWord.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold);
            this.txt_PassWord.ForeColor = System.Drawing.Color.Black;
            this.txt_PassWord.Location = new System.Drawing.Point(5, 68);
            this.txt_PassWord.Name = "txt_PassWord";
            this.txt_PassWord.Size = new System.Drawing.Size(307, 34);
            this.txt_PassWord.TabIndex = 1;
            this.txt_PassWord.UseSystemPasswordChar = true;
            this.txt_PassWord.TextChanged += new System.EventHandler(this.txt_PassWord_TextChanged);
            this.txt_PassWord.Enter += new System.EventHandler(this.txt_PassWord_Enter);
            this.txt_PassWord.Leave += new System.EventHandler(this.txt_PassWord_Leave);
            // 
            // FrmAddUser
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(387, 202);
            this.Controls.Add(this.txt_PassWord);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.ckb_PasswordShow);
            this.Controls.Add(this.lb_PassWord);
            this.Controls.Add(this.lb_UserName);
            this.Controls.Add(this.combo_UserName);
            this.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAddUser";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frm_AddUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lb_UserName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.combo_UserName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lb_PassWord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckb_PasswordShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Save)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadLabel lb_UserName;
        private Telerik.WinControls.UI.RadDropDownList combo_UserName;
        private Telerik.WinControls.UI.RadLabel lb_PassWord;
        private Telerik.WinControls.UI.RadDesktopAlert Alert_AddUser;
        private Telerik.WinControls.UI.RadCheckBox ckb_PasswordShow;
        private Telerik.WinControls.UI.RadButton btn_Save;
        private System.Windows.Forms.TextBox txt_PassWord;
    }
}