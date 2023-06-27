namespace LP2Soft
{
    partial class frmIngresarMedicina
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
            this.gbCliente = new System.Windows.Forms.GroupBox();
            this.textBoxDescripcion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgregarMedicina = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textPrecioMed = new System.Windows.Forms.TextBox();
            this.lblNombreCliente = new System.Windows.Forms.Label();
            this.txtNombreLaboratorioMed = new System.Windows.Forms.TextBox();
            this.txtNombreComercialMed = new System.Windows.Forms.TextBox();
            this.lblDNICliente = new System.Windows.Forms.Label();
            this.tsMenu = new System.Windows.Forms.ToolStrip();
            this.btnNuevo = new System.Windows.Forms.ToolStripButton();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.gbCliente.SuspendLayout();
            this.tsMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbCliente
            // 
            this.gbCliente.Controls.Add(this.textBoxDescripcion);
            this.gbCliente.Controls.Add(this.label1);
            this.gbCliente.Controls.Add(this.btnAgregarMedicina);
            this.gbCliente.Controls.Add(this.label3);
            this.gbCliente.Controls.Add(this.textPrecioMed);
            this.gbCliente.Controls.Add(this.lblNombreCliente);
            this.gbCliente.Controls.Add(this.txtNombreLaboratorioMed);
            this.gbCliente.Controls.Add(this.txtNombreComercialMed);
            this.gbCliente.Controls.Add(this.lblDNICliente);
            this.gbCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCliente.Location = new System.Drawing.Point(12, 30);
            this.gbCliente.Name = "gbCliente";
            this.gbCliente.Size = new System.Drawing.Size(628, 255);
            this.gbCliente.TabIndex = 42;
            this.gbCliente.TabStop = false;
            this.gbCliente.Text = "Datos de la Medicina:";
            // 
            // textBoxDescripcion
            // 
            this.textBoxDescripcion.BackColor = System.Drawing.Color.White;
            this.textBoxDescripcion.Enabled = false;
            this.textBoxDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDescripcion.Location = new System.Drawing.Point(210, 148);
            this.textBoxDescripcion.Multiline = true;
            this.textBoxDescripcion.Name = "textBoxDescripcion";
            this.textBoxDescripcion.Size = new System.Drawing.Size(302, 53);
            this.textBoxDescripcion.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(92, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Descripción:";
            // 
            // btnAgregarMedicina
            // 
            this.btnAgregarMedicina.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAgregarMedicina.FlatAppearance.BorderSize = 0;
            this.btnAgregarMedicina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarMedicina.ForeColor = System.Drawing.Color.Transparent;
            this.btnAgregarMedicina.Location = new System.Drawing.Point(263, 210);
            this.btnAgregarMedicina.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarMedicina.Name = "btnAgregarMedicina";
            this.btnAgregarMedicina.Size = new System.Drawing.Size(109, 34);
            this.btnAgregarMedicina.TabIndex = 7;
            this.btnAgregarMedicina.Text = "Agregar";
            this.btnAgregarMedicina.UseVisualStyleBackColor = false;
            this.btnAgregarMedicina.Click += new System.EventHandler(this.btnAgregarMedicina_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(131, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Precio:";
            // 
            // textPrecioMed
            // 
            this.textPrecioMed.BackColor = System.Drawing.Color.White;
            this.textPrecioMed.Enabled = false;
            this.textPrecioMed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPrecioMed.Location = new System.Drawing.Point(210, 114);
            this.textPrecioMed.Name = "textPrecioMed";
            this.textPrecioMed.Size = new System.Drawing.Size(69, 20);
            this.textPrecioMed.TabIndex = 5;
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.AutoSize = true;
            this.lblNombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreCliente.Location = new System.Drawing.Point(12, 77);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(176, 20);
            this.lblNombreCliente.TabIndex = 3;
            this.lblNombreCliente.Text = "Nombre de Laboratorio:";
            // 
            // txtNombreLaboratorioMed
            // 
            this.txtNombreLaboratorioMed.BackColor = System.Drawing.Color.White;
            this.txtNombreLaboratorioMed.Enabled = false;
            this.txtNombreLaboratorioMed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreLaboratorioMed.Location = new System.Drawing.Point(210, 77);
            this.txtNombreLaboratorioMed.Name = "txtNombreLaboratorioMed";
            this.txtNombreLaboratorioMed.Size = new System.Drawing.Size(302, 20);
            this.txtNombreLaboratorioMed.TabIndex = 2;
            // 
            // txtNombreComercialMed
            // 
            this.txtNombreComercialMed.BackColor = System.Drawing.Color.White;
            this.txtNombreComercialMed.Enabled = false;
            this.txtNombreComercialMed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreComercialMed.Location = new System.Drawing.Point(210, 43);
            this.txtNombreComercialMed.Name = "txtNombreComercialMed";
            this.txtNombreComercialMed.Size = new System.Drawing.Size(302, 20);
            this.txtNombreComercialMed.TabIndex = 1;
            // 
            // lblDNICliente
            // 
            this.lblDNICliente.AutoSize = true;
            this.lblDNICliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDNICliente.Location = new System.Drawing.Point(45, 41);
            this.lblDNICliente.Name = "lblDNICliente";
            this.lblDNICliente.Size = new System.Drawing.Size(143, 20);
            this.lblDNICliente.TabIndex = 0;
            this.lblDNICliente.Text = "Nombre Comercial:";
            // 
            // tsMenu
            // 
            this.tsMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNuevo,
            this.btnCancelar});
            this.tsMenu.Location = new System.Drawing.Point(0, 0);
            this.tsMenu.Name = "tsMenu";
            this.tsMenu.Size = new System.Drawing.Size(663, 27);
            this.tsMenu.TabIndex = 41;
            this.tsMenu.Text = "toolStrip1";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Image = global::LP2Soft.Properties.Resources.anadir;
            this.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(70, 24);
            this.btnNuevo.Text = "&Nuevo";
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = global::LP2Soft.Properties.Resources.cerca;
            this.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(85, 24);
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.BackgroundImage = global::LP2Soft.Properties.Resources.cerca;
            this.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Location = new System.Drawing.Point(607, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(56, 38);
            this.btnCerrar.TabIndex = 10;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // frmIngresarMedicina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 306);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.gbCliente);
            this.Controls.Add(this.tsMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmIngresarMedicina";
            this.gbCliente.ResumeLayout(false);
            this.gbCliente.PerformLayout();
            this.tsMenu.ResumeLayout(false);
            this.tsMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gbCliente;
        private System.Windows.Forms.Button btnAgregarMedicina;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textPrecioMed;
        private System.Windows.Forms.Label lblNombreCliente;
        private System.Windows.Forms.TextBox txtNombreLaboratorioMed;
        private System.Windows.Forms.TextBox txtNombreComercialMed;
        private System.Windows.Forms.Label lblDNICliente;
        private System.Windows.Forms.ToolStrip tsMenu;
        private System.Windows.Forms.ToolStripButton btnNuevo;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private System.Windows.Forms.TextBox textBoxDescripcion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCerrar;
    }
}