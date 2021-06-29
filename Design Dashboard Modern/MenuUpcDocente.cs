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
using Design_Dashboard_Modern;

namespace ProyectoHotelPensionados
{
    public partial class MenuUpcDocente : Form
    {
        public MenuUpcDocente()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            PanelHijo.Controls.Add(childForm);
            PanelHijo.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        private void Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Minimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Maximizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            Maximizar.Visible = false;
            Restaurar.Visible = true;
        }

        private void Restaurar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            Restaurar.Visible = false;
            Maximizar.Visible = true;
        }

        private void MenuSidebar_Click(object sender, EventArgs e)
        {
            if(Sidebar.Width == 250)
            {
                Sidebar.Visible = false;
                Sidebar.Width = 68;
                SidebarWrapper.Width = 90;
                LineaSidebar.Width = 52;
                AnimacionSidebar.Show(Sidebar);
            }
            else
            {
                Sidebar.Visible = false;
                Sidebar.Width = 250;
                SidebarWrapper.Width = 280;
                LineaSidebar.Width = 252;
                AnimacionSidebarBack.Show(Sidebar);
            }
        }

        private void Temporizador_Tick(object sender, EventArgs e)
        {
            Temporizador.Stop();           
        }

        private void MenuTop_Paint(object sender, PaintEventArgs e)
        {
        }

        private void Grafico_Click(object sender, EventArgs e)
        {
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
        }

        private void PanelChart_Paint(object sender, PaintEventArgs e)
        {
        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void SidebarWrapper_Paint(object sender, PaintEventArgs e)
        {
        }

        private void BtGenerarFactura_Click(object sender, EventArgs e)
        {
            openChildForm(new ActualizacionPlanAsignatura());
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void BtHabitaciones_Click(object sender, EventArgs e)
        {
        }

        private void BtGestionarGanancias_Click(object sender, EventArgs e)
        {
        }

        private void BTPensionados_Click(object sender, EventArgs e)
        {
        }

        private void Maximizar_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            Maximizar.Visible = false;
            Restaurar.Visible = true;
        }

        private void Minimizar_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Salir_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtConsultarPlanAsignatura_Click(object sender, EventArgs e)
        {
        }

        private void BtConsultarAsignatura_Click(object sender, EventArgs e)
        {
            openChildForm(new ConsultaAsignatura());
        }

        private void BtConsultarDocente_Click(object sender, EventArgs e)
        {
            openChildForm(new ConsultaDocente());
        }

        private void BtConsultarPlanAsignatura_Click_1(object sender, EventArgs e)
        {
            openChildForm(new ConsultarPlanAsignatura());
        }

        private void BtRegistrarSolicitudActualizacionPlan_Click(object sender, EventArgs e)
        {
            openChildForm(new SolicitudActualizacionDocentes());
        }

        private void BtConsultarRespuestaComite_Click(object sender, EventArgs e)
        {
            openChildForm(new RevisionesSolicitudesDocente());
        }

        private void Minimizar_Click_2(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Maximizar_Click_2(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            Maximizar.Visible = false;
            Restaurar.Visible = true;
        }

        private void Salir_Click_2(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Restaurar_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            Restaurar.Visible = false;
            Maximizar.Visible = true;
        }

        private void MenuSidebar_Click_1(object sender, EventArgs e)
        {
            if (Sidebar.Width == 260)
            {
                Sidebar.Visible = false;
                Sidebar.Width = 68;
                SidebarWrapper.Width = 90;
                LineaSidebar.Width = 54;
                AnimacionSidebar.Show(Sidebar);
            }
            else
            {
                Sidebar.Visible = false;
                Sidebar.Width = 260;
                SidebarWrapper.Width = 280;
                LineaSidebar.Width = 245;
                AnimacionSidebarBack.Show(Sidebar);
            }
        }
    }
}
