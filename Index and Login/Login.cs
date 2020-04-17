using System;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;
using HomeCafe.DataBase;
using HomeCafe.My_Custom_Classes;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace HomeCafe.Index_and_Login
{
    public partial class FrmLogin : RadForm 
    {
        private readonly IFixLanguageAndForms _fixLanguageAndForms;
        public RadForm Error;
        public static string FormUser;
        public FrmLogin(IFixLanguageAndForms fixLanguageAndForms)
        {
            _fixLanguageAndForms = fixLanguageAndForms;
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("fa-Ir");

            InitializeComponent();
        }

        private void txt_username_TextChanged(object sender, EventArgs e)
        {
            if (txt_username.TextLength > 0 && txt_password.TextLength > 0)
                btn_enter1.Enabled = true;
            else
                btn_enter1.Enabled = false;
        }

        private void txt_password_TextChanged(object sender, EventArgs e)
        {
            txt_password.UseSystemPasswordChar = true;
            if (txt_username.TextLength > 0 && txt_password.TextLength > 0)
                btn_enter1.Enabled = true;
            else
                btn_enter1.Enabled = false;
        }

        private void btn_enter1_Click(object sender, EventArgs e)
        {
            var loginUser = new LoginUser(new MyDatabase())
            {
                PassWord = txt_password.Text.Trim(),
                UserName = txt_username.Text.Trim()
            };

            var result = loginUser.Login();
          
            if (!result)
            {
                Error = new Alert.Alert("Error", "." + "نام کاربری یا رمز عبور اشتباه است")
                {
                    ThemeClassName = "Telerik.WinControls.UI.RadForm",
                    ThemeName = "telerikMetroTheme1"
                };

                ThemeResolutionService.ApplyThemeToControlTree(Error, ThemeName);
                Error.AllowTheming = true;
                Error.TopMost = true;
                Error.Show();
                return;
            }

            var loginForm = new FrmMain();
            Visible = false;
            FormUser = txt_username.Text.Trim();
            loginForm.Show();
        }

        private void btn_exit1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frm_login_Load_1(object sender, EventArgs e)
        {
            btn_enter1.Enabled = false;
        }

        private void txt_username_Enter(object sender, EventArgs e)
        {
           _fixLanguageAndForms.FixLanguage();
        }

        private void txt_username_Leave(object sender, EventArgs e)
        {
            _fixLanguageAndForms.OriginalLanguage();
        }

        private void txt_password_Enter(object sender, EventArgs e)
        {
            _fixLanguageAndForms.FixLanguage();
        }

        private void txt_password_Leave(object sender, EventArgs e)
        {
            _fixLanguageAndForms.OriginalLanguage();
        }

    }
}
