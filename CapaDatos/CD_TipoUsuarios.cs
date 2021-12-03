using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
   public class CD_TipoUsuarios
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
                comando.CommandText = "MostrarTipoUsuario";
                comando.CommandType = CommandType.StoredProcedure;
                leer = comando.ExecuteReader();
                tabla.Load(leer);
                conexion.CerrarConexion();
                return tabla;
            }

            //metodo para insertar
            public void Insertar(string tip_detalle)
            {
                //procedimiento almacenado
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "InsertarTipoUsuario";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@tip_detalle", tip_detalle);
                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
            }

            //metodo para editar
            public void Editar(string tip_detalle, int tip_id)
            {
                //procedimiento almacenado
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "ModificarTipoUsuario";
                comando.CommandType = CommandType.StoredProcedure;
               
                comando.Parameters.AddWithValue("@tip_detalle",tip_detalle);
                comando.Parameters.AddWithValue("@usu_id", tip_id);
                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
            }

            //metodo para editar
            public void Eliminar(int tip_id)
            {
                //procedimiento almacenado
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "EliminarTipoUsuario";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@tip_id", tip_id);
                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
            }
        
    }
}
