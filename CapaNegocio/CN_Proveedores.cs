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
    public class CN_Proveedores
    {
        //creamos un objeto de producto
        private CD_Proveedores objetoCD = new CD_Proveedores();

        //metodo para pasar los datos a la tabla
        public DataTable MostrarProv()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.MostrarProveedor();
            return tabla;
        }

        //metodo para insertar
        public void InsertarProv(string prov_nombre, string prov_detalle)
        {
            objetoCD.InsertarProveedor(prov_nombre, prov_detalle);
        }

        //metodo para editar
        public void EditarProv(string prov_nombre, string prov_detalle, string prov_id)
        {
            objetoCD.EditarProveedor(prov_nombre, prov_detalle, Convert.ToInt32(prov_id));
        }

        ////metodo para eliminar
        public void EliminarUsu(string prov_id)
        {
            objetoCD.EliminarProveedor(Convert.ToInt32(prov_id));
        }
    }
}
