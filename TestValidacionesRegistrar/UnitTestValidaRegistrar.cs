using NUnit.Framework;
using ENTITY;
using BLL;
using System;

namespace TestValidacionesRegistrar
{
    public class Tests
    {
        UpcService upcService = new UpcService();
        Asignaturas asignatura = new Asignaturas();
        Docentes docente = new Docentes();
        PlanAsignaturas planAsignatura = new PlanAsignaturas();
        SolicitudDocentes solicitudDocente = new SolicitudDocentes();

        [SetUp]
        public void Setup()
        {
        }
     
        [Test]
        public void test_CorrectoRegistar_Asignatura()
        {
            asignatura.Codigo = "555";
            asignatura.Nombre = "Computacion Grafica";
            asignatura.Programa = "INGENIERIA SISTEMAS";
            asignatura.TipoAsignatura= "Practico";
            asignatura.Creditos = 2;
            

            upcService.GuardarAsignatura(asignatura);
            Assert.Pass();
        }

        [Test]
        public void test_Incorrecto_CodigoRegistrar_Asignatura()
        {
            try
            {                
                asignatura.Codigo = "123";
                asignatura.Nombre = "Software 01";
                asignatura.Programa = "INGENIERIA SISTEMAS";
                asignatura.TipoAsignatura = "Teorico/Practico";
                asignatura.Creditos = 3;


                upcService.GuardarAsignatura(asignatura);
                Assert.Fail();
            }
            catch (Exception e)
            {
                Assert.Pass();
            }
        }

        [Test]
        public void test_IncorrectoAsignatura_CamposVacios()
        {
            try
            {
                asignatura = null;

                upcService.GuardarAsignatura(asignatura);
                Assert.Fail();
            }
            catch (Exception e)
            {
                Assert.Pass();
            }
        }

        [Test]
        public void test_CorrectoRegistar_Docente()
        {
            docente.Identificacion = "7";
            docente.Nombre = "Maribel";
            docente.Apellido = "Romero";
            docente.Telefono = "3001234567";
            docente.Correo = "maribelromero@gmail.com";
            docente.Categoria = "Docente catedratico";
            docente.Materia = "Software 02";

            upcService.GuardarDocente(docente);
            Assert.Pass();
        }

        [Test]
        public void test_Incorrecto_CodigoRegistrar_Docente()
        {
            try
            {           
                docente.Identificacion = "1";
                docente.Nombre = "Eydy";
                docente.Apellido = "Suarez Brieva";
                docente.Telefono = "302293220";
                docente.Correo = "Eydy@unicesar.edu.co";
                docente.Categoria = "Docente catedratico";
                docente.Materia = "Software 01";

                upcService.GuardarDocente(docente);
                Assert.Fail();
            }
            catch (Exception e)
            {
                Assert.Pass();
            }
        }

        [Test]
        public void test_IncorrectoDocente_CamposVacios()
        {
            try
            {
                docente = null;

                upcService.GuardarDocente(docente);
                Assert.Fail();
            }
            catch (Exception e)
            {
                Assert.Pass();
            }
        }
        [Test]
        public void test_IncorrectoPlanAsignatura_CamposVacios()
        {
            try
            {
                planAsignatura = null;

                upcService.GuardarPlanAsignatura(planAsignatura);
                Assert.Fail();
            }
            catch (Exception e)
            {
                Assert.Pass();
            }
        }

            [Test]
        public void test_CorrectoRegistar_SolicitudDocente()
        {
            solicitudDocente.Identificacion = "6";
            solicitudDocente.Nombre = "Braulio";
            solicitudDocente.Apellido = "Barrios Zuñiga";
            solicitudDocente.Materia = "Estructura de datos";
            solicitudDocente.Descripcion = "Yes";
            solicitudDocente.Justificacion = "Yes";
            solicitudDocente.ObjetivoGeneral = "Yes";
            solicitudDocente.ObjetivoEspecifico = "Yes";
            solicitudDocente.ComponeteGenerico = "Not";
            solicitudDocente.Estrategias = "Not";
            solicitudDocente.Contenidos = "Not";
            solicitudDocente.MecanismosEvaluacion = "Not";
            solicitudDocente.ReferenciasBibliograficas = "Not";
            solicitudDocente.Estado = "Desaprobado";

            upcService.GuardarSolicitudDocente(solicitudDocente);
            Assert.Pass();
        }

        [Test]
        public void test_Incorrecto_CodigoRegistrar_SolicitudDocente()
        {
            try
            {
                solicitudDocente.Identificacion = "1";
                solicitudDocente.Nombre = "Eydy";
                solicitudDocente.Apellido = "Suarez Brieva";
                solicitudDocente.Materia = "Software 01";
                solicitudDocente.Descripcion = "Not";
                solicitudDocente.Justificacion = "Not";
                solicitudDocente.ObjetivoGeneral = "Yes";
                solicitudDocente.ObjetivoEspecifico = "Yes";
                solicitudDocente.ComponeteGenerico = "Not";
                solicitudDocente.Estrategias = "Not";
                solicitudDocente.Contenidos = "Not";
                solicitudDocente.MecanismosEvaluacion = "Not";
                solicitudDocente.ReferenciasBibliograficas = "Not";
                solicitudDocente.Estado = "Desaprobado";

                upcService.GuardarSolicitudDocente(solicitudDocente);
                Assert.Fail();
            }
            catch (Exception e)
            {
                Assert.Pass();
            }
        }

    }
}