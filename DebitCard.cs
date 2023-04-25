public class DebitCard : PaymentCard
{
    public decimal AccountBalance;
    public decimal DepositInterestRate;

    public DebitCard(string cardNumber, UserInfo userInfo, ExpirationDate expirationDate, short cvv, decimal accountBalance, decimal depositInterestRate) : base(cardNumber, userInfo, expirationDate, cvv)
    {
        AccountBalance = accountBalance;
        DepositInterestRate = depositInterestRate;
    }
    public override string GetFullInfo()
    {
        return String.Format("Card number: {0}, User's name and surname: {1}, expiration date: {2}/{3}, CVV: {4}, Account balance:{5}, Debit interest rate:{6}%", 
                                                CardNumber, UserInfo.UserName, ExpirationDate.ExpirationMonth, ExpirationDate.ExpirationYear, CVV, AccountBalance, DepositInterestRate);
    }

    public override bool MakePayment(decimal totalAmount)
    {
        if (((AccountBalance - totalAmount) > 0) || ((AccountBalance - totalAmount) == 0))
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