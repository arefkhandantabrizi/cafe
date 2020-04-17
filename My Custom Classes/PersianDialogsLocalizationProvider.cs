using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Telerik.WinControls.UI;

namespace HomeCafe
{
    class PersianDialogsLocalizationProvider : PrintDialogsLocalizationProvider
    {
        public override string GetLocalizedString(string id)
        {
            switch (id)
            {
                case PrintDialogsStringId.PreviewDialogTitle: return "پیش نمایش چاپ";
                case PrintDialogsStringId.PreviewDialogPrint: return "چاپ...";
                case PrintDialogsStringId.PreviewDialogPrintSettings: return "تنظیمات چاپ...";
                case PrintDialogsStringId.PreviewDialogWatermark: return "واترمارک...";
                case PrintDialogsStringId.PreviewDialogPreviousPage: return "صفحه پیشین";
                case PrintDialogsStringId.PreviewDialogNextPage: return "صفحه بعد";
                case PrintDialogsStringId.PreviewDialogZoomIn: return "بزرگ نمایی";
                case PrintDialogsStringId.PreviewDialogZoomOut: return "کوچک نمایی";
                case PrintDialogsStringId.PreviewDialogZoom: return "بزرگ نمایی";
                case PrintDialogsStringId.PreviewDialogAuto: return "خودکار";
                case PrintDialogsStringId.PreviewDialogLayout: return "صفحه آرایی";
                case PrintDialogsStringId.PreviewDialogFile: return "فایل";
                case PrintDialogsStringId.PreviewDialogView: return "نمایش";
                case PrintDialogsStringId.PreviewDialogTools: return "ابزار";
                case PrintDialogsStringId.PreviewDialogExit: return "خروج";
                case PrintDialogsStringId.PreviewDialogStripTools: return "ابزارها";
                case PrintDialogsStringId.PreviewDialogStripNavigation: return "جهت یابی";


                case PrintDialogsStringId.WatermarkDialogTitle: return "تنظیمات واترمارک";
                case PrintDialogsStringId.WatermarkDialogButtonOK: return "تایید";
                case PrintDialogsStringId.WatermarkDialogButtonCancel: return "لغو";
                case PrintDialogsStringId.WatermarkDialogLabelPreview: return "نمایش";
                case PrintDialogsStringId.WatermarkDialogButtonRemove: return "حذف واترمارک";
                case PrintDialogsStringId.WatermarkDialogLabelPosition: return "موقعیت";
                case PrintDialogsStringId.WatermarkDialogRadioInFront: return "جلو";
                case PrintDialogsStringId.WatermarkDialogRadioBehind: return "پشت";
                case PrintDialogsStringId.WatermarkDialogLabelPageRange: return "محدوده صفحه";
                case PrintDialogsStringId.WatermarkDialogRadioAll: return "تمام";
                case PrintDialogsStringId.WatermarkDialogRadioPages: return "صفحات";
                case PrintDialogsStringId.WatermarkDialogLabelPagesDescription: return " (مانند. 1،3،5-12(";
                case PrintDialogsStringId.WatermarkDialogTabText: return "متن";
                case PrintDialogsStringId.WatermarkDialogTabPicture: return "تصویر";
                case PrintDialogsStringId.WatermarkDialogLabelText: return "متن";
                case PrintDialogsStringId.WatermarkDialogWatermarkText: return "متن واترمارک";
                case PrintDialogsStringId.WatermarkDialogLabelHOffset: return "افست افقی";
                case PrintDialogsStringId.WatermarkDialogLabelVOffset: return "افست عمودی";
                case PrintDialogsStringId.WatermarkDialogLabelRotation: return "چرخش";
                case PrintDialogsStringId.WatermarkDialogLabelFont: return "فونت:";
                case PrintDialogsStringId.WatermarkDialogLabelSize: return "انداره:";
                case PrintDialogsStringId.WatermarkDialogLabelColor: return "رنگ:";
                case PrintDialogsStringId.WatermarkDialogLabelOpacity: return "تاری:";
                case PrintDialogsStringId.WatermarkDialogLabelLoadImage: return "بارگذاری عکس:";
                case PrintDialogsStringId.WatermarkDialogCheckboxTiling: return "کاشی کاری";


                case PrintDialogsStringId.SettingDialogTitle: return "تنظیمات چاپ";
                case PrintDialogsStringId.SettingDialogButtonPrint: return "چاپ";
                case PrintDialogsStringId.SettingDialogButtonPreview: return "نمایش";
                case PrintDialogsStringId.SettingDialogButtonCancel: return "لغو";
                case PrintDialogsStringId.SettingDialogButtonOK: return "تایید";
                case PrintDialogsStringId.SettingDialogPageFormat: return "قالب";
                case PrintDialogsStringId.SettingDialogPagePaper: return "کاغذ";
                case PrintDialogsStringId.SettingDialogPageHeaderFooter: return "سربرگ/پاورقی";
                case PrintDialogsStringId.SettingDialogButtonPageNumber: return "شماره صفحه";
                case PrintDialogsStringId.SettingDialogButtonTotalPages: return "تمام صفحات";
                case PrintDialogsStringId.SettingDialogButtonCurrentDate: return "تاریخ فعلی";
                case PrintDialogsStringId.SettingDialogButtonCurrentTime: return "زمان فعلی";
                case PrintDialogsStringId.SettingDialogButtonUserName: return "نام کاربری";
                //case PrintDialogsStringId.SettingDialogButtonFont: return "فونت...";
                case PrintDialogsStringId.SettingDialogLabelHeader: return "سربرگ";
                case PrintDialogsStringId.SettingDialogLabelFooter: return "پاورقی";
                case PrintDialogsStringId.SettingDialogCheckboxReverse: return "معکوس در صفحات زوج ";
                case PrintDialogsStringId.SettingDialogLabelPage: return "صفحه";
                case PrintDialogsStringId.SettingDialogLabelType: return "نوع";
                case PrintDialogsStringId.SettingDialogLabelPageSource: return "منبع صفحه";
                case PrintDialogsStringId.SettingDialogLabelMargins: return "حاشیه (اینچ)";
                case PrintDialogsStringId.SettingDialogLabelOrientation: return "جهت";
                case PrintDialogsStringId.SettingDialogLabelTop: return "بالا:";
                case PrintDialogsStringId.SettingDialogLabelBottom: return "پایین";
                case PrintDialogsStringId.SettingDialogLabelLeft: return "چپ:";
                case PrintDialogsStringId.SettingDialogLabelRight: return "راست:";
                case PrintDialogsStringId.SettingDialogRadioPortrait: return "طولی";
                case PrintDialogsStringId.SettingDialogRadioLandscape: return "عرضی";


                case PrintDialogsStringId.SchedulerSettingsLabelPrintStyle: return "سبک چاپ";
                case PrintDialogsStringId.SchedulerSettingsDailyStyle: return "سبک روزانه";
                case PrintDialogsStringId.SchedulerSettingsWeeklyStyle: return "سبک هفتگی";
                case PrintDialogsStringId.SchedulerSettingsMonthlyStyle: return "سبک ماهانه";
                case PrintDialogsStringId.SchedulerSettingsDetailStyle: return "سبک باجزییات";
                case PrintDialogsStringId.SchedulerSettingsButtonWatermark: return "واترمارک...";
                //case PrintDialogsStringId.SchedulerSettingsButtonFont: return "فونت...";
                case PrintDialogsStringId.SchedulerSettingsLabelPrintRange: return "محدوده چاپ";
                case PrintDialogsStringId.SchedulerSettingsLabelStyleSettings: return "تنظیمات سبک";
                case PrintDialogsStringId.SchedulerSettingsLabelPrintSettings: return "تنظیمات چاپ";
                case PrintDialogsStringId.SchedulerSettingsLabelStartDate: return "تاریخ آغاز";
                case PrintDialogsStringId.SchedulerSettingsLabelEndDate: return "تاریخ خاتمه";
                case PrintDialogsStringId.SchedulerSettingsLabelStartTime: return "زمان آغاز";
                case PrintDialogsStringId.SchedulerSettingsLabelEndTime: return "زمان خاتمه";
                case PrintDialogsStringId.SchedulerSettingsLabelDateFont: return "فونت تاریخ سربرگ";
                case PrintDialogsStringId.SchedulerSettingsLabelAppointmentFont: return "فونت قرار ملاقات";
                case PrintDialogsStringId.SchedulerSettingsLabelLayout: return "صفحه آرایی";
                case PrintDialogsStringId.SchedulerSettingsPrintPageTitle: return "عنوان صفحه چاپ";
                case PrintDialogsStringId.SchedulerSettingsPrintCalendar: return "شامل تقویم در عنوان";
                case PrintDialogsStringId.SchedulerSettingsPrintTimezone: return "چاپ منطقه زمانی انتخاب شده";
                case PrintDialogsStringId.SchedulerSettingsPrintNotesBlank: return "منطقه یادداشت (خالی)";
                case PrintDialogsStringId.SchedulerSettingsPrintNotesLined: return "منطقه یادداشت (خط چین)";
                case PrintDialogsStringId.SchedulerSettingsNonworkingDays: return "حذف روزهای غیر کاری";
                case PrintDialogsStringId.SchedulerSettingsExactlyOneMonth: return "چاپ یک ماه کامل";
                case PrintDialogsStringId.SchedulerSettingsLabelWeeksPerPage: return "هفته در هر صفحه";
                case PrintDialogsStringId.SchedulerSettingsNewPageEach: return "شروع صفحه جدید در هر";
                case PrintDialogsStringId.SchedulerSettingsStringDay: return "روز";
                case PrintDialogsStringId.SchedulerSettingsStringMonth: return "ماه";
                case PrintDialogsStringId.SchedulerSettingsStringWeek: return "هفته";
                case PrintDialogsStringId.SchedulerSettingsStringPage: return "صفحه";
                case PrintDialogsStringId.SchedulerSettingsStringPages: return "صفحات";
                case PrintDialogsStringId.SchedulerSettingsLabelGroupBy: return "گروه بندی شده با:";
                case PrintDialogsStringId.SchedulerSettingsGroupByNone: return "هیچ";
                case PrintDialogsStringId.SchedulerSettingsGroupByResource: return "دکتر";
                case PrintDialogsStringId.SchedulerSettingsGroupByDate: return "تاریخ";


                case PrintDialogsStringId.GridSettingsLabelPreview: return "نمایش";
                case PrintDialogsStringId.GridSettingsLabelStyleSettings: return "تنظیمات سبک";
                case PrintDialogsStringId.GridSettingsLabelFitMode: return "حالت تناسب صفحه:";
                case PrintDialogsStringId.GridSettingsLabelHeaderCells: return "سلول های سربرگ";
                case PrintDialogsStringId.GridSettingsLabelGroupCells: return "سلول های گروه";
                case PrintDialogsStringId.GridSettingsLabelDataCells: return "سلول های داده";
                case PrintDialogsStringId.GridSettingsLabelSummaryCells: return "سلول های خلاصه";
                case PrintDialogsStringId.GridSettingsLabelBackground: return "پس زمینه";
                case PrintDialogsStringId.GridSettingsLabelBorderColor: return "رنگ مرز";
                case PrintDialogsStringId.GridSettingsLabelAlternatingRowColor: return "ردیف رنگ متناوب";
                case PrintDialogsStringId.GridSettingsLabelPadding: return "لایه";
                case PrintDialogsStringId.GridSettingsPrintGrouping: return "گروه بندی چاپ";
                case PrintDialogsStringId.GridSettingsPrintSummaries: return "خلاصه چاپ";
                case PrintDialogsStringId.GridSettingsPrintHiddenRows: return "چاپ سطرهای مخفی";
                case PrintDialogsStringId.GridSettingsPrintHiddenColumns: return "چاپ ستون های مخفی";
                case PrintDialogsStringId.GridSettingsPrintHeader: return "چاپ سربرگ در هر صفحه";
                case PrintDialogsStringId.GridSettingsButtonWatermark: return "واترمارک...";
                //case PrintDialogsStringId.GridSettingsButtonFont: return "فونت...";
                case PrintDialogsStringId.GridSettingsFitPageWidth: return "تناسب عرض صفحه";
                case PrintDialogsStringId.GridSettingsNoFit: return "بدون تناسب";
                case PrintDialogsStringId.GridSettingsNoFitCentered: return "بدون تناسب مرکزی";
                case PrintDialogsStringId.GridSettingsLabelPrint: return "چاپ";
            }

            return String.Empty;
        }
    }
}
