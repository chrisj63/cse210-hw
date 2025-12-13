using System;

class Address
{
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _zipCode;
    private string _country;

    public Address(string streetAddress, string city, string state, string zipCode, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _state = state;
        _zipCode = zipCode;
        _country = country;
    }

    public string DisplayAddress()
    {
        string address;
        address = _streetAddress + "\r\n" + _city + ", " + _state + " " + _zipCode + "\r\n" + _country;
        return address;
    }

    public string DisplayCountry()
    {
        string country;
        country = _country;
        return country;
    }
}