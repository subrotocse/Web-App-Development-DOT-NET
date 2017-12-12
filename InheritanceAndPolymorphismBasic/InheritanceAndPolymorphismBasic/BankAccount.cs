using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphismBasic
{
   public class BankAccount
    {
        public string AccName { get; set; }
        public string AccNumber { get; set; }
        public double Balance { get; private set; }
        public string Deposit(double amount)
        {
           
            Balance += amount;
            return "Deposited";
        }
        public virtual string Withdrow(double amount)
        {           
                Balance -= amount;
                return "Withdrown";
        }
    }
}
