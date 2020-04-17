using HomeCafe.DataBase;
using Telerik.WinControls;

namespace HomeCafe.Index_and_Login
{
    public class LoginUser 
    {
        private readonly IMyDataBase _myDataBase;
        private Alert.Alert _error;
        public string UserName { get; set; }
        public string PassWord { get; set; }

        public LoginUser(IMyDataBase myDataBase)
        {
            _myDataBase = myDataBase;
        }

        public bool Login()
        {
            try
            {
                var clinet = _myDataBase.Select("select * from login");
                while (clinet.Read())
                {
                    var userName = clinet[1].ToString();
                    var passWord = clinet[2].ToString();

                    if (userName != UserName || passWord != PassWord) continue;
                    _myDataBase.SqlClose();
                    return true;
                }
                _myDataBase.SqlClose();
                return false;
            }
            catch 
            {

                _error = new Alert.Alert("Error", "خطای کد : [0xd001] مشکل در اتباط با پایگاه داده" + ".")
                {
                    TopMost = true,
                    ThemeClassName = "Telerik.WinControls.UI.RadForm",
                    ThemeName = "telerikMetroTheme1"
                };
                ThemeResolutionService.ApplyThemeToControlTree(_error,_error.ThemeName);
                _error.Show();
                return false;
            }
    

        }

    }
}