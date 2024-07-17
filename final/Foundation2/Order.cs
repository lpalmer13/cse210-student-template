using System;
using System.Collections.Generic;
using System.Text;

public class Order
{
    private List<Product> products;
    private Customer customer;

    public Order(Customer customer)
    {
        products = new List<Product>();
        this.customer = customer;
    }

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public double CalculateTotalCost()
    {
        double totalCost = 0;
        foreach (var product in products)
        {
            totalCost += product.CalculateTotalCost();
        }

        if (customer.IsInUSA())
        {
            totalCost += 5;
        }
        else
        {
            totalCost += 35;
        }

        return totalCost;
    }

    public string GetPackingLabel()
    {
        StringBuilder label = new StringBuilder();
        foreach (var product in products)
        {
            label.AppendLine($"Product Name: {product.Name}, Product ID: {product.ProductId}");
        }
        return label.ToString();
    }

    public string GetShippingLabel()
    {
        return $"Customer Name: {customer.Name}\nAddress: {customer.Address.GetAddressString()}";
    }
}