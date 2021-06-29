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
        public IList<SolicitudDocentes> SolicitudDocentes { get; set; }
        public bool Error { get; set; }
    }

    public class RespuestaBusqueda
    {
        public string Mensaje { get; set; }
        public Asignaturas Asignatura { get; set; }
        public Docentes Docente { get; set; }
        public PlanAsignaturas PlanAsignatura { get; set; }
        public SolicitudDocentes SolicitudDocente { get; set; }
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

    /// <summary>
    /// ////////////////////////////////////////////////------Docente Consultas--------////////////////////////////////
    /// </summary>
    public class DocenteResponse
    {
        public Docentes Docente { get; set; }
        public string Message { get; set; }
        public bool Encontrado { get; set; }

        public DocenteResponse(Docentes docente)
        {
            Docente = new Docentes();
            Docente = docente;
            Encontrado = true;
        }
        public DocenteResponse(string message)
        {
            Message = message;
            Encontrado = false;
        }
    }
    public class ConsultaDocenteResponse
    {
        public List<Docentes> Docente { get; set; }
        public string Message { get; set; }
        public bool Encontrado { get; set; }

        public ConsultaDocenteResponse(List<Docentes> docente)
        {
            Docente = new List<Docentes>();
            Docente = docente;
            Encontrado = true;
        }
        public ConsultaDocenteResponse(string message)
        {
            Message = message;
            Encontrado = false;
        }
    }

    /// <summary>
    /// ////////////////////////////////////////////////------Plan de asignaturas en Consultas--------////////////////////////////////
    /// </summary>
    public class PlanAsignaturaResponse
    {
        public PlanAsignaturas PlanAsignatura { get; set; }
        public string Message { get; set; }
        public bool Encontrado { get; set; }

        public PlanAsignaturaResponse(PlanAsignaturas planAsignatura)
        {
            PlanAsignatura = new PlanAsignaturas();
            PlanAsignatura = planAsignatura;
            Encontrado = true;
        }
        public PlanAsignaturaResponse(string message)
        {
            Message = message;
            Encontrado = false;
        }
    }
    public class ConsultaPlanAsignaturaResponse
    {
        public List<PlanAsignaturas> PlanAsignatura { get; set; }
        public string Message { get; set; }
        public bool Encontrado { get; set; }

        public ConsultaPlanAsignaturaResponse(List<PlanAsignaturas> planAsignatura)
        {
            PlanAsignatura = new List<PlanAsignaturas>();
            PlanAsignatura = planAsignatura;
            Encontrado = true;
        }
        public ConsultaPlanAsignaturaResponse(string message)
        {
            Message = message;
            Encontrado = false;
        }
    }

    /// <summary>
    /// ////////////////////////////////////////////////------SOLICITUD DocenteS Consultas--------////////////////////////////////
    /// </summary>
    public class SolicitudDocenteResponse
    {
        public SolicitudDocentes SolicitudDocente { get; set; }
        public string Message { get; set; }
        public bool Encontrado { get; set; }

        public SolicitudDocenteResponse(SolicitudDocentes solicitudDocente)
        {
            SolicitudDocente = new SolicitudDocentes();
            SolicitudDocente = solicitudDocente;
            Encontrado = true;
        }
        public SolicitudDocenteResponse(string message)
        {
            Message = message;
            Encontrado = false;
        }
    }
    public class ConsultaSolicitudDocenteResponse
    {
        public List<SolicitudDocentes> SolicitudDocente { get; set; }
        public string Message { get; set; }
        public bool Encontrado { get; set; }

        public ConsultaSolicitudDocenteResponse(List<SolicitudDocentes> solicitudDocente)
        {
            SolicitudDocente = new List<SolicitudDocentes>();
            SolicitudDocente = solicitudDocente;
            Encontrado = true;
        }
        public ConsultaSolicitudDocenteResponse(string message)
        {
            Message = message;
            Encontrado = false;
        }
    }
}
