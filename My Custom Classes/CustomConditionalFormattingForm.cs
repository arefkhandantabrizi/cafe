using System;
using System.Drawing;
using Telerik.WinControls.UI;

namespace HomeCafe.My_Custom_Classes
{
    public partial class CustomConditionalFormattingForm : ConditionalFormattingForm
    {
        static Font _font = new Font("IRANSansDNFaNum", 9.0f, FontStyle.Regular);
        public CustomConditionalFormattingForm(RadGridView radGridView, GridViewTemplate template, GridViewDataColumn column, string themeName)
            : base(radGridView, template, column, themeName)
        {
            Font = _font;

        }

        public sealed override Font Font
        {
            get { return base.Font; }
            set { base.Font = value; }
        }


        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            RadDropDownList list = (RadDropDownList)Controls["radComboBoxColumns"];
            //list.Font = _font;
            for (int i = list.Items.Count - 1; i >= 0; i--)
            {
                RadListDataItem item = list.Items[i];
                //item.Font = _font;
                GridViewColumn column = (GridViewColumn)item.Value;
                if (!column.IsVisible || !column.VisibleInColumnChooser)
                {
                    list.Items.RemoveAt(i);
                }
            }

        }
    }
}
