using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    class Department:IBasicInfo
    {
        public string DeptName { get; set; }
        public string DeptCode { get; set; }
        public string Description { get; set; }

        public string GetBasicInfo()
        {
            return DeptName + "  " + DeptCode + "  " + Description;
        }
    }
}
