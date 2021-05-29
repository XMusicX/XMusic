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
    public partial class IUListasReproduccion : Form
    {
        public int IdUsuario;
        GestorListasReproduccion GListas = new GestorListasReproduccion();
        List<string> playLists = new List<string>();
        List<int> idPlayList = new List<int>();
        public IUListasReproduccion()
        {
            InitializeComponent();
        }

        private void btnCrearPlayList_Click(object sender, EventArgs e)
        {
            txtNombrePlayList.Visible = true;
            btnAceptar.Visible = true;
            btnCancelar.Visible = true;
            lblInstruccion.Visible = true;
            btnReproducir.Visible = false;
            btnModificarPlayList.Visible = false;
            btnCrearPlayList.Visible = false;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if(txtNombrePlayList.Text == "")
            {
                MessageBox.Show("Ingrese un nombre");
            }
            else
            {
                GListas.CrearPlayList(IdUsuario, txtNombrePlayList.Text);

                txtNombrePlayList.Visible = false;
                btnAceptar.Visible = false;
                btnCancelar.Visible = false;
                lblInstruccion.Visible = false;
                btnReproducir.Visible = true;
                btnModificarPlayList.Visible = true;
                btnCrearPlayList.Visible = true;

                ActualizarListasPlayList();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtNombrePlayList.Visible = false;
            btnAceptar.Visible = false;
            btnCancelar.Visible = false;
            lblInstruccion.Visible = false;
            btnReproducir.Visible = true;
            btnModificarPlayList.Visible = true;
            btnCrearPlayList.Visible = true;
        }
        public void ActualizarListasPlayList()
        {
            lslListasReproduccion.Items.Clear();
            playLists = GListas.ConsultarNombresPlayLists(IdUsuario);
            idPlayList = GListas.ConsultarIdPlayLists(IdUsuario);
            foreach(string nombre in playLists)
            {
                lslListasReproduccion.Items.Add(nombre);
            }
        }

        private void IUListasReproduccion_Load(object sender, EventArgs e)
        {
            ActualizarListasPlayList();
        }

        private void btnModificarPlayList_Click(object sender, EventArgs e)
        {
            IUMenuListasReproduccion IUMenuListas = new IUMenuListasReproduccion();
            IUMenuListas.IdUsuario = IdUsuario;
            IUMenuListas.IdPlayListSeleccionada = idPlayList[lslListasReproduccion.SelectedIndex];
            IUMenuListas.Show();
            this.Close();
        }
    }
}
