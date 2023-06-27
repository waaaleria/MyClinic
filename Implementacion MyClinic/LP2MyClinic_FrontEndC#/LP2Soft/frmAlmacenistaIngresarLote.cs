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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LP2Soft
{
    public partial class frmAlmacenistaIngresarLote : Form
    {
        private Estado _estado;
        private MedicinaWSClient daoMedicina;
        private medicamento medicamentoNuevo;
        private inventario inventarieo;
        private inventario inventarioSeleccionado;
        private medicamento medicamentoContenido;
        public frmAlmacenistaIngresarLote()
        {
            InitializeComponent();
            _estado = Estado.Inicial;
            daoMedicina = new MedicinaWSClient();
            medicamentoNuevo = new medicamento();
            inventarieo = new inventario();
            medicamentoContenido = new medicamento();
            inventarieo.medicamento = medicamentoContenido;
            cboNombreComercial.DataSource = daoMedicina.listarMedicinasTodasParaAlmacenista();
            cboNombreComercial.DisplayMember = "nombreComercial";
            cboNombreComercial.ValueMember = "idMedicamento";
            dgvLote.AutoGenerateColumns = false;
            dgvLote.DataSource = daoMedicina.listarInventario();            
            establecerEstadoComponentes();           
        }
        public void establecerEstadoComponentes()
        {
            switch (this._estado)
            {
                case Estado.Inicial:
                    dtpFechaIngreso.Enabled = true;
                    dtpFechaCaducidad.Enabled = true;
                    cboNombreComercial.Enabled = true;
                    textCantidad.Enabled = true;
                    buttonAgregarInventario.Enabled = true;
                    btnEliminarLote.Enabled = true;
                    break;

            }
        }



        private void button2_Click(object sender, EventArgs e)
        {
            frmIngresarMedicina formIngresar = new frmIngresarMedicina(medicamentoNuevo);
            if (formIngresar.ShowDialog() == DialogResult.OK)
            {
                cboNombreComercial.DataSource = daoMedicina.listarMedicinasTodasParaAlmacenista();
                cboNombreComercial.Refresh();
                cboNombreComercial.SelectedIndex = cboNombreComercial.Items.Count - 1;
                cboNombreComercial.Select(cboNombreComercial.SelectedIndex, 0);
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
            dtpFechaIngreso.Value = DateTime.Now;
            dtpFechaCaducidad.Value = DateTime.Now;
            cboNombreComercial.Text = "";
            textCantidad.Text = "";
            establecerEstadoComponentes();
        }

        private void dgvLote_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            inventario inventario = (inventario)dgvLote.Rows[e.RowIndex].DataBoundItem;
            dgvLote.Rows[e.RowIndex].Cells[0].Value = inventario.medicamento.nombreComercial.ToString();
            dgvLote.Rows[e.RowIndex].Cells[1].Value = inventario.codigoLote;
            dgvLote.Rows[e.RowIndex].Cells[2].Value = inventario.fechaCaducidad.ToString("dd-MM-yyyy");
            dgvLote.Rows[e.RowIndex].Cells[3].Value = inventario.fechaIngreso.ToString("dd-MM-yyyy");
        }

        private void buttonAgregarInventario_Click(object sender, EventArgs e)
        {
            inventarieo.medicamento.idMedicamento = (int)cboNombreComercial.SelectedValue;
            inventarieo.fechaCaducidad = dtpFechaCaducidad.Value;
            inventarieo.fechaCaducidadSpecified = true;
            inventarieo.fechaIngreso = dtpFechaIngreso.Value;
            inventarieo.fechaIngresoSpecified = true;
            if (inventarieo.fechaIngreso>=inventarieo.fechaCaducidad)
            {
                MessageBox.Show("La fecha de ingreso no puede ser mayor que la fecha de caducidad", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            inventarieo.stock = int.Parse(textCantidad.Text);
            daoMedicina.insertarInventario(inventarieo);           
            dgvLote.DataSource = daoMedicina.listarInventario();
            dgvLote.Refresh();
        }

        private void btnEliminarLote_Click(object sender, EventArgs e)
        {
            inventarioSeleccionado = (inventario)dgvLote.CurrentRow.DataBoundItem;
            daoMedicina.eliminarInventario(inventarioSeleccionado);
            dgvLote.DataSource = daoMedicina.listarInventario();
            dgvLote.Refresh();
        }
    }
 }
