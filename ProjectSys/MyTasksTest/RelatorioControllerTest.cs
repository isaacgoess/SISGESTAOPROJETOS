using System;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyTasks.Controllers;

namespace MyTasksTest
{
    [TestClass]
    public class RelatorioControllerTest
    {
        [TestMethod]
        public void IndexRelatorio()
        {
            var controller = new UserController();
            var result = controller.HomeRel() as ViewResult;
            Assert.AreEqual("Rel_Home", result.View);
        }

        [TestMethod]
        public void ProjectRelatorio()
        {
            var controller = new UserController();
            var result = controller.ListProjects() as ViewResult;
            Assert.AreEqual("Rel_Projects", result.View);
        }

        [TestMethod]
        public void TaskRelatorio()
        {
            var controller = new UserController();
            var result = controller.ListTaks() as ViewResult;
            Assert.AreEqual("Rel_Taks", result.View);
        }

        [TestMethod]
        public void BackRelatorio()
        {
            var controller = new UserController();
            var result = controller.Back() as ViewResult;
            Assert.AreEqual("Rel_Home", result.View);
        }
    }
}
