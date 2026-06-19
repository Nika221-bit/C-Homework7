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
}
