using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ENTITY;
using BLL;

//using ProyectoHotelPensionados;

namespace UnitTestAsignaturas
{
    [TestClass]

    public class UnitTestValidaConsultar
    {
        UpcService upcService = new UpcService();
  
        [TestMethod]
        public void Test_CompararTodosLosDatos_Asignatura()
        {
            //Arrange
            var codigoDR = "123";

            var expectedNombre = "Software 01";
            var expectedPrograma = "INGENIERIA SISTEMAS";
            var expectedTipoAsignatura = "Teorico / Practico";
            var expectedCreditos = 3;

            //Action
            RespuestaBusqueda respuesta = upcService.BuscarAsignatura(codigoDR);
            if (respuesta.Asignatura != null)
            {
                Asignaturas asignatura = respuesta.Asignatura;
                var actualNombre = asignatura.Nombre;
                var actualPrograma = asignatura.Programa;
                var actualTipoAsignatura = asignatura.TipoAsignatura;
                var actualCreditos = asignatura.Creditos;

                //Assert o Afirmar
                Assert.AreEqual(expectedNombre, actualNombre);
                Assert.AreEqual(expectedPrograma, actualPrograma);
                Assert.AreEqual(expectedTipoAsignatura, actualTipoAsignatura);
                Assert.AreEqual(expectedCreditos, actualCreditos);
            }           
        }
    
        [TestMethod]
        public void Test_CompararCodigos_Asignatura()
        {
            //Arrange
            var codigoDR = "123";
            var Experado = "123";

            //Action
            RespuestaBusqueda respuesta = upcService.BuscarAsignatura(codigoDR);
            if (respuesta.Asignatura != null)
            {
                Asignaturas asignatura = respuesta.Asignatura;
                var actual = asignatura.Codigo;

                //Assert o Afirmar
                Assert.AreEqual(actual, Experado);
            }          
        }

        [TestMethod]
        public void Test_CompararTodosLosDatos_Docente()
        {
            //Arrange
            var IdentificacionDR = "1";

            var experadoNombre = "Eydy";
            var experadoApellido = "Suarez Brieva";
            var experadoTelefono = "302293220";
            var experadoCorreo = "Eydy@unicesar.edu.co";
            var experadoCategoria = "Docente catedratico";
            var experadoMateria = "Software 01";

            //Action
            RespuestaBusqueda respuesta = upcService.BuscarDocente(IdentificacionDR);
            if (respuesta.Docente != null)
            {
                Docentes docente = respuesta.Docente;
                var actualNombre = docente.Nombre;
                var actualApellido = docente.Apellido;
                var actualTelefono = docente.Telefono;
                var actualCorreo = docente.Correo;
                var actualCategoria = docente.Categoria;
                var actualMateria = docente.Materia;

                //Assert o Afirmar
                Assert.AreEqual(experadoNombre, actualNombre);
                Assert.AreEqual(experadoApellido, actualApellido);
                Assert.AreEqual(experadoTelefono, actualTelefono);
                Assert.AreEqual(experadoCorreo, actualCorreo);
                Assert.AreEqual(experadoCategoria, actualCategoria);
                Assert.AreEqual(experadoMateria, actualMateria);
            }
        }

        [TestMethod]
        public void Test_CompararCodigos_Docente()
        {
            //Arrange
            var IdentificacionDR = "1";
            var experado = "1";

            //Action
            RespuestaBusqueda respuesta = upcService.BuscarDocente(IdentificacionDR);
            if (respuesta.Docente != null)
            {
                Docentes docente = respuesta.Docente;
                var actual = docente.Identificacion;

                //Assert o Afirmar
                Assert.AreEqual(actual, experado);
            }
        }




























































        //[TestMethod]
        //public void TestIncorrectoAsignaturaTodosLosDatos()
        //{
        //    //Arrange
        //    var codigoDR = "123";
        //    var expectedNombre = "Mecanica";
        //    var expectedPrograma = "INGENIERIA AMBIENTAL";
        //    var expectedTipoAsignatura = "Practico";
        //    var expectedCreditos = "2";

        //    //Action
        //    Asignaturas asignatura = AsignaturaRepository.BuscarAsignatura(codigoDR);
        //    if (asignatura != null)
        //    {
        //        var actualNombre = asignatura.Nombre;
        //        var actualPrograma = asignatura.Programa;
        //        var actualTipoAsignatura = asignatura.TipoAsignatura;
        //        var actualCreditos = asignatura.Creditos;

        //        //Assert o Afirmar
        //        Assert.AreEqual(expectedNombre, actualNombre);
        //        Assert.AreEqual(expectedPrograma, actualPrograma);
        //        Assert.AreEqual(expectedTipoAsignatura, actualTipoAsignatura);
        //        Assert.AreEqual(expectedCreditos, actualCreditos);
        //    }
        //    else
        //    {
        //        Assert.Fail(expectedNombre, expectedPrograma, expectedTipoAsignatura, expectedCreditos);
        //    }
        //}













        //[TestMethod]
        //public void TestIncorrectoAsignaturaCodigo()
        //{
        //    //Arrange
        //    var codigoDR = "123";
        //    var expected = "2342453254325432453";

        //    //Action
        //    Asignaturas asignatura = AsignaturaRepository.BuscarAsignatura(codigoDR);
        //    if (asignatura != null)
        //    {
        //        var actual = asignatura.Codigo;

        //        //Assert o Afirmar
        //        Assert.AreEqual(expected, actual);
        //    }
        //    else
        //    {
        //        Assert.Fail(expected);
        //    }
        //}
    }
}
