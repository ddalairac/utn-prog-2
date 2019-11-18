using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Excepciones;
using Clases_Instanciables;
using EntidadesAbstractas;

namespace UnitTestTP3
{
    [TestClass]
    public class TestsExcepciones
    {

        [TestMethod]
        [ExpectedException(typeof(DniInvalidoException))]
        public void TestExcepciontDniInvalido()
        {
            // arrange
            Alumno alumno;
            int id = 1;
            string nombre = "Diego"; ;
            string apellido = "Dalairac";
            string dni = "AR122344";
            Persona.ENacionalidad nacionalidad = Persona.ENacionalidad.Argentino;
            Universidad.EClases claseQueToma = Universidad.EClases.Laboratorio;

            // act
            alumno = new Alumno(id, nombre, apellido, dni, nacionalidad, claseQueToma);

            //assert

        }
        [TestMethod]
        [ExpectedException(typeof(NacionalidadInvalidaException))]
        public void TestExcepcionNacionalidadInvalida()
        {
            // arrange
            Alumno alumno;
            int id = 1;
            string nombre = "Cosme"; ;
            string apellido = "Fulanito";
            string dni = "1";
            Persona.ENacionalidad nacionalidad = Persona.ENacionalidad.Extranjero;
            Universidad.EClases claseQueToma = Universidad.EClases.Laboratorio;
            Alumno.EEstadoCuenta cuenta = Alumno.EEstadoCuenta.AlDia;

            // act
            alumno = new Alumno(id, nombre, apellido, dni, nacionalidad, claseQueToma, cuenta);

            //assert

        }
        [TestMethod]
        [ExpectedException(typeof(SinProfesorException))]
        public void TestExcepcionSinProfesor()
        {
            // arrange  
            Universidad uni;
            Universidad.EClases clase = Universidad.EClases.SPD;

            // act  
            uni = new Universidad();
            uni += clase;

            // assert   
        }
        [TestMethod]
        [ExpectedException(typeof(AlumnoRepetidoException))]
        public void TestExcepciontAlumnoRepetido()
        {
            // arrange
            Universidad uni;
            Alumno alumno;
            int id = 1;
            string nombre = "Diego"; ;
            string apellido = "Dalairac";
            string dni = "123456";
            Persona.ENacionalidad nacionalidad = Persona.ENacionalidad.Argentino;
            Universidad.EClases claseQueToma = Universidad.EClases.Laboratorio;
            Alumno alumno2;
            int id2 = 1;
            string nombre2 = "Bruce"; ;
            string apellido2 = "Waine";
            string dni2 = "123456";
            Persona.ENacionalidad nacionalidad2 = Persona.ENacionalidad.Argentino;
            Universidad.EClases claseQueToma2 = Universidad.EClases.Programacion;

            // act
            uni = new Universidad();
            alumno = new Alumno(id, nombre, apellido, dni, nacionalidad, claseQueToma);
            alumno2 = new Alumno(id2, nombre2, apellido2, dni2, nacionalidad2, claseQueToma2);
            uni += alumno;
            uni += alumno2;

            //assert
        }

    }
}
