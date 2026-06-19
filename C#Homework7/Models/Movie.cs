namespace C_Homework7.Models;

internal class Movie
{
  

    public string Name { get; set; }
    public string Description { get; set; }
    public string Genre { get; set; }
    public TimeSpan DurationTime { get; set; }

    public Movie(string name, string description, string genre, TimeSpan durationTime)
    {
        Name = name;
        Description = description;
        Genre = genre;
        DurationTime = durationTime;
    }

    public void PrintMovie()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Description: {Description}");
        Console.WriteLine($"Genre: {Genre}");
        Console.WriteLine($"DurationTim: {DurationTime}");
    } 

    public static Movie EnterMovie()
    {
        Console.WriteLine("Enter movie name:");
        string name = Console.ReadLine();
        Console.WriteLine("Enter movie description:");
        string description = Console.ReadLine();
        Console.WriteLine("Enter movie genre:");
        string genre = Console.ReadLine();
        Console.WriteLine("Enter movie duration (hh:mm:ss):");
        TimeSpan durationTime = TimeSpan.Parse(Console.ReadLine());
       
        
        Movie movie = new Movie(name, description, genre, durationTime);
        return movie;

    } 
}
