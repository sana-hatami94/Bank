using BankPrj.Domain;
using System;

namespace BankApplication.DesignPattern
{
    public class BankAccountServiceFactory
    {
        private IBankAccountRepository bankAccountRepository;
        private IGerericRepository<Person> personRepository;
        private IGerericRepository<CartTransferTransaction> cartTransferTransactionRepository;
        public BankAccountServiceFactory(IBankAccountRepository bankAccountRepository,
                      IGerericRepository<Person> personRepository,
                      IGerericRepository<CartTransferTransaction> cartTransferTransactionRepository)
        {
            this.bankAccountRepository = bankAccountRepository;
            this.personRepository = personRepository;
            this.cartTransferTransactionRepository = cartTransferTransactionRepository;
        }


        public ICartTransferService Create(string mask)
        {

            switch (mask)
            {
                case "111111": return new SamanService(bankAccountRepository,personRepository,cartTransferTransactionRepository);
                case "222222": return new MellatService(bankAccountRepository, personRepository, cartTransferTransactionRepository);
                case "333333": return new AyandehService(bankAccountRepository, personRepository, cartTransferTransactionRepository);
                default: throw new ArgumentException("Invalid type", "type");
            }
        }
    }
}
