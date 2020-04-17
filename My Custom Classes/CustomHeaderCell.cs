using System;
using Telerik.WinControls.UI;

namespace HomeCafe.My_Custom_Classes
{
    public class CustomHeaderCell : GridHeaderCellElement
    {
        public CustomHeaderCell(GridViewColumn column, GridRowElement row)
            : base(column, row)
        {

        }

        protected override Type ThemeEffectiveType
        {
            get
            {
                return typeof(GridHeaderCellElement);
            }
        }

        protected override ConditionalFormattingForm CreateConditionalFormattingForm()
        {
            return new CustomConditionalFormattingForm(GridControl, ViewTemplate,
                                                    ColumnInfo as GridViewDataColumn, ElementTree.ThemeName);
        }
    }
}
