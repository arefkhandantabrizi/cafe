using Telerik.WinControls.UI.Localization;

namespace HomeCafe.My_Custom_Classes
{
    public class MyPersianRadGridLocalizationProvider : RadGridLocalizationProvider
    {
        public override string GetLocalizedString(string id)
        {
            switch (id)
            {
                case RadGridStringId.ConditionalFormattingPleaseSelectValidCellValue: return "لطفا مقدار سلول معتبر انتخاب کنید";
                case RadGridStringId.ConditionalFormattingPleaseSetValidCellValue: return "لطفا مقدار سلول معتبر تنظیم کنید";
                case RadGridStringId.ConditionalFormattingPleaseSetValidCellValues: return "لطفا مقادیر سلول معتبر تنظیم کنید";
                case RadGridStringId.ConditionalFormattingPleaseSetValidExpression: return "لطفا حالت معتبر تنظیم کنید";
                case RadGridStringId.ConditionalFormattingItem: return "آیتم";

                case RadGridStringId.ConditionalFormattingInvalidParameters: return "پارامترهای نا معتبر";
                case RadGridStringId.FilterFunctionBetween: return "ما بین";
                case RadGridStringId.FilterFunctionContains: return "شامل";
                case RadGridStringId.FilterFunctionDoesNotContain: return "شامل نمی شود";
                case RadGridStringId.FilterFunctionEndsWith: return "به پایان می رسد با";
                case RadGridStringId.FilterFunctionEqualTo: return "برابر";
                case RadGridStringId.FilterFunctionGreaterThan: return "بزرگتر از";
                case RadGridStringId.FilterFunctionGreaterThanOrEqualTo: return "بزرگتر از یا مساوی با";
                case RadGridStringId.FilterFunctionIsEmpty: return "خالی است";
                case RadGridStringId.FilterFunctionIsNull: return "تهی است";
                case RadGridStringId.FilterFunctionLessThan: return "کمتر از";
                case RadGridStringId.FilterFunctionLessThanOrEqualTo: return "کمتر از یا مساوی با";
                case RadGridStringId.FilterFunctionNoFilter: return "بدون فیلتر";
                case RadGridStringId.FilterFunctionNotBetween: return "مابین نیست";
                case RadGridStringId.FilterFunctionNotEqualTo: return "برابر نیست با";
                case RadGridStringId.FilterFunctionNotIsEmpty: return "خالی نیست";
                case RadGridStringId.FilterFunctionNotIsNull: return "تهی نیست";
                case RadGridStringId.FilterFunctionStartsWith: return "شروع می شود با";
                case RadGridStringId.FilterFunctionCustom: return "شخصی";

                case RadGridStringId.FilterOperatorBetween: return "مابین";
                case RadGridStringId.FilterOperatorContains: return "شامل";
                case RadGridStringId.FilterOperatorDoesNotContain: return "شامل نمی شود";
                case RadGridStringId.FilterOperatorEndsWith: return "به پایان می رسد با";
                case RadGridStringId.FilterOperatorEqualTo: return "برابر";
                case RadGridStringId.FilterOperatorGreaterThan: return "بزرگتر از";
                case RadGridStringId.FilterOperatorGreaterThanOrEqualTo: return "بزرگتر از یا مساوی با";
                case RadGridStringId.FilterOperatorIsEmpty: return "خالی است";
                case RadGridStringId.FilterOperatorIsNull: return "تهی است";
                case RadGridStringId.FilterOperatorLessThan: return "کمتر از";
                case RadGridStringId.FilterOperatorLessThanOrEqualTo: return "کمتر از یا مساوی با";
                case RadGridStringId.FilterOperatorNoFilter: return "بدون فیلتر";
                case RadGridStringId.FilterOperatorNotBetween: return "مابین نیست";
                case RadGridStringId.FilterOperatorNotEqualTo: return "برابر نیست با";
                case RadGridStringId.FilterOperatorNotIsEmpty: return "خالی نیست";
                case RadGridStringId.FilterOperatorNotIsNull: return "تهی نیست";
                case RadGridStringId.FilterOperatorStartsWith: return "شروع می شود با";
                case RadGridStringId.FilterOperatorIsLike: return "مانند";
                case RadGridStringId.FilterOperatorNotIsLike: return "مانند نباشد";
                case RadGridStringId.FilterOperatorIsContainedIn: return "شامل است در";
                case RadGridStringId.FilterOperatorNotIsContainedIn: return "شامل نیست در";
                case RadGridStringId.FilterOperatorCustom: return "شخصی";

                case RadGridStringId.CustomFilterMenuItem: return "شخصی";
                case RadGridStringId.CustomFilterDialogCaption: return "[{0}] دیالوگ فیلتر کردن";
                case RadGridStringId.CustomFilterDialogLabel: return "نمایش سطر جایکه:";
                case RadGridStringId.CustomFilterDialogRbAnd: return "و";
                case RadGridStringId.CustomFilterDialogRbOr: return "یا";
                case RadGridStringId.CustomFilterDialogBtnOk: return "تایید";
                case RadGridStringId.CustomFilterDialogBtnCancel: return "لغو";
                case RadGridStringId.CustomFilterDialogCheckBoxNot: return "منفی";
                case RadGridStringId.CustomFilterDialogTrue: return "درست";
                case RadGridStringId.CustomFilterDialogFalse: return "نادرست";

                case RadGridStringId.FilterMenuBlanks: return "خالی";
                case RadGridStringId.FilterMenuAvailableFilters: return "فیلترهای موجود";
                case RadGridStringId.FilterMenuSearchBoxText: return "جستجو...";
                case RadGridStringId.FilterMenuClearFilters: return "پاک کردن فیلتر";
                case RadGridStringId.FilterMenuButtonOK: return "تایید";
                case RadGridStringId.FilterMenuButtonCancel: return "لغو";
                case RadGridStringId.FilterMenuSelectionAll: return "تمام";
                case RadGridStringId.FilterMenuSelectionAllSearched: return "نتیجه تمام جستجو";
                case RadGridStringId.FilterMenuSelectionNull: return "تهی";
                case RadGridStringId.FilterMenuSelectionNotNull: return "تهی نیست";

                case RadGridStringId.FilterFunctionSelectedDates: return "فیلتر با تاریخ های مشخص:";
                case RadGridStringId.FilterFunctionToday: return "امروز";
                case RadGridStringId.FilterFunctionYesterday: return "دیروز";
                case RadGridStringId.FilterFunctionDuringLast7days: return "در طول 7 روز گذشته";

                case RadGridStringId.FilterLogicalOperatorAnd: return "و";
                case RadGridStringId.FilterLogicalOperatorOr: return "یا";
                case RadGridStringId.FilterCompositeNotOperator: return "منفی";

                case RadGridStringId.DeleteRowMenuItem: return "حذف سطر";
                case RadGridStringId.SortAscendingMenuItem: return "مرتب سازی صعودی";
                case RadGridStringId.SortDescendingMenuItem: return "مرتب سازی نزولی";
                case RadGridStringId.ClearSortingMenuItem: return "پاک کردن مرتب سازی";
                case RadGridStringId.ConditionalFormattingMenuItem: return "قالب بندی شرطی";
                case RadGridStringId.GroupByThisColumnMenuItem: return "دسته بندی با این ستون";
                case RadGridStringId.UngroupThisColumn: return "عدم دسته بندی این ستون";
                case RadGridStringId.ColumnChooserMenuItem: return "انتخاب گر ستون";
                case RadGridStringId.HideMenuItem: return "مخفی کردن ستون";
                case RadGridStringId.HideGroupMenuItem: return "مخفی کردن دسته بندی";
                case RadGridStringId.UnpinMenuItem: return "باز کردن ستون";
                case RadGridStringId.UnpinRowMenuItem: return "باز کردن سطر";
                case RadGridStringId.PinMenuItem: return "حالت متصل شده";
                case RadGridStringId.PinAtLeftMenuItem: return "متصل کردن در سمت چپ";
                case RadGridStringId.PinAtRightMenuItem: return "متصل کردن در سمت راست";
                case RadGridStringId.PinAtBottomMenuItem: return "متصل کردن در پایین";
                case RadGridStringId.PinAtTopMenuItem: return "متصل کردن در بالا";
                case RadGridStringId.BestFitMenuItem: return "بهترین تناسب";
                case RadGridStringId.PasteMenuItem: return "چسباندن";
                case RadGridStringId.EditMenuItem: return "اصلاح";
                case RadGridStringId.ClearValueMenuItem: return "پاک کردن مقدار";
                case RadGridStringId.CopyMenuItem: return "کپی کردن";
                case RadGridStringId.CutMenuItem: return "برش";
                case RadGridStringId.AddNewRowString: return "برای اضافه کردن سطر جدید اینجا کلیک کنید";
                case RadGridStringId.SearchRowResultsOfLabel: return "از";
                case RadGridStringId.SearchRowMatchCase: return "مورد مشابه";
                case RadGridStringId.ConditionalFormattingSortAlphabetically: return "مرتب سازی براساس حروف الفبا";
                case RadGridStringId.ConditionalFormattingCaption: return "مدیریت قوانین قالب بندی شرطی";
                case RadGridStringId.ConditionalFormattingLblColumn: return "قالب بندی تنها سلول با";
                case RadGridStringId.ConditionalFormattingLblName: return "نام قانون";
                case RadGridStringId.ConditionalFormattingLblType: return "مقدار سلول";
                case RadGridStringId.ConditionalFormattingLblValue1: return "مقدار 1";
                case RadGridStringId.ConditionalFormattingLblValue2: return "مقدار 2";
                case RadGridStringId.ConditionalFormattingGrpConditions: return "قوانین";
                case RadGridStringId.ConditionalFormattingGrpProperties: return "ویژگی های قانون";
                case RadGridStringId.ConditionalFormattingChkApplyToRow: return "این قالب بندی را برای تمام سطر اعمال کن";
                case RadGridStringId.ConditionalFormattingChkApplyOnSelectedRows: return "قالب بندی را اعمال کن اگر سطر انتخاب شده";
                case RadGridStringId.ConditionalFormattingBtnAdd: return " افزودن قانون جدید";
                case RadGridStringId.ConditionalFormattingBtnRemove: return "برداشتن";
                case RadGridStringId.ConditionalFormattingBtnOK: return "تایید";
                case RadGridStringId.ConditionalFormattingBtnCancel: return "لغو";
                case RadGridStringId.ConditionalFormattingBtnApply: return "اعمال";
                case RadGridStringId.ConditionalFormattingRuleAppliesOn: return "اعمال قوانین برای";
                case RadGridStringId.ConditionalFormattingCondition: return "شرایط";
                case RadGridStringId.ConditionalFormattingExpression: return "حالت";
                case RadGridStringId.ConditionalFormattingChooseOne: return "[انتخاب یک]";
                case RadGridStringId.ConditionalFormattingEqualsTo: return " برابر با [مقدار1] ";
                case RadGridStringId.ConditionalFormattingIsNotEqualTo: return "برابر نیست با [مقدار1] ";
                case RadGridStringId.ConditionalFormattingStartsWith: return "شروع با[مقدار1] ";
                case RadGridStringId.ConditionalFormattingEndsWith: return "پایان با [مقدار1]";
                case RadGridStringId.ConditionalFormattingContains: return "شامل [مقدار1]";
                case RadGridStringId.ConditionalFormattingDoesNotContain: return "عدم شمول [مقدار1]";
                case RadGridStringId.ConditionalFormattingIsGreaterThan: return "بزرگتر است از [مقدار1] ";
                case RadGridStringId.ConditionalFormattingIsGreaterThanOrEqual: return "بزرگتر یا مساوی [مقدار1] ";
                case RadGridStringId.ConditionalFormattingIsLessThan: return "کوچکتر از [مقدار1] ";
                case RadGridStringId.ConditionalFormattingIsLessThanOrEqual: return "کوچکتر یا مساوی [مقدار1] ";
                case RadGridStringId.ConditionalFormattingIsBetween: return "بین [مقدار1] و [مقدار2 ]";
                case RadGridStringId.ConditionalFormattingIsNotBetween: return "بین [مقدار1] و [مقدار2] نیست";
                case RadGridStringId.ConditionalFormattingLblFormat: return "قالب بندی";

                case RadGridStringId.ConditionalFormattingBtnExpression: return "ویرایشگر حالت";
                case RadGridStringId.ConditionalFormattingTextBoxExpression: return "حالت";

                case RadGridStringId.ConditionalFormattingPropertyGridCaseSensitive: return "حساس به مورد";
                case RadGridStringId.ConditionalFormattingPropertyGridCellBackColor: return "رنگ پیشین سلول";
                case RadGridStringId.ConditionalFormattingPropertyGridCellForeColor: return "رنگ جلوی سلول";
                case RadGridStringId.ConditionalFormattingPropertyGridEnabled: return "فعال";
                case RadGridStringId.ConditionalFormattingPropertyGridRowBackColor: return "رنگ پیشین سطر";
                case RadGridStringId.ConditionalFormattingPropertyGridRowForeColor: return "رنگ جلوی سطر";
                case RadGridStringId.ConditionalFormattingPropertyGridRowTextAlignment: return "تنظیم متن سطر";
                case RadGridStringId.ConditionalFormattingPropertyGridTextAlignment: return "تنظیم متن";

                case RadGridStringId.ConditionalFormattingPropertyGridCaseSensitiveDescription: return "تعیین می کند که زمانیکه ارزیابی مقادیر رشته انجام می شود مقایسه حساس به حرف صورت می گیرد.";
                case RadGridStringId.ConditionalFormattingPropertyGridCellBackColorDescription: return "رنگ پیش زمینه را وارد کنید تا برای سلول استفاده شود.";
                case RadGridStringId.ConditionalFormattingPropertyGridCellForeColorDescription: return "رنگ جلوی زمینه را وارد کنید تا برای سلول استفاده شود.";
                case RadGridStringId.ConditionalFormattingPropertyGridEnabledDescription: return "تعیین می کند که آیا شرایط فعال است(می تواند ارزیابی و اجرا شود). ";
                case RadGridStringId.ConditionalFormattingPropertyGridRowBackColorDescription: return "رنگ پیش زمینه را وارد کنید تا برای تمام سطر استفاده شود.";
                case RadGridStringId.ConditionalFormattingPropertyGridRowForeColorDescription: return "رنگ جلوی زمینه را وارد کنید تا برای تمام سطر استفاده شود.";
                case RadGridStringId.ConditionalFormattingPropertyGridRowTextAlignmentDescription: return "تنظیم را وارد کنید تا برای مقادیر سلول هنگامی که اعمال در سطر درست است استفاده شود. ";
                case RadGridStringId.ConditionalFormattingPropertyGridTextAlignmentDescription: return "تنظیم را وارد کنید تا برای مقادیر سلول استفاده شود.";

                case RadGridStringId.ColumnChooserFormCaption: return "انتخاب گر ستون";
                case RadGridStringId.ColumnChooserFormMessage: return " عنوان یک ستون را از\nجدول اینجا بکشید تا آن را از \n نمایش فعلی پاک کند.";
                case RadGridStringId.GroupingPanelDefaultMessage: return "یک ستون را اینجا بکشید تا با این ستون گروه بندی صورت گیرد.";
                case RadGridStringId.GroupingPanelHeader: return "گروه بندی با:";
                case RadGridStringId.PagingPanelPagesLabel: return "صفحه";
                case RadGridStringId.PagingPanelOfPagesLabel: return "از";
                case RadGridStringId.NoDataText: return "هیچ داده ای برای نمایش وجود ندارد";
                case RadGridStringId.CompositeFilterFormErrorCaption: return "خطایی فیلتر کردن";
                case RadGridStringId.CompositeFilterFormInvalidFilter: return "توصیف گر فیلتر ترکیبی معتبر نیست.";

                case RadGridStringId.ExpressionMenuItem: return "حالت";
                case RadGridStringId.ExpressionFormTitle: return "سازنده حالت";
                case RadGridStringId.ExpressionFormFunctions: return "توابع";
                case RadGridStringId.ExpressionFormFunctionsText: return "متن";
                case RadGridStringId.ExpressionFormFunctionsAggregate: return "تجمیع";
                case RadGridStringId.ExpressionFormFunctionsDateTime: return "تاریخ-زمان";
                case RadGridStringId.ExpressionFormFunctionsLogical: return "منطقی";
                case RadGridStringId.ExpressionFormFunctionsMath: return "ریاضی";
                case RadGridStringId.ExpressionFormFunctionsOther: return "سایر";
                case RadGridStringId.ExpressionFormOperators: return "عملگر";
                case RadGridStringId.ExpressionFormConstants: return "ثبات";
                case RadGridStringId.ExpressionFormFields: return "زمینه ها";
                case RadGridStringId.ExpressionFormDescription: return "توضیحات";
                case RadGridStringId.ExpressionFormResultPreview: return "نمایش نتایج";
                case RadGridStringId.ExpressionFormTooltipPlus: return "جمع";
                case RadGridStringId.ExpressionFormTooltipMinus: return "تفریق";
                case RadGridStringId.ExpressionFormTooltipMultiply: return "ضرب";
                case RadGridStringId.ExpressionFormTooltipDivide: return "تقسیم";
                case RadGridStringId.ExpressionFormTooltipModulo: return "باقیمانده";
                case RadGridStringId.ExpressionFormTooltipEqual: return "مساوی";
                case RadGridStringId.ExpressionFormTooltipNotEqual: return "نا مساوی";
                case RadGridStringId.ExpressionFormTooltipLess: return "کمتر";
                case RadGridStringId.ExpressionFormTooltipLessOrEqual: return "کمتر یا مساوی";
                case RadGridStringId.ExpressionFormTooltipGreaterOrEqual: return "بزرگتر یا مساوی";
                case RadGridStringId.ExpressionFormTooltipGreater: return "بزرگتر";
                case RadGridStringId.ExpressionFormTooltipAnd: return "منطقی \"AND\"";
                case RadGridStringId.ExpressionFormTooltipOr: return "منطقی \"OR\"";
                case RadGridStringId.ExpressionFormTooltipNot: return "منطقی \"NOT\"";
                case RadGridStringId.ExpressionFormAndButton: return string.Empty; //if empty, default button image is used
                case RadGridStringId.ExpressionFormOrButton: return string.Empty; //if empty, default button image is used
                case RadGridStringId.ExpressionFormNotButton: return string.Empty; //if empty, default button image is used
                case RadGridStringId.ExpressionFormOKButton: return "تایید";
                case RadGridStringId.ExpressionFormCancelButton: return "لغو";
            }

            return string.Empty;
        }
    }
}
