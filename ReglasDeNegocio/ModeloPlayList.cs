using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReglasDeNegocio
{
    public class ModeloPlayList
    {
        public int IdPlayList { get; set; }
        public int IdUsuario { get; set; }
        public string Nombre { get; set; }
        public List<ModeloCancion> Canciones { get; set; }
    }
}
