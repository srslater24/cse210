using System;

public class Order
{
    private List<Product> _products = new List<Product> {};
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double CalculateCost()
    {
        double total = 0;
        foreach (var product in _products)
        {
            total += product.ComputePrice();
        }
        total += _customer.CustomerIsInUSA() ? 5 : 35;
        return total;
    }
    public string GetPackingLabel()
    {
        string label = "Packing List:\n";
        foreach (var product in _products)
        {
            label += product.GetPackingLabel() + "\n";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        return "Shipping Label:\n" + _customer.GetShippingLabel();
    }
}