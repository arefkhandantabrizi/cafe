using Telerik.WinControls.UI;

namespace HomeCafe.My_Custom_Classes
{
    public class CustomSchedulerNavigatorLocalizationProvider : SchedulerNavigatorLocalizationProvider
    {
        public override string GetLocalizedString(string id)
        {
            switch (id)
            {
                case SchedulerNavigatorStringId.DayViewButtonCaption:
                    {
                        return "نمایش روزانه";
                    }
                case SchedulerNavigatorStringId.WeekViewButtonCaption:
                    {
                        return "نمایش هفتگی";
                    }
                case SchedulerNavigatorStringId.MonthViewButtonCaption:
                    {
                        return "نمایش ماهانه";
                    }
                case SchedulerNavigatorStringId.TimelineViewButtonCaption:
                    {
                        return "نمایش جدول زمانی";
                    }
                case SchedulerNavigatorStringId.ShowWeekendCheckboxCaption:
                    {
                        return "نمایش آخر هفته";
                    }
                case SchedulerNavigatorStringId.TodayButtonCaptionToday:
                    {
                        return "امروز";
                    }
                case SchedulerNavigatorStringId.TodayButtonCaptionThisWeek:
                    {
                        return "این هفته";
                    }
                case SchedulerNavigatorStringId.TodayButtonCaptionThisMonth:
                    {
                        return "این ماه";
                    }
                case SchedulerNavigatorStringId.SearchInAppointments:
                    {
                        return " جستجو در رزرو";
                    }

            }
            

            return string.Empty;
        }
    }
}
