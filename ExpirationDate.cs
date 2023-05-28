public class ExpirationDate
{
    public short ExpirationMonth;
    public short ExpirationYear;

    public ExpirationDate (short expirationMonth, short expirationYear)
    {
        ExpirationMonth = expirationMonth;
        ExpirationYear = expirationYear;
    }

    public override string ToString()
    {
        return ExpirationMonth + "/" + ExpirationYear;
    }

    public override bool Equals(object? obj)
    {
        if (obj is ExpirationDate)
        {
            ExpirationDate expirationDate = obj as ExpirationDate;
            return expirationDate.ExpirationMonth == ExpirationMonth &&
                   expirationDate.ExpirationYear == ExpirationYear;
        }
        return false;
    }

}