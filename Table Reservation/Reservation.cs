using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Cafe;
using HomeCafe.My_Custom_Classes;
using Telerik.WinControls;
using Telerik.WinControls.Data;
using Telerik.WinControls.UI;
using Telerik.WinControls.UI.Localization;
using Telerik.WinControls.UI.Scheduler.Dialogs;

namespace HomeCafe.Table_Reservation
{
    public partial class Reservation : Form
    {
        private readonly Font _font = new Font("IRANSansDNFaNum", 10.0f, FontStyle.Regular);
        public string FilePath = "C:\\Cafe\\Alarm";
        private Alert.Alert _error;
        private readonly RulerPrimitive _ruler;
        
        public Reservation()
        {
            InitializeComponent();

            var schedulerDayViewElement = ReservationScheduler.SchedulerElement.ViewElement as SchedulerDayViewElement;
            //if (schedulerDayViewElement != null)
            //    _ruler = schedulerDayViewElement.DataAreaElement.Ruler;

            var dayView1 = ReservationScheduler.SchedulerElement.ViewElement as SchedulerDayViewElement;
            if (dayView1 != null)
            {
                dayView1.DataAreaElement.Ruler.RulerRenderer = new
                    MyRulerRenderer(dayView1.DataAreaElement.Ruler);
                _ruler = schedulerDayViewElement.DataAreaElement.Ruler;
            }
                
            _ruler.RulerWidth = 80;
            _ruler.AutoSize = true;
            _ruler.StartScale = 10;
            _ruler.EndScale = 24;
            _ruler.RangeFactor = ScaleRange.HalfHour;
            _ruler.Font = _font;
            _ruler.MinutesFont = _font;

            //ReservationScheduler.ViewElement.Font = _font;
            ReservationScheduler.EnableExactTimeRendering = true;

            RadSchedulerLocalizationProvider.CurrentProvider = new PersianSchedulerLocalizationProvider();
            SchedulerNavigatorLocalizationProvider.CurrentProvider = new CustomSchedulerNavigatorLocalizationProvider();
            RadReminderLocalizationProvider.CurrentProvider = new PersianReminderLocalizationProvider();

            var dayView = ReservationScheduler.GetDayView();
            dayView.WorkWeekStart = DayOfWeek.Saturday;
            dayView.WorkWeekEnd = DayOfWeek.Thursday;

            var appointmentMappingInfo = (ReservationBindingDataSource.EventProvider.Mapping as AppointmentMappingInfo);

            ReservationBindingDataSource.EventProvider.AppointmentFactory = new CustomAppointmentFactory();
            ReservationScheduler.AppointmentFactory = new CustomAppointmentFactory();

            if (appointmentMappingInfo != null)
            {
                appointmentMappingInfo.Mappings.Add(new SchedulerMapping("Dismissed", "Dismissed"));
                appointmentMappingInfo.Mappings.Add(new SchedulerMapping("DismissedDates", "DismissedDates"));

                resourceTableAdapter1.Fill(ReservationDataSet.resource);
                reservationTableAdapter1.Fill(ReservationDataSet.reservation);

                ReservationScheduler.Culture = PersianCultureHelper.GetFixedPersianCulture();

                ReservationScheduler.Appointments.CollectionChanged += Appointments_CollectionChanged;

                var statusIdSchedulermapping = appointmentMappingInfo.FindBySchedulerProperty("StatusId");
                statusIdSchedulermapping.ConvertToScheduler = ConvertStatusIdToScheduler;
                statusIdSchedulermapping.ConvertToDataSource = ConverStatusIdToDataSource;

                var backgroundIdSchedulerMapping = appointmentMappingInfo.FindBySchedulerProperty("BackgroundId");
                backgroundIdSchedulerMapping.ConvertToScheduler = ConvertBackgrounIdToScheduler;
                backgroundIdSchedulerMapping.ConvertToDataSource = ConvertBackgrounIdToDataSource;

                var resouceSchedulermaping = appointmentMappingInfo.FindBySchedulerProperty("ResourceId");
                resouceSchedulermaping.ConvertToDataSource = ConvertResourceToDataSource;
                resouceSchedulermaping.ConvertToScheduler = ConvertResourceToScheduler;
            }

            ReservationScheduler.GroupType = GroupType.Resource;

            var dayView2 = ReservationScheduler.SchedulerElement.ViewElement as SchedulerDayViewGroupedByResourceElement;
            if (dayView2 != null) dayView2.ResourceHeaderHeight = 50;

            ReservationScheduler.ThemeName = "TelerikMetro";
        }

        private void Appointments_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            var appointmentMappingInfo = (ReservationBindingDataSource.EventProvider.Mapping as AppointmentMappingInfo);

            if (appointmentMappingInfo != null)
            {
                var statusIdSchedulermapping = appointmentMappingInfo.FindBySchedulerProperty("StatusId");
                statusIdSchedulermapping.ConvertToScheduler = ConvertStatusIdToScheduler;
                statusIdSchedulermapping.ConvertToDataSource = ConverStatusIdToDataSource;
            }
            if (appointmentMappingInfo != null)
            {
                var backgroundIdSchedulerMapping = appointmentMappingInfo.FindBySchedulerProperty("BackgroundId");
                backgroundIdSchedulerMapping.ConvertToScheduler = ConvertBackgrounIdToScheduler;
                backgroundIdSchedulerMapping.ConvertToDataSource = ConvertBackgrounIdToDataSource;
            }
            if (appointmentMappingInfo != null)
            {
                var resouceSchedulermaping = appointmentMappingInfo.FindBySchedulerProperty("ResourceId");
                resouceSchedulermaping.ConvertToDataSource =ConvertResourceToDataSource;
                resouceSchedulermaping.ConvertToScheduler =ConvertResourceToScheduler;
            }
            var newAppointmentRecords =
             ReservationDataSet.reservation.GetChanges(DataRowState.Added)
             as Resource.reservationDataTable;

            var deletedAppointmentRecords =
                 ReservationDataSet.reservation.GetChanges(DataRowState.Deleted)
                as Resource.reservationDataTable;
             var modifiedAppointmentRecords =
               ReservationDataSet.reservation.GetChanges(DataRowState.Modified)
               as Resource.reservationDataTable;
            try
            {
                ReservationScheduler.LoadReminders(FilePath);
                if (newAppointmentRecords != null)
                {
                    var newAppointmentIds = new Dictionary<int, int>();
                    var oldAppointmentIds = new Dictionary<object, int>();
                    for (var i = 0; i < newAppointmentRecords.Count; i++)
                    {
                        oldAppointmentIds.Add(newAppointmentRecords[i], newAppointmentRecords[i].ID);
                    }
                    reservationTableAdapter1.Update(newAppointmentRecords);
                    for (var i = 0; i < newAppointmentRecords.Count; i++)
                    {
                        newAppointmentIds.Add(oldAppointmentIds[newAppointmentRecords[i]], newAppointmentRecords[i].ID);
                    }
                }
                if (deletedAppointmentRecords != null)
                {
                    reservationTableAdapter1.Update(deletedAppointmentRecords);
                }
                if (modifiedAppointmentRecords != null)
                {
                    reservationTableAdapter1.Update(modifiedAppointmentRecords);
                }
                ReservationDataSet.AcceptChanges();
                ReservationScheduler.SaveReminders(FilePath);
            }
            catch 
            {
                _error = new Alert.Alert("_error", "." + "مشکل در برقراری ارتباط با پایگاه داده") {TopMost = true};
                _error.Show();
            }
        }
        private static object ConvertResourceToScheduler(object item)
        {
            return new EventId(item);
        }
        private static object ConvertResourceToDataSource(object item)
        {
            var resourceId = item as EventId;
            if (resourceId != null && resourceId.KeyValue is int)
            {
                return resourceId.KeyValue;
            }
            return DBNull.Value;
        }

       private void Reservation_Load(object sender, EventArgs e)
        {
            try
            {
                var mainElement = ReservationScheduler.SchedulerElement.ViewElement as SchedulerDayViewGroupedByResourceElement;

                if (mainElement != null)
                    foreach (var dayView in mainElement.Children.OfType<SchedulerDayViewElement>())
                    {
                        dayView.DataAreaElement.Table.ScrollToTime(new TimeSpan(DateTime.Now.Hour, 0, 0));
                    }
                var appointmentMappingInfo = (ReservationBindingDataSource.EventProvider.Mapping as AppointmentMappingInfo);

                if (appointmentMappingInfo != null)
                {
                    var statusIdSchedulermapping = appointmentMappingInfo.FindBySchedulerProperty("StatusId");
                    statusIdSchedulermapping.ConvertToScheduler = ConvertStatusIdToScheduler;
                    statusIdSchedulermapping.ConvertToDataSource = ConverStatusIdToDataSource;
                }

                if (appointmentMappingInfo != null)
                {
                    var backgroundIdSchedulerMapping = appointmentMappingInfo.FindBySchedulerProperty("BackgroundId");
                    backgroundIdSchedulerMapping.ConvertToScheduler = ConvertBackgrounIdToScheduler;
                    backgroundIdSchedulerMapping.ConvertToDataSource = ConvertBackgrounIdToDataSource;
                }

                if (appointmentMappingInfo != null)
                {
                    var resouceSchedulermaping = appointmentMappingInfo.FindBySchedulerProperty("ResourceId");
                    resouceSchedulermaping.ConvertToScheduler = ConvertResourceToScheduler;
                    resouceSchedulermaping.ConvertToDataSource = ConvertResourceToDataSource;
                }

                ReservationRiminder.StartReminder();

                ReservationScheduler.Culture = PersianCultureHelper.GetFixedPersianCulture();
                ReservationScheduler.Font = _font;

                ReservationScheduler.AppointmentTitleFormat = "{2} [{3}]";
                ReservationScheduler.ThemeName = "TelerikMetro";
                ReservationScheduler.EnableExactTimeRendering = true;
            }
            catch 
            {
                _error = new Alert.Alert("Error", "." + "خطایی رخ داده لطفا مجدداً تلاش نمایید") {TopMost = true};
                _error.Show();
                
            }
           
        }

        private static object ConvertBackgrounIdToScheduler(object obj)
        {
            if (obj is DBNull) return AppointmentBackground.None;
            var appointmentBackground = (string)obj;
            switch (appointmentBackground)
            {
                case "Business":
                    return AppointmentBackground.Business;
                case "Important":
                    return AppointmentBackground.Important;
                case "MustAttend":
                    return AppointmentBackground.MustAttend;
                case "PhoneCall":
                    return AppointmentBackground.PhoneCall;
                case "Personal":
                    return AppointmentBackground.Personal;
                case "Vacation":
                    return AppointmentBackground.Vacation;
                case "TravelRequired":
                    return AppointmentBackground.TravelRequired;
                case "NeedsPreparation":
                    return AppointmentBackground.NeedsPreparation;
                case "Birthday":
                    return AppointmentBackground.Birthday;
                case "Anniversary":
                    return AppointmentBackground.Anniversary;
            }
            return AppointmentBackground.None;
        }

        private static object ConvertBackgrounIdToDataSource(object obj)
        {
            var appointmentBackground = (AppointmentBackground)obj;
            switch (appointmentBackground)
            {
                case AppointmentBackground.Business:
                    return "Business";
                case AppointmentBackground.Important:
                    return "Important";
                case AppointmentBackground.MustAttend:
                    return "MustAttend";
                case AppointmentBackground.PhoneCall:
                    return "PhoneCall";
                case AppointmentBackground.NeedsPreparation:
                    return "NeedsPreparation";
                case AppointmentBackground.Birthday:
                    return "Birthday";
                case AppointmentBackground.Anniversary:
                    return "Anniversary";
                case AppointmentBackground.Personal:
                    return "Personal";
                case AppointmentBackground.TravelRequired:
                    return "TravelRequired";
                case AppointmentBackground.Vacation:
                    return "Vacation";
            }
            return "None";
        }

        private void ReservationScheduler_AppointmentFormatting(object sender, SchedulerAppointmentEventArgs e)
        {
            e.AppointmentElement.Font = _font;
            e.AppointmentElement.UseHtml = false;
            e.AppointmentElement.ShowAppointmentDescription = true;
        }

        private static object ConvertStatusIdToScheduler(object obj)
        {
            if (obj is DBNull) return AppointmentStatus.Busy;
            var appointmentStatus = (string)obj;
            switch (appointmentStatus)
            {
                case "Free":
                    return AppointmentStatus.Free;
                case "Tentative":
                    return AppointmentStatus.Tentative;
                case "Unavailable":
                    return AppointmentStatus.Unavailable;
            }
            return AppointmentStatus.Busy;
        }

        private static object ConverStatusIdToDataSource(object obj)
        {
            var appointmentStatus = (AppointmentStatus)obj;
            switch (appointmentStatus)
            {
                case AppointmentStatus.Free:
                    return "Free";
                case AppointmentStatus.Tentative:
                    return "Tentative";
                case AppointmentStatus.Unavailable:
                    return "Unavailable";
            }
            return AppointmentStatus.Busy;
        }

        private void ReservationNavigator_MonthViewClick(object sender, EventArgs e)
        {
            ReservationScheduler.ThemeName = "TelerikMetro";
            var dayView = ReservationScheduler.GetMonthView();

            dayView.WorkWeekStart = DayOfWeek.Saturday;
            dayView.WorkWeekEnd = DayOfWeek.Thursday;
        }

        private void ReservationNavigator_TimelineViewClick(object sender, EventArgs e)
        {
            ReservationScheduler.ThemeName = "TelerikMetro";
            var focusedDate = DateTime.Now;
            ReservationScheduler.FocusedDate = focusedDate;
            ReservationScheduler.ActiveViewType = SchedulerViewType.Timeline;
            var timelineview = ReservationScheduler.GetTimelineView();
            timelineview.ShowTimescale(Timescales.Hours);
            var startDate = timelineview.StartDate.Date;
            timelineview.StartDate = startDate.AddHours(focusedDate.Hour);
            
            RadSchedulerLocalizationProvider.CurrentProvider = new PersianSchedulerLocalizationProvider();
            ReservationScheduler.Font = _font;
        }

        private void ReservationScheduler_CellFormatting(object sender, SchedulerCellEventArgs e)
        {
            ReservationScheduler.ThemeName = "TelerikMetro";
            e.CellElement.Font = _font;
            e.CellElement.AutoSize = true;
            e.CellElement.StretchVertically = true;
            e.CellElement.Opacity = 1;
            
            if (e.CellElement is SchedulerResourceHeaderCellElement)
            {
                e.CellElement.BackColor = Color.LightGreen;
            }
            if (e.CellElement is SchedulerHeaderCellElement)
            {
                if (e.CellElement.Text == @"Local")
                    e.CellElement.Text = @"زمان محلی";
            }
            if (e.CellElement != null && !(e.CellElement is SchedulerResourceHeaderCellElement) && !(e.CellElement is SchedulerHeaderCellElement))
            {
                e.CellElement.BackColor = Color.White;
                e.CellElement.GradientStyle = GradientStyles.Solid;
            }

            var appointmentMappingInfo = ReservationBindingDataSource.EventProvider.Mapping as AppointmentMappingInfo;

            if (appointmentMappingInfo != null)
            {
                var statusIdSchedulermapping = appointmentMappingInfo.FindBySchedulerProperty("StatusId");
                statusIdSchedulermapping.ConvertToScheduler = ConvertStatusIdToScheduler;
                statusIdSchedulermapping.ConvertToDataSource = ConverStatusIdToDataSource;
            }

            if (appointmentMappingInfo != null)
            {
                var backgroundIdSchedulerMapping = appointmentMappingInfo.FindBySchedulerProperty("BackgroundId");
                backgroundIdSchedulerMapping.ConvertToScheduler = ConvertBackgrounIdToScheduler;
                backgroundIdSchedulerMapping.ConvertToDataSource = ConvertBackgrounIdToDataSource;
            }

            if (appointmentMappingInfo == null) return;
            var resouceSchedulermaping = appointmentMappingInfo.FindBySchedulerProperty("ResourceId");
            resouceSchedulermaping.ConvertToDataSource = ConvertResourceToDataSource;
            resouceSchedulermaping.ConvertToScheduler = ConvertResourceToScheduler;
        }

        private void ReservationScheduler_ContextMenuOpening(object sender, SchedulerContextMenuOpeningEventArgs e)
        {
            e.Menu.DropDown.Font = _font;
            for (var i = 0; i < e.Menu.Items.Count; i++)
                if (e.Menu.Items[i].Text == @"مقیاس زمانی")
                    e.Menu.Items[i].Visibility = ElementVisibility.Collapsed;    
        }

        private IEditAppointmentDialog _appointmentDialog;
    

        private void ReservationScheduler_AppointmentEditDialogShowing_1(object sender, AppointmentEditDialogShowingEventArgs e)
        {
            if (_appointmentDialog == null)
                _appointmentDialog = new ReservationWithNewFontForm();

            e.AppointmentEditDialog = _appointmentDialog;
        }

        private void ReservationScheduler_RecurrenceEditDialogShowing(object sender, RecurrenceEditDialogShowingEventArgs e)
        {
            e.RecurrenceEditDialog = new MyEditRecurrenceDialog(e.Appointment);
        }

        private void ReservationScheduler_ActiveViewChanged(object sender, SchedulerViewChangedEventArgs e)
        {
            if (e.NewView.ViewType != SchedulerViewType.Day && e.NewView.ViewType != SchedulerViewType.Week)
            {
                if (e.NewView.ViewType != SchedulerViewType.Month)
                {
                    if (e.NewView.ViewType == SchedulerViewType.Timeline)
                    {
                        var timelineElement =
                            ReservationScheduler.SchedulerElement.ViewElement as TimelineGroupingByResourcesElement;
                        if (timelineElement != null) timelineElement.ResourceHeaderWidth = 150;
                    }
                }
                else
                {
                    var monthView =
                        ReservationScheduler.SchedulerElement.ViewElement as SchedulerMonthViewGroupedByResourceElement;
                    if (monthView != null) monthView.ResourceHeaderHeight = 50;
                }
            }
            else
            {
                var dayView =
                    ReservationScheduler.SchedulerElement.ViewElement as SchedulerDayViewGroupedByResourceElement;
                if (dayView != null) dayView.ResourceHeaderHeight = 50;
            }
            switch (ReservationScheduler.ActiveViewType)
            {
                case SchedulerViewType.Month:
                    ReservationNavigator.DateLabelElement.Text = null;
                    ReservationScheduler.ActiveViewType = SchedulerViewType.Month;
                    var monthview = ReservationScheduler.GetMonthView();
                    monthview.WorkWeekStart = DayOfWeek.Saturday;
                    monthview.WorkWeekEnd = DayOfWeek.Thursday;
                    break;

                case SchedulerViewType.Week:
                    ReservationNavigator.DateLabelElement.Text = null;
                    ReservationScheduler.ActiveViewType = SchedulerViewType.Week;
                    var weekview = ReservationScheduler.GetWeekView();
                    weekview.WorkWeekStart = DayOfWeek.Saturday;
                    weekview.WorkWeekEnd = DayOfWeek.Thursday;
                    break;

                case SchedulerViewType.Day:
                    ReservationNavigator.DateLabelElement.Text = null;
                    ReservationScheduler.ActiveViewType = SchedulerViewType.Day;
                    var dayview = ReservationScheduler.GetDayView();
                    dayview.WorkWeekStart = DayOfWeek.Saturday;
                    dayview.WorkWeekEnd = DayOfWeek.Thursday;
                    var mainElement = ReservationScheduler.SchedulerElement.ViewElement as SchedulerDayViewGroupedByResourceElement;
                    if (mainElement != null)
                        foreach (var dayView in mainElement.Children.OfType<SchedulerDayViewElement>())
                        {
                            dayView.DataAreaElement.Table.ScrollToTime(new TimeSpan(DateTime.Now.Hour, 0, 0));
                        }
                    break;

                case SchedulerViewType.Timeline:
                    ReservationNavigator.DateLabelElement.Text = null;
                    ReservationScheduler.ActiveViewType = SchedulerViewType.Timeline;
                    ReservationScheduler.GetTimelineView();
                    break;
                case SchedulerViewType.MultiDay:
                    break;
                case SchedulerViewType.WorkWeek:
                    break;
                case SchedulerViewType.Agenda:
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        private void ItemOpened(object sender, RadOpenItemArgs e)
        {
            if (_appointmentDialog == null)
                _appointmentDialog = new CustomEditAppointmentDialog((IEvent) e.RemindObject, ReservationScheduler);
            _appointmentDialog.ShowDialog();
        }

        public class CustomEditAppointmentDialog : EditAppointmentDialog
        {
            public CustomEditAppointmentDialog(IEvent iEvent, RadScheduler radScheduler) : base(iEvent, radScheduler)
            {
            }
        }

        private void ReservationRiminder_AlarmFormShowing(object sender, RadAlarmFormShowingEventArgs e)
        {
            var radForm = e.AlarmForm as RadForm;
            if (radForm != null) radForm.RightToLeft = RightToLeft.Yes;
            var form = e.AlarmForm as RadForm;
            if (form != null) form.Font = _font;
            var alaram = (e.AlarmForm as RadAlarmForm);
            SetFontForControls(alaram);
            var alarmForm = e.AlarmForm as RadAlarmForm;

            if (alarmForm == null) return;
            var grid = alarmForm.Controls["radGridViewEvents"] as RadGridView;
            if (grid == null) return;
            grid.CreateCell += grid_CreateCell;
            grid.ViewCellFormatting += grid_ViewCellFormatting;
            RadGridLocalizationProvider.CurrentProvider = new MyPersianRadGridLocalizationProvider();
            grid.ContextMenuOpening += grid_ContextMenuOpening;
            grid.ConditionalFormattingFormShown += grid_ConditionalFormattingFormShown;

            if (grid.ColumnCount <= 0) return;
            for (var i = 0; i < grid.ColumnCount; i++)
                grid.Columns[i].TextAlignment = ContentAlignment.MiddleCenter;
        }

        private void grid_ConditionalFormattingFormShown(object sender, EventArgs e)
        {
            var form = (ConditionalFormattingForm) sender;
            SetFormFont(form.Controls);
        }

        private readonly Font _f = new Font("IRANSansDNFaNum", 9.0f, FontStyle.Regular);

        private void SetFormFont(IEnumerable controls)
        {
            foreach (Control c in controls)
            {
                c.Font = _f;
                if (c.HasChildren)
                {
                    SetFormFont(c.Controls);
                }
            }
        }

        void grid_ContextMenuOpening(object sender, ContextMenuOpeningEventArgs e)
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

        void grid_ViewCellFormatting(object sender, CellFormattingEventArgs e)
        {
            e.CellElement.Font = _font;
        }

        void grid_CreateCell(object sender, GridViewCreateCellEventArgs e)
        {
            if (e.CellType == typeof (GridHeaderCellElement))
            {
                e.CellType = typeof (CustomHeaderCell);
            }
            if (e.CellType == typeof (GridHeaderCellElement))
            {
                e.CellType = typeof (CustomGridHeaderCellElement);
            }
        }

        private void SetFontForControls(Control parentControl)
        {
            var allControls = ControlHelper.GetChildControls<Control>(parentControl, true);
            foreach (var c in allControls)
            {
                c.Font = _font;
            }
        }
    }
}
