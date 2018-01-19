using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Web.Mvc;
using System.Web.Configuration;
using System.Data;
using ItemController.Inventory.Core.DAL;
using ItemController.Models;

namespace ItemController.Controllers
{
    public class ItemController : Controller
    {
        ItemManager itemManager = new ItemManager();
        //public string Save(Item item)
        //{
        //    bool isSaved =itemManager.Save(item);
        //    if(isSaved)
        //    {
        //        return "Saved!";
        //    }
        //    else
        //    {
        //        return "Failed";
        //    }
        //}
        List<Item> GetAllItem()
        {
           return new List<Item>()
            {
               new Item{ Id=1,Name="Laptop",UnitPrice=40000},
               new Item{Id=2,Name="Mobile",UnitPrice=5000},
               new Item{Id=3,Name="Electronics",UnitPrice=1000},
            };        
        }
        //public string Find(Item item)
        //{
        //    var items = GetAllItem().Find(c =>c.Id == item.Id);
        //    string foundItem="No Item Found";
        //    if (items!=null)
        //    {              
        //       foundItem=items.Id+"  "+items.Name+"  "+items.UnitPrice;  
        //    }
        //    return foundItem;
        //}
        public ActionResult Index()
        {
            Item item = new Item();
            item.Name = "Pencil";
            item.Id = 12525;
            item.UnitPrice = 2413;
            ViewBag.Item = item;
           return View();
        }
	}
}