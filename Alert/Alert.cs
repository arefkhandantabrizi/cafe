using System;
using System.Drawing;
using System.Windows.Forms;
using HomeCafe.Properties;
using Telerik.WinControls.UI;

namespace HomeCafe.Alert
{
    public partial class Alert : RadForm
    {
       
        private RadLabel _mainlabelTxt;
        public RadButton BtnNo;
        public RadButton BtnCancel;
        public RadButton BtnOk;
        private RadLabel _alertlabelHeader;
        private RadLabel _alertlabelPic;
        public string CheckKind;
        public bool Flag;
        public Alert(string kind, string mainTxt )
        {
            CheckKind = kind;
            InitializeComponent();
            switch (kind)
            {
                case "Error":
                    var errorPic = new Bitmap(Resources.error_2);
                    _alertlabelPic.Image = errorPic;
                    _alertlabelHeader.Text = @"خطا";
                    BtnCancel.Visible = false;
                    BtnNo.Visible = false;
                    _mainlabelTxt.Text = mainTxt;
                    _mainlabelTxt.TextAlignment = ContentAlignment.TopRight;
                    ThemeName = "TelerikMetro";
                    break;
                case "Warning":
                    var warningPic = new Bitmap(Resources.warning);
                    _alertlabelPic.Image = warningPic;
                    _alertlabelHeader.Text = @"هشدار";
                    BtnCancel.Visible = false;
                    BtnNo.Visible = false;
                    _mainlabelTxt.Text = mainTxt;
                    _mainlabelTxt.TextAlignment = ContentAlignment.TopRight;
                    ThemeName = "TelerikMetro";
                    break;
                case "Success":
                    var successPic = new Bitmap(Resources.success);
                    _alertlabelPic.Image = successPic;
                    _alertlabelHeader.Text = @"موفق";
                    BtnCancel.Visible = false;
                    BtnNo.Visible = false;
                    _mainlabelTxt.Text = mainTxt;
                    _mainlabelTxt.TextAlignment = ContentAlignment.TopRight;
                    ThemeName = "TelerikMetro";
                    break;
                case "Back_up":
                    var backupPic = new Bitmap(Resources.database);
                    _alertlabelPic.Image = backupPic;
                    _alertlabelHeader.Text = @"توجه";
                    _mainlabelTxt.Text = mainTxt;
                    _mainlabelTxt.TextAlignment = ContentAlignment.TopRight;
                    ThemeName = "TelerikMetro";
                    break;

                case "Print":
                    var printPic = new Bitmap(Resources.warning);
                    _alertlabelPic.Image = printPic;
                    _alertlabelHeader.Text = @"توجه";
                    BtnCancel.Visible = false;
                    BtnNo.Visible = false;
                    _mainlabelTxt.Text = mainTxt;
                    _mainlabelTxt.TextAlignment = ContentAlignment.TopRight;
                    ThemeName = "TelerikMetro";
                    break;

            }



        }


        private void btn_Ok_Click(object sender, EventArgs e)
        {
            Flag = true;
            
            //if (CheckKind == "Back_up")
            //{
            //    Form openback_up = new frm_back_up();
            //    this.Close();
            //    openback_up.Show();
            //    openback_up.FormClosed += new FormClosedEventHandler(openback_up_FormClosed);
            //}
            //else
            Close();
        }

        void openback_up_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btn_No_Click(object sender, EventArgs e)
        {
        //    this.Close();

        //    Application.Exit();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Flag = false;
            Close();
            
        }

     

        

    }
}

