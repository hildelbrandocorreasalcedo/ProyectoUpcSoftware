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
    public partial class LLenarObjetivoEspecifico2 : Form
    {
        public LLenarObjetivoEspecifico2()
        {
            InitializeComponent();
        }

        private void BtVolverLLenado_Click(object sender, EventArgs e)
        {
            SolicitudActualizacionDocentes abrir = Owner as SolicitudActualizacionDocentes;
            abrir.TxtObjetivosEspecificos.Text = TxtOjetivosEspecificosFrom.Text;
            this.Hide();
        }

        private void BtVolver_Click(object sender, EventArgs e)
        {
            ActualizacionPlanAsignatura abrir = Owner as ActualizacionPlanAsignatura;
            abrir.TxtObjetivoEspecifico.Text = TxtOjetivosEspecificosFrom.Text;
            this.Hide();
        }
    }
}
