public abstract class PaymentCard
{
    public string CardNumber;
    public UserInfo UserInfo;
    public ExpirationDate ExpirationDate;
    public short CVV;

    public PaymentCard (string cardNumber, UserInfo userInfo, ExpirationDate expirationDate, short cvv)
    {
        CardNumber = cardNumber;
        UserInfo = userInfo;
        ExpirationDate = expirationDate;
        CVV =cvv;
    }
    public virtual string GetFullInfo()
    {
        return String.Format("Card number: {0}, User's name and surname: {1}, expiration date {2}/{3}, CVV: {4}", CardNumber, UserInfo.UserName, ExpirationDate.ExpirationMonth, ExpirationDate.ExpirationYear, CVV);
    }

    public abstract bool MakePayment(decimal totalAmount);
}