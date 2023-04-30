public class CreditCard : PaymentCard
{
    public const string PaymentMeanType = "Credit Card";
    decimal AccountBalance;
    decimal CreditLimit;
    decimal CreditInterestRate;

    public CreditCard(string cardNumber, string cardHolder, ExpirationDate expirationDate, short cvv, decimal accountBalance, decimal creditLimit, decimal creditInterestRate) : base(cardNumber, cardHolder, expirationDate, cvv)
    {
        AccountBalance = accountBalance;
        CreditLimit = creditLimit;
        CreditInterestRate = creditInterestRate;
    }
    public override string GetFullInfo()
    {
        return String.Format("Card number: {0}, Client's name and surname: {1}, expiration date {2}, CVV: {3}, Credit limit:{4}, Credit interest rate:{5}%, Credit Card Balance:{6}",
        CardNumber, CardHolder, ExpirationDate, CVV, CreditLimit, CreditInterestRate, AccountBalance);
    }

    public override bool MakePayment(decimal amount)
    {
        if (AccountBalance - amount < -CreditLimit)
        {
            return false;
        }
        AccountBalance = AccountBalance - amount;
        return true;
    }

    public override bool TopUp(decimal amount)
    {
        AccountBalance += amount;
        return true;
    }

    public override decimal GetBalance()
    {
        return AccountBalance;
    }

    public override string GetID()
    {
        return String.Format("{0} {1}", PaymentMeanType, CardNumber);
    }
}