using HelloMVC.BAL;
using HelloMVC.DAL;
using HelloMVC.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.Mvc;

namespace HelloMVC.Controllers
{
    public class HelloWorldController : Controller
    {
       
        public string SayHello(Student student,string name,string regNo,string email,int? age)
        {
            if (student.age > 0 && student.age < 200)
            {
                if (student.age > 0 && student.age < 18)
                {
                    return "<h1>under 18 Not permitted</h1>" + "<h1>Hello MVC! my name is " + student.Name + "  " + student.RegNo + " " + student.Email + "</h1>";
                }
                else if (student.age >= 18 && student.age <= 30)
                {
                    return "<h1>Young Age</h1>" + "<h1>Hello MVC! my name is " + student.Name + "  " + student.RegNo + " " + student.Email + "</h1>";
                }
                else if (student.age >= 31 && student.age <= 50)
                {
                    return "<h1>Middle age person</h1>" + "<h1>Hello MVC! my name is " + student.Name + "  " + student.RegNo + " " + student.Email + "</h1>";
                }
                return null;
             
            }
            else
            {
                return "out of range age value";
            }

            
        }

        public ActionResult Save()
        {
            return View();
        }
     
        [HttpPost]
        public ActionResult Save(Item item)
        {
            ItemManager itemManager = new ItemManager();
            //bool isExist = false;
            //if(isExist)
            //{
            //    itemManager.IsExistCheck(item);
            //}
           
            if (item.Name == null && item.UnitPrice == 0)
            {
                ViewBag.Message1 = "Please Provide Information";
            }
            if(item.Name!=null && item.UnitPrice!=0)
            {
                if (itemManager.Save(item)> 0)
                {
                    ViewBag.Message = "Saved";
                }
               
                else
                {
                    ViewBag.Message = "Failed";
                }
            }
            //bool isexist;

           item=itemManager.Exist();
           ViewBag.Message3 = "Exist";
            return View();            
        }
	}
}