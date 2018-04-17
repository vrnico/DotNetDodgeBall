using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DodgeBall.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DodgeBall.Controllers
{
    public class DivisionController : Controller
    {
        private DodgeBallDbContext db = new DodgeBallDbContext();
        public IActionResult Index()
        {
            List<Division> model = db.Divisions.ToList();
            return View();
        }
        public IActionResult Details(int id)
        {
            var thisDivision = db.Divisions.Include(division => division.Teams).FirstOrDefault(divisions => divisions.DivisionId == id);
            return View(thisDivision);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Division division)
        {
            db.Divisions.Add(division);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int id)
        {
            var thisDivision = db.Divisions.FirstOrDefault(divisions => divisions.DivisionId == id);
            ViewBag.DivisionId = new SelectList(db.Teams, "TeamId", "Name");
            return View(thisDivision);
        }
        [HttpPost]
        public IActionResult Edit(Division division)
        {
            db.Entry(division).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            var thisDivision = db.Divisions.FirstOrDefault(divisions => divisions.DivisionId == id);
            return View(thisDivision);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var thisDivision = db.Divisions.FirstOrDefault(divisions => divisions.DivisionId == id);
            db.Divisions.Remove(thisDivision);
            db.SaveChanges();
            return RedirectToAction("Index")
        }
    }

}
