using System;
using HomeCafe.DataBase;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace HomeCafe.Index_and_Login
{
    public class Index
    {
        private readonly IMyDataBase _myDataBase;
        public string UserName { get; set; }
        public string PageName { get; set; }
        private bool _visibility;
        private Alert.Alert _error;

        public Index(IMyDataBase myDataBase)
        {
            _myDataBase = myDataBase;
        }

        public ElementVisibility GetStatus()
        {
            try
            {
                var result = _myDataBase.Select("SELECT    dbo.accessibility.visibility"
                                   + " FROM         dbo.accessibility INNER JOIN"
                                   + " dbo.login ON dbo.accessibility.UserID = dbo.login.id "
                                   + " WHERE  (dbo.login.username = N'" + UserName + "')" +
                                   " AND (dbo.accessibility.pagename = N'" + PageName + "')");
                if (result.Read())
                {
                    _visibility = Convert.ToBoolean(result[0].ToString());
                }
                _myDataBase.SqlClose();
                return _visibility ? ElementVisibility.Visible : ElementVisibility.Collapsed;
            }
            catch (Exception exception)
            {
                _error = new Alert.Alert("Error", "مشکل در برقراری ارتباط با پایگاه داده" + ".") { TopMost = true };
                _error.Show();
                _myDataBase.SqlClose();
                throw new ArgumentException("Can not read product", exception.InnerException);
            }
           
        }

    }
}