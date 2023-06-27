namespace LP2Soft
{
    partial class frmHistorialPaciente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHistorialPaciente));
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFechaBusqFin = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaBusqIni = new System.Windows.Forms.DateTimePicker();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.dgvListaCitasPaciente = new System.Windows.Forms.DataGridView();
            this.NombreMedico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Especialidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaCitasPaciente)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 55;
            this.label3.Text = "Fecha Fin:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 54;
            this.label1.Text = "Fecha Inicio:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(15, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 25);
            this.label2.TabIndex = 53;
            this.label2.Text = "Historico de Citas";
            // 
            // dtpFechaBusqFin
            // 
            this.dtpFechaBusqFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaBusqFin.Location = new System.Drawing.Point(168, 105);
            this.dtpFechaBusqFin.Name = "dtpFechaBusqFin";
            this.dtpFechaBusqFin.Size = new System.Drawing.Size(264, 22);
            this.dtpFechaBusqFin.TabIndex = 52;
            this.dtpFechaBusqFin.Value = new System.DateTime(2023, 5, 28, 23, 3, 5, 0);
            // 
            // dtpFechaBusqIni
            // 
            this.dtpFechaBusqIni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaBusqIni.Location = new System.Drawing.Point(168, 67);
            this.dtpFechaBusqIni.Name = "dtpFechaBusqIni";
            this.dtpFechaBusqIni.Size = new System.Drawing.Size(264, 22);
            this.dtpFechaBusqIni.TabIndex = 51;
            this.dtpFechaBusqIni.Value = new System.DateTime(2023, 5, 28, 23, 3, 5, 0);
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSeleccionar.FlatAppearance.BorderSize = 0;
            this.btnSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeleccionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionar.ForeColor = System.Drawing.Color.Transparent;
            this.btnSeleccionar.Location = new System.Drawing.Point(504, 390);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(215, 23);
            this.btnSeleccionar.TabIndex = 50;
            this.btnSeleccionar.Text = "SELECCIONAR CITA";
            this.btnSeleccionar.UseVisualStyleBackColor = false;
            // 
            // dgvListaCitasPaciente
            // 
            this.dgvListaCitasPaciente.AllowUserToAddRows = false;
            this.dgvListaCitasPaciente.AllowUserToDeleteRows = false;
            this.dgvListaCitasPaciente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListaCitasPaciente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaCitasPaciente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreMedico,
            this.Especialidad});
            this.dgvListaCitasPaciente.Location = new System.Drawing.Point(12, 146);
            this.dgvListaCitasPaciente.Name = "dgvListaCitasPaciente";
            this.dgvListaCitasPaciente.ReadOnly = true;
            this.dgvListaCitasPaciente.RowHeadersWidth = 51;
            this.dgvListaCitasPaciente.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvListaCitasPaciente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaCitasPaciente.Size = new System.Drawing.Size(707, 238);
            this.dgvListaCitasPaciente.TabIndex = 49;
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
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.Transparent;
            this.btnBuscar.Location = new System.Drawing.Point(467, 102);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(109, 28);
            this.btnBuscar.TabIndex = 48;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // frmHistorialPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 422);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpFechaBusqFin);
            this.Controls.Add(this.dtpFechaBusqIni);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.dgvListaCitasPaciente);
            this.Controls.Add(this.btnBuscar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmHistorialPaciente";
            this.Load += new System.EventHandler(this.frmPacienteHistoricoCitas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaCitasPaciente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFechaBusqFin;
        private System.Windows.Forms.DateTimePicker dtpFechaBusqIni;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.DataGridView dgvListaCitasPaciente;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreMedico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Especialidad;
    }
}