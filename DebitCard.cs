public class DebitCard : PaymentCard
{
    public const string PaymentMeanType = "Debit Card";
    public decimal AccountBalance;
    public decimal DepositInterestRate;

    public DebitCard(string cardNumber, string cardHolder, ExpirationDate expirationDate, short cvv, decimal accountBalance, decimal depositInterestRate) : base(cardNumber, cardHolder, expirationDate, cvv)
    {
        AccountBalance = accountBalance;
        DepositInterestRate = depositInterestRate;
    }
    public override string GetFullInfo()
    {
        return String.Format("Card number: {0}, Client's name and surname: {1}, expiration date: {2}, CVV: {3}, Account balance:{4}, Debit interest rate:{5}%",
        CardNumber, CardHolder, ExpirationDate, CVV, AccountBalance, DepositInterestRate);
    }

    public override bool MakePayment(decimal amount)
    {
        if (AccountBalance - amount < 0)
        {
            return false;
        }
        AccountBalance -= amount;
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