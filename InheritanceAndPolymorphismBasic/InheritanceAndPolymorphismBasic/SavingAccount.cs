using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphismBasic
{
   public class SavingAccount:BankAccount
    {
        public double InterestAmount { get; set; }
        public override string Withdrow(double amount)
        {
            if (Balance - amount <= 0)
            {
                return "Insufisiands Balance";
               
            }
            else
            {
                return base.Withdrow(amount);
            }
        }
    }
}
