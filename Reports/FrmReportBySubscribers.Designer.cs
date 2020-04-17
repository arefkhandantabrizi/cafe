namespace HomeCafe.Reports
{
    partial class FrmReportBySubscribers
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
            this.Grid_ReportBySubscribers = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_ReportBySubscribers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_ReportBySubscribers.MasterTemplate)).BeginInit();
            this.SuspendLayout();
            // 
            // Grid_ReportBySubscribers
            // 
            this.Grid_ReportBySubscribers.AutoSizeRows = true;
            this.Grid_ReportBySubscribers.BackColor = System.Drawing.SystemColors.Control;
            this.Grid_ReportBySubscribers.Cursor = System.Windows.Forms.Cursors.Default;
            this.Grid_ReportBySubscribers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Grid_ReportBySubscribers.Font = new System.Drawing.Font("IRANSansDNFaNum", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Grid_ReportBySubscribers.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Grid_ReportBySubscribers.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Grid_ReportBySubscribers.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            this.Grid_ReportBySubscribers.MasterTemplate.AllowAddNewRow = false;
            this.Grid_ReportBySubscribers.MasterTemplate.AllowDeleteRow = false;
            this.Grid_ReportBySubscribers.MasterTemplate.AllowEditRow = false;
            this.Grid_ReportBySubscribers.MasterTemplate.AllowSearchRow = true;
            this.Grid_ReportBySubscribers.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.Grid_ReportBySubscribers.MasterTemplate.EnableGrouping = false;
            this.Grid_ReportBySubscribers.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.Grid_ReportBySubscribers.Name = "Grid_ReportBySubscribers";
            this.Grid_ReportBySubscribers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Grid_ReportBySubscribers.ShowGroupPanel = false;
            this.Grid_ReportBySubscribers.ShowGroupPanelScrollbars = false;
            this.Grid_ReportBySubscribers.ShowNoDataText = false;
            this.Grid_ReportBySubscribers.Size = new System.Drawing.Size(953, 489);
            this.Grid_ReportBySubscribers.TabIndex = 1;
            this.Grid_ReportBySubscribers.ThemeName = "TelerikMetro";
            this.Grid_ReportBySubscribers.CreateCell += new Telerik.WinControls.UI.GridViewCreateCellEventHandler(this.Grid_ReportBySubscribers_CreateCell);
            this.Grid_ReportBySubscribers.ViewCellFormatting += new Telerik.WinControls.UI.CellFormattingEventHandler(this.Grid_ReportBySubscribers_ViewCellFormatting);
            this.Grid_ReportBySubscribers.ColumnChooserItemElementCreating += new Telerik.WinControls.UI.ColumnChooserItemElementCreatingEventHandler(this.Grid_ReportBySubscribers_ColumnChooserItemElementCreating);
            this.Grid_ReportBySubscribers.ConditionalFormattingFormShown += new System.EventHandler(this.Grid_ReportBySubscribers_ConditionalFormattingFormShown);
            this.Grid_ReportBySubscribers.ContextMenuOpening += new Telerik.WinControls.UI.ContextMenuOpeningEventHandler(this.Grid_ReportBySubscribers_ContextMenuOpening);
            // 
            // FrmReportBySubscribers
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(953, 489);
            this.Controls.Add(this.Grid_ReportBySubscribers);
            this.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmReportBySubscribers";
            this.Text = "FrmReportBySubscribers";
            this.Load += new System.EventHandler(this.frm_ReportBySubscribers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid_ReportBySubscribers.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_ReportBySubscribers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView Grid_ReportBySubscribers;
    }
}