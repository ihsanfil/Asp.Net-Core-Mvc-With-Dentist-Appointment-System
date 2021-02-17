using System;

namespace DentistCalendar
{
    public class AppointmentViewModel
    {
        public int Id { get; set; }
        public string Dentitst { get; internal set; }
        public string PatientName { get; internal set; }
        public string PatientSurName { get; internal set; }
        public DateTime StartDate { get; internal set; }
        public DateTime EndDate { get; internal set; }
        public string Description { get; internal set; }
        public string UserId { get; internal set; }
        public string Color { get; internal set; }
    }
}