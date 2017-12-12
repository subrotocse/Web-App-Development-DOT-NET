using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice3SuperShopStore
{
    class Shop
    {
        public string  Name { get; set; }
        public string Address { get; set; }
        public List<Product> ProductList { get; set; }
        public Shop()
        {
            ProductList = new List<Product>();
        }
        public string GetShopFullInformation()
        {
            return  "          "+Name + "        "+Address+"\n";
        }
    }
}
