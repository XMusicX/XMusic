using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using AccesoADatosLocales;

namespace ReglasDeNegocio
{
    public class GestorSubirCanciones
    {
        DatosMediaLocal DMedia = new DatosMediaLocal();
        
        public void RegistrarCanciones(int idUsuario, string[] nombres, string[] rutas)
        {
            DMedia.ReconocerCanciones(idUsuario, nombres, rutas);
        }
    }
}
