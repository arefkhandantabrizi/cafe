using HomeCafe.DataBase;

namespace HomeCafe.Subscription
{
    public class Subscriber 
    {
        private readonly IMyDataBase _myDataBase;
        public string Name { get; set; }
        public string BirthDate { get; set; }
        public string PhoneNumber { get; set; }
        public string Adress { get; set; }
        public string SubscriptionNumber { get; set; }
        private Alert.Alert _error;

        public Subscriber(IMyDataBase myDataBase)
        {
            _myDataBase = myDataBase;
        }

        public bool CheckSubscriptionNumber()
        {
            var drSubscriptionNumber = _myDataBase.Select("select subscribe_num from subscribe");
            while (drSubscriptionNumber.Read())
            {
                var result = SubscriptionNumber != drSubscriptionNumber[0].ToString();
                if (result) continue;
                _myDataBase.SqlClose();
                return false;
            }
            _myDataBase.SqlClose();
            return true;
        }

        public bool Save()
        {
            try
            {
               var result = _myDataBase.Insert("insert into subscribe (name,tel,address,subscribe_num,birthday) "
                + " values(N'" +Name+ "', N'" + PhoneNumber + "' "
                + ",N'" + Adress + "',N'" +SubscriptionNumber + "',N'" + BirthDate + "') ");

                _myDataBase.SqlClose();
                return result;


            }
            catch
            {
                _error = new Alert.Alert("Error", "." + "مشکل در برقراری ارتباط با پایگاه داده") { TopMost = true };
                _error.Show();
                _myDataBase.SqlClose();
                return false;
            }

        }
    }
}