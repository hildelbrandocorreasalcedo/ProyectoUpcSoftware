using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class SolicitudDocentes
    {
        public string Identificacion { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }     
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
        public string Estado { get; set; }
        public SolicitudDocentes()
        {

        }
        public SolicitudDocentes(string identificacion, string nombre, string apellido, string materia, string descripcion, string justificacion, string objetivoGeneral, string objetivoEspecifico,
            string estrategias, string contenidos, string mecanismosEvaluacion, string referenciasBibliograficas, string estado)
        {
            Identificacion = identificacion;
            Nombre = nombre;
            Apellido = apellido;
            Materia = materia;
            Descripcion = descripcion;
            Justificacion = justificacion;
            ObjetivoGeneral = objetivoGeneral;
            ObjetivoEspecifico = objetivoEspecifico;
            Estrategias = estrategias;
            Contenidos = contenidos;
            MecanismosEvaluacion = mecanismosEvaluacion;
            ReferenciasBibliograficas = referenciasBibliograficas;
            Estado = estado;
        }
    }
}
