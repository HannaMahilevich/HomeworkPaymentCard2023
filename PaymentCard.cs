public class PaymentCard
{
    public string CardNumber;
    public UserInfo UserInfo;
    public ExpirationDate ExpirationDate;
    private short CVV;

    public PaymentCard (string cardNumber, UserInfo userInfo, ExpirationDate expirationDate, short cvv)
    {
        CardNumber = cardNumber;
        UserInfo = userInfo;
        ExpirationDate = expirationDate;
        CVV =cvv;
    }

    // public string GetCardNumber()
    // {
    //     return CardNumber;
    // }
    // public string GetUserName()
    // {
    //     return UserName;
    // }
    // public string GetExpirationDate()
    // {
    //     return ExpirationDate;
    // }
    // public short GetCVV()
    // {
    //     return CVV;
    // }

    public string GetFullInfo()
    {
        return String.Format("Card number: {0}, User's name and surname: {1}, expiration date {2}/{3}, CVV: {4}", CardNumber, UserInfo.UserName, ExpirationDate.ExpirationMonth, ExpirationDate.ExpirationYear, CVV);
    }
}