// Program.cs

using System;

class Program
{
    static void Main(string[] args)
    {
        // Addresses
        var addressUSA = new Address("123 Main St", "Anytown", "CA", "USA");
        var addressNonUSA = new Address("Central District", "CoolHouse", "Pyongyang", "North Korea");

        // Customers
        var customerUSA = new Customer("Joe Biden", addressUSA);
        var customerNonUSA = new Customer("Kim Jong-Un", addressNonUSA);

        // Products
        var product1 = new Product("Dehydrated Water", "PP1", 26.0, 20);
        var product2 = new Product("Soap Soap-Cleaner", "PP2", 11.0, 2);
        var product3 = new Product("Recycled Toilet Paper", "PP3", 33.0, 12);

        // Create orders
        var order1 = new Order(customerUSA);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        var order2 = new Order(customerNonUSA);
        order2.AddProduct(product2);
        order2.AddProduct(product3);

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.CalculateTotalPrice()}");

        Console.WriteLine();

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.CalculateTotalPrice()}");
    }
}
