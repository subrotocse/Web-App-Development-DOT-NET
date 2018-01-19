using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using HtmlHelperDataAnnotation.Models;

namespace HtmlHelperDataAnnotation.Controllers
{
    public class StudentOneController : Controller
    {
        private ProjectDbContext db = new ProjectDbContext();

        // GET: /StudentOne/
        public ActionResult Index()
        {
            return View(db.MyProperty.ToList());
        }

        // GET: /StudentOne/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Student student = db.MyProperty.Find(id);
            if (student == null)
            {
                return HttpNotFound();
            }
            return View(student);
        }

        // GET: /StudentOne/Create
        private List<Department> GetDropdown()
        {
            List<Department> departments = new List<Department>()
             {
             new Department(){Id=0,Code="",Name="...Select..."},
                 new Department() { Id=1,Code="CSE",Name="Computer Science & Engineering"},
                 new Department() { Id=2,Code="EEE",Name="Electrical & Electronic Engineering"},
                 new Department() { Id=3,Code="SE",Name="Software Engineering"}
              };
            return departments;
        }
        public ActionResult Create()
        {
            List<Department> departments = GetDropdown();
            ViewBag.Departments = departments;
            return View();
        }

        // POST: /StudentOne/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="Id,Name,Email,Password,Department,Gender,Address")] Student student)
        {
            List<Department> departments = GetDropdown();
                ViewBag.Departments = departments;
            if (ModelState.IsValid)
            {
               
                db.MyProperty.Add(student);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(student);
        }

        // GET: /StudentOne/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Student student = db.MyProperty.Find(id);
            if (student == null)
            {
                return HttpNotFound();
            }
            return View(student);
        }

        // POST: /StudentOne/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="Id,Name,Email,Password,Department,Gender,Address")] Student student)
        {
            if (ModelState.IsValid)
            {
                db.Entry(student).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(student);
        }

        // GET: /StudentOne/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Student student = db.MyProperty.Find(id);
            if (student == null)
            {
                return HttpNotFound();
            }
            return View(student);
        }

        // POST: /StudentOne/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Student student = db.MyProperty.Find(id);
            db.MyProperty.Remove(student);
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
