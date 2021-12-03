using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class CN_Login
    {
        //public static DataSet Ejecutar(string cmd)
        //{
        //    //SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-V7DANHEC\SQLEXPRESS;Initial Catalog=Farmacia;Integrated Security=True");
        //    //con.Open();
        //    //DataSet ds = new DataSet();
        //    //SqlDataAdapter dp = new SqlDataAdapter(cmd, con);
        //    //dp.Fill(ds);
        //    //con.Close();
        //    //return ds;




        //}

        private CD_Login objetoCD = new CD_Login();

        public int ConsultarUsu(string usu_nombre)
        {

            int asd1 = Convert.ToInt32(objetoCD.ConsultarUsuario(usu_nombre));

            return asd1;
        }
        public int ConsultarPass(string usu_password)
        {



            int asd2 = Convert.ToInt32(objetoCD.ConsultarPassword(usu_password));

            return asd2;
        }
    }
}
