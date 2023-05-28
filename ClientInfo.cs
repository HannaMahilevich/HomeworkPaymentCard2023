public class ClientInfo
{
    public string Name;
    public string ClientNumber;
    public Address Address;

    public ClientInfo(string name, string clientNumber, Address address)
    {
        this.Name = name;
        ClientNumber = clientNumber;
        Address = address;
    }

    public override string ToString()
    {
        return Name + ", " + ClientNumber + ", " + Address;
    }

    public override bool Equals(object? obj)
    {
        if (obj is ClientInfo)
        {
            ClientInfo clientInfo = obj as ClientInfo;
            return clientInfo.Name == Name &&
                   clientInfo.ClientNumber == ClientNumber &&
                   clientInfo.Address.Equals(Address);
        }
        return false;
    }
}