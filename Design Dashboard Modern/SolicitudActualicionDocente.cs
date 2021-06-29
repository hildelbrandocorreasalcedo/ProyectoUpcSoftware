using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using ENTITY;

namespace Design_Dashboard_Modern
{
    public partial class SolicitudActualicionDocente : Form
    {
        private readonly UpcService upcService;
        public SolicitudActualicionDocente()
        {
            InitializeComponent();
            upcService = new UpcService();
        }

        private void BorrarMensajesError()
        {
            errorProvider1.SetError(TxtIdentificacion, "");
            
        }

        private bool validarcampos()
        {
            bool ok = true;
            if (TxtNombre.Text == "")
            {
                ok = false;
                errorProvider1.SetError(TxtNombre, "Por Favor Ingrese los Nombre");
            }
            if (TxtIdentificacion.Text == "")
            {
                ok = false;
                errorProvider1.SetError(TxtIdentificacion, "Por Favor Ingrese la Identificacion");
            }
            if (TxtApellido.Text == "")
            {
                ok = false;
                errorProvider1.SetError(TxtApellido, "Por Favor Ingrese el apellido");
            }           
            if (CmbAsignatura.Text == "")
            {
                ok = false;
                errorProvider1.SetError(CmbAsignatura, "Este Campo Es Obligatorio");
            }
            return ok;
        }
        private void RegistrarRespuestaFormatoDocente_Load(object sender, EventArgs e)
        {
            var response = upcService.ConsultarTodosAsignaturasDtg();
            CmbAsignatura.Items.Insert(0, "");
            foreach (var item in response.Asignatura)
            {
                CmbAsignatura.Items.Insert(1, item.Nombre);
            }
        }

        private void BtRegistrar_Click(object sender, EventArgs e)
        {

            if (validarcampos())
            {
                BorrarMensajesError();
                int numero;
                if (!int.TryParse(TxtIdentificacion.Text, out numero))
                {
                    errorProvider1.SetError(TxtIdentificacion, "Ingrese Solo Numeros");
                }               
                else
                {
                    SolicitudDocentes solicitudDocente = MapearSolicitudDocente();
                    string mensaje = upcService.GuardarSolicitudDocente(solicitudDocente);
                    MessageBox.Show(mensaje, "Informacion de Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarTxt();
                }
            }
            else { MessageBox.Show("Debe llenar todos los campos", "Informacion de Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }
        private SolicitudDocentes MapearSolicitudDocente()
        {
            SolicitudDocentes solicitudDocente = new SolicitudDocentes();
            solicitudDocente.Identificacion = TxtIdentificacion.Text;
            solicitudDocente.Nombre = TxtNombre.Text;
            solicitudDocente.Apellido = TxtApellido.Text;
            solicitudDocente.Materia = CmbAsignatura.Text;
            solicitudDocente.Descripcion = "Yes";//CkDescripcion.Text;
            solicitudDocente.Justificacion = "Yes";//CkJustificacion.Text;
            solicitudDocente.ObjetivoGeneral = "Yes"; //CkObjetivoGeneral.Text;
            solicitudDocente.ObjetivoEspecifico = "Yes"; //CkObjetivosEspecificos.Text;
            solicitudDocente.ComponeteGenerico = "Yes"; //CkComponentesGenericos.Text;
            solicitudDocente.Estrategias = "Yes"; //CkEstrategias.Text;
            solicitudDocente.Contenidos = "Yes"; //CkContenido.Text;
            solicitudDocente.MecanismosEvaluacion = "Yes"; //CkMecanismoEvaluativo.Text;
            solicitudDocente.ReferenciasBibliograficas = "Yes"; //CkReferenciasBibliograficas.Text;
            solicitudDocente.Aprobado = "No";
            return solicitudDocente;
        }

        private void bunifuCheckbox1_OnChange(object sender, EventArgs e)
        {
          
        }

        private void CmbTipoAsignatura_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BtConsultar_Click(object sender, EventArgs e)
        {
            string identifiacion = TxtIdentificacion.Text;
            if (identifiacion != "")
            {
                RespuestaBusqueda respuesta = upcService.BuscarDocente(identifiacion);

                if (respuesta.Docente != null)
                {
                    Docentes docente = respuesta.Docente;
                    TxtNombre.Text = docente.Nombre;
                    TxtApellido.Text = docente.Apellido;                
                    CmbAsignatura.Text = docente.Materia;                 
                    MessageBox.Show(respuesta.Mensaje);
                }
                else
                {
                    MessageBox.Show(respuesta.Mensaje, "Informacion de Consulta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("digite la identificacion a buscar", "Informacion de Consulta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void bunifuCheckbox4_OnChange(object sender, EventArgs e)
        {

        }

        private void TxtIdentificacion_TextChanged(object sender, EventArgs e)
        {
            int numero;
            if (!int.TryParse(TxtIdentificacion.Text, out numero))
            {
                errorProvider1.SetError(TxtIdentificacion, "Ingrese Solo Numeros");
            }
            else
            {
                errorProvider1.SetError(TxtIdentificacion, "");
            }
        }

        private void BtLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarTxt();
        }
        private void LimpiarTxt()
        {
            TxtIdentificacion.Text = "";
            TxtNombre.Text = "";
            TxtApellido.Text = "";
            TxtApellido.Text = "";
            CmbAsignatura.Text = "";
        }

        private void BtCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
