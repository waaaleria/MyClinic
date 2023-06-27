namespace LP2Soft
{
    partial class frmBusquedaMedico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBusquedaMedico));
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.dgvMedicos = new System.Windows.Forms.DataGridView();
            this.IDMedico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreMedico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Especialidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtNombreEsp = new System.Windows.Forms.TextBox();
            this.lblBusqueda = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSeleccionar.FlatAppearance.BorderSize = 0;
            this.btnSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeleccionar.ForeColor = System.Drawing.Color.White;
            this.btnSeleccionar.Location = new System.Drawing.Point(551, 14);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(102, 23);
            this.btnSeleccionar.TabIndex = 9;
            this.btnSeleccionar.Text = "SELECCIONAR";
            this.btnSeleccionar.UseVisualStyleBackColor = false;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // dgvMedicos
            // 
            this.dgvMedicos.AllowUserToAddRows = false;
            this.dgvMedicos.AllowUserToDeleteRows = false;
            this.dgvMedicos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMedicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedicos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDMedico,
            this.NombreMedico,
            this.Especialidad});
            this.dgvMedicos.Location = new System.Drawing.Point(13, 46);
            this.dgvMedicos.Name = "dgvMedicos";
            this.dgvMedicos.ReadOnly = true;
            this.dgvMedicos.RowHeadersWidth = 51;
            this.dgvMedicos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMedicos.Size = new System.Drawing.Size(640, 205);
            this.dgvMedicos.TabIndex = 8;
            this.dgvMedicos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvMedicos_CellFormatting_1);
            // 
            // IDMedico
            // 
            this.IDMedico.HeaderText = "ID Medico";
            this.IDMedico.MinimumWidth = 6;
            this.IDMedico.Name = "IDMedico";
            this.IDMedico.ReadOnly = true;
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
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(470, 15);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 7;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtNombreEsp
            // 
            this.txtNombreEsp.Location = new System.Drawing.Point(226, 17);
            this.txtNombreEsp.Name = "txtNombreEsp";
            this.txtNombreEsp.Size = new System.Drawing.Size(238, 20);
            this.txtNombreEsp.TabIndex = 6;
            // 
            // lblBusqueda
            // 
            this.lblBusqueda.AutoSize = true;
            this.lblBusqueda.Location = new System.Drawing.Point(10, 20);
            this.lblBusqueda.Name = "lblBusqueda";
            this.lblBusqueda.Size = new System.Drawing.Size(219, 13);
            this.lblBusqueda.TabIndex = 5;
            this.lblBusqueda.Text = "Ingrese el nombre del medico o especialidad:";
            // 
            // frmBusquedaMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 265);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.dgvMedicos);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtNombreEsp);
            this.Controls.Add(this.lblBusqueda);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmBusquedaMedico";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.DataGridView dgvMedicos;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtNombreEsp;
        private System.Windows.Forms.Label lblBusqueda;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDMedico;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreMedico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Especialidad;
    }
}