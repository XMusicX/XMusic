using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReglasDeNegocio
{
    public class ModeloCancion
    {
        public int IdCancion { get; set; }

        public int IdUsuario { get; set; }
        public string Nombre { get; set; }
        public string Ruta { get; set; }

    }
}
