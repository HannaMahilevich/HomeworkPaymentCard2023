public class PaymentCard
{
    private string CardNumber;
    private string UserName;
    private string ExpirationDate;
    private short CVV;

    public PaymentCard (string cardNumber, string userName, string expirationDate, short cvv)
    {
        CardNumber = cardNumber;
        UserName = userName;
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
        return String.Format("Card number: {0}, User's name and surname: {1}, expiration date {2}, CVV: {3}", CardNumber, UserName, ExpirationDate, CVV);
    }
}