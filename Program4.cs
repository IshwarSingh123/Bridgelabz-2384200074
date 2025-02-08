//using System;

//// Base class Book
//class Book
//{
//    public string Title { get; set; }
//    public int PublicationYear { get; set; }

//    public Book(string title, int publicationYear)
//    {
//        Title = title;
//        PublicationYear = publicationYear;
//    }

//    public virtual void DisplayInfo()
//    {
//        Console.WriteLine($"Title: {Title}, Publication Year: {PublicationYear}");
//    }
//}

//// Subclass Author
//class Author : Book
//{
//    public string Name { get; set; }
//    public string Bio { get; set; }

//    public Author(string title, int publicationYear, string name, string bio)
//        : base(title, publicationYear)
//    {
//        Name = name;
//        Bio = bio;
//    }

//    public override void DisplayInfo()
//    {
//        base.DisplayInfo();
//        Console.WriteLine($"Author: {Name}, Bio: {Bio}");
//    }
//}

//// Main Program
//class Program
//{
//    static void Main()
//    {
//        Author book = new Author("C# Programming", 2022, "Ishwar Singh", "Software Developer and Author");
//        book.DisplayInfo();
//    }
//}
