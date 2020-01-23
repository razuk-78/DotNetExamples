using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Web.Mvc;
using System.Reflection;
using System.Web;
using System.Web.Routing;
using MVC;
namespace UnitTestProject1
{


    [TestClass]
    public class UnitTest1
    {
 


        [TestMethod]
        public void CanMapNormalControllerActionRoute()
        {
     
           RouteConfig.RegisterRoutes(RouteTable.Routes);

            var httpContextMock = new Mock<HttpContextBase>();
            httpContextMock.Setup(c => c.Request.AppRelativeCurrentExecutionFilePath)
                .Returns("~/");

            RouteData routeData = RouteTable.Routes.GetRouteData(httpContextMock.Object);
            Assert.IsNotNull(routeData, "Should have found the route");
            Assert.AreEqual("Home", routeData.Values["Controller"]
                , "Expected a different controller");
            Assert.AreEqual("Index", routeData.Values["action"] , "Expected a different action");
               
        }

        [TestMethod]
        public void TestRouter()
        {
            RouteTable.Routes.MapRoute("test", "{controller}/{year}/{month}/{day}",
                new { controller = "main", action = "index" },
                new { year = @"\d{2}|\d{4}", month = @"\d{1,2}", day = @"\d{1,2}" }

                );
            Mock<HttpContextBase> ctx = new Mock<HttpContextBase>();
            ctx.Setup(e => e.Request.AppRelativeCurrentExecutionFilePath).Returns("~/main/2000/12/11");
            var ctr = RouteTable.Routes.GetRouteData(ctx.Object);
            Assert.AreEqual(RouteTable.Routes.GetRouteData(ctx.Object).Values["controller"], "main");
        }
    }
}
