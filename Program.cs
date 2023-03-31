void ShowCards(PaymentCard[] cards)
{
    foreach (PaymentCard paymentCard in cards)
    {
        Console.WriteLine("Card number: {0}, User's name and surname: {1}, expiration date {2}, CVV: {3}", paymentCard.CardNumber,
                                                                                                            paymentCard.UserName,
                                                                                                            paymentCard.ExpirationDate,
                                                                                                            paymentCard.CVV);
    }
}

PaymentCard paymentCard1 = new PaymentCard();
paymentCard1.CardNumber = "0000 4141 1010 0180";
paymentCard1.UserName = "Vasya Ivanov";
paymentCard1.ExpirationDate = "03/25";
paymentCard1.CVV = 308;

PaymentCard paymentCard2 = new PaymentCard();
paymentCard2.CardNumber = "0220 1342 0000 0909";
paymentCard1.UserName = "Ivan Vasiliev";
paymentCard2.ExpirationDate = "04/26";
paymentCard2.CVV = 122;

PaymentCard paymentCard3 = new PaymentCard();
paymentCard3.CardNumber = "1234 3894 0000 0000";
paymentCard3.UserName = "Vanya Vanyo";
paymentCard3.ExpirationDate = "09/25";
paymentCard3.CVV = 984;

PaymentCard paymentCard4 = new PaymentCard();
paymentCard4.CardNumber = "5609 0000 3450 3456";
paymentCard4.UserName = "Vasiliy Petrov";
paymentCard4.ExpirationDate = "07/24";
paymentCard4.CVV = 773;

PaymentCard paymentCard5 = new PaymentCard();
paymentCard5.CardNumber = "0000 3330 2234 0894 3545";
paymentCard5.UserName = "Petr Sharp";
paymentCard5.ExpirationDate = "08/27";
paymentCard5.CVV = 708;

PaymentCard[] cards = new PaymentCard[] {paymentCard1, paymentCard2, paymentCard3, paymentCard4, paymentCard5};

ShowCards(cards);


