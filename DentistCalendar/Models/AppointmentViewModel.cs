using System;

namespace DentistCalendar
{
    public class AppointmentViewModel
    {
        public string Dentitst { get; internal set; }
        public string Patient { get; internal set; }
        public DateTime StartDate { get; internal set; }
        public DateTime EndDate { get; internal set; }
        public string Description { get; internal set; }
        public string UserId { get; internal set; }
    }
}