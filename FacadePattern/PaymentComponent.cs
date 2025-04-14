namespace FacadePattern
{
    public class PaymentComponent
    {
        public String GetPaymentDetails(String paymentID)
        {
            return "Processing payment " + paymentID;
        }
    }
}
