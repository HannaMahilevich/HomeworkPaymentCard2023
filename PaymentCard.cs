public abstract class PaymentCard : IPaymentMean
{
    public string CardHolder;
    public string CardNumber;
    public ExpirationDate ExpirationDate;
    public short CVV;

    public PaymentCard(string cardNumber, string cardHolder, ExpirationDate expirationDate, short cvv)
    {
        CardNumber = cardNumber;
        CardHolder = cardHolder;
        ExpirationDate = expirationDate;
        CVV = cvv;
    }
    public virtual string GetFullInfo()
    {
        return String.Format("Card number: {0}, Client's name and surname: {1}, expiration date {2}, CVV: {3}", CardNumber, CardHolder, ExpirationDate, CVV);
    }

    public abstract bool MakePayment(decimal amount);

    public abstract bool TopUp(decimal amount);

    public abstract decimal GetBalance();

    public abstract string GetID();
}