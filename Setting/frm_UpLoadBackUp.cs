using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading;
using HomeCafe.DataBase;
using HomeCafe.Index_and_Login;
using Telerik.WinControls.UI;

namespace HomeCafe.Setting
{
    public partial class frm_UpLoadBackUp : RadForm
    {
        OpenFileDialog dlg;
        public SqlConnection conn;
        string sql = string.Empty;
        public SqlCommand command;
        Alert.Alert Error;
       
        public frm_UpLoadBackUp()
        {
            InitializeComponent();
            this.ThemeName = "TelerikMetro";

          

        }

        private void frm_UpLoadBackUp_Load(object sender, EventArgs e)
        {
            this.Text =  " بارگذاری فایل پشتیبان" + "      " + "کاربر:" + "   " + FrmLogin.FormUser;
            WaitingBar_UpLaod.Visible = false;

        }

        private void btn_SelectAddress_Click(object sender, EventArgs e)
        {
            dlg = new OpenFileDialog();
            dlg.Filter = "فایل های پشتیبان (*.bak)|*.bak|تمامی فایل ها (*.*)|*.*";
            dlg.FilterIndex = 0;
            if (dlg.ShowDialog() == DialogResult.OK)
            {

                btn_UpLoad.Enabled = true;
            }
            else
                btn_UpLoad.Enabled = false;


        }

        private void UpLoad_DoWork(object sender, DoWorkEventArgs e)
        {
            MyDatabase db = new MyDatabase();
           
            try
            {

               
                conn = new SqlConnection();
                conn.ConnectionString = @"Data Source=.;Initial Catalog=Master;User ID=sa;password=qwert12345";
                conn.Open();
                System.Data.Sql.SqlDataSourceEnumerator instance = System.Data.Sql.SqlDataSourceEnumerator.Instance;
               
                sql = "Alter Database Cafe Set SINGLE_USER WITH ROLLBACK IMMEDIATE;";
                sql += "Restore Database Cafe FROM DISK=N'" +dlg.FileName  + "' WITH REPLACE";

                command = new SqlCommand(sql, conn);
                command.ExecuteNonQuery();
                conn.Close();
                conn.Dispose();

               
                e.Result = true;



            }
            catch 
            {
                e.Result = false;
               
                Error = new Alert.Alert("Error", "." + "مشکل در برقراری ارتباط با پایگاه داده ");
                Error.TopMost = true;
                Error.Show();
            }
          


        }

        private void btn_UpLoad_Click(object sender, EventArgs e)
        {
            Thread_UpLoad.RunWorkerAsync();

            WaitingBar_UpLaod.Visible = true;
            WaitingBar_UpLaod.StartWaiting();

           
            
        }

        private void UpLoad_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            
            WaitingBar_UpLaod.Visible = false;
            WaitingBar_UpLaod.StopWaiting();
            btn_UpLoad.Enabled = false;
            if ((bool)e.Result)
            {
                Alert_LoadBackUp.CaptionText = "توجه";
                Alert_LoadBackUp.ContentText = "." + "فایل پشتیبان با موفقیت بارگذاری شد";
                Alert_LoadBackUp.Popup.AlertElement.ContentElement.Font = new Font("B kamran", 16.0f);
                Alert_LoadBackUp.Popup.AlertElement.CaptionElement.TextAndButtonsElement.TextElement.Font = new Font("B kamran", 14.0f);

                Alert_LoadBackUp.Popup.AlertElement.ContentElement.TextAlignment = ContentAlignment.MiddleRight;
                Alert_LoadBackUp.Popup.AlertElement.CaptionElement.TextAndButtonsElement.TextAlignment = ContentAlignment.TopRight;
                Alert_LoadBackUp.Show();
            }
            

        }
    }
}
