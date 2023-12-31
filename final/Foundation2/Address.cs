using System.Data.SqlTypes;

class Address
{
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _country;

    public Address(string street, string city, string state, string country)
    {
        _streetAddress = street;
        _city = city;
        _state = state;
        _country = country;
    }

    public bool CheckLocality()
    {
        if (_country == "USA")
        {
            return true;
        }
        else
        {
            return false;
        }
        
    }
    public string GetRenderedAdress()
    {
        return $"{_streetAddress}, {_city}\n{_state}, {_country}";
    }
}