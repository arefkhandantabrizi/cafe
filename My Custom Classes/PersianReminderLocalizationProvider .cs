using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Telerik.WinControls.UI;

namespace HomeCafe
{
    class PersianReminderLocalizationProvider : RadReminderLocalizationProvider
    {
        public override string GetLocalizedString(string id)
        {
            switch (id)
            {
                case RadReminderStringId.AlarmFormButtonDismiss:
                    return "مرخص کردن";
                case RadReminderStringId.AlarmFormButtonDismissAll:
                    return "مرخص کردن همه";
                case RadReminderStringId.AlarmFormButtonOpenItem:
                    return "باز کردن آیتم";
                case RadReminderStringId.AlarmFormButtonSnooze:
                    return "تعویق";
                case RadReminderStringId.AlarmFormColumnDueIn:
                    return "موعد رزرو";
                case RadReminderStringId.AlarmFormColumnSubject:
                    return "نام مشتری";
                case RadReminderStringId.AlarmFormLabelSnooze:
                    return "برای یاد آوری در بر روی تعویق کلیک کنید: ";
                case RadReminderStringId.AlarmFormReminder:
                    return "یادآوری";
                case RadReminderStringId.AlarmFormReminders:
                    return "یادآوری ها";
                case RadReminderStringId.AlarmFormSnoozeOneMinute:
                    return "1 دقیقه";
                case RadReminderStringId.AlarmFormSnoozeFiveMinutes:
                    return "5 دقیقه";
                case RadReminderStringId.AlarmFormSnoozeTenMinutes:
                    return "10 دقیقه";
                case RadReminderStringId.AlarmFormSnoozeFifteenMinutes:
                    return "15 دقیقه";
                case RadReminderStringId.AlarmFormSnoozeThirtyMinutes:
                    return "30 دقیقه";
                case RadReminderStringId.AlarmFormSnoozeOneHour:
                    return "1 ساعت";
                case RadReminderStringId.AlarmFormSnoozeTwoHours:
                    return "2 ساعت";
                case RadReminderStringId.AlarmFormSnoozeFourHours:
                    return "4 ساعت";
                case RadReminderStringId.AlarmFormSnoozeEightHours:
                    return "8 ساعت";
                case RadReminderStringId.AlarmFormSnoozeHalfDay:
                    return "0.5 روز";
                case RadReminderStringId.AlarmFormSnoozeOneDay:
                    return "1 روز";
                case RadReminderStringId.AlarmFormSnoozeTwoDays:
                    return "2 روز";
                case RadReminderStringId.AlarmFormSnoozeThreeDays:
                    return "3 روز";
                case RadReminderStringId.AlarmFormSnoozeFourDays:
                    return "4 روز";
                case RadReminderStringId.AlarmFormSnoozeOneWeek:
                    return "1 هفته";
                case RadReminderStringId.AlarmFormSnoozeTwoWeeks:
                    return "2 هفته";
                case RadReminderStringId.DueInMinute:
                    return "1 دقیقه";
                case RadReminderStringId.DueInMinutes:
                    return "دقیقه";
                case RadReminderStringId.DueInHour:
                    return "1 ساعت";
                case RadReminderStringId.DueInHours:
                    return "ساعت";
                case RadReminderStringId.DueInDay:
                    return "1 روز";
                case RadReminderStringId.DueInDays:
                    return "روز";
                case RadReminderStringId.DueInWeek:
                    return "1 هفته";
                case RadReminderStringId.DueInWeeks:
                    return "هقته ها";
                case RadReminderStringId.DueInNow:
                    return "حالا";
                case RadReminderStringId.DueInOverdue:
                    return "{0} سررسیده";
                case RadReminderStringId.AlarmFormSelectMoreRemindObjects:
                    return " یادآوری ها انتخاب شده اند.";
            }
            return string.Empty;
        }
    }
}
