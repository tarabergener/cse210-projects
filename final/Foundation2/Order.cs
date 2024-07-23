using System;
using System.Dynamic;

class Order
{
    public List<Product> _products = new List<Product>();
    private Customer _customer;

    public void CalculateCost()
    {
        if (_customer.UsResident() == true)
        {
            foreach (Product product in _products)
            {
                int total = 0;
                total += product.TotalCost();
                Console.WriteLine($"Your order total is ${total + 5}");
            }
        } else {
            foreach (Product product in _products)
            {
                int total = 0;
                total += product.TotalCost();
                Console.WriteLine($"Your order total is ${total + 35}");
            }
        }
    }

    public void DisplayPackingLabel()
    {
        foreach (Product product in _products)
        {
            product.DisplayProductInfo();
        }
    }
}