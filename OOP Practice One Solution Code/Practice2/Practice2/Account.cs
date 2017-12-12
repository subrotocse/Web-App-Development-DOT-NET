using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2
{
    class Account
    {
        public string AccountNo{ get; set; }
        public string OpeningDate { get; set; }
        public string AccountType { get; set; }
        public string Duration { get; set; } 
        public Account()
        {

        }
        public string GetAccountFullInformation()
        {
            return AccountNo + " " + OpeningDate + "  " + AccountType + " " + Duration;
        }
        
    }
}
