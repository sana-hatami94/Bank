using Castle.Windsor;
using System;
using System.Net.Http;
using System.Web.Http.Controllers;
using System.Web.Http.Dispatcher;

namespace InterfaceUI
{
    public class ControllerActivator : IHttpControllerActivator
    {

        public ControllerActivator(IWindsorContainer container)
        {
            _container = container;

        }
        protected IWindsorContainer _container;

        public IHttpController Create(HttpRequestMessage request, HttpControllerDescriptor controllerDescriptor, Type controllerType)
        {
            if (_container.Kernel.HasComponent(controllerType))
            {
                return (IHttpController)_container.Resolve(controllerType);
            }
            else
            {
                return null;
            }

        }
    }
}
