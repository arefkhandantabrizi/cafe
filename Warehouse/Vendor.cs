using System.Collections.Generic;
using System.Globalization;
using HomeCafe.DataBase;
using HomeCafe.My_Custom_Classes;

namespace HomeCafe.Warehouse
{
    public class Vendor 
    {
        private readonly IMyDataBase _myDataBase;
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public int Id { get; set; }

        private Alert.Alert _error;

        public Vendor(IMyDataBase myDataBase)
        {
            _myDataBase = myDataBase;
          
        }

        public bool Delete()
        {
            try
            {
                var result = _myDataBase.Update("update vendor set isDeleted=N'" + true + "' where id=N'" + Id + "'");
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

        public bool UpDate()
        {
            try
            {

               var result = _myDataBase.Update("update vendor set name=N'" +Name + "'" +
                                               ",tel=N'" + PhoneNumber + "', address=N'" + Address + "' " +
                                               "where id=N'" + Id + "'");
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

        public bool Save()
        {
            try
            {
                
               var result = _myDataBase.Insert("Insert into vendor (name,address,tel,isDeleted) values" +
                                   " (N'" + Name + "',N'" + Address + "',N'" + PhoneNumber + "',N'" + false + "')");
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

        public List<string> FillName()
        {
            var vendorNames = new List<string>();
            try
            {

                var result = _myDataBase.Select("select * from vendor where isDeleted=N'" +false+ "'");
                while (result.Read())
                {
                    vendorNames.Add(result[1].ToString());
                }
                _myDataBase.SqlClose();
                return vendorNames;
            }
            catch
            {
                _error = new Alert.Alert("Error", "." + "مشکل در برقراری ارتباط با پایگاه داده") { TopMost = true };
                _error.Show();
                return null;
            }
        }
    }
}