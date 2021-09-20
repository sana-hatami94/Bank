using Castle.MicroKernel.Registration;
using Castle.MicroKernel.Resolvers.SpecializedResolvers;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Web.Http;
using System.Web.Http.Dispatcher;

namespace InterfaceUI
{
    public class Startup
    {
        private static readonly WindsorContainer Container = new WindsorContainer();
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            var container = new WindsorContainer();
            ConfigurPrj.Bootstraper.WireUp(container);

            var container2= new WindsorContainer();
            container.Install(new KernelInstaller());

            var activator = new ControllerActivator(container);
            GlobalConfiguration.Configuration
                .Services.Replace(typeof(IHttpControllerActivator), activator);


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

        }


        public class KernelInstaller : IWindsorInstaller
        {
            public void Install(IWindsorContainer container, IConfigurationStore store)
            {
                //container.Register(Classes.FromAssemblyInThisApplication.BasedOn<ApiController>().LifestyleTransient());
                container.Kernel.Resolver.AddSubResolver(new CollectionResolver(container.Kernel, true));
            }
        }
    }
}
