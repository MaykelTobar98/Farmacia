using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_Proveedores
    {
        //intanciar la clase conexion
        private CD_Conexion conexion = new CD_Conexion();

        //propiedades del sql
        
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable MostrarProveedor()
        {
            //procedimento almacenado
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostarProveedores";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        //metodo para insertar
        public void InsertarProveedor(string prov_nombre, string prov_detalle)
        {
            //procedimiento almacenado
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "InsertarProveedores";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@prov_nombre", prov_nombre);
            comando.Parameters.AddWithValue("@prov_detalle", prov_detalle);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        //metodo para editar
        public void EditarProveedor(string prov_nombre, string prov_detalle, int prov_id)
        {
            //procedimiento almacenado
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "ModificarProveedores";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@prov_nombre", prov_nombre);
            comando.Parameters.AddWithValue("@prov_detalle", prov_detalle);
            comando.Parameters.AddWithValue("@prov_id", prov_id);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        //metodo para editar
        public void EliminarProveedor(int prov_id)
        {
            //procedimiento almacenado
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminarProveedores";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@prov_id", prov_id);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }
    }
}
