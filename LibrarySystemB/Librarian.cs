using System;

namespace LibrarySystemB
{
    public class Librarian
    {
        public string Name { get; set; }

        // Конструктор, що приймає ім'я
        public Librarian(string name)
        {
            Name = name;
        }

        // Додає книгу до каталогу
        public void AddBook(Catalog catalog, Book book)
        {
            catalog.AddBook(book);
            Console.WriteLine($"Librarian {Name} added the book: {book.Title}");
        }

        // Видаляє книгу з каталогу
        public void RemoveBook(Catalog catalog, string title)
        {
            var book = catalog.FindBookByTitle(title);
            if (book != null)
            {
                catalog.RemoveBook(book);
                Console.WriteLine($"Librarian {Name} removed the book: {title}");
            }
            else
            {
                Console.WriteLine($"Book '{title}' not found in the catalog.");
            }
        }

        // Шукає книгу в каталозі
        public void SearchBook(Catalog catalog, string title)
        {
            var book = catalog.FindBookByTitle(title);
            if (book != null)
            {
                Console.WriteLine($"Librarian {Name} found the book: {book.Title} by {book.Author}");
            }
            else
            {
                Console.WriteLine($"Book '{title}' not found in the catalog.");
            }
        }
    }
}