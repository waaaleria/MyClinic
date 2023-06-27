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
    public partial class frmTarjetaMedico : Form
    {
        private UsuarioWSClient daoUsuario;
        private medico med;
        public frmTarjetaMedico(int idMedicoSeleccionado)
        {
            InitializeComponent();
            daoUsuario = new UsuarioWSClient();
            med = new medico();
            med = daoUsuario.obtener_datos_medico(idMedicoSeleccionado);
            textEstudios.Text=med.estudios.ToString();
            txtAñosExperiencia.Text = med.experiencia +" años";
            txtCMPMedico.Text = med.cmp;
            txtNombreMedico.Text = med.nombre + " " + med.apellido;
        }
    }
}
