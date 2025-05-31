using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");
        
        //Instantiate the order class
        Order order1 = new Order("Jay", "123 Main Street, Springfield, IL, USA");

        order1.AddProduct("apple", 09123, 5, 1);
        order1.AddProduct("orange", 048473, 10, 1);
        order1.AddProduct("Pineapple", 11043, 10, 2);
        string PackingLabel = order1.PackingLabel();
        string shippingLabel = order1.ShippingLabel();
        double orderTotal = order1.GetTotalCost();

        Console.WriteLine(PackingLabel);
        Console.WriteLine(shippingLabel);
        Console.WriteLine($"Order total: ${orderTotal}");
    }
}