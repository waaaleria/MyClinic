namespace LP2Soft
{
    partial class frmTarjetaMedico
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
            this.gbMedico = new System.Windows.Forms.GroupBox();
            this.txtAñosExperiencia = new System.Windows.Forms.TextBox();
            this.lblAños = new System.Windows.Forms.Label();
            this.lblEspecialidadMedico = new System.Windows.Forms.Label();
            this.textEstudios = new System.Windows.Forms.TextBox();
            this.lblNombrePaciente = new System.Windows.Forms.Label();
            this.txtNombreMedico = new System.Windows.Forms.TextBox();
            this.txtCMPMedico = new System.Windows.Forms.TextBox();
            this.lblDNIMedico = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbMedico.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbMedico
            // 
            this.gbMedico.Controls.Add(this.txtAñosExperiencia);
            this.gbMedico.Controls.Add(this.lblAños);
            this.gbMedico.Controls.Add(this.lblEspecialidadMedico);
            this.gbMedico.Controls.Add(this.textEstudios);
            this.gbMedico.Controls.Add(this.lblNombrePaciente);
            this.gbMedico.Controls.Add(this.txtNombreMedico);
            this.gbMedico.Controls.Add(this.txtCMPMedico);
            this.gbMedico.Controls.Add(this.lblDNIMedico);
            this.gbMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbMedico.Location = new System.Drawing.Point(12, 12);
            this.gbMedico.Name = "gbMedico";
            this.gbMedico.Size = new System.Drawing.Size(353, 175);
            this.gbMedico.TabIndex = 43;
            this.gbMedico.TabStop = false;
            this.gbMedico.Text = "Datos del Médico";
            // 
            // txtAñosExperiencia
            // 
            this.txtAñosExperiencia.Enabled = false;
            this.txtAñosExperiencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAñosExperiencia.Location = new System.Drawing.Point(125, 127);
            this.txtAñosExperiencia.Name = "txtAñosExperiencia";
            this.txtAñosExperiencia.ReadOnly = true;
            this.txtAñosExperiencia.Size = new System.Drawing.Size(189, 20);
            this.txtAñosExperiencia.TabIndex = 7;
            // 
            // lblAños
            // 
            this.lblAños.AutoSize = true;
            this.lblAños.Location = new System.Drawing.Point(30, 128);
            this.lblAños.Name = "lblAños";
            this.lblAños.Size = new System.Drawing.Size(85, 17);
            this.lblAños.TabIndex = 6;
            this.lblAños.Text = "Experiencia:";
            // 
            // lblEspecialidadMedico
            // 
            this.lblEspecialidadMedico.AutoSize = true;
            this.lblEspecialidadMedico.Location = new System.Drawing.Point(49, 101);
            this.lblEspecialidadMedico.Name = "lblEspecialidadMedico";
            this.lblEspecialidadMedico.Size = new System.Drawing.Size(66, 17);
            this.lblEspecialidadMedico.TabIndex = 5;
            this.lblEspecialidadMedico.Text = "Estudios:";
            // 
            // textEstudios
            // 
            this.textEstudios.Enabled = false;
            this.textEstudios.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEstudios.Location = new System.Drawing.Point(125, 99);
            this.textEstudios.Name = "textEstudios";
            this.textEstudios.ReadOnly = true;
            this.textEstudios.Size = new System.Drawing.Size(189, 20);
            this.textEstudios.TabIndex = 4;
            // 
            // lblNombrePaciente
            // 
            this.lblNombrePaciente.AutoSize = true;
            this.lblNombrePaciente.Location = new System.Drawing.Point(52, 72);
            this.lblNombrePaciente.Name = "lblNombrePaciente";
            this.lblNombrePaciente.Size = new System.Drawing.Size(62, 17);
            this.lblNombrePaciente.TabIndex = 3;
            this.lblNombrePaciente.Text = "Nombre:";
            // 
            // txtNombreMedico
            // 
            this.txtNombreMedico.Enabled = false;
            this.txtNombreMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreMedico.Location = new System.Drawing.Point(125, 71);
            this.txtNombreMedico.Name = "txtNombreMedico";
            this.txtNombreMedico.ReadOnly = true;
            this.txtNombreMedico.Size = new System.Drawing.Size(189, 20);
            this.txtNombreMedico.TabIndex = 2;
            // 
            // txtCMPMedico
            // 
            this.txtCMPMedico.Enabled = false;
            this.txtCMPMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCMPMedico.Location = new System.Drawing.Point(125, 43);
            this.txtCMPMedico.Name = "txtCMPMedico";
            this.txtCMPMedico.ReadOnly = true;
            this.txtCMPMedico.Size = new System.Drawing.Size(189, 20);
            this.txtCMPMedico.TabIndex = 1;
            // 
            // lblDNIMedico
            // 
            this.lblDNIMedico.AutoSize = true;
            this.lblDNIMedico.Location = new System.Drawing.Point(72, 43);
            this.lblDNIMedico.Name = "lblDNIMedico";
            this.lblDNIMedico.Size = new System.Drawing.Size(41, 17);
            this.lblDNIMedico.TabIndex = 0;
            this.lblDNIMedico.Text = "CMP:";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::LP2Soft.Properties.Resources.images__2_1;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(383, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(167, 165);
            this.panel1.TabIndex = 42;
            // 
            // frmTarjetaMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(573, 214);
            this.Controls.Add(this.gbMedico);
            this.Controls.Add(this.panel1);
            this.Name = "frmTarjetaMedico";
            this.gbMedico.ResumeLayout(false);
            this.gbMedico.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gbMedico;
        private System.Windows.Forms.Label lblAños;
        private System.Windows.Forms.Label lblEspecialidadMedico;
        private System.Windows.Forms.TextBox textEstudios;
        private System.Windows.Forms.Label lblNombrePaciente;
        private System.Windows.Forms.TextBox txtNombreMedico;
        private System.Windows.Forms.TextBox txtCMPMedico;
        private System.Windows.Forms.Label lblDNIMedico;
        private System.Windows.Forms.TextBox txtAñosExperiencia;
    }
}