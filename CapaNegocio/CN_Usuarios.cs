using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class CN_Usuarios
    {
        
        
            //creamos un objeto de producto
            private CD_Usuarios objetoCD = new CD_Usuarios();

            //metodo para pasar los datos a la tabla
            public DataTable MostrarUsu()
            {
                DataTable tabla = new DataTable();
                tabla = objetoCD.Mostrar();
                return tabla;
            }

            //metodo para insertar
            public void InsertarUsu(string usu_nombre, string usu_pass)
            {
                objetoCD.Insertar(usu_nombre,usu_pass);
            }

            //metodo para editar
            public void EditarUsu(string usu_nombre, string usu_pass, string usu_id)
            {
                objetoCD.Editar(usu_nombre, usu_pass, Convert.ToInt32(usu_id));
            }

            //metodo para editar
            public void Eliminar(string usu_id)
            {
                objetoCD.Eliminar(Convert.ToInt32(usu_id));
            }
        
    }
}
