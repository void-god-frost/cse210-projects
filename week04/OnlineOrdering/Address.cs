using System;
using System.Runtime.CompilerServices;


public class Address
{
    private string _street;

    private string _city;

    private string _state;

    private string _country;

    public Address(string country, string city, string state, string street)
    {
        Location(country, city, state, street);
    }

    public void Location(string country, string city, string state, string street)
    {
        _country = country;
        _city = city;
        _state = state;
        _street = street;
    }

    public bool InRegion()
    {
        if (_country == null)
        {
            return false;
        }
        return
        string.Equals(_country.Trim(), "USA", StringComparison.OrdinalIgnoreCase);
    }

    public string DisplayAddress()
    {
        return $"Address: {_street}, {_city}\n{_state}, {_country}";

    }
}