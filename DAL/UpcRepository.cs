using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITY;
using System.IO;

namespace DAL
{
    public class UpcRepository
    {
        private readonly string FileAsignatura = "Asignaturas.txt";
        private readonly string FileDocente = "Docentes.txt";
        private readonly string FilePlanAsignatura = "PlanAsignaturas.txt";

        public IList<Asignaturas> asignaturas;
        public IList<Docentes> docentes;
        public IList<PlanAsignaturas> planAsignaturas;
        public UpcRepository()
        {
            asignaturas = new List<Asignaturas>();
            docentes = new List<Docentes>();
            planAsignaturas = new List<PlanAsignaturas>();
        }
        //////////////////////////////////------------------------///////////////////////////////////////
        /////////////////////////////////------Asignaturas-------///////////////////////////////////////
        ////////////////////////////////------------------------///////////////////////////////////////
        public void GuardarAsignatura(Asignaturas asignatura)
        {
            FileStream file = new FileStream(FileAsignatura, FileMode.Append);
            StreamWriter writer = new StreamWriter(file);
            writer.WriteLine($"{asignatura.Codigo};{asignatura.Nombre};{asignatura.Programa};{asignatura.TipoAsignatura};{asignatura.Creditos}");
            writer.Close();
            file.Close();
        }

        public IList<Asignaturas> ConsultarTodosAsignaturas()
        {
            FileStream fileStream = new FileStream(FileAsignatura, FileMode.OpenOrCreate);
            StreamReader lector = new StreamReader(fileStream);
            string linea = string.Empty;
            while ((linea = lector.ReadLine()) != null)
            {
                Asignaturas curso = MapearAsignatura(linea);
                asignaturas.Add(curso);
            }
            lector.Close();
            fileStream.Close();
            return asignaturas;
        }
        public List<Asignaturas> ConsultarTodosAsignaturasDtg()
        {
            List<Asignaturas> asignaturas = new List<Asignaturas>();
            FileStream fileStream = new FileStream(FileAsignatura, FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader lector = new StreamReader(fileStream);
            string linea = string.Empty;
            while ((linea = lector.ReadLine()) != null)
            {
                Asignaturas asignatura = MapearAsignatura(linea);
                asignaturas.Add(asignatura);
            }
            lector.Close();
            fileStream.Close();
            return asignaturas;
        }

        public Asignaturas MapearAsignatura(string linea)
        {
            Asignaturas asignatura = new Asignaturas();
            string[] datos = linea.Split(';');
            asignatura.Codigo = datos[0];
            asignatura.Nombre = datos[1];
            asignatura.Programa = datos[2];
            asignatura.TipoAsignatura = datos[3];
            asignatura.Creditos = int.Parse(datos[4]);           
            return asignatura;
        }


        public void EliminarAsignatura(string codigo)
        {
            asignaturas.Clear();
            asignaturas = ConsultarTodosAsignaturas();
            FileStream fileStream = new FileStream(FileAsignatura, FileMode.Create);
            fileStream.Close();
            foreach (var item in asignaturas)
            {
                if (item.Codigo != codigo)
                {
                    GuardarAsignatura(item);
                }
            }
        }

        public void ModificarAsignatura(Asignaturas asignatura)
        {
            asignaturas.Clear();
            asignaturas = ConsultarTodosAsignaturas();
            FileStream fileStream = new FileStream(FileAsignatura, FileMode.Create);
            fileStream.Close();
            foreach (var item in asignaturas)
            {
                if (item.Codigo != asignatura.Codigo)
                {
                    GuardarAsignatura(item);
                }
                else
                {
                    GuardarAsignatura(asignatura);
                }
            }
        }

        public Asignaturas BuscarAsignatura(string codigo)
        {
            asignaturas.Clear();
            asignaturas = ConsultarTodosAsignaturas();
            Asignaturas asignatura = new Asignaturas();
            foreach (var item in asignaturas)
            {
                if (item.Codigo.Equals(codigo))
                {
                    return item;
                }
            }
            return null;
        }
        
        //////////////////////////////////------------------------///////////////////////////////////////
        /////////////////////////////////---------Docente--------///////////////////////////////////////
        ////////////////////////////////------------------------///////////////////////////////////////

        public void GuardarDocente(Docentes docente)
        {
            FileStream file = new FileStream(FileDocente, FileMode.Append);
            StreamWriter writer = new StreamWriter(file);
            writer.WriteLine($"{docente.Identificacion};{docente.Nombre};{docente.Apellido};{docente.Telefono};{docente.Correo};{docente.Categoria};{docente.Materia}");
            writer.Close();
            file.Close();
        }

        public IList<Docentes> ConsultarTodosDocentes()
        {
            FileStream fileStream = new FileStream(FileDocente, FileMode.OpenOrCreate);
            StreamReader lector = new StreamReader(fileStream);
            string linea = string.Empty;
            while ((linea = lector.ReadLine()) != null)
            {
                Docentes docente = MapearDocente(linea);
                docentes.Add(docente);
            }
            lector.Close();
            fileStream.Close();
            return docentes;
        }
        public List<Docentes> ConsultarTodosDocentesDtg()
        {
            List<Docentes> docentes = new List<Docentes>();
            FileStream fileStream = new FileStream(FileDocente, FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader lector = new StreamReader(fileStream);
            string linea = string.Empty;
            while ((linea = lector.ReadLine()) != null)
            {
                Docentes docente = MapearDocente(linea);
                docentes.Add(docente);
            }
            lector.Close();
            fileStream.Close();
            return docentes;
        }

        public Docentes MapearDocente(string linea)
        {
            Docentes docente = new Docentes();
            string[] datos = linea.Split(';');
            docente.Identificacion = datos[0];
            docente.Nombre = datos[1];
            docente.Apellido = datos[2];
            docente.Telefono = datos[3];
            docente.Correo = datos[4];
            docente.Categoria = datos[5];
            docente.Materia = datos[6];
            return docente;
        }


        public void EliminarDocente(string identificacion)
        {
            docentes.Clear();
            docentes = ConsultarTodosDocentes();
            FileStream fileStream = new FileStream(FileDocente, FileMode.Create);
            fileStream.Close();
            foreach (var item in docentes)
            {
                if (item.Identificacion != identificacion)
                {
                    GuardarDocente(item);
                }
            }
        }

        public void ModificarDocente(Docentes docente)
        {
            docentes.Clear();
            docentes = ConsultarTodosDocentes();
            FileStream fileStream = new FileStream(FileDocente, FileMode.Create);
            fileStream.Close();
            foreach (var item in docentes)
            {
                if (item.Identificacion != docente.Identificacion)
                {
                    GuardarDocente(item);
                }
                else
                {
                    GuardarDocente(docente);
                }
            }
        }

        public Docentes BuscarDocente(string identificacion)
        {
            docentes.Clear();
            docentes = ConsultarTodosDocentes();
            Docentes persona = new Docentes();
            foreach (var item in docentes)
            {
                if (item.Identificacion.Equals(identificacion))
                {
                    return item;
                }
            }
            return null;
        }
        //////////////////////////////////------------------------///////////////////////////////////////
        /////////////////////////////////-----Plan Asignatura----///////////////////////////////////////
        ////////////////////////////////------------------------///////////////////////////////////////

        public void GuardarPlanAsignatura(PlanAsignaturas planAsignatura)
        {
            FileStream file = new FileStream(FilePlanAsignatura, FileMode.Append);
            StreamWriter writer = new StreamWriter(file);
            writer.WriteLine($"{planAsignatura.Materia};{planAsignatura.Descripcion};{planAsignatura.Justificacion};{planAsignatura.ObjetivoGeneral};" +
                $"{planAsignatura.ObjetivoEspecifico};{planAsignatura.ComponeteGenerico};{planAsignatura.Estrategias};{planAsignatura.Contenidos}; " +
                $"{planAsignatura.MecanismosEvaluacion};{planAsignatura.ReferenciasBibliograficas} ");
            writer.Close();
            file.Close();
        }

        public IList<PlanAsignaturas> ConsultarTodosPlanAsignaturas()
        {
            FileStream fileStream = new FileStream(FilePlanAsignatura, FileMode.OpenOrCreate);
            StreamReader lector = new StreamReader(fileStream);
            string linea = string.Empty;
            while ((linea = lector.ReadLine()) != null)
            {
                PlanAsignaturas planAsignatura = MapearPlanAsignatura(linea);
                planAsignaturas.Add(planAsignatura);
            }
            lector.Close();
            fileStream.Close();
            return planAsignaturas;
        }
        public PlanAsignaturas MapearPlanAsignatura(string linea)
        {
            PlanAsignaturas planAsignatura = new PlanAsignaturas();
            string[] datos = linea.Split(';');
            planAsignatura.Materia = datos[0];
            planAsignatura.Descripcion = datos[1];
            planAsignatura.Justificacion = datos[2];
            planAsignatura.ObjetivoGeneral = datos[3];
            planAsignatura.ObjetivoEspecifico = datos[4];
            planAsignatura.ComponeteGenerico = datos[5];
            planAsignatura.Estrategias = datos[6];
            planAsignatura.Contenidos = datos[7];
            planAsignatura.MecanismosEvaluacion = datos[8];
            planAsignatura.ReferenciasBibliograficas = datos[10];
            return planAsignatura;
        }

        public PlanAsignaturas BuscarPlanAsignatura(string materia)
        {
            planAsignaturas.Clear();
            planAsignaturas = ConsultarTodosPlanAsignaturas();
            PlanAsignaturas planAsignatura = new PlanAsignaturas();
            foreach (var item in planAsignaturas)
            {
                if (item.Materia.Equals(materia))
                {
                    return item;
                }
            }
            return null;
        }
    }
}
