using System;
using System.Web.Mvc;
using System.Web.Routing;

namespace Epidemosite
{
    public class EPiServerApplication : EPiServer.Global
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            //Tip: Want to call the EPiServer API on startup? Add an initialization module instead (Add -> New Item.. -> EPiServer -> Initialization Module)
        }

        protected override void RegisterRoutes(RouteCollection routes)
        {
            base.RegisterRoutes(routes);

            routes.MapRoute("CreateAdminRoute", "CreateAdminAccount/{action}", new { controller = "CreateAdminAccount", action = "Index" });

            routes.MapRoute("TokenPassingRoute", "TokenPassing/{action}", new { controller = "TokenPassing", action = "Index" });
        }
    }
}