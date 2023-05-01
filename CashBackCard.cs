// CashBackCard works as usual Card, but with CashBack function activated.
// CashBack returns: CashBack rate percentage of paying amount.  
class CashBackCard : PaymentCard
{
    public const string PaymentMeanType = "CashBack Card";
    public decimal AccountBalance;
    decimal CashBackRate;

    public CashBackCard(string cardNumber, string cardHolder, ExpirationDate expirationDate, short cvv, decimal accountBalance, decimal сashBackRate) : base(cardNumber, cardHolder, expirationDate, cvv)
    {
        AccountBalance = accountBalance;
        CashBackRate = сashBackRate;
    }
       public override string GetFullInfo()
    {
        return String.Format("Card number: {0}, Client's name and surname: {1}, expiration date: {2}, CVV: {3}, Account balance:{4}, CashBack rate:{5}%",
        CardNumber, CardHolder, ExpirationDate, CVV, AccountBalance, CashBackRate);
    }

    public override bool MakePayment(decimal amount)
    {
        if (AccountBalance - amount < 0)
        {
            return false;
        }
        AccountBalance -= (100 - CashBackRate)/100*amount;
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