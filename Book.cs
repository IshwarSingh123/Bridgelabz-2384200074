using System;
public class Book{
   //static variable to store the name of the library
   private static string libraryName = "Central Library";

   //instance variables for book details
   private string title;
	private string author;
   private readonly string ISBN;
	
	//to get library name 
   public static string GetLibraryName()
   {
       return libraryName;
   }
	
	//to get book title
   public string GetTitle()
   {
       return title;
   }
	
	//to get author 
   public string GetAuthor()
   {
       return author;
   }
	
	//to get ISBN 
   public string GetISBN()
   {
       return ISBN;
   }

   //constructor to initialize book details
   public Book(string title, string author, string ISBN){
       this.title = title;
       this.author = author;
       this.ISBN = ISBN;
   }

   //method to display the library name
   public static void DisplayLibraryName(){
       Console.WriteLine("Library: "+GetLibraryName());
   }

   //method to display book details
   public void DisplayBookDetails(){
		if(this is Book){
			Console.WriteLine("Book Title: {0}\nAuthor: {1}\nISBN: {2}\n", GetTitle(), GetAuthor(), GetISBN());
		}
		else
			Console.WriteLine("Invalid book!");
   }
}

class Program2{
   static void Main(string[] args){
       //creating first book object
       Book book1 = new Book("Harry Potter", "J.K. Rowling","I23445");
		//displaying book details using 'DisplayBookDetails()' method
		book1.DisplayBookDetails();
		
		//creating book object and displaying details using 'DisplayBookDetails()' method
       Book book2 = new Book("Divine Rivals", "Rebecca Ross","ZE2343");
		book2.DisplayBookDetails();

       //displaying library name
       Book.DisplayLibraryName();
   }
}