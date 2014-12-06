using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace RenderLib
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            //Ignore routes that have an .axd extension (trace.axd & resource.axd)
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //Registers MVC5 Attribute Routing
            routes.MapMvcAttributeRoutes();

            //Default Routing
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Renders", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
