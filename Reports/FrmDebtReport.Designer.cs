namespace HomeCafe.Reports
{
    partial class FrmDebtReport
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
            this.Grid_ReportByDebt = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_ReportByDebt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_ReportByDebt.MasterTemplate)).BeginInit();
            this.SuspendLayout();
            // 
            // Grid_ReportByDebt
            // 
            this.Grid_ReportByDebt.AutoSizeRows = true;
            this.Grid_ReportByDebt.BackColor = System.Drawing.SystemColors.Control;
            this.Grid_ReportByDebt.Cursor = System.Windows.Forms.Cursors.Default;
            this.Grid_ReportByDebt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Grid_ReportByDebt.Font = new System.Drawing.Font("IRANSansDNFaNum", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Grid_ReportByDebt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Grid_ReportByDebt.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Grid_ReportByDebt.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            this.Grid_ReportByDebt.MasterTemplate.AllowAddNewRow = false;
            this.Grid_ReportByDebt.MasterTemplate.AllowDeleteRow = false;
            this.Grid_ReportByDebt.MasterTemplate.AllowEditRow = false;
            this.Grid_ReportByDebt.MasterTemplate.AllowSearchRow = true;
            this.Grid_ReportByDebt.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.Grid_ReportByDebt.MasterTemplate.EnableGrouping = false;
            this.Grid_ReportByDebt.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.Grid_ReportByDebt.Name = "Grid_ReportByDebt";
            this.Grid_ReportByDebt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Grid_ReportByDebt.ShowGroupPanel = false;
            this.Grid_ReportByDebt.ShowGroupPanelScrollbars = false;
            this.Grid_ReportByDebt.ShowNoDataText = false;
            this.Grid_ReportByDebt.Size = new System.Drawing.Size(953, 489);
            this.Grid_ReportByDebt.TabIndex = 1;
            this.Grid_ReportByDebt.ThemeName = "TelerikMetro";
            this.Grid_ReportByDebt.CreateCell += new Telerik.WinControls.UI.GridViewCreateCellEventHandler(this.Grid_ReportByDebt_CreateCell);
            this.Grid_ReportByDebt.ViewCellFormatting += new Telerik.WinControls.UI.CellFormattingEventHandler(this.Grid_ReportByDebt_ViewCellFormatting);
            this.Grid_ReportByDebt.ColumnChooserItemElementCreating += new Telerik.WinControls.UI.ColumnChooserItemElementCreatingEventHandler(this.Grid_ReportByDebt_ColumnChooserItemElementCreating);
            this.Grid_ReportByDebt.ConditionalFormattingFormShown += new System.EventHandler(this.Grid_ReportByDebt_ConditionalFormattingFormShown);
            this.Grid_ReportByDebt.ContextMenuOpening += new Telerik.WinControls.UI.ContextMenuOpeningEventHandler(this.Grid_ReportByDebt_ContextMenuOpening);
            // 
            // FrmDebtReport
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(953, 489);
            this.Controls.Add(this.Grid_ReportByDebt);
            //this.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmDebtReport";
            this.Text = "FrmDebtReport";
            this.Load += new System.EventHandler(this.frm_DebtReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid_ReportByDebt.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_ReportByDebt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView Grid_ReportByDebt;
    }
}