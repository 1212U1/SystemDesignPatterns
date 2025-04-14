namespace FacadePattern
{
    public class OrderComponent
    {
        public String GetOrderDetails(String orderID)
        {
            return "Processing order " + orderID;
        }
    }
}
