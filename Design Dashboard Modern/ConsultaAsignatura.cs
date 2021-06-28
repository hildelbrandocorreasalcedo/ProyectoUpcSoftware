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
            var response = upcService.BuscarAsignaturaDtg(TxtCodigo.Text);
            if (response != null)
            {
                CandidatoResponse respuesta = upcService.BuscarPorCodigo(TxtCodigo.Text);
                Asignaturas asignatura = respuesta.Asignatura;
                if (asignatura == null)
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
        private void FiltrarProgramaADMINISTRACION_EMPRESAS()
        {
            var response = upcService.FiltrarProgramaADMINISTRACION_EMPRESAS(CmbFiltro.Text);
            LlenarDtg(response);
            TxtTotalPrograma.Text = upcService.ContarProgramaADMINISTRACION_EMPRESAS().ToString();
        }
        private void FiltrarProgramaADMINISTRACION_TURISTICAS()
        {
            var response = upcService.FiltrarProgramaADMINISTRACION_TURISTICAS(CmbFiltro.Text);
            LlenarDtg(response);
            TxtTotalPrograma.Text = upcService.ContarProgramaADMINISTRACION_TURISTICAS().ToString();
        }
        private void FiltrarProgramaCOMERCIO_INTERNACIONAL()
        {
            var response = upcService.FiltrarProgramaCOMERCIO_INTERNACIONAL(CmbFiltro.Text);
            LlenarDtg(response);
            TxtTotalPrograma.Text = upcService.ContarProgramaCOMERCIO_INTERNACIONAL().ToString();
        }
        private void FiltrarProgramaCONTADURIA_PUBLICA()
        {
            var response = upcService.FiltrarProgramaCONTADURIA_PUBLICA(CmbFiltro.Text);
            LlenarDtg(response);
            TxtTotalPrograma.Text = upcService.ContarProgramaCONTADURIA_PUBLICA().ToString();
        }
        private void FiltrarProgramaDERECHO()
        {
            var response = upcService.FiltrarProgramaDERECHO(CmbFiltro.Text);
            LlenarDtg(response);
            TxtTotalPrograma.Text = upcService.ContarProgramaDERECHO().ToString();
        }
        private void FiltrarProgramaECONOMIA()
        {
            var response = upcService.FiltrarProgramaECONOMIA(CmbFiltro.Text);
            LlenarDtg(response);
            TxtTotalPrograma.Text = upcService.ContarProgramaECONOMIA().ToString();
        }
        private void FiltrarProgramaENFERMERIA()
        {
            var response = upcService.FiltrarProgramaENFERMERIA(CmbFiltro.Text);
            LlenarDtg(response);
            TxtTotalPrograma.Text = upcService.ContarProgramaENFERMERIA().ToString();
        }
        private void FiltrarProgramaINGENIERIA_AGROINDUSTRIAL()
        {
            var response = upcService.FiltrarProgramaINGENIERIA_AGROINDUSTRIAL(CmbFiltro.Text);
            LlenarDtg(response);
            TxtTotalPrograma.Text = upcService.ContarProgramaINGENIERIA_AGROINDUSTRIAL().ToString();
        }
        private void FiltrarProgramaINGENIERIA_AMBIENTAL()
        {
            var response = upcService.FiltrarProgramaINGENIERIA_AMBIENTAL(CmbFiltro.Text);
            LlenarDtg(response);
            TxtTotalPrograma.Text = upcService.ContarProgramaINGENIERIA_AMBIENTAL().ToString();
        }
        private void FiltrarProgramaINGENIERIA_ELECTRONICA()
        {
            var response = upcService.FiltrarProgramaINGENIERIA_ELECTRONICA(CmbFiltro.Text);
            LlenarDtg(response);
            TxtTotalPrograma.Text = upcService.ContarProgramaINGENIERIA_ELECTRONICA().ToString();
        }
        private void FiltrarProgramaINGENIERIA_SISTEMAS()
        {
            var response = upcService.FiltrarProgramaINGENIERIA_SISTEMAS(CmbFiltro.Text);
            LlenarDtg(response);
            TxtTotalPrograma.Text = upcService.ContarProgramaINGENIERIA_SISTEMAS().ToString();
        }
        private void FiltrarProgramaINSTRUMENTACION_QUIRURGICA()
        {
            var response = upcService.FiltrarProgramaINSTRUMENTACION_QUIRURGICA(CmbFiltro.Text);
            LlenarDtg(response);
            TxtTotalPrograma.Text = upcService.ContarProgramaINSTRUMENTACION_QUIRURGICA().ToString();
        }
        private void FiltrarProgramaLICENCIATURA_ARTE()
        {
            var response = upcService.FiltrarProgramaLICENCIATURA_ARTE(CmbFiltro.Text);
            LlenarDtg(response);
            TxtTotalPrograma.Text = upcService.ContarProgramaLICENCIATURA_ARTE().ToString();
        }
        private void FiltrarProgramaLICENCIATURA_DEPORTES()
        {
            var response = upcService.FiltrarProgramaLICENCIATURA_DEPORTES(CmbFiltro.Text);
            LlenarDtg(response);
            TxtTotalPrograma.Text = upcService.ContarProgramaLICENCIATURA_DEPORTES().ToString();
        }
        private void FiltrarProgramaLICENCIATURA_ESPANOL_INGLES()
        {
            var response = upcService.FiltrarProgramaLICENCIATURA_ESPANOL_INGLES(CmbFiltro.Text);
            LlenarDtg(response);
            TxtTotalPrograma.Text = upcService.ContarProgramaLICENCIATURA_INGLES().ToString();
        }
        private void FiltrarProgramaLICENCIATURA_LITERATURA()
        {
            var response = upcService.FiltrarProgramaLICENCIATURA_LITERATURA(CmbFiltro.Text);
            LlenarDtg(response);
            TxtTotalPrograma.Text = upcService.ContarProgramaLICENCIATURA_LITERATURA().ToString();
        }
        private void FiltrarProgramaLICENCIATURA_MATEMATICAS()
        {
            var response = upcService.FiltrarProgramaLICENCIATURA_MATEMATICAS(CmbFiltro.Text);
            LlenarDtg(response);
            TxtTotalPrograma.Text = upcService.ContarProgramaLICENCIATURA_MATEMATICAS().ToString();
        }
        private void FiltrarProgramaLICENCIATURA_NATURALES()
        {
            var response = upcService.FiltrarProgramaLICENCIATURA_NATURALES(CmbFiltro.Text);
            LlenarDtg(response);
            TxtTotalPrograma.Text = upcService.ContarProgramaLICENCIATURA_NATURALES().ToString();
        }
        private void FiltrarProgramaMICROBIOLOGIA()
        {
            var response = upcService.FiltrarProgramaMICROBIOLOGIA(CmbFiltro.Text);
            LlenarDtg(response);
            TxtTotalPrograma.Text = upcService.ContarProgramaMICROBIOLOGIA().ToString();
        }
        private void FiltrarProgramaMUSICA()
        {
            var response = upcService.FiltrarProgramaMUSICA(CmbFiltro.Text);
            LlenarDtg(response);
            TxtTotalPrograma.Text = upcService.ContarProgramaMUSICA().ToString();
        }
        private void FiltrarProgramaPSICOLOGIA()
        {
            var response = upcService.FiltrarProgramaPSICOLOGIA(CmbFiltro.Text);
            LlenarDtg(response);
            TxtTotalPrograma.Text = upcService.ContarProgramaPSICOLOGIA().ToString();
        }
      
        private void BtFiltroPrograma_Click(object sender, EventArgs e)
        {
            DtgAsignatura.Rows.Clear();
            VaciarTextBox();
            var filtrado = CmbFiltroPrograma.Text;
            if (filtrado.Equals(""))
            {
                MessageBox.Show("Escoja una Opción de Filtrado", "Informacion de Consulta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (CmbFiltroPrograma.Text.Equals("TODAS LAS ASIGNATURAS"))
            {
                ConsultarTodosAsignaturasDtg();
            }
            else if (CmbFiltroPrograma.Text.Equals("ADMINISTRACION DE EMPRESAS"))
            {
                FiltrarProgramaADMINISTRACION_EMPRESAS();
            }
            else if (CmbFiltroPrograma.Text.Equals("ADMINISTRACION DE EMPRESAS TURISTICAS Y HOTELERAS"))
            {
                FiltrarProgramaADMINISTRACION_TURISTICAS();
            }
            else if (CmbFiltroPrograma.Text.Equals("COMERCIO INTERNACIONAL"))
            {
                FiltrarProgramaCOMERCIO_INTERNACIONAL();
            }
            else if (CmbFiltroPrograma.Text.Equals("CONTADURIA PUBLICA"))
            {
                FiltrarProgramaCONTADURIA_PUBLICA();
            }
            else if (CmbFiltroPrograma.Text.Equals("DERECHO"))
            {
                FiltrarProgramaDERECHO();
            }
            else if (CmbFiltroPrograma.Text.Equals("ECONOMIA"))
            {
                FiltrarProgramaECONOMIA();
            }
            else if (CmbFiltroPrograma.Text.Equals("ENFERMERIA"))
            {
                FiltrarProgramaENFERMERIA();
            }
            else if (CmbFiltroPrograma.Text.Equals("INGENIERIA AGROINDUSTRIAL"))
            {
                FiltrarProgramaINGENIERIA_AGROINDUSTRIAL();
            }
            else if (CmbFiltroPrograma.Text.Equals("INGENIERIA AMBIENTAL Y SANITARIAS"))
            {
                FiltrarProgramaINGENIERIA_AMBIENTAL();
            }
            else if (CmbFiltroPrograma.Text.Equals("INGENIERIA ELECTRONICA"))
            {
                FiltrarProgramaINGENIERIA_ELECTRONICA();
            }
            else if (CmbFiltroPrograma.Text.Equals("INGENIERIA SISTEMAS"))
            {
                FiltrarProgramaINGENIERIA_SISTEMAS();
            }
            else if (CmbFiltroPrograma.Text.Equals("INSTRUMENTACION QUIRURGICA SOCIOLOGIA"))
            {
                FiltrarProgramaINSTRUMENTACION_QUIRURGICA();
            }
            else if (CmbFiltroPrograma.Text.Equals("LICENCIATURA EN ARTE"))
            {
                FiltrarProgramaLICENCIATURA_ARTE();
            }
            else if (CmbFiltroPrograma.Text.Equals("LICENCIATURA EN EDUCACION FISICA, RECREACION Y DEPORTES"))
            {
                FiltrarProgramaLICENCIATURA_DEPORTES();
            }
            else if (CmbFiltroPrograma.Text.Equals("LICENCIATURA EN ESPAÑOL E INGLES"))
            {
                FiltrarProgramaLICENCIATURA_ESPANOL_INGLES();
            }
            else if (CmbFiltroPrograma.Text.Equals("LICENCIATURA EN LITERATURA Y LENGUAS CASTELLANAS"))
            {
                FiltrarProgramaLICENCIATURA_LITERATURA();
            }
            else if (CmbFiltroPrograma.Text.Equals("LICENCIATURA EN MATEMATICAS"))
            {
                FiltrarProgramaLICENCIATURA_MATEMATICAS();
            }
            else if (CmbFiltroPrograma.Text.Equals("LICENCIATURA EN CIENCIAS NATURALES Y EDUCACION AMBIENTAL"))
            {
                FiltrarProgramaLICENCIATURA_NATURALES();
            }
            else if (CmbFiltroPrograma.Text.Equals("MICROBIOLOGIA"))
            {
                FiltrarProgramaMICROBIOLOGIA(); 
            }
            else if (CmbFiltroPrograma.Text.Equals("MUSICA"))
            {
                FiltrarProgramaMUSICA();
            }
            else if (CmbFiltroPrograma.Text.Equals("PSICOLOGIA"))
            {
                FiltrarProgramaPSICOLOGIA();
            }
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
