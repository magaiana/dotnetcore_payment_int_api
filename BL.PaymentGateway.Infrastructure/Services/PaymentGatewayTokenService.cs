using System.Threading.Tasks;
using BL.PaymentGateway.Domain.Common.Models;
using BL.PaymentGateway.Domain.Common.Interfaces;

namespace BL.PaymentGateway.Infrastructure.Services
{
    public class PaymentGatewayTokenService : IPaymentGatewayTokenRequest
    {
        public async Task<ClientTokenResponse> RequestToken(ClientTokenRequest request)
        {
            throw new System.NotImplementedException();
        }
    }
}