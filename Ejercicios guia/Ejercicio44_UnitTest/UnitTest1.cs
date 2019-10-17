using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ejercicio41;

namespace Ejercicio44_UnitTest
{
    [TestClass]
    public class UnitCentralita
    {
        [TestMethod]
        public void TestLlamadasInicializadas()
        {
            // arrange  
            string cenName = "Corp";
            // act  
            Centralita central = new Centralita(cenName);
            // assert   
            Assert.IsNotNull(central.Llamadas);
            
        }
        [TestMethod]
        [ExpectedException(typeof(CentralitaExcepction))]
        public void TestCentralitaExcepctionLocal()
        {
            // arrange  
            string cenName = "Corp";
            Local l1 = new Local("3452345", 30, "23452345", (float)2.65);
            Local l2 = new Local("3452345", 30, "23452345", (float)2.65);
            // act  
            Centralita central = new Centralita(cenName);
            central = central + l1;
            central = central + l2;
            // assert   
            // - es manejado en el ExpectedException
        }
        [TestMethod]
        [ExpectedException(typeof(CentralitaExcepction))]
        public void TestCentralitaExcepctionProvincial()
        {
            // arrange  
            string cenName = "Corp";
            Provincial l1 = new Provincial("53452345", Provincial.Franja.Franja_1, 15, "#546745634");
            Provincial l2 = new Provincial("53452345", Provincial.Franja.Franja_1, 15, "#546745634");
            // act  
            Centralita central = new Centralita(cenName);
            central = central + l1;
            central = central + l2;
            // assert   
            // - es manejado en el ExpectedException
        }

        [TestMethod]
        public void TestCompararLlamadas()
        {
            // arrange  
            string cenName = "Corp";
            Llamada l1 = new Local("3452345", 30, "23452345", (float)2.65);
            Llamada l2 = new Local("3452345", 30, "23452345", (float)2.65);
            Llamada p1 = new Provincial("53452345", Provincial.Franja.Franja_1, 15, "#546745634");
            Llamada p2 = new Provincial("53452345", Provincial.Franja.Franja_1, 15, "#546745634");
            // act  
            Centralita central = new Centralita(cenName);
            // assert   
            Assert.IsTrue(l1 == l2);
            Assert.IsTrue(p1 == p2);
            Assert.IsFalse(l1 == p1);
            Assert.IsFalse(l1 == p2);
            Assert.IsFalse(l2 == p1);
            Assert.IsFalse(l2 == p2);
        }

    }
}
