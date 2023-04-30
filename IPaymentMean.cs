interface IPaymentMean
{
    bool MakePayment(decimal amount);

    bool TopUp(decimal amount);

    decimal GetBalance();

    string GetID();
}