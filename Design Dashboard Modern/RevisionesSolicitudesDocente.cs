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
    public partial class RevisionesSolicitudesDocente : Form
    {
        private readonly UpcService upcService;
        public RevisionesSolicitudesDocente()
        {
            InitializeComponent();
            upcService = new UpcService();
        }
        private void BuscarDtg()
        {
            var response = upcService.BuscarSolicitudDocentesDtg(TxtIdentificacion.Text);
            if (response != null)
            {
                SolicitudDocenteResponse respuesta = upcService.BuscarPorIdentificacionSolicitudDocentes(TxtIdentificacion.Text);
                SolicitudDocentes solicitudDocente = respuesta.SolicitudDocente;
                if (solicitudDocente == null)
                {
                    MessageBox.Show("La identificacion buscada no se encuentra, vuelva a intentarlo con otra identificacion",
                        "Informacion de Consulta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                LlenarDtg(response);
            }
        }
        private void LlenarDtg(ConsultaSolicitudDocenteResponse response)
        {
            if (response.Encontrado)
            {
                foreach (var item in response.SolicitudDocente)
                {
                    DtgSolicitudDocente.Rows.Add(item.Identificacion, item.Nombre, item.Apellido, item.Materia, item.Descripcion,
                        item.Justificacion, item.ObjetivoGeneral, item.ComponeteGenerico, item.Estrategias, item.Contenidos, 
                        item.MecanismosEvaluacion, item.ReferenciasBibliograficas, item.Estado);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void BtConsultar_Click(object sender, EventArgs e)
        {
            DtgSolicitudDocente.Rows.Clear();
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

        private void BtLimpiar_Click(object sender, EventArgs e)
        {
            VaciarTextBox();
            DtgSolicitudDocente.Rows.Clear();
        }
        private void VaciarTextBox()
        {
            TxtContarTotalAprobados.Text = "";
            TxtContarSiAprobados.Text = "";
            TxtContarNOAprobados.Text = "";
        }

        private void BtFiltroTipoDocente_Click(object sender, EventArgs e)
        {
            DtgSolicitudDocente.Rows.Clear();
            VaciarTextBox();
            var filtrado = CmbFiltro.Text;
            if (filtrado.Equals(""))
            {
                MessageBox.Show("Escoja una Opción de Filtrado", "Informacion de Consulta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (CmbFiltro.Text.Equals("TODOS"))
            {
                ConsultarTodosSolicitudDocentesDtg();
            }
            else if (CmbFiltro.Text.Equals("Aprobado"))
            {
                ConsultarFiltrarSolicitudDocenteAprobadoSi();
            }
            else if (CmbFiltro.Text.Equals("Desaprobado"))
            {
                ConsultarFiltrarSolicitudDocenteAprobadoNo();
            }
        }
        private void ConsultarTodosSolicitudDocentesDtg()
        {
            var response = upcService.ConsultarTodosSolicitudDocentesDtg();
            LlenarDtg(response);
            TxtContarTotalAprobados.Text = upcService.TotalizarTodosSolicitudDocentes().ToString();
        }
        private void ConsultarFiltrarSolicitudDocenteAprobadoSi()
        {
            var response = upcService.FiltrarSolicitudDocenteAprobado(CmbFiltro.Text);
            LlenarDtg(response);
            TxtContarSiAprobados.Text = upcService.ContarSolicitudDocenteAprobado().ToString();
        }

        private void ConsultarFiltrarSolicitudDocenteAprobadoNo()
        {
            var response = upcService.FiltrarSolicitudDocenteDesaprobado(CmbFiltro.Text);
            LlenarDtg(response);
            TxtContarNOAprobados.Text = upcService.ContarSolicitudDocenteDesaprobado().ToString();
        }
    }
}
