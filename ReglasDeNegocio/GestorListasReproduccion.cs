using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoADatosBD;
using System.Data;

namespace ReglasDeNegocio
{
    public class GestorListasReproduccion
    {
        DatosUsuarios DUsuario = new DatosUsuarios();
        public void CrearPlayList(int idUsuario, string nombre)
        {
            DUsuario.CrearPlayList(idUsuario, nombre);
        }
        
        public List<ModeloPlayList> ConsultarPlayLists(int idUsuario)
        {
            DataTable resultado = DUsuario.ConsultarPlayList(idUsuario);
            List<ModeloPlayList> playLists = new List<ModeloPlayList>();
            foreach (DataRow row in resultado.Rows)
            {
                ModeloPlayList playList = new ModeloPlayList();
                playList.IdPlayList = Convert.ToInt32(row[1]);
                playList.IdUsuario = idUsuario;
                playList.Nombre = row[0].ToString();
                playList.Canciones = ConsultarCancionesDePlayList(playList.IdPlayList);

                playLists.Add(playList);
            }
            return playLists;
        }
        public List<ModeloCancion> ConsultarCancionesBD(int idUsuario)
        {
            DataTable resultado = DUsuario.ConsultarCanciones(idUsuario);
            List<ModeloCancion> cancionesBD = new List<ModeloCancion>();
            foreach (DataRow row in resultado.Rows)
            {
                ModeloCancion cancion = new ModeloCancion();
                cancion.IdCancion = Convert.ToInt32(row[2]);
                cancion.IdUsuario = idUsuario;
                cancion.Nombre = row[0].ToString();
                cancion.Ruta = row[1].ToString();

                cancionesBD.Add(cancion);
            }
            return cancionesBD;
        }
        public void AñadirCancionAPlayList(int idPlayList, int idCancion)
        {
            DUsuario.AñadirCancionAPlayList(idPlayList, idCancion);
        }
        public List<ModeloCancion> ConsultarCancionesDePlayList(int idPlayList)
        {
            DataTable resultado = DUsuario.ConsultarCancionesPlayList(idPlayList);
            List<ModeloCancion> Canciones = new List<ModeloCancion>();
            foreach(DataRow row in resultado.Rows)
            {
                ModeloCancion cancion = new ModeloCancion();
                cancion.IdCancion = Convert.ToInt32(row[0]);
                cancion.Nombre = row[1].ToString();
                cancion.Ruta = row[2].ToString();
                Canciones.Add(cancion);
            }
            return Canciones;
        }
        public void EliminarPlayList(int idPlayList)
        {
            DUsuario.EliminarPlayList(idPlayList);
        }
        public void EliminarCancionDePlayList(int idPlayList, int idCancion)
        {
            DUsuario.EliminarCancionesDePlayList(idPlayList, idCancion);
        }
    }
}
