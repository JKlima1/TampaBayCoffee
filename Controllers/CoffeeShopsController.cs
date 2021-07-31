using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TampaBayCoffee.Models;

namespace TampaBayCoffee.Controllers
{
    public class CoffeeShopsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: CoffeeShops
        public ActionResult Index()
        {
            return View("ReadOnlyIndex");
        }

        [Authorize]
        // GET: CoffeeShops/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CoffeeShop coffeeShop = db.CoffeeShops.Find(id);
            if (coffeeShop == null)
            {
                return HttpNotFound();
            }
            return View(coffeeShop);
        }

        // GET: CoffeeShops/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CoffeeShops/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,State,County,Zip_Code,StreetName,Add_Number,Longitude,Latitude,NatGrid_Coord,IsRoaster,CoffeeBrandsUsed")] CoffeeShop coffeeShop)
        {
            if (ModelState.IsValid)
            {
                db.CoffeeShops.Add(coffeeShop);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(coffeeShop);
        }

        // GET: CoffeeShops/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CoffeeShop coffeeShop = db.CoffeeShops.Find(id);
            if (coffeeShop == null)
            {
                return HttpNotFound();
            }
            return View(coffeeShop);
        }

        // POST: CoffeeShops/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,State,County,Zip_Code,StreetName,Add_Number,Longitude,Latitude,NatGrid_Coord,IsRoaster,CoffeeBrandsUsed")] CoffeeShop coffeeShop)
        {
            if (ModelState.IsValid)
            {
                db.Entry(coffeeShop).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(coffeeShop);
        }

        // GET: CoffeeShops/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CoffeeShop coffeeShop = db.CoffeeShops.Find(id);
            if (coffeeShop == null)
            {
                return HttpNotFound();
            }
            return View(coffeeShop);
        }

        // POST: CoffeeShops/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CoffeeShop coffeeShop = db.CoffeeShops.Find(id);
            db.CoffeeShops.Remove(coffeeShop);
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
