using System;

namespace LibrarySystemB
{
    class Program
    {
        static void Main()
        {
            var catalog = new Catalog();
            var librarian = new Librarian("Alice");
            var reader = new Reader("Bob", "bob@example.com");

            Console.WriteLine("Welcome to the Library System!");

            while (true)
            {
                Console.WriteLine("\nChoose an action:");
                Console.WriteLine("1. Add a Book");
                Console.WriteLine("2. Remove a Book");
                Console.WriteLine("3. Search for a Book");
                Console.WriteLine("4. Exit");

                Console.Write("Enter your choice: ");
                int choice;
                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter book title: ");
                        string title = Console.ReadLine();

                        Console.Write("Enter book author: ");
                        string author = Console.ReadLine();

                        var book = new Book { Title = title, Author = author };
                        librarian.AddBook(catalog, book);
                        break;

                    case 2:
                        Console.Write("Enter the title of the book to remove: ");
                        string removeTitle = Console.ReadLine();
                        librarian.RemoveBook(catalog, removeTitle);
                        break;

                    case 3:
                        Console.Write("Enter book title to search: ");
                        string searchTitle = Console.ReadLine();
                        librarian.SearchBook(catalog, searchTitle);
                        break;

                    case 4:
                        Console.WriteLine("Goodbye!");
                        return;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
    }
}