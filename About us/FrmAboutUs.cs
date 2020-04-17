using System;
using System.Drawing;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using System.Runtime.InteropServices;

namespace HomeCafe.About_us
{
    public partial class FrmAboutUs : RadForm
    {
        public FrmAboutUs()
        {
            InitializeComponent();
        }

        private void frm_About_Us_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
          
        }

        readonly string _text = "نرم افزار مدیریت کافه و رستوران" + "\r\n نسخه 1.0.0" +"\r\n"+ "تمامی حق و حقوق این برنامه به سازنده ی آن تعلق دارد." +"\r\n";
        private int _index;

        private void timer1_Tick(object sender, EventArgs e)
        {
            txt_AboutUs.Text = _text.Substring(0, _index) + @"¦";
            txt_AboutUs.ForeColor = Color.MidnightBlue;
            _index++;
            if (_index != _text.Length + 1) return;
            lb_txt.Focus();
            txt_AboutUs.Text = txt_AboutUs.Text.Remove(txt_AboutUs.Text.Length - 1 );         
            txt_AboutUs.Text = txt_AboutUs.Text.Remove(txt_AboutUs.Text.Length - 1);   
            timer1.Enabled = false;
            _index = 0;
            HideCaret(txt_AboutUs.Handle);
        }

        [DllImport("user32.dll")]
        private static extern bool HideCaret(IntPtr hWnd);

        private void txt_AboutUs_TextChanging(object sender, Telerik.WinControls.TextChangingEventArgs e)
        {
            lb_txt.Focus();
        }

        private void txt_AboutUs_MouseEnter(object sender, EventArgs e)
        {
            Cursor.Hide();
            txt_AboutUs.Click += txt_AboutUs_Click;
        }

        private void txt_AboutUs_Click(object sender, EventArgs e)
        {
            lb_txt.Focus();
        }

        private void txt_AboutUs_MouseLeave(object sender, EventArgs e)
        {
            Cursor.Show();
        }
       
    
       

    }
}
