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
    public partial class frmBusquedaMedico : Form
    {

        private UsuarioWSClient daoUsuario;
        private medico medicoSeleccionado;

        public frmBusquedaMedico()
        {
            InitializeComponent();
            daoUsuario = new UsuarioWSClient();
            dgvMedicos.AutoGenerateColumns = false;
        }


        public medico MedicoSeleccionado { get => medicoSeleccionado; set => medicoSeleccionado = value; }


        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (dgvMedicos.CurrentRow != null)
            {
                medicoSeleccionado = (medico)dgvMedicos.CurrentRow.DataBoundItem;
                this.DialogResult = DialogResult.OK;
            }
        }



        private void btnBuscar_Click(object sender, EventArgs e)
        {
            medico[] medicos = daoUsuario.listarMedicosPorNombreEspecialidad(txtNombreEsp.Text);
            if (medicos != null)
                dgvMedicos.DataSource = medicos.ToList();
            else
                dgvMedicos.DataSource = null;
        }



       

        private void dgvMedicos_CellFormatting_1(object sender, DataGridViewCellFormattingEventArgs e)
        {
            medico medico = (medico)dgvMedicos.Rows[e.RowIndex].DataBoundItem;
            dgvMedicos.Rows[e.RowIndex].Cells[0].Value = medico.idMedico;
            dgvMedicos.Rows[e.RowIndex].Cells[1].Value = medico.nombre + " " + medico.apellido;
            dgvMedicos.Rows[e.RowIndex].Cells[2].Value = medico.especialidad.nombre;
        }
    }
}
