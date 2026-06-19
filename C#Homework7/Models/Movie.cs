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
}
