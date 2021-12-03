using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    class CD_Conexion
    {
        //creamos la cade de conexion
        private SqlConnection Conexion = new SqlConnection(@"Data Source=DESKTOP-ERF58BK\SQLEXPRESS;Initial Catalog=Farmacia;Integrated Security=True");
        
        //metodo para abrir y cerrar la conexion
        public SqlConnection AbrirConexion()
        {
            if(Conexion.State == ConnectionState.Closed)
                Conexion.Open();
            
            return Conexion;
        }

        public SqlConnection CerrarConexion()
        {
            if (Conexion.State == ConnectionState.Open)
                Conexion.Close();

            return Conexion;
        }
    }
}
