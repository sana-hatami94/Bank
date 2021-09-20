using BankApplication;
using Castle.MicroKernel.Registration;
using Castle.Windsor;
using Framework.Core;
using Framework.EntityFramework;
using Infrastructure.EF.Repositories;

namespace ConfigurPrj
{
    public class Bootstraper
    {
        public static void WireUp(IWindsorContainer container)
        {
            container.Register(Component.For<TransactionInterceptor>().LifestyleScoped());

            container.Register(Component.For<ICartTransferService>()
                .ImplementedBy<CartTransferService>()
                //.Interceptors<TransactionInterceptor>() ===> وقت نشد ...با دات نت کور مشکل داشت 
                .LifestyleScoped());

            container.Register(Component.For<BankAccountRepository>()
                .LifestyleScoped());

            container.Register(Component.For<PersonRepository>()
                 .LifestyleScoped());

            container.Register(Component.For<CartTransferTransactionRepository>()
          .LifestyleScoped());


            container.Register(Component.For<IUnitOfWork>()
                .ImplementedBy<EFUnitOfWork>()
                .LifestyleScoped());

         

        }
    }
}
