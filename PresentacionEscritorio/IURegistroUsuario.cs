using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReglasDeNegocio;

namespace PresentacionEscritorio
{
    public partial class IURegistroUsuario : Form
    {
        IUInicioSesion IUIniciar = new IUInicioSesion();
        GestorInicioUsuarios GInicio = new GestorInicioUsuarios();
        public IURegistroUsuario()
        {
            InitializeComponent();
        }

        private void lblIniciarSesion_Click(object sender, EventArgs e)
        {
            IUIniciar.Visible = true;
            this.Close();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if(txtContraseña.Text == txtConfirmarContraseña.Text)
            {
                GInicio.RegistroUsuario(txtNombre.Text, txtApellido.Text, txtCorreoElectronico.Text, txtContraseña.Text);
                MessageBox.Show("Registro exitoso");
                IUIniciar.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("No coinciden las contraseñas, verifique");
            }
        }
    }
}
