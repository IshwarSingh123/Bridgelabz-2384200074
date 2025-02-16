using System;

class BookNode
{
    public string Title;
    public string Author;
    public string Genre;
    public int BookID;
    public bool IsAvailable;
    public BookNode Next;
    public BookNode Prev;

    public BookNode(string title, string author, string genre, int bookID, bool isAvailable)
    {
        Title = title;
        Author = author;
        Genre = genre;
        BookID = bookID;
        IsAvailable = isAvailable;
        Next = null;
        Prev = null;
    }
}

class LibraryManagement
{
    private BookNode head;
    private BookNode tail;
    private int count;

    public void AddBookAtBeginning(string title, string author, string genre, int bookID, bool isAvailable)
    {
        BookNode newNode = new BookNode(title, author, genre, bookID, isAvailable);
        if (head == null)
        {
            head = tail = newNode;
        }
        else
        {
            newNode.Next = head;
            head.Prev = newNode;
            head = newNode;
        }
        count++;
    }

    public void AddBookAtEnd(string title, string author, string genre, int bookID, bool isAvailable)
    {
        BookNode newNode = new BookNode(title, author, genre, bookID, isAvailable);
        if (tail == null)
        {
            head = tail = newNode;
        }
        else
        {
            tail.Next = newNode;
            newNode.Prev = tail;
            tail = newNode;
        }
        count++;
    }

    public void RemoveBookByID(int bookID)
    {
        BookNode temp = head;
        while (temp != null && temp.BookID != bookID)
            temp = temp.Next;

        if (temp == null) return;

        if (temp.Prev != null)
            temp.Prev.Next = temp.Next;
        else
            head = temp.Next;

        if (temp.Next != null)
            temp.Next.Prev = temp.Prev;
        else
            tail = temp.Prev;

        count--;
    }

    public void SearchBookByTitle(string title)
    {
        BookNode temp = head;
        while (temp != null)
        {
            if (temp.Title.Equals(title, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"Book ID: {temp.BookID}, Title: {temp.Title}, Author: {temp.Author}, Genre: {temp.Genre}, Available: {temp.IsAvailable}");
                return;
            }
            temp = temp.Next;
        }
        Console.WriteLine("Book not found.");
    }

    public void UpdateAvailability(int bookID, bool isAvailable)
    {
        BookNode temp = head;
        while (temp != null)
        {
            if (temp.BookID == bookID)
            {
                temp.IsAvailable = isAvailable;
                return;
            }
            temp = temp.Next;
        }
    }

    public void DisplayBooksForward()
    {
        BookNode temp = head;
        while (temp != null)
        {
            Console.WriteLine($"Book ID: {temp.BookID}, Title: {temp.Title}, Author: {temp.Author}, Genre: {temp.Genre}, Available: {temp.IsAvailable}");
            temp = temp.Next;
        }
    }

    public void DisplayBooksReverse()
    {
        BookNode temp = tail;
        while (temp != null)
        {
            Console.WriteLine($"Book ID: {temp.BookID}, Title: {temp.Title}, Author: {temp.Author}, Genre: {temp.Genre}, Available: {temp.IsAvailable}");
            temp = temp.Prev;
        }
    }

    public int CountBooks()
    {
        return count;
    }
}

class Program
{
    static void Main()
    {
        LibraryManagement library = new LibraryManagement();
        library.AddBookAtEnd("Book A", "Author 1", "Fiction", 101, true);
        library.AddBookAtBeginning("Book B", "Author 2", "Non-Fiction", 102, false);
        library.AddBookAtEnd("Book C", "Author 3", "Science", 103, true);

        Console.WriteLine("Library Book List (Forward):");
        library.DisplayBooksForward();

        Console.WriteLine("\nLibrary Book List (Reverse):");
        library.DisplayBooksReverse();

        Console.WriteLine("\nTotal Books in Library: " + library.CountBooks());
    }
}