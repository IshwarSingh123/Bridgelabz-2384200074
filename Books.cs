using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opps
{
    class Books
    {
        public string ISBN; // Public: Accessible from anywhere
        protected string title; // Protected: Accessible in derived classes
        private string author; // Private: Only accessible within this class

        // Constructor
        public Books(string ISBN, string title, string author)
        {
            this.ISBN = ISBN;
            this.title = title;
            this.author = author;
        }

        // Public method to get author
        public string GetAuthor()
        {
            return author;
        }

        // Public method to set author
        public void SetAuthor(string newAuthor)
        {
            if (!string.IsNullOrWhiteSpace(newAuthor))
            {
                author = newAuthor;
            }
            else
            {
                Console.WriteLine("Invalid author name.");
            }
        }

        // Display book details
        public virtual void DisplayBookDetails()
        {
            Console.WriteLine("ISBN: " + ISBN + ", Title: " + title + ", Author: " + GetAuthor());
        }
    }

    // Subclass demonstrating use of protected member
    class EBook : Books
    {
        private double fileSize; // In MB

        // Constructor
        public EBook(string ISBN, string title, string author, double fileSize)
            : base(ISBN, title, author)
        {
            this.fileSize = fileSize;
        }

        // Override method to display eBook details
        public override void DisplayBookDetails()
        {
            Console.WriteLine("E-Book - ISBN: " + ISBN + ", Title: " + title + ", Author: " + GetAuthor() + ", File Size: " + fileSize + "MB");
        }
    }

    // Main method to test the classes
    class Program
    {
        public static void Main()
        {
            // Creating a Book object
            Books book1 = new Books("978-3-16-148410-0", "The Great Adventure", "Chandreshekhar");
            book1.DisplayBookDetails();

            // Modifying Author
            Console.WriteLine("\nUpdating Author...");
            book1.SetAuthor("Rajesh bharanger");
            book1.DisplayBookDetails();

            // Creating an EBook object
            EBook ebook = new EBook("978-0-13-235088-4", "C# Programming", "Ishwar Singh", 5.2);
            Console.WriteLine("\nE-Book Details:");
            ebook.DisplayBookDetails();
        }
    }

}
