public class Address
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
}