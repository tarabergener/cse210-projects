using System;

public class Customer
{
    private string _customerName;
    private Address _address;

    public void SetCustomer(string customerName)
    {
        _customerName = customerName;
    }

    public string GetCustomer()
    {
        return _customerName;
    }

    public bool UsResident()
    {
        if (_address.GetCountry() == "United States")
        {
            return true;
        } else {
            return false;
        }
    }

    public void CustomerAddress()
    {
        Console.WriteLine(_customerName);
        Console.WriteLine($"{_address.FullAddress}");
    }
}