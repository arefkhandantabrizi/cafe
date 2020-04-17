namespace HomeCafe.Setting
{
    partial class frm_EditDeleteUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_EditDeleteUser));
            this.txt_PassWord = new System.Windows.Forms.TextBox();
            this.btn_Delete = new Telerik.WinControls.UI.RadButton();
            this.ckb_PasswordShow = new Telerik.WinControls.UI.RadCheckBox();
            this.lb_PassWord = new Telerik.WinControls.UI.RadLabel();
            this.lb_UserName = new Telerik.WinControls.UI.RadLabel();
            this.combo_UserName = new Telerik.WinControls.UI.RadDropDownList();
            this.btn_Edit = new Telerik.WinControls.UI.RadButton();
            this.lb_OldUserName = new Telerik.WinControls.UI.RadLabel();
            this.combo_OldUserName = new Telerik.WinControls.UI.RadDropDownList();
            this.Alert_EditDeletUser = new Telerik.WinControls.UI.RadDesktopAlert(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.btn_Delete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckb_PasswordShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lb_PassWord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lb_UserName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.combo_UserName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lb_OldUserName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.combo_OldUserName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_PassWord
            // 
            this.txt_PassWord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txt_PassWord.Cursor = System.Windows.Forms.Cursors.Default;
            this.txt_PassWord.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold);
            this.txt_PassWord.ForeColor = System.Drawing.Color.Black;
            this.txt_PassWord.Location = new System.Drawing.Point(8, 109);
            this.txt_PassWord.Name = "txt_PassWord";
            this.txt_PassWord.Size = new System.Drawing.Size(307, 34);
            this.txt_PassWord.TabIndex = 18;
            this.txt_PassWord.UseSystemPasswordChar = true;
            this.txt_PassWord.TextChanged += new System.EventHandler(this.txt_PassWord_TextChanged);
            this.txt_PassWord.Enter += new System.EventHandler(this.txt_PassWord_Enter);
            this.txt_PassWord.Leave += new System.EventHandler(this.txt_PassWord_Leave);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Enabled = false;
            this.btn_Delete.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_Delete.Location = new System.Drawing.Point(12, 200);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(110, 38);
            this.btn_Delete.TabIndex = 20;
            this.btn_Delete.Text = "حذف";
            this.btn_Delete.ThemeName = "TelerikMetro";
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // ckb_PasswordShow
            // 
            this.ckb_PasswordShow.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ckb_PasswordShow.Location = new System.Drawing.Point(8, 150);
            this.ckb_PasswordShow.Name = "ckb_PasswordShow";
            this.ckb_PasswordShow.Size = new System.Drawing.Size(109, 30);
            this.ckb_PasswordShow.TabIndex = 19;
            this.ckb_PasswordShow.Text = "نمایش رمز عبور";
            this.ckb_PasswordShow.ThemeName = "TelerikMetro";
            this.ckb_PasswordShow.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.ckb_PasswordShow_ToggleStateChanged);
            // 
            // lb_PassWord
            // 
            this.lb_PassWord.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lb_PassWord.Location = new System.Drawing.Point(321, 109);
            this.lb_PassWord.Name = "lb_PassWord";
            this.lb_PassWord.Size = new System.Drawing.Size(56, 30);
            this.lb_PassWord.TabIndex = 22;
            this.lb_PassWord.Text = "رمز عبور:";
            this.lb_PassWord.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            this.lb_PassWord.ThemeName = "TelerikMetro";
            // 
            // lb_UserName
            // 
            this.lb_UserName.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lb_UserName.Location = new System.Drawing.Point(321, 65);
            this.lb_UserName.Name = "lb_UserName";
            this.lb_UserName.Size = new System.Drawing.Size(93, 30);
            this.lb_UserName.TabIndex = 21;
            this.lb_UserName.Text = "نام کاربری جدید:";
            this.lb_UserName.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            this.lb_UserName.ThemeName = "TelerikMetro";
            // 
            // combo_UserName
            // 
            this.combo_UserName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.combo_UserName.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.combo_UserName.Location = new System.Drawing.Point(8, 63);
            this.combo_UserName.Name = "combo_UserName";
            this.combo_UserName.Size = new System.Drawing.Size(307, 35);
            this.combo_UserName.TabIndex = 17;
            this.combo_UserName.ThemeName = "TelerikMetro";
            this.combo_UserName.TextChanged += new System.EventHandler(this.combo_UserName_TextChanged);
            this.combo_UserName.Enter += new System.EventHandler(this.combo_UserName_Enter);
            this.combo_UserName.Leave += new System.EventHandler(this.combo_UserName_Leave);
            ((Telerik.WinControls.UI.RadDropDownListElement)(this.combo_UserName.GetChildAt(0))).RightToLeft = true;
            ((Telerik.WinControls.UI.RadDropDownListElement)(this.combo_UserName.GetChildAt(0))).Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            // 
            // btn_Edit
            // 
            this.btn_Edit.Enabled = false;
            this.btn_Edit.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_Edit.Location = new System.Drawing.Point(128, 200);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(110, 38);
            this.btn_Edit.TabIndex = 23;
            this.btn_Edit.Text = "اصلاح";
            this.btn_Edit.ThemeName = "TelerikMetro";
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // lb_OldUserName
            // 
            this.lb_OldUserName.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lb_OldUserName.Location = new System.Drawing.Point(318, 14);
            this.lb_OldUserName.Name = "lb_OldUserName";
            this.lb_OldUserName.Size = new System.Drawing.Size(95, 30);
            this.lb_OldUserName.TabIndex = 25;
            this.lb_OldUserName.Text = "نام کاربری قبلی:";
            this.lb_OldUserName.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            this.lb_OldUserName.ThemeName = "TelerikMetro";
            // 
            // combo_OldUserName
            // 
            this.combo_OldUserName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.combo_OldUserName.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.combo_OldUserName.Location = new System.Drawing.Point(5, 12);
            this.combo_OldUserName.Name = "combo_OldUserName";
            this.combo_OldUserName.Size = new System.Drawing.Size(307, 35);
            this.combo_OldUserName.TabIndex = 24;
            this.combo_OldUserName.ThemeName = "TelerikMetro";
            this.combo_OldUserName.TextChanged += new System.EventHandler(this.combo_OldUserName_TextChanged);
            this.combo_OldUserName.Enter += new System.EventHandler(this.combo_OldUserName_Enter);
            this.combo_OldUserName.Leave += new System.EventHandler(this.combo_OldUserName_Leave);
            ((Telerik.WinControls.UI.RadDropDownListElement)(this.combo_OldUserName.GetChildAt(0))).RightToLeft = true;
            ((Telerik.WinControls.UI.RadDropDownListElement)(this.combo_OldUserName.GetChildAt(0))).Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            // 
            // Alert_EditDeletUser
            // 
            this.Alert_EditDeletUser.CanMove = false;
            this.Alert_EditDeletUser.ContentImage = global::HomeCafe.Properties.Resources.success_Alert;
            this.Alert_EditDeletUser.Opacity = 1F;
            this.Alert_EditDeletUser.ThemeName = "TelerikMetro";
            // 
            // frm_EditDeleteUser
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(415, 250);
            this.Controls.Add(this.lb_OldUserName);
            this.Controls.Add(this.combo_OldUserName);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.txt_PassWord);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.ckb_PasswordShow);
            this.Controls.Add(this.lb_PassWord);
            this.Controls.Add(this.lb_UserName);
            this.Controls.Add(this.combo_UserName);
            this.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_EditDeleteUser";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "";
            this.ThemeName = "TelerikMetro";
            this.Load += new System.EventHandler(this.frm_EditDeleteUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btn_Delete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckb_PasswordShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lb_PassWord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lb_UserName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.combo_UserName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lb_OldUserName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.combo_OldUserName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_PassWord;
        private Telerik.WinControls.UI.RadButton btn_Delete;
        private Telerik.WinControls.UI.RadCheckBox ckb_PasswordShow;
        private Telerik.WinControls.UI.RadLabel lb_PassWord;
        private Telerik.WinControls.UI.RadLabel lb_UserName;
        private Telerik.WinControls.UI.RadDropDownList combo_UserName;
        private Telerik.WinControls.UI.RadButton btn_Edit;
        private Telerik.WinControls.UI.RadLabel lb_OldUserName;
        private Telerik.WinControls.UI.RadDropDownList combo_OldUserName;
        private Telerik.WinControls.UI.RadDesktopAlert Alert_EditDeletUser;
    }
}