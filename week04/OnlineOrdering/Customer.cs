class Customer
{
    private string _customerName;
    private Address _customerAddress;

    public Customer(string name, string address)//Tang, "123 Main Street, Springfield, IL, USA"
    {
        string[] parts = address.Split(',');
        string street = parts[0].Trim(); // 123 Main Street
        string city = parts[1].Trim(); // Springfield
        string state = parts[2].Trim(); // IL
        string country = parts[3].Trim(); //USA

        _customerAddress = new Address(street, city, state, country);
        _customerName = name;
    }


    //method to return if they live in usa or not
    public bool LivesInTheUs()
    {
        if (_customerAddress.LivesInUsa())
        {
            return true;
        }
        return false;
    }

    //Getters
    public string GetCustomerName()
    {
        return _customerName;
    }

    public string GetCustomerAddress()
    {
        return _customerAddress.GetAddress();
    }
}