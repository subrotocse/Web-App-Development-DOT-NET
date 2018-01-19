using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MyFirstAppEFCodeFirst.Models
{
    public class CityDbContext:DbContext
    {
        public DbSet<Student> students { get; set; }
    }
}