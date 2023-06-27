namespace LP2Soft
{
    partial class frmMedicoHistoricoCitas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMedicoHistoricoCitas));
            this.lblEspecialidad = new System.Windows.Forms.Label();
            this.txtEspecialidad = new System.Windows.Forms.TextBox();
            this.lblNombreDoctor = new System.Windows.Forms.Label();
            this.txtNombreMedico = new System.Windows.Forms.TextBox();
            this.panelDatosMedico = new System.Windows.Forms.Panel();
            this.grpFiltros = new System.Windows.Forms.GroupBox();
            this.btnReiniciarFiltro = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblFechaFin = new System.Windows.Forms.Label();
            this.lblFechaIni = new System.Windows.Forms.Label();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaInicial = new System.Windows.Forms.DateTimePicker();
            this.lblRangoFechas = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBusquedaPacientes = new System.Windows.Forms.Button();
            this.lblNombreCompletoPac = new System.Windows.Forms.Label();
            this.txtNombrePaciente = new System.Windows.Forms.TextBox();
            this.btnAplicarFiltros = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvListaCitasPaciente = new System.Windows.Forms.DataGridView();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Horario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Paciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnVerDetalles = new System.Windows.Forms.Button();
            this.panelDatosMedico.SuspendLayout();
            this.grpFiltros.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaCitasPaciente)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEspecialidad
            // 
            this.lblEspecialidad.AutoSize = true;
            this.lblEspecialidad.Location = new System.Drawing.Point(19, 16);
            this.lblEspecialidad.Name = "lblEspecialidad";
            this.lblEspecialidad.Size = new System.Drawing.Size(95, 18);
            this.lblEspecialidad.TabIndex = 1;
            this.lblEspecialidad.Text = "Especialidad:";
            // 
            // txtEspecialidad
            // 
            this.txtEspecialidad.Enabled = false;
            this.txtEspecialidad.Location = new System.Drawing.Point(129, 13);
            this.txtEspecialidad.Name = "txtEspecialidad";
            this.txtEspecialidad.ReadOnly = true;
            this.txtEspecialidad.Size = new System.Drawing.Size(155, 24);
            this.txtEspecialidad.TabIndex = 2;
            // 
            // lblNombreDoctor
            // 
            this.lblNombreDoctor.AutoSize = true;
            this.lblNombreDoctor.Location = new System.Drawing.Point(53, 46);
            this.lblNombreDoctor.Name = "lblNombreDoctor";
            this.lblNombreDoctor.Size = new System.Drawing.Size(61, 18);
            this.lblNombreDoctor.TabIndex = 3;
            this.lblNombreDoctor.Text = "Medico:";
            // 
            // txtNombreMedico
            // 
            this.txtNombreMedico.Enabled = false;
            this.txtNombreMedico.Location = new System.Drawing.Point(129, 43);
            this.txtNombreMedico.Name = "txtNombreMedico";
            this.txtNombreMedico.ReadOnly = true;
            this.txtNombreMedico.Size = new System.Drawing.Size(155, 24);
            this.txtNombreMedico.TabIndex = 4;
            // 
            // panelDatosMedico
            // 
            this.panelDatosMedico.Controls.Add(this.lblEspecialidad);
            this.panelDatosMedico.Controls.Add(this.txtNombreMedico);
            this.panelDatosMedico.Controls.Add(this.txtEspecialidad);
            this.panelDatosMedico.Controls.Add(this.lblNombreDoctor);
            this.panelDatosMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.panelDatosMedico.Location = new System.Drawing.Point(12, 12);
            this.panelDatosMedico.Name = "panelDatosMedico";
            this.panelDatosMedico.Size = new System.Drawing.Size(318, 79);
            this.panelDatosMedico.TabIndex = 5;
            // 
            // grpFiltros
            // 
            this.grpFiltros.Controls.Add(this.btnReiniciarFiltro);
            this.grpFiltros.Controls.Add(this.panel2);
            this.grpFiltros.Controls.Add(this.panel1);
            this.grpFiltros.Controls.Add(this.btnAplicarFiltros);
            this.grpFiltros.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpFiltros.Location = new System.Drawing.Point(12, 97);
            this.grpFiltros.Name = "grpFiltros";
            this.grpFiltros.Size = new System.Drawing.Size(318, 341);
            this.grpFiltros.TabIndex = 6;
            this.grpFiltros.TabStop = false;
            this.grpFiltros.Text = "Filtros";
            // 
            // btnReiniciarFiltro
            // 
            this.btnReiniciarFiltro.Location = new System.Drawing.Point(6, 301);
            this.btnReiniciarFiltro.Name = "btnReiniciarFiltro";
            this.btnReiniciarFiltro.Size = new System.Drawing.Size(154, 25);
            this.btnReiniciarFiltro.TabIndex = 6;
            this.btnReiniciarFiltro.Text = "Reiniciar filtros";
            this.btnReiniciarFiltro.UseVisualStyleBackColor = true;
            this.btnReiniciarFiltro.Click += new System.EventHandler(this.btnReiniciarFiltro_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblFechaFin);
            this.panel2.Controls.Add(this.lblFechaIni);
            this.panel2.Controls.Add(this.dtpFechaFin);
            this.panel2.Controls.Add(this.dtpFechaInicial);
            this.panel2.Controls.Add(this.lblRangoFechas);
            this.panel2.Location = new System.Drawing.Point(6, 21);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(306, 161);
            this.panel2.TabIndex = 5;
            // 
            // lblFechaFin
            // 
            this.lblFechaFin.AutoSize = true;
            this.lblFechaFin.Location = new System.Drawing.Point(20, 107);
            this.lblFechaFin.Name = "lblFechaFin";
            this.lblFechaFin.Size = new System.Drawing.Size(75, 16);
            this.lblFechaFin.TabIndex = 4;
            this.lblFechaFin.Text = "Fecha final:";
            // 
            // lblFechaIni
            // 
            this.lblFechaIni.AutoSize = true;
            this.lblFechaIni.Location = new System.Drawing.Point(20, 45);
            this.lblFechaIni.Name = "lblFechaIni";
            this.lblFechaIni.Size = new System.Drawing.Size(85, 16);
            this.lblFechaIni.TabIndex = 3;
            this.lblFechaIni.Text = "Fecha inicial:";
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.dtpFechaFin.Location = new System.Drawing.Point(23, 127);
            this.dtpFechaFin.MaxDate = new System.DateTime(2025, 1, 1, 0, 0, 0, 0);
            this.dtpFechaFin.MinDate = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(262, 21);
            this.dtpFechaFin.TabIndex = 2;
            // 
            // dtpFechaInicial
            // 
            this.dtpFechaInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.dtpFechaInicial.Location = new System.Drawing.Point(23, 65);
            this.dtpFechaInicial.MaxDate = new System.DateTime(2025, 1, 1, 0, 0, 0, 0);
            this.dtpFechaInicial.MinDate = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            this.dtpFechaInicial.Name = "dtpFechaInicial";
            this.dtpFechaInicial.Size = new System.Drawing.Size(262, 21);
            this.dtpFechaInicial.TabIndex = 1;
            this.dtpFechaInicial.Value = new System.DateTime(2023, 6, 26, 0, 0, 0, 0);
            // 
            // lblRangoFechas
            // 
            this.lblRangoFechas.AutoSize = true;
            this.lblRangoFechas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRangoFechas.Location = new System.Drawing.Point(13, 12);
            this.lblRangoFechas.Name = "lblRangoFechas";
            this.lblRangoFechas.Size = new System.Drawing.Size(113, 16);
            this.lblRangoFechas.TabIndex = 0;
            this.lblRangoFechas.Text = "Rango de fechas:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnBusquedaPacientes);
            this.panel1.Controls.Add(this.lblNombreCompletoPac);
            this.panel1.Controls.Add(this.txtNombrePaciente);
            this.panel1.Location = new System.Drawing.Point(6, 188);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(306, 96);
            this.panel1.TabIndex = 4;
            // 
            // btnBusquedaPacientes
            // 
            this.btnBusquedaPacientes.Location = new System.Drawing.Point(23, 61);
            this.btnBusquedaPacientes.Name = "btnBusquedaPacientes";
            this.btnBusquedaPacientes.Size = new System.Drawing.Size(262, 26);
            this.btnBusquedaPacientes.TabIndex = 4;
            this.btnBusquedaPacientes.Text = "Buscar paciente";
            this.btnBusquedaPacientes.UseVisualStyleBackColor = true;
            this.btnBusquedaPacientes.Click += new System.EventHandler(this.btnBusquedaPacientes_Click);
            // 
            // lblNombreCompletoPac
            // 
            this.lblNombreCompletoPac.AutoSize = true;
            this.lblNombreCompletoPac.Location = new System.Drawing.Point(20, 14);
            this.lblNombreCompletoPac.Name = "lblNombreCompletoPac";
            this.lblNombreCompletoPac.Size = new System.Drawing.Size(195, 16);
            this.lblNombreCompletoPac.TabIndex = 3;
            this.lblNombreCompletoPac.Text = "Nombre completo del paciente:";
            // 
            // txtNombrePaciente
            // 
            this.txtNombrePaciente.Location = new System.Drawing.Point(23, 33);
            this.txtNombrePaciente.Name = "txtNombrePaciente";
            this.txtNombrePaciente.Size = new System.Drawing.Size(262, 22);
            this.txtNombrePaciente.TabIndex = 2;
            // 
            // btnAplicarFiltros
            // 
            this.btnAplicarFiltros.Location = new System.Drawing.Point(185, 301);
            this.btnAplicarFiltros.Name = "btnAplicarFiltros";
            this.btnAplicarFiltros.Size = new System.Drawing.Size(127, 25);
            this.btnAplicarFiltros.TabIndex = 1;
            this.btnAplicarFiltros.Text = "Aplicar filtros";
            this.btnAplicarFiltros.UseVisualStyleBackColor = true;
            this.btnAplicarFiltros.Click += new System.EventHandler(this.btnAplicarFiltros_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvListaCitasPaciente);
            this.panel3.Controls.Add(this.btnVerDetalles);
            this.panel3.Location = new System.Drawing.Point(336, 13);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(410, 425);
            this.panel3.TabIndex = 7;
            // 
            // dgvListaCitasPaciente
            // 
            this.dgvListaCitasPaciente.AllowUserToAddRows = false;
            this.dgvListaCitasPaciente.AllowUserToDeleteRows = false;
            this.dgvListaCitasPaciente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListaCitasPaciente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaCitasPaciente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Fecha,
            this.Horario,
            this.Paciente});
            this.dgvListaCitasPaciente.Location = new System.Drawing.Point(3, 3);
            this.dgvListaCitasPaciente.MultiSelect = false;
            this.dgvListaCitasPaciente.Name = "dgvListaCitasPaciente";
            this.dgvListaCitasPaciente.ReadOnly = true;
            this.dgvListaCitasPaciente.RowHeadersWidth = 51;
            this.dgvListaCitasPaciente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaCitasPaciente.Size = new System.Drawing.Size(385, 373);
            this.dgvListaCitasPaciente.TabIndex = 41;
            // 
            // Fecha
            // 
            this.Fecha.DataPropertyName = "fecha";
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.MinimumWidth = 6;
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // Horario
            // 
            this.Horario.DataPropertyName = "horario";
            this.Horario.HeaderText = "Horario";
            this.Horario.MinimumWidth = 6;
            this.Horario.Name = "Horario";
            this.Horario.ReadOnly = true;
            // 
            // Paciente
            // 
            this.Paciente.DataPropertyName = "paciente";
            this.Paciente.HeaderText = "Paciente";
            this.Paciente.MinimumWidth = 6;
            this.Paciente.Name = "Paciente";
            this.Paciente.ReadOnly = true;
            // 
            // btnVerDetalles
            // 
            this.btnVerDetalles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnVerDetalles.Location = new System.Drawing.Point(267, 385);
            this.btnVerDetalles.Name = "btnVerDetalles";
            this.btnVerDetalles.Size = new System.Drawing.Size(121, 32);
            this.btnVerDetalles.TabIndex = 2;
            this.btnVerDetalles.Text = "Ver detalles";
            this.btnVerDetalles.UseVisualStyleBackColor = true;
            this.btnVerDetalles.Click += new System.EventHandler(this.btnVerDetalles_Click);
            // 
            // frmMedicoHistoricoCitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.grpFiltros);
            this.Controls.Add(this.panelDatosMedico);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMedicoHistoricoCitas";
            this.panelDatosMedico.ResumeLayout(false);
            this.panelDatosMedico.PerformLayout();
            this.grpFiltros.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaCitasPaciente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblEspecialidad;
        private System.Windows.Forms.TextBox txtEspecialidad;
        private System.Windows.Forms.Label lblNombreDoctor;
        private System.Windows.Forms.TextBox txtNombreMedico;
        private System.Windows.Forms.Panel panelDatosMedico;
        private System.Windows.Forms.GroupBox grpFiltros;
        private System.Windows.Forms.Label lblNombreCompletoPac;
        private System.Windows.Forms.TextBox txtNombrePaciente;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnBusquedaPacientes;
        private System.Windows.Forms.Label lblRangoFechas;
        private System.Windows.Forms.Label lblFechaIni;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.Label lblFechaFin;
        private System.Windows.Forms.DateTimePicker dtpFechaInicial;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnAplicarFiltros;
        private System.Windows.Forms.Button btnVerDetalles;
        private System.Windows.Forms.DataGridView dgvListaCitasPaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Horario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Paciente;
        private System.Windows.Forms.Button btnReiniciarFiltro;
    }
}