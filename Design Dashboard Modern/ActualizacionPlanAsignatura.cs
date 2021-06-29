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
    public partial class ActualizacionPlanAsignatura : Form
    {
        private readonly UpcService upcService;
        public ActualizacionPlanAsignatura()
        {
            InitializeComponent();
            upcService = new UpcService();
        }
        private PlanAsignaturas MapearPlanAsignatura()
        {
            PlanAsignaturas planAsignatura = new PlanAsignaturas();
            planAsignatura.Materia = CmbAsignatura.Text;
            planAsignatura.Descripcion = TxtDescripcion.Text;
            planAsignatura.Justificacion = TxtJustificacion.Text;
            planAsignatura.ObjetivoGeneral = TxtObjetivoGeneral.Text;
            planAsignatura.ObjetivoEspecifico = TxtObjetivoEspecifico.Text;
            planAsignatura.ComponeteGenerico = TxtComponentesGenericos.Text;
            planAsignatura.Estrategias = TxtEstrategias.Text;
            planAsignatura.Contenidos = TxtContenido.Text;
            planAsignatura.MecanismosEvaluacion = TxtMecanismoEvaluativo.Text;
            planAsignatura.ReferenciasBibliograficas = TxtReferenciaBibliografica.Text;
            return planAsignatura;
        }

        private void BorrarMensajesError()
        {
            errorProvider1.SetError(CmbAsignatura, "");
            errorProvider1.SetError(TxtDescripcion, "");
            errorProvider1.SetError(TxtJustificacion, "");
            errorProvider1.SetError(TxtObjetivoGeneral, "");
            errorProvider1.SetError(TxtObjetivoEspecifico, "");
            errorProvider1.SetError(TxtComponentesGenericos, "");
            errorProvider1.SetError(TxtEstrategias, "");
            errorProvider1.SetError(TxtContenido, "");
            errorProvider1.SetError(TxtMecanismoEvaluativo, "");
            errorProvider1.SetError(TxtReferenciaBibliografica, "");
        }


        private bool validarcampos()
        {
            bool ok = true;
            if (CmbAsignatura.Text == "")
            {
                ok = false;
                errorProvider1.SetError(CmbAsignatura, "Por Favor escoja una Asignatura");
            }
            if (TxtDescripcion.Text == "")
            {
                ok = false;
                errorProvider1.SetError(TxtDescripcion, "Por Favor Ingrese la descripcion");
            }
            if (TxtJustificacion.Text == "")
            {
                ok = false;
                errorProvider1.SetError(TxtJustificacion, "Por Favor Ingrese la justificacion");
            }
            if (TxtObjetivoGeneral.Text == "")
            {
                ok = false;
                errorProvider1.SetError(TxtObjetivoGeneral, "Por Favor Ingrese el Objetivo general");
            }
            if (TxtObjetivoEspecifico.Text == "")
            {
                ok = false;
                errorProvider1.SetError(TxtObjetivoEspecifico, "Por Favor Ingrese los Objetivos especificos");
            }
            if (TxtComponentesGenericos.Text == "")
            {
                ok = false;
                errorProvider1.SetError(TxtComponentesGenericos, "Por Favor Ingrese los componentes genericos");
            }
            if (TxtEstrategias.Text == "")
            {
                ok = false;
                errorProvider1.SetError(TxtEstrategias, "Por Favor Ingrese las estreategias pedagogicas");
            }
            if (TxtContenido.Text == "")
            {
                ok = false;
                errorProvider1.SetError(TxtContenido, "Por Favor Ingrese los Contenidos, Competencias y resultados");
            }
            if (TxtMecanismoEvaluativo.Text == "")
            {
                ok = false;
                errorProvider1.SetError(TxtMecanismoEvaluativo, "Por Favor Ingrese el mecanismo de evaluacion");
            }
            if (TxtReferenciaBibliografica.Text == "")
            {
                ok = false;
                errorProvider1.SetError(TxtReferenciaBibliografica, "Por Favor Ingrese las referencias bibliograficas");
            }
            return ok;
        }
        private void BtConsultar_Click(object sender, EventArgs e)
        {
            string materia = CmbAsignatura.Text;
            if (materia != "")
            {
                RespuestaBusqueda respuesta = upcService.BuscarPlanAsignatura(materia);

                if (respuesta.PlanAsignatura != null)
                {
                    PlanAsignaturas planAsignatura = respuesta.PlanAsignatura;
                    TxtDescripcion.Text = planAsignatura.Descripcion;
                    TxtJustificacion.Text = planAsignatura.Justificacion;
                    TxtObjetivoGeneral.Text = planAsignatura.ObjetivoGeneral;
                    TxtObjetivoEspecifico.Text = planAsignatura.ObjetivoEspecifico;
                    TxtComponentesGenericos.Text = planAsignatura.ComponeteGenerico;
                    TxtEstrategias.Text = planAsignatura.Estrategias;
                    TxtContenido.Text = planAsignatura.Contenidos;
                    TxtMecanismoEvaluativo.Text = planAsignatura.MecanismosEvaluacion;
                    TxtReferenciaBibliografica.Text = planAsignatura.ReferenciasBibliograficas;
                    MessageBox.Show(respuesta.Mensaje);
                }
                else
                {
                    MessageBox.Show(respuesta.Mensaje, "Informacion de Consulta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Escoja el Plan Asignatura a buscar", "Informacion de Consulta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarTxt();
        }
        private void LimpiarTxt()
        {
            CmbAsignatura.Text = "";
            TxtDescripcion.Text = "";
            TxtJustificacion.Text = "";
            TxtObjetivoGeneral.Text = "";
            TxtObjetivoEspecifico.Text = "";
            TxtComponentesGenericos.Text = "";
            TxtEstrategias.Text = "";
            TxtContenido.Text = "";
            TxtMecanismoEvaluativo.Text = "";
            TxtReferenciaBibliografica.Text = "";
        }

        private void BtModificar_Click(object sender, EventArgs e)
        {

            BorrarMensajesError();
            if (validarcampos())
            {
                if (CmbAsignatura.Text != "" && TxtDescripcion.Text != "" && TxtJustificacion.Text != "" && TxtObjetivoGeneral.Text != ""
                    && TxtObjetivoEspecifico.Text != "" && TxtComponentesGenericos.Text != "" && TxtEstrategias.Text != ""
                     && TxtContenido.Text != "" && TxtMecanismoEvaluativo.Text != "" && TxtReferenciaBibliografica.Text != "")
                {
                    PlanAsignaturas planAsignatura = MapearPlanAsignatura();
                    string mensaje = upcService.ModificarPlanAsignatura(planAsignatura);
                    MessageBox.Show(mensaje, "Informacion de Modificacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("rectifique los campos", "Informacion de Modificacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                LimpiarTxt();
            }
        }

        private void TxtDescripcion_TextChanged(object sender, EventArgs e)
        {
            
            errorProvider1.SetError(TxtDescripcion, "");
            
        }

        private void CmbAsignatura_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(CmbAsignatura, "");
        }

        private void TxtJustificacion_TextChanged(object sender, EventArgs e)
        {
            
            errorProvider1.SetError(TxtJustificacion, "");
           
        }

        private void TxtObjetivoGeneral_TextChanged(object sender, EventArgs e)
        {
            
            errorProvider1.SetError(TxtObjetivoGeneral, "");
            
        }

        private void TxtObjetivoEspecifico_TextChanged(object sender, EventArgs e)
        {
           
            errorProvider1.SetError(TxtObjetivoEspecifico, "");
            
        }

        private void TxtComponentesGenericos_TextChanged(object sender, EventArgs e)
        {
            
            errorProvider1.SetError(TxtComponentesGenericos, "");
          
        }

        private void TxtEstrategias_TextChanged(object sender, EventArgs e)
        {
            
            errorProvider1.SetError(TxtEstrategias, "");
           
        }

        private void TxtContenido_TextChanged(object sender, EventArgs e)
        {
           
            errorProvider1.SetError(TxtContenido, "");
            
        }

        private void TxtMecanismoEvaluativo_TextChanged(object sender, EventArgs e)
        {
            
            errorProvider1.SetError(TxtMecanismoEvaluativo, "");
           
        }

        private void TxtReferenciaBibliografica_TextChanged(object sender, EventArgs e)
        {
           
            errorProvider1.SetError(TxtReferenciaBibliografica, "");
        }

        private void ActualizacionPlanAsignatura_Load(object sender, EventArgs e)
        {
            var response = upcService.ConsultarTodosAsignaturasDtg();
            CmbAsignatura.Items.Insert(0, "");
            foreach (var item in response.Asignatura)
            {
                CmbAsignatura.Items.Insert(1, item.Nombre);
            }
        }

        private void BtCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void BtLLenarDescripcion_Click(object sender, EventArgs e)
        {

        }

        private void BtLLenarJustificacion_Click(object sender, EventArgs e)
        {

        }

        private void ExDescripcion_Click(object sender, EventArgs e)
        {
            LLenarDescripcion2 abrir = new LLenarDescripcion2();
            AddOwnedForm(abrir);
            abrir.TxtDescripcionFrom.Text = TxtDescripcion.Text;
            abrir.ShowDialog();
        }

        private void ExJustificacion_Click(object sender, EventArgs e)
        {
            LLenarJustificacion2 abrir = new LLenarJustificacion2();
            AddOwnedForm(abrir);
            abrir.TxtJustificacionFrom.Text = TxtJustificacion.Text;
            abrir.ShowDialog();
        }

        private void ExObjetivoGeneral_Click(object sender, EventArgs e)
        {
            LLenarObjetivoGeneral2 abrir = new LLenarObjetivoGeneral2();
            AddOwnedForm(abrir);
            abrir.TxtObjetivoGeneralFrom.Text = TxtObjetivoGeneral.Text;
            abrir.ShowDialog();
        }

        private void ExObjetivosEspecificos_Click(object sender, EventArgs e)
        {
            LLenarObjetivoEspecifico2 abrir = new LLenarObjetivoEspecifico2();
            AddOwnedForm(abrir);
            abrir.TxtOjetivosEspecificosFrom.Text = TxtObjetivoEspecifico.Text;
            abrir.ShowDialog();
        }

        private void ExComponetes_Click(object sender, EventArgs e)
        {
            LLenarComponentesGenericos2 abrir = new LLenarComponentesGenericos2();
            AddOwnedForm(abrir);
            abrir.TxtComponetesGenericosFrom.Text = TxtComponentesGenericos.Text;
            abrir.ShowDialog();
        }

        private void ExEstrategias_Click(object sender, EventArgs e)
        {
            LLenarEstrategiasPedagogicas2 abrir = new LLenarEstrategiasPedagogicas2();
            AddOwnedForm(abrir);
            abrir.TxtEstrategiasPedagogicasFrom.Text = TxtEstrategias.Text;
            abrir.ShowDialog();
        }

        private void ExContenido_Click(object sender, EventArgs e)
        {
            LLenarContenidosCompetencias2 abrir = new LLenarContenidosCompetencias2();
            AddOwnedForm(abrir);
            abrir.TxtContenidosCompetenciasFrom.Text = TxtContenido.Text;
            abrir.ShowDialog();
        }

        private void ExMecanismoEvaluacion_Click(object sender, EventArgs e)
        {
            LLenarMecanismoEvaluacion2 abrir = new LLenarMecanismoEvaluacion2();
            AddOwnedForm(abrir);
            abrir.TxtMecanismoEvaluacionFrom.Text = TxtMecanismoEvaluativo.Text;
            abrir.ShowDialog();
        }

        private void ExReferenciasBibliograficas_Click(object sender, EventArgs e)
        {
            LLenarReferenciasBibliograficas2 abrir = new LLenarReferenciasBibliograficas2();
            AddOwnedForm(abrir);
            abrir.TxtReferenciasBibliograficasFrom.Text = TxtMecanismoEvaluativo.Text;
            abrir.ShowDialog();
        }
    }
}
