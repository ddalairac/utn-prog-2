using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ejercicio41;

namespace Ejercicio44_UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string cenName = "Saltamonte";

            Centralita central = new Centralita(cenName);

            Assert.IsNotNull(central.Llamadas);
        }
    }
}
