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
    public partial class IUMiPerfil : Form
    {
        public int IdUsuario;
        public IUMiPerfil()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void IUMiPerfil_Load(object sender, EventArgs e)
        {
            GestorInicioUsuarios GInicio = new GestorInicioUsuarios();
            List<string> datos = GInicio.ConsultarPerfil(IdUsuario);
            lblNombre.Text = datos[0];
            lblApellidos.Text = datos[1];
            lblCorreo.Text = datos[2];
            lblTipoUsuario.Text = datos[3];
            lblNombreArtistico.Text = datos[4];
        }

        private void btnActualizarCuenta_Click(object sender, EventArgs e)
        {
            if(lblNombreArtistico.Text == "No especificado")
            {
                IUActualizarCuenta iUActualizar = new IUActualizarCuenta();
                iUActualizar.Visible = true;
                iUActualizar.IdUsuario = IdUsuario;
            }
            else
            {
                MessageBox.Show("Ya esta registrado como artista");
            }            
        }
    }
}
