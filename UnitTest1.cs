using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LibrarySystem;

namespace LibrarySystem
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System.Runtime.Remoting.Messaging;

    [TestClass]
    public class LibraryTests
    {
        [TestMethod]
        public void TestAddBook()
        {
            // Arrange
            var library = new Library();
            var book = new Book();

            // Act
            library.AddBook(book);

            // Assert
            Assert.Fail("Not implemented");
        }

        [TestMethod]
        public void TestRemoveBook()
        {
            // Arrange
            var library = new Library();
            var book = new Book();

            // Act
            library.RemoveBook(book);

            // Assert
            Assert.Fail("Not implemented");
        }

        [TestMethod]
        public void TestSearchBookInLibrary()
        {
            // Arrange
            var library = new Library();
            var catalog = new Catalog();
            var book = new Book();
            catalog.AddBook(book);
            library.AssignCatalog(catalog);

            // Act
            var result = library.SearchBook("Sample Title");

            // Assert
            Assert.Fail("Not implemented");
        }

    }


    [TestClass]
    public class LoanTests
    {
        [TestMethod]
        public void TestLoanCreation()
        {
            // Arrange
            var reader = new Reader();
            var book = new Book();
            var loanDate = DateTime.Now;
            var dueDate = loanDate.AddDays(14);

            // Act
            var loan = new Loan(reader, book, loanDate, dueDate);

            // Assert
            Assert.Fail("Not implemented");
        }

        [TestMethod]
        public void TestLoanIsOverdue()
        {
            // Arrange
            var reader = new Reader(); 
            var book = new Book(); 
            var loanDate = DateTime.Now.AddDays(-15); 
            var dueDate = loanDate.AddDays(14); 
            var loan = new Loan(reader, book, loanDate, dueDate);
            var overdueDate = DateTime.Now;

            // Act
            var isOverdue = loan.IsOverdue(overdueDate);

            // Assert
            Assert.Fail("Not implemented");
        }

    }

    [TestClass]
    public class ReservationTests
    {
        [TestMethod]
        public void TestReservationCreation()
        {
            // Arrange
            var reader = new Reader(); 
            var book = new Book();
            var reservationDate = DateTime.Now; 

            // Act
            var reservation = new Reservation(reader, book, reservationDate);

            // Assert
            Assert.Fail("Not implemented");
        }


        [TestMethod]
        public void TestReservationIsValid()
        {
            // Arrange
            var reader = new Reader();
            var book = new Book();
            var reservationDate = DateTime.Now;
            var reservation = new Reservation(reader, book, reservationDate);
            var expirationDate = DateTime.Now.AddDays(1);

            // Act & Assert
            Assert.Fail("Not implemented");
        }



        [TestMethod]
        public void TestDuplicateBookAddition()
        {
            // Arrange
            var catalog = new Catalog();
            var book = new Book();
            catalog.AddBook(book);

            // Act
            catalog.AddBook(book);

            // Assert
            Assert.Fail("Not implemented");
        }

    }



    [TestClass]
    public class CatalogTests
    {
        [TestMethod]
        public void TestFindBookByTitle()
        {
            // Arrange
            var catalog = new Catalog();
            string title = "Sample Book";

            // Act
            var result = catalog.FindBookByTitle(title);

            // Assert
            Assert.Fail("Not implemented");
        }

        [TestMethod]
        public void TestAddBookToCatalog()
        {
            // Arrange
            var catalog = new Catalog();
            var book = new Book();

            // Act
            catalog.AddBook(book);

            // Assert
            Assert.Fail("Not implemented");
        }

        [TestMethod]
        public void TestRemoveBookFromCatalog()
        {
            // Arrange
            var catalog = new Catalog();
            var book = new Book();
            catalog.AddBook(book);

            // Act
            catalog.RemoveBook(book);

            // Assert
            Assert.Fail("Not implemented");
        }

    }

    [TestClass]
    public class BookTests
    {
        [TestMethod]
        public void TestIsAvailable()
        {
            // Arrange
            var book = new Book();

            // Act & Assert
            Assert.Fail("Not implemented");
        }


    }

    [TestClass]
    public class ReaderTests
    {
        [TestMethod]
        public void TestReserveBook()
        {
            // Arrange
            var reader = new Reader();
            var book = new Book();

            // Act
            var reservation = reader.ReserveBook(book);

            // Assert
            Assert.Fail("Not implemented");
        }
    }

    [TestClass]
    public class LibrarianTests
    {
        [TestMethod]
        public void TestManageCatalog()
        {
            // Arrange
            var librarian = new Librarian();
            var catalog = new Catalog();

            // Act
            librarian.ManageCatalog(catalog);

            // Assert
            Assert.Fail("Not implemented");
        }
    }


}
