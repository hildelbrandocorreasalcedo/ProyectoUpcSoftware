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
    public partial class LLenarReferenciasBibliograficas2 : Form
    {
        public LLenarReferenciasBibliograficas2()
        {
            InitializeComponent();
        }

        private void BtVolverLLenado_Click(object sender, EventArgs e)
        {
            SolicitudActualizacionDocentes abrir = Owner as SolicitudActualizacionDocentes;
            abrir.TxtReferenciasBibliograficas.Text = TxtReferenciasBibliograficasFrom.Text;
            this.Hide();
        }

        private void BtVolver_Click(object sender, EventArgs e)
        {
            ActualizacionPlanAsignatura abrir = Owner as ActualizacionPlanAsignatura;
            abrir.TxtReferenciaBibliografica.Text = TxtReferenciasBibliograficasFrom.Text;
            this.Hide();
        }
    }
}
