using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace BL.Framework.PaymentGateway.Controllers
{
    public class SecurityController : ControllerBase
    {
        [HttpPost]
        public async Task<ActionResult<TokenResult>> Authenticate()
        {
            throw new  NotImplementedException();
        }
    }
}