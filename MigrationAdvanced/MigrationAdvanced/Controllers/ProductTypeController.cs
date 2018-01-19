using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MigrationAdvanced.Models;

namespace MigrationAdvanced.Controllers
{
    public class ProductTypeController : Controller
    {
        private ProductContext db = new ProductContext();

        // GET: /ProductType/
        public ActionResult Index()
        {
            return View(db.ProductTypes.ToList());
        }

        // GET: /ProductType/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProductType producttype = db.ProductTypes.Find(id);
            if (producttype == null)
            {
                return HttpNotFound();
            }
            return View(producttype);
        }

        // GET: /ProductType/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /ProductType/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="Id,TypeName")] ProductType producttype)
        {
            if (ModelState.IsValid)
            {
                db.ProductTypes.Add(producttype);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(producttype);
        }

        // GET: /ProductType/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProductType producttype = db.ProductTypes.Find(id);
            if (producttype == null)
            {
                return HttpNotFound();
            }
            return View(producttype);
        }

        // POST: /ProductType/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="Id,TypeName")] ProductType producttype)
        {
            if (ModelState.IsValid)
            {
                db.Entry(producttype).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(producttype);
        }

        // GET: /ProductType/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProductType producttype = db.ProductTypes.Find(id);
            if (producttype == null)
            {
                return HttpNotFound();
            }
            return View(producttype);
        }

        // POST: /ProductType/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ProductType producttype = db.ProductTypes.Find(id);
            db.ProductTypes.Remove(producttype);
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
