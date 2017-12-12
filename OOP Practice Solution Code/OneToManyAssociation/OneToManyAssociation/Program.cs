using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneToManyAssociation
{
    class Program
    {
        static void Main(string[] args)
        {
            Student aStudent = new Student("subroto","141352057","s@gmail.com","01706681577");
            Student bStudent = new Student("suvo","1461411","g@gamil.com","`820820`8`2");
            Student cStudent = new Student("chowdary", "180830242", "c@gamil.com", "9347973w3");
            Department bDepartment = new Department("cse", "3421-373"); 
            Department aDepartment = new Department();
            aDepartment.StudentList.Add(aStudent);
            aDepartment.StudentList.Add(bStudent);
            aDepartment.StudentList.Add(cStudent);
            Console.WriteLine(bDepartment.GetDepartInformation());
            foreach (Student dStudent  in  aDepartment.StudentList)
            {
               string student= dStudent.GetFullInformation();
               Console.WriteLine(student);
            }
            Console.ReadLine();
        }
    }
}
