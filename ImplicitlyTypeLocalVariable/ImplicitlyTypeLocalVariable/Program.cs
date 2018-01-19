using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplicitlyTypeLocalVariable
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 10;
            string name = "subroto";
            double number2 = 26381.33;
            int[] array = new int[5];
            var value = number;
            var value1 = name;
            var value2 = number2;
            var value3 = array;
            Trainee aTrainee = new Trainee()
            {
                SEID="1234",
                Name="subrato",
                Address="West Rajabazar, Dhaka"

            };

            List<Trainee> trainees = new List<Trainee>() 
            {
                new Trainee()
                {SEID="2237",Name="suvo",Address="rajabazar"},
                aTrainee,
            };
            foreach (var trainee in trainees)
            {
                Console.WriteLine(trainee.SEID+"  "+trainee.Name+"  "+trainee.Address);
            }
            //Console.WriteLine(aTrainee.SEID+"  "+aTrainee.Name+"  "+aTrainee.Address);
            Console.ReadLine();
        }
    }
}
