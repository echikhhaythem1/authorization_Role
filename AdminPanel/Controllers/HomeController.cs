using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RoleBasedAuthorization.Models;
using RoleBasedAuthorization.ViewModels;
using System.Linq;

namespace RoleBasedAuthorization.Controllers
{
    public class HomeController : Controller
    {
        private readonly MyDbContext db;
        public HomeController(MyDbContext db)
        {
            this.db = db;
        }

        public IActionResult Index()
        {
            DashboardViewModel dashboard = new DashboardViewModel();

            dashboard.doctors_count = db.Doctors.Count();
            dashboard.admins_count = db.Admins.Count();
            dashboard.roles_count = db.Roles.Count();

            if (HttpContext.Session.GetString("email") == null)
            {
                return Redirect("/Account/Login");
            }

            return View(dashboard);
        }


    }
}