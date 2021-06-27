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
    public partial class RegistroAsignatura : Form
    {
        UpcService upcService = new UpcService();
        public RegistroAsignatura()
        {
            InitializeComponent();
        }
        private void BorrarMensajesError()
        {
            errorProvider1.SetError(TxtCodigo, "");
            errorProvider1.SetError(TxtNombre, "");
            errorProvider1.SetError(CmbCreditos, "");
            errorProvider1.SetError(CmbTipoAsignatura, "");
            errorProvider1.SetError(CmbPrograma, "");
        }

        private bool validarcampos()
        {
            bool ok = true;
            if (TxtNombre.Text == "")
            {
                ok = false;
                errorProvider1.SetError(TxtNombre, "Por Favor Ingrese los Nombre");
            }
            if (TxtCodigo.Text == "")
            {
                ok = false;
                errorProvider1.SetError(TxtCodigo, "Por Favor Ingrese el codigo");
            }
            if (CmbPrograma.Text == "")
            {
                ok = false;
                errorProvider1.SetError(CmbPrograma, "Este Campo Es Obligatorio");
            }
            if (CmbCreditos.Text == "")
            {
                ok = false;
                errorProvider1.SetError(CmbCreditos, "Este Campo Es Obligatorio");
            }
            if (CmbTipoAsignatura.Text == "")
            {
                ok = false;
                errorProvider1.SetError(CmbTipoAsignatura, "Este Campo Es Obligatorio");
            }
            return ok;
        }
        private void BorrarMensajesErrorCodigo()
        {
            errorProvider1.SetError(TxtCodigo, "");
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void RegistroAsignatura_Load(object sender, EventArgs e)
        {

        }

        private void bunifuGradientPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtRegistrar_Click(object sender, EventArgs e)
        {
            
            if (validarcampos())
            {
                BorrarMensajesError();
                int numero;
                if (!int.TryParse(TxtCodigo.Text, out numero))
                {
                    errorProvider1.SetError(TxtCodigo, "Ingrese Solo Numeros");
                }
                else
                {
                    Asignaturas asignatura = MapearAsignatura();
                    string mensaje = upcService.GuardarAsignatura(asignatura);
                    MessageBox.Show(mensaje, "Informacion de Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);                  
                    LimpiarTxt();
                }             
            }
            else { MessageBox.Show("Debe llenar todos los campos", "Informacion de Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }
        
        private Asignaturas MapearAsignatura()
        {
            Asignaturas asignatura = new Asignaturas();
            asignatura.Codigo = TxtCodigo.Text;
            asignatura.Nombre = TxtNombre.Text;
            asignatura.Programa = CmbPrograma.Text;
            asignatura.TipoAsignatura = CmbTipoAsignatura.Text;
            asignatura.Creditos = int.Parse(CmbCreditos.Text);        
            return asignatura;
        }

        private void BtLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarTxt();
        }
        private void LimpiarTxt()
        {
            TxtCodigo.Text = "";
            TxtNombre.Text = "";
            CmbPrograma.Text = "";           
            CmbTipoAsignatura.Text = "";
            CmbCreditos.Text = "";
        }

        private void BtConsultar_Click(object sender, EventArgs e)
        {
            string codigo = TxtCodigo.Text;
            if (codigo != "")
            {
                RespuestaBusqueda respuesta = upcService.BuscarAsignatura(codigo);

                if (respuesta.Asignatura != null)
                {
                    Asignaturas asignatura = respuesta.Asignatura;
                    TxtNombre.Text = asignatura.Nombre;
                    CmbPrograma.Text = asignatura.Programa;                 
                    CmbTipoAsignatura.Text = asignatura.TipoAsignatura;
                    CmbCreditos.Text = asignatura.Creditos.ToString();
                    MessageBox.Show(respuesta.Mensaje, "Informacion de Consulta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(respuesta.Mensaje, "Informacion de Consulta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("digite el codigo a buscar", "Informacion de Consulta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtEliminar_Click(object sender, EventArgs e)
        {
            BorrarMensajesErrorCodigo();
            if (validarcampos())
            {
                string codigo = TxtCodigo.Text;
                if (codigo != "")
                {
                    RespuestaBusqueda respuesta = upcService.BuscarAsignatura(codigo);
                    if (respuesta.Asignatura != null)
                    {
                        codigo = TxtCodigo.Text;
                        var mensaje = upcService.EliminarAsignatura(codigo);
                        MessageBox.Show(mensaje, "Asignatura ELiminada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                    }
                    else
                    {
                        MessageBox.Show($"La asignatura con el codigo {codigo} no se encuentra registrada", "Informacion de Eliminacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                LimpiarTxt();
            }
        }

        private void BtModificar_Click(object sender, EventArgs e)
        {
            BorrarMensajesError();
            if (validarcampos())
            {
                if (TxtCodigo.Text != "" && TxtNombre.Text != "" && CmbTipoAsignatura.Text != "" && CmbCreditos.Text != "")
                {
                    Asignaturas codigo = MapearAsignatura();
                    string mensaje = upcService.ModificarAsignatura(codigo);
                    MessageBox.Show(mensaje);
                }
                else
                {
                    MessageBox.Show("rectifique los campos", "Informacion de Modificacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                LimpiarTxt();
            }
        }

        private void BtCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void TxtCodigo_TextChanged(object sender, EventArgs e)
        {
            int numero;
            if (!int.TryParse(TxtCodigo.Text, out numero))
            {
                errorProvider1.SetError(TxtCodigo, "Ingrese Solo Numeros");
            }
            else
            {
                errorProvider1.SetError(TxtCodigo, "");
            }
        }

        private void TxtNombre_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(TxtNombre, "");
        }

        private void CmbCreditos_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(CmbCreditos, "");
        }

        private void CmbTipoAsignatura_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void CmbTipoAsignatura_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            errorProvider1.SetError(CmbTipoAsignatura, "");
        }

        private void CmbPrograma_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(CmbPrograma, "");
        }
    }
}
