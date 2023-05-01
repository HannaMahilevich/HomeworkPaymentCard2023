interface IPaymentMean
{
    bool MakePayment(decimal amount);

    bool TopUp(decimal amount);

// This method is needed for MakePayment method in BankClient.
    decimal GetBalance();
    
// This method is needed for MakePayment method in BankClient.
    string GetID();
}