namespace LP2Soft
{
    partial class FrmBibliotecaHistorialPaciente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBibliotecaHistorialPaciente));
            this.btnBuscarHistorico = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaBusqIni = new System.Windows.Forms.DateTimePicker();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.dgvListaCitasPaciente = new System.Windows.Forms.DataGridView();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreMedico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Especialidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxDNIPaciente = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaCitasPaciente)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscarHistorico
            // 
            this.btnBuscarHistorico.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnBuscarHistorico.FlatAppearance.BorderSize = 0;
            this.btnBuscarHistorico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarHistorico.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarHistorico.ForeColor = System.Drawing.Color.Transparent;
            this.btnBuscarHistorico.Location = new System.Drawing.Point(32, 258);
            this.btnBuscarHistorico.Name = "btnBuscarHistorico";
            this.btnBuscarHistorico.Size = new System.Drawing.Size(269, 34);
            this.btnBuscarHistorico.TabIndex = 72;
            this.btnBuscarHistorico.Text = "BUSCAR HISTORIAL";
            this.btnBuscarHistorico.UseVisualStyleBackColor = false;
            this.btnBuscarHistorico.Click += new System.EventHandler(this.btnBuscarHistorico_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 71;
            this.label2.Text = "Fecha Fin:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 70;
            this.label1.Text = "Fecha Inicio:";
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaFin.Location = new System.Drawing.Point(32, 144);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(269, 22);
            this.dtpFechaFin.TabIndex = 69;
            this.dtpFechaFin.Value = new System.DateTime(2023, 5, 28, 23, 3, 5, 0);
            // 
            // dtpFechaBusqIni
            // 
            this.dtpFechaBusqIni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaBusqIni.Location = new System.Drawing.Point(32, 65);
            this.dtpFechaBusqIni.Name = "dtpFechaBusqIni";
            this.dtpFechaBusqIni.Size = new System.Drawing.Size(269, 22);
            this.dtpFechaBusqIni.TabIndex = 68;
            this.dtpFechaBusqIni.Value = new System.DateTime(2023, 5, 28, 23, 3, 5, 0);
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSeleccionar.FlatAppearance.BorderSize = 0;
            this.btnSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeleccionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionar.ForeColor = System.Drawing.Color.Transparent;
            this.btnSeleccionar.Location = new System.Drawing.Point(501, 376);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(180, 33);
            this.btnSeleccionar.TabIndex = 67;
            this.btnSeleccionar.Text = "SELECCIONAR CITA";
            this.btnSeleccionar.UseVisualStyleBackColor = false;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // dgvListaCitasPaciente
            // 
            this.dgvListaCitasPaciente.AllowUserToAddRows = false;
            this.dgvListaCitasPaciente.AllowUserToDeleteRows = false;
            this.dgvListaCitasPaciente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListaCitasPaciente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaCitasPaciente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Fecha,
            this.NombreMedico,
            this.Especialidad,
            this.Estado});
            this.dgvListaCitasPaciente.Location = new System.Drawing.Point(323, 22);
            this.dgvListaCitasPaciente.Name = "dgvListaCitasPaciente";
            this.dgvListaCitasPaciente.ReadOnly = true;
            this.dgvListaCitasPaciente.RowHeadersWidth = 51;
            this.dgvListaCitasPaciente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaCitasPaciente.Size = new System.Drawing.Size(358, 348);
            this.dgvListaCitasPaciente.TabIndex = 66;
            this.dgvListaCitasPaciente.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvListaCitasPaciente_CellFormatting);
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.MinimumWidth = 6;
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // NombreMedico
            // 
            this.NombreMedico.HeaderText = "Nombre del Médico";
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
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 17);
            this.label3.TabIndex = 73;
            this.label3.Text = "Nombre o DNI de Paciente:";
            // 
            // textBoxDNIPaciente
            // 
            this.textBoxDNIPaciente.Location = new System.Drawing.Point(32, 232);
            this.textBoxDNIPaciente.Name = "textBoxDNIPaciente";
            this.textBoxDNIPaciente.Size = new System.Drawing.Size(269, 20);
            this.textBoxDNIPaciente.TabIndex = 74;
            // 
            // FrmBibliotecaHistorialPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 436);
            this.Controls.Add(this.textBoxDNIPaciente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBuscarHistorico);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpFechaFin);
            this.Controls.Add(this.dtpFechaBusqIni);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.dgvListaCitasPaciente);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmBibliotecaHistorialPaciente";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaCitasPaciente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBuscarHistorico;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.DateTimePicker dtpFechaBusqIni;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.DataGridView dgvListaCitasPaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreMedico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Especialidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxDNIPaciente;
    }
}