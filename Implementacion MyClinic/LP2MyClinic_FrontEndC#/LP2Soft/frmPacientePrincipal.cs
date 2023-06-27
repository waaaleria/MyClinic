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
    public partial class frmPacientePrincipal : Form
    {
        //para que se pueda mover la panalla
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

      
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParam);
        private usuario usuarioLogeado;


        public Button BtnGestionarCita
        {
            get => btnGestionarCita;
            set => btnGestionarCita = value;
        }

        public Button BtnHistoricoCita
        {
            get => btnHistoricoCita;
            set => btnHistoricoCita = value;
        }

        public Button BtnGestionarPerfil
        {
            get => btnGestionarPerfil;
            set => btnGestionarPerfil = value;
        }
        public frmPacientePrincipal(usuario usuarioLogeado)
        {
            InitializeComponent();
            this.usuarioLogeado = usuarioLogeado;
        }


        //public frmPrincipal(empleado empleadoLogeado)
        //{
        //    InitializeComponent();
        //    this.empleadoLogeado = empleadoLogeado;
        //    lblNombre.Text = empleadoLogeado.nombre + " " +
        //        empleadoLogeado.apellidoPaterno;
        //}



        private void pbCerrar_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            //MessageBox.Show("Debe ingresar un DNI", "Mensaje de Advertencia",
            //        MessageBoxButtons.OK,MessageBoxIcon.Warning);
            //  if(MessageBoxButtons.OK())

            DialogResult result = MessageBox.Show("¿Desea salir de la sesion?", 
                "Cerrar sesion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Código para guardar los cambios
                
                frmInicioSesion formPrincipal = new frmInicioSesion();
                this.Hide();
                formPrincipal.Show();
            }
            
            
        }

        private void panelSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0xA1, 0x2, 0);
        }

        private void btnGestionarEmpleados_Click(object sender, EventArgs e)
        {
            frmPacienteGestionarCitas formGestEmp = new frmPacienteGestionarCitas();
            mostrarFormulario(formGestEmp);
        }

        public void mostrarFormulario(Form form)
        {
            panelContenedor.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            panelContenedor.Controls.Add(form);
            form.Visible = true;
        }

        private void btnBusquedaEmpleados_Click(object sender, EventArgs e)
        {
            frmPacienteHistoricoCitas formHistCi = new frmPacienteHistoricoCitas();
            mostrarFormulario(formHistCi);
        }

        private void btnGestionarPedidos_Click(object sender, EventArgs e)
        {
            FrmPacGestionaPerfil formGestOV = new FrmPacGestionaPerfil();
            mostrarFormulario(formGestOV);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
