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


namespace Design_Dashboard_Modern
{
    public partial class MenuUpcComite : Form
    {
        public MenuUpcComite()
        {
            InitializeComponent();
            customizeDesing();
        }
        private void customizeDesing()
        {
            PanelSubAsignatura.Visible = false;
            PanelSubDocente.Visible = false;
            PanelSubPlanAsignatura.Visible = false;

        }
        private void HideSubMenu()
        {
            if (PanelSubAsignatura.Visible == true)
                PanelSubAsignatura.Visible = false;

            if (PanelSubDocente.Visible == true)
                PanelSubDocente.Visible = false;

            if (PanelSubPlanAsignatura.Visible == true)
                PanelSubPlanAsignatura.Visible = false;

        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                HideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
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

        private void MenuDocente_Load(object sender, EventArgs e)
        {

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

        private void Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtRegistrarAsignatura_Click(object sender, EventArgs e)
        {
            openChildForm(new RegistroAsignatura());
        }

        private void BtConsultarAsignatura_Click(object sender, EventArgs e)
        {
            openChildForm(new ConsultaAsignatura());
        }

        private void BtRegistrarDocente_Click(object sender, EventArgs e)
        {
            openChildForm(new RegistroDocente());
        }

        private void BtConsultarDocente_Click(object sender, EventArgs e)
        {
            openChildForm(new ConsultaDocente());
        }

        private void BtRegistrarPlanAsignatura_Click(object sender, EventArgs e)
        {
            openChildForm(new RegistroPlanAsignaturas());
        }

        private void BtConsultarPlanAsignatura_Click(object sender, EventArgs e)
        {
            
            openChildForm(new SolicitudActualizacionDocentes());
        }

        private void BtRevisionesFormatoDocente_Click(object sender, EventArgs e)
        {
            openChildForm(new RevisionesSolicitudesDocente());
        }

        private void BtRespuestaFormatoDocente_Click(object sender, EventArgs e)
        {
            openChildForm(new RespuestasSolicitudes());
        }

        private void BTAsignaturas_Click(object sender, EventArgs e)
        {
            showSubMenu(PanelSubAsignatura);
        }

        private void BtDocentes_Click(object sender, EventArgs e)
        {
            showSubMenu(PanelSubDocente);
        }

        private void BtPlanAsignatura_Click(object sender, EventArgs e)
        {
            showSubMenu(PanelSubPlanAsignatura);
        }

        private void Restaurar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            Restaurar.Visible = false;
            Maximizar.Visible = true;
        }

        private void MenuSidebar_Click(object sender, EventArgs e)
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
