using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MigrationAdvanced.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public int ProductTypeId { get; set; }
        public ProductType ProductType { get; set; }
    }
}