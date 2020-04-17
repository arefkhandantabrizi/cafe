using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace HomeCafe
{
    public partial class ReservationWithNewFontForm : Telerik.WinControls.UI.Scheduler.Dialogs.EditAppointmentDialog
    {
        Font f = new Font(new FontFamily("B Kamran"), 16.0f);
        Font f_small = new Font(new FontFamily("B Kamran"), 12.0f);
        public ReservationWithNewFontForm()
        {
            InitializeComponent();
    
        }

        private void ReservationWithNewFontForm_Load(object sender, EventArgs e)
        {
            
        }

        //protected override void LoadSettingsFromEvent(Telerik.WinControls.UI.IEvent sourceEvent)
        //{
        //    base.LoadSettingsFromEvent(sourceEvent);
        //    dateStart.Culture = PersianCultureHelper.GetFixedPersianCulture();
        //    dateEnd.Culture = PersianCultureHelper.GetFixedPersianCulture();
        //    var reservationWithNewFont = sourceEvent as ReservationWithNewFont;
        //}

        //protected override void ApplySettingsToEvent(Telerik.WinControls.UI.IEvent targetEvent)
        //{
        //    var reservationWithNewFont = targetEvent as ReservationWithNewFont;
        //    base.ApplySettingsToEvent(targetEvent);
        //}

        //protected override Telerik.WinControls.UI.IEvent CreateNewEvent()
        //{
        // //   return new ReservationWithNewFont();
        //}



    }
}
