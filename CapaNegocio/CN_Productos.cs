using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaDatos;

namespace CapaNegocio
{
    public class CN_Productos
    {
        //creamos un objeto de producto
        private CD_Productos objetoCD = new CD_Productos();

        //metodo para pasar los datos a la tabla
        public DataTable MostrarProd()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.Mostrar();
            return tabla;
        }

        //metodo para insertar
        public void InsertarPro(string pro_nombre,string pro_cantidad)
        {
            objetoCD.Insertar(pro_nombre, Convert.ToInt32(pro_cantidad));
        }

        //metodo para editar
        public void EditarPro(string pro_nombre, string pro_cantidad,string pro_id)
        {
            objetoCD.Editar(pro_nombre, Convert.ToInt32(pro_cantidad),Convert.ToInt32(pro_id));
        }

        //metodo para editar
        public void EliminarPro(string pro_id)
        {
            objetoCD.Eliminar(Convert.ToInt32(pro_id));
        }
    }
}
