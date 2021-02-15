using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DentistCalendar.Data.Entity
{
    public class AppUser : IdentityUser
    {
        public bool IsDentist { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Color { get; set; }
        public List<Appointment> Appoinments { get; set; } // 1'e çok ilişki 1 doktor'a birden fazla randevu atanabilir.

    }

}
