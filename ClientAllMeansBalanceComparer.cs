class ClientAllMeansBalanceComparer : IComparer<BankClient>
{
    public int Compare(BankClient? x, BankClient? y)
    {
        decimal xBalance = 0;
        foreach (IPaymentMean paymentMean in x.PaymentMeans)
        {
            xBalance += paymentMean.GetBalance();
        }
        decimal yBalance = 0;
        foreach (IPaymentMean paymentMean in y.PaymentMeans)
        {
            yBalance += paymentMean.GetBalance();
        }
        return xBalance.CompareTo(yBalance);
    }
}