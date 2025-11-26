using System.Collections.Generic;

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double CalculateTotalCost()
    {
        double total = 0;
        
        // Add product costs
        foreach (Product product in _products)
        {
            total += product.GetTotalCost();
        }

        // Add shipping cost
        total += _customer.IsInUSA() ? 5 : 35;

        return total;
    }

    public string GetPackingLabel()
    {
        string label = "PACKING LABEL:\n";
        label += "====================\n";
        
        foreach (Product product in _products)
        {
            label += $"Product: {product.GetName()}\n";
            label += $"ID: {product.GetProductId()}\n";
            label += "--------------------\n";
        }

        return label;
    }

    public string GetShippingLabel()
    {
        string label = "SHIPPING LABEL:\n";
        label += "====================\n";
        label += $"Customer: {_customer.GetName()}\n";
        label += _customer.GetAddress().GetFullAddress();
        return label;
    }

    public void DisplayOrderDetails()
    {
        Console.WriteLine(GetPackingLabel());
        Console.WriteLine(GetShippingLabel());
        Console.WriteLine($"TOTAL COST: ${CalculateTotalCost():F2}");
        Console.WriteLine("========================================\n");
    }
}