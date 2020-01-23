using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVC
{
    public class MvcApplication : System.Web.HttpApplication
    {
      
        protected void Application_Start()
        {
            
 
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
           // System.Web.Mvc.FilterProviders.Providers.Add()
        }
        //
        // Summary:
        //     Specifies a a callback to invoke when a request execution step is executed.
        //
        // Parameters:
        //   callback:
        //     The callback method.
   
       
    }
}
