namespace LP2Soft
{
    partial class frmAdministradorGestionarMedico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdministradorGestionarMedico));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.dgvDetalleHorario = new System.Windows.Forms.DataGridView();
            this.gbHorarioDisponible = new System.Windows.Forms.GroupBox();
            this.cboHoraFin = new System.Windows.Forms.ComboBox();
            this.cboHoraInicio = new System.Windows.Forms.ComboBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.btnAgregarAgregar = new System.Windows.Forms.Button();
            this.lblHoraFin = new System.Windows.Forms.Label();
            this.lblHoraInicio = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.gbMedico = new System.Windows.Forms.GroupBox();
            this.txtEspecialidadMedico = new System.Windows.Forms.TextBox();
            this.lblEspecialidadDat = new System.Windows.Forms.Label();
            this.btnBuscarMedico = new System.Windows.Forms.Button();
            this.lblNombreMedico = new System.Windows.Forms.Label();
            this.txtNombreMedico = new System.Windows.Forms.TextBox();
            this.buttonBuscarMedicoo = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.ToolStripButton();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.Num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Horario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreMedico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Especialidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleHorario)).BeginInit();
            this.gbHorarioDisponible.SuspendLayout();
            this.gbMedico.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNuevo,
            this.btnCancelar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(748, 27);
            this.toolStrip1.TabIndex = 23;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // dgvDetalleHorario
            // 
            this.dgvDetalleHorario.AllowUserToAddRows = false;
            this.dgvDetalleHorario.AllowUserToDeleteRows = false;
            this.dgvDetalleHorario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetalleHorario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleHorario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Num,
            this.Fecha,
            this.Horario,
            this.NombreMedico,
            this.Especialidad});
            this.dgvDetalleHorario.Location = new System.Drawing.Point(12, 263);
            this.dgvDetalleHorario.Name = "dgvDetalleHorario";
            this.dgvDetalleHorario.ReadOnly = true;
            this.dgvDetalleHorario.RowHeadersWidth = 51;
            this.dgvDetalleHorario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetalleHorario.Size = new System.Drawing.Size(688, 121);
            this.dgvDetalleHorario.TabIndex = 22;
            this.dgvDetalleHorario.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvDetalleHorario_CellFormatting);
            // 
            // gbHorarioDisponible
            // 
            this.gbHorarioDisponible.Controls.Add(this.cboHoraFin);
            this.gbHorarioDisponible.Controls.Add(this.buttonBuscarMedicoo);
            this.gbHorarioDisponible.Controls.Add(this.cboHoraInicio);
            this.gbHorarioDisponible.Controls.Add(this.dtpFecha);
            this.gbHorarioDisponible.Controls.Add(this.btnAgregarAgregar);
            this.gbHorarioDisponible.Controls.Add(this.lblHoraFin);
            this.gbHorarioDisponible.Controls.Add(this.lblHoraInicio);
            this.gbHorarioDisponible.Controls.Add(this.lblFecha);
            this.gbHorarioDisponible.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbHorarioDisponible.Location = new System.Drawing.Point(12, 103);
            this.gbHorarioDisponible.Name = "gbHorarioDisponible";
            this.gbHorarioDisponible.Size = new System.Drawing.Size(688, 140);
            this.gbHorarioDisponible.TabIndex = 21;
            this.gbHorarioDisponible.TabStop = false;
            this.gbHorarioDisponible.Text = "Ingresar horarios disponibles";
            // 
            // cboHoraFin
            // 
            this.cboHoraFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboHoraFin.FormattingEnabled = true;
            this.cboHoraFin.Location = new System.Drawing.Point(157, 94);
            this.cboHoraFin.Name = "cboHoraFin";
            this.cboHoraFin.Size = new System.Drawing.Size(292, 24);
            this.cboHoraFin.TabIndex = 19;
            // 
            // cboHoraInicio
            // 
            this.cboHoraInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboHoraInicio.FormattingEnabled = true;
            this.cboHoraInicio.Location = new System.Drawing.Point(157, 60);
            this.cboHoraInicio.Name = "cboHoraInicio";
            this.cboHoraInicio.Size = new System.Drawing.Size(292, 24);
            this.cboHoraInicio.TabIndex = 18;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Location = new System.Drawing.Point(157, 26);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(292, 22);
            this.dtpFecha.TabIndex = 17;
            // 
            // btnAgregarAgregar
            // 
            this.btnAgregarAgregar.Location = new System.Drawing.Point(483, 56);
            this.btnAgregarAgregar.Name = "btnAgregarAgregar";
            this.btnAgregarAgregar.Size = new System.Drawing.Size(174, 28);
            this.btnAgregarAgregar.TabIndex = 10;
            this.btnAgregarAgregar.Text = "Asignar horario";
            this.btnAgregarAgregar.UseVisualStyleBackColor = true;
            this.btnAgregarAgregar.Click += new System.EventHandler(this.btnAgregarAgregar_Click);
            // 
            // lblHoraFin
            // 
            this.lblHoraFin.AutoSize = true;
            this.lblHoraFin.Location = new System.Drawing.Point(47, 96);
            this.lblHoraFin.Name = "lblHoraFin";
            this.lblHoraFin.Size = new System.Drawing.Size(104, 17);
            this.lblHoraFin.TabIndex = 6;
            this.lblHoraFin.Text = "Hora de salida:";
            // 
            // lblHoraInicio
            // 
            this.lblHoraInicio.AutoSize = true;
            this.lblHoraInicio.Location = new System.Drawing.Point(52, 60);
            this.lblHoraInicio.Name = "lblHoraInicio";
            this.lblHoraInicio.Size = new System.Drawing.Size(99, 17);
            this.lblHoraInicio.TabIndex = 4;
            this.lblHoraInicio.Text = "Hora de inicio:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(97, 31);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(51, 17);
            this.lblFecha.TabIndex = 1;
            this.lblFecha.Text = "Fecha:";
            // 
            // gbMedico
            // 
            this.gbMedico.Controls.Add(this.txtEspecialidadMedico);
            this.gbMedico.Controls.Add(this.lblEspecialidadDat);
            this.gbMedico.Controls.Add(this.btnBuscarMedico);
            this.gbMedico.Controls.Add(this.lblNombreMedico);
            this.gbMedico.Controls.Add(this.txtNombreMedico);
            this.gbMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbMedico.Location = new System.Drawing.Point(12, 30);
            this.gbMedico.Name = "gbMedico";
            this.gbMedico.Size = new System.Drawing.Size(679, 67);
            this.gbMedico.TabIndex = 20;
            this.gbMedico.TabStop = false;
            this.gbMedico.Text = "Datos del Medico";
            // 
            // txtEspecialidadMedico
            // 
            this.txtEspecialidadMedico.Enabled = false;
            this.txtEspecialidadMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEspecialidadMedico.Location = new System.Drawing.Point(441, 26);
            this.txtEspecialidadMedico.Name = "txtEspecialidadMedico";
            this.txtEspecialidadMedico.ReadOnly = true;
            this.txtEspecialidadMedico.Size = new System.Drawing.Size(162, 20);
            this.txtEspecialidadMedico.TabIndex = 6;
            // 
            // lblEspecialidadDat
            // 
            this.lblEspecialidadDat.AutoSize = true;
            this.lblEspecialidadDat.Location = new System.Drawing.Point(343, 28);
            this.lblEspecialidadDat.Name = "lblEspecialidadDat";
            this.lblEspecialidadDat.Size = new System.Drawing.Size(92, 17);
            this.lblEspecialidadDat.TabIndex = 5;
            this.lblEspecialidadDat.Text = "Especialidad:";
            // 
            // btnBuscarMedico
            // 
            this.btnBuscarMedico.BackgroundImage = global::LP2Soft.Properties.Resources.lupa__1_;
            this.btnBuscarMedico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscarMedico.Location = new System.Drawing.Point(645, 26);
            this.btnBuscarMedico.Name = "btnBuscarMedico";
            this.btnBuscarMedico.Size = new System.Drawing.Size(28, 23);
            this.btnBuscarMedico.TabIndex = 4;
            this.btnBuscarMedico.UseVisualStyleBackColor = true;
            this.btnBuscarMedico.Click += new System.EventHandler(this.btnBuscarMedico_Click);
            // 
            // lblNombreMedico
            // 
            this.lblNombreMedico.AutoSize = true;
            this.lblNombreMedico.Location = new System.Drawing.Point(23, 28);
            this.lblNombreMedico.Name = "lblNombreMedico";
            this.lblNombreMedico.Size = new System.Drawing.Size(125, 17);
            this.lblNombreMedico.TabIndex = 3;
            this.lblNombreMedico.Text = "Nombre Completo:";
            // 
            // txtNombreMedico
            // 
            this.txtNombreMedico.Enabled = false;
            this.txtNombreMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreMedico.Location = new System.Drawing.Point(155, 26);
            this.txtNombreMedico.Name = "txtNombreMedico";
            this.txtNombreMedico.ReadOnly = true;
            this.txtNombreMedico.Size = new System.Drawing.Size(164, 20);
            this.txtNombreMedico.TabIndex = 2;
            // 
            // buttonBuscarMedicoo
            // 
            this.buttonBuscarMedicoo.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonBuscarMedicoo.FlatAppearance.BorderSize = 0;
            this.buttonBuscarMedicoo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBuscarMedicoo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscarMedicoo.ForeColor = System.Drawing.Color.White;
            this.buttonBuscarMedicoo.Location = new System.Drawing.Point(483, 90);
            this.buttonBuscarMedicoo.Margin = new System.Windows.Forms.Padding(2);
            this.buttonBuscarMedicoo.Name = "buttonBuscarMedicoo";
            this.buttonBuscarMedicoo.Size = new System.Drawing.Size(174, 28);
            this.buttonBuscarMedicoo.TabIndex = 8;
            this.buttonBuscarMedicoo.Text = "Buscar horarios";
            this.buttonBuscarMedicoo.UseVisualStyleBackColor = false;
            this.buttonBuscarMedicoo.Click += new System.EventHandler(this.buttonBuscarMedicoo_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnImprimir.FlatAppearance.BorderSize = 0;
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.ForeColor = System.Drawing.Color.White;
            this.btnImprimir.Location = new System.Drawing.Point(495, 389);
            this.btnImprimir.Margin = new System.Windows.Forms.Padding(2);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(202, 28);
            this.btnImprimir.TabIndex = 24;
            this.btnImprimir.Text = "IMPRIMIR HORARIOS";
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = global::LP2Soft.Properties.Resources.recepcion;
            this.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(73, 24);
            this.btnNuevo.Text = "&Nuevo";
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::LP2Soft.Properties.Resources.cerca;
            this.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(88, 24);
            this.btnCancelar.Text = "&Cancelar";
            // 
            // Num
            // 
            this.Num.HeaderText = "#";
            this.Num.MinimumWidth = 6;
            this.Num.Name = "Num";
            this.Num.ReadOnly = true;
            this.Num.Visible = false;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.MinimumWidth = 6;
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // Horario
            // 
            this.Horario.HeaderText = "Horario";
            this.Horario.MinimumWidth = 6;
            this.Horario.Name = "Horario";
            this.Horario.ReadOnly = true;
            // 
            // NombreMedico
            // 
            this.NombreMedico.HeaderText = "Nombre Medico";
            this.NombreMedico.MinimumWidth = 6;
            this.NombreMedico.Name = "NombreMedico";
            this.NombreMedico.ReadOnly = true;
            // 
            // Especialidad
            // 
            this.Especialidad.HeaderText = "Especialidad";
            this.Especialidad.MinimumWidth = 6;
            this.Especialidad.Name = "Especialidad";
            this.Especialidad.ReadOnly = true;
            // 
            // frmAdministradorGestionarMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 422);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgvDetalleHorario);
            this.Controls.Add(this.gbHorarioDisponible);
            this.Controls.Add(this.gbMedico);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmAdministradorGestionarMedico";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleHorario)).EndInit();
            this.gbHorarioDisponible.ResumeLayout(false);
            this.gbHorarioDisponible.PerformLayout();
            this.gbMedico.ResumeLayout(false);
            this.gbMedico.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnNuevo;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private System.Windows.Forms.DataGridView dgvDetalleHorario;
        private System.Windows.Forms.GroupBox gbHorarioDisponible;
        private System.Windows.Forms.ComboBox cboHoraFin;
        private System.Windows.Forms.ComboBox cboHoraInicio;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Button btnAgregarAgregar;
        private System.Windows.Forms.Label lblHoraFin;
        private System.Windows.Forms.Label lblHoraInicio;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.GroupBox gbMedico;
        private System.Windows.Forms.TextBox txtEspecialidadMedico;
        private System.Windows.Forms.Label lblEspecialidadDat;
        private System.Windows.Forms.Button btnBuscarMedico;
        private System.Windows.Forms.Label lblNombreMedico;
        private System.Windows.Forms.TextBox txtNombreMedico;
        private System.Windows.Forms.Button buttonBuscarMedicoo;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.DataGridViewTextBoxColumn Num;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Horario;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreMedico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Especialidad;
    }
}