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
        public CandidatoResponse BuscarPorCodigo(string codigo)
        {
            try
            {
                Asignaturas asignatura = AsignaturaRepository.BuscarPorCodigo(codigo);
                if (asignatura != null)
                {
                    return new CandidatoResponse(asignatura);
                }
                else
                {
                    return new CandidatoResponse($"La asignatura con el codigo {codigo} no se encuentra registrada");
                }
            }
            catch (Exception e)
            {
                return new CandidatoResponse("Error de Aplicacion: " + e.Message);
            }
        }
        public ConsultaCandidatoResponse ConsultarFiltrarTeoricoPractico(string tipoAsignatura)
        {
            try
            {
                List<Asignaturas> asignaturas = AsignaturaRepository.FiltrarTeoricoPractico(tipoAsignatura);
                if (asignaturas != null)
                {
                    return new ConsultaCandidatoResponse(asignaturas);
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
        public ConsultaCandidatoResponse ConsultarFiltrarPractico(string tipoAsignatura)
        {
            try
            {
                List<Asignaturas> asignaturas = AsignaturaRepository.FiltrarPractico(tipoAsignatura);
                if (asignaturas != null)
                {
                    return new ConsultaCandidatoResponse(asignaturas);
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

        public ConsultaCandidatoResponse ConsultarFiltrarTeorico(string tipoAsignatura)
        {
            try
            {
                List<Asignaturas> asignaturas = AsignaturaRepository.FiltrarTeorico(tipoAsignatura);
                if (asignaturas != null)
                {
                    return new ConsultaCandidatoResponse(asignaturas);
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

        public ConsultaCandidatoResponse BuscarDtg(string codigo)
        {
            try
            {
                List<Asignaturas> asignaturas = AsignaturaRepository.BuscarDtg(codigo);
                if (asignaturas != null)
                {
                    return new ConsultaCandidatoResponse(asignaturas);
                }
                else
                {
                    return new ConsultaCandidatoResponse($"La asignatura con el codigo {codigo} no se encuentra registrada");
                }
            }
            catch (Exception e)
            {
                return new ConsultaCandidatoResponse("Error de Aplicacion: " + e.Message);
            }
        }

        public int TotalizarTodasAsignaturas()
        {
            return AsignaturaRepository.TotalizarTodasAsignaturas();
        }
        public int ContarTeoricoPractico()
        {
            return AsignaturaRepository.ContarTeoricoPractico();
        }
        public int ContarPractico()
        {
            return AsignaturaRepository.ContarPractico();
        }
        public int ContarTeorico()
        {
            return AsignaturaRepository.ContarTeorico();
        }

        public ConsultaCandidatoResponse FiltrarProgramaADMINISTRACION_EMPRESAS(string programa)
        {
            try
            {
                List<Asignaturas> asignaturas = AsignaturaRepository.FiltrarProgramaADMINISTRACION_EMPRESAS(programa);
                if (asignaturas != null)
                {
                    return new ConsultaCandidatoResponse(asignaturas);
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
        
        public ConsultaCandidatoResponse FiltrarProgramaADMINISTRACION_TURISTICAS(string programa)
        {
            try
            {
                List<Asignaturas> asignaturas = AsignaturaRepository.FiltrarProgramaADMINISTRACION_TURISTICAS(programa);
                if (asignaturas != null)
                {
                    return new ConsultaCandidatoResponse(asignaturas);
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
        public ConsultaCandidatoResponse FiltrarProgramaCOMERCIO_INTERNACIONAL(string programa)
        {
            try
            {
                List<Asignaturas> asignaturas = AsignaturaRepository.FiltrarProgramaCOMERCIO_INTERNACIONAL(programa);
                if (asignaturas != null)
                {
                    return new ConsultaCandidatoResponse(asignaturas);
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
        public ConsultaCandidatoResponse FiltrarProgramaCONTADURIA_PUBLICA(string programa)
        {
            try
            {
                List<Asignaturas> asignaturas = AsignaturaRepository.FiltrarProgramaCONTADURIA_PUBLICA(programa);
                if (asignaturas != null)
                {
                    return new ConsultaCandidatoResponse(asignaturas);
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
        public ConsultaCandidatoResponse FiltrarProgramaDERECHO(string programa)
        {
            try
            {
                List<Asignaturas> asignaturas = AsignaturaRepository.FiltrarProgramaDERECHO(programa);
                if (asignaturas != null)
                {
                    return new ConsultaCandidatoResponse(asignaturas);
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
        public ConsultaCandidatoResponse FiltrarProgramaECONOMIA(string programa)
        {
            try
            {
                List<Asignaturas> asignaturas = AsignaturaRepository.FiltrarProgramaECONOMIA(programa);
                if (asignaturas != null)
                {
                    return new ConsultaCandidatoResponse(asignaturas);
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
        public ConsultaCandidatoResponse FiltrarProgramaENFERMERIA(string programa)
        {
            try
            {
                List<Asignaturas> asignaturas = AsignaturaRepository.FiltrarProgramaENFERMERIA(programa);
                if (asignaturas != null)
                {
                    return new ConsultaCandidatoResponse(asignaturas);
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
        public ConsultaCandidatoResponse FiltrarProgramaINGENIERIA_AGROINDUSTRIAL(string programa)
        {
            try
            {
                List<Asignaturas> asignaturas = AsignaturaRepository.FiltrarProgramaINGENIERIA_AGROINDUSTRIAL(programa);
                if (asignaturas != null)
                {
                    return new ConsultaCandidatoResponse(asignaturas);
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
        public ConsultaCandidatoResponse FiltrarProgramaINGENIERIA_AMBIENTAL(string programa)
        {
            try
            {
                List<Asignaturas> asignaturas = AsignaturaRepository.FiltrarProgramaINGENIERIA_AMBIENTAL(programa);
                if (asignaturas != null)
                {
                    return new ConsultaCandidatoResponse(asignaturas);
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
        public ConsultaCandidatoResponse FiltrarProgramaINGENIERIA_ELECTRONICA(string programa)
        {
            try
            {
                List<Asignaturas> asignaturas = AsignaturaRepository.FiltrarProgramaINGENIERIA_ELECTRONICA(programa);
                if (asignaturas != null)
                {
                    return new ConsultaCandidatoResponse(asignaturas);
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
        public ConsultaCandidatoResponse FiltrarProgramaINGENIERIA_SISTEMAS(string programa)
        {
            try
            {
                List<Asignaturas> asignaturas = AsignaturaRepository.FiltrarProgramaINGENIERIA_SISTEMAS(programa);
                if (asignaturas != null)
                {
                    return new ConsultaCandidatoResponse(asignaturas);
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
        public ConsultaCandidatoResponse FiltrarProgramaINSTRUMENTACION_QUIRURGICA(string programa)
        {
            try
            {
                List<Asignaturas> asignaturas = AsignaturaRepository.FiltrarProgramaINSTRUMENTACION_QUIRURGICA(programa);
                if (asignaturas != null)
                {
                    return new ConsultaCandidatoResponse(asignaturas);
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
        public ConsultaCandidatoResponse FiltrarProgramaLICENCIATURA_ARTE(string programa)
        {
            try
            {
                List<Asignaturas> asignaturas = AsignaturaRepository.FiltrarProgramaLICENCIATURA_ARTE(programa);
                if (asignaturas != null)
                {
                    return new ConsultaCandidatoResponse(asignaturas);
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
        public ConsultaCandidatoResponse FiltrarProgramaLICENCIATURA_DEPORTES(string programa)
        {
            try
            {
                List<Asignaturas> asignaturas = AsignaturaRepository.FiltrarProgramaLICENCIATURA_DEPORTES(programa);
                if (asignaturas != null)
                {
                    return new ConsultaCandidatoResponse(asignaturas);
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
        public ConsultaCandidatoResponse FiltrarProgramaLICENCIATURA_ESPANOL_INGLES(string programa)
        {
            try
            {
                List<Asignaturas> asignaturas = AsignaturaRepository.FiltrarProgramaLICENCIATURA_ESPANOL_INGLES(programa);
                if (asignaturas != null)
                {
                    return new ConsultaCandidatoResponse(asignaturas);
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
        public ConsultaCandidatoResponse FiltrarProgramaLICENCIATURA_LITERATURA(string programa)
        {
            try
            {
                List<Asignaturas> asignaturas = AsignaturaRepository.FiltrarProgramaLICENCIATURA_LITERATURA(programa);
                if (asignaturas != null)
                {
                    return new ConsultaCandidatoResponse(asignaturas);
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
        public ConsultaCandidatoResponse FiltrarProgramaLICENCIATURA_MATEMATICAS(string programa)
        {
            try
            {
                List<Asignaturas> asignaturas = AsignaturaRepository.FiltrarProgramaLICENCIATURA_MATEMATICAS(programa);
                if (asignaturas != null)
                {
                    return new ConsultaCandidatoResponse(asignaturas);
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
        public ConsultaCandidatoResponse FiltrarProgramaLICENCIATURA_NATURALES(string programa)
        {
            try
            {
                List<Asignaturas> asignaturas = AsignaturaRepository.FiltrarProgramaLICENCIATURA_NATURALES(programa);
                if (asignaturas != null)
                {
                    return new ConsultaCandidatoResponse(asignaturas);
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
        public ConsultaCandidatoResponse FiltrarProgramaMICROBIOLOGIA(string programa)
        {
            try
            {
                List<Asignaturas> asignaturas = AsignaturaRepository.FiltrarProgramaMICROBIOLOGIA(programa);
                if (asignaturas != null)
                {
                    return new ConsultaCandidatoResponse(asignaturas);
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
        public ConsultaCandidatoResponse FiltrarProgramaMUSICA(string programa)
        {
            try
            {
                List<Asignaturas> asignaturas = AsignaturaRepository.FiltrarProgramaMUSICA(programa);
                if (asignaturas != null)
                {
                    return new ConsultaCandidatoResponse(asignaturas);
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
        public ConsultaCandidatoResponse FiltrarProgramaPSICOLOGIA(string programa)
        {
            try
            {
                List<Asignaturas> asignaturas = AsignaturaRepository.FiltrarProgramaPSICOLOGIA(programa);
                if (asignaturas != null)
                {
                    return new ConsultaCandidatoResponse(asignaturas);
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
    }
    //////////////////////////////////------------------------///////////////////////////////////////
    /////////////////////////////////---Plan de asignatura --///////////////////////////////////////
    ////////////////////////////////------------------------///////////////////////////////////////

}
