using System;

namespace LibrarySystemB
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

        public bool IsValid(DateTime currentDate)
        {
            return (currentDate - ReservationDate).TotalDays <= 2;
        }
    }
}