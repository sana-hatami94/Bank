using BankPrj.Domain;
using System;
using System.Collections.Generic;

namespace Infrastructure.EF.Repositories
{
    public class CartTransferTransactionRepository : IGerericRepository<CartTransferTransaction>
    {
        public BankContext _context;
        public CartTransferTransactionRepository(BankContext context)
        {
            this._context = context;
        }

        public int Add(CartTransferTransaction entity)
        {
            return _context.CartTransferTransaction.Add(entity).Id;
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CartTransferTransaction> GetAll()
        {
            throw new NotImplementedException();
        }

        public CartTransferTransaction GetById(int id)
        {
            return _context.CartTransferTransaction.Find(id);
        }

        public int Update(CartTransferTransaction entity)
        {
            throw new NotImplementedException();
        }
    }
}
