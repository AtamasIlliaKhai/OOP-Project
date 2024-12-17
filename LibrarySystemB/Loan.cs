using LibrarySystemB;
using System;

namespace LibrarySystemB
{
    public class Loan
    {
        public Reader Reader { get; }
        public Book Book { get; }
        public DateTime LoanDate { get; }
        public DateTime DueDate { get; }

        public Loan(Reader reader, Book book, DateTime loanDate, DateTime dueDate)
        {
            Reader = reader;
            Book = book;
            LoanDate = loanDate;
            DueDate = dueDate;
        }

        public bool IsOverdue(DateTime currentDate)
        {
            return currentDate > DueDate;
        }
    }
}