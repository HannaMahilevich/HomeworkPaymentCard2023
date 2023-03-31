void ShowCards(PaymentCard[] cards)
{
    foreach (PaymentCard paymentCard in cards)
    {
        Console.WriteLine(paymentCard.GetFullInfo());
    }
}

PaymentCard paymentCard1 = new PaymentCard("0000 4141 1010 0180", "Vasya Ivanov", "03/25", 308);

PaymentCard paymentCard2 = new PaymentCard("0220 1342 0000 0909", "Ivan Vasiliev", "04/26", 122);

PaymentCard paymentCard3 = new PaymentCard("1234 3894 0000 0000", "Vanya Vanyo", "09/25", 984);

PaymentCard paymentCard4 = new PaymentCard("5609 0000 3450 3456", "Vasiliy Petrov", "07/24", 773);

PaymentCard paymentCard5 = new PaymentCard("0000 3330 2234 0894 3545", "Petr Sharp", "08/27", 708);

PaymentCard[] cards = new PaymentCard[] {paymentCard1, paymentCard2, paymentCard3, paymentCard4, paymentCard5};

ShowCards(cards);


