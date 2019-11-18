using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Excepciones;
using Clases_Instanciables;
using EntidadesAbstractas;

namespace UnitTestTP3
{
    [TestClass]
    public class TestsNotNull
    {

        [TestMethod]
        public void TestNotNullListAlumnos()
        {
            // arrange  
            Universidad uni;
            // act  
            uni = new Universidad();
            // assert   
            Assert.IsNotNull(uni.Alumnos);
        }
        [TestMethod]
        public void TestNotNullListInstructores()
        {
            // arrange  
            Universidad uni;
            // act  
            uni = new Universidad();
            // assert   
            Assert.IsNotNull(uni.Instructores);
        }
        [TestMethod]
        public void TestNotNullListJornadas()
        {
            // arrange  
            Universidad uni;
            // act  
            uni = new Universidad();
            // assert   
            Assert.IsNotNull(uni.Jornadas);
        }
    }
}
