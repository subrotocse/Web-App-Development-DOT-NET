using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphismBasic
{
    class Program
    {
        static void Main(string[] args)
        {
            SavingAccount aSavingAccount = new SavingAccount();
            aSavingAccount.AccName = "Mr.Abul";
            aSavingAccount.AccNumber = "5377252";
            aSavingAccount.Deposit(20000);
           string sBalance= aSavingAccount.Withdrow(30000);
           sBalance= aSavingAccount.Withdrow(20000);
           Console.WriteLine("Current Balance Saving Account"+sBalance);

           CheckingAccount aCheckingAccount = new CheckingAccount();
           aCheckingAccount.AccName = "Musa Bin";
           aCheckingAccount.AccNumber = "682386";
           aCheckingAccount.Deposit(20000);
           string cBalance = aCheckingAccount.Withdrow(30000);
           Console.WriteLine("Current Balance Checking  Account" + cBalance);
           
            Console.ReadLine();
        }
    }
}
