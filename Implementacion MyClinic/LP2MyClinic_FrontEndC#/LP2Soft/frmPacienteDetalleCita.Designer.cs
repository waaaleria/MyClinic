namespace LP2Soft
{
    partial class frmPacienteDetalleCita
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvRecetaMedica = new System.Windows.Forms.DataGridView();
            this.NombrePMedicamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dosis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Frecuencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbMedico = new System.Windows.Forms.GroupBox();
            this.lblEspecialidadMedico = new System.Windows.Forms.Label();
            this.textEspecialidad = new System.Windows.Forms.TextBox();
            this.lblNombrePaciente = new System.Windows.Forms.Label();
            this.txtNombreMedico = new System.Windows.Forms.TextBox();
            this.txtDNIMedico = new System.Windows.Forms.TextBox();
            this.lblDNIMedico = new System.Windows.Forms.Label();
            this.gbPedido = new System.Windows.Forms.GroupBox();
            this.dtpFechaHoraio = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRecetaMedica = new System.Windows.Forms.Label();
            this.lblDescripcionCita = new System.Windows.Forms.Label();
            this.textDescripcionCita = new System.Windows.Forms.TextBox();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecetaMedica)).BeginInit();
            this.gbMedico.SuspendLayout();
            this.gbPedido.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvRecetaMedica
            // 
            this.dgvRecetaMedica.AllowUserToAddRows = false;
            this.dgvRecetaMedica.AllowUserToDeleteRows = false;
            this.dgvRecetaMedica.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRecetaMedica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecetaMedica.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombrePMedicamento,
            this.Dosis,
            this.Frecuencia});
            this.dgvRecetaMedica.Location = new System.Drawing.Point(40, 292);
            this.dgvRecetaMedica.Name = "dgvRecetaMedica";
            this.dgvRecetaMedica.ReadOnly = true;
            this.dgvRecetaMedica.RowHeadersWidth = 51;
            this.dgvRecetaMedica.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRecetaMedica.Size = new System.Drawing.Size(576, 127);
            this.dgvRecetaMedica.TabIndex = 12;
            this.dgvRecetaMedica.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvRecetaMedica_CellFormatting);
            // 
            // NombrePMedicamento
            // 
            this.NombrePMedicamento.HeaderText = "Nombre Medicamento";
            this.NombrePMedicamento.MinimumWidth = 6;
            this.NombrePMedicamento.Name = "NombrePMedicamento";
            this.NombrePMedicamento.ReadOnly = true;
            // 
            // Dosis
            // 
            this.Dosis.HeaderText = "Dosis";
            this.Dosis.MinimumWidth = 6;
            this.Dosis.Name = "Dosis";
            this.Dosis.ReadOnly = true;
            // 
            // Frecuencia
            // 
            dataGridViewCellStyle2.Format = "N2";
            this.Frecuencia.DefaultCellStyle = dataGridViewCellStyle2;
            this.Frecuencia.HeaderText = "Frecuencia";
            this.Frecuencia.MinimumWidth = 6;
            this.Frecuencia.Name = "Frecuencia";
            this.Frecuencia.ReadOnly = true;
            // 
            // gbMedico
            // 
            this.gbMedico.Controls.Add(this.lblEspecialidadMedico);
            this.gbMedico.Controls.Add(this.textEspecialidad);
            this.gbMedico.Controls.Add(this.lblNombrePaciente);
            this.gbMedico.Controls.Add(this.txtNombreMedico);
            this.gbMedico.Controls.Add(this.txtDNIMedico);
            this.gbMedico.Controls.Add(this.lblDNIMedico);
            this.gbMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbMedico.Location = new System.Drawing.Point(40, 90);
            this.gbMedico.Name = "gbMedico";
            this.gbMedico.Size = new System.Drawing.Size(596, 114);
            this.gbMedico.TabIndex = 9;
            this.gbMedico.TabStop = false;
            this.gbMedico.Text = "Datos del Médico";
            // 
            // lblEspecialidadMedico
            // 
            this.lblEspecialidadMedico.AutoSize = true;
            this.lblEspecialidadMedico.Location = new System.Drawing.Point(22, 80);
            this.lblEspecialidadMedico.Name = "lblEspecialidadMedico";
            this.lblEspecialidadMedico.Size = new System.Drawing.Size(92, 17);
            this.lblEspecialidadMedico.TabIndex = 5;
            this.lblEspecialidadMedico.Text = "Especialidad:";
            // 
            // textEspecialidad
            // 
            this.textEspecialidad.Enabled = false;
            this.textEspecialidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEspecialidad.Location = new System.Drawing.Point(115, 79);
            this.textEspecialidad.Name = "textEspecialidad";
            this.textEspecialidad.ReadOnly = true;
            this.textEspecialidad.Size = new System.Drawing.Size(229, 20);
            this.textEspecialidad.TabIndex = 4;
            // 
            // lblNombrePaciente
            // 
            this.lblNombrePaciente.AutoSize = true;
            this.lblNombrePaciente.Location = new System.Drawing.Point(52, 54);
            this.lblNombrePaciente.Name = "lblNombrePaciente";
            this.lblNombrePaciente.Size = new System.Drawing.Size(62, 17);
            this.lblNombrePaciente.TabIndex = 3;
            this.lblNombrePaciente.Text = "Nombre:";
            // 
            // txtNombreMedico
            // 
            this.txtNombreMedico.Enabled = false;
            this.txtNombreMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreMedico.Location = new System.Drawing.Point(115, 48);
            this.txtNombreMedico.Name = "txtNombreMedico";
            this.txtNombreMedico.ReadOnly = true;
            this.txtNombreMedico.Size = new System.Drawing.Size(374, 20);
            this.txtNombreMedico.TabIndex = 2;
            // 
            // txtDNIMedico
            // 
            this.txtDNIMedico.Enabled = false;
            this.txtDNIMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDNIMedico.Location = new System.Drawing.Point(115, 21);
            this.txtDNIMedico.Name = "txtDNIMedico";
            this.txtDNIMedico.ReadOnly = true;
            this.txtDNIMedico.Size = new System.Drawing.Size(144, 20);
            this.txtDNIMedico.TabIndex = 1;
            // 
            // lblDNIMedico
            // 
            this.lblDNIMedico.AutoSize = true;
            this.lblDNIMedico.Location = new System.Drawing.Point(71, 27);
            this.lblDNIMedico.Name = "lblDNIMedico";
            this.lblDNIMedico.Size = new System.Drawing.Size(35, 17);
            this.lblDNIMedico.TabIndex = 0;
            this.lblDNIMedico.Text = "DNI:";
            // 
            // gbPedido
            // 
            this.gbPedido.Controls.Add(this.dtpFechaHoraio);
            this.gbPedido.Controls.Add(this.label2);
            this.gbPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPedido.Location = new System.Drawing.Point(40, 25);
            this.gbPedido.Name = "gbPedido";
            this.gbPedido.Size = new System.Drawing.Size(596, 59);
            this.gbPedido.TabIndex = 8;
            this.gbPedido.TabStop = false;
            this.gbPedido.Text = "Datos de la Cita Médica";
            // 
            // dtpFechaHoraio
            // 
            this.dtpFechaHoraio.Enabled = false;
            this.dtpFechaHoraio.Location = new System.Drawing.Point(136, 23);
            this.dtpFechaHoraio.Name = "dtpFechaHoraio";
            this.dtpFechaHoraio.Size = new System.Drawing.Size(374, 23);
            this.dtpFechaHoraio.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fecha de la cita:";
            // 
            // lblRecetaMedica
            // 
            this.lblRecetaMedica.AutoSize = true;
            this.lblRecetaMedica.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecetaMedica.Location = new System.Drawing.Point(37, 272);
            this.lblRecetaMedica.Name = "lblRecetaMedica";
            this.lblRecetaMedica.Size = new System.Drawing.Size(102, 17);
            this.lblRecetaMedica.TabIndex = 13;
            this.lblRecetaMedica.Text = "Receta Medica";
            // 
            // lblDescripcionCita
            // 
            this.lblDescripcionCita.AutoSize = true;
            this.lblDescripcionCita.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcionCita.Location = new System.Drawing.Point(40, 207);
            this.lblDescripcionCita.Name = "lblDescripcionCita";
            this.lblDescripcionCita.Size = new System.Drawing.Size(99, 17);
            this.lblDescripcionCita.TabIndex = 14;
            this.lblDescripcionCita.Text = "Motivo de cita:";
            // 
            // textDescripcionCita
            // 
            this.textDescripcionCita.Location = new System.Drawing.Point(40, 232);
            this.textDescripcionCita.Margin = new System.Windows.Forms.Padding(2);
            this.textDescripcionCita.Multiline = true;
            this.textDescripcionCita.Name = "textDescripcionCita";
            this.textDescripcionCita.ReadOnly = true;
            this.textDescripcionCita.Size = new System.Drawing.Size(576, 38);
            this.textDescripcionCita.TabIndex = 15;
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnImprimir.FlatAppearance.BorderSize = 0;
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.ForeColor = System.Drawing.Color.Transparent;
            this.btnImprimir.Location = new System.Drawing.Point(479, 434);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(137, 23);
            this.btnImprimir.TabIndex = 66;
            this.btnImprimir.Text = "IMPRIMIR RECETA";
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.BackgroundImage = global::LP2Soft.Properties.Resources.cerca;
            this.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Location = new System.Drawing.Point(625, 1);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(46, 33);
            this.btnCerrar.TabIndex = 16;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // frmPacienteDetalleCita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 469);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.textDescripcionCita);
            this.Controls.Add(this.lblDescripcionCita);
            this.Controls.Add(this.lblRecetaMedica);
            this.Controls.Add(this.dgvRecetaMedica);
            this.Controls.Add(this.gbMedico);
            this.Controls.Add(this.gbPedido);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmPacienteDetalleCita";
            this.Text = "FrmDetalleCIta";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecetaMedica)).EndInit();
            this.gbMedico.ResumeLayout(false);
            this.gbMedico.PerformLayout();
            this.gbPedido.ResumeLayout(false);
            this.gbPedido.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRecetaMedica;
        private System.Windows.Forms.GroupBox gbMedico;
        private System.Windows.Forms.Label lblNombrePaciente;
        private System.Windows.Forms.TextBox txtNombreMedico;
        private System.Windows.Forms.TextBox txtDNIMedico;
        private System.Windows.Forms.Label lblDNIMedico;
        private System.Windows.Forms.GroupBox gbPedido;
        private System.Windows.Forms.DateTimePicker dtpFechaHoraio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblRecetaMedica;
        private System.Windows.Forms.Label lblDescripcionCita;
        private System.Windows.Forms.TextBox textDescripcionCita;
        private System.Windows.Forms.Label lblEspecialidadMedico;
        private System.Windows.Forms.TextBox textEspecialidad;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombrePMedicamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dosis;
        private System.Windows.Forms.DataGridViewTextBoxColumn Frecuencia;
        private System.Windows.Forms.Button btnImprimir;
    }
}