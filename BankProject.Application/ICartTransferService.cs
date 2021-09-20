using BankProject.Application.Contracts;

namespace BankProject.Application
{
    public interface ICartTransferService
    {
        CartToCartResponse CartTransfer(CartToCartRequest request);
    }
}
