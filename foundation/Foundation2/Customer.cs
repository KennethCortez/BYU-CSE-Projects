
public class Customer
{
    private string _clientName;
    private Address _address;

    public Customer(string clientName, Address address)
    {
        _clientName = clientName;
        _address = address;
    }

    public Address Address
    {
        get { return _address; }
    }

    public string GetInfo()
    {
        return $"Name: {_clientName}\nAddress: {_address.FormatAddress()}";
    }
}