using LibrarySystemB;
using System;

namespace LibrarySystemB
{
    public class Reader
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public Reader() { }

        public Reader(string name, string email)
        {
            Name = name;
            Email = email;
        }

        public Reservation ReserveBook(Book book)
        {
            return new Reservation(this, book, DateTime.Now);
        }
    }
}