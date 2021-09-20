using BankApplication;
using BankApplication.Contracts;
using System.Web.Http;

namespace CartTransfer.Controllers
{

    [Route("api/[controller]")]
    public class CartController : ApiController
    {
        private ICartTransferService transferService;
        public CartController(ICartTransferService transferService)
        {
            this.transferService = transferService;
        }

        public CartToCartResponse CartTransfer(CartToCartRequest request)
        {
            var result = transferService.CartTransfer(request);
            return result;
        }

    }
}
