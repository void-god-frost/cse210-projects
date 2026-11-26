using System;
using System.Numerics;

public class Product
{
    private string _productName;

    private int _id;

    private float _price;

    private int _quantity;

    public Product(string product, int iD, float price, int quantity)
    {
        _productName = product;
        _id = iD;
        _price = price;
        _quantity = quantity;
    }

    public string GetName()
    {
        return _productName;
    }

    public int GetId()
    {
        return _id;
    }

    public float CostPrice()
    {
        float total = _price * _quantity;
        return total;
    }
}

