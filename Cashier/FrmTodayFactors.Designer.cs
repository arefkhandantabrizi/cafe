namespace HomeCafe.Cashier
{
    partial class FrmTodayFactors
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
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition2 = new Telerik.WinControls.UI.TableViewDefinition();
            this.Grid_Factor = new Telerik.WinControls.UI.RadGridView();
            this.txt_FactorDate = new Telerik.WinControls.UI.RadDateTimePicker();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.Group_Invoice = new Telerik.WinControls.UI.RadGroupBox();
            this.radPanel2 = new Telerik.WinControls.UI.RadPanel();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.GridItems = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Factor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Factor.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_FactorDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Group_Invoice)).BeginInit();
            this.Group_Invoice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel2)).BeginInit();
            this.radPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridItems.MasterTemplate)).BeginInit();
            this.SuspendLayout();
            // 
            // Grid_Factor
            // 
            this.Grid_Factor.AutoSizeRows = true;
            this.Grid_Factor.BackColor = System.Drawing.SystemColors.Control;
            this.Grid_Factor.Cursor = System.Windows.Forms.Cursors.Default;
            this.Grid_Factor.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Grid_Factor.Font = new System.Drawing.Font("IRANSansDNFaNum", 9.75F);
            this.Grid_Factor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Grid_Factor.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Grid_Factor.Location = new System.Drawing.Point(2, 33);
            // 
            // 
            // 
            this.Grid_Factor.MasterTemplate.AllowAddNewRow = false;
            this.Grid_Factor.MasterTemplate.AllowDeleteRow = false;
            this.Grid_Factor.MasterTemplate.AllowEditRow = false;
            this.Grid_Factor.MasterTemplate.AllowSearchRow = true;
            this.Grid_Factor.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.Grid_Factor.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.Grid_Factor.Name = "Grid_Factor";
            this.Grid_Factor.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Grid_Factor.ShowGroupPanel = false;
            this.Grid_Factor.Size = new System.Drawing.Size(612, 218);
            this.Grid_Factor.TabIndex = 0;
            this.Grid_Factor.ThemeName = "TelerikMetro";
            this.Grid_Factor.CreateCell += new Telerik.WinControls.UI.GridViewCreateCellEventHandler(this.Grid_Factor_CreateCell);
            this.Grid_Factor.CellFormatting += new Telerik.WinControls.UI.CellFormattingEventHandler(this.Grid_Factor_CellFormatting);
            this.Grid_Factor.ViewCellFormatting += new Telerik.WinControls.UI.CellFormattingEventHandler(this.Grid_Factor_ViewCellFormatting);
            this.Grid_Factor.CurrentRowChanged += new Telerik.WinControls.UI.CurrentRowChangedEventHandler(this.Grid_Factor_CurrentRowChanged);
            this.Grid_Factor.ColumnChooserItemElementCreating += new Telerik.WinControls.UI.ColumnChooserItemElementCreatingEventHandler(this.Grid_Factor_ColumnChooserItemElementCreating);
            this.Grid_Factor.ConditionalFormattingFormShown += new System.EventHandler(this.Grid_Factor_ConditionalFormattingFormShown);
            this.Grid_Factor.ContextMenuOpening += new Telerik.WinControls.UI.ContextMenuOpeningEventHandler(this.Grid_Factor_ContextMenuOpening);
            // 
            // txt_FactorDate
            // 
            this.txt_FactorDate.Culture = new System.Globalization.CultureInfo("fa-IR");
            this.txt_FactorDate.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_FactorDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_FactorDate.Location = new System.Drawing.Point(170, 198);
            this.txt_FactorDate.Name = "txt_FactorDate";
            this.txt_FactorDate.Size = new System.Drawing.Size(277, 35);
            this.txt_FactorDate.TabIndex = 11;
            this.txt_FactorDate.TabStop = false;
            this.txt_FactorDate.Text = "03/23/2019";
            this.txt_FactorDate.ThemeName = "TelerikMetro";
            this.txt_FactorDate.Value = new System.DateTime(2019, 3, 23, 20, 43, 24, 699);
            this.txt_FactorDate.Visible = false;
            // 
            // radPanel1
            // 
            this.radPanel1.Controls.Add(this.Group_Invoice);
            this.radPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radPanel1.Location = new System.Drawing.Point(0, 0);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(616, 253);
            this.radPanel1.TabIndex = 1;
            // 
            // Group_Invoice
            // 
            this.Group_Invoice.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.Group_Invoice.Controls.Add(this.Grid_Factor);
            this.Group_Invoice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Group_Invoice.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Group_Invoice.HeaderText = "فاکتورهای ثبت شده امروز";
            this.Group_Invoice.Location = new System.Drawing.Point(0, 0);
            this.Group_Invoice.Name = "Group_Invoice";
            this.Group_Invoice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Group_Invoice.Size = new System.Drawing.Size(616, 253);
            this.Group_Invoice.TabIndex = 0;
            this.Group_Invoice.Text = "فاکتورهای ثبت شده امروز";
            this.Group_Invoice.ThemeName = "TelerikMetro";
            ((Telerik.WinControls.UI.GroupBoxHeader)(this.Group_Invoice.GetChildAt(0).GetChildAt(1))).Font = new System.Drawing.Font("IRANSansDNFaNum", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            // 
            // radPanel2
            // 
            this.radPanel2.Controls.Add(this.radGroupBox1);
            this.radPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radPanel2.Location = new System.Drawing.Point(0, 253);
            this.radPanel2.Name = "radPanel2";
            this.radPanel2.Size = new System.Drawing.Size(616, 270);
            this.radPanel2.TabIndex = 2;
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.GridItems);
            this.radGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radGroupBox1.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.radGroupBox1.HeaderText = "جزئیات فاکتور";
            this.radGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radGroupBox1.Size = new System.Drawing.Size(616, 270);
            this.radGroupBox1.TabIndex = 0;
            this.radGroupBox1.Text = "جزئیات فاکتور";
            this.radGroupBox1.ThemeName = "TelerikMetro";
            ((Telerik.WinControls.UI.GroupBoxHeader)(this.radGroupBox1.GetChildAt(0).GetChildAt(1))).Font = new System.Drawing.Font("IRANSansDNFaNum", 9.75F);
            // 
            // GridItems
            // 
            this.GridItems.AutoSizeRows = true;
            this.GridItems.BackColor = System.Drawing.SystemColors.Control;
            this.GridItems.Cursor = System.Windows.Forms.Cursors.Default;
            this.GridItems.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GridItems.Font = new System.Drawing.Font("IRANSansDNFaNum", 9.75F);
            this.GridItems.ForeColor = System.Drawing.Color.Black;
            this.GridItems.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.GridItems.Location = new System.Drawing.Point(2, 27);
            // 
            // 
            // 
            this.GridItems.MasterTemplate.AllowAddNewRow = false;
            this.GridItems.MasterTemplate.AllowDeleteRow = false;
            this.GridItems.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.GridItems.MasterTemplate.ViewDefinition = tableViewDefinition2;
            this.GridItems.Name = "GridItems";
            this.GridItems.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.GridItems.ShowGroupPanel = false;
            this.GridItems.Size = new System.Drawing.Size(612, 241);
            this.GridItems.TabIndex = 2;
            this.GridItems.ThemeName = "TelerikMetro";
            this.GridItems.CreateCell += new Telerik.WinControls.UI.GridViewCreateCellEventHandler(this.GridItems_CreateCell);
            this.GridItems.CellFormatting += new Telerik.WinControls.UI.CellFormattingEventHandler(this.GridItems_CellFormatting);
            this.GridItems.ViewCellFormatting += new Telerik.WinControls.UI.CellFormattingEventHandler(this.GridItems_ViewCellFormatting);
            this.GridItems.ColumnChooserItemElementCreating += new Telerik.WinControls.UI.ColumnChooserItemElementCreatingEventHandler(this.GridItems_ColumnChooserItemElementCreating);
            this.GridItems.ConditionalFormattingFormShown += new System.EventHandler(this.GridItems_ConditionalFormattingFormShown);
            this.GridItems.ContextMenuOpening += new Telerik.WinControls.UI.ContextMenuOpeningEventHandler(this.GridItems_ContextMenuOpening);
            // 
            // FrmTodayFactors
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(616, 523);
            this.Controls.Add(this.radPanel2);
            this.Controls.Add(this.radPanel1);
            this.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmTodayFactors";
            this.Text = "FrmTodayFactors";
            this.Load += new System.EventHandler(this.frm_TodayFactors_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Factor.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Factor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_FactorDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Group_Invoice)).EndInit();
            this.Group_Invoice.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radPanel2)).EndInit();
            this.radPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridItems.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridItems)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView Grid_Factor;
        private Telerik.WinControls.UI.RadDateTimePicker txt_FactorDate;
        private Telerik.WinControls.UI.RadGridView MasterTemplate;
        private Telerik.WinControls.UI.RadPanel radPanel1;
        private Telerik.WinControls.UI.RadGroupBox Group_Invoice;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadPanel radPanel2;
        private Telerik.WinControls.UI.RadGridView GridItems;
    }
}