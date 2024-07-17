public class Product
{
    private string name;
    private int productId;
    private double pricePerUnit;
    private int quantity;

    public Product(string name, int productId, double pricePerUnit, int quantity)
    {
        this.name = name;
        this.productId = productId;
        this.pricePerUnit = pricePerUnit;
        this.quantity = quantity;
    }

    public double CalculateTotalCost()
    {
        return pricePerUnit * quantity;
    }

    public string Name { get { return name; } }
    public int ProductId { get { return productId; } }
}