using System;
using System.Linq;
using System.Web.Mvc;
using Epidemosite.Business.SiteDependencyResolver;
using EPiServer.Framework;
using EPiServer.Framework.Initialization;
using EPiServer.ServiceLocation;

namespace Epidemosite.Business.Initialization
{
    [InitializableModule]
    public class RegisterDependencyResolverInitializationModule : IConfigurableModule
    {
        public void ConfigureContainer(ServiceConfigurationContext context)
        {
            //DependencyResolver.SetResolver(new ServiceLocatorDependencyResolver(context.StructureMap()));
        }

        public void Initialize(InitializationEngine context)
        {
            DependencyResolver.SetResolver(new ServiceLocatorDependencyResolver(context.Locate.Advanced));
        }

        public void Uninitialize(InitializationEngine context)
        {
            //Add uninitialization logic
        }
    }
}