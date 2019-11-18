using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Excepciones;
using Clases_Instanciables;
using EntidadesAbstractas;

namespace UnitTestTP3
{
    [TestClass]
    public class TestsIsTrue
    {

        [TestMethod]
        public void TestAddProfesorIsTrue()
        {
            // arrange  
            Universidad uni;
            Profesor profesor;
            int idProf = 2;
            string nombreProf = "Charles";
            string apellidoProf = "Xavier";
            string dniProf = "92264456";
            Persona.ENacionalidad nacionalidadProf = Persona.ENacionalidad.Extranjero;

            // act  
            uni = new Universidad();
            profesor = new Profesor(idProf, nombreProf, apellidoProf, dniProf, nacionalidadProf);
            uni += profesor;

            // assert   
            Assert.IsTrue(uni.Instructores.Count == 1);
        }
        [TestMethod]
        public void TestAddAlumnoIsTrue()
        {
            // arrange  
            Universidad uni;
            Alumno alumno;
            int id = 1;
            string nombre = "Diego"; ;
            string apellido = "Dalairac";
            string dni = "12234456";
            Persona.ENacionalidad nacionalidad = Persona.ENacionalidad.Argentino;
            Universidad.EClases claseQueToma = Universidad.EClases.Laboratorio;

            // act  
            uni = new Universidad();
            alumno = new Alumno(id, nombre, apellido, dni, nacionalidad, claseQueToma);
            uni += alumno;

            // assert   
            Assert.IsTrue(uni.Alumnos.Count == 1);
        }
        [TestMethod]
        public void TestDniPropertyIsNumberTrue()
        {
            // arrange  
            Alumno alumno;
            int id = 1;
            string nombre = "Diego"; ;
            string apellido = "Dalairac";
            string dni = "12234456";
            Persona.ENacionalidad nacionalidad = Persona.ENacionalidad.Argentino;
            Universidad.EClases claseQueToma = Universidad.EClases.Laboratorio;


            // act  
            alumno = new Alumno(id, nombre, apellido, dni, nacionalidad, claseQueToma);

            // assert   
            Assert.IsTrue(alumno.DNI.GetType() == typeof(int));
        }

        [TestMethod]
        public void TestDniParseoCorrectoTrue()
        {
            // arrange  
            Alumno alumno;
            int id = 1;
            string nombre = "Diego"; ;
            string apellido = "Dalairac";
            string dni = "12234456";
            Persona.ENacionalidad nacionalidad = Persona.ENacionalidad.Argentino;
            Universidad.EClases claseQueToma = Universidad.EClases.Laboratorio;

            int dniNumero = 12234456;

            // act  
            alumno = new Alumno(id, nombre, apellido, dni, nacionalidad, claseQueToma);

            // assert   
            Assert.IsTrue(alumno.DNI == dniNumero);
        }
    }
}
