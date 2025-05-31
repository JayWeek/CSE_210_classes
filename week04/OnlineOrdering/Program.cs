using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.\n");

        //Instantiate the order class
        Order order1 = new Order("Jay", "123 Main Street, Springfield, IL, USA");
        Order order2 = new Order("Mike", "123 King Street, Toronto, ON, Canada");

        //order1
        order1.AddProduct("apple", 09123, 5, 1);
        order1.AddProduct("orange", 048473, 10, 1);
        order1.AddProduct("Pineapple", 11043, 10, 2);
        string PackingLabel1 = order1.PackingLabel();
        string shippingLabel1 = order1.ShippingLabel();
        double order1Total = order1.GetTotalCost();

        Console.WriteLine(PackingLabel1);
        Console.WriteLine(shippingLabel1);
        Console.WriteLine($"Order total: ${order1Total}\n");


        //order2
        order2.AddProduct("watch", 1543, 50, 2);
        order2.AddProduct("phone", 1113, 100, 1);
        order2.AddProduct("headphones", 1643, 50, 1);
        string PackingLabel2 = order2.PackingLabel();
        string shippingLabel2 = order2.ShippingLabel();
        double order2Total = order2.GetTotalCost();

        Console.WriteLine(PackingLabel2);
        Console.WriteLine(shippingLabel2);
        Console.WriteLine($"Order total: ${order2Total}\n");
    }
}