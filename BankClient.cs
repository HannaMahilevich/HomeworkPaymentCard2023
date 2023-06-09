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
            IEnumerable<IPaymentMean> cashList = PaymentMeans.Where(x => x is Cash);
            foreach (IPaymentMean paymentMean in cashList)
            {
                if (paymentMean.MakePayment(amount))
                {
                    return true;
                }
            }
        }
        {
            IEnumerable<IPaymentMean> cashBackList = PaymentMeans.Where(x => x is CashBackCard);
            foreach (IPaymentMean paymentMean in cashBackList)
            {
                if (paymentMean.MakePayment(amount))
                {
                    return true;
                }
            }
        }
        {
            IEnumerable<IPaymentMean> debitCardList = PaymentMeans.Where(x => x is DebitCard);
            foreach (IPaymentMean paymentMean in debitCardList)
            {
                if (paymentMean.MakePayment(amount))
                {
                    return true;
                }
            }
        }
        {
            IEnumerable<IPaymentMean> creditCardList = PaymentMeans.Where(x => x is CreditCard);
            foreach (IPaymentMean paymentMean in creditCardList)
            {
                if (paymentMean.MakePayment(amount))
                {
                    return true;
                }
            }
        }
        {
            IEnumerable<IPaymentMean> bitcoinList = PaymentMeans.Where(x => x is Bitcoin);
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

    public decimal GetTotalBalance()
    {
        decimal totalBalance = 0;
        foreach (IPaymentMean paymentMean in PaymentMeans)
        {
            totalBalance += paymentMean.GetBalance();
        }
        return totalBalance;
    }

    public decimal GetTotalBalanceLinq()
    {
        return PaymentMeans.Sum(x => x.GetBalance());
    }

    public decimal GetMaxBalance()
    {
        decimal maxBalance = 0;
        foreach (IPaymentMean paymentMean in PaymentMeans)
        {
            if (paymentMean.GetBalance() > maxBalance)
            {
                maxBalance = paymentMean.GetBalance();
            }
        }
        return maxBalance;
    }

    public override string ToString()
    {
        return ClientInfo + "," + GetTotalBalance();
    }

    public override bool Equals(object? obj)
    {
        if (obj is BankClient)
        {
            BankClient bankClient = obj as BankClient;
            return bankClient.ClientInfo.Name == ClientInfo.Name&&
                   bankClient.ClientInfo.Address.Equals(ClientInfo.Address) &&
                   bankClient.GetTotalBalance() == GetTotalBalance();
        }
        return false;
    }

}