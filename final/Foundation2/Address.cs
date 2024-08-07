using System;
using System.Collections.Concurrent;
using System.Dynamic;

public class Address
{
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _country;

    public void SetStreetAddress(string streetAddress)
    {
        _streetAddress = streetAddress;
    }

    public string GetStreetAddress()
    {
        return _streetAddress;
    }

    public void SetCity(string city)
    {
        _city = city;
    }

    public string GetCity()
    {
        return _city;
    }

    public void SetState(string state)
    {
        _state = state;
    }

    public string GetState()
    {
        return _state;
    }

    public void SetCountry(string country)
    {
        _country = country;
    }

    public string GetCountry()
    {
        return _country;
    }

    public bool Resident()
    {
        if (_country == "United States")
        {
            return true;
        } else {
            return false;
        }
    }

    public void FullAddress()
    {
        Console.WriteLine($"{_streetAddress}");
        Console.WriteLine($"{_city}, {_state}, {_country}");
    }

    //public Address(string streetAddress, string city, string state, string country)
    //{
    //    _streetAddress = streetAddress;
    //    _city = city;
    //    _state = state;
    //    _country = country;
    //}
}