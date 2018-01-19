using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MigrationAdvanced.Models
{
    public class OrderDetails
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string ContactNo { get; set; }
        public List<Product> Products { get; set; }
    }
}