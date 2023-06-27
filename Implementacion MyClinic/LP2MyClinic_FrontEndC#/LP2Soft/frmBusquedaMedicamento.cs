
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
    public partial class frmBusquedaMedicamento : Form
    {

        private MedicinaWSClient daoMedicinaWS;
        private medicamento medicamentoSeleccionado;

        public frmBusquedaMedicamento()
        {
            InitializeComponent();
            dgvMedicamentos.AutoGenerateColumns = false;
            daoMedicinaWS = new MedicinaWSClient();

            BindingList<medicamento> medicamentos = new BindingList<medicamento>(daoMedicinaWS.listarMedicamentosTodos().ToList());
            dgvMedicamentos.DataSource = medicamentos;

        }

        public medicamento MedicamentoSeleccionado { get => medicamentoSeleccionado; set => medicamentoSeleccionado = value; }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            medicamento[] medicamentos = daoMedicinaWS.buscarMedicamentos(txtNombreMedicamento.Text);
            if(medicamentos != null)
            {
                dgvMedicamentos.DataSource = medicamentos.ToList();
            }
            else
            {
                dgvMedicamentos.DataSource = null;
            }
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if(dgvMedicamentos != null)
            {
                medicamentoSeleccionado = (medicamento)dgvMedicamentos.CurrentRow.DataBoundItem;
                this.DialogResult = DialogResult.OK;
            }
        }

        private void dgvProductos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            medicamento medicamento = (medicamento)dgvMedicamentos.Rows[e.RowIndex].DataBoundItem;
            dgvMedicamentos.Rows[e.RowIndex].Cells[0].Value = medicamento.nombreComercial;
            dgvMedicamentos.Rows[e.RowIndex].Cells[1].Value = medicamento.nombreLaboratorio;
            dgvMedicamentos.Rows[e.RowIndex].Cells[2].Value = medicamento.descripcion;

        }


    }
}
