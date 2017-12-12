using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2
{
    class Program
    {
        static void Main(string[] args)
        {
            Account bAccount = new Account();
            bAccount.AccountNo = "9129-91";
            bAccount.AccountType = "Saving";
            bAccount.OpeningDate = "2017-25-2";
            bAccount.Duration = "4 Years";

            Customer aCustomer = new Customer();
            aCustomer.Name = "subroto";
            aCustomer.Email = "s@gmail.com";
            aCustomer.PhoneNumber = "10919919010";
            aCustomer.PresentAddress = "Rajabazar , Dhaka ";
            aCustomer.CustomerAccount = bAccount;
            string information = aCustomer.CustomerAccount.GetAccountFullInformation();
            string customer = aCustomer.GetCustomerFullInformation();
            Console.WriteLine(customer);
            Console.ReadLine();
        }
    }
}
