namespace HomeCafe.About_us
{
    partial class FrmAboutUs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAboutUs));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.radPanel2 = new Telerik.WinControls.UI.RadPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_txt = new System.Windows.Forms.Label();
            this.txt_AboutUs = new Telerik.WinControls.UI.RadTextBox();
            this.Panel_Logo = new Telerik.WinControls.UI.RadPanel();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel2)).BeginInit();
            this.radPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_AboutUs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Panel_Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // radPanel2
            // 
            this.radPanel2.Controls.Add(this.label4);
            this.radPanel2.Controls.Add(this.label2);
            this.radPanel2.Controls.Add(this.label5);
            this.radPanel2.Controls.Add(this.label3);
            this.radPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.radPanel2.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.radPanel2.Location = new System.Drawing.Point(0, 391);
            this.radPanel2.Name = "radPanel2";
            this.radPanel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radPanel2.Size = new System.Drawing.Size(387, 88);
            this.radPanel2.TabIndex = 2;
            this.radPanel2.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.radPanel2.ThemeName = "TelerikMetro";
            // 
            // label4
            // 
            this.label4.Image = global::HomeCafe.Properties.Resources.smartphone_call1;
            this.label4.Location = new System.Drawing.Point(359, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 24);
            this.label4.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.Image = global::HomeCafe.Properties.Resources.close_envelope;
            this.label2.Location = new System.Drawing.Point(359, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 24);
            this.label2.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(136, 51);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(199, 19);
            this.label5.TabIndex = 13;
            this.label5.Text = "aref.khandantabrizi@gmail.com";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("IRANSansDNFaNum", 9.75F);
            this.label3.Location = new System.Drawing.Point(246, 14);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(83, 21);
            this.label3.TabIndex = 12;
            this.label3.Text = "09366361223";
            // 
            // lb_txt
            // 
            this.lb_txt.AutoSize = true;
            this.lb_txt.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lb_txt.ForeColor = System.Drawing.Color.SteelBlue;
            this.lb_txt.Location = new System.Drawing.Point(200, 302);
            this.lb_txt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_txt.Name = "lb_txt";
            this.lb_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lb_txt.Size = new System.Drawing.Size(0, 29);
            this.lb_txt.TabIndex = 14;
            this.lb_txt.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lb_txt.UseCompatibleTextRendering = true;
            // 
            // txt_AboutUs
            // 
            this.txt_AboutUs.AcceptsReturn = true;
            this.txt_AboutUs.AutoScroll = true;
            this.txt_AboutUs.Cursor = System.Windows.Forms.Cursors.Default;
            this.txt_AboutUs.Font = new System.Drawing.Font("IRANSansDNFaNum", 9.75F);
            this.txt_AboutUs.ForeColor = System.Drawing.Color.DimGray;
            this.txt_AboutUs.Location = new System.Drawing.Point(0, 294);
            this.txt_AboutUs.Multiline = true;
            this.txt_AboutUs.Name = "txt_AboutUs";
            this.txt_AboutUs.ReadOnly = true;
            // 
            // 
            // 
            this.txt_AboutUs.RootElement.StretchVertically = true;
            this.txt_AboutUs.Size = new System.Drawing.Size(380, 91);
            this.txt_AboutUs.TabIndex = 15;
            this.txt_AboutUs.ThemeName = "TelerikMetro";
            this.txt_AboutUs.TextChanging += new Telerik.WinControls.TextChangingEventHandler(this.txt_AboutUs_TextChanging);
            //this.txt_AboutUs.Enter += new System.EventHandler(this.txt_AboutUs_Enter);
            this.txt_AboutUs.MouseEnter += new System.EventHandler(this.txt_AboutUs_MouseEnter);
            this.txt_AboutUs.MouseLeave += new System.EventHandler(this.txt_AboutUs_MouseLeave);
            ((Telerik.WinControls.UI.RadTextBoxElement)(this.txt_AboutUs.GetChildAt(0))).NullTextColor = System.Drawing.Color.DimGray;
            ((Telerik.WinControls.UI.RadTextBoxElement)(this.txt_AboutUs.GetChildAt(0))).Text = "";
            ((Telerik.WinControls.UI.RadTextBoxElement)(this.txt_AboutUs.GetChildAt(0))).BackColor = System.Drawing.Color.White;
            ((Telerik.WinControls.UI.RadTextBoxItem)(this.txt_AboutUs.GetChildAt(0).GetChildAt(0))).StretchVertically = true;
            ((Telerik.WinControls.UI.RadTextBoxItem)(this.txt_AboutUs.GetChildAt(0).GetChildAt(0))).BackColor = System.Drawing.Color.White;
            ((Telerik.WinControls.UI.RadTextBoxItem)(this.txt_AboutUs.GetChildAt(0).GetChildAt(0))).Font = new System.Drawing.Font("IRANSansDNFaNum", 9.75F);
            ((Telerik.WinControls.UI.RadTextBoxItem)(this.txt_AboutUs.GetChildAt(0).GetChildAt(0))).CanFocus = false;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.txt_AboutUs.GetChildAt(0).GetChildAt(1))).BackColor2 = System.Drawing.Color.White;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.txt_AboutUs.GetChildAt(0).GetChildAt(1))).BackColor3 = System.Drawing.Color.White;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.txt_AboutUs.GetChildAt(0).GetChildAt(1))).BackColor4 = System.Drawing.Color.White;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.txt_AboutUs.GetChildAt(0).GetChildAt(1))).BackColor = System.Drawing.Color.White;
            // 
            // Panel_Logo
            // 
            this.Panel_Logo.BackgroundImage = global::HomeCafe.Properties.Resources.WhatsApp_Image_2019_06_07_at_14_31_54;
            this.Panel_Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Panel_Logo.Location = new System.Drawing.Point(0, 0);
            this.Panel_Logo.Name = "Panel_Logo";
            this.Panel_Logo.Size = new System.Drawing.Size(380, 288);
            this.Panel_Logo.TabIndex = 0;
            this.Panel_Logo.ThemeName = "TelerikMetro";
            // 
            // FrmAboutUs
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(387, 479);
            this.Controls.Add(this.txt_AboutUs);
            this.Controls.Add(this.lb_txt);
            this.Controls.Add(this.radPanel2);
            this.Controls.Add(this.Panel_Logo);
            this.Font = new System.Drawing.Font("IRANSansDNFaNum", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAboutUs";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "درباره ما .....";
            this.ThemeName = "TelerikMetro";
            this.Load += new System.EventHandler(this.frm_About_Us_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radPanel2)).EndInit();
            this.radPanel2.ResumeLayout(false);
            this.radPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_AboutUs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Panel_Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadPanel Panel_Logo;
        private System.Windows.Forms.Timer timer1;
        private Telerik.WinControls.UI.RadPanel radPanel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_txt;
        private Telerik.WinControls.UI.RadTextBox txt_AboutUs;
    }
}