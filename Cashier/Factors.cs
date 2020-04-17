using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using HomeCafe.DataBase;

namespace HomeCafe.Cashier
{
    public class Factors
    {
        private readonly IMyDataBase _myDataBase;
        private Alert.Alert _error;
        private int _locationId;
        private int _tableId;
        public string Location { get; set; }
        public string Table { get; set; }
        public float Price { get; set; }
        public float PriceToPay { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public string SubscribeNumber { get; set; }
        public bool IsPayed { get; set; }
        public int InvoiceId { get; set; }

        public Factors(IMyDataBase myDataBase)
        {
            _myDataBase = myDataBase;
        }

        public List<string> FillSubscriber()
        {
            try
            {
                var subscribeDetails = new List<string>();
                var result = _myDataBase.Select("select name,tel,address from subscribe where subscribe_num=N'" +SubscribeNumber+ "' ");
                while (result.Read())
                {
                    for (var i = 0; i < 3; i++)
                    {
                        subscribeDetails.Add(result[i].ToString());
                    }
                    
                }
                _myDataBase.SqlClose();
                return subscribeDetails;
            }
            catch (Exception exception)
            {
                _error = new Alert.Alert("Error", "مشکل در برقراری ارتباط با پایگاه داده" + ".") {TopMost = true};
                _error.Show();
                _myDataBase.SqlClose();
                throw new ArgumentException("Can not read subscriber", exception.InnerException);
            }
        }

        public bool Save()
        {
            _locationId = FindLocationId();
            _tableId = FindTableId();
            try
            {
                if (SubscribeNumber != "")
                {
                    var resultIf = _myDataBase.Insert("Insert into invoice (table_id,location_id,date,customer_id,payed,total,isDeleted) " +
                                        "values (N'" + _tableId + "',N'" + _locationId + "',N'" + Date + "'" +
                                        ",N'" + SubscribeNumber + "',N'" + IsPayed + "',N'" + PriceToPay + "',N'" + false + "')");
                   
                    _myDataBase.SqlClose();
                    if (resultIf)
                    {
                        return true;
                    }
                    _error = new Alert.Alert("Error", "در حال حاضر امکان ذخیره فاکتور وجود ندارد" + ".") { TopMost = true };
                    _error.Show();
                    return false;

                }
                var result = _myDataBase.Insert("Insert into invoice (table_id,location_id,date,payed,total,isDeleted) values " +
                                   "(N'" + _tableId + "',N'" + _locationId + "', N'" + Date + "',N'" +
                                   IsPayed + "',N'" + PriceToPay + "',N'" + false + "')");
               
                _myDataBase.SqlClose();
                if (result)
                {
                    return true;
                }
                _error = new Alert.Alert("Error", "در حال حاضر امکان ذخیره فاکتور وجود ندارد" + ".") { TopMost = true };
                _error.Show();
                return false;
            }
            catch (Exception exception)
            {
                _error = new Alert.Alert("Error", "مشکل در برقراری ارتباط با پایگاه داده" + ".") { TopMost = true };
                _error.Show();
                _myDataBase.SqlClose();
                throw new ArgumentException("Can not read subscriber", exception.InnerException);

            }
           
        }

        public bool CheckOut()
        {
            try
            {
                var result =  _myDataBase.Update("update invoice set payed=N'" + true + "' where id=N'" + InvoiceId + "'");
                
                _myDataBase.SqlClose();
                return result;
            }
            catch (Exception exception)
            {
                _error = new Alert.Alert("Error", "مشکل در برقراری ارتباط با پایگاه داده" + ".") { TopMost = true };
                _error.Show();
                _myDataBase.SqlClose();
                throw new ArgumentException("Can not update checkout", exception.InnerException);

            }
        }

        public bool DeleteInvoice()
        {
            try
            {
                var result = _myDataBase.Update("update invoice set isDeleted=N'" + true + "' where id=N'" + InvoiceId + "'");

                _myDataBase.SqlClose();
                return result;
            }
            catch (Exception exception)
            {
                _error = new Alert.Alert("Error", "مشکل در برقراری ارتباط با پایگاه داده" + ".") { TopMost = true };
                _error.Show();
                _myDataBase.SqlClose();
                throw new ArgumentException("Can not delete invoice", exception.InnerException);

            }
        }

        public List<string> GetSubscribeName()
        {
            try
            {
                var subscribeName = new List<string>();
                var result = _myDataBase.Select("select subscribe_num from subscribe ");
                while (result.Read())
                {
                    subscribeName.Add(result[0].ToString());
                }
                _myDataBase.SqlClose();
                return subscribeName;          
            }
            catch (Exception exception)
            {
                _error = new Alert.Alert("Error", "مشکل در برقراری ارتباط با پایگاه داده" + ".") { TopMost = true };
                _error.Show();
                _myDataBase.SqlClose();
                throw new ArgumentException("Can not read subscriber", exception.InnerException);
            }
        }

        public bool UpDateInvoice()
        {
            _locationId = FindLocationId();
            _tableId = FindTableId();
            try
            {
                var result = _myDataBase.Update("update invoice set table_id=N'" + _tableId + "', location_id=N'" + _locationId + "' where id=N'" + InvoiceId + "'");

                if (result)
                {
                    _myDataBase.SqlClose();
                    return true;
                }
                _error = new Alert.Alert("Error", "در حال حاضر امکان بروزرسانی فاکتور وجود ندارد" + ".") { TopMost = true };
                _error.Show();
                return false;
            }
            catch (Exception exception)
            {

                _error = new Alert.Alert("Error", "مشکل در برقراری ارتباط با پایگاه داده" + ".") { TopMost = true };
                _error.Show();
                _myDataBase.SqlClose();
                throw new ArgumentException("Can not update invoice.", exception.InnerException); ;
            }
        }

        private int FindLocationId()
        {
            var id = -1;
            try
            {
                var locationId = _myDataBase.Select("SELECT ID FROM resource where ResourceName = N'" + Location + "' ");
                                                    
                while (locationId.Read())
                {
                    id = Convert.ToInt32(locationId[0].ToString());
                }
                _myDataBase.SqlClose();
                return id;
            }
            catch (Exception exception)
            {
                _error = new Alert.Alert("Error", "مشکل در برقراری ارتباط با پایگاه داده" + ".") { TopMost = true };
                _error.Show();
                throw new ArgumentException("Can not read the table id", exception.InnerException);
            }
        }


        private int FindTableId()
        {
            var id = -1;
            try
            {
                var tableId = _myDataBase.Select("SELECT dbo.table_name.id" +
                                                    " FROM dbo.resource INNER JOIN " +
                                                    " dbo.table_name ON dbo.resource.ID = dbo.table_name.location_id" +
                                                    " WHERE     (dbo.resource.ResourceName = N'" + Location + "')" +
                                                    " AND( dbo.table_name.name=N'" + Table + "') " +
                                                    "AND (dbo.table_name.isDeleted=N'" + false + "') ");
               while (tableId.Read())
                {
                      id = Convert.ToInt32(tableId[0].ToString());
                }
                _myDataBase.SqlClose();
                return id;
            }
            catch (Exception exception)
            {

                _error = new Alert.Alert("Error", "مشکل در برقراری ارتباط با پایگاه داده" + ".") { TopMost = true };
                _error.Show();
                throw new ArgumentException("Can not read the table id", exception.InnerException);
            }
        }

        public List<string> FillLocation()
        {
            try
            {
                var location = new List<string>();
                var result = _myDataBase.Select("select ResourceName from resource ");
                while (result.Read())
                {
                    location.Add(result[0].ToString());
                }
                _myDataBase.SqlClose();
                if (location.Count != 0) return location;
                _error = new Alert.Alert("Error", "محلی برای میز ها ثبت نشده است" + ".") { TopMost = true };
                _error.Show();
                return location;
            }
            catch (Exception exception)
            {
                _error = new Alert.Alert("Error", "مشکل در برقراری ارتباط با پایگاه داده" + ".") { TopMost = true };
                _error.Show();
                _myDataBase.SqlClose();
                throw new ArgumentException("Can not read location", exception.InnerException);
            }
           
        }

        public List<string> FillTable()
        {
            try
            {
                var table = new List<string>();
                var result = _myDataBase.Select("SELECT dbo.table_name.name FROM dbo.resource INNER JOIN "+
                                                    " dbo.table_name ON dbo.resource.ID = dbo.table_name.location_id" +
                                                    " WHERE     (dbo.resource.ResourceName = N'" + Location + "')" +
                                                    " and dbo.table_name.isDeleted=N'"+false+"'");
                while (result.Read())
                {
                    table.Add(result[0].ToString());
                }
                _myDataBase.SqlClose();
                if (table.Count != 0) return table;
                _error = new Alert.Alert("Error", " میزی  ثبت نشده است" + ".") { TopMost = true };
                _error.Show();
                _myDataBase.SqlClose();
                return table;
            }
            catch (Exception exception)
            {
                _error = new Alert.Alert("Error", "مشکل در برقراری ارتباط با پایگاه داده" + ".") { TopMost = true };
                _error.Show();
                throw new ArgumentException("Can not read table",  exception.InnerException);
            }

        }

        public SqlDataReader FillInvoiceGrid()
        {
            try
            {
                _myDataBase.SqlClose();
                var result =_myDataBase.Select("SELECT     dbo.resource.ResourceName AS [نام محل], dbo.invoice.location_id," +
                                       " dbo.table_name.name AS [نام میز], dbo.invoice.table_id, dbo.invoice.customer_id" +
                                       " AS [شماره اشتراک], dbo.invoice.id AS [شماره فاکتور], " +
                                       "  dbo.invoice.total AS [جمع کل (ريال)] " +
                                       "   FROM         dbo.invoice INNER JOIN " +
                                       "dbo.table_name ON dbo.invoice.table_id = dbo.table_name.id INNER JOIN " +
                                       "  dbo.resource ON dbo.invoice.location_id = dbo.resource.ID " +
                                       " WHERE     (dbo.invoice.isDeleted = 0) AND " +
                                       "(dbo.invoice.date=N'" + Date + "') ");
                if (result.HasRows)
                {
                    return result;
                }
                _myDataBase.SqlClose();
                return result;
            }
            catch (Exception exception)
            {
                _error = new Alert.Alert("Error", "مشکل در برقراری ارتباط با پایگاه داده" + ".") { TopMost = true };
                _error.Show();
                throw new ArgumentException("Can not fill invoice grid", exception.InnerException);
            }
        }
    }
}