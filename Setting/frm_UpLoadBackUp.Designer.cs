namespace HomeCafe.Setting
{
    partial class frm_UpLoadBackUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_UpLoadBackUp));
            this.btn_SelectAddress = new Telerik.WinControls.UI.RadButton();
            this.btn_UpLoad = new Telerik.WinControls.UI.RadButton();
            this.WaitingBar_UpLaod = new Telerik.WinControls.UI.RadWaitingBar();
            this.waitingBarIndicatorElement2 = new Telerik.WinControls.UI.WaitingBarIndicatorElement();
            this.waitingBarIndicatorElement1 = new Telerik.WinControls.UI.WaitingBarIndicatorElement();
            this.Alert_LoadBackUp = new Telerik.WinControls.UI.RadDesktopAlert(this.components);
            this.Thread_UpLoad = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.btn_SelectAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_UpLoad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WaitingBar_UpLaod)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_SelectAddress
            // 
            this.btn_SelectAddress.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_SelectAddress.Location = new System.Drawing.Point(85, 12);
            this.btn_SelectAddress.Name = "btn_SelectAddress";
            this.btn_SelectAddress.Size = new System.Drawing.Size(110, 38);
            this.btn_SelectAddress.TabIndex = 9;
            this.btn_SelectAddress.Text = "انتخاب فایل";
            this.btn_SelectAddress.ThemeName = "TelerikMetro";
            this.btn_SelectAddress.Click += new System.EventHandler(this.btn_SelectAddress_Click);
            // 
            // btn_UpLoad
            // 
            this.btn_UpLoad.Enabled = false;
            this.btn_UpLoad.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_UpLoad.Location = new System.Drawing.Point(85, 66);
            this.btn_UpLoad.Name = "btn_UpLoad";
            this.btn_UpLoad.Size = new System.Drawing.Size(110, 38);
            this.btn_UpLoad.TabIndex = 10;
            this.btn_UpLoad.Text = "بارگذاری";
            this.btn_UpLoad.ThemeName = "TelerikMetro";
            this.btn_UpLoad.Click += new System.EventHandler(this.btn_UpLoad_Click);
            // 
            // WaitingBar_UpLaod
            // 
            this.WaitingBar_UpLaod.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.WaitingBar_UpLaod.Location = new System.Drawing.Point(12, 115);
            this.WaitingBar_UpLaod.Name = "WaitingBar_UpLaod";
            this.WaitingBar_UpLaod.Size = new System.Drawing.Size(265, 24);
            this.WaitingBar_UpLaod.TabIndex = 11;
            this.WaitingBar_UpLaod.Text = "radWaitingBar1";
            this.WaitingBar_UpLaod.ThemeName = "TelerikMetro";
            this.WaitingBar_UpLaod.WaitingDirection = Telerik.WinControls.ProgressOrientation.Left;
            this.WaitingBar_UpLaod.WaitingIndicators.Add(this.waitingBarIndicatorElement2);
            this.WaitingBar_UpLaod.WaitingIndicators.Add(this.waitingBarIndicatorElement1);
            // 
            // waitingBarIndicatorElement2
            // 
            this.waitingBarIndicatorElement2.AutoSize = false;
            this.waitingBarIndicatorElement2.Bounds = new System.Drawing.Rectangle(0, 0, 90, 22);
            this.waitingBarIndicatorElement2.Name = "waitingBarIndicatorElement2";
            this.waitingBarIndicatorElement2.StretchHorizontally = false;
            this.waitingBarIndicatorElement2.Text = "در حال بارگذاری";
            // 
            // waitingBarIndicatorElement1
            // 
            this.waitingBarIndicatorElement1.AutoSize = false;
            this.waitingBarIndicatorElement1.Bounds = new System.Drawing.Rectangle(0, 0, 90, 22);
            this.waitingBarIndicatorElement1.Name = "waitingBarIndicatorElement1";
            this.waitingBarIndicatorElement1.StretchHorizontally = false;
            this.waitingBarIndicatorElement1.Text = "در حال بارگذاری";
            // 
            // Alert_LoadBackUp
            // 
            this.Alert_LoadBackUp.CanMove = false;
            this.Alert_LoadBackUp.ContentImage = global::HomeCafe.Properties.Resources.success_Alert;
            this.Alert_LoadBackUp.ThemeName = "TelerikMetro";
            // 
            // Thread_UpLoad
            // 
            this.Thread_UpLoad.DoWork += new System.ComponentModel.DoWorkEventHandler(this.UpLoad_DoWork);
            this.Thread_UpLoad.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.UpLoad_RunWorkerCompleted);
            // 
            // frm_UpLoadBackUp
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(289, 151);
            this.Controls.Add(this.WaitingBar_UpLaod);
            this.Controls.Add(this.btn_UpLoad);
            this.Controls.Add(this.btn_SelectAddress);
            this.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_UpLoadBackUp";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frm_UpLoadBackUp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btn_SelectAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_UpLoad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WaitingBar_UpLaod)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadButton btn_SelectAddress;
        private Telerik.WinControls.UI.RadButton btn_UpLoad;
        private Telerik.WinControls.UI.RadWaitingBar WaitingBar_UpLaod;
        private Telerik.WinControls.UI.WaitingBarIndicatorElement waitingBarIndicatorElement2;
        private Telerik.WinControls.UI.WaitingBarIndicatorElement waitingBarIndicatorElement1;
        private Telerik.WinControls.UI.RadDesktopAlert Alert_LoadBackUp;
        private System.ComponentModel.BackgroundWorker UpLoad;
        private System.ComponentModel.BackgroundWorker Thread_UpLoad;
    }
}