namespace HomeCafe.Alert
{
    partial class Alert
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
            this._alertlabelHeader = new Telerik.WinControls.UI.RadLabel();
            this.BtnOk = new Telerik.WinControls.UI.RadButton();
            this.BtnCancel = new Telerik.WinControls.UI.RadButton();
            this.BtnNo = new Telerik.WinControls.UI.RadButton();
            this._mainlabelTxt = new Telerik.WinControls.UI.RadLabel();
            this._alertlabelPic = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this._alertlabelHeader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnOk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._mainlabelTxt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._alertlabelPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // _alertlabelHeader
            // 
            this._alertlabelHeader.Font = new System.Drawing.Font("IRANSansDNFaNum", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._alertlabelHeader.ForeColor = System.Drawing.Color.Red;
            this._alertlabelHeader.Location = new System.Drawing.Point(160, 5);
            this._alertlabelHeader.Name = "_alertlabelHeader";
            this._alertlabelHeader.Size = new System.Drawing.Size(77, 29);
            this._alertlabelHeader.TabIndex = 1;
            this._alertlabelHeader.Text = "radLabel1";
            this._alertlabelHeader.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            this._alertlabelHeader.ThemeName = "TelerikMetro";
            // 
            // BtnOk
            // 
            this.BtnOk.Font = new System.Drawing.Font("IRANSansDNFaNum", 9.75F);
            this.BtnOk.Location = new System.Drawing.Point(12, 118);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Size = new System.Drawing.Size(74, 34);
            this.BtnOk.TabIndex = 3;
            this.BtnOk.Tag = "";
            this.BtnOk.Text = "تایید";
            this.BtnOk.ThemeName = "TelerikMetro";
            this.BtnOk.Click += new System.EventHandler(this.btn_Ok_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.Font = new System.Drawing.Font("IRANSansDNFaNum", 9.75F);
            this.BtnCancel.Location = new System.Drawing.Point(172, 118);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(74, 34);
            this.BtnCancel.TabIndex = 4;
            this.BtnCancel.Text = "انصراف";
            this.BtnCancel.ThemeName = "TelerikMetro";
            this.BtnCancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // BtnNo
            // 
            this.BtnNo.Font = new System.Drawing.Font("IRANSansDNFaNum", 9.75F);
            this.BtnNo.Location = new System.Drawing.Point(92, 118);
            this.BtnNo.Name = "BtnNo";
            this.BtnNo.Size = new System.Drawing.Size(74, 34);
            this.BtnNo.TabIndex = 4;
            this.BtnNo.Tag = "";
            this.BtnNo.Text = "لغو";
            this.BtnNo.ThemeName = "TelerikMetro";
            this.BtnNo.Click += new System.EventHandler(this.btn_No_Click);
            // 
            // _mainlabelTxt
            // 
            this._mainlabelTxt.AutoSize = false;
            this._mainlabelTxt.Font = new System.Drawing.Font("IRANSansDNFaNum", 9.75F);
            this._mainlabelTxt.Location = new System.Drawing.Point(17, 41);
            this._mainlabelTxt.Margin = new System.Windows.Forms.Padding(0);
            this._mainlabelTxt.MaximumSize = new System.Drawing.Size(280, 90);
            this._mainlabelTxt.Name = "_mainlabelTxt";
            // 
            // 
            // 
            this._mainlabelTxt.RootElement.MaxSize = new System.Drawing.Size(280, 90);
            this._mainlabelTxt.Size = new System.Drawing.Size(278, 74);
            this._mainlabelTxt.TabIndex = 5;
            this._mainlabelTxt.Text = "radLabel1";
            this._mainlabelTxt.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            this._mainlabelTxt.ThemeName = "TelerikMetro";
            // 
            // _alertlabelPic
            // 
            this._alertlabelPic.AutoSize = false;
            this._alertlabelPic.Image = global::HomeCafe.Properties.Resources.database;
            this._alertlabelPic.Location = new System.Drawing.Point(298, 5);
            this._alertlabelPic.Name = "_alertlabelPic";
            this._alertlabelPic.Size = new System.Drawing.Size(67, 67);
            this._alertlabelPic.TabIndex = 0;
            this._alertlabelPic.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            this._alertlabelPic.ThemeName = "TelerikMetro";
            // 
            // Alert
            // 
            this.AcceptButton = this.BtnOk;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.CancelButton = this.BtnCancel;
            this.ClientSize = new System.Drawing.Size(382, 157);
            this.Controls.Add(this._mainlabelTxt);
            this.Controls.Add(this.BtnNo);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnOk);
            this.Controls.Add(this._alertlabelHeader);
            this.Controls.Add(this._alertlabelPic);
            this.Font = new System.Drawing.Font("IRANSansDNFaNum", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Alert";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "";
            this.ThemeName = "TelerikMetro";
            ((System.ComponentModel.ISupportInitialize)(this._alertlabelHeader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnOk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._mainlabelTxt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._alertlabelPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
