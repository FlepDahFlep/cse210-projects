using System.Xml;

public class Product
{
    private string _Name;
    private string _ProductID;
    private double _Price;
    private int _Quantity;

    public Product(string name, string productId, double price, int quantity)
    {
        _Name = name;
        _ProductID = productId;
        _Price = price;
        _Quantity = quantity;
    }    

    public string GetName()
    {
        return _Name;
    }

    public string GetProductId()
    {
        return _ProductID;
    }

    public double GetTotalCost()
    {
        return _Price * _Quantity;
    }
}