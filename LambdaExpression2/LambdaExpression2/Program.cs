using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpression2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>() 
            {
                "subroto","subr","suvo","Masum","subroto"
            };
           string found= names.Find(name => name.Contains("subroto"));
           string find = names.Find(name=>name.StartsWith("M"));
           Console.WriteLine("Names Found "+found);
           Console.WriteLine(find);

           List<double> numbers = new List<double>()
           {
               1,2,35,1,9,10
           };
           double result = numbers.Find(number => number > 9);
           Console.WriteLine(result);
           List<Book> bookList = new List<Book>()
           {
              new Book{AuthorName="subroto", Price=20.0,},
              new Book{AuthorName="ubro", Price=200.0,},
              new Book{AuthorName="sub", Price=20.0,},
           };
           var books = bookList.FindAll(book=>book.AuthorName.StartsWith("s"));
           foreach (var book in books)
           {
               Console.WriteLine(book.AuthorName); 
           }
           Console.ReadLine();
        }
    }
}
