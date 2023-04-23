public class UserInfo
{
    public string UserName;
    public string UserNumber;
    public Address UserAddress;

    public UserInfo (string userName, string userNumber, Address userAddress)
    {
        UserName = userName;
        UserNumber = userNumber;
        UserAddress = userAddress;
    }
}