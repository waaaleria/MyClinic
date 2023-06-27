namespace LP2Soft
{
    partial class frmPacienteBuscarCitas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPacienteBuscarCitas));
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.dgvHorarios = new System.Windows.Forms.DataGridView();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreMedico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFechaBusqFin = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaBusqIni = new System.Windows.Forms.DateTimePicker();
            this.btnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHorarios)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSeleccionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeleccionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionar.ForeColor = System.Drawing.Color.Transparent;
            this.btnSeleccionar.Location = new System.Drawing.Point(535, 41);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(126, 28);
            this.btnSeleccionar.TabIndex = 14;
            this.btnSeleccionar.Text = "SELECCIONAR";
            this.btnSeleccionar.UseVisualStyleBackColor = false;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // dgvHorarios
            // 
            this.dgvHorarios.AllowUserToAddRows = false;
            this.dgvHorarios.AllowUserToDeleteRows = false;
            this.dgvHorarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHorarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHorarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Fecha,
            this.HoraInicio,
            this.HoraFinal,
            this.NombreMedico});
            this.dgvHorarios.Location = new System.Drawing.Point(11, 84);
            this.dgvHorarios.Name = "dgvHorarios";
            this.dgvHorarios.ReadOnly = true;
            this.dgvHorarios.RowHeadersWidth = 51;
            this.dgvHorarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHorarios.Size = new System.Drawing.Size(650, 205);
            this.dgvHorarios.TabIndex = 13;
            this.dgvHorarios.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvOrdenesVenta_CellFormatting);
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.MinimumWidth = 6;
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // HoraInicio
            // 
            this.HoraInicio.HeaderText = "HoraInicio";
            this.HoraInicio.MinimumWidth = 6;
            this.HoraInicio.Name = "HoraInicio";
            this.HoraInicio.ReadOnly = true;
            // 
            // HoraFinal
            // 
            this.HoraFinal.HeaderText = "HoraFinal";
            this.HoraFinal.MinimumWidth = 6;
            this.HoraFinal.Name = "HoraFinal";
            this.HoraFinal.ReadOnly = true;
            // 
            // NombreMedico
            // 
            this.NombreMedico.HeaderText = "Nombre del Médico";
            this.NombreMedico.MinimumWidth = 6;
            this.NombreMedico.Name = "NombreMedico";
            this.NombreMedico.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 62;
            this.label3.Text = "Fecha Fin:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 61;
            this.label1.Text = "Fecha Inicio:";
            // 
            // dtpFechaBusqFin
            // 
            this.dtpFechaBusqFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaBusqFin.Location = new System.Drawing.Point(127, 47);
            this.dtpFechaBusqFin.Name = "dtpFechaBusqFin";
            this.dtpFechaBusqFin.Size = new System.Drawing.Size(264, 22);
            this.dtpFechaBusqFin.TabIndex = 59;
            this.dtpFechaBusqFin.Value = new System.DateTime(2023, 5, 28, 23, 3, 5, 0);
            // 
            // dtpFechaBusqIni
            // 
            this.dtpFechaBusqIni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaBusqIni.Location = new System.Drawing.Point(127, 15);
            this.dtpFechaBusqIni.Name = "dtpFechaBusqIni";
            this.dtpFechaBusqIni.Size = new System.Drawing.Size(264, 22);
            this.dtpFechaBusqIni.TabIndex = 58;
            this.dtpFechaBusqIni.Value = new System.DateTime(2023, 5, 28, 23, 3, 5, 0);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.Transparent;
            this.btnBuscar.Location = new System.Drawing.Point(418, 41);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(103, 28);
            this.btnBuscar.TabIndex = 57;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // frmPacienteBuscarCitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 313);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpFechaBusqFin);
            this.Controls.Add(this.dtpFechaBusqIni);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.dgvHorarios);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmPacienteBuscarCitas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvHorarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.DataGridView dgvHorarios;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFechaBusqFin;
        private System.Windows.Forms.DateTimePicker dtpFechaBusqIni;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraFinal;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreMedico;
    }
}