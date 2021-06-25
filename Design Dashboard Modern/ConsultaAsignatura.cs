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
    public partial class ConsultaAsignatura : Form
    {
        UpcService upcService = new UpcService();
        public ConsultaAsignatura()
        {
            InitializeComponent();
        }

        

        private void BtConsultar_Click(object sender, EventArgs e)
        {
            //DtgAsignatura.Rows.Clear();
            //VaciarTextBox();
            //var filtrado = TxtCodigo.Text;
            //if (filtrado.Equals(""))
            //{
            //    var respuesta = upcService.ConsultaVaciaBuscarDtg();
            //    MessageBox.Show(respuesta.Message);
            //}
            //else
            //{
            //    BuscarDtg();
            //}
        }
    }
}
