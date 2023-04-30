public class ClientInfo
{
    public string Name;
    public string ClientNumber;
    public Address Address;

    public ClientInfo (string name, string clientNumber, Address address)
    {
        this.Name = name;
        ClientNumber = clientNumber;
        Address = address;
    }

    public override string ToString()
    {
        return Name + ", " + ClientNumber + ", " + Address;
    }
}