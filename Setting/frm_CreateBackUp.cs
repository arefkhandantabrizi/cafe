using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HomeCafe.DataBase;
using HomeCafe.Index_and_Login;
using Telerik.WinControls.UI;

namespace HomeCafe.Setting
{
    public partial class frm_CreateBackUp : RadForm
    {
        InputLanguage original;
        string fn;
        Alert.Alert Error;
        public frm_CreateBackUp()
        {
            InitializeComponent();
            this.ThemeName = "TelerikMetro";
        }

        private void frm_CreateBackUp_Load(object sender, EventArgs e)
        {
            this.Text = "        " + " تهیه فایل پشتیبان" + "                  " + "کاربر:" + "   " + FrmLogin.FormUser;
            txt_BackUp.NullText = "نام فایل پشتیبان را با فرمت دلخواه وارد کنید" + ".";

            btn_Create.Enabled = false;
           

        }

     
        private void btn_Create_Click(object sender, EventArgs e)
        {
           
            MyDatabase db_SaveBackUp = new MyDatabase();
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "آدرس پیشنهادی برای فایل پشتیبان";


            if (fbd.ShowDialog() == DialogResult.OK)
            {
                fn = fbd.SelectedPath + "\\" + txt_BackUp.Text + ".bak";
                try
                {
                    db_SaveBackUp.Backup("BACKUP DATABASE Cafe TO DISK='" + fn + "' ");


                    this.Alert_CreateBackUp.CaptionText = "توجه";
                    this.Alert_CreateBackUp.ContentText = "." + "فایل پشتیبان با موفقیت ساخته شد";
                    this.Alert_CreateBackUp.Popup.AlertElement.ContentElement.Font = new Font("B kamran", 16.0f);
                    this.Alert_CreateBackUp.Popup.AlertElement.CaptionElement.TextAndButtonsElement.TextElement.Font = new Font("B kamran", 14.0f);

                    this.Alert_CreateBackUp.Popup.AlertElement.ContentElement.TextAlignment = ContentAlignment.MiddleRight;
                    this.Alert_CreateBackUp.Popup.AlertElement.CaptionElement.TextAndButtonsElement.TextAlignment = ContentAlignment.TopRight;
                    Alert_CreateBackUp.Show();


                    db_SaveBackUp.Conn.Close();
                    db_SaveBackUp.Conn.Dispose();
                }
                catch
                {
                    Error = new Alert.Alert("Error", "." + "مشکل در برقراری ارتباط با پایگاه داده ");
                    Error.TopMost = true;
                    Error.Show();
                }
            }
        }

      
        private void txt_BackUp_Enter(object sender, EventArgs e)
        {
            original = InputLanguage.CurrentInputLanguage;
            var culture = System.Globalization.CultureInfo.GetCultureInfo("fa-IR");
            var language = InputLanguage.FromCulture(culture);
            if (InputLanguage.InstalledInputLanguages.IndexOf(language) >= 0)
                InputLanguage.CurrentInputLanguage = language;
            else
                InputLanguage.CurrentInputLanguage = InputLanguage.DefaultInputLanguage;
        }

        private void txt_BackUp_Leave(object sender, EventArgs e)
        {
            InputLanguage.CurrentInputLanguage = original;
        }

        private void txt_BackUp_TextChanged(object sender, EventArgs e)
        {
            if (txt_BackUp.Text.Length > 0)
                btn_Create.Enabled = true;
            else
                btn_Create.Enabled = false;
        }

        private void txt_BackUp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(!char.IsControl(e.KeyChar)
                  && e.KeyChar != '.' && e.KeyChar != '+' && e.KeyChar != '-'
                  && e.KeyChar != '(' && e.KeyChar != ')' && e.KeyChar != '*'
                  && e.KeyChar != '/' && e.KeyChar !='!'  && e.KeyChar !='@'
                  && e.KeyChar != '#' && e.KeyChar != '$' && e.KeyChar != '%'
                  && e.KeyChar != '^' && e.KeyChar != '&' && e.KeyChar != '_'
                  && e.KeyChar != '|' && e.KeyChar != '?' && e.KeyChar != '>'
                  && e.KeyChar != '<' && e.KeyChar != '{' && e.KeyChar != '}'
                  && e.KeyChar != '[' && e.KeyChar != ']' && e.KeyChar != '`'
                  && e.KeyChar != '~' && e.KeyChar != ':' && e.KeyChar != ';'
                  && e.KeyChar != ':' && e.KeyChar != '؟' && e.KeyChar != '»'
                  && e.KeyChar != '«' && e.KeyChar != ':' && e.KeyChar != '"'
                  && e.KeyChar != '<' && e.KeyChar != '>' && e.KeyChar != '|'
                  && e.KeyChar != '}' && e.KeyChar != '{' && e.KeyChar != '×'
                  && e.KeyChar != '÷' && e.KeyChar != 'ـ' && e.KeyChar != '،'
                  && e.KeyChar != '؛' && e.KeyChar != '=' && e.KeyChar != '='
                  && e.KeyChar != ',' && e.KeyChar != '_' 
                  && e.KeyChar != '"' && e.KeyChar != (Char)Keys.Oemcomma
                  && e.KeyChar != (Char)Keys.OemBackslash) && e.KeyChar != (Char)Keys.Back
                  && e.KeyChar != (Char)Keys.OemQuestion && e.KeyChar != (Char)Keys.RShiftKey
                  && e.KeyChar != (Char)Keys.LShiftKey)                 
            {
                e.Handled = true;
                return;
            }
            e.Handled = false;
        }

        
    }
}
