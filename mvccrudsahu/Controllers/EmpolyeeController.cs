using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using mvccrudsahu.Models;

namespace mvccrudsahu.Controllers
{
    public class EmpolyeeController : Controller
    {
        private ApplicationDbContext dbContext;
        public EmpolyeeController(ApplicationDbContext DbContext)
        {
            this.dbContext=DbContext;
        }
        public IActionResult Index()
        {
            List<Empolyee> Empolyees = dbContext.Empolyees.ToList();
            return View(Empolyees);
        }
        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Create(Empolyee emp)
        {
            if (ModelState.IsValid)
            {
                dbContext.Empolyees.Add(emp);
                dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View(emp);
            }
        }
        public IActionResult Delete(int id)
        {
            var emp = dbContext.Empolyees.SingleOrDefault(e => e.Id == id);
            if (emp != null)
            {
                dbContext.Empolyees.Remove(emp);
                dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("Index");
            }
            
        }
        public IActionResult Edit(int id)
        {
            var emp = dbContext.Empolyees.SingleOrDefault(e => e.Id == id);
           
                return View(emp);
        }

        [HttpPost]
        public IActionResult Edit(Empolyee emp)
        {
            dbContext.Empolyees.Update(emp);
            dbContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
