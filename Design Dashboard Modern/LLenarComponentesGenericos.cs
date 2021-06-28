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
    public partial class LLenarComponentesGenericos : Form
    {
        public LLenarComponentesGenericos()
        {
            InitializeComponent();
        }

        private void BtVolverLLenado_Click(object sender, EventArgs e)
        {
            RegistroPlanAsignaturas abrir = Owner as RegistroPlanAsignaturas;
            abrir.TxtComponentesGenericos.Text = TxtComponetesGenericosFrom.Text;
            this.Hide();
        }

        private void BtVolver_Click(object sender, EventArgs e)
        {
            ConsultarPlanAsignatura abrir = Owner as ConsultarPlanAsignatura;
            abrir.TxtComponentesGenericos.Text = TxtComponetesGenericosFrom.Text;
            this.Hide();
        }
    }
}
