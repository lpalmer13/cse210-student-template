using System;

public class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Fart Lane", "Stinkytown", "CA", "USA");
        Address address2 = new Address("456 Burp Blvd", "Flatulenceville", "NY", "Canada");
        Address address3 = new Address("789 Puff St", "Gassy City", "TX", "USA");
        Address address4 = new Address("101 Belch Ave", "Tootville", "ON", "Canada");

        Customer custmer1 = new Customer("John Doe", address1);
        Customer custmer2 = new Customer("Jane Smith", address2);
        Customer customer3 = new Customer("Alice Johnson", address3);
        Customer customer4 = new Customer("Bob Brown", address4);

        Product product1 = new Product("Laptop", 1, 1200.0, 2);
        Product product2 = new Product("Mouse", 2, 25.0, 5);
        Product product3 = new Product("Keyboard", 3, 75.0, 1);
        Product product4 = new Product("Monitor", 4, 300.0, 1);

        Order order1 = new Order(custmer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(custmer2);
        order2.AddProduct(product2);
        order2.AddProduct(product3);

        Order order3 = new Order(customer3);
        order3.AddProduct(product1);
        order3.AddProduct(product4);

        Order order4 = new Order(customer4);
        order4.AddProduct(product3);
        order4.AddProduct(product4);
        
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
        Console.WriteLine();

        Console.WriteLine("Oder 3 - Paking Label:");
        Console.WriteLine(order3.GetPackingLabel());
        Console.WriteLine();

        Console.WriteLine("Order 3 - Shipping Label:");
        Console.WriteLine(order3.GetShippingLabel());
        Console.WriteLine();

        Console.WriteLine("Order 3 - Total Cost:");
        Console.WriteLine($"${order3.CalculateTotalCost()}");
        Console.WriteLine();

        Console.WriteLine("Order 4 - Packing Label:");
        Console.WriteLine(order4.GetPackingLabel());
        Console.WriteLine();

        Console.WriteLine("Order 4 - Shipping Label:");
        Console.WriteLine(order4.GetShippingLabel());
        Console.WriteLine();

        Console.WriteLine("Order 4 - Total Cost:");
        Console.WriteLine($"${order4.CalculateTotalCost()}");
        Console.WriteLine();

    }
}