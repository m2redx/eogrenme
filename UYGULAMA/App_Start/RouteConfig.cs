﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace UYGULAMA
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            var namespaces = new[] { typeof(Areas.Admin.Controllers.PostsController).Namespace };


            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute("Login", "", new { controller = "Auth", action = "Login" }, namespaces);
            routes.MapRoute("Ogrenci", "ogrenci", new { controller = "Ogrenci", action = "Index" }, namespaces);
            routes.MapRoute("Ogretmen", "ogretmen", new { controller = "Ogretmen", action = "Index" }, namespaces);



        }
    }
}
