using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Hotel.Datos;

namespace Hotel.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Service service = new Service();
            var services = service.getAll();
            Assert.AreEqual(services.Count, 2);
        }
    }
}
