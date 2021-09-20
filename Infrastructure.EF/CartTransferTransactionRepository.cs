using BankPrj.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.EF
{
    class CartTransferTransactionRepository : IGerericRepository<CartTransferTransaction>
    {
        public BankContext _context;
        public CartTransferTransactionRepository(BankContext context)
        {
            this._context = context;
        }

        public int Add(CartTransferTransaction entity)
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        public int Update(CartTransferTransaction entity)
        {
            throw new NotImplementedException();
        }
    }
}
