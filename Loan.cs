using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    public class Loan
    {
        public Reader Reader { get; private set; }
        public Book Book { get; private set; }
        public DateTime LoanDate { get; private set; }
        public DateTime DueDate { get; private set; }

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
