using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace AccesoADatosBD
{
    public class DatosUsuarios
    {
        SqlConnection ObjCn = new SqlConnection(ConfigurationManager.AppSettings["CADENA_CONEXION"]);
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

        public void RecuperarContraseña(string correo, string contraseña, string token)
        {
            SqlCommand objCmd = new SqlCommand("uspEditarContraseña", ObjCn);
            objCmd.Parameters.AddWithValue("@Correo", correo);
            objCmd.Parameters.AddWithValue("@Contraseña", contraseña);
            objCmd.Parameters.AddWithValue("@token", token);
            ObjCn.Open();
            SqlDataReader Dr = objCmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(Dr);
            ObjCn.Close();
        }

        public void GuardarToken(string correo, string token)
        {
            SqlCommand objCmd = new SqlCommand("uspGenerarToken", ObjCn);
            objCmd.Parameters.AddWithValue("@Correo", correo);
            objCmd.Parameters.AddWithValue("@token", token);
            ObjCn.Open();
            SqlDataReader Dr = objCmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(Dr);
            ObjCn.Close();
        }

        public void GuardarCancion(int idUsuario, string nombre,string ubicacion)
        {
            SqlCommand objCmd = new SqlCommand("uspRegistroCancion", ObjCn);
            objCmd.CommandType = CommandType.StoredProcedure;
            objCmd.Parameters.AddWithValue("@IdUsuario", idUsuario);
            objCmd.Parameters.AddWithValue("@Nombre", nombre);
            objCmd.Parameters.AddWithValue("@Ubicacion", ubicacion);
            ObjCn.Open();
            objCmd.ExecuteNonQuery();
            ObjCn.Close();
        }
        public DataTable ConsultarCanciones(int idUsuario)
        {
            SqlCommand ObjCmd = new SqlCommand("uspConsultarCanciones", ObjCn);
            ObjCmd.CommandType = CommandType.StoredProcedure;
            ObjCmd.Parameters.AddWithValue("@IdUsuario", idUsuario);
            ObjCn.Open();
            SqlDataReader Dr = ObjCmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(Dr);
            ObjCn.Close();
            return dt;
        }
        public DataTable ConsultarPerfil(int idUsuario)
        {
            SqlCommand ObjCmd = new SqlCommand("uspConsultarPerfil", ObjCn);
            ObjCmd.CommandType = CommandType.StoredProcedure;
            ObjCmd.Parameters.AddWithValue("@IdUsuario", idUsuario);
            ObjCn.Open();
            SqlDataReader Dr = ObjCmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(Dr);
            ObjCn.Close();
            return dt;
        }
        public void ActualizarPefil(int idUsuario, string nombreArtistico)
        {
            SqlCommand objCmd = new SqlCommand("uspActualizarCuenta", ObjCn);
            objCmd.CommandType = CommandType.StoredProcedure;
            objCmd.Parameters.AddWithValue("@IdUsuario", idUsuario);
            objCmd.Parameters.AddWithValue("@NombreArtistico", nombreArtistico);
            ObjCn.Open();
            objCmd.ExecuteNonQuery();
            ObjCn.Close();
        }
        public void CrearPlayList(int idUsuario, string nombre)
        {
            SqlCommand objCmd = new SqlCommand("uspCrearPlayList", ObjCn);
            objCmd.CommandType = CommandType.StoredProcedure;
            objCmd.Parameters.AddWithValue("@IdUsuario", idUsuario);
            objCmd.Parameters.AddWithValue("@Nombre", nombre);
            ObjCn.Open();
            objCmd.ExecuteNonQuery();
            ObjCn.Close();
        }
        public DataTable ConsultarPlayList(int idUsuario)
        {
            SqlCommand ObjCmd = new SqlCommand("uspConsultarPlayLists", ObjCn);
            ObjCmd.CommandType = CommandType.StoredProcedure;
            ObjCmd.Parameters.AddWithValue("@IdUsuario", idUsuario);
            ObjCn.Open();
            SqlDataReader Dr = ObjCmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(Dr);
            ObjCn.Close();
            return dt;
        }
        public void AñadirCancionAPlayList(int idPlayList, int idCancion)
        {
            SqlCommand objCmd = new SqlCommand("uspAñadirCancionAPlayList", ObjCn);
            objCmd.CommandType = CommandType.StoredProcedure;
            objCmd.Parameters.AddWithValue("@IdPlayList", idPlayList);
            objCmd.Parameters.AddWithValue("@IdCancion", idCancion);
            ObjCn.Open();
            objCmd.ExecuteNonQuery();
            ObjCn.Close();
        }
        public DataTable ConsultarCancionesPlayList(int idPlayList)
        {
            SqlCommand ObjCmd = new SqlCommand("uspConsultarCancionesDePlayList", ObjCn);
            ObjCmd.CommandType = CommandType.StoredProcedure;
            ObjCmd.Parameters.AddWithValue("@IdPlayList", idPlayList);
            ObjCn.Open();
            SqlDataReader Dr = ObjCmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(Dr);
            ObjCn.Close();
            return dt;
        }
        public void EliminarPlayList(int idPlayList)
        {
            SqlCommand objCmd = new SqlCommand("uspEliminarPlayList", ObjCn);
            objCmd.CommandType = CommandType.StoredProcedure;
            objCmd.Parameters.AddWithValue("@IdPlayList", idPlayList);
            ObjCn.Open();
            objCmd.ExecuteNonQuery();
            ObjCn.Close();
        }
        public void EliminarCancionesDePlayList(int idPlayList, int idCancion)
        {
            SqlCommand objCmd = new SqlCommand("uspEliminarCancionDePlayList", ObjCn);
            objCmd.CommandType = CommandType.StoredProcedure;
            objCmd.Parameters.AddWithValue("@IdPlayList", idPlayList);
            objCmd.Parameters.AddWithValue("@IdCancion", idCancion);
            ObjCn.Open();
            objCmd.ExecuteNonQuery();
            ObjCn.Close();
        }
        public void EliminarCancion(int idCancion)
        {
            SqlCommand objCmd = new SqlCommand("uspEliminarCancion", ObjCn);
            objCmd.CommandType = CommandType.StoredProcedure;
            objCmd.Parameters.AddWithValue("@IdCancion", idCancion);
            ObjCn.Open();
            objCmd.ExecuteNonQuery();
            ObjCn.Close();
        }
    }
}
