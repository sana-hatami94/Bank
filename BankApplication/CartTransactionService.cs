using BankApplication.Contracts;
using BankApplication.DesignPattern;
using BankPrj.Domain;
using System;

namespace BankApplication
{
    public class CartTransferService : ICartTransferService
    {
        private IBankAccountRepository bankAccountRepository;
        private IGerericRepository<Person> personRepository;
        private IGerericRepository<CartTransferTransaction> cartTransferTransactionRepository;
        public CartTransferService(IBankAccountRepository bankAccountRepository,
                                    IGerericRepository<Person> personRepository,
                                    IGerericRepository<CartTransferTransaction> cartTransferTransactionRepository)
        {
            this.bankAccountRepository = bankAccountRepository;
            this.personRepository = personRepository;
            this.cartTransferTransactionRepository = cartTransferTransactionRepository;
        }
        public CartToCartResponse CartTransfer(CartToCartRequest request)
        {
            var factory = new BankAccountServiceFactory(bankAccountRepository, personRepository, cartTransferTransactionRepository);
            ICartTransferService fromAccountService = factory.Create(request.FromCartNumber.Substring(6));

            if (request.FromCartNumber == request.ToCartNumber)
            {
                return new CartToCartResponse { Remark = "شماره کارت مبدا و مقصد یکی می باشد", StatusCode = StatusCodeEnum.Unsuccess };
            }
            try
            {
                return fromAccountService.CartTransfer(request);
                           }
            catch (Exception)
            {

                throw;
            }



        }
    }
}
