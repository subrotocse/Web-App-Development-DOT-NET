using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneToManyAssociationLibraryBook
{
    class Book
    {
        public string  BookName { get; set; }
        public string AuthorName { get; set; }
        public string  ISBN { get; set; }
        public double Price{ get; set; }
        public Book(string bookName,string authorName,string isbn,double price)
        {
            BookName = bookName;
            AuthorName = authorName;
            ISBN = isbn;
            Price = price;
        }
        public Book()
        {

        }

    }
}
