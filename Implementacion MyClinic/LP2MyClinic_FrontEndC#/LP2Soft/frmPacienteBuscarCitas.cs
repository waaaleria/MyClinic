using LP2Soft.AtencionMedicaWS;
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
    
    public partial class frmPacienteBuscarCitas : Form
    {
        private AtencionMedicaWSClient daoAtencionMedica= new AtencionMedicaWSClient() ;
        public citaMedica citaMedicaSeleccionada;
        int idusuarioSelec;

        public citaMedica CitaMedicaSeleccionada { get => citaMedicaSeleccionada; set => citaMedicaSeleccionada = value; }

        public frmPacienteBuscarCitas(int idUsuarioSeleccionado)
        {
            idusuarioSelec= idUsuarioSeleccionado;
            InitializeComponent();
            dtpFechaBusqIni.Value = DateTime.Now;
            dtpFechaBusqFin.Value = DateTime.Now;
            dtpFechaBusqFin.Enabled = true;
            dgvHorarios.AutoGenerateColumns = false;
        }

        private void dtpFechaBusqIni_ValueChanged(object sender, EventArgs e)
        {
            
            dtpFechaBusqFin.Enabled = true;
            dtpFechaBusqFin.Value = dtpFechaBusqIni.Value;

        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            if (dgvHorarios.CurrentRow.Index != -1)
            {
                citaMedicaSeleccionada = (AtencionMedicaWS.citaMedica)dgvHorarios.CurrentRow.DataBoundItem;
                this.DialogResult = DialogResult.OK;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            citaMedica citas = new citaMedica();
            citaMedica citas2 = new citaMedica();
            citas.fecha = dtpFechaBusqIni.Value;
            citas.fechaSpecified=true;
            citas2.fecha = dtpFechaBusqFin.Value;
            citas2.fechaSpecified=true;
            if (citas.fecha >= citas2.fecha)
            {
                MessageBox.Show("La fecha de ingreso no puede ser mayor que la fecha de fin", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            AtencionMedicaWS.citaMedica[] citasMedicas = daoAtencionMedica.ListarHorarioPacienteFechaIniFinal(idusuarioSelec,citas.fecha,citas2.fecha);
            if (citasMedicas != null)
            {
                dgvHorarios.DataSource = citasMedicas.ToList();
            }
        }

        private void dgvOrdenesVenta_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            
            AtencionMedicaWS.citaMedica cita = (AtencionMedicaWS.citaMedica)dgvHorarios.Rows[e.RowIndex].DataBoundItem;
            string fechaFormateada = cita.programa.fecha.ToString("dd/MM/yyyy");
            dgvHorarios.Rows[e.RowIndex].Cells[0].Value = fechaFormateada;
            dgvHorarios.Rows[e.RowIndex].Cells[1].Value = cita.programa.hora_inicio;
            dgvHorarios.Rows[e.RowIndex].Cells[2].Value = cita.programa.hora_fin;
            dgvHorarios.Rows[e.RowIndex].Cells[3].Value = cita.nombreMedico;
        }
    }
}
