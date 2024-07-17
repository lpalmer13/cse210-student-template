using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St", "Anytown", "CA", "USA");
        Address address2 = new Address("456 Elm St", "Othertown", "NY", "Canada");

        Customer custmer1 = new Customer("John Doe", address1);
        Customer custmer2 = new Customer("Jane Smith", address2);

        Product product1 = new Product("Laptop", 1, 1200.0, 2);
        Product product2 = new Product("Mouse", 2, 25.0, 5);

        Order order1 = new Order(custmer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(custmer2);
        order2.AddProduct(product2);

        Console.WriteLine("Order 1 - Packing Label:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine();

        Console.WriteLine("Order 1 - Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine();

        Console.WriteLine("Order 1 - Total Cost:");
        Console.WriteLine($"${order1.CalculateTotalCost()}");

        Console.WriteLine();

        Console.WriteLine("Order 2 - Packing Label:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine();

        Console.WriteLine("Order 2 - Shipping Label:");
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine();

        Console.WriteLine("Order 2 - Total Cost:");
        Console.WriteLine($"${order2.CalculateTotalCost()}");
    }
}