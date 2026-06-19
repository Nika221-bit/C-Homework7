namespace C_Homework7.Models;

internal class Book
{
  

    public string Title { get; set; }
    public string Author { get; set; }
    public int Pagecout { get; set; }
    public DateOnly ReleaseYear { get; set; }

    public Book(string title, string author, int pagecout, DateOnly releaseYear)
    {
        Title = title;
        Author = author;
        Pagecout = pagecout;
        ReleaseYear = releaseYear;
    }

    public void PrintBook()
    {
        Console.WriteLine($"Title : {Title}");
        Console.WriteLine($"Author : {Author}");
        Console.WriteLine($"Page : {Pagecout}");
        Console.WriteLine($"Release year : {ReleaseYear}");
    }

    public static Book CreateBook()
    {
        Console.WriteLine("Enter the book title:");
        string title = Console.ReadLine();
        Console.WriteLine("Enter the book author:");
        string author = Console.ReadLine();
        Console.WriteLine("Enter the number of pages:");
        int pageCount = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the release year (YYYY-MM-DD):");
        DateOnly releaseYear = DateOnly.Parse(Console.ReadLine());
        
        Book book = new Book(title, author, pageCount, releaseYear);
        return book;
    }
}
