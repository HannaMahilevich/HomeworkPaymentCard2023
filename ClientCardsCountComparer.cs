class ClientCardsCountComparer: IComparer<BankClient>
{
    public int Compare (BankClient? x, BankClient? y)
    {
        return x.GetCardCount().CompareTo(y.GetCardCount());
    }
}