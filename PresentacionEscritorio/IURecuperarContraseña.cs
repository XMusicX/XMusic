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
    public partial class IURecuperarContraseña : Form
    {
        public IURecuperarContraseña()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRecuperarContraseña_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals("") || textBox2.Text.Equals("") || textBox3.Text.Equals("") || textBox4.Text.Equals(""))
            {
                MessageBox.Show("De llenar todos los campos.");
            }
            else
            {
                if (textBox3.Text.Equals(textBox4.Text))
                {
                    GestorRecuperacionContraseña gr = new GestorRecuperacionContraseña();
                    gr.RecuperarContraseña(textBox1.Text, textBox3.Text, textBox2.Text);
                }
                else
                {
                    MessageBox.Show("Las contraseñas no coinciden");
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            IUInicioSesion Iuis = new IUInicioSesion();
            Iuis.Show();
        }
    }
}
