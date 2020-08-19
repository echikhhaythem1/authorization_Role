using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RoleBasedAuthorization.Models;

namespace RoleBasedAuthorization.Controllers
{
    public class AdminsController : Controller
    {
        private readonly MyDbContext db;
        public AdminsController(MyDbContext db)
        {
            this.db = db;
        }


        // GET: Admins
        [AuthorizedAction]
        public async Task<IActionResult> Index()
        {
            var myDbContext = db.Admins.Include(a => a.Roles);
            return View(await myDbContext.ToListAsync());
        }
        
        // GET: Admins/Create
        [AuthorizedAction]
        public IActionResult Create()
        {
            ViewBag.RolesId = new SelectList(db.Roles, "Id", "Title");
            return View();
        }

        // POST: Admins/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public async Task<IActionResult> Create([Bind("Id,FullName,Email,Password,RolesId")] Admins admins)
        {
            if (ModelState.IsValid)
            {
                db.Add(admins);
                await db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["RolesId"] = new SelectList(db.Roles, "Id", "Title", admins.RolesId);
            return View(admins);
        }

        // GET: Admins/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var admins = await db.Admins.SingleOrDefaultAsync(m => m.Id == id);
            if (admins == null)
            {
                return NotFound();
            }
            ViewData["RolesId"] = new SelectList(db.Roles, "Id", "Title", admins.RolesId);
            return View(admins);
        }

        // POST: Admins/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FullName,Email,RolesId")] Admins admins)
        {
            if (id != admins.Id)
            {
                return NotFound();
            }

            Admins admin = await db.Admins.Where(s => s.Id == admins.Id).FirstOrDefaultAsync();
            admin.FullName = admins.FullName;
            admin.Email = admins.Email;
            admin.RolesId = admins.RolesId;
            await db.SaveChangesAsync();
            
            return RedirectToAction(nameof(Index));
        }

        // GET: Admins/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var admins = await db.Admins
                .Include(a => a.Roles)
                .SingleOrDefaultAsync(m => m.Id == id);
            if (admins == null)
            {
                return NotFound();
            }

            return View(admins);
        }

        // POST: Admins/DeleteConfirmed/5
        [HttpPost, ActionName("DeleteConfirmed")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var admins = await db.Admins.SingleOrDefaultAsync(m => m.Id == id);
            db.Admins.Remove(admins);
            await db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AdminsExists(int id)
        {
            return db.Admins.Any(e => e.Id == id);
        }
    }
}
