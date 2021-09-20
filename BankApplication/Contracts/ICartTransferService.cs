using BankApplication.Contracts;

namespace BankApplication
{
    public interface ICartTransferService
    {
        CartToCartResponse CartTransfer(CartToCartRequest request);
    }
}
