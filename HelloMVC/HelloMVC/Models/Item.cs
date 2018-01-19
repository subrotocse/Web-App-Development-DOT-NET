using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HelloMVC.Models
{
    public class Item
    {
        public string Name { get; set; }
        public int UnitPrice { get; set; }

        public Item(string name,int unitPrice)
        {
            this.Name = name;
            this.UnitPrice = unitPrice;
        }
        public Item()
        {

        }
    }
}