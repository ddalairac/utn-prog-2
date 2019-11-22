using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.IO;
using Entidades;
using Archivos;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestGuardarLeer()
        {
            //Arrange 
            List<Planeta> planetas = new List<Planeta>();
            List<Planeta> planetasLeidos = new List<Planeta>();
            planetas.Add(new Planeta(12, 0, 150,  new Object()) );
            planetas.Add(new Planeta(8, 0, 250, new Object()) );
            Xml<List<Planeta>> xml = new Xml<List<Planeta>>();

            string desktop = xml.GetDirectoryPath;
            string path = Path.Combine(desktop, "Test.xml");
            
            // Act
           
            xml.Guardar(path, planetas);
            xml.Leer(path, out planetasLeidos);

            //Assert

            Assert.AreEqual(planetas[0].PosicionActual, planetasLeidos[0].PosicionActual);
            Assert.AreEqual(planetas[0].RadioRespectoSol, planetasLeidos[0].RadioRespectoSol);
            Assert.AreEqual(planetas[1].PosicionActual, planetasLeidos[1].PosicionActual);
            Assert.AreEqual(planetas[1].RadioRespectoSol, planetasLeidos[1].RadioRespectoSol);
        }
        [TestMethod]
        [ExpectedException(typeof(ErrorArchivosException))]
        public void TestErrorArchivosException()
        {
            // arrange 
            //Arrange 
            List<Planeta> planetas = new List<Planeta>();
            List<Planeta> planetasLeidos = new List<Planeta>();
            planetas.Add(new Planeta(12, 0, 150, new Object()));
            planetas.Add(new Planeta(8, 0, 250, new Object()));
            Xml<List<Planeta>> xml = new Xml<List<Planeta>>();

            string desktop = xml.GetDirectoryPath;
            string path = Path.Combine("../../../" + desktop, "Test.xml");
            // act 
            xml.Guardar(path, planetas);
            // assert es manejado en el ExpectedException 
        }

    }
}
