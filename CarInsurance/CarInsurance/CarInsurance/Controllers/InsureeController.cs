using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CarInsurance.Models;

namespace CarInsurance.Controllers
{
    public class InsureeController : Controller
    {
        private InsuranceEntities db = new InsuranceEntities();
        private InsuranceEntities _context = new InsuranceEntities();

        public ActionResult CreateFromViewModel(InsureeViewModel model)
        {
            if (ModelState.IsValid)
            {
                decimal quote = 50.00m; // Base quote

                // Age calculation
                if (model.DateOfBirth <= 18)
                    quote += 100.00m;
                else if (model.DateOfBirth >= 19 && model.Age <= 25)
                    quote += 50.00m;
                else
                    quote += 25.00m;

                // Car year calculation
                if (model.CarYear < 2000)
                    quote += 25.00m;
                else if (model.CarYear > 2015)
                    quote += 25.00m;

                // Car Make calculation
                if (model.CarMake == "Porsche")
                {
                    quote += 25.00m;
                    if (model.CarModel == "911 Carrera")
                        quote += 25.00m;
                }

                // Speeding tickets calculation
                quote += model.SpeedingTickets * 10.00m;

                // DUI calculation
                if (model.DUI)
                    quote *= 1.25m; // Increase by 25%

                // Full coverage calculation
                if (model.FullCoverage)
                    quote *= 1.50m; // Increase by 50%

                // Save quote to database
                var insuree = new Insuree
                {
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    Email = model.Email,
                    Quote = quote
                };
                _context.Insurees.Add(insuree);
                _context.SaveChanges();

                return RedirectToAction("Index", "Home"); // Redirect to home page after submission
            }

            return View(model); // Return the view with errors if ModelState is not valid
        }

        // GET: Insuree/AdminView
        public ActionResult AdminView()
        {
            var insurees = _context.Insurees.ToList(); // Retrieve all Insurees with quotes
            return View(insurees);
        }




        // GET: Insuree
        public ActionResult Index()
        {
            return View(db.Insurees.ToList());
        }

        // GET: Insuree/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // GET: Insuree/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Insuree/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create2([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                db.Insurees.Add(insuree);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(insuree);
        }

        // GET: Insuree/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                db.Entry(insuree).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(insuree);
        }

        // GET: Insuree/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Insuree insuree = db.Insurees.Find(id);
            db.Insurees.Remove(insuree);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}