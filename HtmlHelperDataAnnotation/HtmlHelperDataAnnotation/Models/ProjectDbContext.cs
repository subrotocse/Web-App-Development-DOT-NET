using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace HtmlHelperDataAnnotation.Models
{
    public class ProjectDbContext:DbContext
    {
        public DbSet<Student> MyProperty { get; set; }
    }
}