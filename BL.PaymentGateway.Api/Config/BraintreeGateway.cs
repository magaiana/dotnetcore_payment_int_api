namespace BL.Framework.PaymentGateway.Config
{
    public class BraintreeGateway
    {
        public string Environment { get; set; }
        public string MerchantId { get; set; }
        public string PublicKey { get; set; }
        public string PrivateKey { get; set; }
    }
}