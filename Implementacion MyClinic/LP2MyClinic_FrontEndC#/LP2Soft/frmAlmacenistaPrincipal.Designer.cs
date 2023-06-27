namespace LP2Soft
{
    partial class frmAlmacenistaPrincipal
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
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.panelLateral = new System.Windows.Forms.Panel();
            this.btnGestionarEmpleados = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.lblNombre = new System.Windows.Forms.Label();
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.pbCerrar = new System.Windows.Forms.PictureBox();
            this.btnBusquedaEmpleados = new System.Windows.Forms.Button();
            this.panelLateral.SuspendLayout();
            this.panelSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContenedor
            // 
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(218, 74);
            this.panelContenedor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(762, 460);
            this.panelContenedor.TabIndex = 6;
            // 
            // panelLateral
            // 
            this.panelLateral.AutoScroll = true;
            this.panelLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panelLateral.Controls.Add(this.btnBusquedaEmpleados);
            this.panelLateral.Controls.Add(this.btnGestionarEmpleados);
            this.panelLateral.Controls.Add(this.panelLogo);
            this.panelLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLateral.Location = new System.Drawing.Point(0, 74);
            this.panelLateral.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelLateral.Name = "panelLateral";
            this.panelLateral.Size = new System.Drawing.Size(218, 460);
            this.panelLateral.TabIndex = 5;
            // 
            // btnGestionarEmpleados
            // 
            this.btnGestionarEmpleados.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGestionarEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionarEmpleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionarEmpleados.Location = new System.Drawing.Point(0, 81);
            this.btnGestionarEmpleados.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGestionarEmpleados.Name = "btnGestionarEmpleados";
            this.btnGestionarEmpleados.Size = new System.Drawing.Size(218, 161);
            this.btnGestionarEmpleados.TabIndex = 1;
            this.btnGestionarEmpleados.Text = "Ingresar Lote";
            this.btnGestionarEmpleados.UseVisualStyleBackColor = true;
            this.btnGestionarEmpleados.Click += new System.EventHandler(this.btnGestionarEmpleados_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackgroundImage = global::LP2Soft.Properties.Resources.WhatsApp_Image_2023_05_28_at_7_26_03_PM;
            this.panelLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(218, 81);
            this.panelLogo.TabIndex = 0;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(28, 26);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(181, 20);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre del Almacenista";
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(64)))), ((int)(((byte)(147)))));
            this.panelSuperior.Controls.Add(this.lblNombre);
            this.panelSuperior.Controls.Add(this.pbCerrar);
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelSuperior.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(980, 74);
            this.panelSuperior.TabIndex = 4;
            this.panelSuperior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelSuperior_MouseDown);
            // 
            // pbCerrar
            // 
            this.pbCerrar.Image = global::LP2Soft.Properties.Resources.close_window_xxl;
            this.pbCerrar.Location = new System.Drawing.Point(928, 16);
            this.pbCerrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbCerrar.Name = "pbCerrar";
            this.pbCerrar.Size = new System.Drawing.Size(38, 41);
            this.pbCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCerrar.TabIndex = 0;
            this.pbCerrar.TabStop = false;
            this.pbCerrar.Click += new System.EventHandler(this.pbCerrar_Click);
            // 
            // btnBusquedaEmpleados
            // 
            this.btnBusquedaEmpleados.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBusquedaEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBusquedaEmpleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBusquedaEmpleados.Location = new System.Drawing.Point(0, 242);
            this.btnBusquedaEmpleados.Margin = new System.Windows.Forms.Padding(2);
            this.btnBusquedaEmpleados.Name = "btnBusquedaEmpleados";
            this.btnBusquedaEmpleados.Size = new System.Drawing.Size(218, 142);
            this.btnBusquedaEmpleados.TabIndex = 2;
            this.btnBusquedaEmpleados.Text = "Mantenimiento Lotes";
            this.btnBusquedaEmpleados.UseVisualStyleBackColor = true;
            this.btnBusquedaEmpleados.Click += new System.EventHandler(this.btnBusquedaEmpleados_Click);
            // 
            // FrmPrincipalAlma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 534);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panelLateral);
            this.Controls.Add(this.panelSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmPrincipalAlma";
            this.Text = "FrmPrincipalAlma";
            this.panelLateral.ResumeLayout(false);
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Panel panelLateral;
        private System.Windows.Forms.Button btnGestionarEmpleados;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.PictureBox pbCerrar;
        private System.Windows.Forms.Button btnBusquedaEmpleados;
    }
}