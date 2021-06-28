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
    public partial class RegistroPlanAsignaturas : Form
    {
        private readonly UpcService upcService;
        public RegistroPlanAsignaturas()
        {
            InitializeComponent();
            upcService = new UpcService();
        }

        private void BtLLenarDescripcion_Click(object sender, EventArgs e)
        {
            LLenarDescripcion abrir = new LLenarDescripcion();
            abrir.Show();
        }
        private void RegistroPlanAsignaturas_Load(object sender, EventArgs e)
        {
            var response = upcService.ConsultarTodosAsignaturasDtg();
            CmbAsignatura.Items.Insert(0, "");
            foreach (var item in response.Asignatura)
            {
                CmbAsignatura.Items.Insert(1, item.Nombre);
            }
        }
        private void BtLLenarJustificacion_Click(object sender, EventArgs e)
        {
            LLenarJustificacion abrir = new LLenarJustificacion();
            abrir.Show();
        }
        private void BtLLenarObjetivoGeneral_Click(object sender, EventArgs e)
        {
            LLenarObjetivoGeneral abrir = new LLenarObjetivoGeneral();
            abrir.Show();
        }
        private void BtLLenarObjetivosEspecificos_Click(object sender, EventArgs e)
        {
            LLenarObjetivoEspecifico abrir = new LLenarObjetivoEspecifico();
            abrir.Show();
        }
        private void BtLLenarComponentesGenericos_Click(object sender, EventArgs e)
        {
            LLenarComponentesGenericos abrir = new LLenarComponentesGenericos();
            abrir.Show();
        }
        private void BtLLenarEstrategiasPedagogicas_Click(object sender, EventArgs e)
        {
            LLenarEstrategiasPedagogicas abrir = new LLenarEstrategiasPedagogicas();
            abrir.Show();
        }
        private void BtLLenarContenidos_Click(object sender, EventArgs e)
        {
            LLenarContenidosCompetencias abrir = new LLenarContenidosCompetencias();
            abrir.Show();
        }
        private void BtLLenarMecanismoEvaluacion_Click(object sender, EventArgs e)
        {
            LLenarMecanismoEvaluacion abrir = new LLenarMecanismoEvaluacion();
            abrir.Show();
        }
        private void BtLLenarReferenciasBibliograficas_Click(object sender, EventArgs e)
        {
            LLenarReferenciasBibliograficas abrir = new LLenarReferenciasBibliograficas();
            abrir.Show();
        }
    }
}
