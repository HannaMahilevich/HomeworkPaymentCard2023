public class Address : IComparable<Address>
{
    public string Country;
    public string City;
    public string Street;
    public int HouseNumber;
    public int FlatNumber;

    public Address (string country, string city, string street, int houseNumber, int flatNumber)
    {
        Country = country;
        City = city;
        Street = street;
        HouseNumber = houseNumber;
        FlatNumber = flatNumber;
    }
    
    public override string ToString()
    {
        return Country + ", " + City + ", " + Street + ", " + HouseNumber  + ", " + FlatNumber;
    }

    public int CompareTo(Address? address)
    {
        return this.ToString().CompareTo(address.ToString());
    }

    public override bool Equals(object? obj)
    {
        if (obj is Address)
        {
            Address address = obj as Address;
            return address.Country == Country &&
                   address.City == City &&
                   address.Street == Street &&
                   address.HouseNumber == HouseNumber &&
                   address.FlatNumber == FlatNumber;
        }
        return false;
    }
}