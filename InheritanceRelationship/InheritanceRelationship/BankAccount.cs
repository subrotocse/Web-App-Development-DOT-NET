using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceRelationship
{
    class BankAccount
    {
        public string AccountNumber { get; set; }
        public string Name { get; set; }
        public double Balance { get; private set; }
        public string Deposit(double amount)
        {
            Balance = Balance+ amount;
            return "Deposited";
        }
        public string Withdrow(double amount)
        {
            Balance =Balance - amount;
            return "Withdrown";
        }
    }
}
