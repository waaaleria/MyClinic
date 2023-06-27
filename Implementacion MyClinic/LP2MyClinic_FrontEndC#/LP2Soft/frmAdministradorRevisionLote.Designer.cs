namespace LP2Soft
{
    partial class frmAdministradorRevisionLote
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdministradorRevisionLote));
            this.gbCliente = new System.Windows.Forms.GroupBox();
            this.btnMantenimientoLote = new System.Windows.Forms.Button();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.lblNombreCliente = new System.Windows.Forms.Label();
            this.lblDNICliente = new System.Windows.Forms.Label();
            this.dgvLote = new System.Windows.Forms.DataGridView();
            this.NombrePMedicamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NroLote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaVencimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaDeIngreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLote)).BeginInit();
            this.SuspendLayout();
            // 
            // gbCliente
            // 
            this.gbCliente.Controls.Add(this.btnMantenimientoLote);
            this.gbCliente.Controls.Add(this.dtpFechaFin);
            this.gbCliente.Controls.Add(this.dtpFechaIngreso);
            this.gbCliente.Controls.Add(this.lblNombreCliente);
            this.gbCliente.Controls.Add(this.lblDNICliente);
            this.gbCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCliente.Location = new System.Drawing.Point(25, 12);
            this.gbCliente.Name = "gbCliente";
            this.gbCliente.Size = new System.Drawing.Size(735, 104);
            this.gbCliente.TabIndex = 41;
            this.gbCliente.TabStop = false;
            this.gbCliente.Text = "Datos del Lote:";
            // 
            // btnMantenimientoLote
            // 
            this.btnMantenimientoLote.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnMantenimientoLote.FlatAppearance.BorderSize = 0;
            this.btnMantenimientoLote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMantenimientoLote.ForeColor = System.Drawing.Color.White;
            this.btnMantenimientoLote.Location = new System.Drawing.Point(373, 34);
            this.btnMantenimientoLote.Margin = new System.Windows.Forms.Padding(2);
            this.btnMantenimientoLote.Name = "btnMantenimientoLote";
            this.btnMantenimientoLote.Size = new System.Drawing.Size(120, 34);
            this.btnMantenimientoLote.TabIndex = 7;
            this.btnMantenimientoLote.Text = "Buscar lote";
            this.btnMantenimientoLote.UseVisualStyleBackColor = false;
            this.btnMantenimientoLote.Click += new System.EventHandler(this.btnMantenimientoLote_Click);
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaFin.Location = new System.Drawing.Point(167, 71);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(181, 22);
            this.dtpFechaFin.TabIndex = 37;
            // 
            // dtpFechaIngreso
            // 
            this.dtpFechaIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaIngreso.Location = new System.Drawing.Point(167, 34);
            this.dtpFechaIngreso.Name = "dtpFechaIngreso";
            this.dtpFechaIngreso.Size = new System.Drawing.Size(181, 22);
            this.dtpFechaIngreso.TabIndex = 36;
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
            this.lblDNICliente.Location = new System.Drawing.Point(42, 71);
            this.lblDNICliente.Name = "lblDNICliente";
            this.lblDNICliente.Size = new System.Drawing.Size(119, 20);
            this.lblDNICliente.TabIndex = 0;
            this.lblDNICliente.Text = "Fecha de Fin:";
            // 
            // dgvLote
            // 
            this.dgvLote.AllowUserToAddRows = false;
            this.dgvLote.AllowUserToDeleteRows = false;
            this.dgvLote.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLote.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLote.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombrePMedicamento,
            this.NroLote,
            this.FechaVencimiento,
            this.FechaDeIngreso});
            this.dgvLote.Location = new System.Drawing.Point(25, 122);
            this.dgvLote.Name = "dgvLote";
            this.dgvLote.ReadOnly = true;
            this.dgvLote.RowHeadersWidth = 51;
            this.dgvLote.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLote.Size = new System.Drawing.Size(735, 291);
            this.dgvLote.TabIndex = 42;
            this.dgvLote.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvLote_CellFormatting);
            // 
            // NombrePMedicamento
            // 
            this.NombrePMedicamento.FillWeight = 50F;
            this.NombrePMedicamento.HeaderText = "Nombre Medicamento";
            this.NombrePMedicamento.MinimumWidth = 6;
            this.NombrePMedicamento.Name = "NombrePMedicamento";
            this.NombrePMedicamento.ReadOnly = true;
            // 
            // NroLote
            // 
            this.NroLote.HeaderText = "Nro de Lote";
            this.NroLote.MinimumWidth = 6;
            this.NroLote.Name = "NroLote";
            this.NroLote.ReadOnly = true;
            // 
            // FechaVencimiento
            // 
            dataGridViewCellStyle1.Format = "N2";
            this.FechaVencimiento.DefaultCellStyle = dataGridViewCellStyle1;
            this.FechaVencimiento.HeaderText = "Fecha de Vencimiento";
            this.FechaVencimiento.MinimumWidth = 6;
            this.FechaVencimiento.Name = "FechaVencimiento";
            this.FechaVencimiento.ReadOnly = true;
            // 
            // FechaDeIngreso
            // 
            dataGridViewCellStyle2.Format = "N2";
            this.FechaDeIngreso.DefaultCellStyle = dataGridViewCellStyle2;
            this.FechaDeIngreso.HeaderText = "Fecha de Ingreso";
            this.FechaDeIngreso.MinimumWidth = 6;
            this.FechaDeIngreso.Name = "FechaDeIngreso";
            this.FechaDeIngreso.ReadOnly = true;
            // 
            // frmAdministradorRevisionLote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvLote);
            this.Controls.Add(this.gbCliente);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAdministradorRevisionLote";
            this.gbCliente.ResumeLayout(false);
            this.gbCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLote)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCliente;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.DateTimePicker dtpFechaIngreso;
        private System.Windows.Forms.Label lblNombreCliente;
        private System.Windows.Forms.Label lblDNICliente;
        private System.Windows.Forms.Button btnMantenimientoLote;
        private System.Windows.Forms.DataGridView dgvLote;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombrePMedicamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroLote;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaVencimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaDeIngreso;
    }
}