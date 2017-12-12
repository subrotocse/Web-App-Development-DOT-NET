using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneToManyAssociationLibraryBook
{
    class Library
    {
        public string  Name { get; set; }
        private List<Book> books = new List<Book>();
        public List<Book> Books
        {
            set
            {
                books = value;
            }
            get
            {
                return books;
            }
        }
        public Library()
        {

        }
        public void AddBook(Book aBook)
        {
            books.Add(aBook);
        }
    }
}
