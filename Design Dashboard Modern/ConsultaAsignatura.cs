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
    public partial class ConsultaAsignatura : Form
    {
        private readonly UpcService upcService;
       
        public ConsultaAsignatura()
        {
            InitializeComponent();
            upcService = new UpcService();
        }

        private void ConsultarTodosAsignaturasDtg()
        {
            var response = upcService.ConsultarTodosAsignaturasDtg();
            LlenarDtg(response);
            TxtTotalAsignaturas.Text = upcService.TotalizarTodasAsignaturas().ToString();
        }

        private void ConsultarFiltrarTeoricoPractico()
        {
            var response = upcService.ConsultarFiltrarTeoricoPractico(CmbFiltro.Text);
            LlenarDtg(response);
            TxtTotalTipoAsignatura.Text = upcService.ContarTeoricoPractico().ToString();
        }

        private void ConsultarFiltrarPractico()
        {
            var response = upcService.ConsultarFiltrarPractico(CmbFiltro.Text);
            LlenarDtg(response);
            TxtTotalTipoAsignatura.Text = upcService.ContarPractico().ToString();
        }

        private void ConsultarFiltrarTeorico()
        {
            var response = upcService.ConsultarFiltrarTeorico(CmbFiltro.Text);
            LlenarDtg(response);
            TxtTotalTipoAsignatura.Text = upcService.ContarTeorico().ToString();
        }

        private void BuscarDtg()
        {
            var response = upcService.BuscarDtg(TxtCodigo.Text);
            if (response != null)
            {
                CandidatoResponse respuesta = upcService.BuscarPorCodigo(TxtCodigo.Text);
                Asignaturas estudiante = respuesta.Asignatura;
                if (estudiante == null)
                {
                    MessageBox.Show("El codigo buscado no se encuentra, vuelva a intentarlo con otro codigo", 
                        "Informacion de Consulta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                LlenarDtg(response);
            }
        }

        private void LlenarDtg(ConsultaCandidatoResponse response)
        {
            if (response.Encontrado)
            {
                foreach (var item in response.Asignatura)
                {
                    DtgAsignatura.Rows.Add(item.Codigo, item.Nombre, item.Programa, item.TipoAsignatura, item.Creditos);
                }
            }
        }
       
        private void VaciarTextBox()
        {
            TxtTotalAsignaturas.Text = "";
            TxtTotalPrograma.Text = "";
            TxtTotalTipoAsignatura.Text = "";
        }

        private void BtConsultar_Click(object sender, EventArgs e)
        {
            DtgAsignatura.Rows.Clear();
            VaciarTextBox();
            var filtrado = TxtCodigo.Text;
            if (filtrado.Equals(""))
            {
                MessageBox.Show("Escriba el Codigo a buscar", "Informacion de Consulta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                BuscarDtg();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void CmbFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TxtConteoVotaron_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void TxtTotalVotaron_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtConteoNoVotaron_TextChanged(object sender, EventArgs e)
        {

        }

        private void ConsultaAsignatura_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtFiltroPrograma_Click(object sender, EventArgs e)
        {

        }

        private void BtFiltroAsignatura_Click(object sender, EventArgs e)
        {
            DtgAsignatura.Rows.Clear();
            VaciarTextBox();
            var filtrado = CmbFiltro.Text;
            if (filtrado.Equals(""))
            {
                MessageBox.Show("Escoja una Opción de Filtrado", "Informacion de Consulta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (CmbFiltro.Text.Equals("TODAS LAS ASIGNATURAS"))
            {
                ConsultarTodosAsignaturasDtg();
            }
            else if (CmbFiltro.Text.Equals("Teorico/Practico"))
            {
                ConsultarFiltrarTeoricoPractico();
            }
            else if (CmbFiltro.Text.Equals("Teorico"))
            {
                ConsultarFiltrarTeorico();
            }
            else if (CmbFiltro.Text.Equals("Practico"))
            {
                ConsultarFiltrarPractico();
            }
        }

        private void BtLimpiar_Click(object sender, EventArgs e)
        {
            VaciarTextBox();
            DtgAsignatura.Rows.Clear();
        }
    }
}
