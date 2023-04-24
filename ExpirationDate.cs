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
        return ExpirationMonth + ", " + ExpirationYear;
    }
}