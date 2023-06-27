using LP2Soft.UsuarioWS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LP2Soft
{
    public partial class FormPantallaInicio : Form
    {
        //CAMPOS
        private Button currentButton;
        private Form activeForm;


        private usuario usuarioLogeado;

        public Button BtnGestionarCitasP
        {
            get => btnGestionarCitasP;
            set => btnGestionarCitasP = value;
        }
        public Button BtnHistoricoCitasP
        {
            get => btnHistoricoCitasP;
            set => btnHistoricoCitasP = value;
        }
        public Button BtnGestionarPerfilP
        {
            get => btnGestionarPerfilP;
            set => btnGestionarPerfilP = value;
        }
        public Button BtnHistoricoCitasMed
        {
            get => btnHistoricoCitasMed;
            set => btnHistoricoCitasMed = value;
        }
        public Button BtnGestionarMedicoAdmi
        {
            get => btnGestionarMedicoAdmi;
            set => btnGestionarMedicoAdmi = value;
        }

        public Button BtnIngresarLoteAlma
        {
            get => btnIngresarLoteAlma;
            set => btnIngresarLoteAlma = value;
        }
        public Button BtnMantenimientoAlma
        {
            get => btnMantenimientoAlma;
            set => btnMantenimientoAlma = value;
        }

        public Button BtnRevisarLote
        {
            get => btnRevisionLote;
            set => btnRevisionLote = value;
        }

        public Button btnBibliotecaLotes
        {
            get => btnBiblioteca;
            set => btnBiblioteca = value;
        }

        public FormPantallaInicio(usuario usuarioLogeado)
        {
            InitializeComponent();
            BtnCerrarForm.Visible = false;
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds=Screen.FromHandle(this.Handle).WorkingArea;

            this.usuarioLogeado = usuarioLogeado;

        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg,int wParam, int lParam);

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = ColorTranslator.FromHtml("#679FF5");
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    BtnCerrarForm.Visible = true;
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenuPaciente.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void OpenChildForm(Form child, object btnSender)
        {
            if(activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = child;
            child.TopLevel = false;
            child.FormBorderStyle = FormBorderStyle.None;
            child.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(child);
            this.panelContenedor.Tag = child;
            child.BringToFront();
            child.Show();
        }
        private void btnHistoricoCitas_Click(object sender, EventArgs e)
        {
            frmPacienteHistoricoCitas formHistCi = new frmPacienteHistoricoCitas(usuarioLogeado);
            OpenChildForm(formHistCi, sender);
            lblTitle.Text = "HISTORICO DE CITAS";
            
        }

        private void btnGestionarPerfil_Click(object sender, EventArgs e)
        {
            FrmPacGestionaPerfil formGestPE = new FrmPacGestionaPerfil(usuarioLogeado);
            OpenChildForm(formGestPE, sender);
            lblTitle.Text = "GESTIONAR PERFIL";
        }

        private void btnGestionarCitas_Click(object sender, EventArgs e)
        {
            frmPacienteGestionarCitas formGestEmp = new frmPacienteGestionarCitas(usuarioLogeado);
            OpenChildForm(formGestEmp, sender);
            lblTitle.Text = "GESTIONAR CITAS";
        }
        private void btnHistoricoCitasMed_Click(object sender, EventArgs e)
        {
            frmMedicoHistoricoCitas formHistoricoCitas = new frmMedicoHistoricoCitas(usuarioLogeado.idUsuario);
            OpenChildForm(formHistoricoCitas, sender);
            lblTitle.Text = "AGENDA DE CITAS";
        }

        private void btnIngresarLoteAlma_Click(object sender, EventArgs e)
        {
            frmAlmacenistaIngresarLote formGestIngreso = new frmAlmacenistaIngresarLote();
            OpenChildForm(formGestIngreso, sender);
            lblTitle.Text = "INGRESAR LOTE";
        }

        private void btnMantenimientoAlma_Click(object sender, EventArgs e)
        {
            frmAlmacenistaMantenimientoLote formGestMantenimiento = new frmAlmacenistaMantenimientoLote();
            OpenChildForm(formGestMantenimiento, sender);
            lblTitle.Text = "MANTENIMIENTO LOTE";
        }



        private void BtnCerrarForm_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            lblTitle.Text = "HOME";
            currentButton = null;
            BtnCerrarForm.Visible = false;
        }

        private void panelTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        public void mostrarFormulario(Form form)
        {
            panelContenedor.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            panelContenedor.Controls.Add(form);
            form.Visible = true;
        }

        private void btnRevisionLote_Click_1(object sender, EventArgs e)
        {
            frmAdministradorRevisionLote formRevisarLote = new frmAdministradorRevisionLote();
            OpenChildForm(formRevisarLote, sender);
            lblTitle.Text = "REVISION LOTE";
        }

        private void btnGestionarMedicoAdmi_Click(object sender, EventArgs e)
        {
            frmAdministradorGestionarMedico formGestMedico = new frmAdministradorGestionarMedico();
            OpenChildForm(formGestMedico, sender);
            lblTitle.Text = "GESTIONAR MEDICO";
        }

        private void btnBiblioteca_Click(object sender, EventArgs e)
        {
           FrmBibliotecaHistorialPaciente formGestMedico = new FrmBibliotecaHistorialPaciente();
           OpenChildForm(formGestMedico, sender);
           lblTitle.Text = "HISTORIAL DE PACIENTE";
        }

    }
}
