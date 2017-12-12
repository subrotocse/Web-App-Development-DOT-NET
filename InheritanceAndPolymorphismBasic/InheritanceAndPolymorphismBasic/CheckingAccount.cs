using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphismBasic
{
   public class CheckingAccount:BankAccount
    {
        public double ServiceCharge{ get; set; }     
       
      ///it's working ..because this design is a lot of fault or not a good design ...now use polymorphism to good design
       //public string WithDrawByCheckingAccount(double amount)
       // {
       //     BankAccount aAcc = new BankAccount();
       //     aAcc.Deposit(1000);
       //     aAcc.Withdrow(30000);
       //     if (Balance - amount >= 0 || Balance - amount < 0)
       //     {
       //         return "Withdrow Successfully";
       //     }
       //     else
       //     {
       //         return "Not Found";
       //     }
       // }
       
    }
}
