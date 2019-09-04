using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ProductionManagement
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");


            //set the routes
            //default route
            routes.MapRoute("Default", "", new { controller = "Pages", action = "Index" }, new[] { "ProductionManagement.Controllers" });

            //specific route
            routes.MapRoute("Pages", "{page}", new { controller = "Pages", action = "Index" }, new[] { "ProductionManagement.Controllers" });

            //set the route for partial view
            routes.MapRoute("PagesMenuPartial", "Pages/PagesMenuPartial", new { controller = "Pages", action = "PagesMenuPartial" }, new[] { "ProductionManagement.Controllers" });
            routes.MapRoute("SideBarPartial", "Pages/SideBarPartial", new { controller = "Pages", action = "SideBarPartial" }, new[] { "ProductionManagement.Controllers" });


            //routes.MapRoute(
            //    name: "Default",
            //    url: "{controller}/{action}/{id}",
            //    defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            //);
        }
    }
}
