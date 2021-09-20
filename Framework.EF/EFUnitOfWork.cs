
using Framework.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Framework.EF
{
    class EFUnitOfWork : IUnitOfWork
    {
        private BankContext _session;
        public NhUnitOfWork(ISession session)
        {
            this._session = session;
        }

        public void Begin()
        {
            _session.BeginTransaction();
        }

        public void Commit()
        {
            _session.Transaction.Commit();
        }

        public void Rollback()
        {
            _session.Transaction.Rollback();
        }
    }
}
