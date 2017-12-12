using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice4
{
    class BankAccount
    {
        public string AccountNumber { get; set; }
        public string CustomerName { get; set; }
        public double Amount { get; set; }
        public BankAccount(string accountNumber,string customerName)
        {
            AccountNumber = accountNumber;
            CustomerName = customerName;
        }
        public BankAccount()
        {

        }
        public string CreateAccount()
        {
            string account =  CustomerName+ ", Your account Number is "+AccountNumber+" and it's Balance is "+ Amount;
            return account;
        }
        public double Deposit(double balance)
        {
            Amount += balance;
            return Amount;
        }
        public double Withdrow(double balance)
        {
            Amount -= balance;
            return Amount;
        }
    }
}
