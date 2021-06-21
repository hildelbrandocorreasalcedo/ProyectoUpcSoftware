using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using ProyectoHotelPensionados;

namespace Design_Dashboard_Modern
{
    public partial class Login : Form
    {
        int Contador = 0;
        public Login()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private Form activeForm = null;
        private void Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Minimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (TxtUsuario.Text == "Usuario" && TxtContraseña.Text == "Contraseña")
            {
                MessageBox.Show("Faltan llenar Completar Campos");
            }
            else
            {
                ///Docente
                if ((TxtUsuario.Text == "Docente") && (TxtContraseña.Text == "docente123"))
                {
                    MenuUpcDocente abrir = new MenuUpcDocente();
                    abrir.Show();
                    this.Hide();
                }
                else
                if ((TxtUsuario.Text == "Comite curricular") && (TxtContraseña.Text == "comite123"))
                {
                    MenuUpcComite abrir = new MenuUpcComite();
                    abrir.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Datos Incorrectos");
                    Contador += 1;
                    
                }
            }
            if (Contador>2)
            {
                MessageBox.Show("Se ha equivocado 3 veces, el programa se cerra, por razones de seguridad");
                Application.Exit();
            }
        }
        
        private void txtUsusario_Enter(object sender, EventArgs e)
        {
            if (TxtUsuario.Text == "Usuario")
            {
                TxtUsuario.Text = "";
                TxtUsuario.ForeColor = Color.WhiteSmoke;
            }
        }

        private void txtUsusario_Leave(object sender, EventArgs e)
        {
            if (TxtUsuario.Text == "")
            {
                TxtUsuario.Text = "Usuario";
                TxtUsuario.ForeColor = Color.LightGray;
            }
        }

        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            if (TxtContraseña.Text == "Contraseña")
            {
                TxtContraseña.Text = "";
                TxtContraseña.ForeColor = Color.WhiteSmoke;
                TxtContraseña.UseSystemPasswordChar = true;
            }
        }

        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            if (TxtContraseña.Text == "")
            {
                TxtContraseña.Text = "Contraseña";
                TxtContraseña.ForeColor = Color.LightGray;
                TxtContraseña.UseSystemPasswordChar = false;
            }
        }

        private void TxtUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
