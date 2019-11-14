using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using Entidades;
using Excepciones;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        public void ManejadorVoto(string senador, Votacion.EVoto voto)
        {
        }
        [TestMethod]
        public void TestEvento()
        {
            // arrange
            Votacion v;
            Dictionary<string, Votacion.EVoto> participantes;
            Thread tSimular;
            int totalVotos = 0;
            int totalSenadores = 72;

            // act
            participantes = new Dictionary<string, Votacion.EVoto>();
            for (int i = 0; i < totalSenadores; i++)
            {
                participantes.Add(i.ToString(), Votacion.EVoto.Abstencion);
            }
            v = new Votacion("some ley", participantes);
            v.EventoVotoEfectuado += ManejadorVoto;
            v.Simular();

            totalVotos += v.ContadorAbstencion;
            totalVotos += v.ContadorAfirmativo;
            totalVotos += v.ContadorNegativo;

            //assert
            Assert.AreEqual(totalVotos, totalSenadores);
        }
        [TestMethod]
        [ExpectedException(typeof(ErrorArchivoException))]
        public void TestExcepciontGuardarArchivo()
        {
            // arrange
            Votacion v;
            SerializarXML<Votacion> xml;
            string archivo = "../../../../../" + Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory), "Votacion-test.xml");

            // act
            v = new Votacion("ley", new Dictionary<string, Votacion.EVoto>());

            xml = new SerializarXML<Votacion>();
            xml.Guardar(archivo, v);

            //assert

        }
    }
}
