using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DentistCalendar.Data;
using DentistCalendar.Data.Entity;
using DentistCalendar.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DentistCalendar.Controllers
{
    public class AppointmentController : Controller
    {
        private ApplicationDbContext _context;
        public AppointmentController(ApplicationDbContext context)
        {
            _context = context;
        }
       
        public JsonResult GetAppointment()
        {
            var model = _context.Appointments.Include(x => x.User).Select(x => new AppointmentViewModel() //Randevuları ve ona ait doktorları getir
            {
                Dentitst = x.User.Name + " " + x.User.SurName, //doktor
                Patient = x.PatientName + " " + x.PatientSurName, //hasta
                StartDate = x.StartDate,
                EndDate= x.EndDate,
                Description = x.Description,
                UserId = x.UserId
            });
            return Json(model);
        }
        public JsonResult GetAppointmentsByDentist(string userId="") //id ye göre randevu getir
        {
            var model = _context.Appointments.Where(x=>x.UserId == userId)
                .Include(x => x.User).Select(x => new AppointmentViewModel() 
            {
                Dentitst = x.User.Name + " " + x.User.SurName,
                Patient = x.PatientName + " " + x.PatientSurName, 
                StartDate = x.StartDate,
                EndDate = x.EndDate,
                Description = x.Description,
                UserId = x.UserId
            });
            return Json(model);
        }
        [HttpPost]
        public JsonResult AddOrUpdateAppointment(AddOrUpdateAppointmentModel model)
        {
            if (model.Id == 0) //id sıfırsa ekleme işlemi değilse güncelleme işlemi
            {
                Appointment entity = new Appointment() //databaseden gelen entity
                {
                    CreatedDate = DateTime.Now,
                    StartDate = model.StartDate,
                    EndDate = model.EndDate,
                    PatientName = model.PatientName,
                    PatientSurName = model.PatientSurName,
                    Description = model.Description,
                    UserId = model.UserId
                };

                _context.Add(entity); //veritabanına randevu kaydını ekledik
                _context.SaveChanges(); //veritabanını kaydettik
            }
            else
            {
                var entity = _context.Appointments.SingleOrDefault(x => x.Id == model.Id);
                if (entity == null)
                {
                    return Json("Güncellenecek veri bulunamadı");
                }
                entity.UpdatedDate = DateTime.Now;
                entity.PatientName = model.PatientName;
                entity.PatientSurName = model.PatientSurName;
                entity.Description = model.Description;
                entity.StartDate = model.StartDate;
                entity.EndDate = model.EndDate;
                entity.UserId = model.UserId;
                _context.Update(entity);
                _context.SaveChanges();
            }
            return Json("200");
        }

        public JsonResult DeleteAppointment(int id = 0) //Randevu silme işlemi
        {
            var entity = _context.Appointments.SingleOrDefault(x => x.Id == id);
            if (entity == null)
            {
                return Json("Kayıt Bulunamadı");
            }
            _context.Remove(entity);
            _context.SaveChanges();
            return Json("200");
        }
    }
}
