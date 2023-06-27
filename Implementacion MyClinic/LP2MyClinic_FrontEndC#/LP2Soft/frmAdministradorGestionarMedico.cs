using iTextSharp.text.pdf;
using iTextSharp.text;
using LP2Soft.AtencionMedicaWS;
using LP2Soft.ItinerarioWS;
using LP2Soft.UsuarioWS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using programaAtencion = LP2Soft.ItinerarioWS.programaAtencion;
using LP2Soft.MedicinaWS;
using iTextSharp.text.pdf.codec.wmf;

namespace LP2Soft
{
    public partial class frmAdministradorGestionarMedico : Form
    {
        private medico _medico;
        private programaAtencion _programaAtencion;
        private programaAtencion _programaBuscado;

        private ItinerarioWSClient daoItinerario = new ItinerarioWSClient();
        private ItinerarioWS.programaAtencion programaSeleccionado;
        ItinerarioWS.programaAtencion[] programas;
        private Estado _estado;

        public frmAdministradorGestionarMedico()
        {
            InitializeComponent();
            dgvDetalleHorario.AutoGenerateColumns = false;
            _programaAtencion = new programaAtencion();
            LlenarComboBoxHoras();
        }

        public void establecerEstadoComponentes()
        {
            switch (this._estado)
            {
                case Estado.Inicial:
                    txtEspecialidadMedico.Enabled = false;
                    txtNombreMedico.Enabled = false;
                    dtpFecha.Enabled = false;
                    cboHoraFin.Enabled = false;
                    cboHoraInicio.Enabled = false;
                    btnBuscarMedico.Enabled = false;
                    dgvDetalleHorario.DataSource = null;//NUEVO CAMBIO DANNY reserva cita
                    break;
                case Estado.Nuevo:
                    txtEspecialidadMedico.Enabled = true;
                    txtNombreMedico.Enabled = true;
                    dtpFecha.Enabled = true;
                    cboHoraFin.Enabled = true;
                    cboHoraInicio.Enabled = true;
                    btnBuscarMedico.Enabled = true;
                    dgvDetalleHorario.DataSource = true;//NUEVO CAMBIO DANNY reserva cita
                    break;

            }
        }

        private void btnBuscarMedico_Click(object sender, EventArgs e)
        {
            frmBusquedaMedico formBusqMedico = new frmBusquedaMedico();
            if (formBusqMedico.ShowDialog() == DialogResult.OK)
            {
                _medico = formBusqMedico.MedicoSeleccionado;
                txtNombreMedico.Text = _medico.nombre.ToString() + " " + _medico.apellido.ToString();
                txtEspecialidadMedico.Text = _medico.especialidad.nombre.ToString();
            }
        }

        private void LlenarComboBoxHoras()
        {
            // Limpiar el ComboBox por si ya contiene elementos
            cboHoraInicio.Items.Clear();
            cboHoraFin.Items.Clear();

            // Generar una lista de horas y agregarlas al ComboBox
            for (int hora = 0; hora <= 23; hora++)
            {
                // Crear un objeto DateTime con la hora actual
                DateTime horaActual = DateTime.Today.AddHours(hora);

                // Convertir la hora a formato de 24 horas (opcional)
                string horaFormateada = horaActual.ToString("HH:mm:ss");

                // Agregar la hora al ComboBox
                cboHoraInicio.Items.Add(horaFormateada);
                cboHoraFin.Items.Add(horaFormateada);

            }
        }

        private void btnAgregarAgregar_Click(object sender, EventArgs e)
        {
            _programaAtencion.idMedico = _medico.idMedico;
            _programaAtencion.fecha = dtpFecha.Value;
            _programaAtencion.hora_inicio = cboHoraInicio.SelectedItem.ToString();
            _programaAtencion.hora_fin = cboHoraFin.SelectedItem.ToString();
            _programaAtencion.fechaSpecified  = true;

            int resultado = 0;

            resultado = daoItinerario.insertarListaHorariosPorMedico(_programaAtencion);



            //_programaBuscado =

             programas = daoItinerario.listarProgramaXMedico (_medico.idMedico);
            if (programas != null)
            {
                dgvDetalleHorario.DataSource = programas.ToList();
            }


        }

        private void dgvDetalleHorario_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //BindingList<programaAtencion> programas
            //= new BindingList<programaAtencion>(daoItinerario.listarProgramaXMedico(_medico.idMedico));

            ItinerarioWS.programaAtencion programa = (ItinerarioWS.programaAtencion)dgvDetalleHorario.Rows[e.RowIndex].DataBoundItem;

            for (int i = 0; i < dgvDetalleHorario.Rows.Count; i++)
            {
                dgvDetalleHorario.Rows[i].Cells[0].Value = (i + 1).ToString(); // Asigna el número de fila a la primera celda (columna 0)
            }
            //dgvProgramaAtencion.Rows[e.RowIndex].Cells[1].Value = programa.fecha.ToString();
            dgvDetalleHorario.Rows[e.RowIndex].Cells[1].Value = programa.fecha;
            dgvDetalleHorario.Rows[e.RowIndex].Cells[2].Value = programa.hora_inicio + " hasta " + programa.hora_fin; ;
            dgvDetalleHorario.Rows[e.RowIndex].Cells[3].Value = _medico.nombre + " " + _medico.apellido;
            dgvDetalleHorario.Rows[e.RowIndex].Cells[4].Value = _medico.especialidad.nombre;


        }

        private void buttonBuscarMedicoo_Click(object sender, EventArgs e)
        {
            programas = daoItinerario.listarProgramaXMedico(_medico.idMedico);
            if (programas != null)
            {
                dgvDetalleHorario.DataSource = programas.ToList();
            }
            else
            {
                MessageBox.Show("No hay Horarios disponibles para esa fecha", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
                int contador = 0;
                FileStream fs = new FileStream(@"C:\Users\sergi\Downloads\LP2MyClinic-DannyP\LP2MyClinic_FrontEndC#\PDF\CitasXMedico.pdf", FileMode.Create);
                Document doc = new Document(PageSize.LETTER, 5, 5, 7, 7);
                PdfWriter pw = PdfWriter.GetInstance(doc, fs);

                doc.Open();

                doc.AddAuthor("Clinica Ortega");
                doc.AddTitle("Reporte de Citas X Medico");

                iTextSharp.text.Font standartFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);

                doc.Add(new Paragraph("Reporte de Citas X Medico"));
                doc.Add(Chunk.NEWLINE);

                PdfPTable tblEjemplo = new PdfPTable(4);
                tblEjemplo.WidthPercentage = 100;

                PdfPCell clFecha = new PdfPCell(new Phrase("Fecha", standartFont));
                clFecha.BorderWidth = 0;
                clFecha.BorderWidthBottom = 0.75f;

                PdfPCell clHorario = new PdfPCell(new Phrase("Horario", standartFont));
                clHorario.BorderWidth = 0;
                clHorario.BorderWidthBottom = 0.75f;

                PdfPCell clNombre = new PdfPCell(new Phrase("Nombre Medico", standartFont));
                clNombre.BorderWidth = 0;
                clNombre.BorderWidthBottom = 0.75f;

                PdfPCell clEspecialidad = new PdfPCell(new Phrase("Especialidad", standartFont));
                clEspecialidad.BorderWidth = 0;
                clEspecialidad.BorderWidthBottom = 0.75f;

                tblEjemplo.AddCell(clFecha);
                tblEjemplo.AddCell(clHorario);
                tblEjemplo.AddCell(clNombre);
                tblEjemplo.AddCell(clEspecialidad);

                foreach (var row in programas)
                {
                    clFecha = new PdfPCell(new Phrase(row.fecha.ToString("yyyy-MM-dd"), standartFont));
                    clFecha.BorderWidth = 0;

                    clHorario = new PdfPCell(new Phrase(row.hora_inicio + " hasta " + row.hora_fin, standartFont));
                    clHorario.BorderWidth = 0;

                    clNombre = new PdfPCell(new Phrase(_medico.nombre + " " + _medico.apellido, standartFont));
                    clNombre.BorderWidth = 0;
                    
                    clEspecialidad = new PdfPCell(new Phrase(_medico.especialidad.nombre, standartFont));
                    clEspecialidad.BorderWidth = 0;

                    tblEjemplo.AddCell(clFecha);
                    tblEjemplo.AddCell(clHorario);
                    tblEjemplo.AddCell(clNombre);
                    tblEjemplo.AddCell(clEspecialidad);
                contador++;
                }
                doc.Add(tblEjemplo);

                doc.Close();
                pw.Close();

                MessageBox.Show("Documento Generado satisfactoriamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            _estado = Estado.Nuevo;
            establecerEstadoComponentes();
        }
    }





}
