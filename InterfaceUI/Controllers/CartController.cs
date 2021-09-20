using BankApplication;
using BankApplication.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace CartTransfer.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class CartController : ControllerBase
    {
        private ICartTransferService transferService;
        public CartController(ICartTransferService transferService)
        {
            this.transferService = transferService;
        }

        [HttpGet]
        public CartToCartResponse CartTransfer(CartToCartRequest request)
        {
            var result = transferService.CartTransfer(request);
            return result;
        }

    }
}
