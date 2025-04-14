namespace FacadePattern
{
    public class APIGateway
    {
        private OrderComponent OrderComponent;
        private PaymentComponent paymentComponent;
        private UserComponent userComponent;
        public APIGateway()
        {
            this.paymentComponent = new PaymentComponent();
            this.userComponent = new UserComponent();
            this.OrderComponent = new OrderComponent();
        }
        public String GetFullOrderDetails(String orderID, String userID, String paymentID)
        {
            return this.userComponent.GetUserDetails(userID) + "\r\n" + this.OrderComponent.GetOrderDetails(orderID) + "\r\n"
                    + this.paymentComponent.GetPaymentDetails(paymentID);
        }
    }
}
