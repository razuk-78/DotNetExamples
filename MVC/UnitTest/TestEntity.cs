using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Web.Mvc;
using System.Reflection;
using MVC.Models;
using System.Data.Entity;
using System.Linq;
using System.Collections.Generic;
using TestingDemo;

namespace MVC.UnitTest
{
    // https://docs.microsoft.com/en-us/ef/ef6/fundamentals/testing/mocking
    [TestClass]
    public class TestEntity
    {
       Mock<DbSet<Blog>> MockBlogs;
       Mock<BloggingContext> mockContext ;
        [TestInitialize]
        public void SetUp()
        {
            mockContext = new Mock<BloggingContext>();
            MockBlogs = new Mock<DbSet<Blog>>();
        }

        [TestMethod]
        public void test()
        {
            var data = new List<Blog>
            {
                new Blog { Name = "BBB" },
                new Blog { Name = "ZZZ" },
                new Blog { Name = "AAA" },
            }.AsQueryable();

            MockBlogs.As<IQueryable<Blog>>().Setup(e => e.Provider).Returns(data.Provider);
            MockBlogs.As<IQueryable<Blog>>().Setup(e => e.Expression).Returns(data.Expression);
            MockBlogs.As<IQueryable<Blog>>().Setup(e => e.ElementType).Returns(data.ElementType);
            MockBlogs.As<IQueryable<Blog>>().Setup(e => e.GetEnumerator()).Returns(data.GetEnumerator());
            
        }

        [TestMethod]
        public void testBlogRepo()
        {
            var data = new List<Blog>
            {
                new Blog { Name = "ABBB" },
                new Blog { Name = "ZZZ" },
                new Blog { Name = "AAA" },
            }.AsQueryable();
            var post = new List<MVC.Models.Post>
            {
             new Post{}
            }.AsQueryable();
            MockBlogs.As<IQueryable<Blog>>().Setup(e => e.Provider).Returns(data.Provider);
            MockBlogs.As<IQueryable<Blog>>().Setup(e => e.Expression).Returns(data.Expression);
            MockBlogs.As<IQueryable<Blog>>().Setup(e => e.ElementType).Returns(data.ElementType);
            MockBlogs.As<IQueryable<Blog>>().Setup(e => e.GetEnumerator()).Returns(data.GetEnumerator());
            mockContext.Setup(e => e.Blogs).Returns(MockBlogs.Object);
            BlogRepo blog = new BlogRepo(mockContext.Object);
            Assert.AreEqual(blog.GetBlogsByName(e=>e.Name.StartsWith("A")).Count,2);
        }
        [TestMethod]
        public void CreateBlog_saves_a_blog_via_context()
        {
            var mockSet = new Mock<DbSet<Blog>>();

            var mockContext = new Mock<BloggingContext>();
            mockContext.Setup(m => m.Blogs).Returns(mockSet.Object);

            var service = new BlogRepo(mockContext.Object);
            service.AddBlog("ADO.NET Blog", "http://blogs.msdn.com/adonet");

            mockSet.Verify(m => m.Add(It.IsAny<Blog>()), Times.Once());
            mockContext.Verify(m => m.SaveChanges(), Times.Once());
        }

        [TestMethod]
        public void CreateDb()
        {
            BloggingContext bloggingContext = new BloggingContext();
          
        }
    }
}
