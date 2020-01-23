using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using System.Web.Routing;
namespace WebApplication2
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            //RouteTable.Routes.MapPageRoute("my rout", "myUrl", "~/List.aspx");
            Route reportRoute = new Route("{locale}", new ReportRouteHandler());

            RouteTable.Routes.Add(reportRoute);

        }
    
            protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
    class test
    {
        public test()
        {

        }
    }
    internal class ReportRouteHandler : IRouteHandler
    {
        public IHttpHandler GetHttpHandler(RequestContext requestContext)
        {
            
            return requestContext.HttpContext.Handler;
           //throw new NotImplementedException();
        }
        public bool CheckPhysicalUrlAccess => true;
        public string VirtualPath => "~/List.aspx";
    }
}