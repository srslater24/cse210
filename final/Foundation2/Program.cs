using System;

class Program
{
    static void Main(string[] args)
    {
        // Products
        Product product1 = new Product("Drop Pod", "P1001", 1000, 1);
        Product product2 = new Product("Gurken Shuck", "P1002", 25, 2);
        Product product3 = new Product("Pickaxe", "P1003", 50, 1);
        Product product4 = new Product("Bosco", "P2001", 200, 1);
        Product product5 = new Product("Scrip", "P2002", 10, 3);

        // Addresses
        Address address1 = new Address("123 Elm Street", "New York", "NY", "USA");
        Address address2 = new Address("456 Maple Avenue", "Toronto", "ON", "Canada");

        // Customers
        Customer customer1 = new Customer("John Package", address1);
        Customer customer2 = new Customer("Karl Dwarf", address2);

        // Orders
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);

        Order order2 = new Order(customer2);
        order2.AddProduct(product4);
        order2.AddProduct(product5);

        // Output
        Console.WriteLine("Order 1:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.CalculateCost()}");

        Console.WriteLine("-----------------------------");
        Console.WriteLine("\nOrder 2:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.CalculateCost()}");
    }
}