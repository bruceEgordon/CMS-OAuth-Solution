using EPiServer.ServiceLocation;
using StructureMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Epidemosite.Business.SiteDependencyResolver
{
    public class ServiceLocatorDependencyResolver : IDependencyResolver
    {
        private readonly IServiceLocator _container;
        public ServiceLocatorDependencyResolver(IServiceLocator container)
        {
            _container = container;
        }
        public object GetService(Type serviceType)
        {

            if(serviceType.IsInterface || serviceType.IsAbstract)
            {
                object instance;
                return _container.TryGetExistingInstance(serviceType, out instance) ? instance : null;
                //return _container.TryGetInstance(serviceType);
            }
            return GetConcreteService(serviceType);
        }
        
        public IEnumerable<object> GetServices(Type serviceType)
        {
            return _container.GetAllInstances(serviceType).Cast<object>();
        }

        private object GetConcreteService(Type serviceType)
        {
            try
            {
                return _container.GetInstance(serviceType);
            }
            catch (ActivationException)
            {

                return null;
            }
        }
    }
}