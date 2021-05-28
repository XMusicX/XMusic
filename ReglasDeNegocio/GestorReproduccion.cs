using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoADatosBD;
using System.Data;

namespace ReglasDeNegocio
{
    public class GestorReproduccion
    {
        DatosUsuarios DUsusario = new DatosUsuarios();
        public List<string> ConsultarNombresCanciones(int idUsuario)
        {
            List<string> nombresCanciones = new List<string>();
            DataTable ResultadoCanciones = DUsusario.ConsultarCanciones(idUsuario);

            foreach (DataRow row in ResultadoCanciones.Rows)
            {
                nombresCanciones.Add(row[0].ToString());
            }
            return nombresCanciones;
        }
        public List<string> ConsultarRutasCanciones(int idUsuario)
        {
            List<string> rutasCanciones = new List<string>();
            DataTable ResultadoCanciones = DUsusario.ConsultarCanciones(idUsuario);

            foreach (DataRow row in ResultadoCanciones.Rows)
            {
                rutasCanciones.Add(row[1].ToString());
            }
            return rutasCanciones;
        }
    }
}
