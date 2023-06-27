namespace LP2Soft
{
    partial class frmAlmacenistaIngresarLote
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAlmacenistaIngresarLote));
            this.gbCliente = new System.Windows.Forms.GroupBox();
            this.cboNombreComercial = new System.Windows.Forms.ComboBox();
            this.buttonAgregarInventario = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textCantidad = new System.Windows.Forms.TextBox();
            this.dtpFechaCaducidad = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.lblNombreCliente = new System.Windows.Forms.Label();
            this.lblDNICliente = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvLote = new System.Windows.Forms.DataGridView();
            this.NombrePMedicamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NroLote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaVencimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaDeIngreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEliminarLote = new System.Windows.Forms.Button();
            this.tsMenu = new System.Windows.Forms.ToolStrip();
            this.button2 = new System.Windows.Forms.Button();
            this.gbCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLote)).BeginInit();
            this.SuspendLayout();
            // 
            // gbCliente
            // 
            this.gbCliente.Controls.Add(this.button2);
            this.gbCliente.Controls.Add(this.cboNombreComercial);
            this.gbCliente.Controls.Add(this.buttonAgregarInventario);
            this.gbCliente.Controls.Add(this.label3);
            this.gbCliente.Controls.Add(this.textCantidad);
            this.gbCliente.Controls.Add(this.dtpFechaCaducidad);
            this.gbCliente.Controls.Add(this.dtpFechaIngreso);
            this.gbCliente.Controls.Add(this.lblNombreCliente);
            this.gbCliente.Controls.Add(this.lblDNICliente);
            this.gbCliente.Controls.Add(this.label2);
            this.gbCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCliente.Location = new System.Drawing.Point(22, 12);
            this.gbCliente.Name = "gbCliente";
            this.gbCliente.Size = new System.Drawing.Size(754, 147);
            this.gbCliente.TabIndex = 40;
            this.gbCliente.TabStop = false;
            this.gbCliente.Text = "Datos del Lote:";
            // 
            // cboNombreComercial
            // 
            this.cboNombreComercial.FormattingEnabled = true;
            this.cboNombreComercial.Location = new System.Drawing.Point(167, 68);
            this.cboNombreComercial.Name = "cboNombreComercial";
            this.cboNombreComercial.Size = new System.Drawing.Size(143, 28);
            this.cboNombreComercial.TabIndex = 41;
            // 
            // buttonAgregarInventario
            // 
            this.buttonAgregarInventario.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonAgregarInventario.FlatAppearance.BorderSize = 0;
            this.buttonAgregarInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAgregarInventario.ForeColor = System.Drawing.Color.White;
            this.buttonAgregarInventario.Location = new System.Drawing.Point(604, 71);
            this.buttonAgregarInventario.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAgregarInventario.Name = "buttonAgregarInventario";
            this.buttonAgregarInventario.Size = new System.Drawing.Size(124, 28);
            this.buttonAgregarInventario.TabIndex = 7;
            this.buttonAgregarInventario.Text = "Agregar";
            this.buttonAgregarInventario.UseVisualStyleBackColor = false;
            this.buttonAgregarInventario.Click += new System.EventHandler(this.buttonAgregarInventario_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 40;
            this.label3.Text = "Cantidad:";
            // 
            // textCantidad
            // 
            this.textCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCantidad.Location = new System.Drawing.Point(167, 109);
            this.textCantidad.Name = "textCantidad";
            this.textCantidad.Size = new System.Drawing.Size(43, 20);
            this.textCantidad.TabIndex = 5;
            // 
            // dtpFechaCaducidad
            // 
            this.dtpFechaCaducidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaCaducidad.Location = new System.Drawing.Point(555, 34);
            this.dtpFechaCaducidad.Name = "dtpFechaCaducidad";
            this.dtpFechaCaducidad.Size = new System.Drawing.Size(173, 22);
            this.dtpFechaCaducidad.TabIndex = 37;
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
            this.lblDNICliente.Location = new System.Drawing.Point(370, 36);
            this.lblDNICliente.Name = "lblDNICliente";
            this.lblDNICliente.Size = new System.Drawing.Size(179, 20);
            this.lblDNICliente.TabIndex = 0;
            this.lblDNICliente.Text = "Fecha de Caducidad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre Comercial:";
            // 
            // dgvLote
            // 
            this.dgvLote.AllowUserToAddRows = false;
            this.dgvLote.AllowUserToDeleteRows = false;
            this.dgvLote.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLote.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombrePMedicamento,
            this.NroLote,
            this.FechaVencimiento,
            this.FechaDeIngreso});
            this.dgvLote.Location = new System.Drawing.Point(22, 187);
            this.dgvLote.Name = "dgvLote";
            this.dgvLote.ReadOnly = true;
            this.dgvLote.RowHeadersWidth = 51;
            this.dgvLote.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLote.Size = new System.Drawing.Size(744, 192);
            this.dgvLote.TabIndex = 41;
            this.dgvLote.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvLote_CellFormatting);
            // 
            // NombrePMedicamento
            // 
            this.NombrePMedicamento.FillWeight = 50F;
            this.NombrePMedicamento.HeaderText = "Nombre Medicamento";
            this.NombrePMedicamento.MinimumWidth = 6;
            this.NombrePMedicamento.Name = "NombrePMedicamento";
            this.NombrePMedicamento.ReadOnly = true;
            this.NombrePMedicamento.Width = 200;
            // 
            // NroLote
            // 
            this.NroLote.HeaderText = "Nro de Lote";
            this.NroLote.MinimumWidth = 6;
            this.NroLote.Name = "NroLote";
            this.NroLote.ReadOnly = true;
            this.NroLote.Width = 130;
            // 
            // FechaVencimiento
            // 
            dataGridViewCellStyle1.Format = "N2";
            this.FechaVencimiento.DefaultCellStyle = dataGridViewCellStyle1;
            this.FechaVencimiento.HeaderText = "Fecha de Vencimiento";
            this.FechaVencimiento.MinimumWidth = 6;
            this.FechaVencimiento.Name = "FechaVencimiento";
            this.FechaVencimiento.ReadOnly = true;
            this.FechaVencimiento.Width = 180;
            // 
            // FechaDeIngreso
            // 
            dataGridViewCellStyle2.Format = "N2";
            this.FechaDeIngreso.DefaultCellStyle = dataGridViewCellStyle2;
            this.FechaDeIngreso.HeaderText = "Fecha de Ingreso";
            this.FechaDeIngreso.MinimumWidth = 6;
            this.FechaDeIngreso.Name = "FechaDeIngreso";
            this.FechaDeIngreso.ReadOnly = true;
            this.FechaDeIngreso.Width = 180;
            // 
            // btnEliminarLote
            // 
            this.btnEliminarLote.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnEliminarLote.FlatAppearance.BorderSize = 0;
            this.btnEliminarLote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarLote.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarLote.ForeColor = System.Drawing.Color.White;
            this.btnEliminarLote.Location = new System.Drawing.Point(664, 398);
            this.btnEliminarLote.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminarLote.Name = "btnEliminarLote";
            this.btnEliminarLote.Size = new System.Drawing.Size(102, 28);
            this.btnEliminarLote.TabIndex = 42;
            this.btnEliminarLote.Text = "Eliminar";
            this.btnEliminarLote.UseVisualStyleBackColor = false;
            this.btnEliminarLote.Click += new System.EventHandler(this.btnEliminarLote_Click);
            // 
            // tsMenu
            // 
            this.tsMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tsMenu.Location = new System.Drawing.Point(0, 0);
            this.tsMenu.Name = "tsMenu";
            this.tsMenu.Size = new System.Drawing.Size(800, 25);
            this.tsMenu.TabIndex = 2;
            this.tsMenu.Text = "toolStrip1";
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::LP2Soft.Properties.Resources.anadir;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.Location = new System.Drawing.Point(316, 67);
            this.button2.Name = "button2";
            this.button2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button2.Size = new System.Drawing.Size(32, 30);
            this.button2.TabIndex = 43;
            this.button2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.UseCompatibleTextRendering = true;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmAlmacenistaIngresarLote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEliminarLote);
            this.Controls.Add(this.dgvLote);
            this.Controls.Add(this.gbCliente);
            this.Controls.Add(this.tsMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAlmacenistaIngresarLote";
            this.gbCliente.ResumeLayout(false);
            this.gbCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLote)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gbCliente;
        private System.Windows.Forms.Button buttonAgregarInventario;
        private System.Windows.Forms.TextBox textCantidad;
        private System.Windows.Forms.Label lblNombreCliente;
        private System.Windows.Forms.Label lblDNICliente;
        private System.Windows.Forms.DateTimePicker dtpFechaCaducidad;
        private System.Windows.Forms.DateTimePicker dtpFechaIngreso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboNombreComercial;
        private System.Windows.Forms.DataGridView dgvLote;
        private System.Windows.Forms.Button btnEliminarLote;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolStrip tsMenu;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombrePMedicamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroLote;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaVencimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaDeIngreso;
    }
}