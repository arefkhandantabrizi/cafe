using System;
using System.Linq;
using System.Windows.Forms;
using HomeCafe.About_us;
using HomeCafe.Cashier;
using HomeCafe.DataBase;
using HomeCafe.My_Custom_Classes;
using HomeCafe.Reports;
using HomeCafe.Setting;
using HomeCafe.Subscription;
using HomeCafe.Table_Reservation;
using HomeCafe.Warehouse;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace HomeCafe.Index_and_Login
{
    public partial class FrmMain : RadForm
    {
        private string _lastOpenedForm;
        private Form _currentForm;
        private int _counter;

        public FrmMain()
        {
            _lastOpenedForm = null;
            _currentForm = new Form();
            InitializeComponent();

        }

        public void OpenFullScreenForm(string formName)
        {
            if (_lastOpenedForm == formName) return;
            Panel_BackGroundPic.Visible = false;
            IsMdiContainer = false;
            IsMdiContainer = true;
            _currentForm.Dispose();
        }

        public void OpenChildForm(string formName)
        {
            _counter = 0;
            var openForms = Application.OpenForms.Cast<Form>().ToList();

            foreach (var f in openForms.Where(f => f.Name != "FrmLogin" && f.Name != "FrmMain"))
            {
                if (f.Name != formName)
                    f.Dispose();
                else
                    _counter += 1;
            }
        }
       
        protected override bool ProcessCmdKey(ref Message message, Keys keys)
        {
            switch (keys)
            {
                case Keys.Control | Keys.H:
                    if (_currentForm.Name != "FrmMain")
                    {
                        _currentForm.Dispose();
                        Panel_BackGroundPic.Visible = true;
                    }
                    _lastOpenedForm = "FrmMain";
                    return true;
                case Keys.Control | Keys.R:
                    if (_lastOpenedForm != "Reservation")
                    {
                        OpenFullScreenForm("Reservation");
                        _currentForm = new Reservation
                        {
                            MdiParent = this,
                            Dock = DockStyle.Fill
                        };
                        _currentForm.Show();
                        _lastOpenedForm = "Reservation";
                    }
                    return true;
                case Keys.Control | Keys.W:
                    if (_currentForm.Name == "FrmWareHouse")
                    {
                        _currentForm.Dispose();
                    }
                    _currentForm = new FrmWareHouse();
                    _currentForm.Show();
                    _lastOpenedForm = "FrmWareHouse";
                return true;    
            }
            return base.ProcessCmdKey(ref message, keys);
        }

        private void menu_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private static ElementVisibility GetVisibility(RadElement e)
        {
            var index = new Index(new MyDatabase())
            {
                PageName = e.Name,
                UserName = FrmLogin.FormUser
            };
            return index.GetStatus();
        }

        private void frm_Main_Load(object sender, EventArgs e)
        {
            Text = @"نرم افزار مدیریت کافه و رستوران" + @"                  " + @"کاربر:" + @" " + FrmLogin.FormUser;
            SetVisibility();
        }

        private void menu_Reservation_Click(object sender, EventArgs e)
        {
            OpenFullScreenForm("Reservation");
            _currentForm = new Reservation
            {
                MdiParent = this,
                Dock = DockStyle.Fill
            };
            _currentForm.Show();
            _lastOpenedForm = "Reservation";
        }

        private void submenu_EntraceGoods_Click(object sender, EventArgs e)
        {
            OpenChildForm("FrmWareHouse");
            if (_counter != 0) return;
            Panel_BackGroundPic.Visible = true;
            _currentForm = new FrmWareHouse();
            _currentForm.Show();
            _lastOpenedForm = "FrmWareHouse";
        }

        private void submenu_EditWareHouseData_Click(object sender, EventArgs e)
        {
            OpenFullScreenForm("FrmEditWareHouse");
            _currentForm = new FrmEditWareHouse
            {
                MdiParent = this,
                Dock = DockStyle.Fill
            };
            _currentForm.Show();
            _lastOpenedForm = "FrmEditWareHouse";
        }

        private void submenu_Factor_Click(object sender, EventArgs e)
        {
            OpenFullScreenForm("FrmFactors");
            _currentForm = new FrmFactors(new FixLanguageAndForm(), new InputValidation())
            {
                MdiParent = this,
                Dock = DockStyle.Fill
            };
            _currentForm.Show();
            _lastOpenedForm = "FrmFactors";
        }

        private void submenuCatagories_Create_Click(object sender, EventArgs e)
        {
            OpenChildForm("frm_AddCatagories");
            if (_counter != 0) return;
            Panel_BackGroundPic.Visible = true;
            _currentForm = new frm_AddCatagories();
            _currentForm.Show();
            _lastOpenedForm = "frm_AddCatagories";
        }

        private void submenuCatagories_Edit_Click(object sender, EventArgs e)
        {
            OpenChildForm("frm_EditDeleteCatagories");
            if (_counter != 0) return;
            Panel_BackGroundPic.Visible = true;
            _currentForm = new frm_EditDeleteCatagories();
            _currentForm.Show();
            _lastOpenedForm = "frm_EditDeleteCatagories";
        }

        private void submenuProducts_Create_Click(object sender, EventArgs e)
        {
            OpenChildForm("frm_AddProducts");
            if (_counter != 0) return;
            Panel_BackGroundPic.Visible = true;
            _currentForm = new frm_AddProducts();
            _currentForm.Show();
            _lastOpenedForm = "frm_AddProducts";
        }

        private void submenuProducts_EditDelete_Click(object sender, EventArgs e)
        {
            OpenFullScreenForm("frm_EditDeleteProducts");
            _currentForm = new frm_EditDeleteProducts
            {
                MdiParent = this,
                Dock = DockStyle.Fill
            };
            _currentForm.Show();
            _lastOpenedForm = "frm_EditDeleteProducts";
        }

        private void submenuuser_Add_Click(object sender, EventArgs e)
        {
            OpenChildForm("FrmAddUser");
            if (_counter != 0) return;
            Panel_BackGroundPic.Visible = true;
            _currentForm = new FrmAddUser();
            _currentForm.Show();
            _lastOpenedForm = "FrmAddUser";
        }

        private void submenuuser_EditDelete_Click(object sender, EventArgs e)
        {
            OpenChildForm("frm_EditDeleteUser");
            if (_counter != 0) return;
            Panel_BackGroundPic.Visible = true;
            _currentForm = new frm_EditDeleteUser();
            _currentForm.Show();
            _lastOpenedForm = "frm_EditDeleteUser";
        }

        private void submenuuser_Access_Click(object sender, EventArgs e)
        {
            OpenFullScreenForm("frm_UserAccessLevel");
            _currentForm = new frm_UserAccessLevel
            {
                MdiParent = this,
                Dock = DockStyle.Fill
            };
            _currentForm.Show();
            _lastOpenedForm = "frm_UserAccessLevel";
        }

        private void submenubackup_Create_Click(object sender, EventArgs e)
        {
            OpenChildForm("frm_CreateBackUp");
            if (_counter != 0) return;
            Panel_BackGroundPic.Visible = true;
            _currentForm = new frm_CreateBackUp();
            _currentForm.Show();
            _lastOpenedForm = "frm_CreateBackUp";
        }

        private void submenubackup_UpLoad_Click(object sender, EventArgs e)
        {
            OpenChildForm("frm_UpLoadBackUp");
            if (_counter != 0) return;
            Panel_BackGroundPic.Visible = true;
            _currentForm = new frm_UpLoadBackUp();
            _currentForm.Show();
            _lastOpenedForm = "frm_UpLoadBackUp";
        }

        private void menu_AboutUs_Click(object sender, EventArgs e)
        {
            OpenChildForm("FrmAboutUs");
            if (_counter != 0) return;
            Panel_BackGroundPic.Visible = true;
            _currentForm = new FrmAboutUs();
            _currentForm.Show();
            _lastOpenedForm = "FrmAboutUs";
        }

        private void menu_Subscription_Click(object sender, EventArgs e)
        {
            OpenChildForm("FrmSubscription");
            if (_counter != 0) return;
            Panel_BackGroundPic.Visible = true;
            _currentForm = new FrmSubscription(new FixLanguageAndForm(), new InputValidation());
            _currentForm.Show();
            _lastOpenedForm = "FrmSubscription";
        }

        private void submenuTable_Create_Click(object sender, EventArgs e)
        {
            OpenChildForm("frm_AddTable");
            if (_counter != 0) return;
            Panel_BackGroundPic.Visible = true;
            _currentForm = new frm_AddTable();
            _currentForm.Show();
            _lastOpenedForm = "frm_AddTable";
        }

        private void submenuTable_EditDelete_Click(object sender, EventArgs e)
        {
            OpenChildForm("frm_EditDeleteTable");
            if (_counter != 0) return;
            Panel_BackGroundPic.Visible = true;
            _currentForm = new frm_EditDeleteTable();
            _currentForm.Show();
            _lastOpenedForm = "frm_EditDeleteTable";
        }

        private void submenu_NotCheckOut_Click(object sender, EventArgs e)
        {
            OpenFullScreenForm("FrmUnpayedFactors");
            _currentForm = new FrmUnpayedFactors
            {
                MdiParent = this,
                Dock = DockStyle.Fill
            };
            _currentForm.Show();
            _lastOpenedForm = "FrmUnpayedFactors";
        }

        private void submenu_EditFactor_Click(object sender, EventArgs e)
        {
            OpenFullScreenForm("FrmEditFactors");
            _currentForm = new FrmEditFactors(new FixLanguageAndForm())
            {
                MdiParent = this,
                Dock = DockStyle.Fill
            };
            _currentForm.Show();
            _lastOpenedForm = "FrmEditFactors";
        }

        private void submenu_AllFactors_Click(object sender, EventArgs e)
        {
            OpenFullScreenForm("FrmTodayFactors");
            _currentForm = new FrmTodayFactors
            {
                MdiParent = this,
                Dock = DockStyle.Fill
            };
            _currentForm.Show();
            _lastOpenedForm = "FrmTodayFactors";
        }

        private void submenuResouce_Create_Click(object sender, EventArgs e)
        {
            OpenChildForm("FrmAddVendor");
            if (_counter != 0) return;
            Panel_BackGroundPic.Visible = true;
            _currentForm = new FrmAddVendor(new FixLanguageAndForm());
            _currentForm.Show();
            _lastOpenedForm = "FrmAddVendor";
        }

        private void submenuResouce_EditDelete_Click(object sender, EventArgs e)
        {
            OpenFullScreenForm("FrmEditDeleteVendor");
            _currentForm = new FrmEditDeleteVendor (new FixLanguageAndForm())
            {
                MdiParent = this,
                Dock = DockStyle.Fill
            };
            _currentForm.Show();
            _lastOpenedForm = "FrmEditDeleteVendor";
        }

        private void submenu_ReportByDate_Click(object sender, EventArgs e)
        {
            OpenFullScreenForm("FrmReportByDate");
            _currentForm = new FrmReportByDate
            {
                MdiParent = this,
                Dock = DockStyle.Fill
            };
            _currentForm.Show();
            _lastOpenedForm = "FrmReportByDate";
        }

        private void submenu_ReportByGoods_Click(object sender, EventArgs e)
        {
            OpenFullScreenForm("FrmReportByGoods");
            _currentForm = new FrmReportByGoods(new FixLanguageAndForm())
            {
                MdiParent = this,
                Dock = DockStyle.Fill
            };
            _currentForm.Show();
            _lastOpenedForm = "FrmReportByGoods";
        }

        private void submenu_ReportByBestSellingCatagories_Click(object sender, EventArgs e)
        {
            OpenFullScreenForm("FrmReportByBestSellingCatagories");
            _currentForm = new FrmReportByBestSellingCatagories(new FixLanguageAndForm())
            {
                MdiParent = this,
                Dock = DockStyle.Fill
            };
            _currentForm.Show();
            _lastOpenedForm = "FrmReportByBestSellingCatagories";
        }

        private void submenu_DebtReport_Click(object sender, EventArgs e)
        {
            OpenFullScreenForm("FrmDebtReport");
            _currentForm = new FrmDebtReport
            {
                MdiParent = this,
                Dock = DockStyle.Fill
            };
            _currentForm.Show();
            _lastOpenedForm = "FrmDebtReport";
        }

        private void submenu_Subscribers_Click(object sender, EventArgs e)
        {
            OpenFullScreenForm("FrmReportBySubscribers");
            _currentForm = new FrmReportBySubscribers
            {
                MdiParent = this,
                Dock = DockStyle.Fill
            };
            _currentForm.Show();
            _lastOpenedForm = "FrmReportBySubscribers";
        }

        private void SetVisibility()
        {
            menu_Cashier.Visibility = GetVisibility(menu_Cashier);
            submenu_Factor.Visibility = GetVisibility(submenu_Factor);
            submenu_NotCheckOut.Visibility = GetVisibility(submenu_NotCheckOut);
            submenu_EditFactor.Visibility = GetVisibility(submenu_EditFactor);
            submenu_AllFactors.Visibility = GetVisibility(submenu_AllFactors);
            menu_Warehouse.Visibility = GetVisibility(menu_Warehouse);
            submenu_EntraceGoods.Visibility = GetVisibility(submenu_EntraceGoods);
            submenu_EditWareHouseData.Visibility = GetVisibility(submenu_EditWareHouseData);
            submenuResouce_Create.Visibility = GetVisibility(submenuResouce_Create);
            submenuResouce_EditDelete.Visibility = GetVisibility(submenuResouce_EditDelete);
            menu_Reports.Visibility = GetVisibility(menu_Reports);
            submenu_ReportByDate.Visibility = GetVisibility(submenu_ReportByDate);
            submenu_ReportByGoods.Visibility = GetVisibility(submenu_ReportByGoods);
            submenu_ReportByBestSellingCatagories.Visibility = GetVisibility(submenu_ReportByBestSellingCatagories);
            submenu_DebtReport.Visibility = GetVisibility(submenu_DebtReport);
            submenu_Subscribers.Visibility = GetVisibility(submenu_Subscribers);
            menu_Setting.Visibility = GetVisibility(menu_Setting);
            submenuTable_Create.Visibility = GetVisibility(submenuTable_Create);
            submenuTable_EditDelete.Visibility = GetVisibility(submenuTable_EditDelete);
            submenuCatagories_Create.Visibility = GetVisibility(submenuCatagories_Create);
            submenuCatagories_EditDelete.Visibility = GetVisibility(submenuCatagories_EditDelete);
            submenuProducts_Create.Visibility = GetVisibility(submenuProducts_Create);
            submenuProducts_EditDelete.Visibility = GetVisibility(submenuProducts_EditDelete);
            submenuuser_Add.Visibility = GetVisibility(submenuuser_Add);
            submenuuser_EditDelete.Visibility = GetVisibility(submenuuser_EditDelete);
            submenuuser_Access.Visibility = GetVisibility(submenuuser_Access);
            submenubackup_Create.Visibility = GetVisibility(submenubackup_Create);
            submenubackup_UpLoad.Visibility = GetVisibility(submenubackup_UpLoad);
            menu_Reservation.Visibility = GetVisibility(menu_Reservation);
            menu_Subscription.Visibility = GetVisibility(menu_Subscription);
        }
    }
}
