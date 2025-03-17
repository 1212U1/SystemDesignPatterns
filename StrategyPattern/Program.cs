using StrategyPattern;

PaymentService paymentService = new PaymentService();
paymentService.SetPaymentMethod(new DebitCard());
paymentService.MakePayment();
paymentService.SetPaymentMethod(new CreditCard());
paymentService.MakePayment();