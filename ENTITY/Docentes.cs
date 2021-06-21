using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Docentes
    {
        public string Identificacion { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public string Categoria { get; set; }
        public string Materia { get; set; }

        public Docentes()
        {

        }
        public Docentes(string identificacion, string nombre, string apellido, string telefono, string correo, string categoria, string materia)
        {
            Identificacion = identificacion;
            Nombre = nombre;
            Apellido = apellido;
            Telefono = telefono;
            Correo = correo;
            Categoria = categoria;
            Materia = materia;
        }
        public override string ToString()
        {
            return $"Identificacion del docente:{Identificacion} Nombre: {Nombre} Apellido: {Apellido}" +
                $" Telefono: {Telefono} Correo: {Correo} Categoria: {Categoria} asignatura {Materia}";
        }
    }
}
