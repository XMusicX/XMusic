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
    public partial class IUReproductor : Form
    {
        bool Play = false;
        bool Random = false;
        bool Mute = false;
        int CancionAnterior;

        List<string> ArchivosMP3 = new List<string>();
        List<string> RutasArchivosMP3 = new List<string>();
        List<int> IdArchivosMP3 = new List<int>();

        public int IdUsuario;
        IUListasReproduccion IUListas = new IUListasReproduccion();

        public IUReproductor()
        {
            InitializeComponent();
        }


        private void macTrackBar1_ValueChanged(object sender, decimal value)
        {
            if (macCancion.Value == macCancion.Maximum)
            {
                switch (Play)
                {
                    case true:
                        Random r = new Random();
                        lstCanciones.SelectedIndex = r.Next(0,RutasArchivosMP3.Count());
                        Reproductor.URL = RutasArchivosMP3[lstCanciones.SelectedIndex];
                        break;
                    case false:
                        lstCanciones.SelectedIndex += 1;
                        Reproductor.URL = RutasArchivosMP3[lstCanciones.SelectedIndex];
                        break;
                }
                
            }
        }

        private void macVolumen_ValueChanged(object sender, decimal value)
        {
            Reproductor.settings.volume = macVolumen.Value;
            btnVolumen.Image = Properties.Resources.Volumen;
            Mute = false;
            if (macVolumen.Value == 0)
            {
                Mute = true;
                btnVolumen.Image = Properties.Resources.btnMute;
            }
        }

        private void lblNombreCancion_Click(object sender, EventArgs e)
        {

        }

        private void lblAlbumCancion_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnSubirCancion_Click(object sender, EventArgs e)
        {
            OpenFileDialog CajaDeBusquedaDeArchivos = new OpenFileDialog();
            CajaDeBusquedaDeArchivos.Multiselect = true;
            CajaDeBusquedaDeArchivos.Filter = "Mp3 Files|*.mp3*";
            if (CajaDeBusquedaDeArchivos.ShowDialog()== System.Windows.Forms.DialogResult.OK)
            {
                List<string> ArchivosMp3Nuevos = CajaDeBusquedaDeArchivos.SafeFileNames.ToList();
                List<string> RutasMp3Nuevos = CajaDeBusquedaDeArchivos.FileNames.ToList();
                ArchivosMP3.AddRange(ArchivosMp3Nuevos);
                RutasArchivosMP3.AddRange(RutasMp3Nuevos); 
                foreach(var ArchivosMP3 in ArchivosMp3Nuevos)
                {
                    lstCanciones.Items.Add(ArchivosMP3);
                }
                Reproductor.URL = RutasArchivosMP3[0];
                lstCanciones.SelectedIndex = 0;
                btnReproducir.Image = Properties.Resources.btnPause;
                GestorSubirCanciones GSubir = new GestorSubirCanciones();
                GSubir.RegistrarCanciones(IdUsuario, ArchivosMp3Nuevos.ToArray(), RutasMp3Nuevos.ToArray());
            }
        }

        private void lstCanciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Reproductor.URL = RutasArchivosMP3[lstCanciones.SelectedIndex];
                lblNombreCancion.Text = ArchivosMP3[lstCanciones.SelectedIndex];
                btnReproducir.Image = Properties.Resources.btnPause;
                Play = true;
            }
            catch 
            {
                
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Reproductor_Enter(object sender, EventArgs e)
        {

        }

        private void btnReproducir_Click(object sender, EventArgs e)
        {
            switch(Play)
            {
                case true:
                    Reproductor.Ctlcontrols.pause();
                    btnReproducir.Image = Properties.Resources.btnPlay;
                    Play = false;
                    break;
                case false:
                    Reproductor.Ctlcontrols.play();
                    btnReproducir.Image = Properties.Resources.btnPause;
                    Play = true;
                    break;
            }
        }
        public void ActualizarDatosTrack()
        {
            switch (Reproductor.playState)
            {
                case WMPLib.WMPPlayState.wmppsPlaying:
                    macCancion.Maximum = (int)Reproductor.Ctlcontrols.currentItem.duration;
                    timer1.Start();
                    break;
                case WMPLib.WMPPlayState.wmppsPaused:
                    timer1.Stop();
                    break;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ActualizarDatosTrack();
            macCancion.Value = (int)Reproductor.Ctlcontrols.currentPosition;
            macVolumen.Value = Reproductor.settings.volume;
        }

        private void Reproductor_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            ActualizarDatosTrack();
        }

        private void btnCancionSiguiente_Click(object sender, EventArgs e)
        {
            try
            {
                if (Random == false)
                {
                    if (lstCanciones.SelectedIndex != RutasArchivosMP3.Count() - 1)
                    {
                        lstCanciones.SelectedIndex += 1;
                        Reproductor.URL = RutasArchivosMP3[lstCanciones.SelectedIndex];

                    }
                    else
                    {
                        lstCanciones.SelectedIndex = 0;
                        Reproductor.URL = RutasArchivosMP3[lstCanciones.SelectedIndex];
                    }
                }
                else
                {
                    CancionAnterior = lstCanciones.SelectedIndex;
                    Random r = new Random();
                    lstCanciones.SelectedIndex = r.Next(0, RutasArchivosMP3.Count());
                    Reproductor.URL = RutasArchivosMP3[lstCanciones.SelectedIndex];
                }
            }
            catch
            {

            }
        }

        private void btnCancionAnterior_Click(object sender, EventArgs e)
        {
            try
            {
                if (Random == false)
                {
                    if (lstCanciones.SelectedIndex != 0)
                    {
                        lstCanciones.SelectedIndex -= 1;
                        Reproductor.URL = RutasArchivosMP3[lstCanciones.SelectedIndex];
                    }
                    else
                    {
                        lstCanciones.SelectedIndex = RutasArchivosMP3.Count() - 1;
                        Reproductor.URL = RutasArchivosMP3[lstCanciones.SelectedIndex];
                    }
                }
                else
                {
                    lstCanciones.SelectedIndex = CancionAnterior;
                    Reproductor.URL = RutasArchivosMP3[lstCanciones.SelectedIndex];
                }
            }
            catch
            {

            }
        }

        private void btnAleatorio_Click(object sender, EventArgs e)
        {
            switch (Random)
            {
                case true:
                    btnAleatorio.Image = Properties.Resources.btnNoAleatorio;
                    Random = false;
                    break;
                case false:
                    btnAleatorio.Image = Properties.Resources.btnRandom;
                    Random = true;
                    break;
            }
        }

        private void btnVolumen_Click(object sender, EventArgs e)
        {
            switch (Mute)
            {
                case true:
                    macVolumen.Value = 50;
                    Reproductor.settings.volume = macVolumen.Value;
                    btnVolumen.Image = Properties.Resources.Volumen;
                    Mute = false;
                    break;
                case false:
                    Reproductor.settings.volume = 0;
                    macVolumen.Value = 0;
                    btnVolumen.Image = Properties.Resources.btnMute;
                    Mute = true;
                    break;
            }
        }
        private void ActualizarCancionesBD()
        {
            ArchivosMP3.Clear();
            RutasArchivosMP3.Clear();
            IdArchivosMP3.Clear();
            lstCanciones.Items.Clear();
            GestorReproduccion GRep = new GestorReproduccion();
            List<string> NombresCancioes = new List<string>();
            List<string> RutasCanciones = new List<string>();
            List<int> IdCanciones = new List<int>();

            NombresCancioes = GRep.ConsultarNombresCanciones(IdUsuario);
            RutasCanciones = GRep.ConsultarRutasCanciones(IdUsuario);
            IdCanciones = GRep.ConsultarIDCanciones(IdUsuario);

            foreach (string nombre in NombresCancioes)
            {
                lstCanciones.Items.Add(nombre);
            }
            ArchivosMP3 = NombresCancioes;
            RutasArchivosMP3 = RutasCanciones;
            IdArchivosMP3 = IdCanciones;
            btnEliminarCancion.Enabled = true;
            lblListaCanciones.Text = "Canciones agregadas";
        }
        private void IUReproductor_Load(object sender, EventArgs e)
        {
            ActualizarCancionesBD();
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            IUMiPerfil MiPerfil = new IUMiPerfil();
            MiPerfil.IdUsuario = IdUsuario;
            MiPerfil.Visible = true;
        }

        private void btnPlaylist_Click(object sender, EventArgs e)
        {
            IUListas.IdUsuario = IdUsuario;
            IUListas.Show();
        }
        private void ActualizarCancionesReproducir(List<ModeloCancion> canciones)
        {
            ArchivosMP3.Clear();
            RutasArchivosMP3.Clear();
            lstCanciones.Items.Clear();
            foreach (ModeloCancion cancion in canciones)
            {
                lstCanciones.Items.Add(cancion.Nombre);
                ArchivosMP3.Add(cancion.Nombre);
                RutasArchivosMP3.Add(cancion.Ruta);
            }
            btnSubirCancion.Enabled = false;
            btnEliminarCancion.Enabled = false;
        }
        public void RecibirPlayListReproducir(ModeloPlayList playList)
        {
            lblListaCanciones.Text = playList.Nombre;
            ActualizarCancionesReproducir(playList.Canciones);
        }

        private void IUReproductor_Activated(object sender, EventArgs e)
        {
            if (IUListas.QuiereReproducir())
            {
                RecibirPlayListReproducir(IUListas.ObtenerListaReproducir());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnSubirCancion.Enabled = true;
            ActualizarCancionesBD();
        }

        private void btnEliminarCancion_Click(object sender, EventArgs e)
        {
            GestorReproduccion Grep = new GestorReproduccion();
            Grep.EliminarCancion(IdArchivosMP3[lstCanciones.SelectedIndex]);
            ActualizarCancionesBD();
        }
    }
}
