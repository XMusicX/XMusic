using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace AccesoADatosBD
{
    public class DatosUsuarios
    {
        SqlConnection ObjCn = new SqlConnection(@"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=XMusic;Data Source=LAPTOP-DEJRMO8U\SQLEXPRESS");
        public void RegistarUsuario(string nombre,string apellidos,string correo,string contraseña)
        {
            SqlCommand ObjCmd = new SqlCommand("uspRegistroUsuario", ObjCn);
            ObjCmd.CommandType = CommandType.StoredProcedure;
            ObjCmd.Parameters.AddWithValue("@Nombre", nombre);
            ObjCmd.Parameters.AddWithValue("@Apellidos", apellidos);
            ObjCmd.Parameters.AddWithValue("@Correo", correo);
            ObjCmd.Parameters.AddWithValue("@Contraseña", contraseña);
            ObjCn.Open();
            ObjCmd.ExecuteNonQuery();
            ObjCn.Close();
        }
        public DataTable ConsultarCredenciales(string correo, string contraseña)
        {
            SqlCommand ObjCmd = new SqlCommand("uspConsultarCredenciales", ObjCn);
            ObjCmd.CommandType = CommandType.StoredProcedure;
            ObjCmd.Parameters.AddWithValue("@Correo", correo);
            ObjCmd.Parameters.AddWithValue("@Contraseña", contraseña);
            ObjCn.Open();
            SqlDataReader Dr = ObjCmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(Dr);
            ObjCn.Close();
            return dt;
        }
    }
}
