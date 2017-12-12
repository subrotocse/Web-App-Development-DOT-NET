using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneToManyAssociationLibraryBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Book bBook = new Book();
            Book book1 = new Book("C#.NET Programming", "Bill Gates", "37913", 325);
            Book book2 = new Book("Object Oriented Programming", "jon", "1225", 220);
            Book book3 = new Book("DOT NET MVC 5", "Balagurusamy", "6333", 500);
            Library aLibrary = new Library();
            aLibrary.Name = "Programmer reading Space";

            //No Method Using

            //aLibrary.Books.Add(book1);
            //aLibrary.Books.Add(book2);
            //aLibrary.Books.Add(book3);

            //using Add Method from Library
            aLibrary.AddBook(book1);
            aLibrary.AddBook(book2);
            aLibrary.AddBook(book3);
            double totalPrice = 0;
            foreach (Book aBook in aLibrary.Books)
            {
                Console.WriteLine("Library Name \n"+aLibrary.Name);
                Console.WriteLine("Book Name: "+aBook.BookName + ", Author Name: " + aBook.AuthorName +", ISBN :"+ aBook.ISBN + ", Price :" + aBook.Price);
                totalPrice =totalPrice +aBook.Price;
            }
            Console.WriteLine("Total Price"+totalPrice);
            Console.ReadLine();
        }
    }
}
