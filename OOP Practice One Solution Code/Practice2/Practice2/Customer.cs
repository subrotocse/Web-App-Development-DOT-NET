using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2
{
    class Customer
    {
        public string Name { get; set; }
        public string Email{ get; set; }
        public string PhoneNumber { get; set; }
        public string PresentAddress { get; set; }
        public Account CustomerAccount { get; set; } 
      
        public Customer()
        {
          
        }
        public string GetCustomerFullInformation()
        {
            return Name + "  " + Email + "  " + PhoneNumber +"  "+ PresentAddress;         
        }

    }
}
