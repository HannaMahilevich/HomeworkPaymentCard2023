class ClientMaxBalanceComparer : IComparer<BankClient>
{
    public int Compare(BankClient? x, BankClient? y)
    {
        decimal xMaxBalance = 0;
        foreach (IPaymentMean paymentMean in x.PaymentMeans)
        {
            if (paymentMean.GetBalance() > xMaxBalance)
            {
                xMaxBalance = paymentMean.GetBalance();
            }
        }
        decimal yMaxBalance = 0;
        foreach (IPaymentMean paymentMean in y.PaymentMeans)
        {
            if (paymentMean.GetBalance() > yMaxBalance)
            {
                yMaxBalance = paymentMean.GetBalance();
            }
        }
        return xMaxBalance.CompareTo(yMaxBalance);
    }
}