using LP2Soft;
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
    public partial class frmMedicoPrincipal : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]


        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParam);

        int _idUsuario = 6; //Provisional hasta que tenga el login.
                            
        public frmMedicoPrincipal()
        {
            InitializeComponent();

        }

        private void pbCerrar_Click(object sender, EventArgs e)
        {
            //Application.Exit();
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

        public void mostrarFormulario(Form form)
        {
            panelContenedor.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            panelContenedor.Controls.Add(form);
            form.Visible = true;
        }
   

        private void btnGestionCitas_Click(object sender, EventArgs e)
        {
            frmMedicoHistoricoCitas formHistoricoCitas = new frmMedicoHistoricoCitas(_idUsuario);
            mostrarFormulario(formHistoricoCitas);
        }

        private void btnGestionarPerfil_Click(object sender, EventArgs e)
        {
            frmMedicoGestionarPerfil formGestPerf = new frmMedicoGestionarPerfil(_idUsuario);
            mostrarFormulario(formGestPerf);
        }
    }
}
