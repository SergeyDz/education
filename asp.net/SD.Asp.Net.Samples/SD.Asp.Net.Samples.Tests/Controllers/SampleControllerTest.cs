using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SD.Asp.Net.Samples.Controllers;
using System.Web.Mvc;
using System.Threading.Tasks;

namespace SD.Asp.Net.Samples.Tests.Controllers
{
    [TestClass]
    public class SampleControllerTest
    {
        [TestMethod]
        [DeploymentItem(@"Content\", "Content")]
        public void ReadTest()
        {
            SampleController controller = new SampleController();
            ViewResult view = controller.Read() as ViewResult;
        }

        [TestMethod]
        [DeploymentItem(@"Content\", "Content")]
        public async Task AyncReadTest()
        {
            SampleController controller = new SampleController();
            ViewResult view = await controller.AsyncRead() as ViewResult;
        }


        [TestMethod]
        [DeploymentItem(@"Content\", "Content")]
        public void ReadLineTest()
        {
            SampleController controller = new SampleController();
            ViewResult view = controller.ReadLine() as ViewResult;
        }

        [TestMethod]
        [DeploymentItem(@"Content\", "Content")]
        public async Task AyncReadLineTest()
        {
            SampleController controller = new SampleController();
            ViewResult view = await controller.AsyncReadLine() as ViewResult;
        }
    }
}
