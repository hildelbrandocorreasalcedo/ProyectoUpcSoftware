using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Asignaturas
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Programa { get; set; }
        public string Creditos { get; set; }
        public string TipoAsignatura { get; set; }

        public Asignaturas()
        {

        }
        public Asignaturas(string codigo, string nombre, string programa, string creditos, string tipoAsignatura)
        {
            Codigo = codigo;
            Nombre = nombre;
            Programa = programa;
            Creditos = creditos;
            TipoAsignatura = tipoAsignatura;
        }
        public override string ToString()
        {
            return $"Codigo asignatura:{Codigo} Nombre de asignatura: {Nombre} Programa: {Programa} Creditos: {Creditos} Tipo de Asignatura: {TipoAsignatura}";
        }
    }
}
