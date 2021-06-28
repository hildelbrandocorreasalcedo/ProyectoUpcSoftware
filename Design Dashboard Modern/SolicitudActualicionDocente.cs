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

        private void RegistrarRespuestaFormatoDocente_Load(object sender, EventArgs e)
        {          
        }

        private void BtRegistrar_Click(object sender, EventArgs e)
        {
            
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
    }
}
