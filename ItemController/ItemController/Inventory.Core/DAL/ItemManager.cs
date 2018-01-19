using ItemController.Controllers;
using ItemController.Inventory.Core.BLL;
using ItemController.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace ItemController.Inventory.Core.DAL
{
    
    public class ItemManager
    {
        ItemGateway itemGateway = new ItemGateway();
         public bool Save(Item item)
        {
            if(itemGateway.Save(item) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
    }
}