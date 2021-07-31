using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using TampaBayCoffee.Models;

namespace TampaBayCoffee.Controllers.Api
{
    public class CoffeeShopsController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: api/CoffeeShops
        public IQueryable<CoffeeShop> GetCoffeeShops()
        {
            return db.CoffeeShops;
        }

        // GET: api/CoffeeShops/5
        [ResponseType(typeof(CoffeeShop))]
        public IHttpActionResult GetCoffeeShop(int id)
        {
            CoffeeShop coffeeShop = db.CoffeeShops.Find(id);
            if (coffeeShop == null)
            {
                return NotFound();
            }

            return Ok(coffeeShop);
        }

        // PUT: api/CoffeeShops/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutCoffeeShop(int id, CoffeeShop coffeeShop)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != coffeeShop.Id)
            {
                return BadRequest();
            }

            db.Entry(coffeeShop).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CoffeeShopExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/CoffeeShops
        [ResponseType(typeof(CoffeeShop))]
        public IHttpActionResult PostCoffeeShop(CoffeeShop coffeeShop)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.CoffeeShops.Add(coffeeShop);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = coffeeShop.Id }, coffeeShop);
        }

        // DELETE: api/CoffeeShops/5
        [ResponseType(typeof(CoffeeShop))]
        public IHttpActionResult DeleteCoffeeShop(int id)
        {
            CoffeeShop coffeeShop = db.CoffeeShops.Find(id);
            if (coffeeShop == null)
            {
                return NotFound();
            }

            db.CoffeeShops.Remove(coffeeShop);
            db.SaveChanges();

            return Ok(coffeeShop);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool CoffeeShopExists(int id)
        {
            return db.CoffeeShops.Count(e => e.Id == id) > 0;
        }
    }
}