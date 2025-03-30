using System;

public class Product
{
    private string _name;
    private string _product_id;
    private float _price;
    private int _quantity;

    public Product(string name, string id, float price, int quan)
    {
        _name = name;
        _product_id = id;
        _price = price;
        _quantity = quan;
    }

    public double ComputePrice()
    {
        double total = _price * _quantity;
        return Math.Round(total, 2);
    }

    public string GetPackingLabel()
    {
        return ($"{_name} (ID: {_product_id})");
    }
}