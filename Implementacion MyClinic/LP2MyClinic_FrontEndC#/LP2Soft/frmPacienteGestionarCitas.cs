using LP2Soft.AtencionMedicaWS;
using LP2Soft.ItinerarioWS;
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
    public partial class frmPacienteGestionarCitas : Form
    {
        int idMedicoSeleccionado;
        int idMedicoSeleccionado2;
        int idProgramaguardado; //NUEVO CAMBIO DANNY reserva cita
        int idUsuarioSeleccionado;//NUEVO CAMBIO DANNY reserva cita
        private int idProgramaSeleccionado;
        DateTime FechaSelecionada = new DateTime();
        //DateTime FechaSeleccionada = new DateTime;
        private usuario usuarioLogeado;
        private UsuarioWSClient daoUsuario;
        private especialidad especialidadseleccionada;
        private UsuarioWS.programaAtencion programaAtencion;
        private ItinerarioWSClient daoItinerario = new ItinerarioWSClient(); //NUEVO CAMBIO DANNY reserva cita
        private ItinerarioWS.programaAtencion programaSeleccionado; //NUEVO CAMBIO DANNY reserva cita
        private AtencionMedicaWSClient daoAtencionMedica;
        public ItinerarioWS.programaAtencion ProgramaSeleccionado { get => programaSeleccionado; set => programaSeleccionado = value; } //NUEVO CAMBIO DANNY reserva cita
        BindingList<rol> roles;
        private AtencionMedicaWS.citaMedica _cita;
        private UsuarioWS.usuario _paciente;
        private UsuarioWS.usuario _usuario;
        private Estado _estado;
        public frmPacienteGestionarCitas(usuario usuarioLogeado)
        {
            InitializeComponent();
            
            this.usuarioLogeado = usuarioLogeado;
            idUsuarioSeleccionado=usuarioLogeado.idUsuario;//NUEVO CAMBIO DANNY reserva cita
            daoUsuario = new UsuarioWSClient();
            _estado = Estado.Inicial;
            dgvProgramaAtencion.AutoGenerateColumns = false; //NUEVO CAMBIO DANNY reserva cita
            daoAtencionMedica = new AtencionMedicaWSClient(); //NUEVO CAMBIO DANNY reserva cita
            establecerEstadoComponentes();


            _cita = new AtencionMedicaWS.citaMedica();
            _paciente = new UsuarioWS.usuario();
            _usuario= new UsuarioWS.usuario();

            //LISTA ESPECIALIDAD
            
            cboEspecialidad.Text = string.Empty;
            cboEspecialidad.SelectedText= "Seleccione una especialidad";
            cboMedico.SelectedText = "Seleccione una medico";
            cboEspecialidad.DisplayMember = "nombre";
            cboEspecialidad.ValueMember = "idEspecialidad";
            cboMedico.DisplayMember = "nombre";
            cboMedico.ValueMember = "idMedico";
            cboEspecialidad.DataSource = daoUsuario.listarEspecialidadesTodas().ToList();
            cboEspecialidad.Text = "";
            cboMedico.Text = "";
            programaAtencion = new UsuarioWS.programaAtencion();

            roles = new BindingList<rol>(daoUsuario.verificarRolesDeUsuario(usuarioLogeado.dni, usuarioLogeado.contraseña));
            
            foreach (var role in roles)
            {
                switch (role.idRol)
                {
                    case 1://admin
                        txtDNIPac.Enabled = false;
                        txtNombrePac.Enabled = false;
                        btnBuscarPaciente.Enabled = true;
                        break;
                    case 3://paciente
                        txtDNIPac.Text = usuarioLogeado.dni;
                        txtNombrePac.Text = usuarioLogeado.nombre + " "+usuarioLogeado.apellido;
                        txtDNIPac.Enabled = false;
                        txtNombrePac.Enabled = false;
                        btnBuscarPaciente.Enabled = false;
                        btnEliminarCita.Visible = false;
                        break;
                } 
            }  
            establecerEstadoComponentes();
        }

        public void establecerEstadoComponentes()
        {
            switch (this._estado)
            {
                case Estado.Inicial:
                    btnReservarCita.Enabled = true;
                    btnModificarCita.Enabled = true;   
                    btnCancelarReserva.Enabled = true;
                    dtpFechaHorario.Enabled = false;
                    cboEspecialidad.Enabled = false;
                    cboMedico.Enabled = false;
                    cboEspecialidad.Text = string.Empty;
                    cboMedico.Text = string.Empty;
                    btnCancelarReserva.Enabled= false;
                    dgvProgramaAtencion.DataSource = null;//NUEVO CAMBIO DANNY reserva cita
                    break;
                case Estado.Nuevo:              
                    
                    btnReservarCita.Enabled = false;
                    btnModificarCita.Enabled = false;  
                    btnCancelarReserva.Enabled = true;
                    dtpFechaHorario.Enabled = true;
                    cboMedico.Enabled = true;
                    cboEspecialidad.Enabled = true;
                    dgvProgramaAtencion.DataSource = null;//NUEVO CAMBIO DANNY reserva cita
                    break;

                case Estado.BuscarMedico:
                    btnReservarCita.Enabled = false;
                    btnModificarCita.Enabled = false;   
                    btnCancelarReserva.Enabled = true;
                    dtpFechaHorario.Enabled = true;
                    
                    break;
                case Estado.BuscarCita:
                    btnReservarCita.Enabled = false;
                    btnModificarCita.Enabled = false;
                    btnCancelarReserva.Enabled = true;
                    dtpFechaHorario.Enabled = false;
                    
                    break;

            }
        }

        private void buttonMedico_Click(object sender, EventArgs e)
        {
            frmBusquedaMedico formBusqMedico = new frmBusquedaMedico();
            //this.Hide();
            //formBusqMedico.Show();
            if (formBusqMedico.ShowDialog() == DialogResult.OK)
            {   

            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            _estado = Estado.Nuevo;
            establecerEstadoComponentes();
           
        }
        //NUEVO CAMBIO DANNY reserva cita SE ELIMINO btnGuardar_Click

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiarComponentes();
            _estado = Estado.Inicial;
            establecerEstadoComponentes();
        }
        public void limpiarComponentes()
        {     
            cboMedico.Text = "";
            cboEspecialidad.Text = string.Empty;
            dtpFechaHorario.Value = DateTime.Now;
            
            foreach (var role in roles)
            {
                switch (role.idRol)
                {
                    case 1://admin
                        txtNombrePac.Text = string.Empty;
                        txtDNIPac.Text = string.Empty;
                        break;
                    case 3://paciente
                       //no se borra los datos del paciente
                        break;
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmPacienteBuscarCitas formBusqCita = new frmPacienteBuscarCitas(idUsuarioSeleccionado);
            
            if (formBusqCita.ShowDialog() == DialogResult.OK)
            {
                _cita= formBusqCita.citaMedicaSeleccionada;
                cboEspecialidad.Text = _cita.especialidadMedico;
                cboMedico.Text = _cita.nombreMedico;
                dtpFechaHorario.Value =_cita.programa.fecha;
                
                
            }
            _estado = Estado.BuscarCita;
            establecerEstadoComponentes();
        }

        

        private void cboEspecialidad_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cboEspecialidad.SelectedIndex != -1)
            { }

            //var idespecialidad = (int)cboEspecialidad.SelectedValue;
            int idespecialidad = cboEspecialidad.SelectedIndex;
            //especialidadseleccionada = (UsuarioWS.especialidad)cboEspecialidad.SelectedItem;
            try
            {
                cboMedico.DataSource = daoUsuario.listarMedicoXidEspecialidad(idespecialidad+1).ToList();
                

                idMedicoSeleccionado = (int)cboMedico.SelectedValue;
                cboMedico.Enabled = true;

            } catch (Exception ex) 
            { 
                cboMedico.Items.Insert(0,"No hay medicos disponibles");//NUEVO CAMBIO DANNY reserva cita
            }

        }

        //NUEVO CAMBIO DANNY reserva cita
        private void btnHorDisp_Click(object sender, EventArgs e)
        {
            FechaSelecionada = dtpFechaHorario.Value;
            ItinerarioWS.programaAtencion[] programas = daoItinerario.listarProgramaXFechaMedico(idMedicoSeleccionado, FechaSelecionada);
            if (programas != null)
            {
                dgvProgramaAtencion.DataSource = programas.ToList();
            }
            else
            {
                MessageBox.Show("No tenemos horarios para ese día, por favor seleccione otra fecha", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
        //NUEVO CAMBIO DANNY reserva cita
        private void dgvProgramaAtencion_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            ItinerarioWS.programaAtencion programa = (ItinerarioWS.programaAtencion)dgvProgramaAtencion.Rows[e.RowIndex].DataBoundItem;

            for (int i = 0; i < dgvProgramaAtencion.Rows.Count; i++)
            {
                dgvProgramaAtencion.Rows[i].Cells[0].Value = (i + 1).ToString(); // Asigna el número de fila a la primera celda (columna 0)
            }
            //dgvProgramaAtencion.Rows[e.RowIndex].Cells[1].Value = programa.fecha.ToString();
            dgvProgramaAtencion.Rows[e.RowIndex].Cells[1].Value = programa.hora_inicio;
            dgvProgramaAtencion.Rows[e.RowIndex].Cells[2].Value = programa.hora_fin;
        }


        //NUEVO CAMBIO DANNY reserva cita
        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (dgvProgramaAtencion.CurrentRow.Index != -1)
            {
                programaSeleccionado = (ItinerarioWS.programaAtencion)dgvProgramaAtencion.CurrentRow.DataBoundItem;
                this.DialogResult = DialogResult.OK;
            }
            if (cboEspecialidad.Text == string.Empty)
            {
                MessageBox.Show("Debe seleccionar una especialidad", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                if(MessageBox.Show("¿Está seguro de que desea registrar esta cita?", "Mensaje de Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    int resultado = daoAtencionMedica.insertarCitaMedica(idProgramaguardado, idUsuarioSeleccionado, idMedicoSeleccionado, programaSeleccionado.idProgramaAtencion);//NUEVO CAMBIO DANNY reserva cita
                    if (resultado != 0)
                    {
                        MessageBox.Show("Se ha registrado con éxito", "Mensaje de confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        _estado = Estado.Inicial;
                        establecerEstadoComponentes();
                        dgvProgramaAtencion.DataSource = null;
                    }
                    else
                    {
                        MessageBox.Show("No se ha podido registrar", "Mensaje de confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            //NUEVO CAMBIO DANNY reserva cita YA NO EXISTE LA PANTALLA FrmPacienteBusquedaHorariosMedicos
        }

        private void btnBuscarPaciente_Click(object sender, EventArgs e)//NUEVO CAMBIO DANNY admin
        {
            frmBusquedaPaciente formBusqPac = new frmBusquedaPaciente();

            if (formBusqPac.ShowDialog() == DialogResult.OK)
            {
                _paciente = formBusqPac.PacienteSeleccionado;
                txtNombrePac.Text = _paciente.nombre + " " + _paciente.apellido;
                txtDNIPac.Text = _paciente.dni;
                idUsuarioSeleccionado  = daoUsuario.halalr_id_usuario(_paciente.dni);


            }
        }

        private void btnEliminarCita_Click(object sender, EventArgs e)
        {
            frmEliminarCitaPaciente formEliminar = new frmEliminarCitaPaciente(idUsuarioSeleccionado);

            if (formEliminar.ShowDialog() == DialogResult.OK)
            {
                //_paciente = formBusqPaciente.PacienteSeleccionado;
                //txtNombrePac.Text = _paciente.nombre + " " + _paciente.apellido;
                //txtDNIPac.Text = _paciente.dni;
                //idUsuarioSeleccionado = daoUsuario.halalr_id_usuario(_paciente.dni);

            }
        }

        private void TarjetaMedico_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmTarjetaMedico formEliminar = new frmTarjetaMedico(idMedicoSeleccionado2);

            if (formEliminar.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void cboMedico_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboEspecialidad.SelectedIndex != -1)
            { }
            idMedicoSeleccionado2 = (int)cboMedico.SelectedValue;
        }
    }

        
    
}
