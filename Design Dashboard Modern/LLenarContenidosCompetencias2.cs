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
    public partial class LLenarContenidosCompetencias2 : Form
    {
        public LLenarContenidosCompetencias2()
        {
            InitializeComponent();
        }

        private void BtVolverLLenado_Click(object sender, EventArgs e)
        {
            SolicitudActualizacionDocentes abrir = Owner as SolicitudActualizacionDocentes;
            abrir.TxtContenidos.Text = TxtContenidosCompetenciasFrom.Text;
            this.Hide();
        }

        private void BtVolver_Click(object sender, EventArgs e)
        {
            ActualizacionPlanAsignatura abrir = Owner as ActualizacionPlanAsignatura;
            abrir.TxtContenido.Text = TxtContenidosCompetenciasFrom.Text;
            this.Hide();
        }
    }
}
