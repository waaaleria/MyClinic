namespace LP2Soft
{
    partial class frmAlmacenistaMantenimientoLote
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAlmacenistaMantenimientoLote));
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.dgvLoteMantenimiento = new System.Windows.Forms.DataGridView();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.NombrePMedicamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoteMantenimiento)).BeginInit();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(399, 167);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(0, 13);
            this.linkLabel1.TabIndex = 0;
            // 
            // dgvLoteMantenimiento
            // 
            this.dgvLoteMantenimiento.AllowUserToAddRows = false;
            this.dgvLoteMantenimiento.AllowUserToDeleteRows = false;
            this.dgvLoteMantenimiento.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLoteMantenimiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoteMantenimiento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombrePMedicamento,
            this.Cantidad,
            this.PrecioUnitario,
            this.Subtotal});
            this.dgvLoteMantenimiento.Location = new System.Drawing.Point(12, 12);
            this.dgvLoteMantenimiento.Name = "dgvLoteMantenimiento";
            this.dgvLoteMantenimiento.ReadOnly = true;
            this.dgvLoteMantenimiento.RowHeadersWidth = 51;
            this.dgvLoteMantenimiento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLoteMantenimiento.Size = new System.Drawing.Size(763, 382);
            this.dgvLoteMantenimiento.TabIndex = 42;
            this.dgvLoteMantenimiento.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvLoteMantenimiento_CellFormatting);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(319, 399);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(222, 40);
            this.btnEliminar.TabIndex = 38;
            this.btnEliminar.Text = "DAR DE BAJA";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // NombrePMedicamento
            // 
            this.NombrePMedicamento.HeaderText = "N° Lote";
            this.NombrePMedicamento.MinimumWidth = 6;
            this.NombrePMedicamento.Name = "NombrePMedicamento";
            this.NombrePMedicamento.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Nombre Medicina";
            this.Cantidad.MinimumWidth = 6;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // PrecioUnitario
            // 
            dataGridViewCellStyle1.Format = "N2";
            this.PrecioUnitario.DefaultCellStyle = dataGridViewCellStyle1;
            this.PrecioUnitario.HeaderText = "Cantidad";
            this.PrecioUnitario.MinimumWidth = 6;
            this.PrecioUnitario.Name = "PrecioUnitario";
            this.PrecioUnitario.ReadOnly = true;
            // 
            // Subtotal
            // 
            dataGridViewCellStyle2.Format = "N2";
            this.Subtotal.DefaultCellStyle = dataGridViewCellStyle2;
            this.Subtotal.HeaderText = "Fecha Vencimiento";
            this.Subtotal.MinimumWidth = 6;
            this.Subtotal.Name = "Subtotal";
            this.Subtotal.ReadOnly = true;
            // 
            // frmAlmacenistaMantenimientoLote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.dgvLoteMantenimiento);
            this.Controls.Add(this.linkLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAlmacenistaMantenimientoLote";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoteMantenimiento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.DataGridView dgvLoteMantenimiento;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombrePMedicamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subtotal;
    }
}