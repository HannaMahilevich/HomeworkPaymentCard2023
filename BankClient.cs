class BankClient
{
    public ClientInfo ClientInfo { get; set; }
    public List<IPaymentMean> PaymentMeans { get; set; }

    public BankClient(ClientInfo clientInfo, List<IPaymentMean> paymentMeans)
    {
        ClientInfo = clientInfo;
        PaymentMeans = paymentMeans;
    }

    public BankClient(ClientInfo clientInfo)
    {
        ClientInfo = clientInfo;
        PaymentMeans = new List<IPaymentMean>();
    }

    public bool MakePayment(decimal amount)
    {
        {
            List<IPaymentMean> cashList = PaymentMeans.Where(x => x is Cash).ToList();
            foreach (IPaymentMean paymentMean in cashList)
            {
                if (paymentMean.MakePayment(amount))
                {
                    return true;
                }
            }
        }
        {
            List<IPaymentMean> cashBackList = PaymentMeans.Where(x => x is CashBackCard).ToList();
            foreach (IPaymentMean paymentMean in cashBackList)
            {
                if (paymentMean.MakePayment(amount))
                {
                    return true;
                }
            }
        }
        {
            List<IPaymentMean> debitCardList = PaymentMeans.Where(x => x is DebitCard).ToList();
            foreach (IPaymentMean paymentMean in debitCardList)
            {
                if (paymentMean.MakePayment(amount))
                {
                    return true;
                }
            }
        }
        {
            List<IPaymentMean> creditCardList = PaymentMeans.Where(x => x is CreditCard).ToList();
            foreach (IPaymentMean paymentMean in creditCardList)
            {
                if (paymentMean.MakePayment(amount))
                {
                    return true;
                }
            }
        }
        {
            List<IPaymentMean> bitcoinList = PaymentMeans.Where(x => x is Bitcoin).ToList();
            foreach (IPaymentMean paymentMean in bitcoinList)
            {
                if (paymentMean.MakePayment(amount))
                {
                    return true;
                }
            }
        }
        return false;
    }

    public int GetCardCount()
    {
        int count = 0;
        foreach (IPaymentMean paymentMean in PaymentMeans)
        {
            if (paymentMean is PaymentCard)
            {
                count += 1;
            }
        }
        return count;
    }
}