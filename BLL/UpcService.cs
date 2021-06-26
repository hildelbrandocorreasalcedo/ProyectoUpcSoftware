using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITY;
using DAL;

namespace BLL
{
    public class UpcService
    {
        private readonly UpcRepository AsignaturaRepository;
        private readonly UpcRepository DocenteRepository;
        private readonly UpcRepository PlanAsignaturaRepository;

        public UpcService()
        {
            AsignaturaRepository = new UpcRepository();
            DocenteRepository = new UpcRepository();
            PlanAsignaturaRepository = new UpcRepository();
        }

        //////////////////////////////////------------------------///////////////////////////////////////
        /////////////////////////////////------Asignaturas-------///////////////////////////////////////
        ////////////////////////////////------------------------///////////////////////////////////////

        public string GuardarAsignatura(Asignaturas asignatura)
        {
            try
            {
                if (AsignaturaRepository.BuscarAsignatura(asignatura.Codigo) == null)
                {
                    AsignaturaRepository.GuardarAsignatura(asignatura);
                    return "Los Datos han sido guardados satisfactoriamente";
                }
                return $"El Codigo {asignatura.Codigo} ya se encuentra registrada por favor verifique los datos";
            }
            catch (Exception e)
            {
                return "Error de Datos: " + e.Message;
            }
        }

        public string EliminarAsignatura(string codigo)
        {
            try
            {
                if (AsignaturaRepository.BuscarAsignatura(codigo) != null)
                {
                    AsignaturaRepository.EliminarAsignatura(codigo);
                    return $"La asignatura con codigo {codigo} ha sido eliminada satisfacatoriamente";
                }
                return $"La asignatura {codigo} no se encuentra registrada, por favor verifique los datos";
            }
            catch (Exception e)
            {

                return "Error de datos" + e.Message;
            }
        }

        public string ModificarCurso(Asignaturas asignatura)
        {
            try
            {
                if (AsignaturaRepository.BuscarAsignatura(asignatura.Codigo) != null)
                {
                    AsignaturaRepository.ModificarAsignatura(asignatura);
                    return $"La asignatura con codigo {asignatura.Codigo} ha sido modificada satisfacatoriamente";
                }
                return $"La asignatura {asignatura.Codigo} no se encuentra registrada, por favor verifique los datos";
            }
            catch (Exception e)
            {
                return "Error de datos" + e.Message;
            }
        }

        public string ModificarAsignatura(Asignaturas codigo)
        {
            try
            {
                if (AsignaturaRepository.BuscarAsignatura(codigo.Codigo) != null)
                {
                    AsignaturaRepository.ModificarAsignatura(codigo);
                    return $"La asignatura con el codigo {codigo.Codigo} ha sido modificada satisfacatoriamente";
                }
                return $"El codigo {codigo.Codigo} no se encuentra registrado, por favor verifique los datos";
            }
            catch (Exception e)
            {
                return "Error de datos" + e.Message;
            }
        }
        public RespuestaBusqueda BuscarAsignatura(string Codigo)
        {
            RespuestaBusqueda respuesta = new RespuestaBusqueda();
            try
            {
                respuesta.Error = false;
                Asignaturas curso = AsignaturaRepository.BuscarAsignatura(Codigo);
                if (curso == null)
                {
                    respuesta.Mensaje = $"La asignatura con Codigo {Codigo} no se encuentra registrado";
                    respuesta.Asignatura = null;
                }
                else
                {
                    respuesta.Asignatura = curso;
                    respuesta.Mensaje = "Asignatura encontrada\n\n";
                }
            }
            catch (Exception E)
            {
                respuesta.Mensaje = "Error de lectura o escritura de archivos: " + E.Message;
                respuesta.Asignatura = null;
                respuesta.Error = true;
            }
            return respuesta;
        }

        public RespuestaConsulta ConsultarTodosAsignaturas()
        {
            RespuestaConsulta respuesta = new RespuestaConsulta();
            try
            {
                respuesta.Error = false;
                IList<Asignaturas> Cursoss = AsignaturaRepository.ConsultarTodosAsignaturas();
                if (Cursoss.Count != 0)
                {
                    respuesta.Mensaje = "Se Consulta la Informacion de aignatura";
                    respuesta.Asignaturas = Cursoss;
                }
                else
                {
                    respuesta.Mensaje = "No existen Datos para Consultar";
                    respuesta.Asignaturas = null;
                }
            }
            catch (Exception e)
            {
                respuesta.Error = true;
                respuesta.Mensaje = $"Erro en datos: " + e.Message;
                respuesta.Asignaturas = null;
            }
            return respuesta;
        }

        public ConsultaCandidatoResponse ConsultarTodosAsignaturasDtg()
        {
            try
            {
                List<Asignaturas> asignatura = AsignaturaRepository.ConsultarTodosAsignaturasDtg();
                if (asignatura != null)
                {
                    return new ConsultaCandidatoResponse(asignatura);
                }
                else
                {
                    return new ConsultaCandidatoResponse("La asignatura buscada no se encuentra Registrada");
                }
            }
            catch (Exception e)
            {
                return new ConsultaCandidatoResponse("Error de Aplicacion: " + e.Message);
            }
        }

        public class ConsultaCandidatoResponse
        {
            public List<Asignaturas> Asignatura { get; set; }
            public string Message { get; set; }

            public ConsultaCandidatoResponse(List<Asignaturas> asignatura)
            {
                Asignatura = new List<Asignaturas>();
                Asignatura = asignatura;
            }
            public ConsultaCandidatoResponse(string message)
            {
                Message = message;
            }
        }

        //public string GuardarAsignatura(Asignaturas asignatura)
        //{
        //    try
        //    {
        //        if (AsignaturaRepository.BuscarAsignatura(asignatura.Codigo) == null)
        //        {
        //            AsignaturaRepository.GuardarAsignatura(asignatura);
        //            return "Los Datos han sido guardados satisfactoriamente";
        //        }
        //        return $"El codigo {asignatura.Codigo} ya se encuentra registrado por favor verifique los datos";
        //    }
        //    catch (Exception e)
        //    {
        //        return "Error de Datos: " + e.Message;
        //    }
        //}

        //public string EliminarAsignatura(string codigo)
        //{
        //    try
        //    {
        //        if (AsignaturaRepository.BuscarAsignatura(codigo) != null)
        //        {
        //            AsignaturaRepository.EliminarAsignatura(codigo);
        //            return $"La asignatura con el codigo {codigo} ha sido eliminada satisfacatoriamente";
        //        }
        //        return $"El codigo {codigo} no se encuentra registrada, por favor verifique los datos";
        //    }
        //    catch (Exception e)
        //    {

        //        return "Error de datos" + e.Message;
        //    }
        //}

        //public string ModificarAsignatura(Asignaturas codigo)
        //{
        //    try
        //    {
        //        if (AsignaturaRepository.BuscarAsignatura(codigo.Codigo) != null)
        //        {

        //            AsignaturaRepository.ModificarAsignatura(codigo);
        //            return $"La asignatura con el codigo {codigo.Codigo} ha sido modificada satisfacatoriamente";
        //        }
        //        return $"El codigo {codigo.Codigo} no se encuentra registrado, por favor verifique los datos";
        //    }
        //    catch (Exception e)
        //    {
        //        return "Error de datos" + e.Message;
        //    }
        //}
        //public RespuestaBusqueda BuscarAsignatura(string Codigo)
        //{
        //    RespuestaBusqueda respuesta = new RespuestaBusqueda();
        //    try
        //    {
        //        respuesta.Error = false;
        //        Asignaturas asignatura = AsignaturaRepository.BuscarAsignatura(Codigo);
        //        if (asignatura == null)
        //        {
        //            respuesta.Mensaje = $"La asignatura con el codigo {Codigo} no se encuentra registrado";
        //            respuesta.Asignatura = null;
        //        }
        //        else
        //        {
        //            respuesta.Asignatura = asignatura;
        //            respuesta.Mensaje = "Asignatura encontrada\n\n";
        //        }
        //    }
        //    catch (Exception E)
        //    {
        //        respuesta.Mensaje = "Error de lectura o escritura de archivos: " + E.Message;
        //        respuesta.Asignatura = null;
        //        respuesta.Error = true;
        //    }
        //    return respuesta;
        //}

        //public RespuestaConsulta ConsultarTodosAsignaturas()
        //{
        //    RespuestaConsulta respuesta = new RespuestaConsulta();
        //    try
        //    {
        //        respuesta.Error = false;
        //        IList<Asignaturas> Asignaturass = AsignaturaRepository.ConsultarTodosAsignaturas();
        //        if (Asignaturass.Count != 0)
        //        {
        //            respuesta.Mensaje = "Se Consulta la Informacion de Asignaturas";
        //            respuesta.Asignaturas = Asignaturass;
        //        }
        //        else
        //        {
        //            respuesta.Mensaje = "No existen Datos para Consultar";
        //            respuesta.Asignaturas = null;
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        respuesta.Error = true;
        //        respuesta.Mensaje = $"Erro en datos: " + e.Message;
        //        respuesta.Asignaturas = null;
        //    }
        //    return respuesta;
        //}

        //public ConsultaCandidatoResponse ConsultarTodosAsignaturasDtg()
        //{
        //    try
        //    {
        //        List<Asignaturas> asignatura = AsignaturaRepository.ConsultarTodosAsignaturasDtg();
        //        if (asignatura != null)
        //        {
        //            return new ConsultaCandidatoResponse(asignatura);
        //        }
        //        else
        //        {
        //            return new ConsultaCandidatoResponse("La asignatura buscado no se encuentra Registrado");
        //        }
        //    }
        //    catch (Exception e)
        //    {

        //        return new ConsultaCandidatoResponse("Error de Aplicacion: " + e.Message);
        //    }
        //}

        //public class ConsultaCandidatoResponse
        //{
        //    public List<Asignaturas> Asignatura { get; set; }
        //    public string Message { get; set; }

        //    public ConsultaCandidatoResponse(List<Asignaturas> asignatura)
        //    {
        //        Asignatura = new List<Asignaturas>();
        //        Asignatura = asignatura;
        //    }
        //    public ConsultaCandidatoResponse(string message)
        //    {
        //        Message = message;
        //    }
        //}

        //////////////////////////////////------------------------///////////////////////////////////////
        /////////////////////////////////---------Docente--------///////////////////////////////////////
        ////////////////////////////////------------------------///////////////////////////////////////


        public string GuardarDocente(Docentes docente)
        {
            try
            {
                if (DocenteRepository.BuscarDocente(docente.Identificacion) == null)
                {
                    DocenteRepository.GuardarDocente(docente);
                    return "Los Datos han sido guardados satisfactoriamente";
                }
                return $"La identificacion {docente.Identificacion} ya se encuentra registrado por favor verifique los datos";
            }
            catch (Exception e)
            {
                return "Error de Datos: " + e.Message;
            }
        }

        public string EliminarDocente(string identificacion)
        {
            try
            {
                if (DocenteRepository.BuscarDocente(identificacion) != null)
                {
                    DocenteRepository.EliminarDocente(identificacion);
                    return $"El docente con la identificacion {identificacion} ha sido eliminada satisfacatoriamente";
                }
                return $"La identificacion {identificacion} no se encuentra registrada, por favor verifique los datos";
            }
            catch (Exception e)
            {

                return "Error de datos" + e.Message;
            }
        }

        public string ModificarDocente(Docentes codigo)
        {
            try
            {
                if (DocenteRepository.BuscarDocente(codigo.Identificacion) != null)
                {

                    DocenteRepository.ModificarDocente(codigo);
                    return $"El docente con la identificacion {codigo.Identificacion} ha sido modificada satisfacatoriamente";
                }
                return $"La identificacion {codigo.Identificacion} no se encuentra registrado, por favor verifique los datos";
            }
            catch (Exception e)
            {
                return "Error de datos" + e.Message;
            }
        }
        public RespuestaBusqueda BuscarDocente(string Codigo)
        {
            RespuestaBusqueda respuesta = new RespuestaBusqueda();
            try
            {
                respuesta.Error = false;
                Docentes docente = DocenteRepository.BuscarDocente(Codigo);
                if (docente == null)
                {
                    respuesta.Mensaje = $"El docente con la identificacion {Codigo} no se encuentra registrado";
                    respuesta.Docente = null;
                }
                else
                {
                    respuesta.Docente = docente;
                    respuesta.Mensaje = "Docente encontrado\n\n";
                }
            }
            catch (Exception E)
            {
                respuesta.Mensaje = "Error de lectura o escritura de archivos: " + E.Message;
                respuesta.Docente = null;
                respuesta.Error = true;
            }
            return respuesta;
        }

        public RespuestaConsulta ConsultarTodosDocentes()
        {
            RespuestaConsulta respuesta = new RespuestaConsulta();
            try
            {
                respuesta.Error = false;
                IList<Docentes> Docentess = DocenteRepository.ConsultarTodosDocentes();
                if (Docentess.Count != 0)
                {
                    respuesta.Mensaje = "Se Consulta la Informacion de Docentes";
                    respuesta.Docentes = Docentess;
                }
                else
                {
                    respuesta.Mensaje = "No existen Datos para Consultar";
                    respuesta.Docentes = null;
                }
            }
            catch (Exception e)
            {
                respuesta.Error = true;
                respuesta.Mensaje = $"Erro en datos: " + e.Message;
                respuesta.Docentes = null;
            }
            return respuesta;
        }

        public ConsultaDocenteResponse ConsultarTodosDocentesDtg()
        {
            try
            {
                List<Docentes> docente = DocenteRepository.ConsultarTodosDocentesDtg();
                if (docente != null)
                {
                    return new ConsultaDocenteResponse(docente);
                }
                else
                {
                    return new ConsultaDocenteResponse("La asignatura buscado no se encuentra Registrado");
                }
            }
            catch (Exception e)
            {

                return new ConsultaDocenteResponse("Error de Aplicacion: " + e.Message);
            }
        }

        public class ConsultaDocenteResponse
        {
            public List<Docentes> Docente { get; set; }
            public string Message { get; set; }

            public ConsultaDocenteResponse(List<Docentes> docente)
            {
                Docente = new List<Docentes>();
                Docente = docente;
            }
            public ConsultaDocenteResponse(string message)
            {
                Message = message;
            }
        }
        //////////////////////////////////------------------------///////////////////////////////////////
        /////////////////////////////////---Plan de asignatura --///////////////////////////////////////
        ////////////////////////////////------------------------///////////////////////////////////////
    }
}
