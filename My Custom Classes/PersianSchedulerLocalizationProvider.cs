using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Telerik.WinControls.UI.Localization;

namespace Cafe
{
    class PersianSchedulerLocalizationProvider : RadSchedulerLocalizationProvider
    {
        public override string GetLocalizedString(string id)
        {
            switch (id)
            {
                case RadSchedulerStringId.NextAppointment: return "رزرو بعدی";
                case RadSchedulerStringId.PreviousAppointment: return "رزرو قبلی";
                case RadSchedulerStringId.AppointmentDialogTitle: return "اصلاح رزرو";
                case RadSchedulerStringId.AppointmentDialogSubject: return "نام مشتری:";
                case RadSchedulerStringId.AppointmentDialogLocation: return "شماره میز:";
                case RadSchedulerStringId.AppointmentDialogBackground: return "رنگ پیش زمینه:";
                case RadSchedulerStringId.AppointmentDialogDescription: return "توضیحات:";
                case RadSchedulerStringId.AppointmentDialogStartTime: return "زمان شروع:";
                case RadSchedulerStringId.AppointmentDialogEndTime: return "زمان پایان:";
                case RadSchedulerStringId.AppointmentDialogAllDay: return "رویداد یک روز کامل";
                case RadSchedulerStringId.AppointmentDialogResource: return "مکان:";
                case RadSchedulerStringId.AppointmentDialogStatus: return "نمایش به صورت:";
                case RadSchedulerStringId.AppointmentDialogOK: return "تایید";
                case RadSchedulerStringId.AppointmentDialogCancel: return "لغو";
                case RadSchedulerStringId.AppointmentDialogDelete: return "پاک کردن";
                case RadSchedulerStringId.AppointmentDialogRecurrence: return "تکرار";

                case RadSchedulerStringId.OpenRecurringDialogTitle: return "باز کردن آیتم های تکرار";
                case RadSchedulerStringId.DeleteRecurrenceDialogOK: return "تایید";
                case RadSchedulerStringId.OpenRecurringDialogOK: return "تایید";

                case RadSchedulerStringId.DeleteRecurrenceDialogCancel: return "لغو";
                case RadSchedulerStringId.OpenRecurringDialogCancel: return "لغو";
                case RadSchedulerStringId.OpenRecurringDialogLabel: return "\"{0}\" یک قرار ملاقات\nتکرار شونده است.آیا شما مایلید که \nتنها این تکرار را باز کنید یا کل دنباله را؟ ";

                case RadSchedulerStringId.OpenRecurringDialogRadioOccurrence: return "این رزرو را باز کن.";
                case RadSchedulerStringId.OpenRecurringDialogRadioSeries: return "دنباله را باز کن.";

                case RadSchedulerStringId.DeleteRecurrenceDialogTitle: return "تایید حذف";
                case RadSchedulerStringId.DeleteRecurrenceDialogRadioOccurrence: return "حذف این رزرو.";
                case RadSchedulerStringId.DeleteRecurrenceDialogRadioSeries: return "حذف دنباله.";
                case RadSchedulerStringId.DeleteRecurrenceDialogLabel: return " آیا شما مایلید که تمام تکرارهای  رزرو\"{0}\",را پاک کنید یا تنها همین رزرو ?";

                case RadSchedulerStringId.RecurrenceDragDropCreateExceptionDialogText: return "شما تاریخ یک رویداد از یک رزرو تکرار شونده را تغییر داده اید. برای تغییر تمام تاریخ ها، کل سری را باز کن. \n آیا شما می خواهید تنها همین رزرو را تغییر دهید؟";
                case RadSchedulerStringId.RecurrenceDragDropValidationSameDateText: return "دو رزرو از یک رویداد نمی تواند در یک روز اتفاق بیافتد.";
                case RadSchedulerStringId.RecurrenceDragDropValidationSkipOccurrenceText: return " نمی توان یک رویداد از یک رزرو تکرار شونده را برنامه ریزی مجدد کرد اگر آن یک تکرار بعدی از همان قرار را رد کند.";

                case RadSchedulerStringId.RecurrenceDialogMessageBoxText: return "تاریخ شروع باید پیش از تاریخ خاتمه باشد.";
                case RadSchedulerStringId.RecurrenceDialogMessageBoxWrongRecurrenceRuleText: return "الگوی تکرار معتبر نیست.";
                case RadSchedulerStringId.RecurrenceDialogMessageBoxTitle: return "خطای اعتبارسنجی";
                case RadSchedulerStringId.RecurrenceDialogTitle: return "اصلاح تکرار";
                case RadSchedulerStringId.RecurrenceDialogAppointmentTimeGroup: return "زمان رزرو";
                case RadSchedulerStringId.RecurrenceDialogDuration: return "مدت:";
                case RadSchedulerStringId.RecurrenceDialogAppointmentEnd: return "خاتمه:";
                case RadSchedulerStringId.RecurrenceDialogAppointmentStart: return "شروع:";
                case RadSchedulerStringId.RecurrenceDialogRecurrenceGroup: return "الگوی تکرار";
                case RadSchedulerStringId.RecurrenceDialogRangeGroup: return "محدوده تکرار";
                case RadSchedulerStringId.RecurrenceDialogOccurrences: return "تکرار";
                case RadSchedulerStringId.RecurrenceDialogRecurrenceStart: return "شروع:";
                case RadSchedulerStringId.RecurrenceDialogYearly: return "سالانه";
                case RadSchedulerStringId.RecurrenceDialogHourly: return "ساعتی";
                case RadSchedulerStringId.RecurrenceDialogMonthly: return "ماهانه";
                case RadSchedulerStringId.RecurrenceDialogWeekly: return "هفتگی";
                case RadSchedulerStringId.RecurrenceDialogDaily: return "روزانه";
                case RadSchedulerStringId.RecurrenceDialogEndBy: return "خاتمه در:";
                case RadSchedulerStringId.RecurrenceDialogEndAfter: return "خاتمه بعد از:";
                case RadSchedulerStringId.RecurrenceDialogNoEndDate: return "بدون تاریخ پایان";
                case RadSchedulerStringId.RecurrenceDialogAllDay: return "رویداد یک روز کامل";
                case RadSchedulerStringId.RecurrenceDialogDurationDropDown1Day: return "1 روز";
                case RadSchedulerStringId.RecurrenceDialogDurationDropDown2Days: return "2 روز";
                case RadSchedulerStringId.RecurrenceDialogDurationDropDown3Days: return "3 روز";
                case RadSchedulerStringId.RecurrenceDialogDurationDropDown4Days: return "4 روز";
                case RadSchedulerStringId.RecurrenceDialogDurationDropDown1Week: return "1 هفته";
                case RadSchedulerStringId.RecurrenceDialogDurationDropDown2Weeks: return "2 هفته";

               

                case RadSchedulerStringId.RecurrenceDialogOK: return "تایید";
                case RadSchedulerStringId.RecurrenceDialogCancel: return "لغو";
                case RadSchedulerStringId.RecurrenceDialogRemoveRecurrence: return "برداشتن تکرار";

                case RadSchedulerStringId.HourlyRecurrenceEvery: return "هر";
                case RadSchedulerStringId.HourlyRecurrenceHours: return "ساعت";

                case RadSchedulerStringId.DailyRecurrenceEveryDay: return "هر";
                case RadSchedulerStringId.DailyRecurrenceEveryWeekday: return "تمام هفته";
                case RadSchedulerStringId.DailyRecurrenceDays: return "روز";

                case RadSchedulerStringId.WeeklyRecurrenceRecurEvery: return "تکرار در هر";
                case RadSchedulerStringId.WeeklyRecurrenceWeeksOn: return "هفته در:";
                case RadSchedulerStringId.WeeklyRecurrenceSunday: return "یکشنبه";
                case RadSchedulerStringId.WeeklyRecurrenceMonday: return "دوشنبه";
                case RadSchedulerStringId.WeeklyRecurrenceTuesday: return "سه شنبه";
                case RadSchedulerStringId.WeeklyRecurrenceWednesday: return "چهارشنبه";
                case RadSchedulerStringId.WeeklyRecurrenceThursday: return "پنج شنبه";
                case RadSchedulerStringId.WeeklyRecurrenceFriday: return "جمعه";
                case RadSchedulerStringId.WeeklyRecurrenceSaturday: return "شنبه";

                case RadSchedulerStringId.WeeklyRecurrenceDay: return "روز";
                case RadSchedulerStringId.WeeklyRecurrenceWeekday: return "روز هفته";
                case RadSchedulerStringId.WeeklyRecurrenceWeekendDay: return "روز تعطیل هفته";


                case RadSchedulerStringId.MonthlyRecurrenceDay: return "روز";
                case RadSchedulerStringId.MonthlyRecurrenceWeek: return "";
                case RadSchedulerStringId.MonthlyRecurrenceDayOfMonth: return "از هر";
                case RadSchedulerStringId.MonthlyRecurrenceMonths: return "ماه";
                case RadSchedulerStringId.MonthlyRecurrenceWeekOfMonth: return "از هر";
                case RadSchedulerStringId.MonthlyRecurrenceFirst: return "اولین";
                case RadSchedulerStringId.MonthlyRecurrenceSecond: return "دومین";
                case RadSchedulerStringId.MonthlyRecurrenceThird: return "سومین";
                case RadSchedulerStringId.MonthlyRecurrenceFourth: return "چهارمین";
                case RadSchedulerStringId.MonthlyRecurrenceLast: return "آخرین";

                case RadSchedulerStringId.YearlyRecurrenceDayOfMonth: return "هر";
                case RadSchedulerStringId.YearlyRecurrenceWeekOfMonth: return "";
                case RadSchedulerStringId.YearlyRecurrenceOfMonth: return "از";
                case RadSchedulerStringId.YearlyRecurrenceJanuary: return "ژانویه";
                case RadSchedulerStringId.YearlyRecurrenceFebruary: return "فوریه";
                case RadSchedulerStringId.YearlyRecurrenceMarch: return "مارس";
                case RadSchedulerStringId.YearlyRecurrenceApril: return "آوریل";
                case RadSchedulerStringId.YearlyRecurrenceMay: return "مه";
                case RadSchedulerStringId.YearlyRecurrenceJune: return "جون";
                case RadSchedulerStringId.YearlyRecurrenceJuly: return "جولای";
                case RadSchedulerStringId.YearlyRecurrenceAugust: return "آگوست";
                case RadSchedulerStringId.YearlyRecurrenceSeptember: return "سپتامبر";
                case RadSchedulerStringId.YearlyRecurrenceOctober: return "اکتبر";
                case RadSchedulerStringId.YearlyRecurrenceNovember: return "نوامبر";
                case RadSchedulerStringId.YearlyRecurrenceDecember: return "دسامبر";

                case RadSchedulerStringId.BackgroundNone: return "هیچ";
                case RadSchedulerStringId.BackgroundImportant: return "مهم";
                case RadSchedulerStringId.BackgroundBusiness: return "کاری";
                case RadSchedulerStringId.BackgroundPersonal: return "شخصی";
                case RadSchedulerStringId.BackgroundVacation: return "تعطیلات";
                case RadSchedulerStringId.BackgroundMustAttend: return "ولنتاین";
                case RadSchedulerStringId.BackgroundTravelRequired: return "تولد کودک";
                case RadSchedulerStringId.BackgroundNeedsPreparation: return "آماده سازی";
                case RadSchedulerStringId.BackgroundBirthday: return "تولد";
                case RadSchedulerStringId.BackgroundAnniversary: return "سالگرد";
                case RadSchedulerStringId.BackgroundPhoneCall: return "تماس تلفنی";


                


                case RadSchedulerStringId.StatusBusy: return "مشغول";
                case RadSchedulerStringId.StatusFree: return "آزاد";
                case RadSchedulerStringId.StatusTentative: return "قرار مجدد";
                case RadSchedulerStringId.StatusUnavailable: return "عدم دسترسی";

                case RadSchedulerStringId.ReminderNone: return "هیچ";
                case RadSchedulerStringId.ReminderZeroMinutes: return "دقیقه 0";
                case RadSchedulerStringId.ReminderFiveMinutes: return "دقیقه 5";
                case RadSchedulerStringId.ReminderTenMinutes: return "10 دقیقه";
                case RadSchedulerStringId.ReminderFifteenMinutes: return "15 دقیقه";
                case RadSchedulerStringId.ReminderThirtyMinutes: return "30 دقیقه";
                case RadSchedulerStringId.ReminderOneHour: return "1 ساعت";
                case RadSchedulerStringId.ReminderTwoHours: return "2 ساعت";
                case RadSchedulerStringId.ReminderThreeHours: return "3 ساعت";
                case RadSchedulerStringId.ReminderFourHours: return "4 ساعت";
                case RadSchedulerStringId.ReminderFiveHours: return "5 ساعت";
                case RadSchedulerStringId.ReminderSixHours: return "6 ساعت";
                case RadSchedulerStringId.ReminderSevenHours: return "7 ساعت";
                case RadSchedulerStringId.ReminderEightHours: return "8 ساعت";
                case RadSchedulerStringId.ReminderNineHours: return "9 ساعت";
                case RadSchedulerStringId.ReminderTenHours: return "10 ساعت";
                case RadSchedulerStringId.ReminderElevenHours: return "11 ساعت";
                case RadSchedulerStringId.ReminderTwelveHours: return "12 ساعت";
                case RadSchedulerStringId.ReminderEighteenHours: return "18 ساعت";
                case RadSchedulerStringId.ReminderOneDay: return "1 روز";
                case RadSchedulerStringId.ReminderTwoDays: return "2 روز";
                case RadSchedulerStringId.ReminderThreeDays: return "3 روز";
                case RadSchedulerStringId.ReminderFourDays: return "4 روز";
                case RadSchedulerStringId.ReminderOneWeek: return "1 هفته";
                case RadSchedulerStringId.ReminderTwoWeeks: return "2 هفته";
                case RadSchedulerStringId.Reminder: return "یادآوری";

                case RadSchedulerStringId.ContextMenuNewAppointment: return "رزرو  جدید";
                case RadSchedulerStringId.ContextMenuEditAppointment: return "اصلاح قرار";
                case RadSchedulerStringId.ContextMenuNewRecurringAppointment: return "رزرو تکرار شونده جدید";
                case RadSchedulerStringId.ContextMenu60Minutes: return "دقیقه 60";
                case RadSchedulerStringId.ContextMenu30Minutes: return "30 دقیقه";
                case RadSchedulerStringId.ContextMenu15Minutes: return "15 دقیقه";
                case RadSchedulerStringId.ContextMenu10Minutes: return "10 دقیقه";
                case RadSchedulerStringId.ContextMenu6Minutes: return "6 دقیقه";
                case RadSchedulerStringId.ContextMenu5Minutes: return "5 دقیقه";
                case RadSchedulerStringId.ContextMenuNavigateToNextView: return "نمایش بعدی";
                case RadSchedulerStringId.ContextMenuNavigateToPreviousView: return "نمایش پیشین";
                case RadSchedulerStringId.ContextMenuTimescales: return "مقیاس زمانی";
                case RadSchedulerStringId.ContextMenuTimescalesYear: return "سال";
                case RadSchedulerStringId.ContextMenuTimescalesMonth: return "ماه";
                case RadSchedulerStringId.ContextMenuTimescalesWeek: return "هفته";
                case RadSchedulerStringId.ContextMenuTimescalesDay: return "روز";
                case RadSchedulerStringId.ContextMenuTimescalesHour: return "ساعت";
                case RadSchedulerStringId.ContextMenuTimescalesHalfHour: return "30 دقیقه";
                case RadSchedulerStringId.ContextMenuTimescalesFifteenMinutes: return "15 دقیقه";

                case RadSchedulerStringId.ErrorProviderWrongAppointmentDates: return "زمان پایان رزرو کمتر یا مساوی زمان شروع است!";
                case RadSchedulerStringId.ErrorProviderWrongExceptionDuration: return "بازه ی تکرار باید بزرگ تر یا مساوی مدت زمان رزرو باشد!";
                case RadSchedulerStringId.ErrorProviderExceptionSameDate: return "دو تکرار از یک رزرو نمی تواند در یک روز اتفاق بیافتد.";
                case RadSchedulerStringId.ErrorProviderExceptionSkipOverDate: return "استثنایی رویداد نمی توان یک رویداد بعدی از همان رزرو را رد کند.";
                case RadSchedulerStringId.TimeZoneLocal: return "زمان محلی";
       
            }

            return string.Empty;
        }
    }
}
