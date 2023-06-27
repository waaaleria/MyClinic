using LP2Soft.MedicinaWS;
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
    public partial class frmIngresarMedicina : Form
    {
        private Estado _estado;
        private MedicinaWSClient medicina;
        private medicamento medicamentoN;
        public frmIngresarMedicina(medicamento medicamentoNuevo)
        {
            InitializeComponent();
            _estado = Estado.Inicial;
            medicina = new MedicinaWSClient();
            medicamentoN = new medicamento();
            medicamentoNuevo = medicamentoN;
            establecerEstadoComponentes();
        }
        public void establecerEstadoComponentes()
        {
            switch (this._estado)
            {
                case Estado.Inicial:
                    btnNuevo.Enabled = true;
                    btnCancelar.Enabled = false;
                    txtNombreComercialMed.Enabled = false;
                    txtNombreLaboratorioMed.Enabled = false;
                    textPrecioMed.Enabled = false;
                    textBoxDescripcion.Enabled = false;
                    break;
                case Estado.Nuevo:
                    btnNuevo.Enabled = false;
                    btnCancelar.Enabled = true;
                    txtNombreComercialMed.Enabled = true;
                    txtNombreLaboratorioMed.Enabled = true;
                    textPrecioMed.Enabled = true;
                    textBoxDescripcion.Enabled = true;
                    break;

            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            _estado = Estado.Nuevo;
            establecerEstadoComponentes();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            _estado = Estado.Inicial;
            txtNombreComercialMed.Text="";
            txtNombreLaboratorioMed.Text = "";
            textPrecioMed.Text = "";
            textBoxDescripcion.Text = "";
            establecerEstadoComponentes();
        }

        private void btnAgregarMedicina_Click(object sender, EventArgs e)
        {
            medicamentoN.nombreComercial = txtNombreComercialMed.Text;
            medicamentoN.nombreLaboratorio = txtNombreLaboratorioMed.Text;
            medicamentoN.precio = float.Parse(textPrecioMed.Text);
            medicamentoN.descripcion = textBoxDescripcion.Text;
            medicina.insertarMedicamento(medicamentoN);
            this.DialogResult = DialogResult.OK;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
