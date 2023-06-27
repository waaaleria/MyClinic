
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
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace LP2Soft
{
    public partial class frmPacienteHistoricoCitas : Form
    {
        private AtencionMedicaWSClient daoAtencion;
        private UsuarioWSClient daoUsuario;
        private int id_paciente;
        private citaMedica[] arrayCitas;
        private medico[] arrayMedicos;
        private citaMedica citaMedicaSeleccionada;
        public frmPacienteHistoricoCitas(usuario usuarioLogueado)
        {
            daoAtencion = new AtencionMedicaWSClient();
            daoUsuario = new UsuarioWSClient();
            InitializeComponent();
            id_paciente = daoUsuario.obtenerIdPaciente(usuarioLogueado.idUsuario);
        }

        private void dtpFechaBusqIni_ValueChanged(object sender, EventArgs e)
        {
        }

        private void frmPacienteHistoricoCitas_Load(object sender, EventArgs e)
        {

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
            if(Cita.fecha < DateTime.Now)
            {
                dgvListaCitasPaciente.Rows[e.RowIndex].Cells[3].Value = "Concluida";
            }
            else
            {
                dgvListaCitasPaciente.Rows[e.RowIndex].Cells[3].Value = "Programada";
            }
            
        }

        private void btnSeleccionar_Click_1(object sender, EventArgs e)
        {
            citaMedicaSeleccionada = (citaMedica)dgvListaCitasPaciente.CurrentRow.DataBoundItem;
            frmPacienteDetalleCita formDetalleCita = new frmPacienteDetalleCita(citaMedicaSeleccionada);
            formDetalleCita.Show();
        }

        private void btnBuscarHistorico_Click(object sender, EventArgs e)
        {
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
            arrayCitas = daoAtencion.listarCitasxPacientexFecha(id_paciente,citas.fecha, citas2.fecha);
            arrayMedicos = new medico[arrayCitas.Length];

            for (int i = 0; i < arrayCitas.Length; i++)
            {
                citaMedica Cita = arrayCitas[i];
                arrayMedicos[i] = daoUsuario.tomarDatosMedico(Cita.idMedico);
            }
            dgvListaCitasPaciente.DataSource = arrayCitas;
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            int contador=0;
            FileStream fs = new FileStream(@"C:\Users\sergi\Downloads\LP2MyClinic-DannyP\LP2MyClinic_FrontEndC#\PDF\CitasXPaciente.pdf", FileMode.Create);
            Document doc = new Document(PageSize.LETTER, 5, 5, 7, 7);
            PdfWriter pw = PdfWriter.GetInstance(doc, fs);

            doc.Open();

            doc.AddAuthor("Clinica Ortega");
            doc.AddTitle("Reporte de Citas X Paciente");

            iTextSharp.text.Font standartFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);

            doc.Add(new Paragraph("Reporte de Citas X Paciente"));
            doc.Add(Chunk.NEWLINE);

            PdfPTable tblEjemplo = new PdfPTable(4);
            tblEjemplo.WidthPercentage = 100;

            PdfPCell clFecha = new PdfPCell(new Phrase("Fecha", standartFont));
            clFecha.BorderWidth = 0;
            clFecha.BorderWidthBottom = 0.75f;

            PdfPCell clNombreMedico = new PdfPCell(new Phrase("Medico", standartFont));
            clNombreMedico.BorderWidth = 0;
            clNombreMedico.BorderWidthBottom = 0.75f;

            PdfPCell clEspecialidad = new PdfPCell(new Phrase("Especialidad", standartFont));
            clEspecialidad.BorderWidth = 0;
            clEspecialidad.BorderWidthBottom = 0.75f;

            PdfPCell clEstado = new PdfPCell(new Phrase("Estado", standartFont));
            clEstado.BorderWidth = 0;
            clEstado.BorderWidthBottom = 0.75f;

            tblEjemplo.AddCell(clFecha);
            tblEjemplo.AddCell(clNombreMedico);
            tblEjemplo.AddCell(clEspecialidad);
            tblEjemplo.AddCell(clEstado);

            foreach (var row in arrayCitas)
            {
                clFecha = new PdfPCell(new Phrase(row.fecha.ToString("yyyy-MM-dd"), standartFont));
                clFecha.BorderWidth = 0;

                clNombreMedico = new PdfPCell(new Phrase(arrayMedicos[contador].nombre.ToString(), standartFont));
                clNombreMedico.BorderWidth = 0;

                clEspecialidad = new PdfPCell(new Phrase(arrayMedicos[contador].especialidad.nombre.ToString(), standartFont));
                clEspecialidad.BorderWidth = 0;
                if (row.fecha < DateTime.Now)
                {
                    clEstado = new PdfPCell(new Phrase("Concluido", standartFont));
                    clEstado.BorderWidth = 0;
                }
                else
                {
                    clEstado = new PdfPCell(new Phrase("Concluido", standartFont));
                    clEstado.BorderWidth = 0;
                }
                tblEjemplo.AddCell(clFecha);
                tblEjemplo.AddCell(clNombreMedico);
                tblEjemplo.AddCell(clEspecialidad);
                tblEjemplo.AddCell(clEstado);
                contador++;
            }
            doc.Add(tblEjemplo);

            doc.Close();
            pw.Close();

            MessageBox.Show("Documento Generado satisfactoriamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
