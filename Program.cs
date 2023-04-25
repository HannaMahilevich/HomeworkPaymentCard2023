﻿void ShowCards(PaymentCard[] cards)
{
    foreach (PaymentCard paymentCard in cards)
    {
        string information = paymentCard.GetFullInfo();
        Console.WriteLine(information);
    }
}

Address address1 = new Address("PL", "Warsaw", "Narwik", 24, 53);
Address address2 = new Address("PL", "Gdansk", "Jaglana", 6, 24);
Address address3 = new Address("DE", "Berlin", "Gassnerweg", 18, 5);
Address address4 = new Address("BLR", "Minsk", "Hercena", 30, 33);
Address address5 = new Address("LT", "Vilnus", "Gedymina", 3, 86);

UserInfo user1 = new UserInfo("Vasya Ivanov", "+48 182934928", address1);
UserInfo user2 = new UserInfo("Ivan Vasiliev", "+48 388172843", address2);
UserInfo user3 = new UserInfo("Vanya Vanyo", "+48 182934928", address3);
UserInfo user4 = new UserInfo("Vasiliy Petrov", "+48 182934928", address4);
UserInfo user5 = new UserInfo("Petr Sharp", "+48 182934928", address5);

ExpirationDate expirationDate1 = new ExpirationDate(03, 25);
ExpirationDate expirationDate2 = new ExpirationDate(04, 26);
ExpirationDate expirationDate3 = new ExpirationDate(09, 25);
ExpirationDate expirationDate4 = new ExpirationDate(07, 24);
ExpirationDate expirationDate5 = new ExpirationDate(08, 27);


DebitCard paymentCard1 = new DebitCard("0000 4141 1010 0180", user1, expirationDate1, 308, 1500, 0);

CreditCard paymentCard2 = new CreditCard("0220 1342 0000 0909", user2, expirationDate2, 122, 0, 5000, 12);

DebitCard paymentCard3 = new DebitCard("1234 3894 0000 0000", user3, expirationDate3, 984, 1000, 0);

DebitCard paymentCard4 = new DebitCard("5609 0000 3450 3456", user4, expirationDate4, 773, 4000, 8);

CreditCard paymentCard5 = new CreditCard("0000 3330 2234 0894", user5, expirationDate5, 708, 1000, 2000, 13);

PaymentCard[] cards = new PaymentCard[] {paymentCard1, paymentCard2, paymentCard3, paymentCard4, paymentCard5};

ShowCards(cards);

paymentCard1.MakePayment(186);

ShowCards(cards);


