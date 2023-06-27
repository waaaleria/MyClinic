namespace LP2Soft
{
    partial class FormPantallaInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPantallaInicio));
            this.panelMenuPaciente = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.BtnCerrarForm = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnMaximizar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnBiblioteca = new System.Windows.Forms.Button();
            this.btnRevisionLote = new System.Windows.Forms.Button();
            this.btnMantenimientoAlma = new System.Windows.Forms.Button();
            this.btnIngresarLoteAlma = new System.Windows.Forms.Button();
            this.btnGestionarMedicoAdmi = new System.Windows.Forms.Button();
            this.btnHistoricoCitasMed = new System.Windows.Forms.Button();
            this.btnGestionarPerfilP = new System.Windows.Forms.Button();
            this.btnHistoricoCitasP = new System.Windows.Forms.Button();
            this.btnGestionarCitasP = new System.Windows.Forms.Button();
            this.panelMenuPaciente.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelTitle.SuspendLayout();
            this.panelContenedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenuPaciente
            // 
            this.panelMenuPaciente.AutoScroll = true;
            this.panelMenuPaciente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenuPaciente.Controls.Add(this.btnBiblioteca);
            this.panelMenuPaciente.Controls.Add(this.btnRevisionLote);
            this.panelMenuPaciente.Controls.Add(this.btnMantenimientoAlma);
            this.panelMenuPaciente.Controls.Add(this.btnIngresarLoteAlma);
            this.panelMenuPaciente.Controls.Add(this.btnGestionarMedicoAdmi);
            this.panelMenuPaciente.Controls.Add(this.btnHistoricoCitasMed);
            this.panelMenuPaciente.Controls.Add(this.btnGestionarPerfilP);
            this.panelMenuPaciente.Controls.Add(this.btnHistoricoCitasP);
            this.panelMenuPaciente.Controls.Add(this.btnGestionarCitasP);
            this.panelMenuPaciente.Controls.Add(this.panelLogo);
            this.panelMenuPaciente.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenuPaciente.Location = new System.Drawing.Point(0, 0);
            this.panelMenuPaciente.Name = "panelMenuPaciente";
            this.panelMenuPaciente.Size = new System.Drawing.Size(220, 580);
            this.panelMenuPaciente.TabIndex = 1;
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelLogo.Controls.Add(this.label1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(203, 75);
            this.panelLogo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(41, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Clinica Ortega";
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(64)))), ((int)(((byte)(147)))));
            this.panelTitle.Controls.Add(this.BtnCerrarForm);
            this.panelTitle.Controls.Add(this.btnMinimizar);
            this.panelTitle.Controls.Add(this.btnMaximizar);
            this.panelTitle.Controls.Add(this.btnCerrar);
            this.panelTitle.Controls.Add(this.lblTitle);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(220, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(863, 75);
            this.panelTitle.TabIndex = 2;
            this.panelTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitle_MouseDown);
            // 
            // BtnCerrarForm
            // 
            this.BtnCerrarForm.FlatAppearance.BorderSize = 0;
            this.BtnCerrarForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrarForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCerrarForm.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnCerrarForm.Location = new System.Drawing.Point(6, 16);
            this.BtnCerrarForm.Name = "BtnCerrarForm";
            this.BtnCerrarForm.Size = new System.Drawing.Size(82, 43);
            this.BtnCerrarForm.TabIndex = 1;
            this.BtnCerrarForm.Text = "X";
            this.BtnCerrarForm.UseVisualStyleBackColor = true;
            this.BtnCerrarForm.Click += new System.EventHandler(this.BtnCerrarForm_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Font = new System.Drawing.Font("Microsoft PhagsPa", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimizar.ForeColor = System.Drawing.Color.White;
            this.btnMinimizar.Location = new System.Drawing.Point(786, -5);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(31, 31);
            this.btnMinimizar.TabIndex = 3;
            this.btnMinimizar.Text = "-";
            this.btnMinimizar.UseVisualStyleBackColor = true;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.FlatAppearance.BorderSize = 0;
            this.btnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximizar.Font = new System.Drawing.Font("Microsoft PhagsPa", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaximizar.ForeColor = System.Drawing.Color.White;
            this.btnMaximizar.Location = new System.Drawing.Point(813, -3);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(27, 32);
            this.btnMaximizar.TabIndex = 2;
            this.btnMaximizar.Text = "⬜";
            this.btnMaximizar.UseVisualStyleBackColor = true;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft PhagsPa", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Location = new System.Drawing.Point(836, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(27, 32);
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.Text = "X";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft PhagsPa", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(346, 21);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(76, 28);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "HOME";
            // 
            // panelContenedor
            // 
            this.panelContenedor.Controls.Add(this.panel3);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(220, 75);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(863, 505);
            this.panelContenedor.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.BackgroundImage = global::LP2Soft.Properties.Resources.ORTEGA;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Location = new System.Drawing.Point(217, 135);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(387, 151);
            this.panel3.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackgroundImage = global::LP2Soft.Properties.Resources.ORTEGA;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(417, 205);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(387, 151);
            this.panel2.TabIndex = 3;
            // 
            // btnBiblioteca
            // 
            this.btnBiblioteca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBiblioteca.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBiblioteca.FlatAppearance.BorderSize = 0;
            this.btnBiblioteca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBiblioteca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBiblioteca.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnBiblioteca.Image = global::LP2Soft.Properties.Resources.image__13___3_;
            this.btnBiblioteca.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBiblioteca.Location = new System.Drawing.Point(0, 1035);
            this.btnBiblioteca.Name = "btnBiblioteca";
            this.btnBiblioteca.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnBiblioteca.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnBiblioteca.Size = new System.Drawing.Size(203, 120);
            this.btnBiblioteca.TabIndex = 12;
            this.btnBiblioteca.Text = "Historial de Paciente";
            this.btnBiblioteca.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBiblioteca.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBiblioteca.UseVisualStyleBackColor = true;
            this.btnBiblioteca.Click += new System.EventHandler(this.btnBiblioteca_Click);
            // 
            // btnRevisionLote
            // 
            this.btnRevisionLote.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRevisionLote.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRevisionLote.FlatAppearance.BorderSize = 0;
            this.btnRevisionLote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRevisionLote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRevisionLote.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnRevisionLote.Image = global::LP2Soft.Properties.Resources.image__12___1_;
            this.btnRevisionLote.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRevisionLote.Location = new System.Drawing.Point(0, 915);
            this.btnRevisionLote.Name = "btnRevisionLote";
            this.btnRevisionLote.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnRevisionLote.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnRevisionLote.Size = new System.Drawing.Size(203, 120);
            this.btnRevisionLote.TabIndex = 11;
            this.btnRevisionLote.Text = "Revisión de Lote";
            this.btnRevisionLote.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRevisionLote.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRevisionLote.UseVisualStyleBackColor = true;
            this.btnRevisionLote.Click += new System.EventHandler(this.btnRevisionLote_Click_1);
            // 
            // btnMantenimientoAlma
            // 
            this.btnMantenimientoAlma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMantenimientoAlma.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMantenimientoAlma.FlatAppearance.BorderSize = 0;
            this.btnMantenimientoAlma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMantenimientoAlma.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMantenimientoAlma.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMantenimientoAlma.Image = global::LP2Soft.Properties.Resources.image__12___1_;
            this.btnMantenimientoAlma.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMantenimientoAlma.Location = new System.Drawing.Point(0, 795);
            this.btnMantenimientoAlma.Name = "btnMantenimientoAlma";
            this.btnMantenimientoAlma.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnMantenimientoAlma.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnMantenimientoAlma.Size = new System.Drawing.Size(203, 120);
            this.btnMantenimientoAlma.TabIndex = 10;
            this.btnMantenimientoAlma.Text = "    Mantenimiento Lote";
            this.btnMantenimientoAlma.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMantenimientoAlma.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMantenimientoAlma.UseVisualStyleBackColor = true;
            this.btnMantenimientoAlma.Click += new System.EventHandler(this.btnMantenimientoAlma_Click);
            // 
            // btnIngresarLoteAlma
            // 
            this.btnIngresarLoteAlma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnIngresarLoteAlma.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnIngresarLoteAlma.FlatAppearance.BorderSize = 0;
            this.btnIngresarLoteAlma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresarLoteAlma.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresarLoteAlma.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnIngresarLoteAlma.Image = global::LP2Soft.Properties.Resources.image__11___1___1_;
            this.btnIngresarLoteAlma.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIngresarLoteAlma.Location = new System.Drawing.Point(0, 675);
            this.btnIngresarLoteAlma.Name = "btnIngresarLoteAlma";
            this.btnIngresarLoteAlma.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnIngresarLoteAlma.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnIngresarLoteAlma.Size = new System.Drawing.Size(203, 120);
            this.btnIngresarLoteAlma.TabIndex = 9;
            this.btnIngresarLoteAlma.Text = "    Ingresar Lote";
            this.btnIngresarLoteAlma.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIngresarLoteAlma.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnIngresarLoteAlma.UseVisualStyleBackColor = true;
            this.btnIngresarLoteAlma.Click += new System.EventHandler(this.btnIngresarLoteAlma_Click);
            // 
            // btnGestionarMedicoAdmi
            // 
            this.btnGestionarMedicoAdmi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnGestionarMedicoAdmi.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGestionarMedicoAdmi.FlatAppearance.BorderSize = 0;
            this.btnGestionarMedicoAdmi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionarMedicoAdmi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionarMedicoAdmi.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnGestionarMedicoAdmi.Image = global::LP2Soft.Properties.Resources.image__10___1___4___1_;
            this.btnGestionarMedicoAdmi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestionarMedicoAdmi.Location = new System.Drawing.Point(0, 555);
            this.btnGestionarMedicoAdmi.Name = "btnGestionarMedicoAdmi";
            this.btnGestionarMedicoAdmi.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnGestionarMedicoAdmi.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnGestionarMedicoAdmi.Size = new System.Drawing.Size(203, 120);
            this.btnGestionarMedicoAdmi.TabIndex = 6;
            this.btnGestionarMedicoAdmi.Text = " Gestionar Medico";
            this.btnGestionarMedicoAdmi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestionarMedicoAdmi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGestionarMedicoAdmi.UseVisualStyleBackColor = true;
            this.btnGestionarMedicoAdmi.Click += new System.EventHandler(this.btnGestionarMedicoAdmi_Click);
            // 
            // btnHistoricoCitasMed
            // 
            this.btnHistoricoCitasMed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnHistoricoCitasMed.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHistoricoCitasMed.FlatAppearance.BorderSize = 0;
            this.btnHistoricoCitasMed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistoricoCitasMed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistoricoCitasMed.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnHistoricoCitasMed.Image = global::LP2Soft.Properties.Resources.image__8_;
            this.btnHistoricoCitasMed.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHistoricoCitasMed.Location = new System.Drawing.Point(0, 435);
            this.btnHistoricoCitasMed.Name = "btnHistoricoCitasMed";
            this.btnHistoricoCitasMed.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnHistoricoCitasMed.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnHistoricoCitasMed.Size = new System.Drawing.Size(203, 120);
            this.btnHistoricoCitasMed.TabIndex = 4;
            this.btnHistoricoCitasMed.Text = "  Agenda de Citas";
            this.btnHistoricoCitasMed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHistoricoCitasMed.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHistoricoCitasMed.UseVisualStyleBackColor = true;
            this.btnHistoricoCitasMed.Click += new System.EventHandler(this.btnHistoricoCitasMed_Click);
            // 
            // btnGestionarPerfilP
            // 
            this.btnGestionarPerfilP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnGestionarPerfilP.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGestionarPerfilP.FlatAppearance.BorderSize = 0;
            this.btnGestionarPerfilP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionarPerfilP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionarPerfilP.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnGestionarPerfilP.Image = global::LP2Soft.Properties.Resources.image__9___2_;
            this.btnGestionarPerfilP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestionarPerfilP.Location = new System.Drawing.Point(0, 315);
            this.btnGestionarPerfilP.Name = "btnGestionarPerfilP";
            this.btnGestionarPerfilP.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnGestionarPerfilP.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnGestionarPerfilP.Size = new System.Drawing.Size(203, 120);
            this.btnGestionarPerfilP.TabIndex = 3;
            this.btnGestionarPerfilP.Text = "    Gestionar Perfil";
            this.btnGestionarPerfilP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestionarPerfilP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGestionarPerfilP.UseVisualStyleBackColor = true;
            this.btnGestionarPerfilP.Click += new System.EventHandler(this.btnGestionarPerfil_Click);
            // 
            // btnHistoricoCitasP
            // 
            this.btnHistoricoCitasP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnHistoricoCitasP.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHistoricoCitasP.FlatAppearance.BorderSize = 0;
            this.btnHistoricoCitasP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistoricoCitasP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistoricoCitasP.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnHistoricoCitasP.Image = global::LP2Soft.Properties.Resources.image__8_;
            this.btnHistoricoCitasP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHistoricoCitasP.Location = new System.Drawing.Point(0, 195);
            this.btnHistoricoCitasP.Name = "btnHistoricoCitasP";
            this.btnHistoricoCitasP.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnHistoricoCitasP.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnHistoricoCitasP.Size = new System.Drawing.Size(203, 120);
            this.btnHistoricoCitasP.TabIndex = 2;
            this.btnHistoricoCitasP.Text = "  Historico de Citas";
            this.btnHistoricoCitasP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHistoricoCitasP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHistoricoCitasP.UseVisualStyleBackColor = true;
            this.btnHistoricoCitasP.Click += new System.EventHandler(this.btnHistoricoCitas_Click);
            // 
            // btnGestionarCitasP
            // 
            this.btnGestionarCitasP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnGestionarCitasP.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGestionarCitasP.FlatAppearance.BorderSize = 0;
            this.btnGestionarCitasP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionarCitasP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionarCitasP.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnGestionarCitasP.Image = global::LP2Soft.Properties.Resources.image__3_;
            this.btnGestionarCitasP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestionarCitasP.Location = new System.Drawing.Point(0, 75);
            this.btnGestionarCitasP.Name = "btnGestionarCitasP";
            this.btnGestionarCitasP.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnGestionarCitasP.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnGestionarCitasP.Size = new System.Drawing.Size(203, 120);
            this.btnGestionarCitasP.TabIndex = 1;
            this.btnGestionarCitasP.Text = "      Agendar Cita";
            this.btnGestionarCitasP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestionarCitasP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGestionarCitasP.UseVisualStyleBackColor = true;
            this.btnGestionarCitasP.Click += new System.EventHandler(this.btnGestionarCitas_Click);
            // 
            // FormPantallaInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 580);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.panelMenuPaciente);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPantallaInicio";
            this.panelMenuPaciente.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.panelContenedor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenuPaciente;
        private System.Windows.Forms.Button btnGestionarPerfilP;
        private System.Windows.Forms.Button btnHistoricoCitasP;
        private System.Windows.Forms.Button btnGestionarCitasP;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnMaximizar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Button BtnCerrarForm;
        private System.Windows.Forms.Button btnHistoricoCitasMed;
        private System.Windows.Forms.Button btnGestionarMedicoAdmi;
        private System.Windows.Forms.Button btnMantenimientoAlma;
        private System.Windows.Forms.Button btnIngresarLoteAlma;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnRevisionLote;
        private System.Windows.Forms.Button btnBiblioteca;
    }
}