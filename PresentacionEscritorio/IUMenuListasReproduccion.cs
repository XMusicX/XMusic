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
    public partial class IUMenuListasReproduccion : Form
    {
        public int IdUsuario;
        public ModeloPlayList PlayList;
        GestorListasReproduccion GListas = new GestorListasReproduccion();
        List<ModeloCancion> CancionesDeLista = new List<ModeloCancion>();
        List<ModeloCancion> CancionesDeBD = new List<ModeloCancion>();

        ModeloCancion CancionSeleccionada;

        public IUMenuListasReproduccion()
        {
            InitializeComponent();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {            
            IUListasReproduccion IUlistas = new IUListasReproduccion();            
            IUlistas.IdUsuario = IdUsuario;
            IUlistas.Show();
            this.Close();
        }

        private void IUMenuListasReproduccion_Load(object sender, EventArgs e)
        {
            ActualizarListaCancionesPlayList();
            lblNombrePlayList.Text = PlayList.Nombre;
        }       

        private void btnAñadirCancion_Click(object sender, EventArgs e)
        {
            lblNombrePlayList.Text = "Seleccione la cancion a añadir";
            ActualizarListaCancionesEnBD();
            btnAñadirCancion.Enabled = false;
            btnAgregarCancion.Enabled = true;             
        }
        private void ActualizarListaCancionesPlayList()
        {
            lstCanciones.Items.Clear();
            CancionesDeLista = GListas.ConsultarCancionesDePlayList(PlayList.IdPlayList);
            foreach (ModeloCancion cancion in CancionesDeLista)
            {
                lstCanciones.Items.Add(cancion.Nombre);
            }
        }

        private void ActualizarListaCancionesEnBD()
        {
            lstCanciones.Items.Clear();
            CancionesDeBD = GListas.ConsultarCancionesBD(IdUsuario);
            foreach (ModeloCancion cancion in CancionesDeBD)
            {
                lstCanciones.Items.Add(cancion.Nombre);
            }
        }

        private void btnAgregarCancion_Click(object sender, EventArgs e)
        {
            btnAñadirCancion.Enabled = true;
            GListas.AñadirCancionAPlayList(PlayList.IdPlayList, CancionSeleccionada.IdCancion);
            btnAgregarCancion.Enabled = false;            
            lblNombrePlayList.Text = PlayList.Nombre;
            ActualizarListaCancionesPlayList();
        }

        private void lstCanciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (btnAñadirCancion.Enabled == false)
                {
                    btnEliminarCancion.Enabled = false;
                    CancionSeleccionada = CancionesDeBD[lstCanciones.SelectedIndex];
                }
                else
                {
                    btnEliminarCancion.Enabled = true;
                    CancionSeleccionada = CancionesDeLista[lstCanciones.SelectedIndex];
                }
            }
            catch
            {

            }
        }

        private void btnEliminarCancion_Click(object sender, EventArgs e)
        {
            GListas.EliminarCancionDePlayList(PlayList.IdPlayList, CancionSeleccionada.IdCancion);
            ActualizarListaCancionesPlayList();
            btnEliminarCancion.Enabled = false;
        }
    }
}
