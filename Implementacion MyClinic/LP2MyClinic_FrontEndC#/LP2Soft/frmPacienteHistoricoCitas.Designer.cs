namespace LP2Soft
{
    partial class frmPacienteHistoricoCitas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPacienteHistoricoCitas));
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.dtpFechaBusqIni = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBuscarHistorico = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Especialidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreMedico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvListaCitasPaciente = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaCitasPaciente)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSeleccionar.FlatAppearance.BorderSize = 0;
            this.btnSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeleccionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionar.ForeColor = System.Drawing.Color.Transparent;
            this.btnSeleccionar.Location = new System.Drawing.Point(551, 387);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(148, 23);
            this.btnSeleccionar.TabIndex = 50;
            this.btnSeleccionar.Text = "SELECCIONAR CITA";
            this.btnSeleccionar.UseVisualStyleBackColor = false;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click_1);
            // 
            // dtpFechaBusqIni
            // 
            this.dtpFechaBusqIni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaBusqIni.Location = new System.Drawing.Point(132, 16);
            this.dtpFechaBusqIni.Name = "dtpFechaBusqIni";
            this.dtpFechaBusqIni.Size = new System.Drawing.Size(264, 22);
            this.dtpFechaBusqIni.TabIndex = 59;
            this.dtpFechaBusqIni.Value = new System.DateTime(2023, 5, 28, 23, 3, 5, 0);
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaFin.Location = new System.Drawing.Point(132, 54);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(264, 22);
            this.dtpFechaFin.TabIndex = 60;
            this.dtpFechaFin.Value = new System.DateTime(2023, 5, 28, 23, 3, 5, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 62;
            this.label1.Text = "Fecha Inicio:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 63;
            this.label2.Text = "Fecha Fin:";
            // 
            // btnBuscarHistorico
            // 
            this.btnBuscarHistorico.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnBuscarHistorico.FlatAppearance.BorderSize = 0;
            this.btnBuscarHistorico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarHistorico.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarHistorico.ForeColor = System.Drawing.Color.Transparent;
            this.btnBuscarHistorico.Location = new System.Drawing.Point(617, 56);
            this.btnBuscarHistorico.Name = "btnBuscarHistorico";
            this.btnBuscarHistorico.Size = new System.Drawing.Size(82, 23);
            this.btnBuscarHistorico.TabIndex = 64;
            this.btnBuscarHistorico.Text = "BUSCAR";
            this.btnBuscarHistorico.UseVisualStyleBackColor = false;
            this.btnBuscarHistorico.Click += new System.EventHandler(this.btnBuscarHistorico_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnImprimir.FlatAppearance.BorderSize = 0;
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.ForeColor = System.Drawing.Color.Transparent;
            this.btnImprimir.Location = new System.Drawing.Point(387, 387);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(148, 23);
            this.btnImprimir.TabIndex = 65;
            this.btnImprimir.Text = "IMPRIMIR DETALLE";
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // Especialidad
            // 
            this.Especialidad.HeaderText = "Especialidad";
            this.Especialidad.MinimumWidth = 6;
            this.Especialidad.Name = "Especialidad";
            this.Especialidad.ReadOnly = true;
            this.Especialidad.Width = 150;
            // 
            // NombreMedico
            // 
            this.NombreMedico.HeaderText = "Nombre del Médico";
            this.NombreMedico.MinimumWidth = 6;
            this.NombreMedico.Name = "NombreMedico";
            this.NombreMedico.ReadOnly = true;
            this.NombreMedico.Width = 240;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.MinimumWidth = 6;
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            this.Fecha.Width = 150;
            // 
            // dgvListaCitasPaciente
            // 
            this.dgvListaCitasPaciente.AllowUserToAddRows = false;
            this.dgvListaCitasPaciente.AllowUserToDeleteRows = false;
            this.dgvListaCitasPaciente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaCitasPaciente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Fecha,
            this.NombreMedico,
            this.Especialidad,
            this.Estado});
            this.dgvListaCitasPaciente.Location = new System.Drawing.Point(12, 95);
            this.dgvListaCitasPaciente.Name = "dgvListaCitasPaciente";
            this.dgvListaCitasPaciente.ReadOnly = true;
            this.dgvListaCitasPaciente.RowHeadersWidth = 51;
            this.dgvListaCitasPaciente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaCitasPaciente.Size = new System.Drawing.Size(687, 274);
            this.dgvListaCitasPaciente.TabIndex = 49;
            this.dgvListaCitasPaciente.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvListaCitasPaciente_CellFormatting);
            // 
            // frmPacienteHistoricoCitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 422);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnBuscarHistorico);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpFechaFin);
            this.Controls.Add(this.dtpFechaBusqIni);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.dgvListaCitasPaciente);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmPacienteHistoricoCitas";
            this.Load += new System.EventHandler(this.frmPacienteHistoricoCitas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaCitasPaciente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.DateTimePicker dtpFechaBusqIni;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBuscarHistorico;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Especialidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreMedico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridView dgvListaCitasPaciente;
    }
}