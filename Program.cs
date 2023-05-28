static void ShowClientListAddress(IEnumerable<BankClient> bankClientList)
{
    foreach (BankClient client in bankClientList)
    {
        Console.WriteLine(String.Format("Name: {0}, Address: {1}", client.ClientInfo.Name, client.ClientInfo.Address));
    }
}

static void ShowClientListName(IEnumerable<BankClient> bankClientList)
{
    foreach (BankClient client in bankClientList)
    {
        Console.WriteLine(String.Format("Name: {0}", client.ClientInfo.Name));
    }
}

static void ShowClientListCardsCount(IEnumerable<BankClient> bankClientList)
{
    foreach (BankClient client in bankClientList)
    {
        Console.WriteLine(String.Format("Name: {0}, Number of Cards: {1}", client.ClientInfo.Name, client.GetCardCount()));
    }
}

static void ShowClientListPaymentMeans(IEnumerable<BankClient> bankClientList)
{
    foreach (BankClient client in bankClientList)
    {
        Console.WriteLine(String.Format("Name: {0}, Total Balance: {1}", client.ClientInfo.Name, client.GetTotalBalance()));
        foreach (IPaymentMean paymentMean in client.PaymentMeans)
        {
            Console.WriteLine(String.Format("{0}, {1}", paymentMean.GetID(), paymentMean.GetBalance()));
        }
        Enter();
    }
}

static void ShowClientDebitCards(BankClient client)
{
    Console.WriteLine("All debit cards of a client:");
    Console.WriteLine(String.Format("Name: {0}", client.ClientInfo.Name));
    IEnumerable<IPaymentMean> debitCards = client.PaymentMeans.Where(x => x is DebitCard);
    foreach (IPaymentMean paymentMean in debitCards)
    {
        Console.WriteLine(String.Format("{0}, {1}", paymentMean.GetID(), paymentMean.GetBalance()));
    }
}

static void ShowClientTotalBalance(BankClient client)
{
    Console.WriteLine(String.Format("Name: {0}, Total Balance: {1}", client.ClientInfo.Name, client.GetTotalBalanceLinq()));
}

static void ShowTheRichestClient(IEnumerable<BankClient> bankClientList)
{
    BankClient? client = bankClientList.MaxBy(x => x.GetTotalBalanceLinq());
    if (client == null)
    {
        Console.WriteLine("There are no clients provided");
        return;
    }
    Console.WriteLine("The richest client");
    Console.WriteLine(String.Format("Name: {0}, Total Balance: {1}", client.ClientInfo.Name, client.GetTotalBalanceLinq()));
}

static void ShowClientBitcoin(IEnumerable<BankClient> bankClientList)
{
    IEnumerable<BankClient> clientsWithBitcoinSorted = bankClientList
        .Where(x => x.PaymentMeans.Any(x => x is Bitcoin))
        .OrderByDescending(x => x.GetTotalBalanceLinq());
    Console.WriteLine("Clients with Bitcoin, sorted by total balance");
    Enter();
    foreach (BankClient client in clientsWithBitcoinSorted)
    {
        Console.WriteLine(String.Format("Name: {0}, Total Balance: {1}", client.ClientInfo.Name, client.GetTotalBalanceLinq()));
        foreach (IPaymentMean paymentMean in client.PaymentMeans)
        {
            if (paymentMean is Bitcoin)
            {
                Console.WriteLine(String.Format("{0}, {1}", paymentMean.GetID(), paymentMean.GetBalance()));
            }
        }
        Enter();
    }
}

static void Separator()
{
    Console.WriteLine("-----------------------------------------");
}

static void Enter()
{
    Console.WriteLine("");
}

Address address1 = new Address("PL", "Warsaw", "Narwik", 24, 53);
Address address2 = new Address("PL", "Gdansk", "Jaglana", 6, 24);
Address address3 = new Address("DE", "Berlin", "Gassnerweg", 18, 5);
Address address4 = new Address("BY", "Minsk", "Hercena", 30, 33);
// Address address5 = new Address("LT", "Vilnus", "Gedymina", 3, 86);

BankClient client1 = new BankClient(new ClientInfo("Vasya Ivanov", "+48 182934928", address1));
BankClient client2 = new BankClient(new ClientInfo("Ivan Vasiliev", "+48 388172843", address2));
BankClient client3 = new BankClient(new ClientInfo("Vanya Vanyo", "+48 182934928", address3));
BankClient client4 = new BankClient(new ClientInfo("Vasiliy Petrov", "+48 182934928", address4));
// BankClient client5 = new BankClient(new ClientInfo("Petr Sharp", "+48 182934928", address5));

ExpirationDate expirationDate1 = new ExpirationDate(03, 25);
ExpirationDate expirationDate2 = new ExpirationDate(04, 26);
ExpirationDate expirationDate3 = new ExpirationDate(09, 25);
ExpirationDate expirationDate4 = new ExpirationDate(07, 24);
ExpirationDate expirationDate5 = new ExpirationDate(08, 27);
ExpirationDate expirationDate6 = new ExpirationDate(02, 26);
ExpirationDate expirationDate7 = new ExpirationDate(01, 25);



DebitCard paymentCard1 = new DebitCard("0000 4141 1010 0180", client1.ClientInfo.Name, expirationDate1, 308, 1500, 0);

CreditCard paymentCard2 = new CreditCard("0220 1342 0000 0909", client1.ClientInfo.Name, expirationDate2, 122, 0, 5000, 12);

DebitCard paymentCard3 = new DebitCard("1234 3894 0000 0000", client2.ClientInfo.Name, expirationDate3, 984, 1000, 0);

DebitCard paymentCard4 = new DebitCard("5609 0000 3450 3456", client2.ClientInfo.Name, expirationDate4, 773, 4000, 8);

CreditCard paymentCard5 = new CreditCard("0000 3330 2234 0894", client2.ClientInfo.Name, expirationDate5, 708, 1000, 2000, 13);

DebitCard paymentCard6 = new DebitCard("1111 0000 2222 0000", client3.ClientInfo.Name, expirationDate6, 081, 350, 2);

DebitCard paymentCard7 = new DebitCard("0000 3333 0000 4141", client4.ClientInfo.Name, expirationDate7, 090, 1700, 0);


// Adding different payment means to clients
client1.PaymentMeans.AddRange(new List<IPaymentMean>
    {paymentCard1, paymentCard2, new Cash(1000)}
    );

client2.PaymentMeans.AddRange(new List<IPaymentMean>
    {paymentCard3, paymentCard4, new Bitcoin(1)}
    );

client2.PaymentMeans.Add(paymentCard5);

client3.PaymentMeans.AddRange(new List<IPaymentMean>
    {paymentCard6, new Cash(10), new Bitcoin(3)}
    );

client4.PaymentMeans.AddRange(new List<IPaymentMean>
    {paymentCard7, new Cash(330), new Bitcoin(2)}
    );

List<BankClient> bankClientList = new List<BankClient>() { client1, client2, client3, client4 };

// Task 3.1 Sorting as in task 2 using linq

Console.WriteLine("Sort by name:");
ShowClientListName(bankClientList.OrderBy(x => x.ClientInfo.Name));
Separator();
Enter();

Console.WriteLine("Sort by address:");
ShowClientListAddress(bankClientList.OrderBy(x => x.ClientInfo.Address));
Separator();
Enter();

Console.WriteLine("Sort by number of cards:");
ShowClientListCardsCount(bankClientList.OrderBy(x => x.GetCardCount()));
Separator();
Enter();

Console.WriteLine("Sort by overall balance:");
ShowClientListPaymentMeans(bankClientList.OrderBy(x => x.GetTotalBalance()));
Separator();
Enter();

Console.WriteLine("Sort by maximal balance of one of the means:");
ShowClientListPaymentMeans(bankClientList.OrderBy(x => x.GetMaxBalance()));
Separator();
Enter();

// // Task 3.2.1 This method uses linq to show list of Debit Cards of one client
ShowClientDebitCards(client1);
Separator();
Enter();

ShowClientDebitCards(client2);
Separator();
Enter();

ShowClientDebitCards(client3);
Separator();
Enter();

// // Task 3.2.2 This method uses linq to show total balance of a client
ShowClientTotalBalance(client1);
Separator();
Enter();

// Task 3.2.3 Shows the richest client
ShowTheRichestClient(bankClientList);
Separator();
Enter();


// Task 3.2.4 Shows list of clients with Bitcoin, sorted by total balance(descending)
ShowClientBitcoin(bankClientList);


Console.Beep(440, 500);

