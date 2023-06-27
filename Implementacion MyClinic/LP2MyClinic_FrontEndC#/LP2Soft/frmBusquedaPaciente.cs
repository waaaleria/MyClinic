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
    public partial class frmBusquedaPaciente : Form
    {

        private UsuarioWSClient daoUsuario;
        private paciente pacienteSeleccionado;

        public frmBusquedaPaciente()
        {
            InitializeComponent();
            daoUsuario = new UsuarioWSClient();
            dgvPacientes.AutoGenerateColumns = false;
        }
        public paciente PacienteSeleccionado { get => pacienteSeleccionado; set => pacienteSeleccionado = value; }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            paciente[] pacientes = daoUsuario.listarPacientesPorDniNombre(txtNombreDNI.Text);
            if (pacientes != null)
                dgvPacientes.DataSource = pacientes.ToList();
            else
                dgvPacientes.DataSource = null;
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (dgvPacientes.CurrentRow != null)
            {
                pacienteSeleccionado = (paciente)dgvPacientes.CurrentRow.DataBoundItem;
                this.DialogResult = DialogResult.OK;
            }
        }

        private void dgvPacientes_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            paciente data = dgvPacientes.Rows[e.RowIndex].DataBoundItem as paciente;
            dgvPacientes.Rows[e.RowIndex].Cells[0].Value = data.dni;
            dgvPacientes.Rows[e.RowIndex].Cells[1].Value = data.nombre + " " + data.apellido;
        }
    }
}
