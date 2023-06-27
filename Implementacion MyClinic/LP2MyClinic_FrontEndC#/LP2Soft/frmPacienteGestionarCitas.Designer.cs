namespace LP2Soft
{
    partial class frmPacienteGestionarCitas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPacienteGestionarCitas));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnHorDisp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFechaHorario = new System.Windows.Forms.DateTimePicker();
            this.gbCliente = new System.Windows.Forms.GroupBox();
            this.TarjetaMedico = new System.Windows.Forms.LinkLabel();
            this.cboMedico = new System.Windows.Forms.ComboBox();
            this.cboEspecialidad = new System.Windows.Forms.ComboBox();
            this.lblEspecialidadMedico = new System.Windows.Forms.Label();
            this.lblNombreMedico = new System.Windows.Forms.Label();
            this.tsMenu = new System.Windows.Forms.ToolStrip();
            this.gbpacientes = new System.Windows.Forms.GroupBox();
            this.btnEliminarCita = new System.Windows.Forms.Button();
            this.btnBuscarPaciente = new System.Windows.Forms.Button();
            this.txtNombrePac = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.Label();
            this.txtDNIPac = new System.Windows.Forms.TextBox();
            this.txtDNI = new System.Windows.Forms.Label();
            this.dgvProgramaAtencion = new System.Windows.Forms.DataGridView();
            this.btnReservaCita = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnReservarCita = new System.Windows.Forms.ToolStripButton();
            this.btnModificarCita = new System.Windows.Forms.ToolStripButton();
            this.btnCancelarReserva = new System.Windows.Forms.ToolStripButton();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraFIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.gbCliente.SuspendLayout();
            this.tsMenu.SuspendLayout();
            this.gbpacientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProgramaAtencion)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnHorDisp);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtpFechaHorario);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 307);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(706, 101);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Horario";
            // 
            // btnHorDisp
            // 
            this.btnHorDisp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHorDisp.Location = new System.Drawing.Point(187, 63);
            this.btnHorDisp.Margin = new System.Windows.Forms.Padding(2);
            this.btnHorDisp.Name = "btnHorDisp";
            this.btnHorDisp.Size = new System.Drawing.Size(82, 23);
            this.btnHorDisp.TabIndex = 9;
            this.btnHorDisp.Text = "Buscar";
            this.btnHorDisp.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnHorDisp.UseVisualStyleBackColor = true;
            this.btnHorDisp.Click += new System.EventHandler(this.btnHorDisp_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Horarios disponibles:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Fecha:";
            // 
            // dtpFechaHorario
            // 
            this.dtpFechaHorario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaHorario.Location = new System.Drawing.Point(186, 30);
            this.dtpFechaHorario.Name = "dtpFechaHorario";
            this.dtpFechaHorario.Size = new System.Drawing.Size(280, 22);
            this.dtpFechaHorario.TabIndex = 35;
            // 
            // gbCliente
            // 
            this.gbCliente.Controls.Add(this.TarjetaMedico);
            this.gbCliente.Controls.Add(this.cboMedico);
            this.gbCliente.Controls.Add(this.cboEspecialidad);
            this.gbCliente.Controls.Add(this.panel1);
            this.gbCliente.Controls.Add(this.lblEspecialidadMedico);
            this.gbCliente.Controls.Add(this.lblNombreMedico);
            this.gbCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCliente.Location = new System.Drawing.Point(12, 144);
            this.gbCliente.Name = "gbCliente";
            this.gbCliente.Size = new System.Drawing.Size(706, 155);
            this.gbCliente.TabIndex = 42;
            this.gbCliente.TabStop = false;
            this.gbCliente.Text = "Datos del Médico:";
            // 
            // TarjetaMedico
            // 
            this.TarjetaMedico.AutoSize = true;
            this.TarjetaMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TarjetaMedico.Location = new System.Drawing.Point(183, 122);
            this.TarjetaMedico.Name = "TarjetaMedico";
            this.TarjetaMedico.Size = new System.Drawing.Size(155, 15);
            this.TarjetaMedico.TabIndex = 48;
            this.TarjetaMedico.TabStop = true;
            this.TarjetaMedico.Text = "Revisar Tarjeta Medico";
            this.TarjetaMedico.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.TarjetaMedico_LinkClicked);
            // 
            // cboMedico
            // 
            this.cboMedico.BackColor = System.Drawing.SystemColors.Control;
            this.cboMedico.FormattingEnabled = true;
            this.cboMedico.Location = new System.Drawing.Point(186, 82);
            this.cboMedico.Name = "cboMedico";
            this.cboMedico.Size = new System.Drawing.Size(280, 26);
            this.cboMedico.TabIndex = 45;
            this.cboMedico.SelectedIndexChanged += new System.EventHandler(this.cboMedico_SelectedIndexChanged);
            // 
            // cboEspecialidad
            // 
            this.cboEspecialidad.BackColor = System.Drawing.SystemColors.Control;
            this.cboEspecialidad.FormattingEnabled = true;
            this.cboEspecialidad.Location = new System.Drawing.Point(186, 40);
            this.cboEspecialidad.Name = "cboEspecialidad";
            this.cboEspecialidad.Size = new System.Drawing.Size(280, 26);
            this.cboEspecialidad.TabIndex = 44;
            this.cboEspecialidad.SelectedIndexChanged += new System.EventHandler(this.cboEspecialidad_SelectedIndexChanged);
            // 
            // lblEspecialidadMedico
            // 
            this.lblEspecialidadMedico.AutoSize = true;
            this.lblEspecialidadMedico.Location = new System.Drawing.Point(13, 43);
            this.lblEspecialidadMedico.Name = "lblEspecialidadMedico";
            this.lblEspecialidadMedico.Size = new System.Drawing.Size(108, 18);
            this.lblEspecialidadMedico.TabIndex = 6;
            this.lblEspecialidadMedico.Text = "Especialidad:";
            // 
            // lblNombreMedico
            // 
            this.lblNombreMedico.AutoSize = true;
            this.lblNombreMedico.Location = new System.Drawing.Point(13, 82);
            this.lblNombreMedico.Name = "lblNombreMedico";
            this.lblNombreMedico.Size = new System.Drawing.Size(160, 18);
            this.lblNombreMedico.TabIndex = 3;
            this.lblNombreMedico.Text = "Nombre del Médico:";
            // 
            // tsMenu
            // 
            this.tsMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnReservarCita,
            this.btnModificarCita,
            this.btnCancelarReserva});
            this.tsMenu.Location = new System.Drawing.Point(0, 0);
            this.tsMenu.Name = "tsMenu";
            this.tsMenu.Size = new System.Drawing.Size(945, 27);
            this.tsMenu.TabIndex = 41;
            this.tsMenu.Text = "toolStrip1";
            // 
            // gbpacientes
            // 
            this.gbpacientes.Controls.Add(this.btnEliminarCita);
            this.gbpacientes.Controls.Add(this.btnBuscarPaciente);
            this.gbpacientes.Controls.Add(this.txtNombrePac);
            this.gbpacientes.Controls.Add(this.txtNombre);
            this.gbpacientes.Controls.Add(this.txtDNIPac);
            this.gbpacientes.Controls.Add(this.txtDNI);
            this.gbpacientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbpacientes.Location = new System.Drawing.Point(12, 44);
            this.gbpacientes.Name = "gbpacientes";
            this.gbpacientes.Size = new System.Drawing.Size(706, 94);
            this.gbpacientes.TabIndex = 45;
            this.gbpacientes.TabStop = false;
            this.gbpacientes.Text = "Datos del Paciente:";
            // 
            // btnEliminarCita
            // 
            this.btnEliminarCita.Location = new System.Drawing.Point(448, 64);
            this.btnEliminarCita.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminarCita.Name = "btnEliminarCita";
            this.btnEliminarCita.Size = new System.Drawing.Size(97, 23);
            this.btnEliminarCita.TabIndex = 9;
            this.btnEliminarCita.Text = "Eliminar";
            this.btnEliminarCita.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEliminarCita.UseVisualStyleBackColor = true;
            this.btnEliminarCita.Click += new System.EventHandler(this.btnEliminarCita_Click);
            // 
            // btnBuscarPaciente
            // 
            this.btnBuscarPaciente.Location = new System.Drawing.Point(389, 36);
            this.btnBuscarPaciente.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscarPaciente.Name = "btnBuscarPaciente";
            this.btnBuscarPaciente.Size = new System.Drawing.Size(56, 23);
            this.btnBuscarPaciente.TabIndex = 8;
            this.btnBuscarPaciente.Text = "...";
            this.btnBuscarPaciente.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBuscarPaciente.UseVisualStyleBackColor = true;
            this.btnBuscarPaciente.Click += new System.EventHandler(this.btnBuscarPaciente_Click);
            // 
            // txtNombrePac
            // 
            this.txtNombrePac.Enabled = false;
            this.txtNombrePac.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombrePac.Location = new System.Drawing.Point(104, 36);
            this.txtNombrePac.Name = "txtNombrePac";
            this.txtNombrePac.Size = new System.Drawing.Size(280, 20);
            this.txtNombrePac.TabIndex = 7;
            // 
            // txtNombre
            // 
            this.txtNombre.AutoSize = true;
            this.txtNombre.Location = new System.Drawing.Point(6, 35);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(73, 18);
            this.txtNombre.TabIndex = 6;
            this.txtNombre.Text = "Nombre:";
            // 
            // txtDNIPac
            // 
            this.txtDNIPac.Enabled = false;
            this.txtDNIPac.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDNIPac.Location = new System.Drawing.Point(104, 65);
            this.txtDNIPac.Name = "txtDNIPac";
            this.txtDNIPac.Size = new System.Drawing.Size(280, 20);
            this.txtDNIPac.TabIndex = 5;
            // 
            // txtDNI
            // 
            this.txtDNI.AutoSize = true;
            this.txtDNI.Location = new System.Drawing.Point(36, 64);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(36, 18);
            this.txtDNI.TabIndex = 3;
            this.txtDNI.Text = "DNI";
            // 
            // dgvProgramaAtencion
            // 
            this.dgvProgramaAtencion.AllowUserToAddRows = false;
            this.dgvProgramaAtencion.AllowUserToDeleteRows = false;
            this.dgvProgramaAtencion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProgramaAtencion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProgramaAtencion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Producto,
            this.HoraInicio,
            this.HoraFIn});
            this.dgvProgramaAtencion.Location = new System.Drawing.Point(12, 427);
            this.dgvProgramaAtencion.Name = "dgvProgramaAtencion";
            this.dgvProgramaAtencion.ReadOnly = true;
            this.dgvProgramaAtencion.RowHeadersWidth = 51;
            this.dgvProgramaAtencion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProgramaAtencion.Size = new System.Drawing.Size(706, 106);
            this.dgvProgramaAtencion.TabIndex = 46;
            this.dgvProgramaAtencion.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvProgramaAtencion_CellFormatting);
            // 
            // btnReservaCita
            // 
            this.btnReservaCita.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservaCita.Location = new System.Drawing.Point(569, 539);
            this.btnReservaCita.Margin = new System.Windows.Forms.Padding(2);
            this.btnReservaCita.Name = "btnReservaCita";
            this.btnReservaCita.Size = new System.Drawing.Size(149, 27);
            this.btnReservaCita.TabIndex = 47;
            this.btnReservaCita.Text = "Reservar";
            this.btnReservaCita.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnReservaCita.UseVisualStyleBackColor = true;
            this.btnReservaCita.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::LP2Soft.Properties.Resources.images__2_1;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(521, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(133, 126);
            this.panel1.TabIndex = 41;
            // 
            // btnReservarCita
            // 
            this.btnReservarCita.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservarCita.Image = global::LP2Soft.Properties.Resources.recepcion;
            this.btnReservarCita.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnReservarCita.Name = "btnReservarCita";
            this.btnReservarCita.Size = new System.Drawing.Size(95, 24);
            this.btnReservarCita.Text = "&Nueva CIta";
            this.btnReservarCita.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnModificarCita
            // 
            this.btnModificarCita.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarCita.Image = global::LP2Soft.Properties.Resources.lupa__1_;
            this.btnModificarCita.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnModificarCita.Name = "btnModificarCita";
            this.btnModificarCita.Size = new System.Drawing.Size(114, 24);
            this.btnModificarCita.Text = "&Modificar Cita";
            this.btnModificarCita.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnCancelarReserva
            // 
            this.btnCancelarReserva.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarReserva.Image = global::LP2Soft.Properties.Resources.cerca;
            this.btnCancelarReserva.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelarReserva.Name = "btnCancelarReserva";
            this.btnCancelarReserva.Size = new System.Drawing.Size(85, 24);
            this.btnCancelarReserva.Text = "&Cancelar";
            this.btnCancelarReserva.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // Producto
            // 
            this.Producto.HeaderText = "#";
            this.Producto.MinimumWidth = 6;
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            // 
            // HoraInicio
            // 
            this.HoraInicio.HeaderText = "Hora de Inicio";
            this.HoraInicio.MinimumWidth = 6;
            this.HoraInicio.Name = "HoraInicio";
            this.HoraInicio.ReadOnly = true;
            // 
            // HoraFIn
            // 
            this.HoraFIn.HeaderText = "Hora Fin";
            this.HoraFIn.MinimumWidth = 6;
            this.HoraFIn.Name = "HoraFIn";
            this.HoraFIn.ReadOnly = true;
            // 
            // frmPacienteGestionarCitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(962, 422);
            this.Controls.Add(this.btnReservaCita);
            this.Controls.Add(this.dgvProgramaAtencion);
            this.Controls.Add(this.gbpacientes);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbCliente);
            this.Controls.Add(this.tsMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmPacienteGestionarCitas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbCliente.ResumeLayout(false);
            this.gbCliente.PerformLayout();
            this.tsMenu.ResumeLayout(false);
            this.tsMenu.PerformLayout();
            this.gbpacientes.ResumeLayout(false);
            this.gbpacientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProgramaAtencion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFechaHorario;
        private System.Windows.Forms.GroupBox gbCliente;
        private System.Windows.Forms.Label lblEspecialidadMedico;
        private System.Windows.Forms.Label lblNombreMedico;
        private System.Windows.Forms.ToolStrip tsMenu;
        private System.Windows.Forms.ToolStripButton btnReservarCita;
        private System.Windows.Forms.ToolStripButton btnModificarCita;
        private System.Windows.Forms.ToolStripButton btnCancelarReserva;
        private System.Windows.Forms.ComboBox cboEspecialidad;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gbpacientes;
        private System.Windows.Forms.Label txtNombre;
        private System.Windows.Forms.TextBox txtDNIPac;
        private System.Windows.Forms.Label txtDNI;
        private System.Windows.Forms.Button btnBuscarPaciente;
        private System.Windows.Forms.TextBox txtNombrePac;
        private System.Windows.Forms.ComboBox cboMedico;
        private System.Windows.Forms.Button btnHorDisp;
        private System.Windows.Forms.DataGridView dgvProgramaAtencion;
        private System.Windows.Forms.Button btnReservaCita;
        private System.Windows.Forms.Button btnEliminarCita;
        private System.Windows.Forms.LinkLabel TarjetaMedico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraFIn;
    }
}