using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LP2Soft
{
    public partial class frmHistorialPaciente : Form
    {
        public frmHistorialPaciente()
        {
            InitializeComponent();
            dtpFechaBusqIni.Value = DateTime.Now;
            dtpFechaBusqFin.Value = DateTime.Now;
            dtpFechaBusqFin.Enabled = false;
        }

        private void dtpFechaBusqIni_ValueChanged(object sender, EventArgs e)
        {
            dtpFechaBusqFin.Enabled = true;
            dtpFechaBusqFin.Value = dtpFechaBusqIni.Value;
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            //frmPacienteDetalleCita formDetalleCita = new frmPacienteDetalleCita();
            //this.Hide();
            //formDetalleCita.Show();
        }

        private void frmPacienteHistoricoCitas_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }
    }
}
