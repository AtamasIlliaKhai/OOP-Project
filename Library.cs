using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    public class Library
    {
        private Catalog catalog;

        public void AssignCatalog(Catalog catalog)
        {
            this.catalog = catalog;
        }

        public Book SearchBook(string title)
        {
            return catalog.FindBookByTitle(title);
        }

        public void AddBook(Book book)
        {
            catalog.AddBook(book);
        }

        public void RemoveBook(Book book)
        {
            catalog.RemoveBook(book);
        }
    }

}