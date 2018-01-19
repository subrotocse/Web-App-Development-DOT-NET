using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var trainees = GetTraineeList();
            //var result = trainees;
            var result = from trainee in trainees
                         where trainee.Name == "sub"
                         select new { SEID = trainee.SEID, Name = trainee.Name };
            foreach (var resul in result)
            {
                Console.WriteLine(resul.Name+"  "+resul.SEID);
            }
            Console.ReadKey();
        }
        public static List<Trainee> GetTraineeList()
        {
            List<Trainee> trainee = new List<Trainee>()
            {
                   new Trainee(){SEID="182",Name="subroto"},
                   new Trainee(){SEID="1412",Name="subr"},
                   new Trainee(){SEID="1662",Name="sub"},
                   new Trainee(){SEID="1112",Name="subhto"},
                   new Trainee(){SEID="1152",Name="broto"},
                   new Trainee(){SEID="1332",Name="roto"},
            };
            return trainee;
        }
    }
}
