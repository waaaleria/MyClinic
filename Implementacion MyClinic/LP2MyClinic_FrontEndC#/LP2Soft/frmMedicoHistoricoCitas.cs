using LP2Soft.AtencionMedicaWS;
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
    public partial class frmMedicoHistoricoCitas : Form
    {

        UsuarioWSClient daoUsuario;
        medicoDTO medico;
        AtencionMedicaWSClient daoAtencion ;
        paciente pacienteSeleccionado;

        Estado _estado;

        public frmMedicoHistoricoCitas(int idUsuario)
        {
            InitializeComponent();
         
            dgvListaCitasPaciente.AutoGenerateColumns = false;
            
            daoUsuario = new UsuarioWSClient();
            daoAtencion = new AtencionMedicaWSClient();

            //Datos del medico
            medico = daoUsuario.buscarMedicoConEspecialidad(idUsuario);
            txtNombreMedico.Text = medico.nombreCompleto;
            txtEspecialidad.Text=medico.nombreEspecialidad;


            citaMedicaDto[] listaCitas = daoAtencion.listarCitasMedicoPorPacienteFechas(medico.idMedico, -1, "01-01-0001", "01-01-0001");
            BindingList<citaMedicaDto> citas;
            if (listaCitas == null) citas = new BindingList<citaMedicaDto>();
            else citas = new BindingList<citaMedicaDto>(listaCitas.ToList());

            dgvListaCitasPaciente.DataSource = citas;
            pacienteSeleccionado = new paciente();
            pacienteSeleccionado.idPaciente = -1;
        }
        
        public void limpiarComponentes()
        {
            txtNombrePaciente.Text = "";    
            dtpFechaInicial.Value = new DateTime(2023,01,01);
            dtpFechaFin.Value = new DateTime(2023, 06, 01);
        }
        
        private void btnBusquedaPacientes_Click(object sender, EventArgs e)
        {
            frmBusquedaPaciente formBusquedaPaciente = new frmBusquedaPaciente();
   

            if (formBusquedaPaciente.ShowDialog() == DialogResult.OK)
            {
                pacienteSeleccionado = formBusquedaPaciente.PacienteSeleccionado;
                txtNombrePaciente.Text = pacienteSeleccionado.nombre + " " + pacienteSeleccionado.apellido;
            }
        }

        private void btnAplicarFiltros_Click(object sender, EventArgs e)
        {
            citaMedicaDto[] listaCitas =
                daoAtencion.listarCitasMedicoPorPacienteFechas(medico.idMedico, pacienteSeleccionado.idPaciente, dtpFechaInicial.Value.ToString("dd-MM-yyyy"), dtpFechaFin.Value.ToString("dd-MM-yyyy"));
            BindingList<citaMedicaDto> citas;
            if (listaCitas == null) citas = new BindingList<citaMedicaDto>();
            else citas = new BindingList<citaMedicaDto>(listaCitas.ToList());
            dgvListaCitasPaciente.DataSource = citas;
        }

        private void btnVerDetalles_Click(object sender, EventArgs e)
        {
            citaMedicaDto citaSeleccionado = (citaMedicaDto)dgvListaCitasPaciente.CurrentRow.DataBoundItem;
            Console.WriteLine(citaSeleccionado.idCita);
            frmMedicoDetalleCita frmMedicoDetalleCita = new frmMedicoDetalleCita(citaSeleccionado,medico.nombreEspecialidad);
            if (dtpFechaInicial.Value >= dtpFechaFin.Value)
            {
                MessageBox.Show("La fecha de ingreso no puede ser mayor que la fecha de Fin", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (frmMedicoDetalleCita.ShowDialog() == DialogResult.OK)
            {
                Console.WriteLine("OK");
                citaMedicaDto[] listaCitas =
                               daoAtencion.listarCitasMedicoPorPacienteFechas(medico.idMedico, pacienteSeleccionado.idPaciente, dtpFechaInicial.Value.ToString("dd-MM-yyyy"), dtpFechaFin.Value.ToString("dd-MM-yyyy"));
                BindingList<citaMedicaDto> citas;
                if (listaCitas == null) citas = new BindingList<citaMedicaDto>();
                else citas = new BindingList<citaMedicaDto>(listaCitas.ToList());

                dgvListaCitasPaciente.DataSource = citas;
            }
        }

        private void btnReiniciarFiltro_Click(object sender, EventArgs e)
        {
            limpiarComponentes();
            pacienteSeleccionado = new paciente();
            pacienteSeleccionado.idPaciente = -1;
        }

    }
}
