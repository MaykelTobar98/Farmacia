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
   public  class CN_Proveedor
    {
        
        
            //creamos un objeto de producto
            private CD_Proveedor objetoCD = new CD_Proveedor();

            //metodo para pasar los datos a la tabla
            public DataTable MostrarPro()
            {
                DataTable tabla = new DataTable();
                tabla = objetoCD.Mostrar();
                return tabla;
            }

            //metodo para insertar
            public void InsertarProv(string prov_nombre,string prov_detalle)
            {
                objetoCD.Insertar(prov_nombre,prov_detalle);
            }

            //metodo para editar
            public void EditarProv(string prov_nombre, string prov_detalle, string prov_id)
            {
                objetoCD.Editar(prov_nombre,prov_detalle, Convert.ToInt32(prov_id));
            }

            //metodo para editar
            public void EliminarProv(string prov_id)
            {
                objetoCD.Eliminar(Convert.ToInt32(prov_id));
            }
        
    }

}

