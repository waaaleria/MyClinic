namespace LP2Soft
{
    partial class frmMedicoPrincipal
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
            this.panelLateral = new System.Windows.Forms.Panel();
            this.btnGestionarPerfil = new System.Windows.Forms.Button();
            this.btnGestionCitas = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.lblNombre = new System.Windows.Forms.Label();
            this.pbCerrar = new System.Windows.Forms.PictureBox();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.panelLateral.SuspendLayout();
            this.panelSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLateral
            // 
            this.panelLateral.AutoScroll = true;
            this.panelLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panelLateral.Controls.Add(this.btnGestionarPerfil);
            this.panelLateral.Controls.Add(this.btnGestionCitas);
            this.panelLateral.Controls.Add(this.panelLogo);
            this.panelLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLateral.Location = new System.Drawing.Point(0, 74);
            this.panelLateral.Margin = new System.Windows.Forms.Padding(2);
            this.panelLateral.Name = "panelLateral";
            this.panelLateral.Size = new System.Drawing.Size(218, 460);
            this.panelLateral.TabIndex = 3;
            // 
            // btnGestionarPerfil
            // 
            this.btnGestionarPerfil.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGestionarPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionarPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionarPerfil.Location = new System.Drawing.Point(0, 154);
            this.btnGestionarPerfil.Margin = new System.Windows.Forms.Padding(2);
            this.btnGestionarPerfil.Name = "btnGestionarPerfil";
            this.btnGestionarPerfil.Size = new System.Drawing.Size(218, 81);
            this.btnGestionarPerfil.TabIndex = 3;
            this.btnGestionarPerfil.Text = "Gestionar Perfil";
            this.btnGestionarPerfil.UseVisualStyleBackColor = true;
            this.btnGestionarPerfil.Click += new System.EventHandler(this.btnGestionarPerfil_Click);
            // 
            // btnGestionCitas
            // 
            this.btnGestionCitas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGestionCitas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionCitas.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionCitas.Location = new System.Drawing.Point(0, 81);
            this.btnGestionCitas.Margin = new System.Windows.Forms.Padding(2);
            this.btnGestionCitas.Name = "btnGestionCitas";
            this.btnGestionCitas.Size = new System.Drawing.Size(218, 73);
            this.btnGestionCitas.TabIndex = 2;
            this.btnGestionCitas.Text = "Historico de citas";
            this.btnGestionCitas.UseVisualStyleBackColor = true;
            this.btnGestionCitas.Click += new System.EventHandler(this.btnGestionCitas_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackgroundImage = global::LP2Soft.Properties.Resources.WhatsApp_Image_2023_05_28_at_7_26_03_PM;
            this.panelLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(2);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(218, 81);
            this.panelLogo.TabIndex = 0;
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(64)))), ((int)(((byte)(147)))));
            this.panelSuperior.Controls.Add(this.lblNombre);
            this.panelSuperior.Controls.Add(this.pbCerrar);
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelSuperior.Margin = new System.Windows.Forms.Padding(2);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(980, 74);
            this.panelSuperior.TabIndex = 2;
            this.panelSuperior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelSuperior_MouseDown);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(34, 27);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(145, 20);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre del Medico";
            // 
            // pbCerrar
            // 
            this.pbCerrar.Image = global::LP2Soft.Properties.Resources.close_window_xxl;
            this.pbCerrar.Location = new System.Drawing.Point(928, 16);
            this.pbCerrar.Margin = new System.Windows.Forms.Padding(2);
            this.pbCerrar.Name = "pbCerrar";
            this.pbCerrar.Size = new System.Drawing.Size(38, 41);
            this.pbCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCerrar.TabIndex = 0;
            this.pbCerrar.TabStop = false;
            this.pbCerrar.Click += new System.EventHandler(this.pbCerrar_Click);
            // 
            // panelContenedor
            // 
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(218, 74);
            this.panelContenedor.Margin = new System.Windows.Forms.Padding(2);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(762, 460);
            this.panelContenedor.TabIndex = 4;
            // 
            // frmMedicoPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 534);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panelLateral);
            this.Controls.Add(this.panelSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMedicoPrincipal";
            this.Text = "FrmPrincipalMedico";
            this.panelLateral.ResumeLayout(false);
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLateral;
        private System.Windows.Forms.Button btnGestionarPerfil;
        private System.Windows.Forms.Button btnGestionCitas;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.PictureBox pbCerrar;
        private System.Windows.Forms.Panel panelContenedor;
    }
}