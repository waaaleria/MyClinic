using LP2Soft.AtencionMedicaWS;
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
    public partial class FrmBibliotecaHistorialPaciente : Form
    {
        private AtencionMedicaWSClient daoAtencion;
        private UsuarioWSClient daoUsuario;
        private int id_paciente;
        private citaMedica[] arrayCitas;
        private medico[] arrayMedicos;
        private paciente[] arrayPaciente;
        private citaMedica citaMedicaSeleccionada;
        public FrmBibliotecaHistorialPaciente()
        {
            daoAtencion = new AtencionMedicaWSClient();
            daoUsuario = new UsuarioWSClient();
            InitializeComponent();
            arrayPaciente = daoUsuario.listarPacientesPorDniNombre(textBoxDNIPaciente.Text); //hallar esta vaina
            id_paciente = arrayPaciente[0].idPaciente;
        }

        private void dgvListaCitasPaciente_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dgvListaCitasPaciente.Rows.Count)
                return;

            citaMedica Cita = (citaMedica)dgvListaCitasPaciente.Rows[e.RowIndex].DataBoundItem;

            dgvListaCitasPaciente.Rows[e.RowIndex].Cells[0].Value = Cita.fecha.ToString("dd-MM-yyyy");

            if (arrayMedicos != null && e.RowIndex < arrayMedicos.Length)
            {
                medico medicoCita = arrayMedicos[e.RowIndex];
                dgvListaCitasPaciente.Rows[e.RowIndex].Cells[1].Value = medicoCita.nombre.ToString();
                dgvListaCitasPaciente.Rows[e.RowIndex].Cells[2].Value = medicoCita.especialidad.nombre.ToString();
            }

            dgvListaCitasPaciente.Rows[e.RowIndex].Cells[3].Value = "Concluida";
        }

        private void btnBuscarHistorico_Click(object sender, EventArgs e)
        {
            if(textBoxDNIPaciente.Text == "")
            {
                MessageBox.Show("Debe ingresar datos de nombre, paciente y medico", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            dgvListaCitasPaciente.AutoGenerateColumns = false;
            citaMedica citas = new citaMedica();
            citaMedica citas2 = new citaMedica();
            citas.fecha = dtpFechaBusqIni.Value;
            citas.fechaSpecified = true;
            citas2.fecha = dtpFechaFin.Value;
            citas2.fechaSpecified = true;
            if (citas.fecha >= citas2.fecha)
            {
                MessageBox.Show("La fecha de ingreso no puede ser mayor que la fecha de fin", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            arrayCitas = daoAtencion.listarCitasxPacientexFecha(id_paciente, citas.fecha, citas2.fecha);
            if (arrayCitas != null)
            {
                arrayMedicos = new medico[arrayCitas.Length];
            }
            else
            {
                MessageBox.Show("El paciente no ha tenido citas en ese rango de días", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            

            for (int i = 0; i < arrayCitas.Length; i++)
            {
                citaMedica Cita = arrayCitas[i];
                arrayMedicos[i] = daoUsuario.tomarDatosMedico(Cita.idMedico);
            }
            dgvListaCitasPaciente.DataSource = arrayCitas;
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            citaMedicaSeleccionada = (citaMedica)dgvListaCitasPaciente.CurrentRow.DataBoundItem;
            frmPacienteDetalleCita formDetalleCita = new frmPacienteDetalleCita(citaMedicaSeleccionada);
            formDetalleCita.Show();
        }
    }
}
