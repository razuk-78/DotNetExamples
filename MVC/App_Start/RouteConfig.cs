﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVC
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
  //          routes.MapRoute("blog-route", "blog/{year}/{month}/{day}",
  //    new { controller = "Blog", action = "Details"}
  //    //consentraint
  //    //,new { year = @"\d{4}", month = @"\d{2}", day = @"\d{2}" }
  //);
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
               
            );
          

        }
    }
}
