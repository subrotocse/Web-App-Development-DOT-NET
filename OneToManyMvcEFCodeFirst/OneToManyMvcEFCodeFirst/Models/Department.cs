using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OneToManyMvcEFCodeFirst.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public List<Student> Students { get; set; }
    }
}