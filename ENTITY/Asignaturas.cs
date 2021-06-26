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
        public string TipoAsignatura { get; set; }
        public int Creditos { get; set; }
        
        public Asignaturas()
        {

        }
        public Asignaturas(string codigo, string nombre, string programa, string tipoAsignatura, int creditos)
        {
            Codigo = codigo;
            Nombre = nombre;
            Programa = programa;
            TipoAsignatura = tipoAsignatura;
            Creditos = creditos;          
        }
        public override string ToString()
        {
            return $"Codigo asignatura:{Codigo} Nombre de asignatura: {Nombre} Programa: {Programa} Tipo de Asignatura: {TipoAsignatura} Creditos: {Creditos}";
        }
    }
}
