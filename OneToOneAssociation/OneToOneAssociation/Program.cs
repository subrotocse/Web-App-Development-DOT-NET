using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneToOneAssociation
{
    class Program
    {
        static void Main(string[] args)
        {
            Person aPerson = new Person();
            aPerson.FirstName = "subroto";
            aPerson.MiddleName = "ghosh";
            aPerson.LastName = "subro";
            Address address1 = new Address();
            address1.RoadNo="22/3";
            address1.HouseNo="3/23";
            address1.PostCode=1214;
            address1.Thana="Dhaka";
            address1.District="Dhaka Metro";
            aPerson.personAddress = address1;
           string fullAddress=address1.GetFullAdderss();
           string fullInformation = aPerson.GetFullInformation();
            //string fullInformation = "Post Code :"+aPerson.personAddress.PostCode+"\nThana :"+aPerson.personAddress.Thana+"\nHouse No :"+aPerson.personAddress.HouseNo+"\nDistrict :"+address1.District;
           Console.WriteLine("Person Full Information");
           Console.WriteLine(fullInformation);
           Console.WriteLine("\nPerson Full Address");
           Console.WriteLine(fullAddress);
           Console.ReadLine();
        }
    }
}
