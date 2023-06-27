namespace LP2Soft
{
    partial class frmPacientePrincipal
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
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.lblNombre = new System.Windows.Forms.Label();
            this.pbCerrar = new System.Windows.Forms.PictureBox();
            this.panelLateral = new System.Windows.Forms.Panel();
            this.btnGestionarPerfil = new System.Windows.Forms.Button();
            this.btnHistoricoCita = new System.Windows.Forms.Button();
            this.btnGestionarCita = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCerrar)).BeginInit();
            this.panelLateral.SuspendLayout();
            this.panelContenedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(64)))), ((int)(((byte)(147)))));
            this.panelSuperior.Controls.Add(this.lblNombre);
            this.panelSuperior.Controls.Add(this.pbCerrar);
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelSuperior.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(1307, 91);
            this.panelSuperior.TabIndex = 0;
            this.panelSuperior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelSuperior_MouseDown);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(37, 32);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(193, 25);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre del Paciente";
            // 
            // pbCerrar
            // 
            this.pbCerrar.Image = global::LP2Soft.Properties.Resources.close_window_xxl;
            this.pbCerrar.Location = new System.Drawing.Point(1237, 20);
            this.pbCerrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbCerrar.Name = "pbCerrar";
            this.pbCerrar.Size = new System.Drawing.Size(51, 50);
            this.pbCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCerrar.TabIndex = 0;
            this.pbCerrar.TabStop = false;
            this.pbCerrar.Click += new System.EventHandler(this.pbCerrar_Click);
            // 
            // panelLateral
            // 
            this.panelLateral.AutoScroll = true;
            this.panelLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panelLateral.Controls.Add(this.btnGestionarPerfil);
            this.panelLateral.Controls.Add(this.btnHistoricoCita);
            this.panelLateral.Controls.Add(this.btnGestionarCita);
            this.panelLateral.Controls.Add(this.panelLogo);
            this.panelLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLateral.Location = new System.Drawing.Point(0, 91);
            this.panelLateral.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelLateral.Name = "panelLateral";
            this.panelLateral.Size = new System.Drawing.Size(291, 566);
            this.panelLateral.TabIndex = 1;
            // 
            // btnGestionarPerfil
            // 
            this.btnGestionarPerfil.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGestionarPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionarPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionarPerfil.Location = new System.Drawing.Point(0, 300);
            this.btnGestionarPerfil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGestionarPerfil.Name = "btnGestionarPerfil";
            this.btnGestionarPerfil.Size = new System.Drawing.Size(291, 100);
            this.btnGestionarPerfil.TabIndex = 3;
            this.btnGestionarPerfil.Text = "Gestionar Perfil";
            this.btnGestionarPerfil.UseVisualStyleBackColor = true;
            this.btnGestionarPerfil.Click += new System.EventHandler(this.btnGestionarPedidos_Click);
            // 
            // btnHistoricoCita
            // 
            this.btnHistoricoCita.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHistoricoCita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistoricoCita.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistoricoCita.Location = new System.Drawing.Point(0, 200);
            this.btnHistoricoCita.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHistoricoCita.Name = "btnHistoricoCita";
            this.btnHistoricoCita.Size = new System.Drawing.Size(291, 100);
            this.btnHistoricoCita.TabIndex = 2;
            this.btnHistoricoCita.Text = "Histórico de Citas";
            this.btnHistoricoCita.UseVisualStyleBackColor = true;
            this.btnHistoricoCita.Click += new System.EventHandler(this.btnBusquedaEmpleados_Click);
            // 
            // btnGestionarCita
            // 
            this.btnGestionarCita.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGestionarCita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionarCita.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionarCita.Location = new System.Drawing.Point(0, 100);
            this.btnGestionarCita.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGestionarCita.Name = "btnGestionarCita";
            this.btnGestionarCita.Size = new System.Drawing.Size(291, 100);
            this.btnGestionarCita.TabIndex = 1;
            this.btnGestionarCita.Text = "Gestionar Cita";
            this.btnGestionarCita.UseVisualStyleBackColor = true;
            this.btnGestionarCita.Click += new System.EventHandler(this.btnGestionarEmpleados_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackgroundImage = global::LP2Soft.Properties.Resources.WhatsApp_Image_2023_05_28_at_7_26_03_PM;
            this.panelLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(291, 100);
            this.panelLogo.TabIndex = 0;
            // 
            // panelContenedor
            // 
            this.panelContenedor.Controls.Add(this.panel1);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(291, 91);
            this.panelContenedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1016, 566);
            this.panelContenedor.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1016, 566);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // frmPacientePrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1307, 657);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panelLateral);
            this.Controls.Add(this.panelSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmPacientePrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPrincipal";
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCerrar)).EndInit();
            this.panelLateral.ResumeLayout(false);
            this.panelContenedor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.Panel panelLateral;
        private System.Windows.Forms.PictureBox pbCerrar;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnHistoricoCita;
        private System.Windows.Forms.Button btnGestionarCita;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Button btnGestionarPerfil;
        private System.Windows.Forms.Panel panel1;
    }
}