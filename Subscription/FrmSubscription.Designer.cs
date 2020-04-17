namespace HomeCafe.Subscription
{
    partial class FrmSubscription
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSubscription));
            this.GroupBox_PersonalInformation = new Telerik.WinControls.UI.RadGroupBox();
            this.combo_Birthday = new Telerik.WinControls.UI.RadDateTimePicker();
            this.lb_birthday = new Telerik.WinControls.UI.RadLabel();
            this.txt_Name = new Telerik.WinControls.UI.RadTextBox();
            this.lb_name = new Telerik.WinControls.UI.RadLabel();
            this.Alert_Subscription = new Telerik.WinControls.UI.RadDesktopAlert(this.components);
            this.lb_phoneno = new Telerik.WinControls.UI.RadLabel();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.txt_PhoneNo = new Telerik.WinControls.UI.RadMaskedEditBox();
            this.txt_Address = new Telerik.WinControls.UI.RadTextBox();
            this.lb_address = new Telerik.WinControls.UI.RadLabel();
            this.btn_Save = new Telerik.WinControls.UI.RadButton();
            this.radGroupBox2 = new Telerik.WinControls.UI.RadGroupBox();
            this.txt_Subscription = new Telerik.WinControls.UI.RadTextBox();
            this.lb_subscription = new Telerik.WinControls.UI.RadLabel();
            this.txt_LastSubscription = new Telerik.WinControls.UI.RadTextBox();
            this.lb_lastsubscription = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.GroupBox_PersonalInformation)).BeginInit();
            this.GroupBox_PersonalInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.combo_Birthday)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lb_birthday)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Name)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lb_name)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lb_phoneno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_PhoneNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Address)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lb_address)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Save)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).BeginInit();
            this.radGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Subscription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lb_subscription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_LastSubscription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lb_lastsubscription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBox_PersonalInformation
            // 
            this.GroupBox_PersonalInformation.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.GroupBox_PersonalInformation.Controls.Add(this.combo_Birthday);
            this.GroupBox_PersonalInformation.Controls.Add(this.lb_birthday);
            this.GroupBox_PersonalInformation.Controls.Add(this.txt_Name);
            this.GroupBox_PersonalInformation.Controls.Add(this.lb_name);
            this.GroupBox_PersonalInformation.Dock = System.Windows.Forms.DockStyle.Top;
            this.GroupBox_PersonalInformation.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.GroupBox_PersonalInformation.HeaderText = "اطلاعات شناسنامه ای";
            this.GroupBox_PersonalInformation.Location = new System.Drawing.Point(0, 0);
            this.GroupBox_PersonalInformation.Name = "GroupBox_PersonalInformation";
            this.GroupBox_PersonalInformation.Size = new System.Drawing.Size(398, 120);
            this.GroupBox_PersonalInformation.TabIndex = 0;
            this.GroupBox_PersonalInformation.Text = "اطلاعات شناسنامه ای";
            this.GroupBox_PersonalInformation.ThemeName = "TelerikMetro";
            ((Telerik.WinControls.UI.GroupBoxHeader)(this.GroupBox_PersonalInformation.GetChildAt(0).GetChildAt(1))).Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            // 
            // combo_Birthday
            // 
            this.combo_Birthday.Culture = new System.Globalization.CultureInfo("fa-IR");
            this.combo_Birthday.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.combo_Birthday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.combo_Birthday.Location = new System.Drawing.Point(12, 76);
            this.combo_Birthday.Name = "combo_Birthday";
            this.combo_Birthday.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.combo_Birthday.Size = new System.Drawing.Size(301, 35);
            this.combo_Birthday.TabIndex = 2;
            this.combo_Birthday.TabStop = false;
            this.combo_Birthday.Text = "04/25/2019";
            this.combo_Birthday.ThemeName = "TelerikMetro";
            this.combo_Birthday.Value = new System.DateTime(2019, 4, 25, 21, 12, 56, 993);
            // 
            // lb_birthday
            // 
            this.lb_birthday.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lb_birthday.Location = new System.Drawing.Point(319, 76);
            this.lb_birthday.Name = "lb_birthday";
            this.lb_birthday.Size = new System.Drawing.Size(64, 30);
            this.lb_birthday.TabIndex = 4;
            this.lb_birthday.Text = "تاریخ تولد:";
            this.lb_birthday.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            this.lb_birthday.ThemeName = "TelerikMetro";
            // 
            // txt_Name
            // 
            this.txt_Name.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_Name.Location = new System.Drawing.Point(12, 35);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(301, 35);
            this.txt_Name.TabIndex = 0;
            this.txt_Name.ThemeName = "TelerikMetro";
            this.txt_Name.TextChanged += new System.EventHandler(this.txt_Name_TextChanged);
            this.txt_Name.Enter += new System.EventHandler(this.txt_Name_Enter);
            this.txt_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Name_KeyPress);
            this.txt_Name.Leave += new System.EventHandler(this.txt_Name_Leave);
            // 
            // lb_name
            // 
            this.lb_name.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lb_name.Location = new System.Drawing.Point(319, 40);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(33, 30);
            this.lb_name.TabIndex = 0;
            this.lb_name.Text = "نام :";
            this.lb_name.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            this.lb_name.ThemeName = "TelerikMetro";
            // 
            // Alert_Subscription
            // 
            this.Alert_Subscription.CanMove = false;
            this.Alert_Subscription.ContentImage = global::HomeCafe.Properties.Resources.success_Alert;
            this.Alert_Subscription.ThemeName = "TelerikMetro";
            // 
            // lb_phoneno
            // 
            this.lb_phoneno.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lb_phoneno.Location = new System.Drawing.Point(319, 35);
            this.lb_phoneno.Name = "lb_phoneno";
            this.lb_phoneno.Size = new System.Drawing.Size(73, 30);
            this.lb_phoneno.TabIndex = 6;
            this.lb_phoneno.Text = "شماره تلفن:";
            this.lb_phoneno.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            this.lb_phoneno.ThemeName = "TelerikMetro";
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.txt_PhoneNo);
            this.radGroupBox1.Controls.Add(this.lb_phoneno);
            this.radGroupBox1.Controls.Add(this.txt_Address);
            this.radGroupBox1.Controls.Add(this.lb_address);
            this.radGroupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radGroupBox1.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.radGroupBox1.HeaderText = "اطلاعات محل زندگی";
            this.radGroupBox1.Location = new System.Drawing.Point(0, 120);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(398, 139);
            this.radGroupBox1.TabIndex = 1;
            this.radGroupBox1.Text = "اطلاعات محل زندگی";
            this.radGroupBox1.ThemeName = "TelerikMetro";
            ((Telerik.WinControls.UI.GroupBoxHeader)(this.radGroupBox1.GetChildAt(0).GetChildAt(1))).Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            // 
            // txt_PhoneNo
            // 
            this.txt_PhoneNo.Culture = new System.Globalization.CultureInfo("fa-IR");
            this.txt_PhoneNo.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_PhoneNo.Location = new System.Drawing.Point(12, 35);
            this.txt_PhoneNo.Mask = "(0000),000,0000";
            this.txt_PhoneNo.MaskType = Telerik.WinControls.UI.MaskType.Standard;
            this.txt_PhoneNo.Name = "txt_PhoneNo";
            this.txt_PhoneNo.PromptChar = '-';
            this.txt_PhoneNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_PhoneNo.Size = new System.Drawing.Size(300, 35);
            this.txt_PhoneNo.TabIndex = 0;
            this.txt_PhoneNo.TabStop = false;
            this.txt_PhoneNo.Text = "(----),---,----";
            this.txt_PhoneNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_PhoneNo.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txt_PhoneNo.ThemeName = "TelerikMetro";
            this.txt_PhoneNo.TextChanged += new System.EventHandler(this.txt_PhoneNo_TextChanged);
            // 
            // txt_Address
            // 
            this.txt_Address.AcceptsReturn = true;
            this.txt_Address.AutoScroll = true;
            this.txt_Address.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_Address.Location = new System.Drawing.Point(12, 76);
            this.txt_Address.Multiline = true;
            this.txt_Address.Name = "txt_Address";
            // 
            // 
            // 
            this.txt_Address.RootElement.StretchVertically = true;
            this.txt_Address.Size = new System.Drawing.Size(301, 47);
            this.txt_Address.TabIndex = 1;
            this.txt_Address.ThemeName = "TelerikMetro";
            this.txt_Address.TextChanged += new System.EventHandler(this.txt_Address_TextChanged);
            this.txt_Address.Enter += new System.EventHandler(this.txt_Address_Enter);
            this.txt_Address.Leave += new System.EventHandler(this.txt_Address_Leave);
            // 
            // lb_address
            // 
            this.lb_address.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lb_address.Location = new System.Drawing.Point(319, 76);
            this.lb_address.Name = "lb_address";
            this.lb_address.Size = new System.Drawing.Size(44, 30);
            this.lb_address.TabIndex = 2;
            this.lb_address.Text = "آدرس:";
            this.lb_address.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            this.lb_address.ThemeName = "TelerikMetro";
            // 
            // btn_Save
            // 
            this.btn_Save.Enabled = false;
            this.btn_Save.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_Save.Location = new System.Drawing.Point(12, 122);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(110, 39);
            this.btn_Save.TabIndex = 2;
            this.btn_Save.Text = "ثبت";
            this.btn_Save.ThemeName = "TelerikMetro";
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // radGroupBox2
            // 
            this.radGroupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox2.Controls.Add(this.btn_Save);
            this.radGroupBox2.Controls.Add(this.txt_Subscription);
            this.radGroupBox2.Controls.Add(this.lb_subscription);
            this.radGroupBox2.Controls.Add(this.txt_LastSubscription);
            this.radGroupBox2.Controls.Add(this.lb_lastsubscription);
            this.radGroupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radGroupBox2.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.radGroupBox2.HeaderText = "شماره اشتراک";
            this.radGroupBox2.Location = new System.Drawing.Point(0, 259);
            this.radGroupBox2.Name = "radGroupBox2";
            this.radGroupBox2.Size = new System.Drawing.Size(398, 166);
            this.radGroupBox2.TabIndex = 2;
            this.radGroupBox2.Text = "شماره اشتراک";
            this.radGroupBox2.ThemeName = "TelerikMetro";
            ((Telerik.WinControls.UI.GroupBoxHeader)(this.radGroupBox2.GetChildAt(0).GetChildAt(1))).Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            // 
            // txt_Subscription
            // 
            this.txt_Subscription.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_Subscription.Location = new System.Drawing.Point(12, 75);
            this.txt_Subscription.Name = "txt_Subscription";
            this.txt_Subscription.Size = new System.Drawing.Size(256, 35);
            this.txt_Subscription.TabIndex = 1;
            this.txt_Subscription.ThemeName = "TelerikMetro";
            this.txt_Subscription.TextChanged += new System.EventHandler(this.txt_Subscription_TextChanged);
            this.txt_Subscription.Enter += new System.EventHandler(this.txt_Subscription_Enter);
            this.txt_Subscription.Leave += new System.EventHandler(this.txt_Subscription_Leave);
            // 
            // lb_subscription
            // 
            this.lb_subscription.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lb_subscription.Location = new System.Drawing.Point(273, 75);
            this.lb_subscription.Name = "lb_subscription";
            this.lb_subscription.Size = new System.Drawing.Size(85, 30);
            this.lb_subscription.TabIndex = 7;
            this.lb_subscription.Text = "شماره اشتراک:";
            this.lb_subscription.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            this.lb_subscription.ThemeName = "TelerikMetro";
            // 
            // txt_LastSubscription
            // 
            this.txt_LastSubscription.Enabled = false;
            this.txt_LastSubscription.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_LastSubscription.Location = new System.Drawing.Point(12, 33);
            this.txt_LastSubscription.Name = "txt_LastSubscription";
            this.txt_LastSubscription.Size = new System.Drawing.Size(256, 35);
            this.txt_LastSubscription.TabIndex = 0;
            this.txt_LastSubscription.ThemeName = "TelerikMetro";
            // 
            // lb_lastsubscription
            // 
            this.lb_lastsubscription.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lb_lastsubscription.Location = new System.Drawing.Point(274, 38);
            this.lb_lastsubscription.Name = "lb_lastsubscription";
            this.lb_lastsubscription.Size = new System.Drawing.Size(120, 30);
            this.lb_lastsubscription.TabIndex = 6;
            this.lb_lastsubscription.Text = "آخرین شماره اشتراک:";
            this.lb_lastsubscription.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            this.lb_lastsubscription.ThemeName = "TelerikMetro";
            // 
            // FrmSubscription
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(398, 425);
            this.Controls.Add(this.radGroupBox2);
            this.Controls.Add(this.radGroupBox1);
            this.Controls.Add(this.GroupBox_PersonalInformation);
            this.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSubscription";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "";
            this.ThemeName = "TelerikMetro";
            this.Load += new System.EventHandler(this.frm_Subscription_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GroupBox_PersonalInformation)).EndInit();
            this.GroupBox_PersonalInformation.ResumeLayout(false);
            this.GroupBox_PersonalInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.combo_Birthday)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lb_birthday)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Name)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lb_name)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lb_phoneno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_PhoneNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Address)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lb_address)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Save)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).EndInit();
            this.radGroupBox2.ResumeLayout(false);
            this.radGroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Subscription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lb_subscription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_LastSubscription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lb_lastsubscription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGroupBox GroupBox_PersonalInformation;
        private Telerik.WinControls.UI.RadLabel lb_birthday;
        private Telerik.WinControls.UI.RadTextBox txt_Name;
        private Telerik.WinControls.UI.RadLabel lb_name;
        private Telerik.WinControls.UI.RadDesktopAlert Alert_Subscription;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadMaskedEditBox txt_PhoneNo;
        private Telerik.WinControls.UI.RadLabel lb_phoneno;
        private Telerik.WinControls.UI.RadTextBox txt_Address;
        private Telerik.WinControls.UI.RadLabel lb_address;
        private Telerik.WinControls.UI.RadButton btn_Save;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox2;
        private Telerik.WinControls.UI.RadTextBox txt_Subscription;
        private Telerik.WinControls.UI.RadLabel lb_subscription;
        private Telerik.WinControls.UI.RadTextBox txt_LastSubscription;
        private Telerik.WinControls.UI.RadLabel lb_lastsubscription;
        private Telerik.WinControls.UI.RadDateTimePicker combo_Birthday;
    }
}