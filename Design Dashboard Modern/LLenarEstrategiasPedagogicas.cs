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
    public partial class LLenarEstrategiasPedagogicas : Form
    {
        public LLenarEstrategiasPedagogicas()
        {
            InitializeComponent();
        }

        private void BtVolverLLenado_Click(object sender, EventArgs e)
        {
            RegistroPlanAsignaturas abrir = Owner as RegistroPlanAsignaturas;
            abrir.TxtEstrategias.Text = TxtEstrategiasPedagogicasFrom.Text;
            this.Hide();
        }

        private void BtVolver_Click(object sender, EventArgs e)
        {
            RespuestasSolicitudes abrir1 = Owner as RespuestasSolicitudes;
            abrir1.TxtEstrategias.Text = TxtEstrategiasPedagogicasFrom.Text;
            this.Hide();
        }
    }
}
