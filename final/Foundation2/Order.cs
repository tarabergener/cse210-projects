using System;
using System.Dynamic;

class Order
{
    public List<Product> _products = new List<Product>();
    private Customer _customer;
    private Address _address;

    public void CalculateCost()
    {
        if (_customer.UsResident() == true)
        {
            foreach (Product product in _products)
            {
                Console.WriteLine(product.TotalCost() + 5);
            }
        } else {
            foreach (Product product in _products)
            {
                Console.WriteLine(product.TotalCost() + 35);
            }
        }
    }

    //public void AddProducts()
    //{
    //    Product product = new Product();
    //    _products.Add(product.GetProductName());
    //}

    public void ShippingLabel()
    {
        _customer.CustomerInfo();
    }

    public void DisplayPackingLabel()
    {
        foreach (Product product in _products)
        {
            product.DisplayProductInfo();
        }
    }
}