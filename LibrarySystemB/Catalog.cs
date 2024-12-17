using System.Collections.Generic;
using System.Linq;

namespace LibrarySystemB
{
    public class Catalog
    {
        private List<Book> books = new List<Book>();

        public void AddBook(Book book)
        {
            if (!books.Contains(book))
            {
                books.Add(book);
            }
        }

        public void RemoveBook(Book book)
        {
            books.Remove(book);
        }

        public Book FindBookByTitle(string title)
        {
            return books.FirstOrDefault(b => b.Title == title);
        }
    }
}