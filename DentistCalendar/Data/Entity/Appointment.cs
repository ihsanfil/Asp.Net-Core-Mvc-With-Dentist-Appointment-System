using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DentistCalendar.Data.Entity
{
    public class Appointment //RANDEVULAR
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public AppUser User { get; set; }  // 1'e 1 ilişki her randevu bir doktora atanır dedik.
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        //Hastanın Adı
        public string PatientName { get; set; }
        //Hastanın Soyadı
        public string PatientSurName { get; set; }
        public string Description { get; set; }
    }
}
