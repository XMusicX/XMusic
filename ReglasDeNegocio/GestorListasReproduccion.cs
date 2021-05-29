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
        public List<string> ConsultarNombresPlayLists(int idUsuario)
        {
            DataTable resultado = DUsuario.ConsultarPlayList(idUsuario);
            List<string> playList = new List<string>();
            foreach (DataRow row in resultado.Rows)
            {
                playList.Add(row[0].ToString());
            }
            return playList;
        }
        public List<int> ConsultarIdPlayLists(int idUsuario)
        {
            DataTable resultado = DUsuario.ConsultarPlayList(idUsuario);
            List<int> idplayList = new List<int>();
            foreach (DataRow row in resultado.Rows)
            {
                idplayList.Add(Convert.ToInt32(row[1]));
            }
            return idplayList;
        }
        public void AñadirCancionAPlayList(int idPlayList, int idCancion)
        {
            DUsuario.AñadirCancionAPlayList(idPlayList, idCancion);
        }
    }
}
