using System;
using System.Collections.Concurrent;
using System.Dynamic;

public class Product
{
    private string _productName;
    private string _productId;
    private int _price;
    private int _quantity;

    public void SetProdcutName(string productName)
    {
        _productName = productName;
    }

    public string GetProductName()
    {
        return _productName;
    }

    public void SetProductId(string productId)
    {
        _productId = productId;
    }

    public string GetProductId()
    {
        return _productId;
    }

    public void SetPrice(int price)
    {
        _price = price;
    }

    public int GetPrice()
    {
        return _price;
    }

    public void SetQuantity(int quantity)
    {
        _quantity = quantity;
    }

    public int GetQuantity()
    {
        return _quantity;
    }

    public int TotalCost()
    {
        int total = _price * _quantity;
        return total;
    }

    public void DisplayProductInfo()
    {
        Console.WriteLine($"{_productName} - {_productId}");
    }
}