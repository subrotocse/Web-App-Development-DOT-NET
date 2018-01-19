using HtmlHelperDataAnnotation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HtmlHelperDataAnnotation.Controllers
{
    public class StudentController : Controller
    {
        //
        // GET: /Student/
        [HttpPost]
        public ActionResult Index(Student student)
        {
            return View();
        }
        public ActionResult Index()
        {
            var Departments = GetDropdown();
            ViewBag.Departments = Departments;
            return View();
        }
        [HttpPost]
        public ActionResult Save(Student student)
        {
            List<Department> departments = GetDropdown();
            ViewBag.Departments = departments;
            return View();
        }

        private  List<Department> GetDropdown()
        {
            List<Department> departments = new List<Department>()
             {
                 new Department() { Id=1,Code="CSE",Name="Computer Science & Engineering"},
                 new Department() { Id=2,Code="EEE",Name="Electrical & Electronic Engineering"},
                 new Department() { Id=3,Code="SE",Name="Software Engineering"}
              };
            return departments;
        }
        public ActionResult Save()
        {
            List<Department> departments = GetDropdown();
            ViewBag.Departments = departments;
            return View();
        }
	}
}