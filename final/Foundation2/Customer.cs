using System;

class Customer
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

    public string CustomerAddress()
    {
        
    }
}