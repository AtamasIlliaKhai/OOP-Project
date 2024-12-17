using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace LibrarySystemB
{
    [TestClass]
    public class LibraryTests
    {
        [TestMethod]
        public void TestAddBook()
        {
            var library = new Library();
            var catalog = new Catalog();
            var book = new Book { Title = "Test Book", Author = "Test Author" };
            library.AssignCatalog(catalog);

            library.AddBook(book);

            Assert.IsNotNull(catalog.FindBookByTitle("Test Book"));
        }

        [TestMethod]
        public void TestRemoveBook()
        {
            var library = new Library();
            var catalog = new Catalog();
            var book = new Book { Title = "Test Book" };
            library.AssignCatalog(catalog);
            library.AddBook(book);

            library.RemoveBook(book);

            Assert.IsNull(catalog.FindBookByTitle("Test Book"));
        }
    }

    [TestClass]
    public class LoanTests
    {
        [TestMethod]
        public void TestLoanIsOverdue()
        {
            var reader = new Reader("John Doe", "john@example.com");
            var book = new Book { Title = "Book 1" };
            var loan = new Loan(reader, book, DateTime.Now.AddDays(-15), DateTime.Now.AddDays(-5));

            Assert.IsTrue(loan.IsOverdue(DateTime.Now));
        }
    }


        [TestClass]
        public class ReservationTests
        {
            [TestMethod]
            public void TestReservationIsValid()
            {
                var reader = new Reader("Jane Doe", "jane@example.com");
                var book = new Book { Title = "Book 2" };
                var reservation = new Reservation(reader, book, DateTime.Now);

                Assert.IsTrue(reservation.IsValid(DateTime.Now.AddDays(1)));
            }
    }

        [TestClass]
        public class CatalogTests
        {
            [TestMethod]
            public void TestAddBookToCatalog()
            {
                var catalog = new Catalog();
                var book = new Book { Title = "Test Book" };

                catalog.AddBook(book);

                Assert.IsNotNull(catalog.FindBookByTitle("Test Book"));
            }

            [TestMethod]
            public void TestRemoveBookFromCatalog()
            {
                var catalog = new Catalog();
                var book = new Book { Title = "Test Book" };
                catalog.AddBook(book);

                catalog.RemoveBook(book);

                Assert.IsNull(catalog.FindBookByTitle("Test Book"));
            }
       }
}