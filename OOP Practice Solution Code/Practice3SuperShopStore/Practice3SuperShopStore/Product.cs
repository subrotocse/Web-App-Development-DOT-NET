using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice3SuperShopStore
{
    class Product
    {
        public string ProductId { get; set; }
        public int  Quantity{ get; set; }
        public int GetQuantity()
        {
             if (ProductId==GetAllProductInformation())
             {
                return Quantity += 1;
             }
             else
             {
                 return Quantity = 1;
             }

        }
        public string GetAllProductInformation()
        {
            return"      "+ProductId + "     "+Quantity+"\n";
        }
        public Product()
        {
            //Quantity = 0;
        }
    }
}
