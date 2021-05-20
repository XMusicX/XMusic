using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoADatosBD;
using System.Data;

namespace ReglasDeNegocio
{
    public class GestorInicioUsuarios
    {
        private DatosUsuarios DU = new DatosUsuarios();
        private GestorEncriptacionUsuarios EU = new GestorEncriptacionUsuarios();
        public void RegistroUsuario(string nombre, string apellidos, string correo, string contraseña)
        {
            string contraseñaEncriptada = EU.Encriptar(contraseña);
            DU.RegistarUsuario(nombre, apellidos, correo, contraseñaEncriptada);
        }
        public bool BuscarCredencial(string correo, string contraseña)
        {
            string contraseñaEncriptada = EU.Encriptar(contraseña);
            DataTable resultado = DU.ConsultarCredenciales(correo,contraseñaEncriptada);
            return resultado.Rows.Count != 0;
        }
        
    }
}
