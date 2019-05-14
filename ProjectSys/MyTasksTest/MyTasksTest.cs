using System;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyTasks.Controllers;

namespace MyTasksTest
{
    [TestClass]
    public class MyTasksTest
    {
        [TestMethod]
        public void TestLogout()
        {
            UserController controller = new UserController();
            ViewResult result = controller.Logout() as ViewResult;
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void TestRecovery()
        {
            UserController controller = new UserController();
            ViewResult result = controller.Recovery() as ViewResult;
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void TestHome()
        {
            UserController controller = new UserController();
            ViewResult result = controller.Home() as ViewResult;
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void TestRegister()
        {
            UserController controller = new UserController();
            ViewResult result = controller.Register() as ViewResult;
            Assert.IsNotNull(result);
        }
    }
}
