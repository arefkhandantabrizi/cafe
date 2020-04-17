using System;
using System.Collections.Generic;
using System.Diagnostics;
using Telerik.WinControls.UI;

namespace HomeCafe.My_Custom_Classes
{
    class CustomAppointmentFactory : IAppointmentFactory
    {
        public IEvent CreateNewAppointment()
        {
            return new CustomAppointment();
        }
    }
    class CustomAppointment : Appointment
    {
        private string _dismissedDates = string.Empty;
        private readonly List<DateTime> _dismissedDatesList = new List<DateTime>();

        public string DismissedDates
        {
            get
            {
                return _dismissedDates;
            }
            set
            {
                if (_dismissedDates != value)
                {
                    _dismissedDates = value;
                    OnPropertyChanged("DismissedDates");
                }
            }
        }

        protected override void OnPropertyChanged(string propertyName)
        {
            if (propertyName == "RecurrenceRule")
            {
                if (RecurrenceRule == null)
                {
                    DismissedDates = string.Empty;
                }
            }

            if (propertyName == "DismissedDates")
            {
                ParseDates();
            }

            if (propertyName == "Dismissed")
            {
                if (Dismissed && MasterEvent != null && !((CustomAppointment)MasterEvent)._dismissedDatesList.Contains(Start))
                {
                    if (((CustomAppointment)MasterEvent).DismissedDates != string.Empty)
                        ((CustomAppointment)MasterEvent).DismissedDates += ";" + Start.Ticks;
                    else
                        ((CustomAppointment)MasterEvent).DismissedDates += Start.Ticks.ToString();
                }
            }

            base.OnPropertyChanged(propertyName);
        }

        private void ParseDates()
        {
            _dismissedDatesList.Clear();

            var entries = DismissedDates.Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string str in entries)
            {
                long ticks;
                if (long.TryParse(str, out ticks))
                {
                    _dismissedDatesList.Add(new DateTime(ticks));
                }
            }
        }

        protected override Event CreateOccurrenceInstance()
        {
            return new CustomAppointment();
        }

        public override IEvent CreateOccurrence(DateTime start)
        {
            var occurrence = base.CreateOccurrence(start) as CustomAppointment;
            Debug.Assert(occurrence != null, "occurrence != null");
            occurrence.Dismissed = _dismissedDatesList.Contains(start);
            return occurrence;
        }
    }

}
