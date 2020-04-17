using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using HomeCafe.DataBase;
using HomeCafe.My_Custom_Classes;
using Telerik.WinControls.UI;

namespace HomeCafe.Cashier
{
    public class Items
    {
        private readonly IMyDataBase _myDataBase;
        private int _invoiceId;
        private Alert.Alert _error;
        public string PriceToPay { get; set; }
        public bool SavedInvoice { get; set; }
        public string CostumerName { get; set; }
        public int InvoiceId { get; set; }
        private RadGridView _invoice;
        private readonly Font _font = new Font("IRANSansDNFaNum", 10.0f, FontStyle.Regular);
        private readonly Font _printFont = new Font("IRANSansDNFaNum", 9.0f, FontStyle.Regular);

       
        public Items(IMyDataBase myDataBase)
        {
            _myDataBase = myDataBase;
        }

        public SqlDataReader FillItemGrid()
        {
            try
            {
               var result = _myDataBase.Select("SELECT dbo.catagories.name AS دسته, dbo.products.name AS محصول," +
                                                " dbo.products.price AS [قیمت واحد (ريال)], dbo.Item.quantity AS تعداد, " +
                                                " dbo.products.size AS سایز FROM    dbo.Item INNER JOIN " +
                                                " dbo.products ON dbo.Item.product_id = dbo.products.id INNER JOIN " +
                                                "  dbo.catagories ON dbo.products.cat_id = dbo.catagories.id " +
                                                "   WHERE     (dbo.Item.Invoice_id =N'" + InvoiceId + "')");
                if (result.HasRows)
                {
                    return result;
                }
                _myDataBase.SqlClose();
                return result;
            }
            catch (Exception exception)
            {

                _error = new Alert.Alert("Error", "." + "مشکل در برقراری ارتباط با پایگاه داده") { TopMost = true };
                _error.Show();
                throw new ArgumentException("Can not read the invoice id", exception.InnerException);
            }
        }

        private int GetInvoiceId()
        {
            try
            {
                var result = _myDataBase.Select("select top (1) id from invoice order by id desc");
                var invoiceId = -1;
                while (result.Read())
                {
                    invoiceId = int.Parse(result[0].ToString());

                }
                _myDataBase.SqlClose();
                return invoiceId;
            }
            catch (Exception exception)
            {
                _error = new Alert.Alert("Error", "مشکل در برقراری ارتباط با پایگاه داده" + ".") { TopMost = true };
                _error.Show();
                throw new ArgumentException("Can not read the invoice id", exception.InnerException);
            }
        }

        public void Save(int productId, int quantity)
        {
            try
            {
                _invoiceId = GetInvoiceId();
                var result = _myDataBase.Insert("Insert into Item (Invoice_id,product_id,quantity)" +
                                   " values (N'" + _invoiceId + "',N'" + productId + "'" +
                                   ",N'" + quantity + "')");
                _myDataBase.SqlClose();
                if (result) return;
                _error = new Alert.Alert("Error", "در حال حاضر امکان ذخیره فاکتور وجود ندارد" + ".") { TopMost = true };
                _error.Show();
            }
            catch (Exception exception)
            {
                _error = new Alert.Alert("Error", "مشکل در برقراری ارتباط با پایگاه داده" + ".") { TopMost = true };
                _error.Show();
                _myDataBase.SqlClose();
                throw new ArgumentException("Can not save items", exception.InnerException);
            }
        }

        public void Print(RadGridView invoice)
        {
            _invoice = invoice;
            try
            {
                _invoice.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.None;
                _invoice.PrintStyle.FitWidthMode = PrintFitWidthMode.FitPageWidth;
                _invoiceId = GetInvoiceId();
                if (CostumerName.Length <= 0)
                {
                    CostumerName = "فاقد اشتراک";
                }
                PrintDialogsLocalizationProvider.CurrentProvider = new PersianDialogsLocalizationProvider();
                
                var doc = new MyPrintDocument
                {
                    Margins =
                    {
                      Top  = 0,
                      Left = 2,
                      Right = 2
                    },
                    FooterFont = _printFont,
                    FooterHeight = 30,
                    MiddleFooter = "آورین",
                    HeaderHeight = 60,
                    HeaderFont =_printFont,
                    LeftHeader = string.Format("جمع کل: {0}", PriceToPay),
                    RightUpperFont = _printFont,
                    RightUpperText = "نرم افزار مدیریت کافه و رستوران",
                    RightMiddleFont = _printFont,
                    RightMiddleText = string.Format("{0} : شماره فاکتور", _invoiceId),
                    
                    RightLowerFont = _printFont,
                    RightLowerText = string.Format(" نام مشتری: {0}", CostumerName),
                    //MiddleHeader = "Middle header",
                    //RightHeader = "Right header",
                    AssociatedObject = _invoice,
                    PaperSize =
                    {
                        PaperName = "80 X roll paper",
                        Width = 3149
                    },
                    Landscape = false,
                    
                };

                doc.BeginPrint += invoicePrint_BeginPrint;
                doc.EndPrint += invoicePrint_EndPrint;

                var dialog = new RadPrintPreviewDialog(doc)
                {
                    Document = doc,
                    ThemeName = "TelerikMetro",
                    FormElement =
                    {
                        Font = _font,
                        RightToLeft = true
                    },
                    RightToLeft = RightToLeft.Yes,
                    Font = _font

                };
               
              
                dialog.SetZoom(1);
               
                var style = new GridPrintStyle
                {
                    FitWidthMode = PrintFitWidthMode.FitPageWidth,
                    HeaderCellBackColor = Color.White,
                    CellFont = new Font("IRANSansDNFaNum", 8.0f, FontStyle.Regular),
                    HeaderCellFont = _printFont
                };
                _invoice.PrintStyle = style;

                style.PrintCellFormatting += style_PrintCellFormatting;
                //invoicePrint.Print();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    doc.Print();
                }
            }
            catch (Exception exception)
            {
                _error = new Alert.Alert("Error", "مشکل در برقراری ارتباط با چاپگر" + ".") { TopMost = true };
                _error.Show();
                throw new InvalidOperationException("Can not connect to printer.", exception.InnerException);
            }
            

        }
        private void style_PrintCellFormatting(object sender, PrintCellFormattingEventArgs e)
        {
            if (!(e.Row is GridViewTableHeaderRowInfo))
            {

                e.PrintCell.Font = new Font("IRANSansDNFaNum", 8.0f, FontStyle.Regular);

            }
            if (e.Row is GridViewTableHeaderRowInfo && _invoice.RightToLeft == RightToLeft.Yes)
            {
                e.PrintCell.TextAlignment = ContentAlignment.TopCenter;
            }

        }

        private void invoicePrint_EndPrint(object sender, PrintEventArgs e)
        {
            for (var start = _invoice.Columns.Count - 1; start >= 0; start--)
            {
                if (start == 0 || start == 5)
                {

                    _invoice.Columns[start].IsVisible = true;

                }
            }
            _invoice.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;
        }

        private void invoicePrint_BeginPrint(object sender, PrintEventArgs e)
        {
            _invoice.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.None;
            for (var start = _invoice.Columns.Count - 1; start >= 0; start--)
            {
                if (start == 0 || start == 5)
                {
                    _invoice.Columns[start].IsVisible = false;
                    _invoice.Columns[start].AutoSizeMode = BestFitColumnMode.DisplayedCells;
                }
                //_invoice.Columns[start].BestFit();
               
                   
            }
            foreach (var col in _invoice.Columns)
            {
                col.HeaderTextAlignment = ContentAlignment.TopCenter;
            }
        }


    }
    

}