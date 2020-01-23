using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Web.Mvc;
using System.Reflection;
using System.Web;
using System.Web.Routing;
using MVC;
using System.Web.Routing;
using MVC.Controllers;

namespace MVC.UnitTest
{
    [TestClass]
    public class TestController
    {
        [TestMethod]
        public void TestHome()
        {
            HomeController home = new HomeController();
            ViewResult vr = (ViewResult)home.Index();

            Assert.AreEqual(vr.ViewName, "Index", vr.ViewName);
        }
    }
}