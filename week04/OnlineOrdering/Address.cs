class Address
{
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _country;

    //constructor to ensure all the values are passed in
    public Address(string street, string city, string state, string country)
    {
        _streetAddress = street;
        _city = city;
        _state = state;
        _country = country;
    }

    //method tio check if lives in the USA
    public bool LivesInUsa()
    {
        if (_country == "USA")
        {
            return true;
        }
        return false;
    }

    public void SingleNewLineString()
    {
        Console.WriteLine($"{_streetAddress}\n{_city}, {_state}\n{_country}");
    }

    public String GetAddress()
    {
        return $"{_streetAddress}, {_city} {_state}, {_country}";
    }

}