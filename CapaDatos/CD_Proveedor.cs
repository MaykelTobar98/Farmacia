using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_Proveedor
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
                comando.CommandText = "MostrarProveedor";
                comando.CommandType = CommandType.StoredProcedure;
                leer = comando.ExecuteReader();
                tabla.Load(leer);
                conexion.CerrarConexion();
                return tabla;
            }

            //metodo para insertar
            public void Insertar(string pro_nombre, string pro_detalle)
            {
                //procedimiento almacenado
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "InsertarProveedor";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@pro_nombre", pro_nombre);
                comando.Parameters.AddWithValue("@pro_detalle", pro_detalle);
                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
            }

            //metodo para editar
            public void Editar(string pro_nombre, string pro_detalle, int pro_id)
            {
                //procedimiento almacenado
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "EditarProveedor";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@pro_nombre", pro_nombre);
                comando.Parameters.AddWithValue("@pro_detalle", pro_detalle);
                comando.Parameters.AddWithValue("@pro_id", pro_id);
                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
            }

            //metodo para editar
            public void Eliminar(int pro_id)
            {
                //procedimiento almacenado
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "EliminarProveedor";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@pro_id", pro_id);
                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
            }
        
    }
}
