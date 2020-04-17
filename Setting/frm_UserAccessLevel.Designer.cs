namespace HomeCafe.Setting
{
    partial class frm_UserAccessLevel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn3 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 0", "نام کاربری");
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn4 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 1", "Column 1");
            Telerik.WinControls.UI.ListViewDataItem listViewDataItem31 = new Telerik.WinControls.UI.ListViewDataItem("صندوقدار");
            Telerik.WinControls.UI.ListViewDataItem listViewDataItem32 = new Telerik.WinControls.UI.ListViewDataItem("صدور فاکتور");
            Telerik.WinControls.UI.ListViewDataItem listViewDataItem33 = new Telerik.WinControls.UI.ListViewDataItem("تسویه نشده ها");
            Telerik.WinControls.UI.ListViewDataItem listViewDataItem34 = new Telerik.WinControls.UI.ListViewDataItem("اصلاح فاکتور");
            Telerik.WinControls.UI.ListViewDataItem listViewDataItem35 = new Telerik.WinControls.UI.ListViewDataItem("فاکتورهای امروز");
            Telerik.WinControls.UI.ListViewDataItem listViewDataItem36 = new Telerik.WinControls.UI.ListViewDataItem("مدیریت انبار");
            Telerik.WinControls.UI.ListViewDataItem listViewDataItem37 = new Telerik.WinControls.UI.ListViewDataItem("ثبت کالا");
            Telerik.WinControls.UI.ListViewDataItem listViewDataItem38 = new Telerik.WinControls.UI.ListViewDataItem("اصلاح اطلاعات انبار");
            Telerik.WinControls.UI.ListViewDataItem listViewDataItem39 = new Telerik.WinControls.UI.ListViewDataItem("تعریف تامین کننده");
            Telerik.WinControls.UI.ListViewDataItem listViewDataItem40 = new Telerik.WinControls.UI.ListViewDataItem("اصلاح / حذف تامین کننده");
            Telerik.WinControls.UI.ListViewDataItem listViewDataItem41 = new Telerik.WinControls.UI.ListViewDataItem("گزارشگیری");
            Telerik.WinControls.UI.ListViewDataItem listViewDataItem42 = new Telerik.WinControls.UI.ListViewDataItem("گزارش فروش براساس تاریخ");
            Telerik.WinControls.UI.ListViewDataItem listViewDataItem43 = new Telerik.WinControls.UI.ListViewDataItem("گزارش فروش براساس محصول");
            Telerik.WinControls.UI.ListViewDataItem listViewDataItem44 = new Telerik.WinControls.UI.ListViewDataItem("گزارش پرفروش ترین محصول هر دسته");
            Telerik.WinControls.UI.ListViewDataItem listViewDataItem45 = new Telerik.WinControls.UI.ListViewDataItem("گزارش میزان بدهی");
            Telerik.WinControls.UI.ListViewDataItem listViewDataItem46 = new Telerik.WinControls.UI.ListViewDataItem("گزارش لیست مشترکین");
            Telerik.WinControls.UI.ListViewDataItem listViewDataItem47 = new Telerik.WinControls.UI.ListViewDataItem("تنظیمات");
            Telerik.WinControls.UI.ListViewDataItem listViewDataItem48 = new Telerik.WinControls.UI.ListViewDataItem("تعریف میز");
            Telerik.WinControls.UI.ListViewDataItem listViewDataItem49 = new Telerik.WinControls.UI.ListViewDataItem("اصلاح / حذف میز");
            Telerik.WinControls.UI.ListViewDataItem listViewDataItem50 = new Telerik.WinControls.UI.ListViewDataItem("تعریف دسته");
            Telerik.WinControls.UI.ListViewDataItem listViewDataItem51 = new Telerik.WinControls.UI.ListViewDataItem("اصلاح / حذف دسته");
            Telerik.WinControls.UI.ListViewDataItem listViewDataItem52 = new Telerik.WinControls.UI.ListViewDataItem("تعریف محصول");
            Telerik.WinControls.UI.ListViewDataItem listViewDataItem53 = new Telerik.WinControls.UI.ListViewDataItem("اصلاح / حذف محصول");
            Telerik.WinControls.UI.ListViewDataItem listViewDataItem54 = new Telerik.WinControls.UI.ListViewDataItem("تعریف کاربر");
            Telerik.WinControls.UI.ListViewDataItem listViewDataItem55 = new Telerik.WinControls.UI.ListViewDataItem("اصلاح / حذف کاربر");
            Telerik.WinControls.UI.ListViewDataItem listViewDataItem56 = new Telerik.WinControls.UI.ListViewDataItem("تعیین سطح دسترسی");
            Telerik.WinControls.UI.ListViewDataItem listViewDataItem57 = new Telerik.WinControls.UI.ListViewDataItem("ایجاد نسخه پشتیبان");
            Telerik.WinControls.UI.ListViewDataItem listViewDataItem58 = new Telerik.WinControls.UI.ListViewDataItem("بارگذاری نسخه پشتیبان");
            Telerik.WinControls.UI.ListViewDataItem listViewDataItem59 = new Telerik.WinControls.UI.ListViewDataItem("رزرو میز");
            Telerik.WinControls.UI.ListViewDataItem listViewDataItem60 = new Telerik.WinControls.UI.ListViewDataItem("ثبت عضویت");
            this.Panel_User = new Telerik.WinControls.UI.RadPanel();
            this.List_User = new Telerik.WinControls.UI.RadListView();
            this.lb_UserName = new Telerik.WinControls.UI.RadLabel();
            this.lb_Role = new Telerik.WinControls.UI.RadLabel();
            this.Panel_Role = new Telerik.WinControls.UI.RadPanel();
            this.List_Role = new Telerik.WinControls.UI.RadListView();
            this.btn_UserToRole = new Telerik.WinControls.UI.RadButton();
            this.combo_RoleName = new Telerik.WinControls.UI.RadDropDownList();
            this.lb_AddRole = new Telerik.WinControls.UI.RadLabel();
            this.btn_SaveRole = new Telerik.WinControls.UI.RadButton();
            this.btn_RoleToAccessLevel = new Telerik.WinControls.UI.RadButton();
            this.lb_AccessLevel = new Telerik.WinControls.UI.RadLabel();
            this.Panel_AccessLevel = new Telerik.WinControls.UI.RadPanel();
            this.List_AccessLevel = new Telerik.WinControls.UI.RadListView();
            this.btn_SaveAccessLevel = new Telerik.WinControls.UI.RadButton();
            this.Alert_Accessibility = new Telerik.WinControls.UI.RadDesktopAlert(this.components);
            this.ckb_SelectAll = new Telerik.WinControls.UI.RadCheckBox();
            this.ckb_DeselectAll = new Telerik.WinControls.UI.RadCheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.Panel_User)).BeginInit();
            this.Panel_User.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.List_User)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lb_UserName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lb_Role)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Panel_Role)).BeginInit();
            this.Panel_Role.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.List_Role)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_UserToRole)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.combo_RoleName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lb_AddRole)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_SaveRole)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_RoleToAccessLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lb_AccessLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Panel_AccessLevel)).BeginInit();
            this.Panel_AccessLevel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.List_AccessLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_SaveAccessLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckb_SelectAll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckb_DeselectAll)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel_User
            // 
            this.Panel_User.Controls.Add(this.List_User);
            this.Panel_User.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Panel_User.Location = new System.Drawing.Point(669, 48);
            this.Panel_User.Name = "Panel_User";
            this.Panel_User.Size = new System.Drawing.Size(259, 402);
            this.Panel_User.TabIndex = 0;
            // 
            // List_User
            // 
            this.List_User.AllowColumnReorder = false;
            this.List_User.AllowColumnResize = false;
            this.List_User.AllowEdit = false;
            this.List_User.AllowRemove = false;
            listViewDetailColumn3.HeaderText = "نام کاربری";
            listViewDetailColumn4.HeaderText = "Column 1";
            this.List_User.Columns.AddRange(new Telerik.WinControls.UI.ListViewDetailColumn[] {
            listViewDetailColumn3,
            listViewDetailColumn4});
            this.List_User.DisplayMember = "username";
            this.List_User.Dock = System.Windows.Forms.DockStyle.Fill;
            this.List_User.Location = new System.Drawing.Point(0, 0);
            this.List_User.Name = "List_User";
            this.List_User.Size = new System.Drawing.Size(259, 402);
            this.List_User.TabIndex = 0;
            this.List_User.ThemeName = "TelerikMetro";
            this.List_User.ValueMember = "id";
            this.List_User.SelectedIndexChanged += new System.EventHandler(this.List_User_SelectedIndexChanged);
            this.List_User.ItemCreating += new Telerik.WinControls.UI.ListViewItemCreatingEventHandler(this.List_User_ItemCreating);
            // 
            // lb_UserName
            // 
            this.lb_UserName.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lb_UserName.Location = new System.Drawing.Point(861, 12);
            this.lb_UserName.Name = "lb_UserName";
            this.lb_UserName.Size = new System.Drawing.Size(67, 30);
            this.lb_UserName.TabIndex = 16;
            this.lb_UserName.Text = "نام کاربری:";
            this.lb_UserName.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            this.lb_UserName.ThemeName = "TelerikMetro";
            // 
            // lb_Role
            // 
            this.lb_Role.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lb_Role.Location = new System.Drawing.Point(561, 12);
            this.lb_Role.Name = "lb_Role";
            this.lb_Role.Size = new System.Drawing.Size(39, 30);
            this.lb_Role.TabIndex = 17;
            this.lb_Role.Text = "نقش:";
            this.lb_Role.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            this.lb_Role.ThemeName = "TelerikMetro";
            // 
            // Panel_Role
            // 
            this.Panel_Role.Controls.Add(this.List_Role);
            this.Panel_Role.Location = new System.Drawing.Point(349, 48);
            this.Panel_Role.Name = "Panel_Role";
            this.Panel_Role.Size = new System.Drawing.Size(251, 365);
            this.Panel_Role.TabIndex = 18;
            // 
            // List_Role
            // 
            this.List_Role.AllowColumnReorder = false;
            this.List_Role.AllowColumnResize = false;
            this.List_Role.AllowEdit = false;
            this.List_Role.AllowRemove = false;
            this.List_Role.Dock = System.Windows.Forms.DockStyle.Fill;
            this.List_Role.Location = new System.Drawing.Point(0, 0);
            this.List_Role.Name = "List_Role";
            this.List_Role.Size = new System.Drawing.Size(251, 365);
            this.List_Role.TabIndex = 0;
            this.List_Role.ThemeName = "TelerikMetro";
            this.List_Role.SelectedItemChanged += new System.EventHandler(this.List_Role_SelectedItemChanged);
            this.List_Role.SelectedIndexChanged += new System.EventHandler(this.List_Role_SelectedIndexChanged);
            this.List_Role.ItemCreating += new Telerik.WinControls.UI.ListViewItemCreatingEventHandler(this.List_Role_ItemCreating);
            // 
            // btn_UserToRole
            // 
            this.btn_UserToRole.Enabled = false;
            this.btn_UserToRole.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_UserToRole.Image = global::HomeCafe.Properties.Resources.arrowheads_pointing_to_the_left;
            this.btn_UserToRole.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_UserToRole.Location = new System.Drawing.Point(606, 206);
            this.btn_UserToRole.Name = "btn_UserToRole";
            this.btn_UserToRole.Size = new System.Drawing.Size(57, 38);
            this.btn_UserToRole.TabIndex = 19;
            this.btn_UserToRole.ThemeName = "TelerikMetro";
            // 
            // combo_RoleName
            // 
            this.combo_RoleName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.combo_RoleName.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.combo_RoleName.Location = new System.Drawing.Point(349, 419);
            this.combo_RoleName.Name = "combo_RoleName";
            this.combo_RoleName.Size = new System.Drawing.Size(251, 35);
            this.combo_RoleName.TabIndex = 20;
            this.combo_RoleName.ThemeName = "TelerikMetro";
            this.combo_RoleName.TextChanged += new System.EventHandler(this.combo_UserName_TextChanged);
            this.combo_RoleName.Enter += new System.EventHandler(this.combo_UserName_Enter);
            this.combo_RoleName.Leave += new System.EventHandler(this.combo_UserName_Leave);
            ((Telerik.WinControls.UI.RadDropDownListElement)(this.combo_RoleName.GetChildAt(0))).RightToLeft = true;
            ((Telerik.WinControls.UI.RadDropDownListElement)(this.combo_RoleName.GetChildAt(0))).Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            // 
            // lb_AddRole
            // 
            this.lb_AddRole.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lb_AddRole.Location = new System.Drawing.Point(606, 419);
            this.lb_AddRole.Name = "lb_AddRole";
            this.lb_AddRole.Size = new System.Drawing.Size(39, 30);
            this.lb_AddRole.TabIndex = 21;
            this.lb_AddRole.Text = "نقش:";
            this.lb_AddRole.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            this.lb_AddRole.ThemeName = "TelerikMetro";
            // 
            // btn_SaveRole
            // 
            this.btn_SaveRole.Enabled = false;
            this.btn_SaveRole.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_SaveRole.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_SaveRole.Location = new System.Drawing.Point(349, 460);
            this.btn_SaveRole.Name = "btn_SaveRole";
            this.btn_SaveRole.Size = new System.Drawing.Size(110, 38);
            this.btn_SaveRole.TabIndex = 22;
            this.btn_SaveRole.Text = "افزودن نقش";
            this.btn_SaveRole.ThemeName = "TelerikMetro";
            this.btn_SaveRole.Click += new System.EventHandler(this.btn_SaveRole_Click);
            // 
            // btn_RoleToAccessLevel
            // 
            this.btn_RoleToAccessLevel.Enabled = false;
            this.btn_RoleToAccessLevel.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_RoleToAccessLevel.Image = global::HomeCafe.Properties.Resources.arrowheads_pointing_to_the_left;
            this.btn_RoleToAccessLevel.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_RoleToAccessLevel.Location = new System.Drawing.Point(286, 206);
            this.btn_RoleToAccessLevel.Name = "btn_RoleToAccessLevel";
            this.btn_RoleToAccessLevel.Size = new System.Drawing.Size(57, 38);
            this.btn_RoleToAccessLevel.TabIndex = 23;
            this.btn_RoleToAccessLevel.ThemeName = "TelerikMetro";
            // 
            // lb_AccessLevel
            // 
            this.lb_AccessLevel.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lb_AccessLevel.Location = new System.Drawing.Point(243, 12);
            this.lb_AccessLevel.Name = "lb_AccessLevel";
            this.lb_AccessLevel.Size = new System.Drawing.Size(87, 30);
            this.lb_AccessLevel.TabIndex = 24;
            this.lb_AccessLevel.Text = "میزان دسترسی:";
            this.lb_AccessLevel.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            this.lb_AccessLevel.ThemeName = "TelerikMetro";
            // 
            // Panel_AccessLevel
            // 
            this.Panel_AccessLevel.Controls.Add(this.List_AccessLevel);
            this.Panel_AccessLevel.Location = new System.Drawing.Point(12, 49);
            this.Panel_AccessLevel.Name = "Panel_AccessLevel";
            this.Panel_AccessLevel.Size = new System.Drawing.Size(268, 405);
            this.Panel_AccessLevel.TabIndex = 25;
            // 
            // List_AccessLevel
            // 
            this.List_AccessLevel.AllowColumnReorder = false;
            this.List_AccessLevel.AllowColumnResize = false;
            this.List_AccessLevel.AllowEdit = false;
            this.List_AccessLevel.AllowRemove = false;
            this.List_AccessLevel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.List_AccessLevel.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            listViewDataItem31.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            listViewDataItem31.Tag = "menu_Cashier";
            listViewDataItem31.Text = "صندوقدار";
            listViewDataItem32.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            listViewDataItem32.Tag = "submenu_Factor";
            listViewDataItem32.Text = "صدور فاکتور";
            listViewDataItem33.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            listViewDataItem33.Tag = "submenu_NotCheckOut";
            listViewDataItem33.Text = "تسویه نشده ها";
            listViewDataItem34.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            listViewDataItem34.Tag = "submenu_EditFactor";
            listViewDataItem34.Text = "اصلاح فاکتور";
            listViewDataItem35.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            listViewDataItem35.Key = "";
            listViewDataItem35.Tag = "submenu_AllFactors";
            listViewDataItem35.Text = "فاکتورهای امروز";
            listViewDataItem36.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            listViewDataItem36.Tag = "menu_Warehouse";
            listViewDataItem36.Text = "مدیریت انبار";
            listViewDataItem37.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            listViewDataItem37.Tag = "submenu_EntraceGoods";
            listViewDataItem37.Text = "ثبت کالا";
            listViewDataItem38.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            listViewDataItem38.Tag = "submenu_EditWareHouseData";
            listViewDataItem38.Text = "اصلاح اطلاعات انبار";
            listViewDataItem39.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            listViewDataItem39.Tag = "submenuResouce_Create";
            listViewDataItem39.Text = "تعریف تامین کننده";
            listViewDataItem40.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            listViewDataItem40.Tag = "submenuResouce_EditDelete";
            listViewDataItem40.Text = "اصلاح / حذف تامین کننده";
            listViewDataItem41.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            listViewDataItem41.Tag = "menu_Reports";
            listViewDataItem41.Text = "گزارشگیری";
            listViewDataItem42.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            listViewDataItem42.Tag = "submenu_ReportByDate";
            listViewDataItem42.Text = "گزارش فروش براساس تاریخ";
            listViewDataItem43.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            listViewDataItem43.Tag = "submenu_ReportByGoods";
            listViewDataItem43.Text = "گزارش فروش براساس محصول";
            listViewDataItem44.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            listViewDataItem44.Tag = "submenu_ReportByBestSellingCatagories";
            listViewDataItem44.Text = "گزارش پرفروش ترین محصول هر دسته";
            listViewDataItem45.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            listViewDataItem45.Tag = "submenu_DebtReport";
            listViewDataItem45.Text = "گزارش میزان بدهی";
            listViewDataItem46.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            listViewDataItem46.Tag = "submenu_Subscribers";
            listViewDataItem46.Text = "گزارش لیست مشترکین";
            listViewDataItem47.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            listViewDataItem47.Tag = "menu_Setting";
            listViewDataItem47.Text = "تنظیمات";
            listViewDataItem48.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            listViewDataItem48.Tag = "submenuTable_Create";
            listViewDataItem48.Text = "تعریف میز";
            listViewDataItem49.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            listViewDataItem49.Tag = "submenuTable_EditDelete";
            listViewDataItem49.Text = "اصلاح / حذف میز";
            listViewDataItem50.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            listViewDataItem50.Tag = "submenuCatagories_Create";
            listViewDataItem50.Text = "تعریف دسته";
            listViewDataItem51.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            listViewDataItem51.Tag = "submenuCatagories_EditDelete";
            listViewDataItem51.Text = "اصلاح / حذف دسته";
            listViewDataItem52.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            listViewDataItem52.Tag = "submenuProducts_Create";
            listViewDataItem52.Text = "تعریف محصول";
            listViewDataItem53.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            listViewDataItem53.Tag = "submenuProducts_EditDelete";
            listViewDataItem53.Text = "اصلاح / حذف محصول";
            listViewDataItem54.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            listViewDataItem54.Tag = "submenuuser_Add";
            listViewDataItem54.Text = "تعریف کاربر";
            listViewDataItem55.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            listViewDataItem55.Tag = "submenuuser_EditDelete";
            listViewDataItem55.Text = "اصلاح / حذف کاربر";
            listViewDataItem56.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            listViewDataItem56.Tag = "submenuuser_Access";
            listViewDataItem56.Text = "تعیین سطح دسترسی";
            listViewDataItem57.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            listViewDataItem57.Tag = "submenubackup_Create";
            listViewDataItem57.Text = "ایجاد نسخه پشتیبان";
            listViewDataItem58.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            listViewDataItem58.Tag = "submenubackup_UpLoad";
            listViewDataItem58.Text = "بارگذاری نسخه پشتیبان";
            listViewDataItem59.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            listViewDataItem59.Tag = "menu_Reservation";
            listViewDataItem59.Text = "رزرو میز";
            listViewDataItem60.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            listViewDataItem60.Tag = "menu_Subscription";
            listViewDataItem60.Text = "ثبت عضویت";
            this.List_AccessLevel.Items.AddRange(new Telerik.WinControls.UI.ListViewDataItem[] {
            listViewDataItem31,
            listViewDataItem32,
            listViewDataItem33,
            listViewDataItem34,
            listViewDataItem35,
            listViewDataItem36,
            listViewDataItem37,
            listViewDataItem38,
            listViewDataItem39,
            listViewDataItem40,
            listViewDataItem41,
            listViewDataItem42,
            listViewDataItem43,
            listViewDataItem44,
            listViewDataItem45,
            listViewDataItem46,
            listViewDataItem47,
            listViewDataItem48,
            listViewDataItem49,
            listViewDataItem50,
            listViewDataItem51,
            listViewDataItem52,
            listViewDataItem53,
            listViewDataItem54,
            listViewDataItem55,
            listViewDataItem56,
            listViewDataItem57,
            listViewDataItem58,
            listViewDataItem59,
            listViewDataItem60});
            this.List_AccessLevel.Location = new System.Drawing.Point(0, 0);
            this.List_AccessLevel.Name = "List_AccessLevel";
            this.List_AccessLevel.ShowCheckBoxes = true;
            this.List_AccessLevel.Size = new System.Drawing.Size(268, 405);
            this.List_AccessLevel.TabIndex = 0;
            this.List_AccessLevel.ThemeName = "TelerikMetro";
            this.List_AccessLevel.SelectedIndexChanged += new System.EventHandler(this.List_AccessLevel_SelectedIndexChanged);
            this.List_AccessLevel.ItemMouseClick += new Telerik.WinControls.UI.ListViewItemEventHandler(this.List_AccessLevel_ItemMouseClick);
            // 
            // btn_SaveAccessLevel
            // 
            this.btn_SaveAccessLevel.Enabled = false;
            this.btn_SaveAccessLevel.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_SaveAccessLevel.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_SaveAccessLevel.Location = new System.Drawing.Point(12, 460);
            this.btn_SaveAccessLevel.Name = "btn_SaveAccessLevel";
            this.btn_SaveAccessLevel.Size = new System.Drawing.Size(110, 38);
            this.btn_SaveAccessLevel.TabIndex = 23;
            this.btn_SaveAccessLevel.Text = "ثبت دسترسی";
            this.btn_SaveAccessLevel.ThemeName = "TelerikMetro";
            this.btn_SaveAccessLevel.Click += new System.EventHandler(this.btn_SaveAccessLevel_Click);
            // 
            // Alert_Accessibility
            // 
            this.Alert_Accessibility.CanMove = false;
            this.Alert_Accessibility.ContentImage = global::HomeCafe.Properties.Resources.success_Alert;
            this.Alert_Accessibility.ThemeName = "TelerikMetro";
            // 
            // ckb_SelectAll
            // 
            this.ckb_SelectAll.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ckb_SelectAll.Location = new System.Drawing.Point(135, 12);
            this.ckb_SelectAll.Name = "ckb_SelectAll";
            this.ckb_SelectAll.Size = new System.Drawing.Size(87, 30);
            this.ckb_SelectAll.TabIndex = 26;
            this.ckb_SelectAll.Text = "انتخاب همه";
            this.ckb_SelectAll.ThemeName = "TelerikMetro";
            this.ckb_SelectAll.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.ckb_SelectAll_ToggleStateChanged);
            // 
            // ckb_DeselectAll
            // 
            this.ckb_DeselectAll.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ckb_DeselectAll.Location = new System.Drawing.Point(12, 12);
            this.ckb_DeselectAll.Name = "ckb_DeselectAll";
            this.ckb_DeselectAll.Size = new System.Drawing.Size(102, 30);
            this.ckb_DeselectAll.TabIndex = 27;
            this.ckb_DeselectAll.Text = "پاک کردن همه";
            this.ckb_DeselectAll.ThemeName = "TelerikMetro";
            this.ckb_DeselectAll.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.ckb_DeselectAll_ToggleStateChanged);
            // 
            // frm_UserAccessLevel
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(940, 510);
            this.Controls.Add(this.ckb_DeselectAll);
            this.Controls.Add(this.ckb_SelectAll);
            this.Controls.Add(this.btn_SaveAccessLevel);
            this.Controls.Add(this.Panel_AccessLevel);
            this.Controls.Add(this.lb_AccessLevel);
            this.Controls.Add(this.btn_RoleToAccessLevel);
            this.Controls.Add(this.btn_SaveRole);
            this.Controls.Add(this.lb_AddRole);
            this.Controls.Add(this.combo_RoleName);
            this.Controls.Add(this.btn_UserToRole);
            this.Controls.Add(this.Panel_Role);
            this.Controls.Add(this.lb_Role);
            this.Controls.Add(this.lb_UserName);
            this.Controls.Add(this.Panel_User);
            this.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_UserAccessLevel";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "frm_UserAccessLevel";
            this.Load += new System.EventHandler(this.frm_UserAccessLevel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Panel_User)).EndInit();
            this.Panel_User.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.List_User)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lb_UserName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lb_Role)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Panel_Role)).EndInit();
            this.Panel_Role.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.List_Role)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_UserToRole)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.combo_RoleName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lb_AddRole)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_SaveRole)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_RoleToAccessLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lb_AccessLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Panel_AccessLevel)).EndInit();
            this.Panel_AccessLevel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.List_AccessLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_SaveAccessLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckb_SelectAll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckb_DeselectAll)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadPanel Panel_User;
        private Telerik.WinControls.UI.RadListView List_User;
        private Telerik.WinControls.UI.RadLabel lb_UserName;
        private Telerik.WinControls.UI.RadLabel lb_Role;
        private Telerik.WinControls.UI.RadPanel Panel_Role;
        private Telerik.WinControls.UI.RadListView List_Role;
        private Telerik.WinControls.UI.RadButton btn_UserToRole;
        private Telerik.WinControls.UI.RadLabel lb_AddRole;
        private Telerik.WinControls.UI.RadDropDownList combo_RoleName;
        private Telerik.WinControls.UI.RadButton btn_SaveRole;
        private Telerik.WinControls.UI.RadButton btn_RoleToAccessLevel;
        private Telerik.WinControls.UI.RadLabel lb_AccessLevel;
        private Telerik.WinControls.UI.RadPanel Panel_AccessLevel;
        private Telerik.WinControls.UI.RadListView List_AccessLevel;
        private Telerik.WinControls.UI.RadButton btn_SaveAccessLevel;
        private Telerik.WinControls.UI.RadDesktopAlert Alert_Accessibility;
        private Telerik.WinControls.UI.RadCheckBox ckb_SelectAll;
        private Telerik.WinControls.UI.RadCheckBox ckb_DeselectAll;


    }
}