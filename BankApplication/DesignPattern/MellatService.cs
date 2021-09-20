using BankApplication.Contracts;
using BankPrj.Domain;
using System;

namespace BankApplication.DesignPattern
{
    public class MellatService: ICartTransferService
    {
        private IBankAccountRepository bankAccountRepository;
        private IGerericRepository<Person> personRepository;
        private IGerericRepository<CartTransferTransaction> cartTransferTransactionRepository;
        public MellatService(IBankAccountRepository bankAccountRepository,
                              IGerericRepository<Person> personRepository,
                              IGerericRepository<CartTransferTransaction> cartTransferTransactionRepository)
        {
            this.bankAccountRepository = bankAccountRepository;
            this.personRepository = personRepository;
            this.cartTransferTransactionRepository = cartTransferTransactionRepository;
        }

        public CartToCartResponse CartTransfer(CartToCartRequest request)
        {
            try
            {
                var fromAccount = bankAccountRepository.GetByCartNumber(request.FromCartNumber);
                var toAccount = bankAccountRepository.GetByCartNumber(request.ToCartNumber);
                fromAccount.Balance -= request.Amount;
                toAccount.Balance += request.Amount;
               var transactionId= cartTransferTransactionRepository.Add(new CartTransferTransaction
                {
                    Amount = request.Amount,
                    Date = DateTime.Now,
                    FollowingNumber = Guid.NewGuid(),
                    FromCartNumber = request.FromCartNumber,
                    ToCartNumber = request.ToCartNumber,

                });
                bankAccountRepository.Update(fromAccount);
                bankAccountRepository.Update(toAccount);
                var addedTransaction = cartTransferTransactionRepository.GetById(transactionId);
                return new CartToCartResponse
                {
                    TransactionId = transactionId,
                    Remark = "تراکنش با موفقیت انجام شد",
                    FollowingNumber = addedTransaction.FollowingNumber.ToString(),
                    StatusCode = StatusCodeEnum.Success
                };
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
