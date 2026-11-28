using System;
using System.Reflection.Emit;


public class Order
{
    private List<Product> _product;

    private Customer _customer;

    public Order(Customer customer)
    {
        _product = new List<Product>();
        _customer = customer;

    }

    public void AddOrders(Product products)
    {
        _product.Add(products);
    }

    public float TotalPrice()
    {
        float total = 0;
        foreach (Product product in _product)
        {
            total += product.CostPrice();
        }
        return total;    
    }

    public void DisplayPrice(Product price)
    {
        Console.WriteLine($"Total Price: {0}", price.CostPrice());
    }

    public string ProductLabel()
    {
        string productName = "";

        int iD = 0;

        float price = 0;

        string label = "";

        foreach (Product product in _product)
        {
            productName = product.GetName();
            iD = product.GetId();
            price = product.CostPrice();
            label += $"\nProduct Name: {productName}\nProduct ID: {iD}\nProduct Price: ${price}\n";
        }
        return label;
    }

    public void DisplayLabel()
    {
        Console.WriteLine(ProductLabel());
    }

    public string ShippingLabel()
    {
        string name = "";

        string shipping = "";

        Address address;


        name = _customer.GetName();
        address = _customer.GetAddress();
        shipping += $"Customer's Name: {name}\n{address.DisplayAddress()}\n";
        return shipping;
    }

    public void DisplayShippingLabel()
    {
        Console.WriteLine(ShippingLabel());   
    }
}