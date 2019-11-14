using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVCBasic_Viewdate
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            //忽略.axd
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "MACRounte",
                url: "Mac",
                defaults: new { controller = "Mac", action = "MacPage", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "iPadRounte",
                url: "iPad",
                defaults: new { controller = "iPad", action = "iPadPage", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "iPhoneRounte",
                url: "iPhone",
                defaults: new { controller = "iPhone", action = "iPhonePage", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "WatchRounte",
                url: "Watch",
                defaults: new { controller = "Watch", action = "WatchPage", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "EmployeesRounte",
                url: "Employees",
                defaults: new { controller = "Employees", action = "index", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "FriendsRounte",
                url: "Friends",
                defaults: new { controller = "Friends", action = "index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
