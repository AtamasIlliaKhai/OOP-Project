using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    public class Reservation
    {
        public Reader Reader { get; }
        public Book Book { get; }
        public DateTime ReservationDate { get; }

        public Reservation(Reader reader, Book book, DateTime reservationDate)
        {
            Reader = reader;
            Book = book;
            ReservationDate = reservationDate;
        }

        public bool IsValid(DateTime expirationDate)
        {
            throw new NotImplementedException();
        }

    }


}
