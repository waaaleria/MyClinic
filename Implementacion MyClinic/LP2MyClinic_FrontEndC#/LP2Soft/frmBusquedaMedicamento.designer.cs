
namespace LP2Soft
{
    partial class frmBusquedaMedicamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBusquedaMedicamento));
            this.lblNombreCodigoProducto = new System.Windows.Forms.Label();
            this.txtNombreMedicamento = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dgvMedicamentos = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Laboratorio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicamentos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombreCodigoProducto
            // 
            this.lblNombreCodigoProducto.AutoSize = true;
            this.lblNombreCodigoProducto.Location = new System.Drawing.Point(15, 14);
            this.lblNombreCodigoProducto.Name = "lblNombreCodigoProducto";
            this.lblNombreCodigoProducto.Size = new System.Drawing.Size(200, 13);
            this.lblNombreCodigoProducto.TabIndex = 0;
            this.lblNombreCodigoProducto.Text = "Ingrese el nombre o codigo del producto:";
            // 
            // txtNombreMedicamento
            // 
            this.txtNombreMedicamento.Location = new System.Drawing.Point(221, 12);
            this.txtNombreMedicamento.Name = "txtNombreMedicamento";
            this.txtNombreMedicamento.Size = new System.Drawing.Size(200, 20);
            this.txtNombreMedicamento.TabIndex = 1;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(427, 10);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dgvMedicamentos
            // 
            this.dgvMedicamentos.AllowUserToAddRows = false;
            this.dgvMedicamentos.AllowUserToDeleteRows = false;
            this.dgvMedicamentos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMedicamentos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMedicamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedicamentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Laboratorio,
            this.Descripcion});
            this.dgvMedicamentos.Location = new System.Drawing.Point(12, 40);
            this.dgvMedicamentos.Name = "dgvMedicamentos";
            this.dgvMedicamentos.ReadOnly = true;
            this.dgvMedicamentos.RowHeadersWidth = 51;
            this.dgvMedicamentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMedicamentos.Size = new System.Drawing.Size(637, 182);
            this.dgvMedicamentos.TabIndex = 3;
            this.dgvMedicamentos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvProductos_CellFormatting);
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Laboratorio
            // 
            this.Laboratorio.HeaderText = "Laboratorio";
            this.Laboratorio.Name = "Laboratorio";
            this.Laboratorio.ReadOnly = true;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSeleccionar.FlatAppearance.BorderSize = 0;
            this.btnSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeleccionar.ForeColor = System.Drawing.Color.White;
            this.btnSeleccionar.Location = new System.Drawing.Point(551, 9);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(98, 23);
            this.btnSeleccionar.TabIndex = 4;
            this.btnSeleccionar.Text = "SELECCIONAR";
            this.btnSeleccionar.UseVisualStyleBackColor = false;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // frmBusquedaMedicamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 234);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.dgvMedicamentos);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtNombreMedicamento);
            this.Controls.Add(this.lblNombreCodigoProducto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBusquedaMedicamento";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicamentos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNombreMedicamento;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgvMedicamentos;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.Label lblNombreCodigoProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Laboratorio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
    }
}