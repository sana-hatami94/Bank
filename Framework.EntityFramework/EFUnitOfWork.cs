using Framework.Core;
using Infrastructure.EF;

namespace Framework.EntityFramework
{
    public class EFUnitOfWork : IUnitOfWork
    {
        private BankContext _session;
        public EFUnitOfWork(BankContext session)
        {
            this._session = session;
        }

        public void Begin()
        {
            _session.Database.BeginTransaction();
        }

        public void Commit()
        {
            _session.Database.CurrentTransaction.Commit();
        }

        public void Rollback()
        {
            _session.Database.CurrentTransaction.Rollback();
        }
    }
}
