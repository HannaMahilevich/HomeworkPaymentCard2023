class ClientAddressComparer: IComparer<BankClient>
{
    public int Compare (BankClient? x, BankClient? y)
    {
        return x.ClientInfo.Address.CompareTo(y.ClientInfo.Address);
    }
}