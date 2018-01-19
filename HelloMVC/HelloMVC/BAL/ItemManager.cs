using HelloMVC.DAL;
using HelloMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HelloMVC.BAL
{
    public class ItemManager
    {
        ItemGateway itemGateway = new ItemGateway();
       public int  Save(Item item)
        {
           return itemGateway.Save(item); 
        }
       //public string IsExistCheck(Item item)
       //{
       //   if(itemGateway.Save(item)!=item.UnitPrice )
       //   {
       //       return itemGateway.Save(item);
       //   }
       //   else if(itemGateway.Save(item)!=item.Name)
       //   {
       //       return itemGateway.Save(item);
       //   }         
       //   else
       //   {
       //       return itemGateway.Save(item);
       //   }
       //}
        public Item Exist()
       {
           return itemGateway.IsExist();
       }
    }
}