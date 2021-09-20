using BankPrj.Domain;
using System.Collections.Generic;
using System.Linq;

namespace Infrastructure.EF.Repositories
{
    public class BankAccountRepository : IBankAccountRepository
    {
        public BankContext _context;
        public BankAccountRepository(BankContext context)
        {
            this._context = context;
        }

        public BankAccount GetByCartNumber(string cartNumber)
        {
            var entity = _context.BankAccount.FirstOrDefault(s => s.CartNumber == cartNumber);
            return entity;
        }

        public int Update(BankAccount entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
