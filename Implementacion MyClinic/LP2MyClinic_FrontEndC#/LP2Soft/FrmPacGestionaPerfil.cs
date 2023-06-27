using LP2Soft.UsuarioWS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LP2Soft
{
    public partial class FrmPacGestionaPerfil : Form
    {
        private Estado estadoPerfil;
        private usuario usuarioLogeado;
        private UsuarioWSClient daoUsuario;
        public void establecerEstadoComponentes()
        {
            switch (this.estadoPerfil)
            {
                case Estado.Inicial:
                    buttonModificar.Enabled = true;
                    break;
                
                case Estado.Modificar:
                    buttonModificar.Enabled = false;
                    break;
                
            }
        }
        public FrmPacGestionaPerfil(usuario usuarioLogeado)
        {
            
            InitializeComponent();
            this.usuarioLogeado = usuarioLogeado;
            daoUsuario = new UsuarioWSClient();
            panelEdicion.Visible = false;
            estadoPerfil = Estado.Inicial;
            establecerEstadoComponentes();
            lblNombre.Text = usuarioLogeado.nombre;
            lblApellido.Text = usuarioLogeado.apellido;
            lblCorreo.Text = usuarioLogeado.correo;
            lblCelular.Text = usuarioLogeado.telefono;
            lblDni.Text = usuarioLogeado.dni;

            BindingList<rol> roles
                = new BindingList<rol>(
                daoUsuario.verificarRolesDeUsuario(usuarioLogeado.dni, usuarioLogeado.contraseña));
            int cant = 1;
            foreach (var role in roles)
            {
                switch (role.idRol)
                {
                    case 2://medico
                        lblrol.Text = "Medico";
                        break;
                    case 3://paciente
                        lblrol.Text = "Paciente";
                        if (cant == 2)
                        {
                            lblrol.Text = "Medico";
                        }
                        break;
                }
                cant++;
            }
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            panelEdicion.Visible = true;
            linkLblEditarContra.Text = "Editar";
            estadoPerfil = Estado.Modificar;
            textBoxCorreo.Text = usuarioLogeado.correo;
            textBoxTelefono.Text = usuarioLogeado.telefono;
            textBoxContraseña.Text = usuarioLogeado.contraseña;
            textBoxConfirmarContraseña.Text = usuarioLogeado.contraseña;
            textBoxConfirmarContraseña.Enabled = false;
            textBoxConfirmarContraseña.UseSystemPasswordChar = true;
            textBoxContraseña.Enabled = false;
            textBoxContraseña.UseSystemPasswordChar=true;
            textBoxNuevaContra.UseSystemPasswordChar = true;
            establecerEstadoComponentes();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            if(textBoxNuevaContra.Text == usuarioLogeado.contraseña)
            {
                if (textBoxContraseña.Text == textBoxConfirmarContraseña.Text)
                {
                    DialogResult result = MessageBox.Show("¿Desea cambiar los datos?",
                    "Cerrar sesion", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (result == DialogResult.Yes)
                    {
                        daoUsuario.modificarUsuario(usuarioLogeado.idUsuario, textBoxCorreo.Text, textBoxTelefono.Text, textBoxContraseña.Text);
                        usuarioLogeado.correo = textBoxCorreo.Text;
                        usuarioLogeado.telefono = textBoxTelefono.Text;
                        usuarioLogeado.contraseña = textBoxContraseña.Text;
                        // Código para guardar los cambios dentro de la pantalla
                        lblCorreo.Text = textBoxCorreo.Text;
                        lblCelular.Text = textBoxTelefono.Text;
                        panelEdicion.Visible = false;
                        estadoPerfil = Estado.Inicial;
                        establecerEstadoComponentes();
                    }
                }
                else
                {
                    DialogResult result = MessageBox.Show("La contraseñas no son iguales");
                    textBoxContraseña.Text = "";
                    textBoxConfirmarContraseña.Text = "";
                }
            }
            //codigo de guardar
            else
            {
                DialogResult result = MessageBox.Show("La contraseña no coincide");

                panelEdicion.Visible = false;
                textBoxNuevaContra.Text = "";
                estadoPerfil = Estado.Inicial;
                establecerEstadoComponentes();
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            //codigo de guardar
            DialogResult result = MessageBox.Show("¿Desea cancelar su registro?",
                "Se modificaron los datos", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                // Código para guardar los cambios
                panelEdicion.Visible = false;
                textBoxCorreo.Text = "";
                textBoxTelefono.Text = "";
                estadoPerfil = Estado.Inicial;
                establecerEstadoComponentes();
            }
        }

        private void linkLblEditarContra_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(linkLblEditarContra.Text == "Editar")
            {
                linkLblEditarContra.Text = "Cancelar";
                textBoxConfirmarContraseña.Enabled = true;
                textBoxConfirmarContraseña.Text="";
                textBoxContraseña.Enabled = true;
                textBoxContraseña.Text="";
            }
            else if(linkLblEditarContra.Text == "Cancelar")
            {
                textBoxConfirmarContraseña.Text = usuarioLogeado.contraseña;
                textBoxConfirmarContraseña.Enabled = false;
                textBoxContraseña.Text = usuarioLogeado.contraseña;
                textBoxContraseña.Enabled = false;
            }
        }
    }
}
