using Braintree;

namespace BL.PaymentGateway.Domain.Common.Models
{
    public class TransactionRequest
    {
        public decimal Amount { get; set; }
        public string DeviceData { get; set; }
        public PaymentMethodNonce PaymentMethodNonce { get; set; }
        public TransactionOptionsRequest Options = new TransactionOptionsRequest {SubmitForSettlement = true};
    }
}