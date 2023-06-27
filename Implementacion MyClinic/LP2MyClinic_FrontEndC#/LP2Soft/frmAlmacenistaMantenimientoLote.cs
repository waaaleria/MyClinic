using LP2Soft.MedicinaWS;
using LP2Soft.UsuarioWS;
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
    public partial class frmAlmacenistaMantenimientoLote : Form
    {
        private MedicinaWSClient daoMedicina;
        private inventario inventarioSeleccionado;
        public frmAlmacenistaMantenimientoLote()
        {
            InitializeComponent();
            daoMedicina = new MedicinaWSClient();
            inventarioSeleccionado = new inventario();
            dgvLoteMantenimiento.AutoGenerateColumns = false;
            //usuarioLogeado.idUsuario
            dgvLoteMantenimiento.DataSource = daoMedicina.listarInventarioMantenimiento();
        }

        private void dgvLoteMantenimiento_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            inventario inventario = (inventario)dgvLoteMantenimiento.Rows[e.RowIndex].DataBoundItem;
            dgvLoteMantenimiento.Rows[e.RowIndex].Cells[0].Value = inventario.codigoLote;
            dgvLoteMantenimiento.Rows[e.RowIndex].Cells[1].Value = inventario.medicamento.nombreComercial.ToString();
            dgvLoteMantenimiento.Rows[e.RowIndex].Cells[2].Value = inventario.stock;
            dgvLoteMantenimiento.Rows[e.RowIndex].Cells[3].Value = inventario.fechaCaducidad.ToString("dd-MM-yyyy");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            inventarioSeleccionado = (inventario)dgvLoteMantenimiento.CurrentRow.DataBoundItem;
            daoMedicina.eliminarInventario(inventarioSeleccionado);
            dgvLoteMantenimiento.DataSource = daoMedicina.listarInventarioMantenimiento();
            dgvLoteMantenimiento.Refresh();
        }
    }
}
