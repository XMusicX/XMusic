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
        public int IdPlayListSeleccionada;
        GestorListasReproduccion GListas = new GestorListasReproduccion();
        int IdCancionSeleccionada;
        List<string> NombresCancioes = new List<string>();
        List<int> IdCanciones = new List<int>();
        public IUMenuListasReproduccion()
        {
            InitializeComponent();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {            
            IUListasReproduccion IUlistas = new IUListasReproduccion();
            IUlistas.Show();
            this.Close();
        }

        private void IUMenuListasReproduccion_Load(object sender, EventArgs e)
        {

        }

        private void btnAñadirCancion_Click(object sender, EventArgs e)
        {
             ActualizarListaCancionesEnBD();
             btnAgregarCancion.Enabled = true;             
        }

        public void ActualizarListaCancionesEnBD()
        {
            GestorReproduccion GRep = new GestorReproduccion();
            NombresCancioes = GRep.ConsultarNombresCanciones(IdUsuario);
            IdCanciones = GRep.ConsultarIDCanciones(IdUsuario);

            foreach (string nombre in NombresCancioes)
            {
                lstCanciones.Items.Add(nombre);
            }
        }

        private void btnAgregarCancion_Click(object sender, EventArgs e)
        {
            GListas.AñadirCancionAPlayList(IdPlayListSeleccionada, IdCancionSeleccionada);
            btnAgregarCancion.Enabled = false;
            lstCanciones.Items.Clear();
        }

        private void lstCanciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            IdCancionSeleccionada = IdCanciones[lstCanciones.SelectedIndex];
        }
    }
}
