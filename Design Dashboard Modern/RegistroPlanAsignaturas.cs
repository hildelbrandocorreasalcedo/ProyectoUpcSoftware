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
using ProyectoHotelPensionados;

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
            AddOwnedForm(abrir);
            abrir.TxtDescripcionFrom.Text = TxtDescripcion.Text;
            abrir.ShowDialog();      
        }
        private void RegistroPlanAsignaturas_Load(object sender, EventArgs e)
        {          
        }
        private void BtLLenarJustificacion_Click(object sender, EventArgs e)
        {
            LLenarJustificacion abrir = new LLenarJustificacion();
            AddOwnedForm(abrir);
            abrir.TxtJustificacionFrom.Text = TxtJustificacion.Text;
            abrir.ShowDialog();
        }
        private void BtLLenarObjetivoGeneral_Click(object sender, EventArgs e)
        {
            LLenarObjetivoGeneral abrir = new LLenarObjetivoGeneral();
            AddOwnedForm(abrir);
            abrir.TxtObjetivoGeneralFrom.Text = TxtObjetivoGeneral.Text;
            abrir.ShowDialog();
        }
        private void BtLLenarObjetivosEspecificos_Click(object sender, EventArgs e)
        {
            LLenarObjetivoEspecifico abrir = new LLenarObjetivoEspecifico();
            AddOwnedForm(abrir);
            abrir.TxtOjetivosEspecificosFrom.Text = TxtObjetivoEspecifico.Text;
            abrir.ShowDialog();
        }
        private void BtLLenarComponentesGenericos_Click(object sender, EventArgs e)
        {
            LLenarComponentesGenericos abrir = new LLenarComponentesGenericos();
            AddOwnedForm(abrir);
            abrir.TxtComponetesGenericosFrom.Text = TxtComponentesGenericos.Text;
            abrir.ShowDialog();
        }
        private void BtLLenarEstrategiasPedagogicas_Click(object sender, EventArgs e)
        {
            LLenarEstrategiasPedagogicas abrir = new LLenarEstrategiasPedagogicas();
            AddOwnedForm(abrir);
            abrir.TxtEstrategiasPedagogicasFrom.Text = TxtEstrategias.Text;
            abrir.ShowDialog();
        }
        private void BtLLenarContenidos_Click(object sender, EventArgs e)
        {
            LLenarContenidosCompetencias abrir = new LLenarContenidosCompetencias();
            AddOwnedForm(abrir);
            abrir.TxtContenidosCompetenciasFrom.Text = TxtContenido.Text;
            abrir.ShowDialog();
        }
        private void BtLLenarMecanismoEvaluacion_Click(object sender, EventArgs e)
        {
            LLenarMecanismoEvaluacion abrir = new LLenarMecanismoEvaluacion();
            AddOwnedForm(abrir);
            abrir.TxtMecanismoEvaluacionFrom.Text = TxtMecanismoEvaluativo.Text;
            abrir.ShowDialog();
        }
        private void BtLLenarReferenciasBibliograficas_Click(object sender, EventArgs e)
        {
            LLenarReferenciasBibliograficas abrir = new LLenarReferenciasBibliograficas();
            AddOwnedForm(abrir);
            abrir.TxtReferenciasBibliograficasFrom.Text = TxtReferenciaBibliografica.Text;
            abrir.ShowDialog();
        }

        private void TxtDescripcion_MouseEnter(object sender, EventArgs e)
        {
        }
    }
}
