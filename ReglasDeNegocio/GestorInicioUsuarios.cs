using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoADatosBD;
using AccesoADatosLocales;
using System.Data;

namespace ReglasDeNegocio
{
    public class GestorInicioUsuarios
    {
        private DatosUsuarios DU = new DatosUsuarios();
        private GestorEncriptacionUsuarios EU = new GestorEncriptacionUsuarios();
        public int IdUsuario;
        public void RegistroUsuario(string nombre, string apellidos, string correo, string contraseña)
        {
            string contraseñaEncriptada = EU.Encriptar(contraseña);
            DU.RegistarUsuario(nombre, apellidos, correo, contraseñaEncriptada);
        }
        public bool BuscarCredencial(string correo, string contraseña)
        {
            string contraseñaEncriptada = EU.Encriptar(contraseña);
            DataTable resultado = DU.ConsultarCredenciales(correo,contraseñaEncriptada);
            if(resultado.Rows.Count != 0)
            {
                IdUsuario = (int)resultado.Rows[0][2];
            }
            return resultado.Rows.Count != 0;
        }
        public List<string> ConsultarPerfil(int idUsuario)
        {
            DataTable resultado = DU.ConsultarPerfil(idUsuario);
            List<string> datos = new List<string>();
            datos.Add(resultado.Rows[0][0].ToString());   
            datos.Add(resultado.Rows[0][1].ToString() == null || resultado.Rows[0][1].ToString() == "" ? "No especificado" : resultado.Rows[0][1].ToString());
            datos.Add(resultado.Rows[0][2].ToString());
            datos.Add(Convert.ToInt32(resultado.Rows[0][3]) == 0 ? "Perfil Oyente" : "Perfil Artista");
            datos.Add(resultado.Rows[0][4].ToString() == null || resultado.Rows[0][4].ToString() == "" ? "No especificado" : resultado.Rows[0][4].ToString());
            return datos;
        }
    }
}
