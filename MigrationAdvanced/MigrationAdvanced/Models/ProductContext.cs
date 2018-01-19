using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MigrationAdvanced.Models
{
    public class ProductContext:DbContext
    {
        public DbSet<ProductType> ProductTypes { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }

    }
}