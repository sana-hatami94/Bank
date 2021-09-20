using BankProject.Application.Contracts;

namespace BankProject.Application
{
    public class CartTransferService : ICartTransferService
    {
        private IBankAccountRepository bankAccountRepository;
        public CartTransferService()
        {

        }
        public CartToCartResponse CartTransfer(CartToCartRequest request)
        {
            throw new System.NotImplementedException();
        }
    }
}
