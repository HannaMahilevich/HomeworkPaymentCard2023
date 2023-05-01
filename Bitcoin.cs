class Bitcoin : IPaymentMean
{
    public const string PaymentMeanType = "Bitcoin";
    decimal Balance;
// This fee is constant for the sake of simplicity.
    const decimal TransactionFee = 0.0005m;
// Exchange rate is constant for the sake of simplicity.
    const decimal ExchangeRate = 1000;

    public Bitcoin(decimal balance)
    {
        Balance = balance;
    }

    public bool MakePayment(decimal amount)
    {
        if (Balance - (amount/ExchangeRate + TransactionFee) < 0)
        {
            return false;
        }
        Balance -= (amount/ExchangeRate + TransactionFee);
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