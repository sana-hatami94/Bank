using Castle.DynamicProxy;
using Framework.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConfigurPrj
{
    public class TransactionInterceptor
    {
        private readonly IUnitOfWork _unitOfWork;
        public TransactionInterceptor(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }

        public void Intercept(IInvocation invocation)
        {
            _unitOfWork.Begin();
            try
            {
                invocation.Proceed();
                _unitOfWork.Commit();
            }
            catch (Exception)
            {
                _unitOfWork.Rollback();
                throw;
            }
        }
    }
}
