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
        List<ModeloPlayList> PlayLists = new List<ModeloPlayList>();
        bool Reproducir = false;
        int indicePlayListReproducir;
        public IUListasReproduccion()
        {
            InitializeComponent();
        }

        private void btnCrearPlayList_Click(object sender, EventArgs e)
        {
            pnlIngresarNombre.Visible = true;
            pnlMenuBotones.Visible = false;
            txtNombrePlayList.Text = "";
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

                pnlIngresarNombre.Visible = false;
                pnlMenuBotones.Visible = true;
                btnReproducir.Enabled = false;
                btnModificarPlayList.Enabled = false;
                btnEliminarPlayList.Enabled = false;
                ActualizarListasPlayList();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            pnlIngresarNombre.Visible = false;
            pnlMenuBotones.Visible = true;
            btnModificarPlayList.Enabled = false;
            btnReproducir.Enabled = false;
            btnEliminarPlayList.Enabled = false;
        }
        private void ActualizarListasPlayList()
        {
            lslListasReproduccion.Items.Clear();
            PlayLists = GListas.ConsultarPlayLists(IdUsuario);
            foreach(ModeloPlayList play in PlayLists)
            {
                lslListasReproduccion.Items.Add(play.Nombre);
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
            IUMenuListas.PlayList = PlayLists[lslListasReproduccion.SelectedIndex];
            IUMenuListas.Show();
            this.Visible = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lslListasReproduccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnModificarPlayList.Enabled = true;
            btnReproducir.Enabled = true;
            btnEliminarPlayList.Enabled = true;
        }

        private void btnEliminarPlayList_Click(object sender, EventArgs e)
        {
            GListas.EliminarPlayList(PlayLists[lslListasReproduccion.SelectedIndex].IdPlayList);
            btnEliminarPlayList.Enabled = false;
            btnModificarPlayList.Enabled = false;
            btnReproducir.Enabled = false;
            ActualizarListasPlayList();
        }

        private void btnReproducir_Click(object sender, EventArgs e)
        {
            Reproducir = true;
            indicePlayListReproducir = lslListasReproduccion.SelectedIndex;
            ActualizarListasPlayList();
            IUReproductor.ActiveForm.Activate();
            this.Visible = false;
        }
        public bool QuiereReproducir()
        {
            return Reproducir;
        }
        public ModeloPlayList ObtenerListaReproducir()
        {
            return PlayLists[indicePlayListReproducir];
        }
    }
}
