﻿using System;
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
    public partial class LLenarObjetivoEspecifico : Form
    {
        public LLenarObjetivoEspecifico()
        {
            InitializeComponent();
        }

        private void BtVolverLLenado_Click(object sender, EventArgs e)
        {
            RegistroPlanAsignaturas abrir = Owner as RegistroPlanAsignaturas;
            abrir.TxtObjetivoEspecifico.Text =TxtOjetivosEspecificosFrom.Text;
            this.Hide();
        }

        private void BtVolver_Click(object sender, EventArgs e)
        {
            ConsultarPlanAsignatura abrir1 = Owner as ConsultarPlanAsignatura;
            abrir1.TxtObjetivoEspecifico.Text = TxtOjetivosEspecificosFrom.Text;
            this.Hide();
        }
    }
}
