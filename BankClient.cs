class BankClient
{
    public ClientInfo ClientInfo {get; set;}
    public List<IPaymentMean> PaymentMeans {get; set;}

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
}