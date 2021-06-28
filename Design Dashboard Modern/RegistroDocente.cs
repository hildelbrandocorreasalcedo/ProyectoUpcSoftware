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
    public partial class RegistroDocente : Form
    {
        UpcService upcService = new UpcService();
        public RegistroDocente()
        {
            InitializeComponent();
            
        }
        private void BorrarMensajesError()
        {
            errorProvider1.SetError(TxtIdentificacion, "");
            errorProvider1.SetError(TxtNombre, "");
            errorProvider1.SetError(TxtApellido, "");
            errorProvider1.SetError(TxtTelefono, "");
            errorProvider1.SetError(TxtCorreo, "");
            errorProvider1.SetError(CmbCategoria, "");
            errorProvider1.SetError(CmbAsignatura, "");
        }

        private bool validarcampos()
        {
            bool ok = true;
            if (TxtNombre.Text == "")
            {
                ok = false;
                errorProvider1.SetError(TxtNombre, "Por Favor Ingrese los Nombre");
            }
            if (TxtIdentificacion.Text == "")
            {
                ok = false;
                errorProvider1.SetError(TxtIdentificacion, "Por Favor Ingrese la Identificacion");
            }
            if (TxtApellido.Text == "")
            {
                ok = false;
                errorProvider1.SetError(TxtApellido, "Por Favor Ingrese el apellido");
            }
            if (TxtTelefono.Text == "")
            {
                ok = false;
                errorProvider1.SetError(TxtTelefono, "Por Favor Ingrese el telefono");
            }
            if (TxtCorreo.Text == "")
            {
                ok = false;
                errorProvider1.SetError(TxtCorreo, "Por Favor Ingrese el correo");
            }
            if (CmbCategoria.Text == "")
            {
                ok = false;
                errorProvider1.SetError(CmbCategoria, "Este Campo Es Obligatorio");
            }
            if (CmbAsignatura.Text == "")
            {
                ok = false;
                errorProvider1.SetError(CmbAsignatura, "Este Campo Es Obligatorio");
            }
            return ok;
        }
        private void BorrarMensajesErrorIdentificacion()
        {
            errorProvider1.SetError(TxtIdentificacion, "");
        }
        private void RegistroDocente_Load(object sender, EventArgs e)
        {
            var response = upcService.ConsultarTodosAsignaturasDtg();
            CmbAsignatura.Items.Insert(0, "");
            foreach (var item in response.Asignatura)
            {
                CmbAsignatura.Items.Insert(1, item.Nombre);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

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
                }if(!int.TryParse(TxtTelefono.Text, out numero))
                {
                    errorProvider1.SetError(TxtTelefono, "Ingrese Solo Numeros");
                }
                else
                {
                    Docentes docente = MapearDocente();
                    string mensaje = upcService.GuardarDocente(docente);
                    MessageBox.Show(mensaje, "Informacion de Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarTxt();
                }
            }
            else { MessageBox.Show("Debe llenar todos los campos", "Informacion de Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }
        private Docentes MapearDocente()
        {
            Docentes docente = new Docentes();
            docente.Identificacion = TxtIdentificacion.Text;
            docente.Nombre = TxtNombre.Text;
            docente.Apellido = TxtApellido.Text;
            docente.Telefono = TxtTelefono.Text;
            docente.Correo = TxtCorreo.Text;
            docente.Categoria = CmbCategoria.Text;
            docente.Materia = CmbAsignatura.Text;
            return docente;
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
                    TxtTelefono.Text = docente.Telefono;
                    TxtCorreo.Text = docente.Correo;
                    CmbCategoria.Text = docente.Categoria;
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
            TxtTelefono.Text = "";
            TxtCorreo.Text = "";
            CmbCategoria.Text = "";
            CmbAsignatura.Text = "";
        }

        private void BtEliminar_Click(object sender, EventArgs e)
        {
            BorrarMensajesErrorIdentificacion();
            if (validarcampos())
            {
                string identificacion = TxtIdentificacion.Text;
                if (identificacion != "")
                {
                    RespuestaBusqueda respuesta = upcService.BuscarDocente(identificacion);
                    if (respuesta.Docente != null)
                    {
                        identificacion = TxtIdentificacion.Text;
                        var mensaje = upcService.EliminarDocente(identificacion);
                        MessageBox.Show(mensaje, "Docente ELiminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show($"El docente con la identificacion {identificacion} no se encuentra registrado", "Informacion de Eliminacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                if (TxtIdentificacion.Text != "" && TxtNombre.Text != "" && TxtApellido.Text != "" && TxtTelefono.Text != ""
                    && TxtCorreo.Text != "" && CmbCategoria.Text != "" && CmbAsignatura.Text != "")
                {
                    Docentes identificacion = MapearDocente();
                    string mensaje = upcService.ModificarDocente(identificacion);
                    MessageBox.Show(mensaje, "Informacion de Modificacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("rectifique los campos", "Informacion de Modificacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                LimpiarTxt();
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

        private void TxtNombre_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(TxtNombre, "");
        }

        private void TxtApellido_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(TxtApellido, "");
        }

        private void TxtTelefono_TextChanged(object sender, EventArgs e)
        {
            int numero1;
            if (!int.TryParse(TxtTelefono.Text, out numero1))
            {
                errorProvider1.SetError(TxtTelefono, "Ingrese Solo Numeros");
            }
            else
            {
                errorProvider1.SetError(TxtTelefono, "");
            }
        }

        private void TxtCorreo_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(TxtCorreo, "");
        }

        private void CmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(CmbCategoria, "");
        }

        private void CmbAsignatura_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(CmbAsignatura, "");

        }

        private void BtCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
