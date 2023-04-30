class Cash : IPaymentMean
{
    public const string PaymentMeanType = "Cash";
    decimal Balance;

    public Cash(decimal balance)
    {
        Balance = balance;
    }

    public bool MakePayment(decimal amount)
    {
        if (Balance - amount < 0)
        {
            return false;
        }
        Balance -= amount;
        return true;
    }

    public bool TopUp(decimal amount)
    {
        Balance += amount;
        return true;
    }

    public decimal GetBalance()
    {
        return Balance;
    }

    public string GetID()
    {
        return String.Format("{0}", PaymentMeanType);
    }
}