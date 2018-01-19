using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace OneToManyMvcEFCodeFirst.Models
{
    public class UniversityDbContext:DbContext
    {
        public DbSet<Department> Departments { get; set; }
        public DbSet<Student> Students { get; set; } 
    }
}