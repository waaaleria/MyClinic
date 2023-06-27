using LP2Soft.AtencionMedicaWS;
using LP2Soft.MedicinaWS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using medicamento = LP2Soft.MedicinaWS.medicamento;

namespace LP2Soft
{
    public partial class frmMedicoDetalleCita : Form
    {
        private AtencionMedicaWSClient daoAtencionMedicaWS;
        private medicamento medicamento;

        private citaMedicaDto citaMedicaDto;
        private recetaMedicaDto recetaMedica;
        private diagnostico diagnostico;

        private BindingList<lineaRecetaDto> lineas;
        private BindingList<lineaRecetaDto> lineasRecetasNuevas;

        private BindingList<diagnostico> diagnosticos;

        private Estado _estado;

        
        public frmMedicoDetalleCita(citaMedicaDto citaSeleccionada,string nombreEspecialidad)
        {
            InitializeComponent();
            _estado = Estado.Inicial;
            establecerEstadoComponentes();
            if (citaSeleccionada.activo == 0)
            {
                btnModificarCita.Enabled = false;  
            }

            daoAtencionMedicaWS = new AtencionMedicaWSClient();

            dgvRecetaMedica.AutoGenerateColumns = false;
            dgvDiagnosticoCita.AutoGenerateColumns = false;

      
            textEspecialidadAtendida.Text = nombreEspecialidad;
            citaMedicaDto = citaSeleccionada;
            dtpFechaCita.Value = citaMedicaDto.fecha;

            txtNombrePaciente.Text = citaMedicaDto.paciente;
            txtMotivoCita.Text = citaMedicaDto.motivo;
            

            diagnostico[] listaDiagnosticos = daoAtencionMedicaWS.listarDiagnosticosPorCita(citaMedicaDto.idCita);

            if (listaDiagnosticos == null) diagnosticos = new BindingList<diagnostico>();
            else diagnosticos = new BindingList<diagnostico>(listaDiagnosticos.ToList());
            dgvDiagnosticoCita.DataSource = diagnosticos;

            recetaMedica receta = daoAtencionMedicaWS.listarRecetaMedicaPorCita(citaMedicaDto.idCita);
            if (receta.idRecetaMedica == 0) dtpVigenciaFinal.Value = DateTime.Now;
            else {
                dtpVigenciaFinal.Value = receta.vigenciaFinal;
                
            }

            lineaRecetaDto[] listalineas = daoAtencionMedicaWS.listarLineaRecetaMedica(receta.idRecetaMedica);
            if (listalineas == null) lineas = new BindingList<lineaRecetaDto>();
            else lineas = new BindingList<lineaRecetaDto>(listalineas.ToList());

            dgvRecetaMedica.DataSource = lineas;
        }


        public void establecerEstadoComponentes()
        {
            switch (this._estado)
            {
                case Estado.Inicial:
                    btnModificarCita.Enabled = true;
                    btnGuardarCambios.Enabled = false;
                    txtMotivoCita.Enabled = false;

                    btnAgregarDiagnostico.Enabled = false;
                    btnEliminarDiagnostico.Enabled = false;

                    btnAgregarMedicamento.Enabled = false;
                    btnQuitarMedicamento.Enabled = false;
                    btnBuscarMedicamento.Enabled = false;
                    btnGuardarCambios.Enabled = false;
                    dtpVigenciaFinal.Enabled = false;
                    
                    break;

                case Estado.Modificar:
                    this.btnModificarCita.Enabled = false;

                    //Esto jamas se habilita, es solo para visualizacion
                    this.textEspecialidadAtendida.Enabled = false;
                    this.dtpFechaCita.Enabled = false;
                    this.txtNombrePaciente.Enabled = false;

                    //Durante la cita el medico puede modificar estos campos
                    this.btnGuardarCambios.Enabled = true;
                    this.txtMotivoCita.Enabled = true;
                    
                    this.Pestañas.Enabled = true;

                    this.tabDiagnostico.Enabled = true;
                    this.btnAgregarDiagnostico.Enabled = true;
                    this.btnEliminarDiagnostico.Enabled = true;
                    this.txtDescripcionDiagnostico.Enabled = true;
                    this.txtTratamientoDiagnostico.Enabled = true;


                    this.tabRecetaMedica.Enabled = true;
                    this.txtNombreMedicamento.Enabled = false;
                    this.txtDosisMedicamento.Enabled = true;
                    this.txtFrecuenciaMedicamento.Enabled = true;   
                    this.btnBuscarMedicamento.Enabled = true;
                    this.btnAgregarMedicamento.Enabled = true;
                    this.btnQuitarMedicamento.Enabled = true;
                    this.dtpVigenciaFinal.Enabled = true;
                    break;

                case Estado.Esperando:
                    btnGuardarCambios.Enabled = false;
                    break;

            

            }
        }

        public void limpiarComponentes()
        {
            txtMotivoCita.Text = "";
            txtDescripcionDiagnostico.Text = "";
            txtTratamientoDiagnostico.Text = "";
            txtNombreMedicamento.Text = "";
            txtDosisMedicamento.Text = "";
            txtFrecuenciaMedicamento.Text = "";

            dgvDiagnosticoCita.DataSource = null;
            dgvRecetaMedica.DataSource = null;
            dtpVigenciaFinal.Value = dtpFechaCita.Value;
        }

        private void bntModificarCita_Click(object sender, EventArgs e)
        {
            _estado = Estado.Modificar;
            limpiarComponentes();
            establecerEstadoComponentes();
        }

        private void btnVerHistorialPaciente_Click(object sender, EventArgs e)
        {
            //Pantalla para el historial de un paciente.
            frmHistorialPaciente formHistorialPaciente = new frmHistorialPaciente();
        }

        private void btnBuscarMedicamento_Click(object sender, EventArgs e)
        {
            frmBusquedaMedicamento formBuscarMedicamento = new frmBusquedaMedicamento();

            if (formBuscarMedicamento.ShowDialog() == DialogResult.OK)
            {
                this.medicamento = formBuscarMedicamento.MedicamentoSeleccionado;
                if (dgvRecetaMedica.Rows.Count == 0)
                {
                    lineas = new BindingList<lineaRecetaDto>();
                }
                else
                {
                    lineas = (BindingList<lineaRecetaDto>)dgvRecetaMedica.DataSource;
                    lineaRecetaDto linea = new lineaRecetaDto();            
                    txtNombreMedicamento.Text = formBuscarMedicamento.MedicamentoSeleccionado.nombreComercial;
                }
            }
        }

      

        private void btnAgregarDiagnostico_Click(object sender, EventArgs e)
        {

            diagnostico = new diagnostico();

            if (txtDescripcionDiagnostico.Text == "" || txtTratamientoDiagnostico.Text == "")
            {
                MessageBox.Show("Debe ingresar una descripcion y un tratamiento para el diagnostico",
                    "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {

                if (dgvDiagnosticoCita.Rows.Count == 0)
                {
                    diagnosticos = new BindingList<diagnostico>();
                }
                else
                {
                    diagnosticos = (BindingList<diagnostico>)dgvDiagnosticoCita.DataSource;
                }

                diagnostico.descripcion = txtDescripcionDiagnostico.Text;
                diagnostico.tratamiento = txtTratamientoDiagnostico.Text;
                diagnosticos.Add(diagnostico);

                dgvDiagnosticoCita.DataSource = diagnosticos;
            }


        }

        private void btnEliminarDiagnostico_Click(object sender, EventArgs e)
        {
            if (dgvDiagnosticoCita.RowCount > 0)
                dgvDiagnosticoCita.Rows.Remove(dgvDiagnosticoCita.CurrentRow);
        }

        private void btnEliminarMedicamento_Click(object sender, EventArgs e)
        {
            if (dgvRecetaMedica.RowCount > 0)
                dgvRecetaMedica.Rows.Remove(dgvRecetaMedica.CurrentRow);
        }

        private void btnBuscarMedicamento_Click_1(object sender, EventArgs e)
        {
            frmBusquedaMedicamento formBusquedaMedicamento = new frmBusquedaMedicamento();
            
            if(formBusquedaMedicamento.ShowDialog() == DialogResult.OK)
            {
                this.medicamento = formBusquedaMedicamento.MedicamentoSeleccionado;
                txtNombreMedicamento.Text = formBusquedaMedicamento.MedicamentoSeleccionado.nombreComercial;

            }
        }

        private void btnAgregarMedicamento_Click(object sender, EventArgs e)
        {
            lineaRecetaDto linea = new lineaRecetaDto();

            if (txtNombreMedicamento.Text == "" || txtDosisMedicamento.Text == "" || txtFrecuenciaMedicamento.Text == "")
            {
                MessageBox.Show("Debe seleccionar un medicamento", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                if (dgvRecetaMedica.Rows.Count == 0)
                {
                    lineas = new BindingList<lineaRecetaDto>();
                }
                else
                {
                    lineas = (BindingList<lineaRecetaDto>)dgvRecetaMedica.DataSource;
                }
                linea.idMedicamento = medicamento.idMedicamento;
                linea.nombreMedicamento = txtNombreMedicamento.Text;
                linea.dosis = txtDosisMedicamento.Text;
                linea.frecuencia = txtFrecuenciaMedicamento.Text;
                lineas.Add(linea);
                dgvRecetaMedica.DataSource = lineas;
            }

        }

        private void btnQuitarMedicamento_Click(object sender, EventArgs e)
        {
            dgvRecetaMedica.Rows.Remove(dgvRecetaMedica.CurrentRow);    
        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            if (txtMotivoCita.Text == "")
            {
                MessageBox.Show("Debe ingresar un motivo para la cita", "Mensaje de advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            _estado = Estado.Esperando;
            establecerEstadoComponentes();

            int [] errores= new int[3];

            errores[0] = guardarCita();
            errores[1] = guardarReceta();
            errores[2] = guardarDiagnostico();
    
            string error = "";
            bool hayError = false;

            foreach (int valor in errores)
            {
               switch(valor)
                {
                    case -1:
                        error += "Error al modificar el motivo de la cita\n";
                        hayError = true;
                        break;
                    case -2:
                        error += "Error al guardar la receta\n";
                        hayError = true;
                        break;
                    case -3:
                        error += "Error al guardar el diagnostico\n";
                        hayError = true;
                        break;
                }   
            }
            if(hayError)
            {
                MessageBox.Show(error, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Se han guardado los cambios", 
                    "Mensaje de confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
            }

        }

        private int guardarCita()
        {
            int resultado=0;

            citaMedica cita = new citaMedica();
            cita.idCita = citaMedicaDto.idCita;
            cita.motivoCita = txtMotivoCita.Text;
            resultado = daoAtencionMedicaWS.modificarCita(cita);

            if (resultado == 0) resultado = -1;
            return resultado;
        }
        private int guardarReceta()
        {
            int resultado=0;

            recetaMedica = new recetaMedicaDto();
            recetaMedica.idCitaMedica = citaMedicaDto.idCita;
            recetaMedica.vigenciaInicial = dtpFechaCita.Value.ToString("dd-MM-yyyy");
            recetaMedica.vigenciaFinal = dtpVigenciaFinal.Value.ToString("dd-MM-yyyy");


            lineas = (BindingList<lineaRecetaDto>)dgvRecetaMedica.DataSource;

            if (lineas.Count != 0)
            {
                recetaMedica.lineaReceta = lineas.ToArray();
                resultado = daoAtencionMedicaWS.insertarRecetaMedica(recetaMedica);

            }
            if (resultado == 0) resultado = -2;

            return resultado;
        }

        private int guardarDiagnostico()
        {
            int resultado = 0;

            diagnosticos = (BindingList<diagnostico>)dgvDiagnosticoCita.DataSource;

            if(diagnosticos.Count != 0)
            {
                foreach(diagnostico d in diagnosticos)
                {
                    d.idCitaMedica = citaMedicaDto.idCita;
                }
                resultado = daoAtencionMedicaWS.insertarDiagnostico(diagnosticos.ToArray());
            }

            if (resultado == 0) resultado = -3;
            return resultado;
        }
    }
}
