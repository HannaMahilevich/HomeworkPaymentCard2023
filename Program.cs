static void ShowClientListAddress(List<BankClient> bankClientList)
{
    foreach (BankClient client in bankClientList)
    {
        Console.WriteLine(String.Format("Name: {0}, Address: {1}", client.ClientInfo.Name, client.ClientInfo.Address));
    }
}

static void ShowClientListName(List<BankClient> bankClientList)
{
    foreach (BankClient client in bankClientList)
    {
        Console.WriteLine(String.Format("Name: {0}", client.ClientInfo.Name));
    }
}

static void ShowClientListCardsCount(List<BankClient> bankClientList)
{
    foreach (BankClient client in bankClientList)
    {
        Console.WriteLine(String.Format("Name: {0}, Number of Cards: {1}", client.ClientInfo.Name, client.GetCardCount()));
    }
}

static void ShowClientListPaymentMeans(List<BankClient> bankClientList)
{
    foreach (BankClient client in bankClientList)
    {
        Console.WriteLine(String.Format("Name: {0}", client.ClientInfo.Name));
        foreach (IPaymentMean paymentMean in client.PaymentMeans)
        {
            Console.WriteLine(String.Format("{0}, {1}", paymentMean.GetID(), paymentMean.GetBalance()));
        }
    }
}

Address address1 = new Address("PL", "Warsaw", "Narwik", 24, 53);
Address address2 = new Address("PL", "Gdansk", "Jaglana", 6, 24);
Address address3 = new Address("DE", "Berlin", "Gassnerweg", 18, 5);
// Address address4 = new Address("BLR", "Minsk", "Hercena", 30, 33);
// Address address5 = new Address("LT", "Vilnus", "Gedymina", 3, 86);

BankClient client1 = new BankClient(new ClientInfo("Vasya Ivanov", "+48 182934928", address1));
BankClient client2 = new BankClient(new ClientInfo("Ivan Vasiliev", "+48 388172843", address2));
BankClient client3 = new BankClient(new ClientInfo("Vanya Vanyo", "+48 182934928", address3));
// BankClient client4 = new BankClient(new ClientInfo("Vasiliy Petrov", "+48 182934928", address4));
// BankClient client5 = new BankClient(new ClientInfo("Petr Sharp", "+48 182934928", address5));

ExpirationDate expirationDate1 = new ExpirationDate(03, 25);
ExpirationDate expirationDate2 = new ExpirationDate(04, 26);
ExpirationDate expirationDate3 = new ExpirationDate(09, 25);
ExpirationDate expirationDate4 = new ExpirationDate(07, 24);
ExpirationDate expirationDate5 = new ExpirationDate(08, 27);


DebitCard paymentCard1 = new DebitCard("0000 4141 1010 0180", client1.ClientInfo.Name, expirationDate1, 308, 1500, 0);

CreditCard paymentCard2 = new CreditCard("0220 1342 0000 0909", client1.ClientInfo.Name, expirationDate2, 122, 0, 5000, 12);

DebitCard paymentCard3 = new DebitCard("1234 3894 0000 0000", client2.ClientInfo.Name, expirationDate3, 984, 1000, 0);

DebitCard paymentCard4 = new DebitCard("5609 0000 3450 3456", client2.ClientInfo.Name, expirationDate4, 773, 4000, 8);

CreditCard paymentCard5 = new CreditCard("0000 3330 2234 0894", client2.ClientInfo.Name, expirationDate5, 708, 1000, 2000, 13);

DebitCard paymentCard6 = new DebitCard("1111 0000 2222 0000", client3.ClientInfo.Name, expirationDate4, 081, 350, 2);

// Adding different payment means to clients
client1.PaymentMeans.AddRange(new List<IPaymentMean>
    {paymentCard1, paymentCard2, new Cash(1000)}
    );

client2.PaymentMeans.AddRange(new List<IPaymentMean>
    {paymentCard3, paymentCard4}
    );

client2.PaymentMeans.Add(paymentCard5);

client3.PaymentMeans.AddRange(new List<IPaymentMean>
    {paymentCard6, new Cash(10), new Bitcoin(3)}
    );

List<BankClient> bankClientList = new List<BankClient>() { client1, client2, client3 };

Console.WriteLine("Sort by name:");
bankClientList.Sort(new ClientNameComparer());
ShowClientListName(bankClientList);
Console.WriteLine("-----------------------------------------");

Console.WriteLine("Sort by address:");
bankClientList.Sort(new ClientAddressComparer());
ShowClientListAddress(bankClientList);
Console.WriteLine("-----------------------------------------");

Console.WriteLine("Sort by number of cards:");
bankClientList.Sort(new ClientCardsCountComparer());
ShowClientListCardsCount(bankClientList);
Console.WriteLine("-----------------------------------------");

Console.WriteLine("Sort by overall balance:");
bankClientList.Sort(new ClientAllMeansBalanceComparer());
ShowClientListPaymentMeans(bankClientList);
Console.WriteLine("-----------------------------------------");

Console.WriteLine("Sort by maximal balance of one of the means:");
bankClientList.Sort(new ClientMaxBalanceComparer());
ShowClientListPaymentMeans(bankClientList);
Console.WriteLine("-----------------------------------------");