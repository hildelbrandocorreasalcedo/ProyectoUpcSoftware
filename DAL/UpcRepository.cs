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
        private readonly string FileSolicitudDocente = "SolicitudDocente.txt";

        public IList<Asignaturas> asignaturas;
        public IList<Docentes> docentes;
        public IList<PlanAsignaturas> planAsignaturas;
        public IList<SolicitudDocentes> solicitudDocentes;

        public UpcRepository()
        {
            asignaturas = new List<Asignaturas>();
            docentes = new List<Docentes>();
            planAsignaturas = new List<PlanAsignaturas>();
            solicitudDocentes = new List<SolicitudDocentes>();
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
            FileStream file = new FileStream(FileAsignatura, FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader reader = new StreamReader(file);
            string linea = string.Empty;
            while ((linea = reader.ReadLine()) != null)
            {
                Asignaturas Asignatura = MapearAsignatura(linea);
                asignaturas.Add(Asignatura);
            }
            reader.Close();
            file.Close();
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
        public Asignaturas BuscarPorCodigo(string codigo)
        {
            List<Asignaturas> asignaturas = ConsultarTodosAsignaturasDtg();
            foreach (var item in asignaturas)
            {
                if (EncontradaAsignatura(item.Codigo, codigo))
                {
                    return item;
                }
            }
            return null;
        }

        private bool EncontradaAsignatura(string identificacioRegistrada, string identificacionBuscada)
        {
            return identificacioRegistrada == identificacionBuscada;
        }
        //////////////////////////////////////-------------Filtros busqueda en tabla LINQ----------////////////////////////////////////
        public List<Asignaturas> FiltrarTeoricoPractico(string tipoAsignatura)
        {
            List<Asignaturas> asignaturas = ConsultarTodosAsignaturasDtg();
            List<Asignaturas> asignaturaFiltradas =
                (from asignarura in asignaturas
                 where asignarura.TipoAsignatura.Equals("Teorico/Practico")
                 select asignarura).ToList();
            return asignaturaFiltradas;
        }
        
        public List<Asignaturas> FiltrarTeorico(string tipoAsignatura)
        {

            List<Asignaturas> asignaturas = ConsultarTodosAsignaturasDtg();
            List<Asignaturas> asignaturaFiltradas =
                (from asignarura in asignaturas
                 where asignarura.TipoAsignatura.Equals("Teorico")
                 select asignarura).ToList();
            return asignaturaFiltradas;
        }
        public List<Asignaturas> FiltrarPractico(string tipoAsignatura)
        {

            List<Asignaturas> asignaturas = ConsultarTodosAsignaturasDtg();
            List<Asignaturas> asignaturaFiltradas =
                (from asignarura in asignaturas
                 where asignarura.TipoAsignatura.Equals("Practico")
                 select asignarura).ToList();
            return asignaturaFiltradas;
        }

        public List<Asignaturas> BuscarAsignaturaDtg(string codigo)
        {
            List<Asignaturas> asignaturas = ConsultarTodosAsignaturasDtg();
            List<Asignaturas> asignaturaFiltradasBuscado =
                (from asignarura in asignaturas
                 where asignarura.Codigo.Equals(codigo)
                 select asignarura).ToList();
            return asignaturaFiltradasBuscado;
        }

        public int TotalizarTodasAsignaturas()
        {
            return ConsultarTodosAsignaturasDtg().Count();
        }
        public int ContarTeoricoPractico()
        {
            return ConsultarTodosAsignaturasDtg().Where(p => p.TipoAsignatura == "Teorico/Practico").Count();
        }
        public int ContarTeorico()
        {
            return ConsultarTodosAsignaturasDtg().Where(p => p.TipoAsignatura == "Teorico").Count();
        }
        public int ContarPractico()
        {
            return ConsultarTodosAsignaturasDtg().Where(p => p.TipoAsignatura == "Practico").Count();
        }

        public List<Asignaturas> FiltrarProgramaADMINISTRACION_EMPRESAS(string programa)
        {
            List<Asignaturas> asignaturas = ConsultarTodosAsignaturasDtg();
            List<Asignaturas> asignaruraFiltradas =
                (from asignarura in asignaturas
                 where asignarura.Programa.Equals("ADMINISTRACION DE EMPRESAS")
                 select asignarura).ToList();
            return asignaruraFiltradas;
        }
        public List<Asignaturas> FiltrarProgramaADMINISTRACION_TURISTICAS(string programa)
        {
            List<Asignaturas> asignaturas = ConsultarTodosAsignaturasDtg();
            List<Asignaturas> asignaruraFiltradas =
                (from asignarura in asignaturas
                 where asignarura.Programa.Equals("ADMINISTRACION DE EMPRESAS TURISTICAS Y HOTELERAS")
                 select asignarura).ToList();
            return asignaruraFiltradas;
        }
        public List<Asignaturas> FiltrarProgramaCOMERCIO_INTERNACIONAL(string programa)
        {
            List<Asignaturas> asignaturas = ConsultarTodosAsignaturasDtg();
            List<Asignaturas> asignaruraFiltradas =
                (from asignarura in asignaturas
                 where asignarura.Programa.Equals("COMERCIO INTERNACIONAL")
                 select asignarura).ToList();
            return asignaruraFiltradas;
        }
        public List<Asignaturas> FiltrarProgramaCONTADURIA_PUBLICA(string programa)
        {
            List<Asignaturas> asignaturas = ConsultarTodosAsignaturasDtg();
            List<Asignaturas> asignaruraFiltradas =
                (from asignarura in asignaturas
                 where asignarura.Programa.Equals("CONTADURIA PUBLICA")
                 select asignarura).ToList();
            return asignaruraFiltradas;
        }
        public List<Asignaturas> FiltrarProgramaDERECHO(string programa)
        {
            List<Asignaturas> asignaturas = ConsultarTodosAsignaturasDtg();
            List<Asignaturas> asignaruraFiltradas =
                (from asignarura in asignaturas
                 where asignarura.Programa.Equals("DERECHO")
                 select asignarura).ToList();
            return asignaruraFiltradas;
        }
        public List<Asignaturas> FiltrarProgramaECONOMIA(string programa)
        {
            List<Asignaturas> asignaturas = ConsultarTodosAsignaturasDtg();
            List<Asignaturas> asignaruraFiltradas =
                (from asignarura in asignaturas
                 where asignarura.Programa.Equals("ECONOMIA")
                 select asignarura).ToList();
            return asignaruraFiltradas;
        }
        public List<Asignaturas> FiltrarProgramaENFERMERIA(string programa)
        {
            List<Asignaturas> asignaturas = ConsultarTodosAsignaturasDtg();
            List<Asignaturas> asignaruraFiltradas =
                (from asignarura in asignaturas
                 where asignarura.Programa.Equals("ENFERMERIA")
                 select asignarura).ToList();
            return asignaruraFiltradas;
        }
        public List<Asignaturas> FiltrarProgramaINGENIERIA_AGROINDUSTRIAL(string programa)
        {
            List<Asignaturas> asignaturas = ConsultarTodosAsignaturasDtg();
            List<Asignaturas> asignaruraFiltradas =
                (from asignarura in asignaturas
                 where asignarura.Programa.Equals("INGENIERIA AGROINDUSTRIAL")
                 select asignarura).ToList();
            return asignaruraFiltradas;
        }
        public List<Asignaturas> FiltrarProgramaINGENIERIA_AMBIENTAL(string programa)
        {
            List<Asignaturas> asignaturas = ConsultarTodosAsignaturasDtg();
            List<Asignaturas> asignaruraFiltradas =
                (from asignarura in asignaturas
                 where asignarura.Programa.Equals("INGENIERIA AMBIENTAL Y SANITARIAS")
                 select asignarura).ToList();
            return asignaruraFiltradas;
        }
        public List<Asignaturas> FiltrarProgramaINGENIERIA_SISTEMAS(string programa)
        {
            List<Asignaturas> asignaturas = ConsultarTodosAsignaturasDtg();
            List<Asignaturas> asignaruraFiltradas =
                (from asignarura in asignaturas
                 where asignarura.Programa.Equals("INGENIERIA SISTEMAS")
                 select asignarura).ToList();
            return asignaruraFiltradas;
        }
        public List<Asignaturas> FiltrarProgramaINGENIERIA_ELECTRONICA(string programa)
        {
            List<Asignaturas> asignaturas = ConsultarTodosAsignaturasDtg();
            List<Asignaturas> asignaruraFiltradas =
                (from asignarura in asignaturas
                 where asignarura.Programa.Equals("INGENIERIA ELECTRONICA")
                 select asignarura).ToList();
            return asignaruraFiltradas;
        }
        public List<Asignaturas> FiltrarProgramaINSTRUMENTACION_QUIRURGICA(string programa)
        {
            List<Asignaturas> asignaturas = ConsultarTodosAsignaturasDtg();
            List<Asignaturas> asignaruraFiltradas =
                (from asignarura in asignaturas
                 where asignarura.Programa.Equals("INSTRUMENTACION QUIRURGICA SOCIOLOGIA")
                 select asignarura).ToList();
            return asignaruraFiltradas;
        }
        public List<Asignaturas> FiltrarProgramaLICENCIATURA_ARTE(string programa)
        {
            List<Asignaturas> asignaturas = ConsultarTodosAsignaturasDtg();
            List<Asignaturas> asignaruraFiltradas =
                (from asignarura in asignaturas
                 where asignarura.Programa.Equals("LICENCIATURA EN ARTE")
                 select asignarura).ToList();
            return asignaruraFiltradas;
        }
        public List<Asignaturas> FiltrarProgramaLICENCIATURA_NATURALES(string programa)
        {
            List<Asignaturas> asignaturas = ConsultarTodosAsignaturasDtg();
            List<Asignaturas> asignaruraFiltradas =
                (from asignarura in asignaturas
                 where asignarura.Programa.Equals("LICENCIATURA EN CIENCIAS NATURALES Y EDUCACION AMBIENTAL")
                 select asignarura).ToList();
            return asignaruraFiltradas;
        }
        public List<Asignaturas> FiltrarProgramaLICENCIATURA_DEPORTES(string programa)
        {
            List<Asignaturas> asignaturas = ConsultarTodosAsignaturasDtg();
            List<Asignaturas> asignaruraFiltradas =
                (from asignarura in asignaturas
                 where asignarura.Programa.Equals("LICENCIATURA EN EDUCACION FISICA, RECREACION Y DEPORTES")
                 select asignarura).ToList();
            return asignaruraFiltradas;
        }
        public List<Asignaturas> FiltrarProgramaLICENCIATURA_ESPANOL_INGLES(string programa)
        {
            List<Asignaturas> asignaturas = ConsultarTodosAsignaturasDtg();
            List<Asignaturas> asignaruraFiltradas =
                (from asignarura in asignaturas
                 where asignarura.Programa.Equals("LICENCIATURA EN ESPAÑOL E INGLES")
                 select asignarura).ToList();
            return asignaruraFiltradas;
        }
        public List<Asignaturas> FiltrarProgramaLICENCIATURA_LITERATURA(string programa)
        {
            List<Asignaturas> asignaturas = ConsultarTodosAsignaturasDtg();
            List<Asignaturas> asignaruraFiltradas =
                (from asignarura in asignaturas
                 where asignarura.Programa.Equals("LICENCIATURA EN LITERATURA Y LENGUAS CASTELLANAS")
                 select asignarura).ToList();
            return asignaruraFiltradas;
        }
        public List<Asignaturas> FiltrarProgramaLICENCIATURA_MATEMATICAS(string programa)
        {
            List<Asignaturas> asignaturas = ConsultarTodosAsignaturasDtg();
            List<Asignaturas> asignaruraFiltradas =
                (from asignarura in asignaturas
                 where asignarura.Programa.Equals("LICENCIATURA EN MATEMATICAS")
                 select asignarura).ToList();
            return asignaruraFiltradas;
        }
        public List<Asignaturas> FiltrarProgramaMICROBIOLOGIA(string programa)
        {
            List<Asignaturas> asignaturas = ConsultarTodosAsignaturasDtg();
            List<Asignaturas> asignaruraFiltradas =
                (from asignarura in asignaturas
                 where asignarura.Programa.Equals("MICROBIOLOGIA")
                 select asignarura).ToList();
            return asignaruraFiltradas;
        }
        public List<Asignaturas> FiltrarProgramaMUSICA(string programa)
        {
            List<Asignaturas> asignaturas = ConsultarTodosAsignaturasDtg();
            List<Asignaturas> asignaruraFiltradas =
                (from asignarura in asignaturas
                 where asignarura.Programa.Equals("MUSICA")
                 select asignarura).ToList();
            return asignaruraFiltradas;
        }
        public List<Asignaturas> FiltrarProgramaPSICOLOGIA(string programa)
        {
            List<Asignaturas> asignaturas = ConsultarTodosAsignaturasDtg();
            List<Asignaturas> asignaruraFiltradas =
                (from asignarura in asignaturas
                 where asignarura.Programa.Equals("PSICOLOGIA")
                 select asignarura).ToList();
            return asignaruraFiltradas;
        }
        public int ContarProgramaADMINISTRACION_EMPRESAS()
        {
            return ConsultarTodosAsignaturasDtg().Where(p => p.Programa == "ADMINISTRACION DE EMPRESAS").Count();
        }
        public int ContarProgramaADMINISTRACION_TURISTICAS()
        {
            return ConsultarTodosAsignaturasDtg().Where(p => p.Programa == "ADMINISTRACION DE EMPRESAS TURISTICAS Y HOTELERAS").Count();
        }
        public int ContarProgramaCOMERCIO_INTERNACIONAL()
        {
            return ConsultarTodosAsignaturasDtg().Where(p => p.Programa == "COMERCIO INTERNACIONAL").Count();
        }
        public int ContarProgramaCONTADURIA_PUBLICA()
        {
            return ConsultarTodosAsignaturasDtg().Where(p => p.Programa == "CONTADURIA PUBLICA").Count();
        }
        public int ContarProgramaDERECHO()
        {
            return ConsultarTodosAsignaturasDtg().Where(p => p.Programa == "DERECHO").Count();
        }
        public int ContarProgramaECONOMIA()
        {
            return ConsultarTodosAsignaturasDtg().Where(p => p.Programa == "ECONOMIA").Count();
        }
        public int ContarProgramaENFERMERIA()
        {
            return ConsultarTodosAsignaturasDtg().Where(p => p.Programa == "ENFERMERIA").Count();
        }
        public int ContarProgramaINGENIERIA_AGROINDUSTRIAL()
        {
            return ConsultarTodosAsignaturasDtg().Where(p => p.Programa == "INGENIERIA AGROINDUSTRIAL").Count();
        }
        public int ContarProgramaINGENIERIA_AMBIENTAL()
        {
            return ConsultarTodosAsignaturasDtg().Where(p => p.Programa == "INGENIERIA AMBIENTAL Y SANITARIAS").Count();
        }
        public int ContarProgramaINGENIERIA_SISTEMAS()
        {
            return ConsultarTodosAsignaturasDtg().Where(p => p.Programa == "INGENIERIA SISTEMAS").Count();
        }
        public int ContarProgramaINGENIERIA_ELECTRONICA()
        {
            return ConsultarTodosAsignaturasDtg().Where(p => p.Programa == "INGENIERIA ELECTRONICA").Count();
        }
        public int ContarProgramaINSTRUMENTACION_QUIRURGICA()
        {
            return ConsultarTodosAsignaturasDtg().Where(p => p.Programa == "INSTRUMENTACION QUIRURGICA SOCIOLOGIA").Count();
        }
        public int ContarProgramaLICENCIATURA_ARTE()
        {
            return ConsultarTodosAsignaturasDtg().Where(p => p.Programa == "LICENCIATURA EN ARTE").Count();
        }
        public int ContarProgramaLICENCIATURA_NATURALES()
        {
            return ConsultarTodosAsignaturasDtg().Where(p => p.Programa == "LICENCIATURA EN CIENCIAS NATURALES Y EDUCACION AMBIENTAL").Count();
        }
        public int ContarProgramaLICENCIATURA_DEPORTES()
        {
            return ConsultarTodosAsignaturasDtg().Where(p => p.Programa == "LICENCIATURA EN EDUCACION FISICA, RECREACION Y DEPORTES").Count();
        }
        public int ContarProgramaLICENCIATURA_INGLES()
        {
            return ConsultarTodosAsignaturasDtg().Where(p => p.Programa == "LICENCIATURA EN ESPAÑOL E INGLES").Count();
        }
        public int ContarProgramaLICENCIATURA_LITERATURA()
        {
            return ConsultarTodosAsignaturasDtg().Where(p => p.Programa == "LICENCIATURA EN LITERATURA Y LENGUAS CASTELLANAS").Count();
        }
        public int ContarProgramaLICENCIATURA_MATEMATICAS()
        {
            return ConsultarTodosAsignaturasDtg().Where(p => p.Programa == "LICENCIATURA EN MATEMATICAS").Count();
        }
        public int ContarProgramaMICROBIOLOGIA()
        {
            return ConsultarTodosAsignaturasDtg().Where(p => p.Programa == "MICROBIOLOGIA").Count();
        }
        public int ContarProgramaMUSICA()
        {
            return ConsultarTodosAsignaturasDtg().Where(p => p.Programa == "MUSICA").Count();
        }
        public int ContarProgramaPSICOLOGIA()
        {
            return ConsultarTodosAsignaturasDtg().Where(p => p.Programa == "PSICOLOGIA").Count();
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
        public Docentes BuscarPorIdentificacion(string identificacion)
        {
            List<Docentes> docentes = ConsultarTodosDocentesDtg();
            foreach (var item in docentes)
            {
                if (EncontradoDocente(item.Identificacion, identificacion))
                {
                    return item;
                }
            }
            return null;
        }

        private bool EncontradoDocente(string identificacioRegistrada, string identificacionBuscada)
        {
            return identificacioRegistrada == identificacionBuscada;
        }

        //////////////////////////////////////-------------Filtros busqueda en tabla LINQ----------////////////////////////////////////

        public List<Docentes> FiltrarDocenteOcacional(string tipoAsignatura)
        {
            List<Docentes> docentes = ConsultarTodosDocentesDtg();
            List<Docentes> docentesFiltradas =
                (from docente in docentes
                 where docente.Categoria.Equals("Docente ocacional")
                 select docente).ToList();
            return docentesFiltradas;
        }

        public List<Docentes> FiltrarDocenteCatedratico(string tipoAsignatura)
        {

            List<Docentes> docentes = ConsultarTodosDocentesDtg();
            List<Docentes> docentesFiltradas =
                (from docente in docentes
                 where docente.Categoria.Equals("Docente catedratico")
                 select docente).ToList();
            return docentesFiltradas;
        }

        public List<Docentes> BuscarDocentesDtg(string identificacion)
        {
            List<Docentes> docentes = ConsultarTodosDocentesDtg();
            List<Docentes> docentesFiltradasBuscado =
                (from docente in docentes
                 where docente.Identificacion.Equals(identificacion)
                 select docente).ToList();
            return docentesFiltradasBuscado;
        }

        public int TotalizarTodosDocentes()
        {
            return ConsultarTodosDocentesDtg().Count();
        }
        public int ContarDocenteOcacional()
        {
            return ConsultarTodosDocentesDtg().Where(p => p.Categoria == "Docente ocacional").Count();
        }
        public int ContarDocenteCatedratico()
        {
            return ConsultarTodosDocentesDtg().Where(p => p.Categoria == "Docente catedratico").Count();
        }

        //////////////////////////////////------------------------///////////////////////////////////////
        /////////////////////////////////-----Plan Asignatura----///////////////////////////////////////
        ////////////////////////////////------------------------///////////////////////////////////////


        public void GuardarPlanAsignatura(PlanAsignaturas planAsignatura)
        {
            FileStream file = new FileStream(FilePlanAsignatura, FileMode.Append);
            StreamWriter writer = new StreamWriter(file);
            writer.WriteLine($"{planAsignatura.Materia};{planAsignatura.Descripcion};{planAsignatura.Justificacion};{planAsignatura.ObjetivoGeneral};" +
                $"{planAsignatura.ObjetivoEspecifico};{planAsignatura.ComponeteGenerico};{planAsignatura.Estrategias};{planAsignatura.Contenidos};" +
                $"{planAsignatura.MecanismosEvaluacion};{planAsignatura.ReferenciasBibliograficas}");
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
            planAsignatura.ReferenciasBibliograficas = datos[9];
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

        public void EliminarPlanAsignatura(string materia)
        {
            planAsignaturas.Clear();
            planAsignaturas = ConsultarTodosPlanAsignaturas();
            FileStream fileStream = new FileStream(FilePlanAsignatura, FileMode.Create);
            fileStream.Close();
            foreach (var item in planAsignaturas)
            {
                if (item.Materia != materia)
                {
                    GuardarPlanAsignatura(item);
                }
            }
        }
        
        public void ModificarPlanAsignatura(PlanAsignaturas planAsignatura)
        {
            planAsignaturas.Clear();
            planAsignaturas = ConsultarTodosPlanAsignaturas();
            FileStream fileStream = new FileStream(FileDocente, FileMode.Create);
            fileStream.Close();
            foreach (var item in planAsignaturas)
            {
                if (item.Materia != planAsignatura.Materia)
                {
                    GuardarPlanAsignatura(item);
                }
                else
                {
                    GuardarPlanAsignatura(planAsignatura);
                }
            }
        }
    }
}
