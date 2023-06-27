namespace LP2Soft
{
    partial class frmEliminarCitaPaciente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEliminarCitaPaciente));
            this.gbCliente = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnMantenimientoLote = new System.Windows.Forms.Button();
            this.dtpFechaBusqFin = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaBusqIni = new System.Windows.Forms.DateTimePicker();
            this.lblNombreCliente = new System.Windows.Forms.Label();
            this.lblDNICliente = new System.Windows.Forms.Label();
            this.dgvHorarios = new System.Windows.Forms.DataGridView();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreMedico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHorarios)).BeginInit();
            this.SuspendLayout();
            // 
            // gbCliente
            // 
            this.gbCliente.Controls.Add(this.btnEliminar);
            this.gbCliente.Controls.Add(this.btnMantenimientoLote);
            this.gbCliente.Controls.Add(this.dtpFechaBusqFin);
            this.gbCliente.Controls.Add(this.dtpFechaBusqIni);
            this.gbCliente.Controls.Add(this.lblNombreCliente);
            this.gbCliente.Controls.Add(this.lblDNICliente);
            this.gbCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCliente.Location = new System.Drawing.Point(33, 12);
            this.gbCliente.Name = "gbCliente";
            this.gbCliente.Size = new System.Drawing.Size(659, 104);
            this.gbCliente.TabIndex = 43;
            this.gbCliente.TabStop = false;
            this.gbCliente.Text = "Datos del Lote:";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(522, 67);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(124, 28);
            this.btnEliminar.TabIndex = 38;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnMantenimientoLote
            // 
            this.btnMantenimientoLote.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnMantenimientoLote.FlatAppearance.BorderSize = 0;
            this.btnMantenimientoLote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMantenimientoLote.ForeColor = System.Drawing.Color.White;
            this.btnMantenimientoLote.Location = new System.Drawing.Point(381, 67);
            this.btnMantenimientoLote.Margin = new System.Windows.Forms.Padding(2);
            this.btnMantenimientoLote.Name = "btnMantenimientoLote";
            this.btnMantenimientoLote.Size = new System.Drawing.Size(122, 28);
            this.btnMantenimientoLote.TabIndex = 7;
            this.btnMantenimientoLote.Text = "BUSCAR";
            this.btnMantenimientoLote.UseVisualStyleBackColor = false;
            this.btnMantenimientoLote.Click += new System.EventHandler(this.btnMantenimientoLote_Click);
            // 
            // dtpFechaBusqFin
            // 
            this.dtpFechaBusqFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaBusqFin.Location = new System.Drawing.Point(167, 71);
            this.dtpFechaBusqFin.Name = "dtpFechaBusqFin";
            this.dtpFechaBusqFin.Size = new System.Drawing.Size(181, 22);
            this.dtpFechaBusqFin.TabIndex = 37;
            // 
            // dtpFechaBusqIni
            // 
            this.dtpFechaBusqIni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaBusqIni.Location = new System.Drawing.Point(167, 34);
            this.dtpFechaBusqIni.Name = "dtpFechaBusqIni";
            this.dtpFechaBusqIni.Size = new System.Drawing.Size(181, 22);
            this.dtpFechaBusqIni.TabIndex = 36;
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.AutoSize = true;
            this.lblNombreCliente.Location = new System.Drawing.Point(6, 34);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(155, 20);
            this.lblNombreCliente.TabIndex = 3;
            this.lblNombreCliente.Text = "Fecha de Ingreso:";
            // 
            // lblDNICliente
            // 
            this.lblDNICliente.AutoSize = true;
            this.lblDNICliente.Location = new System.Drawing.Point(6, 71);
            this.lblDNICliente.Name = "lblDNICliente";
            this.lblDNICliente.Size = new System.Drawing.Size(119, 20);
            this.lblDNICliente.TabIndex = 0;
            this.lblDNICliente.Text = "Fecha de Fin:";
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
            this.dgvHorarios.Location = new System.Drawing.Point(33, 122);
            this.dgvHorarios.Name = "dgvHorarios";
            this.dgvHorarios.ReadOnly = true;
            this.dgvHorarios.RowHeadersWidth = 51;
            this.dgvHorarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHorarios.Size = new System.Drawing.Size(650, 205);
            this.dgvHorarios.TabIndex = 63;
            this.dgvHorarios.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvHorarios_CellFormatting);
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
            // frmEliminarCitaPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 337);
            this.Controls.Add(this.dgvHorarios);
            this.Controls.Add(this.gbCliente);
            this.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEliminarCitaPaciente";
            this.gbCliente.ResumeLayout(false);
            this.gbCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHorarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbCliente;
        private System.Windows.Forms.Button btnMantenimientoLote;
        private System.Windows.Forms.DateTimePicker dtpFechaBusqFin;
        private System.Windows.Forms.DateTimePicker dtpFechaBusqIni;
        private System.Windows.Forms.Label lblNombreCliente;
        private System.Windows.Forms.Label lblDNICliente;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView dgvHorarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraFinal;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreMedico;
    }
}