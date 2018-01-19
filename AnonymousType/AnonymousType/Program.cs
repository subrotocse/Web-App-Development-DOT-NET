using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousType
{
    class Program
    {
        static void Main(string[] args)
        {
            var aCustomer = new 
            {
                Name="Subroto",
                Email="s@gmail.com",
                Phone="0182821201"
            };
            var aProduct = new
            {
                ItemName="Accessories",
                ItemType="Grossaries",
                Quantity=10,
                UnitPrice=121.33M
            };
            var products = new [] 
            {
              aProduct,
              new {
                        ItemName="Pen",
                        ItemType="aries",
                        Quantity=1,
                        UnitPrice=1.33M
                  }
            };
            dynamic aDynamic = products;
              GetProductInfo(aDynamic); //dynamic methos static 
            dynamic dynamicVariable = new { StudentName="subroto",RegNo="29379217"};
            var a=dynamicVariable.StudentName;
            var b=dynamicVariable.RegNo;
            Console.WriteLine(a+"  "+b);
            //foreach (var product in products)
            //{
            //    Console.WriteLine(product.ItemName + "   " + product.ItemType);
            //}
            dynamic bDynamic = new ExpandoObject();
            bDynamic.Name = "subroto";
            var c = bDynamic.Name;
            Console.WriteLine(c);
            Console.ReadLine();
        }
        public static void GetProductInfo(dynamic products)
        {
            foreach (var product in products)
            {
               Console.WriteLine( product.ItemName + product.ItemType);
            }
        }
    }
}
