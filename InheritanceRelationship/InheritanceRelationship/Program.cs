using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceRelationship
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount aBankAccount = new BankAccount();
            aBankAccount.AccountNumber = "3322-882";
            aBankAccount.Deposit(20000);
            aBankAccount.Deposit(1000);
            aBankAccount.Withdrow(3000);
            double balance=aBankAccount.Balance;
            Console.WriteLine("Bank account Balance"+balance);

            SavingAccount aSavingAccount = new SavingAccount();
            aSavingAccount.AccountNumber = "774-222";
            aSavingAccount.Deposit(10000);
            aSavingAccount.Deposit(2000);
            aSavingAccount.Withdrow(2000);
            double balance3=aBankAccount.Balance;
            Console.WriteLine("Saving Account Balance" + balance3);
            double balance1 = aSavingAccount.Balance;
            Console.WriteLine("Saving Account Balance"+balance1);
            Console.ReadLine();
        }
    }
}
