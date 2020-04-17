using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.Windows.Forms;
using HomeCafe.DataBase;
using HomeCafe.My_Custom_Classes;
using Telerik.WinControls;
using Telerik.WinControls.Data;
using Telerik.WinControls.UI;
using Telerik.WinControls.UI.Localization;

namespace HomeCafe.Cashier
{
    public partial class FrmFactors : Form
    {
        private readonly IFixLanguageAndForms _fixLanguageAndForms;
        private readonly IInputValidation _inputValidation;
        Alert.Alert _error;
        private readonly Font _font = new Font("IRANSansDNFaNum", 10.0f, FontStyle.Regular);

        public static int Loader = 1;
        private int _total;

        public FrmFactors(IFixLanguageAndForms fixLanguageAndForms, IInputValidation inputValidation)
        {
            _fixLanguageAndForms = fixLanguageAndForms;
            _inputValidation = inputValidation;
            InitializeComponent();
            RadGridLocalizationProvider.CurrentProvider = new MyPersianRadGridLocalizationProvider();
            Grid_Products.ColumnChooser.Shown += ColumnChooser_Shown;
            Grid_Products.MasterTemplate.AutoExpandGroups = false;
            Grid_Factor.ColumnChooser.Shown += ColumnChooser_Shown;
            txt_FactorDate.Culture = PersianCultureHelper.GetFixedPersianCulture();
            txt_FactorDate.Enabled = false;
            txt_FactorDate.DateTimePickerElement.Calendar.FocusedDate = DateTime.Now;
            txt_FactorDate.Value = DateTime.Today;
            radTimePicker1.Value = DateTime.Now;
            radTimePicker1.Culture = PersianCultureHelper.GetFixedPersianCulture();
           
        }

        private void ColumnChooser_Shown(object sender, EventArgs e)
        {
            Grid_Products.ColumnChooser.ColumnChooserControl.ColumnChooserElement.Font = _font;
            Grid_Factor.ColumnChooser.ColumnChooserControl.ColumnChooserElement.Font = _font;
        }

        private void frm_Factors_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'factorDataSet.factor' table. You can move, or remove it, as needed.
            factorTableAdapter.Fill(factorDataSet.factor);
            try
            {
                combo_TableName.Enabled = false;
                var factor = new Factors(new MyDatabase());
                combo_LocationName.DataSource = factor.FillLocation();
                combo_LocationName.SelectedIndex = -1;
               
                if (Grid_Products.Columns.Count <= 0) return;
                var descriptor = new GroupDescriptor();
                descriptor.GroupNames.Add("نام دسته", ListSortDirection.Ascending);
                Grid_Products.GroupDescriptors.Add(descriptor);

                Grid_Products.HeaderCellToggleStateChanged += Grid_Products_HeaderCellToggleStateChanged;
            }
            catch
            {
                _error = new Alert.Alert("Error", "مشکل در برقراری ارتباط با پایگاه داده" + ".") {TopMost = true};
                _error.Show();
            }
        }

        private void Grid_Products_HeaderCellToggleStateChanged(object sender, GridViewHeaderCellEventArgs e)
        {
            if (Loader != 1) return;
            foreach (var row in ((GridDataView)Grid_Products.MasterTemplate.DataView).Indexer.Items)
            {
                row.Cells[1].Value = true;
                row.Cells[1].Value = false;
            }
            Loader++;
        }

        private void combo_LocationName_TextChanged(object sender, EventArgs e)
        {
           
            combo_LocationName.DropDownListElement.AutoCompleteSuggest.SuggestMode = SuggestMode.Contains;
            if (combo_LocationName.Items.Contains(combo_LocationName.Text.Trim()))
            {
                var factor = new Factors(new MyDatabase())
                {
                    Location = combo_LocationName.Text
                };
                combo_TableName.DataSource = factor.FillTable();
                combo_TableName.SelectedIndex = -1;

                combo_TableName.Enabled = true;
               
            }
            else
            {
                combo_TableName.Enabled = false;

            }
        }

        private void combo_LocationName_Enter(object sender, EventArgs e)
        {
            _fixLanguageAndForms.FixLanguage();
        }

        private void combo_LocationName_Leave(object sender, EventArgs e)
        {
           _fixLanguageAndForms.OriginalLanguage();
        }

        private void Grid_Products_GroupSummaryEvaluate(object sender, GroupSummaryEvaluationEventArgs e)
        {
            e.FormatString = string.Format("{0}", e.Value);
        }

        private void Grid_Products_ColumnChooserItemElementCreating(object sender, ColumnChooserItemElementCreatingEventArgs e)
        {
            e.ItemElement.Font = _font;
            e.GridViewElement.Font = _font;
        }

        private void Grid_Products_ConditionalFormattingFormShown(object sender, EventArgs e)
        {
            var form = (ConditionalFormattingForm)sender;
            SetFormFont(form.Controls);
        }
        static Font f = new Font("IRANSansDNFaNum", 9.0f, FontStyle.Regular);
        private static void SetFormFont(IEnumerable controls)
        {
            foreach (Control c in controls)
            {
                c.Font = f;
                if (c.HasChildren)
                {
                    SetFormFont(c.Controls);
                }
            }

        }

        private void Grid_Products_ContextMenuOpening(object sender, ContextMenuOpeningEventArgs e)
        {
            for (var i = 0; i < e.ContextMenu.Items.Count; i++)
            {
                e.ContextMenu.Items[i].Font = _font;

                if (e.ContextMenu.Items[i].Text == @"حالت متصل شده")
                {
                    e.ContextMenu.Items[i].Visibility = ElementVisibility.Collapsed;
                }

            }
        }

        private void Grid_Products_CreateCell(object sender, GridViewCreateCellEventArgs e)
        {
            if (e.CellType == typeof(GridHeaderCellElement))
            {
                e.CellType = typeof(CustomHeaderCell);
            }
            if (e.CellType == typeof(GridHeaderCellElement))
            {

                e.CellType = typeof(CustomGridHeaderCellElement);

            }
        }

        private void Grid_Products_ViewCellFormatting(object sender, CellFormattingEventArgs e)
        {
            e.CellElement.Font = _font;
        }


        private void combo_TableName_TextChanged(object sender, EventArgs e)
        {
            Grid_Products.Enabled = combo_TableName.Items.Contains(combo_TableName.Text.Trim());
        }

        private void Grid_Factor_ColumnChooserItemElementCreating(object sender, ColumnChooserItemElementCreatingEventArgs e)
        {
            e.ItemElement.Font = _font;
            e.GridViewElement.Font = _font;
        }

        private void Grid_Factor_ConditionalFormattingFormShown(object sender, EventArgs e)
        {
            var form = (ConditionalFormattingForm)sender;
            SetFormFont(form.Controls);
        }

        private void Grid_Factor_ContextMenuOpening(object sender, ContextMenuOpeningEventArgs e)
        {
            for (var i = 0; i < e.ContextMenu.Items.Count; i++)
            {
                e.ContextMenu.Items[i].Font = _font;

                if (e.ContextMenu.Items[i].Text == @"حالت متصل شده")
                {
                    e.ContextMenu.Items[i].Visibility = ElementVisibility.Collapsed;
                }

            }
        }

        private void Grid_Factor_CreateCell(object sender, GridViewCreateCellEventArgs e)
        {
            if (e.CellType == typeof(GridHeaderCellElement))
            {
                e.CellType = typeof(CustomHeaderCell);
            }
            if (e.CellType == typeof(GridHeaderCellElement))
            {

                e.CellType = typeof(CustomGridHeaderCellElement);

            }
        }

        private void Grid_Factor_ViewCellFormatting(object sender, CellFormattingEventArgs e)
        {
            e.CellElement.Font = _font;
        }

        private void PageView_Factors_SelectedPageChanged(object sender, EventArgs e)
        {
            Grid_Factor.Rows.Clear();

            try
            {
                var i = 1;

                if (PageView_Factors.SelectedPage != PageViewPage_Factor) return;
                
                var factor = new Factors(new MyDatabase());
                combo_Subscriber.DataSource = factor.GetSubscribeName();
                combo_Subscriber.SelectedIndex = -1;

                _total = 0;

                foreach (var row in ((GridDataView)Grid_Products.MasterTemplate.DataView).Indexer.Items)
                {
                    if (!row.Cells[1].Value.Equals(true)) continue;

                    var rowInfo = new GridViewDataRowInfo(Grid_Factor.MasterView);
                    rowInfo.Cells["Row"].Value = i.ToString();
                    rowInfo.Cells["Catagories"].Value = row.Cells["نام دسته"].Value.ToString();
                    rowInfo.Cells["Products"].Value = row.Cells[3].Value.ToString();                         
                    rowInfo.Cells["Price"].Value = int.Parse(row.Cells[" قیمت (ریال)"].Value.ToString());
                    if (row.Cells["Number"].Value != null)
                        rowInfo.Cells["Numbers"].Value = row.Cells["Number"].Value.ToString();
                    else
                        rowInfo.Cells["Numbers"].Value = 1;
                    rowInfo.Cells["Discription"].Value = row.Cells["Discription"].Value != null ? row.Cells["Discription"].Value.ToString() : null;
                    rowInfo.Cells["id"].Value = row.Cells["id"].Value.ToString();

                    Grid_Factor.Rows.Add(rowInfo);

                    _total += int.Parse(row.Cells[" قیمت (ریال)"].Value.ToString()) * int.Parse(rowInfo.Cells["Numbers"].Value.ToString());
                    i++;
                }
                
                txt_PriceToPay.Text = _total.ToString();

                txt_Price.Text = _total.ToString();
                txt_Discount.Text = null;
                combo_Subscriber.Text = "";
                txt_SubscriberName.Text = null;
                txt_SubscriberPhone.Text = null;
                txt_SubscriberAddress.Text = null;
            
                if (Grid_Factor.RowCount > 0)
                {
                    btn_Print.Enabled = true;
                    btn_Save.Enabled = true;
                    btn_KitchenPrint.Enabled = true;
                }
                else
                {
                    btn_Print.Enabled = false;
                    btn_Save.Enabled = false;
                    btn_KitchenPrint.Enabled = false;
                }
            }
            catch (Exception exception)
            {
                _error = new Alert.Alert("Error", "مشکل در بروز رسانی فاکتور" + ".") { TopMost = true };
                _error.Show();
                throw new ArgumentException(exception.Message);
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            var factor = new Factors(new MyDatabase())
            {
                Location = combo_LocationName.Text.Trim(),
                Price = Convert.ToInt32(txt_Price.Text.Trim()),
                PriceToPay = Convert.ToInt32(txt_PriceToPay.Value),
                Table = combo_TableName.Text.Trim(),
                SubscribeNumber = combo_Subscriber.Text.Trim(),
                Date = txt_FactorDate.Text,
                IsPayed = ckb_Payed.Checked
            };
            var result = factor.Save();
            if (!result) return;

            var invoiceItems = new Items(new MyDatabase());
           
            foreach (var row in ((GridDataView)Grid_Factor.MasterTemplate.DataView).Indexer.Items)
            {
                invoiceItems.Save(Convert.ToInt32(row.Cells["id"].Value.ToString()), Convert.ToInt32(row.Cells["Numbers"].Value.ToString()));
            }

            btn_Save.Enabled = false;

            Alert_Factor.CaptionText = "توجه";
            Alert_Factor.ContentText = "." + "فاکتور با موفقیت ثبت شد";
            Alert_Factor.Popup.AlertElement.ContentElement.Font = _font;
            Alert_Factor.Popup.AlertElement.CaptionElement.TextAndButtonsElement.TextElement.Font = _font;
            Alert_Factor.Popup.AlertElement.ContentElement.TextAlignment = ContentAlignment.MiddleRight;
            Alert_Factor.Popup.AlertElement.CaptionElement.TextAndButtonsElement.TextAlignment = ContentAlignment.TopRight;
            Alert_Factor.Show();
        }

        private void txt_Discount_TextChanging(object sender, TextChangingEventArgs e)
        {

            if (txt_Price.Text != "" && txt_Discount.Text != "")
            {
                var price = float.Parse(txt_Price.Text);
                var discount = float.Parse(txt_Discount.Text);
                if (discount >= 100)
                    discount = 100;
                var priceToPay = price - price * (discount / 100);
                txt_PriceToPay.Text = priceToPay.ToString(CultureInfo.CurrentCulture);
                txt_PriceToPay.Value = (decimal)priceToPay;
            }
           
            else if (txt_Discount.Text == "" && txt_Price.Text != "")
            {

                txt_Discount.Text = @"0";
                txt_PriceToPay.Text = txt_Price.Text;
                txt_PriceToPay.Value = Convert.ToDecimal(txt_Price.Text);
            }

        }
        private void txt_Price_TextChanging(object sender, TextChangingEventArgs e)
        {
            if (txt_Price.Text.Length > 20) return;
            if (txt_Price.Text != "" && txt_Discount.Text != "")
            {

                var price = float.Parse(txt_Price.Text);
                var discount = float.Parse(txt_Discount.Text);
                if (discount >= 100)
                    discount = 100;
                var priceToPay = price - price * (discount / 100);
                txt_PriceToPay.Text = priceToPay.ToString(CultureInfo.CurrentCulture);
                txt_PriceToPay.Value = (decimal) priceToPay;
            }
            
            else if (txt_Discount.Text == "" && txt_Price.Text != "")
            {

                txt_Discount.Text = @"0";
                txt_PriceToPay.Text = txt_Price.Text;
                txt_PriceToPay.Value = Convert.ToDecimal(txt_Price.Text);
            }
            else if (txt_Price.Text == "")
            {
                txt_PriceToPay.Text = _total.ToString();
                txt_PriceToPay.Value = _total;
            }

        }

        private void txt_Price_TextChanged(object sender, EventArgs e)
        {
            if (txt_Price.Text.Length > 20) return;
            if (txt_Price.Text.Length == 0)
            {
                txt_PriceToPay.Text = _total.ToString();
                txt_PriceToPay.Value = _total;

                txt_Price.Text = _total.ToString();

            }
            else if (txt_Price.Text.Length > 0)
            {
                txt_PriceToPay.Text = txt_Price.Text;
                txt_PriceToPay.Value = Convert.ToDecimal(txt_Price.Text);
            }
        }

        private void btn_Print_Click(object sender, EventArgs e)
        {
            var invocie = new Items(new MyDatabase())
            {
                PriceToPay = txt_PriceToPay.Text.Trim(),
                SavedInvoice = true,
                CostumerName = txt_SubscriberName.Text.Trim()
            };
            invocie.Print(Grid_Factor);
           
        }

        private void combo_Subscriber_TextChanged(object sender, EventArgs e)
        {
              combo_Subscriber.DropDownListElement.AutoCompleteSuggest.SuggestMode = SuggestMode.Contains;
              if (combo_Subscriber.Items.Contains(combo_Subscriber.Text.Trim()))
              {
                  var factor = new Factors(new MyDatabase()) 
                  {
                      SubscribeNumber = combo_Subscriber.Text.Trim()
                  };

                  var subscribeDetails = factor.FillSubscriber();

                  txt_SubscriberName.Text = subscribeDetails[0];
                  txt_SubscriberPhone.Text = subscribeDetails[1];
                  txt_SubscriberAddress.Text = subscribeDetails[2];
              }
              else
              {
                  txt_SubscriberName.Text = null;
                  txt_SubscriberPhone.Text = null;
                  txt_SubscriberAddress.Text = null;
              }
        }

        private void txt_Price_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txt_Price.Text.Length == 20) {e.Handled= true ;}
             _inputValidation.DigitOnly(e);
        }

        private void txt_Discount_KeyPress(object sender, KeyPressEventArgs e)
        {
            _inputValidation.DigitOnly(e);
        }

        private void btn_KitchenPrint_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    MyDatabase db_findinoviceid = new MyDatabase();
            //    SqlDataReader dr_findinoviceid;
            //    dr_findinoviceid = db_findinoviceid.Select("select top (1) id from invoice order by id desc");

            //    while (dr_findinoviceid.Read())
            //    {
            //        inovice_id = Int32.Parse(dr_findinoviceid[0].ToString());

            //    }
            //    db_findinoviceid.Conn.Close();
            //    db_findinoviceid.Conn.Dispose();
            //    dr_findinoviceid.Close();
            //    dr_findinoviceid.Dispose();
            //}
            //catch
            //{


            //}

            //try
            //{
            //    PrintDialogsLocalizationProvider.CurrentProvider = new PersianDialogsLocalizationProvider();

            //    radPrintDocument2.AssociatedObject = Grid_Factor;
            //    Grid_Factor.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.None;



            //    MyPrintDocument doc = new MyPrintDocument();
            //    doc.HeaderHeight = 30;
            //    doc.HeaderFont = new Font("IRANSansDNFaNum", 9.0f, FontStyle.Regular);
            //    doc.LeftHeader = string.Format("جمع کل: {0}", txt_PriceToPay.Text);
            //    doc.MiddleHeader = "Middle header";
            //    doc.RightHeader = "Right header";


            //    doc.AssociatedObject = Grid_Factor;
            //    doc.PaperSize.PaperName = "X roll 80mm";





            //    this.radPrintDocument1.DefaultPageSettings.Landscape = true;
            //    Grid_Factor.PrintStyle.FitWidthMode = PrintFitWidthMode.FitPageWidth;
            //    RadPrintPreviewDialog dialog = new RadPrintPreviewDialog(doc);

            //    dialog.Document = radPrintDocument2;
            //    dialog.ThemeName = "TelerikMetro";
            //    dialog.SetZoom(1);
            //    dialog.Document.LeftFooter = string.Format("جمع کل: {0}", txt_PriceToPay.Text);

            //    dialog.Document.Logo = new Bitmap(HomeCafe.Properties.Resources.home_cafe_tablo12);
            //    dialog.Document.LeftHeader = string.Format("{0}", radTimePicker1.Value.Value.ToShortTimeString());
            //    if (flag)
            //    {
            //        dialog.Document.MiddleHeader = string.Format("شماره فاکتور:{0}", inovice_id);
            //    }
            //    else
            //    {
            //        dialog.Document.MiddleHeader = string.Format("شماره فاکتور:{0}", inovice_id + 1);
            //    }
            //    dialog.Document.MiddleHeader = "[Logo]";
            //    dialog.Document.RightHeader = string.Format("{0} : {1}", combo_LocationName.Text, combo_TableName.Text);
            //    dialog.Document.HeaderFont = new Font("IRANSansDNFaNum", 9.0f, FontStyle.Regular);
            //    dialog.Document.HeaderHeight = 25;

            //    dialog.FormElement.Font = _font;
            //    dialog.RightToLeft = RightToLeft.Yes;
            //    dialog.Font = _font;
            //    GridPrintStyle style = new GridPrintStyle
            //    {
            //        FitWidthMode = PrintFitWidthMode.FitPageWidth,
            //        HeaderCellBackColor = Color.White,
            //        CellFont = new Font("IRANSansDNFaNum", 9.0f, FontStyle.Regular),
            //        HeaderCellFont = new Font("IRANSansDNFaNum", 9.0f, FontStyle.Regular)
            //    };
            //    Grid_Factor.PrintStyle = style;

            //    style.PrintCellFormatting += style_PrintCellFormatting;


            //    radPrintDocument2.Print();


            //    if (dialog.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            //    {
            //        this.radPrintDocument1.Print();
            //    }
            //}
            //catch
            //{

            //    _error = new Alert.Alert("Error", "." + "از ارتباط چاپگر با کامپیوتر اطمینان حاصل کنید")
            //    {
            //        TopMost = true
            //    };
            //    _error.Show();
            //}
           
           

        }

        private void radPrintDocument2_BeginPrint(object sender, PrintEventArgs e)
        {
            Grid_Factor.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.None;
            for (int start = Grid_Factor.Columns.Count - 1; start >= 0; start--)
            {
                if (start == 0 || start == 3)
                {
                    Grid_Factor.Columns[start].IsVisible = false;
                    //this.Grid_Factor.Columns[start].BestFit();
                }
                Grid_Factor.Columns[start].BestFit();
            }
            foreach (var col in Grid_Factor.Columns)
            {
                col.HeaderTextAlignment = ContentAlignment.TopCenter;
                col.BestFit();
            }
        }

        private void radPrintDocument2_EndPrint(object sender, PrintEventArgs e)
        {
            for (int start = Grid_Factor.Columns.Count - 1; start >= 0; start--)
            {
                if (start == 0 || start == 3)
                {
                    Grid_Factor.Columns[start].IsVisible = true;
                   
                }
            }
            foreach (var col in Grid_Factor.Columns)
            {
                col.HeaderTextAlignment = ContentAlignment.TopCenter;
            }
            Grid_Factor.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;
        }

        private void combo_TableName_Enter(object sender, EventArgs e)
        {
            _fixLanguageAndForms.FixLanguage();
        }

        private void combo_TableName_Leave(object sender, EventArgs e)
        {
            _fixLanguageAndForms.OriginalLanguage();
        }
    }
}
