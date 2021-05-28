using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoADatosBD;

namespace ReglasDeNegocio
{
    public class GestorRegistroArtista
    {
        public void RegistrarArtista(int idUsuario, string nombreArtista)
        {
            DatosUsuarios GUsuario = new DatosUsuarios();
            GUsuario.ActualizarPefil(idUsuario,nombreArtista);
        }
    }
}
