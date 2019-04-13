using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace BensHub
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                "Message",
                "VisitorBoard/PostMessage",
                new { controller = "VisitorBoard", action = "PostMessage" }
            );

            routes.MapRoute(
                "FileDownload",
                "MyFile/CollectFile",
                new { controller = "File", action = "CollectFile" }
            );

            routes.MapRoute(
                "OnlyAction",
                "{action}",
                new { controller = "Home", action = "Index" }
            );
        }
    }
}
