using System;

namespace LibrarySystemB

{
    public class Library
    {
        private Catalog catalog;

        public void AssignCatalog(Catalog catalog)
        {
            this.catalog = catalog;
        }

        public void AddBook(Book book)
        {
            catalog?.AddBook(book);
        }

        public void RemoveBook(Book book)
        {
            catalog?.RemoveBook(book);
        }

        public Book SearchBook(string title)
        {
            return catalog?.FindBookByTitle(title);
        }
    }
}