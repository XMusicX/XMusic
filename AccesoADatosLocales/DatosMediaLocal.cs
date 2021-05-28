using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoADatosBD;

namespace AccesoADatosLocales
{
    public class DatosMediaLocal
    {
        string[] archivosMP3;
        string[] rutasArchivosMP3;
        int idUsuario;

        public void ReconocerCanciones(int idUsuario, string[] nombresCanciones, string[] rutasCanciones) 
        {
            this.idUsuario = idUsuario;
            archivosMP3 = nombresCanciones;
            rutasArchivosMP3 = rutasCanciones;
            RegistrarCanciones();
        }
        private void RegistrarCanciones()
        {
            DatosUsuarios Dusu = new DatosUsuarios();
            for (int i = 0; i < archivosMP3.Count(); i++)
            {
                Dusu.GuardarCancion(idUsuario, archivosMP3[i], rutasArchivosMP3[i]);
            }
        }
    }
}
