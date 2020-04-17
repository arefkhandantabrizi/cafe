using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Threading;
using System.Globalization;
using HomeCafe.DataBase;
using HomeCafe.Index_and_Login;
using HomeCafe.My_Custom_Classes;

namespace HomeCafe
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
               Thread.CurrentThread.CurrentUICulture = new CultureInfo("fa-IR");
                //System.Threading.Thread.CurrentThread.CurrentCulture = new CultureInfo(Properties.Settings.Default.language);//
                //System.Threading.Thread.CurrentThread.CurrentUICulture = new CultureInfo(Properties.Settings.Default.language);//


                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new FrmLogin(new FixLanguageAndForm()));
          
        }
    }
}
