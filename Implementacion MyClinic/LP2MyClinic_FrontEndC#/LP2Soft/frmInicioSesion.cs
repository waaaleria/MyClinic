using LP2Soft.MedicinaWS;
using LP2Soft.UsuarioWS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LP2Soft
{
    public partial class frmInicioSesion : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParam);

        private UsuarioWSClient daoUsuario;
        private MedicinaWSClient daoMedicina;
        private int alerta;
        public frmInicioSesion()
        {
            InitializeComponent();
            daoUsuario = new UsuarioWSClient();
            daoMedicina = new MedicinaWSClient();
            lblError.Text = "";
        }


        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            usuario cuentaUsuario = new usuario();


            cuentaUsuario.dni = txtUsuario.Text;
            cuentaUsuario.contraseña = txtPassword.Text;

            int resultado = daoUsuario.verificarCuentaUsuario(cuentaUsuario.dni, cuentaUsuario.contraseña);

            if (resultado != 0)
            {  
                BindingList<rol> roles
                = new BindingList<rol>(
                daoUsuario.verificarRolesDeUsuario(cuentaUsuario.dni, cuentaUsuario.contraseña));
                usuario usuarioLogeado = daoUsuario.obtenerUsuarioPorId(resultado);

                FormPantallaInicio formPrincipal = new FormPantallaInicio(usuarioLogeado);
                formPrincipal.BtnGestionarCitasP.Visible = false;
                formPrincipal.BtnHistoricoCitasP.Visible = false;
                formPrincipal.BtnGestionarPerfilP.Visible = false;
                formPrincipal.BtnHistoricoCitasMed.Visible = false;
                formPrincipal.BtnGestionarMedicoAdmi.Visible = false;
                formPrincipal.BtnIngresarLoteAlma.Visible = false;
                formPrincipal.BtnMantenimientoAlma.Visible = false;
                formPrincipal.BtnRevisarLote.Visible = false;
                formPrincipal.btnBibliotecaLotes.Visible = false;

                foreach (var role in roles)
                {
                    switch (role.idRol)
                    {
                        case 1://administrador 
                            formPrincipal.BtnGestionarMedicoAdmi.Visible = true;
                            formPrincipal.BtnGestionarCitasP.Visible = true;
                            formPrincipal.btnBibliotecaLotes.Visible=true;
                            formPrincipal.BtnRevisarLote.Visible = true;
                            break;
                        case 2://medico
                            formPrincipal.BtnGestionarPerfilP.Visible = true;
                            formPrincipal.BtnHistoricoCitasMed.Visible = true;
                            formPrincipal.btnBibliotecaLotes.Visible= true;
                            break;
                        case 3://paciente
                            formPrincipal.BtnGestionarCitasP.Visible = true;
                            formPrincipal.BtnHistoricoCitasP.Visible = true;
                            formPrincipal.BtnGestionarPerfilP.Visible = true;
                            break;
                        case 4://almacenista
                            formPrincipal.BtnIngresarLoteAlma.Visible = true;
                            formPrincipal.BtnMantenimientoAlma.Visible = true;
                            alerta = 1;
                            break;
                    }
                }

                this.Hide();
                formPrincipal.Show();
                if (alerta == 1)
                {
                    if (daoMedicina.listarInventarioMantenimiento() != null)
                    {
                        this.Alert("TIENES LOTES POR VENCER");

                    }
                }
            }
            else
            {
                lblError.Text = "El usuario ha ingresado un usuario/contraseña incorrecta";
            }
        }

        private void pbCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "USUARIO")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.LightGray;
            }
        }

        private void textUsuario_Leave(object sender, EventArgs e)
        {
            if(txtUsuario.Text == "")
            {
                txtUsuario.Text = "USUARIO";
                txtUsuario.ForeColor = Color.DimGray;
            }
        }

        private void textContraseña_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "CONTRASEÑA")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.LightGray;
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void textContraseña_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "CONTRASEÑA";
                txtPassword.ForeColor = Color.DimGray;
                txtPassword.UseSystemPasswordChar = false;
            }
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void frmInicioSesion_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        public void Alert(string msg)
        {
            frmNotificacion frm = new frmNotificacion();
            frm.showAlert(msg);
        }
    }
}
