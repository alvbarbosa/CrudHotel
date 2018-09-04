using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Hotel.Api.Controllers;
using Hotel.Bussines;
using Hotel.Datos;

namespace Hotel.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            ServiceRepository repo = new ServiceRepository();
            ManagementServices manage = new ManagementServices(repo);
            ServicesController service = new ServicesController(manage);
            var prueba = service.Get();
            Assert.AreEqual(1, 1);
        }
    }
}
