using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Design_Dashboard_Modern
{
    public partial class LLenarJustificacion2 : Form
    {
        public LLenarJustificacion2()
        {
            InitializeComponent();
        }

        private void BtVolverLLenado_Click(object sender, EventArgs e)
        {
            SolicitudActualizacionDocentes abrir = Owner as SolicitudActualizacionDocentes;
            abrir.TxtJustificacion.Text = TxtJustificacionFrom.Text;
            this.Hide();
        }

        private void BtVolver_Click(object sender, EventArgs e)
        {
            ActualizacionPlanAsignatura abrir1 = Owner as ActualizacionPlanAsignatura;
            abrir1.TxtJustificacion.Text = TxtJustificacionFrom.Text;
            this.Hide();
        }
    }
}
