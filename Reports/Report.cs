using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using HomeCafe.DataBase;

namespace HomeCafe.Reports
{
    public class Report
    {
        private readonly IMyDataBase _myDataBase;
        private Alert.Alert _error;
        private bool _checkEmpty;
        private int _catgoryId;
        private int _productId;
        public string Catagory { get; set; }
        public string Product { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public bool Duration { get; set; }
        public bool CatagoryAndProduct { get; set; }
        public bool AllProduct { get; set; }
        public bool WholeSale { get; set; }

        public Report(IMyDataBase myDataBase)
        {
            _myDataBase = myDataBase;
        }
        
        public bool CheckEmptyGrid()
        {
            return _checkEmpty;
        }

        public List<string> FillProduct()
        {
            _catgoryId = GetCatagoryId();
            try
            {
                var product = new List<string>();
                var result = _myDataBase.Select("select name from products where (isDeleted='false' or isDeleted is null) and cat_id=N'" + _catgoryId + "' ");
                while (result.Read())
                {
                    product.Add(result[0].ToString());
                }
                _myDataBase.SqlClose();
                return product;

            }
            catch (Exception exception)
            {
                _error = new Alert.Alert("Error", "مشکل در برقراری ارتباط با پایگاه داده" + ".") { TopMost = true };
                _error.Show();
                _myDataBase.SqlClose();
                throw new ArgumentException("Can not read product", exception.InnerException);
            }
        }

        public List<string> FillCatagory()
        {
            try
            {
                var cataroy = new List<string>();
                var result =_myDataBase.Select("select name,id from catagories where isDeleted='false' or isDeleted is null ");
                while (result.Read())
                {
                    cataroy.Add(result[0].ToString());
                }
                _myDataBase.SqlClose();
                return cataroy;

            }
            catch (Exception exception)
            {
                _error = new Alert.Alert("Error", "مشکل در برقراری ارتباط با پایگاه داده" + ".") { TopMost = true };
                _error.Show();
                _myDataBase.SqlClose();
                throw new ArgumentException("Can not read catagory", exception.InnerException);
            }
        }

        private int GetProductId()
        {
            _catgoryId = GetCatagoryId();
            var result = -1;
            try
            {
                var dr = _myDataBase.Select("select id,name from products where name=N'" + Product + "' and cat_id=N'" + _catgoryId + "'");
                while (dr.Read())
                {
                    if (dr[1].ToString() != Product) continue;
                    result = Convert.ToInt32(dr[0].ToString());
                    break;
                }
                dr.Dispose();
                _myDataBase.SqlClose();
                return result;
            }
            catch
            {
                _error = new Alert.Alert("Error", "مشکل در برقراری ارتباط با پایگاه داده" + ".") { TopMost = true };
                _error.Show();
                return -1;
            } 
        }

        private int GetCatagoryId()
        {
            var result = -1;
            try
            {
                var dr = _myDataBase.Select("select id,name from catagories where name=N'" + Catagory + "'");
                while (dr.Read())
                {
                    if (dr[1].ToString() != Catagory) continue;
                    result = Convert.ToInt32(dr[0].ToString());
                    break;
                }
                dr.Dispose();
                _myDataBase.SqlClose();
                return result;
            }
            catch
            {
                _error = new Alert.Alert("Error", "مشکل در برقراری ارتباط با پایگاه داده" + ".") { TopMost = true };
                _error.Show();
                return -1;
            } 
        }

        public SqlDataReader GetReportByDate()
        {
            try
            {
                var result = _myDataBase.Select("SELECT  dbo.invoice.id AS [شماره فاکتور], dbo.invoice.date AS [تاریخ فاکتور]," +
                                        " dbo.resource.ResourceName AS [نام محل], dbo.table_name.name AS [نام میز], " +
                                        "dbo.invoice.customer_id AS [شماره اشتراک], dbo.invoice.total AS [جمع فاکتور] " +
                                        "FROM  dbo.invoice INNER JOIN dbo.resource ON dbo.invoice.location_id = dbo.resource.ID " +
                                        "INNER JOIN dbo.table_name ON dbo.invoice.table_id = dbo.table_name.id " +
                                        "WHERE (dbo.invoice.payed = 1) AND (dbo.invoice.isDeleted = 0) AND " +
                                        "(dbo.invoice.date= N'" + StartDate + "')");

                if (result.HasRows)
                {
                    _checkEmpty = true;
                    return result;
                }
                _error = new Alert.Alert("Warning", " در این تاریخ محصولی به فروش نرفته است" + ".")
                {
                    TopMost = true
                };
                _error.Show();
                _checkEmpty = false;
                _myDataBase.SqlClose();
                return result;

            }
            catch 
            {
                _error = new Alert.Alert("Error", "مشکل در برقراری ارتباط با پایگاه داده" + ".") { TopMost = true };
                _error.Show();
                _checkEmpty = false;
                return null;
            }
        }

        public SqlDataReader GetReportBySubscribers()
        {
            try
            {
                var result = _myDataBase.Select("SELECT name AS [نام مشترک], subscribe_num AS [شماره اشتراک]," +
                                                " birthday AS [تاریخ تولد], tel AS [تلفن تماس], address AS آدرس " +
                                                "FROM         dbo.subscribe");
                if (result.HasRows)
                {
                    _checkEmpty = true;
                    return result;
                }
                _error = new Alert.Alert("Warning", " تا کنون هیج مشترکی ثبت نشده است" + ".")
                {
                    TopMost = true
                };
                _error.Show();
                _checkEmpty = false;
                _myDataBase.SqlClose();
                return result;
            }
            catch 
            {
                _error = new Alert.Alert("Error", "مشکل در برقراری ارتباط با پایگاه داده" + ".") { TopMost = true };
                _error.Show();
                _checkEmpty = false;
                return null;
            }
        }

        public SqlDataReader GetReportByDebt()
        {
            try
            {
                var result = _myDataBase.Select("SELECT  dbo.vendor.name AS [تامین کننده], SUM(dbo.warehouse_man.expence)" +
                                                " AS [بدهی (ريال)], dbo.vendor.address AS [آدرس تامین کننده],"
                                                    + " dbo.vendor.tel AS [تلفن تماس تامین کننده] "
                                                    + " FROM         dbo.warehouse_man INNER JOIN "
                                                    + " dbo.vendor ON dbo.warehouse_man.vendor_id = dbo.vendor.id "
                                                    + " WHERE     (dbo.warehouse_man.isDeleted = 0) AND" +
                                                    " (dbo.warehouse_man.debt = 1) OR "
                                                    + " (dbo.warehouse_man.isDeleted IS NULL) "
                                                    + " GROUP BY dbo.vendor.name, dbo.vendor.address, dbo.vendor.tel");

                if (result.HasRows)
                {
                    _checkEmpty = true;
                    return result;
                }
                _error = new Alert.Alert("Warning", " تا کنون هیچگونه بدهی ثبت نشده است" + ".")
                {
                    TopMost = true
                };
                _error.Show();
                _checkEmpty = false;
                _myDataBase.SqlClose();
                return result;
            }
            catch
            {
                _error = new Alert.Alert("Error", "مشکل در برقراری ارتباط با پایگاه داده" + ".") { TopMost = true };
                _error.Show();
                _checkEmpty = false;
                return null;
            }
        }

        public SqlDataReader GetReportByProdct()
        {
            _productId = GetProductId();
            try
            {
                if (CatagoryAndProduct)
                {
                    if (!Duration)
                    {
                        var resultCatagoryAndProductWithotDuration
                            = _myDataBase.Select("SELECT TOP (100) PERCENT dbo.catagories.name AS دسته," +
                                                " dbo.products.name AS محصول, SUM(dbo.Item.quantity) AS [تعداد فروش رفته]," +
                                                    " dbo.invoice.date AS [تاریخ فروش] FROM   dbo.Item INNER JOIN"
                                                + " dbo.products ON dbo.Item.product_id = dbo.products.id INNER JOIN "
                                                + " dbo.catagories ON dbo.products.cat_id = dbo.catagories.id INNER JOIN "
                                                + " dbo.invoice ON dbo.Item.Invoice_id = dbo.invoice.id "
                                                + " WHERE     (dbo.invoice.isDeleted = 0) AND (dbo.invoice.payed = 1) "
                                                + " GROUP BY dbo.products.name, dbo.catagories.name, dbo.invoice.date," +
                                                " dbo.Item.product_id  HAVING (dbo.invoice.date = N'" + StartDate + "') " +
                                                " AND (dbo.Item.product_id =N'" + _productId + "') "
                                                + " ORDER BY [تعداد فروش رفته] DESC");
                        if (resultCatagoryAndProductWithotDuration.HasRows)
                        {
                            _checkEmpty = true;
                            return resultCatagoryAndProductWithotDuration;
                        }
                        _error = new Alert.Alert("Warning", "این محصول در این تاریخ به فروش نرفته است" + ".")
                        {
                            TopMost = true
                        };
                        _error.Show();
                        _checkEmpty = false;
                        _myDataBase.SqlClose();
                        return resultCatagoryAndProductWithotDuration;
                    }

                    var resultCatagoryAndProductDuration =
                        _myDataBase.Select("SELECT     TOP (100) PERCENT dbo.catagories.name AS دسته, dbo.products.name AS محصول," +
                                           " SUM(dbo.Item.quantity) AS [تعداد فروش رفته], dbo.invoice.date AS [تاریخ فروش]"
                                            + " FROM  dbo.Item INNER JOIN dbo.products ON dbo.Item.product_id =" +
                                            " dbo.products.id INNER JOIN dbo.catagories ON dbo.products.cat_id =" +
                                            " dbo.catagories.id INNER JOIN  dbo.invoice ON dbo.Item.Invoice_id = " +
                                            " dbo.invoice.id  WHERE (dbo.invoice.isDeleted = 0) AND (dbo.invoice.payed = 1) "
                                            + " GROUP BY dbo.products.name, dbo.catagories.name, dbo.invoice.date, " +
                                            "dbo.invoice.date, dbo.Item.product_id HAVING  (dbo.invoice.date" +
                                            " between N'" + StartDate + "' and N'" + EndDate + "')" +
                                            " AND (dbo.Item.product_id =N'" + _productId + "') "
                                            + " ORDER BY [تعداد فروش رفته] DESC");

                    if (resultCatagoryAndProductDuration.HasRows)
                    {
                        _checkEmpty = true;
                        return resultCatagoryAndProductDuration;
                    }
                    _error = new Alert.Alert("Warning", "این محصول در این بازه به فروش نرفته است" + ".")
                    {
                        TopMost = true
                    };
                    _error.Show();
                    _checkEmpty = false;
                    _myDataBase.SqlClose();
                    return resultCatagoryAndProductDuration;
                }

                if (AllProduct)
                {
                    if (!Duration)
                    {
                        var resultAllProductWithoutDuration =
                             _myDataBase.Select("SELECT  TOP (100) PERCENT dbo.catagories.name AS دسته, " +
                                              "dbo.products.name AS محصول, SUM(dbo.Item.quantity) AS [تعداد فروش رفته], " +
                                              "dbo.invoice.date AS [تاریخ فروش] FROM         dbo.Item INNER JOIN"
                                            + " dbo.products ON dbo.Item.product_id = dbo.products.id INNER JOIN"
                                            + " dbo.catagories ON dbo.products.cat_id = dbo.catagories.id INNER JOIN"
                                            + " dbo.invoice ON dbo.Item.Invoice_id = dbo.invoice.id"
                                            + " WHERE     (dbo.invoice.isDeleted = 0) AND (dbo.invoice.payed = 1)"
                                            + " GROUP BY dbo.products.name, dbo.catagories.name, dbo.invoice.date," +
                                            " dbo.Item.quantity HAVING (dbo.invoice.date = N'" + StartDate + "') "
                                            + " ORDER BY  [تعداد فروش رفته] DESC");

                        if (resultAllProductWithoutDuration.HasRows)
                        {
                            _checkEmpty = true;
                            return resultAllProductWithoutDuration;
                        }
                        _error = new Alert.Alert("Warning", "این محصول در این تاریخ به فروش نرفته است" + ".")
                        {
                            TopMost = true
                        };
                        _error.Show();
                        _checkEmpty = false;
                        _myDataBase.SqlClose();
                        return resultAllProductWithoutDuration;
                    }
                    
                    var resultAllProductDuration =
                         _myDataBase.Select("SELECT TOP (100) PERCENT dbo.catagories.name AS دسته, dbo.products.name AS محصول," +
                                            " SUM(dbo.Item.quantity) AS [تعداد فروش رفته], dbo.invoice.date AS [تاریخ فروش]"
                                            + " FROM         dbo.Item INNER JOIN dbo.products ON dbo.Item.product_id " +
                                            "= dbo.products.id INNER JOIN dbo.catagories ON dbo.products.cat_id = " +
                                            "dbo.catagories.id INNER JOIN dbo.invoice ON dbo.Item.Invoice_id = dbo.invoice.id"
                                            + " WHERE     (dbo.invoice.isDeleted = 0) AND (dbo.invoice.payed = 1)"
                                            + " GROUP BY dbo.products.name, dbo.catagories.name, dbo.invoice.date," +
                                            " dbo.Item.quantity HAVING (dbo.invoice.date between N'" + StartDate + "'" +
                                            " and N'" + EndDate + "')  ORDER BY  [تعداد فروش رفته] DESC");
                    if (resultAllProductDuration.HasRows)
                    {
                        _checkEmpty = true;
                        return resultAllProductDuration;
                    }
                    _error = new Alert.Alert("Warning", "این محصول در این بازه به فروش نرفته است" + ".")
                    {
                        TopMost = true
                    };
                    _error.Show();
                    _checkEmpty = false;
                    _myDataBase.SqlClose();
                    return resultAllProductDuration;
                }
                if (WholeSale)
                {
                    var resultWholeSale =
                        _myDataBase.Select("SELECT     dbo.catagories.name AS دسته, dbo.products.name AS محصول, " +
                                          "SUM(dbo.Item.quantity) AS [تعداد فروش رفته]  FROM     dbo.Item INNER JOIN "
                                        + "     dbo.products ON dbo.Item.product_id = dbo.products.id INNER JOIN "
                                        + "    dbo.catagories ON dbo.products.cat_id = dbo.catagories.id  INNER JOIN "
                                        + "   dbo.invoice ON dbo.Item.Invoice_id = dbo.invoice.id "
                                        + "WHERE     (dbo.invoice.isDeleted = 0) AND (dbo.invoice.payed = 1)"
                                        + "   GROUP BY dbo.products.name, dbo.catagories.name");
                    if (resultWholeSale.HasRows)
                    {
                        _checkEmpty = true;
                        return resultWholeSale;
                    }
                    _error = new Alert.Alert("Warning", "هیچی محصول تا کنون به فروش نرفته است" + ".")
                    {
                        TopMost = true
                    };
                    _error.Show();
                    _checkEmpty = false;
                    _myDataBase.SqlClose();
                    return resultWholeSale;
                }
            }
            catch
            {
                _error = new Alert.Alert("Error", "مشکل در برقراری ارتباط با پایگاه داده" + ".") { TopMost = true };
                _error.Show();
                _checkEmpty = false;
                return null;
            }
            return null;
        }

        public SqlDataReader GetReportBySellingCatagories()
        {

            try
            {
                _catgoryId = GetCatagoryId();
                if (_catgoryId == -1)
                {
                    _error = new Alert.Alert("Error", "مشکل در برقراری ارتباط با پایگاه داده" + ".") { TopMost = true };
                    _error.Show();
                    _checkEmpty = false;
                    return null;
                }
                if (!Duration)
                {
                    var result =
                        _myDataBase.Select("SELECT  TOP (5) dbo.catagories.name AS دسته, dbo.products.name AS محصول, " +
                                           "dbo.invoice.date AS [تاریخ فروش], SUM(dbo.Item.quantity) AS [تعداد فروش رفته]"
                                           + " FROM         dbo.Item INNER JOIN "
                                           + " dbo.products ON dbo.Item.product_id = dbo.products.id INNER JOIN"
                                           + " dbo.catagories ON dbo.products.cat_id = dbo.catagories.id INNER JOIN "
                                           + " dbo.invoice ON dbo.Item.Invoice_id = dbo.invoice.id "
                                           + " WHERE     (dbo.invoice.isDeleted = 0) AND (dbo.invoice.payed = 1) "
                                           + " GROUP BY dbo.products.name, dbo.catagories.name," +
                                           " dbo.Item.product_id, dbo.products.cat_id, dbo.invoice.date "
                                           + " HAVING      (dbo.products.cat_id = N'" + _catgoryId + "')" +
                                           " AND (dbo.invoice.date = N'" + StartDate + "') "
                                           + " ORDER BY [تعداد فروش رفته] DESC");

                    if (result.HasRows)
                    {
                        _checkEmpty = true;
                        return result;
                    }
                    _error = new Alert.Alert("Warning", "این دسته در این تاریخ به فروش نرفته است" + ".")
                    {
                        TopMost = true
                    };
                    _error.Show();
                    _checkEmpty = false;
                    _myDataBase.SqlClose();
                    return result;
                }

                if (Duration)
                {
                    var result =
                        _myDataBase.Select("SELECT  TOP (5) dbo.catagories.name AS دسته, dbo.products.name AS محصول, dbo.invoice.date AS [تاریخ فروش], SUM(dbo.Item.quantity) AS [تعداد فروش رفته]"
                                           + " FROM         dbo.Item INNER JOIN "
                                           + " dbo.products ON dbo.Item.product_id = dbo.products.id INNER JOIN"
                                           + " dbo.catagories ON dbo.products.cat_id = dbo.catagories.id INNER JOIN "
                                           + " dbo.invoice ON dbo.Item.Invoice_id = dbo.invoice.id "
                                           + " WHERE     (dbo.invoice.isDeleted = 0) AND (dbo.invoice.payed = 1) "
                                           +
                                           " GROUP BY dbo.products.name, dbo.catagories.name, dbo.Item.product_id, dbo.products.cat_id, dbo.invoice.date "
                                           + " HAVING      (dbo.products.cat_id = N'" + _catgoryId +
                                           "') AND (dbo.invoice.date between N'" + StartDate + "' and N'" + EndDate +
                                           "')  ORDER BY [تعداد فروش رفته] DESC");

                    if (result.HasRows)
                    {
                        _checkEmpty = true;
                        return result;
                    }
                    _error = new Alert.Alert("Warning",  "این دسته در این بازه به فروش نرفته است" + ".")
                    {
                        TopMost = true
                    };
                    _error.Show();
                    _checkEmpty = false;
                    _myDataBase.SqlClose();
                    return result;
                }
            }
            catch
            {
                _error = new Alert.Alert("Error", "مشکل در برقراری ارتباط با پایگاه داده" + ".") { TopMost = true };
                _error.Show();
                _checkEmpty = false;
                return null;
            }
            return null;
        }
    }
}
