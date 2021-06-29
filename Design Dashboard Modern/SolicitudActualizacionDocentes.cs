﻿using System;
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
    public partial class SolicitudActualizacionDocentes : Form
    {
        private readonly UpcService upcService;
        public SolicitudActualizacionDocentes()
        {
            InitializeComponent();
            upcService = new UpcService();
            VisibilidadOpciones();
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
        private void label4_Click(object sender, EventArgs e)
        {

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
            TxtDescripcion.Text = "";
            TxtJustificacion.Text = "";
            TxtObjetivoGeneral.Text = "";
            TxtObjetivosEspecificos.Text = "";
            TxtComponetes.Text = "";
            TxtEstrategias.Text = "";
            TxtComponetes.Text = "";
            TxtMecanismoEvaluacion.Text = "";
            TxtReferenciasBibliograficas.Text = "";

        }

        private void SolicitudActualizacionDocentes_Load(object sender, EventArgs e)
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
            string respuestaCkDescripcion;
            if (CkDescripcion.Checked == true)
            {
                respuestaCkDescripcion = "Yes";
            }
            else
            {
                respuestaCkDescripcion = "Not";
            }
            string respuestaCkJustificacion;
            if (CkJustificacion.Checked == true)
            {
                respuestaCkJustificacion = "Yes";
            }
            else
            {
                respuestaCkJustificacion = "Not";
            }
            string respuestaCkObjetivoGeneral;
            if (CkObjetivoGeneral.Checked == true)
            {
                respuestaCkObjetivoGeneral = "Yes";
            }
            else
            {
                respuestaCkObjetivoGeneral = "Not";
            }
            string respuestaCkObjetivosEspecificos;
            if (CkObjetivosEspecificos.Checked == true)
            {
                respuestaCkObjetivosEspecificos = "Yes";
            }
            else
            {
                respuestaCkObjetivosEspecificos = "Not";
            }
            string respuestaCkComponentesGenericos;
            if (CkComponetes.Checked == true)
            {
                respuestaCkComponentesGenericos = "Yes";
            }
            else
            {
                respuestaCkComponentesGenericos = "Not";
            }
            string respuestaCkEstrategias;
            if (CkEstrategias.Checked == true)
            {
                respuestaCkEstrategias = "Yes";
            }
            else
            {
                respuestaCkEstrategias = "Not";
            }
            string respuestaCkContenido;
            if (CkContenido.Checked == true)
            {
                respuestaCkContenido = "Yes";
            }
            else
            {
                respuestaCkContenido = "Not";
            }
            string respuestaCkMecanismoEvaluativo;
            if (CkMecanismoEvaluacion.Checked == true)
            {
                respuestaCkMecanismoEvaluativo = "Yes";
            }
            else
            {
                respuestaCkMecanismoEvaluativo = "Not";
            }
            string respuestaCkReferenciasBibliograficas;
            if (CkReferenciasBibliograficas.Checked == true)
            {
                respuestaCkReferenciasBibliograficas = "Yes";
            }
            else
            {
                respuestaCkReferenciasBibliograficas = "Not";
            }
            SolicitudDocentes solicitudDocente = new SolicitudDocentes();
            solicitudDocente.Identificacion = TxtIdentificacion.Text;
            solicitudDocente.Nombre = TxtNombre.Text;
            solicitudDocente.Apellido = TxtApellido.Text;
            solicitudDocente.Materia = CmbAsignatura.Text;
            solicitudDocente.Descripcion = respuestaCkDescripcion;
            solicitudDocente.Justificacion = respuestaCkJustificacion;
            solicitudDocente.ObjetivoGeneral = respuestaCkObjetivoGeneral;
            solicitudDocente.ObjetivoEspecifico = respuestaCkObjetivosEspecificos;
            solicitudDocente.ComponeteGenerico = respuestaCkComponentesGenericos;
            solicitudDocente.Estrategias = respuestaCkEstrategias;
            solicitudDocente.Contenidos = respuestaCkContenido;
            solicitudDocente.MecanismosEvaluacion = respuestaCkMecanismoEvaluativo;
            solicitudDocente.ReferenciasBibliograficas = respuestaCkReferenciasBibliograficas;
            string estado = "Desaprobado";
            solicitudDocente.Estado = estado;
            return solicitudDocente;
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
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
        private void VisibilidadOpciones()
        {
            TxtDescripcion.Visible = false;
            ExDescripcion.Visible = false;
            TxtJustificacion.Visible = false;
            ExJustificacion.Visible = false;
            TxtObjetivoGeneral.Visible = false;
            ExObjetivoGeneral.Visible = false;
            TxtObjetivosEspecificos.Visible = false;
            ExObjetivosEspecificos.Visible = false;
            TxtComponetes.Visible = false;
            ExComponetes.Visible = false;
            TxtEstrategias.Visible = false;
            ExEstrategias.Visible = false;
            TxtContenidos.Visible = false;
            ExContenido.Visible = false;
            TxtMecanismoEvaluacion.Visible = false;
            ExMecanismoEvaluacion.Visible = false;
            TxtReferenciasBibliograficas.Visible = false;
            ExReferenciasBibliograficas.Visible = false;
        }
        private void bunifuCheckbox2_OnChange(object sender, EventArgs e)
        {
            if (CkJustificacion.Checked == true)
            {
                TxtJustificacion.Visible = true;
                ExJustificacion.Visible = true;
            }
            else
            {
                TxtJustificacion.Text = "";
                TxtJustificacion.Visible = false;
                ExJustificacion.Visible = false;
            }
        }

        private void BtCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void CkDescripcion_OnChange(object sender, EventArgs e)
        {
            if (CkDescripcion.Checked == true)
            {
                TxtDescripcion.Visible = true;
                ExDescripcion.Visible = true;
            }
            else
            {
                TxtDescripcion.Text = "";
                TxtDescripcion.Visible = false;
                ExDescripcion.Visible = false;
            }
        }

        private void CkObjetivoGeneral_OnChange(object sender, EventArgs e)
        {
            if (CkObjetivoGeneral.Checked == true)
            {
                TxtObjetivoGeneral.Visible = true;
                ExObjetivoGeneral.Visible = true;
            }
            else
            {
                TxtObjetivoGeneral.Text = "";
                TxtObjetivoGeneral.Visible = false;
                ExObjetivoGeneral.Visible = false;
            }
        }

        private void CkObjetivosEspecificos_OnChange(object sender, EventArgs e)
        {
            if (CkObjetivosEspecificos.Checked == true)
            {
                TxtObjetivosEspecificos.Visible = true;
                ExObjetivosEspecificos.Visible = true;
            }
            else
            {
                TxtObjetivosEspecificos.Text = "";
                TxtObjetivosEspecificos.Visible = false;
                ExObjetivosEspecificos.Visible = false;
            }
        }

        private void CkComponetes_OnChange(object sender, EventArgs e)
        {
            if (CkComponetes.Checked == true)
            {
                TxtComponetes.Visible = true;
                ExComponetes.Visible = true;
            }
            else
            {
                TxtComponetes.Text = "";
                TxtComponetes.Visible = false;
                ExComponetes.Visible = false;
            }
        }

        private void CkEstrategias_OnChange(object sender, EventArgs e)
        {
            if (CkEstrategias.Checked == true)
            {
                TxtEstrategias.Visible = true;
                ExEstrategias.Visible = true;
            }
            else
            {
                TxtEstrategias.Text = "";
                TxtEstrategias.Visible = false;
                ExEstrategias.Visible = false;
            }
        }

        private void CkContenido_OnChange(object sender, EventArgs e)
        {
            if (CkContenido.Checked == true)
            {
                TxtContenidos.Visible = true;
                ExContenido.Visible = true;
            }
            else
            {
                TxtContenidos.Text = "";
                TxtContenidos.Visible = false;
                ExContenido.Visible = false;
            }
        }

        private void CkMecanismoEvaluacion_OnChange(object sender, EventArgs e)
        {
            if (CkMecanismoEvaluacion.Checked == true)
            {
                TxtMecanismoEvaluacion.Visible = true;
                ExMecanismoEvaluacion.Visible = true;
            }
            else
            {
                TxtMecanismoEvaluacion.Text = "";
                TxtMecanismoEvaluacion.Visible = false;
                ExMecanismoEvaluacion.Visible = false;
            }
        }

        private void CkReferenciasBibliograficas_OnChange(object sender, EventArgs e)
        {
            if (CkReferenciasBibliograficas.Checked == true)
            {
                TxtReferenciasBibliograficas.Visible = true;
                ExReferenciasBibliograficas.Visible = true;
            }
            else
            {
                TxtReferenciasBibliograficas.Text = "";
                TxtReferenciasBibliograficas.Visible = false;
                ExReferenciasBibliograficas.Visible = false;
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

        private void CmbAsignatura_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(CmbAsignatura, "");
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
            abrir.TxtOjetivosEspecificosFrom.Text = TxtObjetivosEspecificos.Text;
            abrir.ShowDialog();
        }

        private void ExComponetes_Click(object sender, EventArgs e)
        {
            LLenarComponentesGenericos2 abrir = new LLenarComponentesGenericos2();
            AddOwnedForm(abrir);
            abrir.TxtComponetesGenericosFrom.Text = TxtComponetes.Text;
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
            abrir.TxtContenidosCompetenciasFrom.Text = TxtContenidos.Text;
            abrir.ShowDialog();
        }

        private void ExMecanismoEvaluacion_Click(object sender, EventArgs e)
        {
            LLenarMecanismoEvaluacion2 abrir = new LLenarMecanismoEvaluacion2();
            AddOwnedForm(abrir);
            abrir.TxtMecanismoEvaluacionFrom.Text = TxtMecanismoEvaluacion.Text;
            abrir.ShowDialog();
        }

        private void ExReferenciasBibliograficas_Click(object sender, EventArgs e)
        {
            LLenarReferenciasBibliograficas2 abrir = new LLenarReferenciasBibliograficas2();
            AddOwnedForm(abrir);
            abrir.TxtReferenciasBibliograficasFrom.Text = TxtReferenciasBibliograficas.Text;
            abrir.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TxtDescripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtJustificacion_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
