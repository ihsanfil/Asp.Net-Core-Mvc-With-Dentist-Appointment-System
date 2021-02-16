using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DentistCalendar.Models
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage ="Lütfen Kullanıcı Adını Belirtiniz.")]
        [Display(Name="Kullanıcı Adınız:")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Lütfen Adınızı Belirtiniz.")]
        [Display(Name = "Adınız:")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Lütfen Soyadınızı Belirtiniz.")]
        [Display(Name = "Soyadınız:")]
        public string SurName { get; set; }

        [Required(ErrorMessage = "Lütfen Bir Şifrenizi Belirleyiniz.")]
        [Display(Name = "Şifreniz:")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Lütfen Bir Eposta Belirtiniz.")]
        [Display(Name = "Emailiniz:")]
        [EmailAddress(ErrorMessage ="Lütfen email alanını kontrol ediniz.")]
        public string Email { get; set; }

        [Display(Name = "Randevu Rengi:")]
        public string Color { get; set; }

        [Display(Name = "Doktorum")]
        public bool IsDentist { get; set; }
    }
}
