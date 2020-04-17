using System;
using System.Drawing;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using Telerik.WinControls.UI.Scheduler.Dialogs;

namespace HomeCafe.Table_Reservation
{
    public partial class MyEditRecurrenceDialog : EditRecurrenceDialog
    {
        
        Font f_small = new Font(new FontFamily("B Kamran"), 12.0f);
        private MyEditRecurrenceDialog()
            : base(null)
        { }

        public MyEditRecurrenceDialog(IEvent appointment)
            : base(appointment, null)
        {
        }

        public MyEditRecurrenceDialog(IEvent appointment, ISchedulerData schedulerData)
            : base(appointment, schedulerData)
        { }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            SetFontForControls(this);
        }

        private void SetFontForControls(Control parentControl)
        {

            //parentControl.Font = f_small;
            var allControls = ControlHelper.GetChildControls<Control>(parentControl, true);
            foreach (var c in allControls)
            {
                c.Font = f_small;

            }
        }

        protected override void ShowRecurrenceSettingsControl(IRecurrenceRuleSettingsControl settingsControl)
        {

            base.ShowRecurrenceSettingsControl(settingsControl);
            dateStart.Culture = PersianCultureHelper.GetFixedPersianCulture();
            dateEnd.Culture = PersianCultureHelper.GetFixedPersianCulture();

            SetFontForControls((Control)settingsControl);
        }
    }
}
