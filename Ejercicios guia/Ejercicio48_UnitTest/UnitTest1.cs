using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ejercicio48;

namespace Ejercicio48_UnitTest
{
    [TestClass]
    public class UnitTestContabilidad
    {
        [TestMethod]
        public void TestListNotNull()
        {
            // arrange  
            Contabilidad<Factura, Remito> cont;
            // act  
            cont = new Contabilidad<Factura, Remito>();
            cont += new Factura(500);
            cont += new Factura(670);
            cont += new Factura(80);
            cont += new Factura(23500);
            cont += new Remito(23423);
            cont += new Remito(654);
            cont += new Remito(867);
            cont += new Remito(25);
            cont += new Remito();
            // assert   
            Assert.IsNotNull(cont.Egresos);
            Assert.IsNotNull(cont.Ingresos);
        }
        [TestMethod]
        public void TestAddItems()
        {
            // arrange  
            Contabilidad<Factura, Remito> cont;
            // act  
            cont = new Contabilidad<Factura, Remito>();
            cont += new Factura(500);
            cont += new Remito();
            // assert   
            Assert.IsTrue(cont.Egresos.Count > 0);
            Assert.IsTrue(cont.Ingresos.Count > 0);
        }
    }
}
