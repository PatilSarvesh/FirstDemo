// See https://aka.ms/new-console-template for more information
class Program
{
    public static void Main()
    {
        Console.WriteLine("Hello, World!");
        Product p1 = new Product { ProductId = 111, Name = "Iphone", Price = 9000 };
        Product p2 = new Product { Name = "Iphone", Price = 9000 };
        Product p3 = new Product { ProductId = 111,  Price = 9000 };
        Product p4 = new Product { ProductId = 111, Name = "Iphone" };

         
    }
}

class Product
{
    public string Name { get; set; }
    public int Price { get; set; }
    public int ProductId { get; set; }

    //private Product() // private const will not allow user to create instances
    //{

    //}

    
}

