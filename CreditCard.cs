public class CreditCard : PaymentCard
{
    public decimal CreditLimit;
    public decimal CreditInterestRate;

    public CreditCard(string cardNumber, UserInfo userInfo, ExpirationDate expirationDate, short cvv, decimal creditLimit, decimal creditInterestRate) : base(cardNumber, userInfo, expirationDate, cvv)
    {
        CreditLimit = creditLimit;
        CreditInterestRate = creditInterestRate;
    }
    public override string GetFullInfo()
    {
        return String.Format("Card number: {0}, User's name and surname: {1}, expiration date {2}/{3}, CVV: {4}, Credit limit:{5}, Credit interest rate:{6}%", 
                                                                                CardNumber, UserInfo.UserName, ExpirationDate.ExpirationMonth, ExpirationDate.ExpirationYear, CVV, CreditLimit, CreditInterestRate);
    }
}