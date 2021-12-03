using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
   public  class CD_Usuarios
    {
        
       
            //intanciar la clase conexion
            private CD_Conexion conexion = new CD_Conexion();

            //propiedades del sql
            SqlDataReader leer;
            DataTable tabla = new DataTable();
            SqlCommand comando = new SqlCommand();

            public DataTable Mostrar()
            {
                //procedimento almacenado
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "MostrarUsuario";
                comando.CommandType = CommandType.StoredProcedure;
                leer = comando.ExecuteReader();
                tabla.Load(leer);
                conexion.CerrarConexion();
                return tabla;
            }

            //metodo para insertar
            public void Insertar(string usu_nombre, string usu_pass)
            {
                //procedimiento almacenado
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "InsertarUsuario";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@usu_nombre", usu_nombre);
                comando.Parameters.AddWithValue("@usu_pass", usu_pass);
                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
            }

            //metodo para editar
            public void Editar(string usu_nombre, string usu_pass, int usu_id)
            {
                //procedimiento almacenado
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "ModificarUsuario";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@usu_nombre", usu_nombre);
                comando.Parameters.AddWithValue("@usu_pass", usu_pass);
                comando.Parameters.AddWithValue("@usu_id", usu_id);
                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
            }

            //metodo para editar
            public void Eliminar(int usu_id)
            {
                //procedimiento almacenado            
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "EliminarUsuario";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@usu_id", usu_id);
                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
            }
        
    }
}
