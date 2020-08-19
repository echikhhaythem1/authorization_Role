using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RoleBasedAuthorization.Models;

namespace RoleBasedAuthorization.Controllers
{
    public class DoctorsController : Controller
    {
        private readonly MyDbContext db;
        public DoctorsController(MyDbContext db)
        {
            this.db = db;
        }

        public ActionResult Index()
        {
            return View(db.Doctors.ToList());
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateDoctor(Doctors doctor)
        {
            db.Doctors.Add(doctor);
            db.SaveChanges();
            return RedirectToAction("Index", "Doctors");
        }
        [HttpPost]
        public bool Delete(int id)
        {
            try
            {
                Doctors doctor = db.Doctors.Where(s => s.Id == id).First();
                db.Doctors.Remove(doctor);
                db.SaveChanges();
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }

        }
        public ActionResult Update(int id)
        {
            return View(db.Doctors.Where(s => s.Id == id).First());
        }
        [HttpPost]
        public ActionResult UpdateDoctor(Doctors doctor)
        {
            Doctors d = db.Doctors.Where(s => s.Id == doctor.Id).First();
            d.FirstName = doctor.FirstName;
            d.LastName = doctor.LastName;
            d.Phone = doctor.Phone;
            d.Address = doctor.Address;
            d.Specialist = doctor.Specialist;
            db.SaveChanges();
            return RedirectToAction("Index", "Doctors");
        }
    }
}