using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class PlanAsignaturas
    {
        public string Materia { get; set; }
        public string Descripcion { get; set; }
        public string Justificacion { get; set; }
        public string ObjetivoGeneral { get; set; }
        public string ObjetivoEspecifico { get; set; }
        public string ComponeteGenerico { get; set; }
        public string Estrategias { get; set; }
        public string Contenidos { get; set; }
        public string MecanismosEvaluacion { get; set; }
        public string ReferenciasBibliograficas { get; set; }

        public PlanAsignaturas()
        {
        }
        public PlanAsignaturas(string materia, string descripcion, string justificacion, string objetivoGeneral, string objetivoEspecifico, 
            string estrategias, string contenidos, string mecanismosEvaluacion, string referenciasBibliograficas)
        {
            Materia = materia;
            Descripcion = descripcion;
            Justificacion = justificacion;
            ObjetivoGeneral = objetivoGeneral;
            ObjetivoEspecifico = objetivoEspecifico;
            Estrategias = estrategias;
            Contenidos = contenidos;
            MecanismosEvaluacion = mecanismosEvaluacion;
            ReferenciasBibliograficas = referenciasBibliograficas;
        }
        public override string ToString()
        {
            return $"Asignatura:{Materia} Descripcion: {Descripcion} Justificacion: {Justificacion}" +
                $" Objetivo General: {ObjetivoGeneral} Objetivo Especifico: {ObjetivoEspecifico} " +
                $"Estrategias: {Estrategias} Contenidos: {Contenidos} Mecanismos Evaluacion: {MecanismosEvaluacion}" +
                $"ReferenciasBibliograficas: {ReferenciasBibliograficas} ";
        }
    }
}
