using JenkinsDemo.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace JenkinsDemo.UnitTests.Controllers
{
    [TestFixture]
    public class HomeControllerTests : IDisposable
    {
        private HomeController _controller;

        [SetUp]
        public void Setup()
        {
            _controller = new HomeController();
        }

        [Test]
        public void Index()
        {
            var result = _controller.Index();
            Assert.IsNotNull(result);
            Assert.IsNotInstanceOf<ViewResult>(result);
        }

        public void Dispose()
        {
        }
    }
}
