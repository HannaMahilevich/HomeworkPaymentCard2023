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

    public override string ToString()
    {
        return PaymentMeanType + "," + Balance;
    }

    public override bool Equals(object? obj)
    {
        if (obj is Cash)
        {
            Cash cash = obj as Cash;
            return cash.Balance == Balance;
        }
        return false;
    }
}