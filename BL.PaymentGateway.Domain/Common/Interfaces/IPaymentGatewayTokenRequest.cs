using System.Threading.Tasks;
using BL.PaymentGateway.Domain.Common.Models;

namespace BL.PaymentGateway.Domain.Common.Interfaces
{
    public interface IPaymentGatewayTokenRequest
    {
        Task<ClientTokenResponse> RequestToken(ClientTokenRequest request);
    }
}