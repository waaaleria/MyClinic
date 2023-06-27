using iTextSharp.text.pdf;
using iTextSharp.text;
using LP2Soft.AtencionMedicaWS;
using LP2Soft.MedicinaWS;
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

namespace LP2Soft
{
    public partial class frmPacienteDetalleCita : Form
    {
        private UsuarioWSClient daoUsuario;
        private medico medico;
        private AtencionMedicaWSClient daoAtencion;
        private MedicinaWSClient daoMedicina;
        private lineaReceta[] arrayLineas;
        private string[] arrayMedicamentos;
        public frmPacienteDetalleCita(citaMedica citaMedicaSeleccionada)
        {
            InitializeComponent();
            daoUsuario = new UsuarioWSClient();
            daoAtencion= new AtencionMedicaWSClient();
            daoMedicina = new MedicinaWSClient();   
            medico = new medico();
            medico = daoUsuario.tomarDatosMedico(citaMedicaSeleccionada.idMedico);
            dgvRecetaMedica.AutoGenerateColumns = false;
            dtpFechaHoraio.Value = citaMedicaSeleccionada.fecha;
            txtDNIMedico.Text = medico.dni;
            txtNombreMedico.Text = medico.nombre;
            textEspecialidad.Text = medico.especialidad.nombre;
            textDescripcionCita.Text = citaMedicaSeleccionada.motivoCita;
            arrayLineas = daoAtencion.listarRecetaxCita(citaMedicaSeleccionada.idCita);
            arrayMedicamentos = new string[arrayLineas.Length];
            for (int i = 0; i < arrayLineas.Length; i++)
            {
                lineaReceta lr = arrayLineas[i];
                arrayMedicamentos[i] = daoMedicina.obtenerMedicamento(lr.medicamento.idMedicamento);
            }
            dgvRecetaMedica.DataSource = arrayLineas;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvRecetaMedica_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dgvRecetaMedica.Rows.Count)
                return;

            lineaReceta lr = (lineaReceta)dgvRecetaMedica.Rows[e.RowIndex].DataBoundItem;
            if (arrayMedicamentos != null && e.RowIndex < arrayMedicamentos.Length)
            {
                String medicamento = arrayMedicamentos[e.RowIndex];
                dgvRecetaMedica.Rows[e.RowIndex].Cells[0].Value = medicamento;
            }
            dgvRecetaMedica.Rows[e.RowIndex].Cells[1].Value = lr.dosis;
            dgvRecetaMedica.Rows[e.RowIndex].Cells[2].Value = lr.frecuencia;
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            int contador = 0;
            FileStream fs = new FileStream(@"C:\Users\sergi\Downloads\LP2MyClinic-DannyP\LP2MyClinic_FrontEndC#\PDF\RecetaMedica.pdf", FileMode.Create);
            Document doc = new Document(PageSize.LETTER, 5, 5, 7, 7);
            PdfWriter pw = PdfWriter.GetInstance(doc, fs);

            doc.Open();

            doc.AddAuthor("Clinica Ortega");
            doc.AddTitle("RecetaMedica");

            iTextSharp.text.Font standartFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);

            doc.Add(new Paragraph("RecetaMedica"));
            doc.Add(Chunk.NEWLINE);

            PdfPTable tblEjemplo = new PdfPTable(3);
            tblEjemplo.WidthPercentage = 100;

            PdfPCell clMedicamento = new PdfPCell(new Phrase("Nombre Medicamento", standartFont));
            clMedicamento.BorderWidth = 0;
            clMedicamento.BorderWidthBottom = 0.75f;

            PdfPCell clDosis = new PdfPCell(new Phrase("Dosis", standartFont));
            clDosis.BorderWidth = 0;
            clDosis.BorderWidthBottom = 0.75f;

            PdfPCell clFrecuencia = new PdfPCell(new Phrase("Frecuencia", standartFont));
            clFrecuencia.BorderWidth = 0;
            clFrecuencia.BorderWidthBottom = 0.75f;

            tblEjemplo.AddCell(clMedicamento);
            tblEjemplo.AddCell(clDosis);
            tblEjemplo.AddCell(clFrecuencia);

            foreach (var row in arrayLineas)
            {
                clMedicamento = new PdfPCell(new Phrase(arrayMedicamentos[contador].ToString(), standartFont));
                clMedicamento.BorderWidth = 0;

                clDosis = new PdfPCell(new Phrase(row.dosis, standartFont));
                clDosis.BorderWidth = 0;

                clFrecuencia = new PdfPCell(new Phrase(row.frecuencia, standartFont));
                clFrecuencia.BorderWidth = 0;

                tblEjemplo.AddCell(clMedicamento);
                tblEjemplo.AddCell(clDosis);
                tblEjemplo.AddCell(clFrecuencia);
                contador++;
            }
            doc.Add(tblEjemplo);

            doc.Close();
            pw.Close();

            MessageBox.Show("Documento Generado satisfactoriamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
