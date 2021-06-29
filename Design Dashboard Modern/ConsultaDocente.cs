using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ENTITY;
using BLL;

namespace Design_Dashboard_Modern
{
    public partial class ConsultaDocente : Form
    {
        private readonly UpcService upcService;
        public ConsultaDocente()
        {
            InitializeComponent();
            upcService = new UpcService();
        }
        private void ConsultarTodosDocentesDtg()
        {
            var response = upcService.ConsultarTodosDocentesDtg();
            LlenarDtg(response);
            TxtTotalDocentes.Text = upcService.TotalizarTodosDocentes().ToString();
        }

        private void ConsultarFiltrarDocenteCatedratico()
        {
            var response = upcService.ConsultarFiltrarDocenteCatedratico(CmbFiltro.Text);
            LlenarDtg(response);
            TxtTotalCategoria.Text = upcService.ContarDocenteCatedratico().ToString();
        }

        private void ConsultarFiltrarDocenteOcacional()
        {
            var response = upcService.ConsultarFiltrarDocenteOcacional(CmbFiltro.Text);
            LlenarDtg(response);
            TxtTotalCategoria.Text = upcService.ContarDocenteOcacional().ToString();
        }
        private void BuscarDtg()
        {
            var response = upcService.BuscarDocentesDtg(TxtIdentificacion.Text);
            if (response != null)
            {
                DocenteResponse respuesta = upcService.BuscarPorIdentificacion(TxtIdentificacion.Text);
                Docentes docente = respuesta.Docente;
                if (docente == null)
                {
                    MessageBox.Show("La identificacion buscada no se encuentra, vuelva a intentarlo con otra identificacion",
                        "Informacion de Consulta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                LlenarDtg(response);
            }
        }
        private void LlenarDtg(ConsultaDocenteResponse response)
        {
            if (response.Encontrado)
            {
                foreach (var item in response.Docente)
                {
                    DtgDocente.Rows.Add(item.Identificacion, item.Nombre, item.Apellido, item.Telefono, item.Correo, item.Categoria, item.Materia);
                }
            }
        }

        private void VaciarTextBox()
        {
            TxtTotalCategoria.Text = "";
            TxtTotalDocentes.Text = "";
        }
        private void ConsultaDocente_Load(object sender, EventArgs e)
        {

        }

        private void BtLimpiar_Click(object sender, EventArgs e)
        {
            VaciarTextBox();
            DtgDocente.Rows.Clear();
        }

        private void BtConsultar_Click(object sender, EventArgs e)
        {
            DtgDocente.Rows.Clear();
            VaciarTextBox();
            var filtrado = TxtIdentificacion.Text;
            if (filtrado.Equals(""))
            {
                MessageBox.Show("Escriba la identificacion a buscar", "Informacion de Consulta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                BuscarDtg();
            }
        }

        private void BtFiltroTipoDocente_Click(object sender, EventArgs e)
        {
            DtgDocente.Rows.Clear();
            VaciarTextBox();
            var filtrado = CmbFiltro.Text;
            if (filtrado.Equals(""))
            {
                MessageBox.Show("Escoja una Opción de Filtrado", "Informacion de Consulta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (CmbFiltro.Text.Equals("TODOS LOS DOCENTES"))
            {
                ConsultarTodosDocentesDtg();
            }
            else if (CmbFiltro.Text.Equals("Docente ocacional"))
            {
                ConsultarFiltrarDocenteCatedratico();
            }
            else if (CmbFiltro.Text.Equals("Docente catedratico"))
            {
                ConsultarFiltrarDocenteOcacional();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
