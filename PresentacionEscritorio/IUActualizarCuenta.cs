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
    public partial class IUActualizarCuenta : Form
    {
        public int IdUsuario;
        public IUActualizarCuenta()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            if (txtNombreArtistico.Text == "")
            {
                MessageBox.Show("Ingrese el nombre del artista");
            }
            else 
            {
                GestorRegistroArtista GReg = new GestorRegistroArtista();
                GReg.RegistrarArtista(IdUsuario, txtNombreArtistico.Text);                
                this.Close();
            }
        }
        
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
