namespace C_Homework7.Models;

internal class Product
{


    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public int Quanity { get; set; }

    public Product(string name, string description, decimal price, int quanity)
    {
        Name = name;
        Description = description;
        Price = price;
        Quanity = quanity;
    }

    public void PrintProduct()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Description: {Description}");
        Console.WriteLine($"Price: {Price:C}");
        Console.WriteLine($"Quantity: {Quanity}");
    }

    public static Product CreateProduct()
    {
        Console.WriteLine("Enter product name:");
        string name = Console.ReadLine();
        Console.WriteLine("Enter product description:");
        string description = Console.ReadLine();
        Console.WriteLine("Enter product price:");
        decimal price = decimal.Parse(Console.ReadLine());
        Console.WriteLine("Enter product quantity:");
        int quantity = int.Parse(Console.ReadLine());
       
        Product product = new Product(name, description, price, quantity);
        return product;
    }


}
