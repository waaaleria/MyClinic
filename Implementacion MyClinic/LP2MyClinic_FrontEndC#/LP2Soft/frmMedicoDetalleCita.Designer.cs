namespace LP2Soft
{
    partial class frmMedicoDetalleCita
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMedicoDetalleCita));
            this.lblNombreCliente = new System.Windows.Forms.Label();
            this.txtNombrePaciente = new System.Windows.Forms.TextBox();
            this.lblEspecialidad = new System.Windows.Forms.Label();
            this.textEspecialidadAtendida = new System.Windows.Forms.TextBox();
            this.gbPedido = new System.Windows.Forms.GroupBox();
            this.btnModificarCita = new System.Windows.Forms.Button();
            this.btnGuardarCambios = new System.Windows.Forms.Button();
            this.txtMotivoCita = new System.Windows.Forms.TextBox();
            this.dtpFechaCita = new System.Windows.Forms.DateTimePicker();
            this.lblDescripcionCita = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Pestañas = new System.Windows.Forms.TabControl();
            this.tabDiagnostico = new System.Windows.Forms.TabPage();
            this.btnAgregarDiagnostico = new System.Windows.Forms.Button();
            this.lblTratamientoDiagnostico = new System.Windows.Forms.Label();
            this.lblDescripcionDiagnostico = new System.Windows.Forms.Label();
            this.txtTratamientoDiagnostico = new System.Windows.Forms.TextBox();
            this.txtDescripcionDiagnostico = new System.Windows.Forms.TextBox();
            this.btnEliminarDiagnostico = new System.Windows.Forms.Button();
            this.dgvDiagnosticoCita = new System.Windows.Forms.DataGridView();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tratamiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabRecetaMedica = new System.Windows.Forms.TabPage();
            this.btnQuitarMedicamento = new System.Windows.Forms.Button();
            this.btnAgregarMedicamento = new System.Windows.Forms.Button();
            this.lblFrecuencia = new System.Windows.Forms.Label();
            this.lblDosis = new System.Windows.Forms.Label();
            this.lblNombreMedicamento = new System.Windows.Forms.Label();
            this.btnBuscarMedicamento = new System.Windows.Forms.Button();
            this.txtNombreMedicamento = new System.Windows.Forms.TextBox();
            this.txtFrecuenciaMedicamento = new System.Windows.Forms.TextBox();
            this.txtDosisMedicamento = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpVigenciaFinal = new System.Windows.Forms.DateTimePicker();
            this.dgvRecetaMedica = new System.Windows.Forms.DataGridView();
            this.idMedicamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreMedicamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dosis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Frecuencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbPedido.SuspendLayout();
            this.Pestañas.SuspendLayout();
            this.tabDiagnostico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiagnosticoCita)).BeginInit();
            this.tabRecetaMedica.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecetaMedica)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.AutoSize = true;
            this.lblNombreCliente.Location = new System.Drawing.Point(16, 88);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(143, 17);
            this.lblNombreCliente.TabIndex = 3;
            this.lblNombreCliente.Text = "Nombre del paciente:";
            // 
            // txtNombrePaciente
            // 
            this.txtNombrePaciente.Enabled = false;
            this.txtNombrePaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombrePaciente.Location = new System.Drawing.Point(178, 88);
            this.txtNombrePaciente.Name = "txtNombrePaciente";
            this.txtNombrePaciente.ReadOnly = true;
            this.txtNombrePaciente.Size = new System.Drawing.Size(267, 20);
            this.txtNombrePaciente.TabIndex = 2;
            // 
            // lblEspecialidad
            // 
            this.lblEspecialidad.AutoSize = true;
            this.lblEspecialidad.Location = new System.Drawing.Point(65, 29);
            this.lblEspecialidad.Name = "lblEspecialidad";
            this.lblEspecialidad.Size = new System.Drawing.Size(92, 17);
            this.lblEspecialidad.TabIndex = 5;
            this.lblEspecialidad.Text = "Especialidad:";
            // 
            // textEspecialidadAtendida
            // 
            this.textEspecialidadAtendida.Enabled = false;
            this.textEspecialidadAtendida.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEspecialidadAtendida.Location = new System.Drawing.Point(178, 29);
            this.textEspecialidadAtendida.Name = "textEspecialidadAtendida";
            this.textEspecialidadAtendida.ReadOnly = true;
            this.textEspecialidadAtendida.Size = new System.Drawing.Size(267, 20);
            this.textEspecialidadAtendida.TabIndex = 4;
            // 
            // gbPedido
            // 
            this.gbPedido.Controls.Add(this.btnModificarCita);
            this.gbPedido.Controls.Add(this.btnGuardarCambios);
            this.gbPedido.Controls.Add(this.txtNombrePaciente);
            this.gbPedido.Controls.Add(this.lblNombreCliente);
            this.gbPedido.Controls.Add(this.lblEspecialidad);
            this.gbPedido.Controls.Add(this.txtMotivoCita);
            this.gbPedido.Controls.Add(this.dtpFechaCita);
            this.gbPedido.Controls.Add(this.lblDescripcionCita);
            this.gbPedido.Controls.Add(this.textEspecialidadAtendida);
            this.gbPedido.Controls.Add(this.label2);
            this.gbPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPedido.Location = new System.Drawing.Point(12, 12);
            this.gbPedido.Name = "gbPedido";
            this.gbPedido.Size = new System.Drawing.Size(654, 166);
            this.gbPedido.TabIndex = 16;
            this.gbPedido.TabStop = false;
            this.gbPedido.Text = "Datos de la Cita Médica";
            // 
            // btnModificarCita
            // 
            this.btnModificarCita.Location = new System.Drawing.Point(467, 29);
            this.btnModificarCita.Name = "btnModificarCita";
            this.btnModificarCita.Size = new System.Drawing.Size(163, 31);
            this.btnModificarCita.TabIndex = 28;
            this.btnModificarCita.Text = "Modificar cita";
            this.btnModificarCita.UseVisualStyleBackColor = true;
            this.btnModificarCita.Click += new System.EventHandler(this.bntModificarCita_Click);
            // 
            // btnGuardarCambios
            // 
            this.btnGuardarCambios.Location = new System.Drawing.Point(467, 71);
            this.btnGuardarCambios.Name = "btnGuardarCambios";
            this.btnGuardarCambios.Size = new System.Drawing.Size(163, 29);
            this.btnGuardarCambios.TabIndex = 27;
            this.btnGuardarCambios.Text = "Guardar cambios";
            this.btnGuardarCambios.UseVisualStyleBackColor = true;
            this.btnGuardarCambios.Click += new System.EventHandler(this.btnGuardarCambios_Click);
            // 
            // txtMotivoCita
            // 
            this.txtMotivoCita.Location = new System.Drawing.Point(178, 116);
            this.txtMotivoCita.Margin = new System.Windows.Forms.Padding(2);
            this.txtMotivoCita.Multiline = true;
            this.txtMotivoCita.Name = "txtMotivoCita";
            this.txtMotivoCita.Size = new System.Drawing.Size(452, 40);
            this.txtMotivoCita.TabIndex = 25;
            // 
            // dtpFechaCita
            // 
            this.dtpFechaCita.Enabled = false;
            this.dtpFechaCita.Location = new System.Drawing.Point(178, 55);
            this.dtpFechaCita.Name = "dtpFechaCita";
            this.dtpFechaCita.Size = new System.Drawing.Size(267, 23);
            this.dtpFechaCita.TabIndex = 3;
            this.dtpFechaCita.TabStop = false;
            this.dtpFechaCita.Value = new System.DateTime(2023, 6, 14, 0, 0, 0, 0);
            // 
            // lblDescripcionCita
            // 
            this.lblDescripcionCita.AutoSize = true;
            this.lblDescripcionCita.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcionCita.Location = new System.Drawing.Point(45, 116);
            this.lblDescripcionCita.Name = "lblDescripcionCita";
            this.lblDescripcionCita.Size = new System.Drawing.Size(114, 17);
            this.lblDescripcionCita.TabIndex = 24;
            this.lblDescripcionCita.Text = "Motivo de la cita:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fecha de la cita:";
            // 
            // Pestañas
            // 
            this.Pestañas.Controls.Add(this.tabDiagnostico);
            this.Pestañas.Controls.Add(this.tabRecetaMedica);
            this.Pestañas.Location = new System.Drawing.Point(12, 184);
            this.Pestañas.Name = "Pestañas";
            this.Pestañas.SelectedIndex = 0;
            this.Pestañas.Size = new System.Drawing.Size(654, 254);
            this.Pestañas.TabIndex = 26;
            // 
            // tabDiagnostico
            // 
            this.tabDiagnostico.BackColor = System.Drawing.Color.Transparent;
            this.tabDiagnostico.Controls.Add(this.btnAgregarDiagnostico);
            this.tabDiagnostico.Controls.Add(this.lblTratamientoDiagnostico);
            this.tabDiagnostico.Controls.Add(this.lblDescripcionDiagnostico);
            this.tabDiagnostico.Controls.Add(this.txtTratamientoDiagnostico);
            this.tabDiagnostico.Controls.Add(this.txtDescripcionDiagnostico);
            this.tabDiagnostico.Controls.Add(this.btnEliminarDiagnostico);
            this.tabDiagnostico.Controls.Add(this.dgvDiagnosticoCita);
            this.tabDiagnostico.Location = new System.Drawing.Point(4, 22);
            this.tabDiagnostico.Name = "tabDiagnostico";
            this.tabDiagnostico.Padding = new System.Windows.Forms.Padding(3);
            this.tabDiagnostico.Size = new System.Drawing.Size(646, 228);
            this.tabDiagnostico.TabIndex = 1;
            this.tabDiagnostico.Text = "Diagnostico";
            // 
            // btnAgregarDiagnostico
            // 
            this.btnAgregarDiagnostico.Location = new System.Drawing.Point(381, 27);
            this.btnAgregarDiagnostico.Name = "btnAgregarDiagnostico";
            this.btnAgregarDiagnostico.Size = new System.Drawing.Size(177, 23);
            this.btnAgregarDiagnostico.TabIndex = 43;
            this.btnAgregarDiagnostico.Text = "Agregar diagnostico";
            this.btnAgregarDiagnostico.UseVisualStyleBackColor = true;
            this.btnAgregarDiagnostico.Click += new System.EventHandler(this.btnAgregarDiagnostico_Click);
            // 
            // lblTratamientoDiagnostico
            // 
            this.lblTratamientoDiagnostico.AutoSize = true;
            this.lblTratamientoDiagnostico.Location = new System.Drawing.Point(12, 66);
            this.lblTratamientoDiagnostico.Name = "lblTratamientoDiagnostico";
            this.lblTratamientoDiagnostico.Size = new System.Drawing.Size(66, 13);
            this.lblTratamientoDiagnostico.TabIndex = 42;
            this.lblTratamientoDiagnostico.Text = "Tratamiento:";
            // 
            // lblDescripcionDiagnostico
            // 
            this.lblDescripcionDiagnostico.AutoSize = true;
            this.lblDescripcionDiagnostico.Location = new System.Drawing.Point(12, 27);
            this.lblDescripcionDiagnostico.Name = "lblDescripcionDiagnostico";
            this.lblDescripcionDiagnostico.Size = new System.Drawing.Size(66, 13);
            this.lblDescripcionDiagnostico.TabIndex = 41;
            this.lblDescripcionDiagnostico.Text = "Descripcion:";
            // 
            // txtTratamientoDiagnostico
            // 
            this.txtTratamientoDiagnostico.Enabled = false;
            this.txtTratamientoDiagnostico.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTratamientoDiagnostico.Location = new System.Drawing.Point(84, 63);
            this.txtTratamientoDiagnostico.Name = "txtTratamientoDiagnostico";
            this.txtTratamientoDiagnostico.Size = new System.Drawing.Size(267, 20);
            this.txtTratamientoDiagnostico.TabIndex = 40;
            // 
            // txtDescripcionDiagnostico
            // 
            this.txtDescripcionDiagnostico.Enabled = false;
            this.txtDescripcionDiagnostico.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcionDiagnostico.Location = new System.Drawing.Point(84, 27);
            this.txtDescripcionDiagnostico.Name = "txtDescripcionDiagnostico";
            this.txtDescripcionDiagnostico.Size = new System.Drawing.Size(267, 20);
            this.txtDescripcionDiagnostico.TabIndex = 29;
            // 
            // btnEliminarDiagnostico
            // 
            this.btnEliminarDiagnostico.Location = new System.Drawing.Point(381, 61);
            this.btnEliminarDiagnostico.Name = "btnEliminarDiagnostico";
            this.btnEliminarDiagnostico.Size = new System.Drawing.Size(177, 23);
            this.btnEliminarDiagnostico.TabIndex = 39;
            this.btnEliminarDiagnostico.Text = "Eliminar diagnostico";
            this.btnEliminarDiagnostico.UseVisualStyleBackColor = true;
            this.btnEliminarDiagnostico.Click += new System.EventHandler(this.btnEliminarDiagnostico_Click);
            // 
            // dgvDiagnosticoCita
            // 
            this.dgvDiagnosticoCita.AllowUserToAddRows = false;
            this.dgvDiagnosticoCita.AllowUserToDeleteRows = false;
            this.dgvDiagnosticoCita.AllowUserToResizeColumns = false;
            this.dgvDiagnosticoCita.AllowUserToResizeRows = false;
            this.dgvDiagnosticoCita.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDiagnosticoCita.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiagnosticoCita.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Descripcion,
            this.Tratamiento});
            this.dgvDiagnosticoCita.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvDiagnosticoCita.Enabled = false;
            this.dgvDiagnosticoCita.Location = new System.Drawing.Point(15, 99);
            this.dgvDiagnosticoCita.Name = "dgvDiagnosticoCita";
            this.dgvDiagnosticoCita.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvDiagnosticoCita.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDiagnosticoCita.Size = new System.Drawing.Size(611, 111);
            this.dgvDiagnosticoCita.TabIndex = 30;
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "descripcion";
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            // 
            // Tratamiento
            // 
            this.Tratamiento.DataPropertyName = "tratamiento";
            this.Tratamiento.HeaderText = "Tratamiento";
            this.Tratamiento.Name = "Tratamiento";
            // 
            // tabRecetaMedica
            // 
            this.tabRecetaMedica.BackColor = System.Drawing.Color.Transparent;
            this.tabRecetaMedica.Controls.Add(this.btnQuitarMedicamento);
            this.tabRecetaMedica.Controls.Add(this.btnAgregarMedicamento);
            this.tabRecetaMedica.Controls.Add(this.lblFrecuencia);
            this.tabRecetaMedica.Controls.Add(this.lblDosis);
            this.tabRecetaMedica.Controls.Add(this.lblNombreMedicamento);
            this.tabRecetaMedica.Controls.Add(this.btnBuscarMedicamento);
            this.tabRecetaMedica.Controls.Add(this.txtNombreMedicamento);
            this.tabRecetaMedica.Controls.Add(this.txtFrecuenciaMedicamento);
            this.tabRecetaMedica.Controls.Add(this.txtDosisMedicamento);
            this.tabRecetaMedica.Controls.Add(this.label1);
            this.tabRecetaMedica.Controls.Add(this.dtpVigenciaFinal);
            this.tabRecetaMedica.Controls.Add(this.dgvRecetaMedica);
            this.tabRecetaMedica.Location = new System.Drawing.Point(4, 22);
            this.tabRecetaMedica.Name = "tabRecetaMedica";
            this.tabRecetaMedica.Size = new System.Drawing.Size(646, 228);
            this.tabRecetaMedica.TabIndex = 3;
            this.tabRecetaMedica.Text = "Receta";
            // 
            // btnQuitarMedicamento
            // 
            this.btnQuitarMedicamento.Location = new System.Drawing.Point(24, 181);
            this.btnQuitarMedicamento.Name = "btnQuitarMedicamento";
            this.btnQuitarMedicamento.Size = new System.Drawing.Size(98, 23);
            this.btnQuitarMedicamento.TabIndex = 45;
            this.btnQuitarMedicamento.Text = "Quitar";
            this.btnQuitarMedicamento.UseVisualStyleBackColor = true;
            this.btnQuitarMedicamento.Click += new System.EventHandler(this.btnQuitarMedicamento_Click);
            // 
            // btnAgregarMedicamento
            // 
            this.btnAgregarMedicamento.Location = new System.Drawing.Point(158, 181);
            this.btnAgregarMedicamento.Name = "btnAgregarMedicamento";
            this.btnAgregarMedicamento.Size = new System.Drawing.Size(98, 23);
            this.btnAgregarMedicamento.TabIndex = 44;
            this.btnAgregarMedicamento.Text = "Agregar";
            this.btnAgregarMedicamento.UseVisualStyleBackColor = true;
            this.btnAgregarMedicamento.Click += new System.EventHandler(this.btnAgregarMedicamento_Click);
            // 
            // lblFrecuencia
            // 
            this.lblFrecuencia.AutoSize = true;
            this.lblFrecuencia.Location = new System.Drawing.Point(23, 127);
            this.lblFrecuencia.Name = "lblFrecuencia";
            this.lblFrecuencia.Size = new System.Drawing.Size(63, 13);
            this.lblFrecuencia.TabIndex = 43;
            this.lblFrecuencia.Text = "Frecuencia:";
            // 
            // lblDosis
            // 
            this.lblDosis.AutoSize = true;
            this.lblDosis.Location = new System.Drawing.Point(23, 79);
            this.lblDosis.Name = "lblDosis";
            this.lblDosis.Size = new System.Drawing.Size(36, 13);
            this.lblDosis.TabIndex = 42;
            this.lblDosis.Text = "Dosis:";
            // 
            // lblNombreMedicamento
            // 
            this.lblNombreMedicamento.AutoSize = true;
            this.lblNombreMedicamento.Location = new System.Drawing.Point(23, 19);
            this.lblNombreMedicamento.Name = "lblNombreMedicamento";
            this.lblNombreMedicamento.Size = new System.Drawing.Size(130, 13);
            this.lblNombreMedicamento.TabIndex = 41;
            this.lblNombreMedicamento.Text = "Nombre del medicamento:";
            // 
            // btnBuscarMedicamento
            // 
            this.btnBuscarMedicamento.BackgroundImage = global::LP2Soft.Properties.Resources.WhatsApp_Image_2023_05_28_at_11_45_22_PM;
            this.btnBuscarMedicamento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscarMedicamento.Location = new System.Drawing.Point(229, 34);
            this.btnBuscarMedicamento.Name = "btnBuscarMedicamento";
            this.btnBuscarMedicamento.Size = new System.Drawing.Size(27, 25);
            this.btnBuscarMedicamento.TabIndex = 29;
            this.btnBuscarMedicamento.UseVisualStyleBackColor = true;
            this.btnBuscarMedicamento.Click += new System.EventHandler(this.btnBuscarMedicamento_Click_1);
            // 
            // txtNombreMedicamento
            // 
            this.txtNombreMedicamento.Enabled = false;
            this.txtNombreMedicamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreMedicamento.Location = new System.Drawing.Point(24, 37);
            this.txtNombreMedicamento.Name = "txtNombreMedicamento";
            this.txtNombreMedicamento.ReadOnly = true;
            this.txtNombreMedicamento.Size = new System.Drawing.Size(199, 20);
            this.txtNombreMedicamento.TabIndex = 40;
            // 
            // txtFrecuenciaMedicamento
            // 
            this.txtFrecuenciaMedicamento.Enabled = false;
            this.txtFrecuenciaMedicamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFrecuenciaMedicamento.Location = new System.Drawing.Point(24, 143);
            this.txtFrecuenciaMedicamento.Name = "txtFrecuenciaMedicamento";
            this.txtFrecuenciaMedicamento.Size = new System.Drawing.Size(232, 20);
            this.txtFrecuenciaMedicamento.TabIndex = 39;
            // 
            // txtDosisMedicamento
            // 
            this.txtDosisMedicamento.Enabled = false;
            this.txtDosisMedicamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDosisMedicamento.Location = new System.Drawing.Point(24, 95);
            this.txtDosisMedicamento.Name = "txtDosisMedicamento";
            this.txtDosisMedicamento.Size = new System.Drawing.Size(232, 20);
            this.txtDosisMedicamento.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(296, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "Receta vigente hasta:";
            // 
            // dtpVigenciaFinal
            // 
            this.dtpVigenciaFinal.Location = new System.Drawing.Point(414, 184);
            this.dtpVigenciaFinal.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.dtpVigenciaFinal.MinDate = new System.DateTime(2023, 1, 1, 0, 0, 0, 0);
            this.dtpVigenciaFinal.Name = "dtpVigenciaFinal";
            this.dtpVigenciaFinal.Size = new System.Drawing.Size(212, 20);
            this.dtpVigenciaFinal.TabIndex = 36;
            this.dtpVigenciaFinal.Value = new System.DateTime(2023, 6, 25, 0, 0, 0, 0);
            // 
            // dgvRecetaMedica
            // 
            this.dgvRecetaMedica.AllowUserToAddRows = false;
            this.dgvRecetaMedica.AllowUserToDeleteRows = false;
            this.dgvRecetaMedica.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRecetaMedica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecetaMedica.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idMedicamento,
            this.NombreMedicamento,
            this.Dosis,
            this.Frecuencia});
            this.dgvRecetaMedica.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvRecetaMedica.Location = new System.Drawing.Point(299, 19);
            this.dgvRecetaMedica.Name = "dgvRecetaMedica";
            this.dgvRecetaMedica.ReadOnly = true;
            this.dgvRecetaMedica.RowHeadersWidth = 51;
            this.dgvRecetaMedica.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRecetaMedica.ShowCellToolTips = false;
            this.dgvRecetaMedica.Size = new System.Drawing.Size(327, 152);
            this.dgvRecetaMedica.TabIndex = 33;
            // 
            // idMedicamento
            // 
            this.idMedicamento.DataPropertyName = "idMedicamento";
            this.idMedicamento.HeaderText = "idMedicamento";
            this.idMedicamento.Name = "idMedicamento";
            this.idMedicamento.ReadOnly = true;
            this.idMedicamento.Visible = false;
            // 
            // NombreMedicamento
            // 
            this.NombreMedicamento.DataPropertyName = "nombreMedicamento";
            this.NombreMedicamento.HeaderText = "Medicamento";
            this.NombreMedicamento.MinimumWidth = 6;
            this.NombreMedicamento.Name = "NombreMedicamento";
            this.NombreMedicamento.ReadOnly = true;
            // 
            // Dosis
            // 
            this.Dosis.DataPropertyName = "dosis";
            dataGridViewCellStyle2.Format = "N2";
            this.Dosis.DefaultCellStyle = dataGridViewCellStyle2;
            this.Dosis.HeaderText = "Dosis";
            this.Dosis.MinimumWidth = 6;
            this.Dosis.Name = "Dosis";
            this.Dosis.ReadOnly = true;
            // 
            // Frecuencia
            // 
            this.Frecuencia.DataPropertyName = "frecuencia";
            this.Frecuencia.HeaderText = "Frecuencia";
            this.Frecuencia.Name = "Frecuencia";
            this.Frecuencia.ReadOnly = true;
            // 
            // frmMedicoDetalleCita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 450);
            this.Controls.Add(this.Pestañas);
            this.Controls.Add(this.gbPedido);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMedicoDetalleCita";
            this.gbPedido.ResumeLayout(false);
            this.gbPedido.PerformLayout();
            this.Pestañas.ResumeLayout(false);
            this.tabDiagnostico.ResumeLayout(false);
            this.tabDiagnostico.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiagnosticoCita)).EndInit();
            this.tabRecetaMedica.ResumeLayout(false);
            this.tabRecetaMedica.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecetaMedica)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblEspecialidad;
        private System.Windows.Forms.TextBox textEspecialidadAtendida;
        private System.Windows.Forms.Label lblNombreCliente;
        private System.Windows.Forms.TextBox txtNombrePaciente;
        private System.Windows.Forms.GroupBox gbPedido;
        private System.Windows.Forms.DateTimePicker dtpFechaCita;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMotivoCita;
        private System.Windows.Forms.Label lblDescripcionCita;
        private System.Windows.Forms.TabControl Pestañas;
        private System.Windows.Forms.TabPage tabDiagnostico;
        private System.Windows.Forms.DataGridView dgvDiagnosticoCita;
        private System.Windows.Forms.TabPage tabRecetaMedica;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpVigenciaFinal;
        private System.Windows.Forms.DataGridView dgvRecetaMedica;
        private System.Windows.Forms.Button btnGuardarCambios;
        private System.Windows.Forms.Button btnModificarCita;
        private System.Windows.Forms.Button btnEliminarDiagnostico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tratamiento;
        private System.Windows.Forms.Label lblDescripcionDiagnostico;
        private System.Windows.Forms.TextBox txtTratamientoDiagnostico;
        private System.Windows.Forms.TextBox txtDescripcionDiagnostico;
        private System.Windows.Forms.Label lblTratamientoDiagnostico;
        private System.Windows.Forms.Button btnAgregarDiagnostico;
        private System.Windows.Forms.Label lblNombreMedicamento;
        private System.Windows.Forms.Button btnBuscarMedicamento;
        private System.Windows.Forms.TextBox txtNombreMedicamento;
        private System.Windows.Forms.TextBox txtFrecuenciaMedicamento;
        private System.Windows.Forms.TextBox txtDosisMedicamento;
        private System.Windows.Forms.Label lblFrecuencia;
        private System.Windows.Forms.Label lblDosis;
        private System.Windows.Forms.Button btnQuitarMedicamento;
        private System.Windows.Forms.Button btnAgregarMedicamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMedicamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreMedicamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dosis;
        private System.Windows.Forms.DataGridViewTextBoxColumn Frecuencia;
    }
}