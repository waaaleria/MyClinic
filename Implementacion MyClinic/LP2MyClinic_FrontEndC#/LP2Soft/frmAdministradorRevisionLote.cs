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
    public partial class frmAdministradorRevisionLote : Form
    {
        private MedicinaWSClient daoMedicina;
        private inventario inventarioSeleccionado;
        public frmAdministradorRevisionLote()
        {
            InitializeComponent();
            daoMedicina = new MedicinaWSClient();
            inventarioSeleccionado = new inventario();
            dgvLote.AutoGenerateColumns = false;
        }

        private void btnMantenimientoLote_Click(object sender, EventArgs e)
        {
            inventarioSeleccionado.fechaIngreso = dtpFechaIngreso.Value;
            inventarioSeleccionado.fechaIngresoSpecified = true;
            inventarioSeleccionado.fechaCaducidad = dtpFechaFin.Value;
            inventarioSeleccionado.fechaCaducidadSpecified = true;
            if (inventarioSeleccionado.fechaIngreso >= inventarioSeleccionado.fechaCaducidad)
            {
                MessageBox.Show("La fecha de ingreso no puede ser mayor que la fecha de caducidad", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            dgvLote.DataSource = daoMedicina.listar_inventario_x_fechas(inventarioSeleccionado);
            
        }

        private void dgvLote_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            inventario inventario = (inventario)dgvLote.Rows[e.RowIndex].DataBoundItem;
            dgvLote.Rows[e.RowIndex].Cells[1].Value = inventario.codigoLote;
            dgvLote.Rows[e.RowIndex].Cells[0].Value = inventario.medicamento.nombreComercial.ToString();
            dgvLote.Rows[e.RowIndex].Cells[2].Value = inventario.fechaCaducidad.ToString("dd-MM-yyyy");
            dgvLote.Rows[e.RowIndex].Cells[3].Value = inventario.fechaIngreso.ToString("dd-MM-yyyy");
        }
    }
}
