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
    public class CN_TipoUsuarios
    {
        
        
            //creamos un objeto de producto
            private CD_TipoUsuarios objetoCD = new CD_TipoUsuarios();

            //metodo para pasar los datos a la tabla
            public DataTable MostrarTipoUsu()
            {
                DataTable tabla = new DataTable();
                tabla = objetoCD.Mostrar();
                return tabla;
            }

            //metodo para insertar
            public void InsertarTipoUsu(string tip_detalle)
            {
                objetoCD.Insertar(tip_detalle);
            }

            //metodo para editar
            public void EditarTipoUsu(string tip_detalle,  string tip_id)
            {
                objetoCD.Editar(tip_detalle, Convert.ToInt32(tip_id));
            }

            //metodo para editar
            public void EliminarTipoUsu(string tip_id)
            {
                objetoCD.Eliminar(Convert.ToInt32(tip_id));
            }
        
    }
}

