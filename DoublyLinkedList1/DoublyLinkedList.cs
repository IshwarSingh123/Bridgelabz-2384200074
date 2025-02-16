using System;

class MovieNode
{
    public string Title;
    public string Director;
    public int Year;
    public double Rating;
    public MovieNode Next;
    public MovieNode Prev;

    public MovieNode(string title, string director, int year, double rating)
    {
        Title = title;
        Director = director;
        Year = year;
        Rating = rating;
        Next = null;
        Prev = null;
    }
}

class MovieList
{
    private MovieNode head;
    private MovieNode tail;

    public void AddMovieAtBeginning(string title, string director, int year, double rating)
    {
        MovieNode newNode = new MovieNode(title, director, year, rating);
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
    }

    public void AddMovieAtEnd(string title, string director, int year, double rating)
    {
        MovieNode newNode = new MovieNode(title, director, year, rating);
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
    }

    public void AddMovieAtPosition(string title, string director, int year, double rating, int position)
    {
        if (position <= 0)
        {
            AddMovieAtBeginning(title, director, year, rating);
            return;
        }

        MovieNode newNode = new MovieNode(title, director, year, rating);
        MovieNode temp = head;
        for (int i = 0; temp != null && i < position - 1; i++)
        {
            temp = temp.Next;
        }

        if (temp == null || temp.Next == null)
        {
            AddMovieAtEnd(title, director, year, rating);
            return;
        }

        newNode.Next = temp.Next;
        temp.Next.Prev = newNode;
        temp.Next = newNode;
        newNode.Prev = temp;
    }

    public void RemoveMovieByTitle(string title)
    {
        MovieNode temp = head;
        while (temp != null && temp.Title != title)
        {
            temp = temp.Next;
        }

        if (temp == null)
        {
            Console.WriteLine("Movie not found.");
            return;
        }

        if (temp.Prev != null)
            temp.Prev.Next = temp.Next;
        else
            head = temp.Next;

        if (temp.Next != null)
            temp.Next.Prev = temp.Prev;
        else
            tail = temp.Prev;
    }

    public void SearchByDirectorOrRating(string director = null, double? rating = null)
    {
        MovieNode temp = head;
        bool found = false;
        while (temp != null)
        {
            if ((director != null && temp.Director == director) || (rating.HasValue && temp.Rating == rating))
            {
                Console.WriteLine($"Title: {temp.Title}, Director: {temp.Director}, Year: {temp.Year}, Rating: {temp.Rating}");
                found = true;
            }
            temp = temp.Next;
        }
        if (!found)
            Console.WriteLine("No matching movies found.");
    }

    public void DisplayMovies(bool reverse = false)
    {
        MovieNode temp = reverse ? tail : head;
        while (temp != null)
        {
            Console.WriteLine($"Title: {temp.Title}, Director: {temp.Director}, Year: {temp.Year}, Rating: {temp.Rating}");
            temp = reverse ? temp.Prev : temp.Next;
        }
    }

    public void UpdateRating(string title, double newRating)
    {
        MovieNode temp = head;
        while (temp != null && temp.Title != title)
        {
            temp = temp.Next;
        }
        if (temp != null)
        {
            temp.Rating = newRating;
            Console.WriteLine("Rating updated successfully.");
        }
        else
        {
            Console.WriteLine("Movie not found.");
        }
    }
}

class Program
{
    static void Main()
    {
        MovieList movies = new MovieList();
        movies.AddMovieAtEnd("Inception", "Christopher Nolan", 2010, 8.8);
        movies.AddMovieAtBeginning("The Matrix", "Lana Wachowski", 1999, 8.7);
        movies.AddMovieAtEnd("Interstellar", "Christopher Nolan", 2014, 8.6);

        Console.WriteLine("Movies List:");
        movies.DisplayMovies();

        Console.WriteLine("\nSearching for movies directed by Christopher Nolan:");
        movies.SearchByDirectorOrRating(director: "Christopher Nolan");

        Console.WriteLine("\nUpdating rating for Inception:");
        movies.UpdateRating("Inception", 9.0);
        movies.DisplayMovies();
    }
}