using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITY;
using DAL;

namespace BLL
{
    public class RespuestaConsulta
    {
        public string Mensaje { get; set; }
        public IList<Asignaturas> Asignaturas { get; set; }
        public IList<Docentes> Docentes { get; set; }
        public IList<PlanAsignaturas> PlanAsignaturas { get; set; }
        public bool Error { get; set; }
    }

    public class RespuestaBusqueda
    {
        public string Mensaje { get; set; }
        public Asignaturas Asignatura { get; set; }
        public Docentes Docente { get; set; }
        public PlanAsignaturas PlanAsignatura { get; set; }
        public bool Error { get; set; }
    }
    /// <summary>
    /// ///////////////////////////////////////------Candidato es igual a Asignatura--------///////////////////////
    /// </summary>

    public class CandidatoResponse
    {
        public Asignaturas Asignatura { get; set; }
        public string Message { get; set; }
        public bool Encontrado { get; set; }

        public CandidatoResponse(Asignaturas asignatura)
        {
            Asignatura = new Asignaturas();
            Asignatura = asignatura;
            Encontrado = true;
        }
        public CandidatoResponse(string message)
        {
            Message = message;
            Encontrado = false;
        }
    }
    public class ConsultaCandidatoResponse
    {
        public List<Asignaturas> Asignatura { get; set; }
        public string Message { get; set; }
        public bool Encontrado { get; set; }

        public ConsultaCandidatoResponse(List<Asignaturas> asignatura)
        {
            Asignatura = new List<Asignaturas>();
            Asignatura = asignatura;
            Encontrado = true;
        }
        public ConsultaCandidatoResponse(string message)
        {
            Message = message;
            Encontrado = false;
        }
    }
}
