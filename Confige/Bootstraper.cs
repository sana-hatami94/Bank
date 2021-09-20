using Castle.MicroKernel.Registration;
using Castle.Windsor;
using Framework.Core;

namespace Confige
{
    public class Bootstraper
    {
        public static void WireUp(IWindsorContainer container)
        {
            container.Register(Component.For<TransactionInterceptor>().LifestyleSingleton());

            container.Register(Component.For<IAuctionService>()
                .ImplementedBy<AuctionService>()
                .Interceptors<TransactionInterceptor>()
                .LifestylePerWebRequest());

            container.Register(Component.For<IAuctionRepository>()
                .ImplementedBy<AuctionRepository>()
                .LifestylePerWebRequest());

            container.Register(Component.For<ISession>()
                            .UsingFactoryMethod(a => factory.OpenSession())
                            .LifestylePerWebRequest());

            container.Register(Component.For<IUnitOfWork>()
                .ImplementedBy<EFUnitOfWork>()
                .LifestylePerWebRequest());

            container.Register(Component.For<AuctionsController>()
                .LifestylePerWebRequest());
        }
    }
}
