public class CreditCard : PaymentCard
{
    decimal AccountBalance;
    decimal CreditLimit;
    decimal CreditInterestRate;

    public CreditCard(string cardNumber, UserInfo userInfo, ExpirationDate expirationDate, short cvv, decimal AccountBalance, decimal creditLimit, decimal creditInterestRate) : base(cardNumber, userInfo, expirationDate, cvv)
    {
        CreditLimit = creditLimit;
        CreditInterestRate = creditInterestRate;
    }
    public override string GetFullInfo()
    {
        return String.Format("Card number: {0}, User's name and surname: {1}, expiration date {2}/{3}, CVV: {4}, Credit limit:{5}, Credit interest rate:{6}%", 
                                                                                CardNumber, UserInfo.UserName, ExpirationDate.ExpirationMonth, ExpirationDate.ExpirationYear, CVV, CreditLimit, CreditInterestRate);
    }

    public override bool MakePayment(decimal totalAmount)
    {
        if (((AccountBalance - totalAmount) > (-CreditLimit)) || ((AccountBalance - totalAmount) == (-CreditLimit)))
        {
            AccountBalance = AccountBalance - totalAmount;
            return true;
        }
        else
        {
            return false;
        }
    }
}