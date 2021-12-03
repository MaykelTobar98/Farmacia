using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_Login
    {
        //intanciar la clase conexion
        private CD_Conexion conexion = new CD_Conexion();

        //propiedades del sql
        //SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public int ConsultarUsuario(string usu_nombre)
        {
            //Procedimiento almacenado

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "ConsultarUsuario";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@usu_nombre", usu_nombre);
            int asd = Convert.ToInt32(comando.ExecuteScalar());
            comando.Parameters.Clear();
            return asd;
        }
        public int ConsultarPassword(string usu_password)
        {
            //Procedimiento almacenado

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "ConsultarPass";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@usu_pass", usu_password);
            int asd = Convert.ToInt32(comando.ExecuteScalar());
            comando.Parameters.Clear();
            return asd;
        }


    }
}
