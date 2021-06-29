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
            VisibilidadOpciones();
        }

        private void VisibilidadOpciones()
        {
            TxtDescripcion.Visible = false;
            ExDescripcion.Visible = false;
            TxtJustificacion.Visible = false;
            ExJustificacion.Visible = false;
            TxtObjetivoGeneral.Visible = false;
            ExObjetivoGeneral.Visible = false;
            TxtObjetivoEspecifico.Visible = false;
            ExObjetivosEspecificos.Visible = false;
            TxtComponentesGenericos.Visible = false;
            ExComponetes.Visible = false;
            TxtEstrategias.Visible = false;
            ExEstrategias.Visible = false;
            TxtContenido.Visible = false;
            ExContenido.Visible = false;
            TxtMecanismoEvaluativo.Visible = false;
            ExMecanismoEvaluacion.Visible = false;
            TxtReferenciaBibliografica.Visible = false;
            ExReferenciasBibliograficas.Visible = false;
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
            if (TxtNombre.Text == "")
            {
                ok = false;
                errorProvider1.SetError(TxtNombre, "Este Campo Es Obligatorio");
            }
            if (TxtIdentificacion.Text == "")
            {
                ok = false;
                errorProvider1.SetError(TxtIdentificacion, "Por Favor Ingrese la Identificacion");
            }
            if (TxtApellido.Text == "")
            {
                ok = false;
                errorProvider1.SetError(TxtApellido, "Este Campo Es Obligatorio");
            }
            if (CmbAsignatura.Text == "")
            {
                ok = false;
                errorProvider1.SetError(CmbAsignatura, "Este Campo Es Obligatorio");
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

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
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
                    string materia = CmbAsignatura.Text;
                    if (materia != "")
                    {
                        RespuestaBusqueda respuesta2 = upcService.BuscarPlanAsignatura(materia);

                        if (respuesta2.PlanAsignatura != null)
                        {
                            PlanAsignaturas planAsignatura = respuesta2.PlanAsignatura;
                            TxtDescripcion.Text = planAsignatura.Descripcion;
                            TxtJustificacion.Text = planAsignatura.Justificacion;
                            TxtObjetivoGeneral.Text = planAsignatura.ObjetivoGeneral;
                            TxtObjetivoEspecifico.Text = planAsignatura.ObjetivoEspecifico;
                            TxtComponentesGenericos.Text = planAsignatura.ComponeteGenerico;
                            TxtEstrategias.Text = planAsignatura.Estrategias;
                            TxtContenido.Text = planAsignatura.Contenidos;
                            TxtMecanismoEvaluativo.Text = planAsignatura.MecanismosEvaluacion;
                            TxtMecanismoEvaluativo.Text = planAsignatura.ReferenciasBibliograficas;

                        }
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

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
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

        private void TxtNombre_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(TxtNombre, "");
        }

        private void TxtApellido_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(TxtApellido, "");
        }

        private void CmbAsignatura_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            errorProvider1.SetError(CmbAsignatura, "");
        }
    }
}
