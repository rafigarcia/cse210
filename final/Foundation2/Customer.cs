using System.Net.Sockets;

class Customer 
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public string GetName() 
    {
        return _name;
    }

    public string GetAddress()
    {
        return _address.GetFullAddress();
    }

    public bool LivesInUsa()
    {
        return _address.IsUsa();
    }

}