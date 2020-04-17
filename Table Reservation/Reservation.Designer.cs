namespace HomeCafe.Table_Reservation
{
    partial class Reservation
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
            Telerik.WinControls.UI.SchedulerDailyPrintStyle schedulerDailyPrintStyle1 = new Telerik.WinControls.UI.SchedulerDailyPrintStyle();
            Telerik.WinControls.UI.AppointmentMappingInfo appointmentMappingInfo1 = new Telerik.WinControls.UI.AppointmentMappingInfo();
            Telerik.WinControls.UI.ResourceMappingInfo resourceMappingInfo1 = new Telerik.WinControls.UI.ResourceMappingInfo();
            this.telerikMetroTheme1 = new Telerik.WinControls.Themes.TelerikMetroTheme();
            this.ReservationNavigator = new Telerik.WinControls.UI.RadSchedulerNavigator();
            this.ReservationScheduler = new Telerik.WinControls.UI.RadScheduler();
            this.ReservationBindingDataSource = new Telerik.WinControls.UI.SchedulerBindingDataSource();
            this.resourceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ReservationDataSet = new HomeCafe.Resource();
            this.ReservationRiminder = new Telerik.WinControls.UI.RadSchedulerReminder(this.components);
            this.resourceTableAdapter1 = new HomeCafe.ResourceTableAdapters.resourceTableAdapter();
            this.reservationTableAdapter1 = new HomeCafe.ResourceTableAdapters.reservationTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ReservationNavigator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReservationScheduler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReservationBindingDataSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReservationBindingDataSource.EventProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReservationBindingDataSource.ResourceProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resourceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReservationDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // ReservationNavigator
            // 
            this.ReservationNavigator.AssociatedScheduler = this.ReservationScheduler;
            this.ReservationNavigator.DateFormat = "yyyy/MM/dd";
            this.ReservationNavigator.Dock = System.Windows.Forms.DockStyle.Top;
            this.ReservationNavigator.Font = new System.Drawing.Font("IRANSansDNFaNum", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ReservationNavigator.Location = new System.Drawing.Point(0, 0);
            this.ReservationNavigator.Name = "ReservationNavigator";
            this.ReservationNavigator.NavigationStepType = Telerik.WinControls.UI.NavigationStepTypes.Day;
            // 
            // 
            // 
            this.ReservationNavigator.RootElement.StretchVertically = false;
            this.ReservationNavigator.Size = new System.Drawing.Size(930, 98);
            this.ReservationNavigator.TabIndex = 0;
            this.ReservationNavigator.ThemeName = "TelerikMetro";
            this.ReservationNavigator.MonthViewClick += new System.EventHandler(this.ReservationNavigator_MonthViewClick);
            this.ReservationNavigator.TimelineViewClick += new System.EventHandler(this.ReservationNavigator_TimelineViewClick);
            ((Telerik.WinControls.UI.RadToggleButtonElement)(this.ReservationNavigator.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(2).GetChildAt(0))).ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            ((Telerik.WinControls.UI.RadToggleButtonElement)(this.ReservationNavigator.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(2).GetChildAt(0))).Font = new System.Drawing.Font("IRANSansDNFaNum", 9.75F);
            ((Telerik.WinControls.UI.RadToggleButtonElement)(this.ReservationNavigator.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(2).GetChildAt(1))).Font = new System.Drawing.Font("IRANSansDNFaNum", 9.75F);
            ((Telerik.WinControls.UI.RadToggleButtonElement)(this.ReservationNavigator.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(2).GetChildAt(2))).Font = new System.Drawing.Font("IRANSansDNFaNum", 9.75F);
            ((Telerik.WinControls.UI.RadToggleButtonElement)(this.ReservationNavigator.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(2).GetChildAt(3))).Font = new System.Drawing.Font("IRANSansDNFaNum", 9.75F);
            ((Telerik.WinControls.UI.RadToggleButtonElement)(this.ReservationNavigator.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(2).GetChildAt(3))).Visibility = Telerik.WinControls.ElementVisibility.Visible;
            ((Telerik.WinControls.UI.RadToggleButtonElement)(this.ReservationNavigator.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(2).GetChildAt(4))).Text = "نمایش دستورجلسه";
            ((Telerik.WinControls.UI.RadToggleButtonElement)(this.ReservationNavigator.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(2).GetChildAt(4))).Font = new System.Drawing.Font("IRANSansDNFaNum", 9.75F);
            ((Telerik.WinControls.UI.RadToggleButtonElement)(this.ReservationNavigator.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(2).GetChildAt(4))).Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            ((Telerik.WinControls.UI.RadLabelElement)(this.ReservationNavigator.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(2).GetChildAt(6).GetChildAt(0))).Text = "(UTC) Casablanca";
            ((Telerik.WinControls.UI.RadLabelElement)(this.ReservationNavigator.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(2).GetChildAt(6).GetChildAt(0))).Font = new System.Drawing.Font("IRANSansDNFaNum", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ((Telerik.WinControls.UI.RadDropDownListElement)(this.ReservationNavigator.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(2).GetChildAt(6).GetChildAt(1))).Font = new System.Drawing.Font("IRANSansDNFaNum", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ((Telerik.WinControls.UI.SchedulerNavigatorSearchTextbox)(this.ReservationNavigator.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(2).GetChildAt(6).GetChildAt(2))).Font = new System.Drawing.Font("IRANSansDNFaNum", 9.75F);
            ((Telerik.WinControls.UI.SchedulerNavigatorSearchTextbox)(this.ReservationNavigator.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(2).GetChildAt(6).GetChildAt(2))).MaxSize = new System.Drawing.Size(250, 0);
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.ReservationNavigator.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(2).GetChildAt(0).GetChildAt(2))).Visibility = Telerik.WinControls.ElementVisibility.Hidden;
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.ReservationNavigator.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(2).GetChildAt(1).GetChildAt(1).GetChildAt(0))).Visibility = Telerik.WinControls.ElementVisibility.Visible;
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.ReservationNavigator.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(2).GetChildAt(1).GetChildAt(1).GetChildAt(1))).Font = new System.Drawing.Font("B Kamran", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.ReservationNavigator.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(2).GetChildAt(1).GetChildAt(1).GetChildAt(1))).Alignment = System.Drawing.ContentAlignment.MiddleCenter;
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.ReservationNavigator.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(2).GetChildAt(1).GetChildAt(1).GetChildAt(1))).Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            ((Telerik.WinControls.UI.RadLabelElement)(this.ReservationNavigator.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(2).GetChildAt(2))).TextAlignment = System.Drawing.ContentAlignment.TopRight;
            ((Telerik.WinControls.UI.RadLabelElement)(this.ReservationNavigator.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(2).GetChildAt(2))).Text = "2019/03/10 - 2019/03/12";
            ((Telerik.WinControls.UI.RadLabelElement)(this.ReservationNavigator.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(2).GetChildAt(2))).Font = new System.Drawing.Font("IRANSansDNFaNum", 9.75F);
            ((Telerik.WinControls.UI.RadLabelElement)(this.ReservationNavigator.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(2).GetChildAt(2))).Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            // 
            // ReservationScheduler
            // 
            this.ReservationScheduler.AutoSizeAppointments = true;
            this.ReservationScheduler.Culture = new System.Globalization.CultureInfo("fa-IR");
            this.ReservationScheduler.DataSource = this.ReservationBindingDataSource;
            this.ReservationScheduler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReservationScheduler.EnableExactTimeRendering = true;
            this.ReservationScheduler.Font = new System.Drawing.Font("IRANSansDNFaNum", 9.75F);
            this.ReservationScheduler.Location = new System.Drawing.Point(0, 98);
            this.ReservationScheduler.Name = "ReservationScheduler";
            schedulerDailyPrintStyle1.AppointmentFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            schedulerDailyPrintStyle1.DateEndRange = new System.DateTime(2019, 3, 13, 0, 0, 0, 0);
            schedulerDailyPrintStyle1.DateHeadingFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            schedulerDailyPrintStyle1.DateStartRange = new System.DateTime(2019, 3, 8, 0, 0, 0, 0);
            schedulerDailyPrintStyle1.PageHeadingFont = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold);
            this.ReservationScheduler.PrintStyle = schedulerDailyPrintStyle1;
            this.ReservationScheduler.Size = new System.Drawing.Size(930, 420);
            this.ReservationScheduler.TabIndex = 1;
            this.ReservationScheduler.ThemeName = "TelerikMetro";
            this.ReservationScheduler.CellFormatting += new System.EventHandler<Telerik.WinControls.UI.SchedulerCellEventArgs>(this.ReservationScheduler_CellFormatting);
            this.ReservationScheduler.ContextMenuOpening += new Telerik.WinControls.UI.SchedulerContextMenuOpeningEventHandler(this.ReservationScheduler_ContextMenuOpening);
            this.ReservationScheduler.ActiveViewChanged += new System.EventHandler<Telerik.WinControls.UI.SchedulerViewChangedEventArgs>(this.ReservationScheduler_ActiveViewChanged);
            this.ReservationScheduler.AppointmentFormatting += new System.EventHandler<Telerik.WinControls.UI.SchedulerAppointmentEventArgs>(this.ReservationScheduler_AppointmentFormatting);
            this.ReservationScheduler.AppointmentEditDialogShowing += new System.EventHandler<Telerik.WinControls.UI.AppointmentEditDialogShowingEventArgs>(this.ReservationScheduler_AppointmentEditDialogShowing_1);
            this.ReservationScheduler.RecurrenceEditDialogShowing += new System.EventHandler<Telerik.WinControls.UI.RecurrenceEditDialogShowingEventArgs>(this.ReservationScheduler_RecurrenceEditDialogShowing);
            ((Telerik.WinControls.UI.RadSchedulerElement)(this.ReservationScheduler.GetChildAt(0))).DefaultDateTimeTitleFont = new System.Drawing.Font("B Kamran", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            ((Telerik.WinControls.UI.SchedulerHeaderCellElement)(this.ReservationScheduler.GetChildAt(0).GetChildAt(0).GetChildAt(0).GetChildAt(1))).Text = "02 الخميس";
            ((Telerik.WinControls.UI.SchedulerHeaderCellElement)(this.ReservationScheduler.GetChildAt(0).GetChildAt(0).GetChildAt(0).GetChildAt(1))).ToolTipText = "02 الخميس";
            ((Telerik.WinControls.UI.SchedulerHeaderCellElement)(this.ReservationScheduler.GetChildAt(0).GetChildAt(0).GetChildAt(0).GetChildAt(1))).Font = new System.Drawing.Font("IRANSansDNFaNum", 9.75F);
            ((Telerik.WinControls.UI.SchedulerHeaderCellElement)(this.ReservationScheduler.GetChildAt(0).GetChildAt(0).GetChildAt(0).GetChildAt(2))).Text = "03 الجمعة";
            ((Telerik.WinControls.UI.SchedulerHeaderCellElement)(this.ReservationScheduler.GetChildAt(0).GetChildAt(0).GetChildAt(0).GetChildAt(2))).ToolTipText = "03 الجمعة";
            ((Telerik.WinControls.UI.SchedulerHeaderCellElement)(this.ReservationScheduler.GetChildAt(0).GetChildAt(0).GetChildAt(0).GetChildAt(2))).Font = new System.Drawing.Font("IRANSansDNFaNum", 9.75F);
            ((Telerik.WinControls.UI.SchedulerHeaderCellElement)(this.ReservationScheduler.GetChildAt(0).GetChildAt(0).GetChildAt(0).GetChildAt(3))).Text = "04 السبت";
            ((Telerik.WinControls.UI.SchedulerHeaderCellElement)(this.ReservationScheduler.GetChildAt(0).GetChildAt(0).GetChildAt(0).GetChildAt(3))).ToolTipText = "04 السبت";
            ((Telerik.WinControls.UI.SchedulerHeaderCellElement)(this.ReservationScheduler.GetChildAt(0).GetChildAt(0).GetChildAt(0).GetChildAt(3))).Font = new System.Drawing.Font("IRANSansDNFaNum", 9.75F);
            ((Telerik.WinControls.UI.ViewNavigationElement)(this.ReservationScheduler.GetChildAt(0).GetChildAt(0).GetChildAt(3))).Font = new System.Drawing.Font("IRANSansDNFaNum", 9.75F);
            ((Telerik.WinControls.UI.ViewNavigationElement)(this.ReservationScheduler.GetChildAt(0).GetChildAt(0).GetChildAt(3))).Visibility = Telerik.WinControls.ElementVisibility.Hidden;
            ((Telerik.WinControls.UI.ViewNavigationElement)(this.ReservationScheduler.GetChildAt(0).GetChildAt(0).GetChildAt(3))).AngleTransform = 270F;
            ((Telerik.WinControls.UI.ViewNavigationElement)(this.ReservationScheduler.GetChildAt(0).GetChildAt(0).GetChildAt(4))).Font = new System.Drawing.Font("IRANSansDNFaNum", 9.75F);
            ((Telerik.WinControls.UI.ViewNavigationElement)(this.ReservationScheduler.GetChildAt(0).GetChildAt(0).GetChildAt(4))).Visibility = Telerik.WinControls.ElementVisibility.Hidden;
            ((Telerik.WinControls.UI.ViewNavigationElement)(this.ReservationScheduler.GetChildAt(0).GetChildAt(0).GetChildAt(4))).AngleTransform = 90F;
            // 
            // ReservationBindingDataSource
            // 
            // 
            // 
            // 
            this.ReservationBindingDataSource.EventProvider.DataMember = "reservation";
            this.ReservationBindingDataSource.EventProvider.DataSource = this.resourceBindingSource;
            appointmentMappingInfo1.BackgroundId = "BackgroundID";
            appointmentMappingInfo1.Description = "Description";
            appointmentMappingInfo1.End = "End";
            appointmentMappingInfo1.Location = "Location";
            appointmentMappingInfo1.MasterEventId = "MasterEventID";
            appointmentMappingInfo1.RecurrenceRule = "RecurrenceRule";
            appointmentMappingInfo1.Reminder = "Reminder";
            appointmentMappingInfo1.ResourceId = "resourceID";
            appointmentMappingInfo1.Start = "Start";
            appointmentMappingInfo1.StatusId = "StatusID";
            appointmentMappingInfo1.Summary = "Summary";
            appointmentMappingInfo1.UniqueId = "ID";
            appointmentMappingInfo1.Visible = "Visible";
            this.ReservationBindingDataSource.EventProvider.Mapping = appointmentMappingInfo1;
            // 
            // 
            // 
            this.ReservationBindingDataSource.ResourceProvider.DataMember = "resource";
            this.ReservationBindingDataSource.ResourceProvider.DataSource = this.resourceBindingSource;
            resourceMappingInfo1.Id = "ID";
            resourceMappingInfo1.Name = "ResourceName";
            this.ReservationBindingDataSource.ResourceProvider.Mapping = resourceMappingInfo1;
            // 
            // resourceBindingSource
            // 
            this.resourceBindingSource.DataSource = this.ReservationDataSet;
            this.resourceBindingSource.Position = 0;
            // 
            // ReservationDataSet
            // 
            this.ReservationDataSet.DataSetName = "ReservationDataSet";
            this.ReservationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ReservationRiminder
            // 
            this.ReservationRiminder.AssociatedScheduler = this.ReservationScheduler;
            this.ReservationRiminder.ThemeName = "TelerikMetro";
            this.ReservationRiminder.TimeInterval = 60000;
            this.ReservationRiminder.AlarmFormShowing += new System.EventHandler<Telerik.WinControls.UI.RadAlarmFormShowingEventArgs>(this.ReservationRiminder_AlarmFormShowing);
            this.ReservationRiminder.ItemOpened += new System.EventHandler<Telerik.WinControls.UI.RadOpenItemArgs>(this.ItemOpened);
            // 
            // resourceTableAdapter1
            // 
            this.resourceTableAdapter1.ClearBeforeFill = true;
            // 
            // reservationTableAdapter1
            // 
            this.reservationTableAdapter1.ClearBeforeFill = true;
            // 
            // Reservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 518);
            this.ControlBox = false;
            this.Controls.Add(this.ReservationScheduler);
            this.Controls.Add(this.ReservationNavigator);
            this.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Reservation";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "Reservation";
            this.Load += new System.EventHandler(this.Reservation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ReservationNavigator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReservationScheduler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReservationBindingDataSource.EventProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReservationBindingDataSource.ResourceProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReservationBindingDataSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resourceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReservationDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.Themes.TelerikMetroTheme telerikMetroTheme1;
        private Telerik.WinControls.UI.RadSchedulerNavigator ReservationNavigator;
        private Telerik.WinControls.UI.RadScheduler ReservationScheduler;
        private Telerik.WinControls.UI.SchedulerBindingDataSource ReservationBindingDataSource;
        private System.Windows.Forms.BindingSource resourceBindingSource;
        private Resource ReservationDataSet;
        private ResourceTableAdapters.resourceTableAdapter resourceTableAdapter1;
        private ResourceTableAdapters.reservationTableAdapter reservationTableAdapter1;
        private Telerik.WinControls.UI.RadSchedulerReminder ReservationRiminder;
        //private ResourceTableAdapters.reservationresourceTableAdapter reservationresourceTableAdapter1;
    }
}