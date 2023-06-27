using LP2Soft.AtencionMedicaWS;
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
    public partial class frmEliminarCitaPaciente : Form
    {
        private AtencionMedicaWSClient daoAtencionMedica = new AtencionMedicaWSClient();
        public citaMedica citaMedicaSeleccionada;
        private citaMedica citSeleccionada;
        int idusuarioSelec;
        public frmEliminarCitaPaciente(int idUsuarioSeleccionado)
        {
            InitializeComponent();
            idusuarioSelec = idUsuarioSeleccionado;
        }

        private void btnMantenimientoLote_Click(object sender, EventArgs e)
        {
            citaMedica citas = new citaMedica();
            citaMedica citas2 = new citaMedica();
            citas.fecha = dtpFechaBusqIni.Value;
            citas.fechaSpecified = true;
            citas2.fecha = dtpFechaBusqFin.Value;
            citas2.fechaSpecified = true;
            if (citas.fecha >= citas2.fecha)
            {
                MessageBox.Show("La fecha de ingreso no puede ser mayor que la fecha de caducidad", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            AtencionMedicaWS.citaMedica[] citasMedicas = daoAtencionMedica.ListarHorarioPacienteFechaIniFinal(idusuarioSelec, citas.fecha, citas2.fecha);
            if (citasMedicas != null)
            {
                dgvHorarios.DataSource = citasMedicas.ToList();
            }
        }

        private void dgvHorarios_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            AtencionMedicaWS.citaMedica cita = (AtencionMedicaWS.citaMedica)dgvHorarios.Rows[e.RowIndex].DataBoundItem;
            string fechaFormateada = cita.programa.fecha.ToString("dd/MM/yyyy");
            dgvHorarios.Rows[e.RowIndex].Cells[0].Value = fechaFormateada;
            dgvHorarios.Rows[e.RowIndex].Cells[1].Value = cita.programa.hora_inicio;
            dgvHorarios.Rows[e.RowIndex].Cells[2].Value = cita.programa.hora_fin;
            dgvHorarios.Rows[e.RowIndex].Cells[3].Value = cita.nombreMedico;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            citaMedica citas = new citaMedica();
            citaMedica citas2 = new citaMedica();
            citas.fecha = dtpFechaBusqIni.Value;
            citas.fechaSpecified = true;
            citas2.fecha = dtpFechaBusqFin.Value;
            citas2.fechaSpecified = true;
            citSeleccionada = (citaMedica)dgvHorarios.CurrentRow.DataBoundItem;
            daoAtencionMedica.eliminarCitaMedica(citSeleccionada.idCita);
            dgvHorarios.DataSource = daoAtencionMedica.ListarHorarioPacienteFechaIniFinal(idusuarioSelec, citas.fecha, citas2.fecha);
            dgvHorarios.Refresh();
        }
    }
}
