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
                return $"El Codigo {asignatura.Codigo} ya se encuentra registrado por favor verifique los datos";
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
                    return $"La asignatura con el codigo {codigo} ha sido eliminada satisfacatoriamente";
                }
                return $"El codigo {codigo} no se encuentra registrada, por favor verifique los datos";
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
                Asignaturas asignatura = AsignaturaRepository.BuscarAsignatura(Codigo);
                if (asignatura == null)
                {
                    respuesta.Mensaje = $"La asignatura con el codigo {Codigo} no se encuentra registrado";
                    respuesta.Asignatura = null;
                }
                else
                {
                    respuesta.Asignatura = asignatura;
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
                IList<Asignaturas> Asignaturass = AsignaturaRepository.ConsultarTodosAsignaturas();
                if (Asignaturass.Count != 0)
                {
                    respuesta.Mensaje = "Se Consulta la Informacion de Asignaturas";
                    respuesta.Asignaturas = Asignaturass;
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
                    return new ConsultaCandidatoResponse("La asignatura buscado no se encuentra Registrado");
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
        //////////////////////////////////------------------------///////////////////////////////////////
        /////////////////////////////////---------Docente--------///////////////////////////////////////
        ////////////////////////////////------------------------///////////////////////////////////////


    }
}
