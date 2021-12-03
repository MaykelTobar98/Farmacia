using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_Productos
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
            comando.CommandText = "MostrarProductos";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        //metodo para insertar
        public void Insertar(string pro_nombre,int pro_cantidad)
        {
            //procedimiento almacenado
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "InsertarProducto";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@pro_nombre",pro_nombre);
            comando.Parameters.AddWithValue("@pro_cantidad", pro_cantidad);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        //metodo para editar
        public void Editar(string pro_nombre, int pro_cantidad, int pro_id)
        {
            //procedimiento almacenado
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "ModificarProductos";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@pro_nombre", pro_nombre);
            comando.Parameters.AddWithValue("@pro_cantidad", pro_cantidad);
            comando.Parameters.AddWithValue("@pro_id", pro_id);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        //metodo para editar
        public void Eliminar(int pro_id)
        {
            //procedimiento almacenado
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminarProducto";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@pro_id", pro_id);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }
    }
}
