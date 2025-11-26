public class Product
{
    private string _productId;
    private string _name;
    private double _price;
    private int _quantity;

    public Product(string productId, string name, double price, int quantity)
    {
        _productId = productId;
        _name = name;
        _price = price;
        _quantity = quantity;
    }

    public string GetProductId()
    {
        return _productId;
    }

    public string GetName()
    {
        return _name;
    }

    public double GetPrice()
    {
        return _price;
    }

    public int GetQuantity()
    {
        return _quantity;
    }

    public double GetTotalCost()
    {
        return _price * _quantity;
    }
}