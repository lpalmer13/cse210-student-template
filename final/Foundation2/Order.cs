using System;
using System.Collections.Generic;
using System.Text;

public class Order
{
    private List<Product> products;
    private Customer customer;
    private double shippingCost;

    public Order(Customer customer)
    {
        products = new List<Product>();
        this.customer = customer;
        shippingCost = customer.IsInUSA() ? 5 : 35;
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
        return totalCost + shippingCost;
    }

    public string GetPackingLabel()
    {
        StringBuilder label = new StringBuilder();
        foreach (var product in products)
        {
            double productCost = product.CalculateTotalCost();
            label.AppendLine($"Product Name: {product.Name}, Product ID: {product.ProductId}, Quantity: {product.Quantity}, Cost: ${productCost}");
        }
        return label.ToString();
    }

    public string GetShippingLabel()
    {
        return $"Customer Name: {customer.Name}\nAddress: {customer.Address.GetAddressString()}\nShipping Cost: ${shippingCost}";
    }
}