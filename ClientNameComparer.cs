class ClientNameComparer : IComparer<BankClient>
{
    public int Compare (BankClient? x, BankClient? y)
    {
        return x.ClientInfo.Name.CompareTo(y.ClientInfo.Name);
    }
}