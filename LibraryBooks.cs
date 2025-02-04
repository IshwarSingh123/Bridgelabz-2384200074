//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Opps
//{

//    class LibraryBooks
//    {
//        private string title;
//        private string author;
//        private double price;
//        private bool isAvailable;

//        // Constructor to initialize book details
//        public LibraryBooks(string title, string author, double price)
//        {
//            this.title = title;
//            this.author = author;
//            this.price = price;
//            this.isAvailable = true; // Book is available by default
//        }

//        // Method to borrow a book
//        public void BorrowBook()
//        {
//            if (isAvailable)
//            {
//                isAvailable = false;
//                Console.WriteLine("You have successfully borrowed '" + title + "' by " + author);
//            }
//            else
//            {
//                Console.WriteLine("Sorry, '" + title + "' is currently not available.");
//            }
//        }

//        // Method to display book details
//        public void DisplayDetails()
//        {
//            Console.WriteLine("Title: " + title + ", Author: " + author + ", Price: $" + price + ", Available: " + isAvailable);
//        }

//        // Main method to test the class
//        public static void Main()
//        {
//            // Creating book objects
//            LibraryBooks book1 = new LibraryBooks("The Alchemist", "Paulo Coelho", 9.99);
//            LibraryBooks book2 = new LibraryBooks("1984", "George Orwell", 12.50);

//            // Display book details
//            Console.WriteLine("Available Books:");
//            book1.DisplayDetails();
//            book2.DisplayDetails();

//            // Borrowing books
//            Console.WriteLine("\nBorrowing books:");
//            book1.BorrowBook();
//            book1.BorrowBook(); // Trying to borrow again

//            // Display book details after borrowing
//            Console.WriteLine("\nUpdated Book Details:");
//            book1.DisplayDetails();
//            book2.DisplayDetails();
//        }
//    }

//}
