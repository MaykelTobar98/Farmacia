using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using CapaNegocio;

namespace CrudWC
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
         
        private void Txt_usu_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_pass_TextChanged(object sender, EventArgs e)
        {

        }
        int count = 0;

        private void btn_incio_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    string CMD = string.Format("Select * from Tbl_usuario where usu_nombre='{0}' and usu_pass='{1}'", Txt_usu.Text.Trim(), Txt_pass.Text.Trim());
            //    DataSet ds = CN_Login.Ejecutar(CMD);
            //    string usuario = ds.Tables[0].Rows[0]["usu_nombre"].ToString().Trim();
            //    string password = ds.Tables[0].Rows[0]["usu_pass"].ToString().Trim();

            //    if (usuario == Txt_usu.Text.Trim() && password == Txt_pass.Text.Trim())
            //    {
            //        MessageBox.Show("se ha iniciado");
            //        Productos pri = new Productos();
            //        pri.Show();
            //        this.Hide();
            //    }

            CN_Login Objeto1 = new CN_Login();

            int asd = Objeto1.ConsultarUsu(Txt_usu.Text);
            int asd2 = Objeto1.ConsultarPass(Txt_pass.Text);
            if (string.IsNullOrEmpty(Txt_usu.Text) || string.IsNullOrEmpty(Txt_pass.Text))
            {
                MessageBox.Show("Campos Vacios");
            }

            else if (asd > 0)
            {


                if (asd2 > 0)
                {
                    Inicio pri = new Inicio();
                    MessageBox.Show("Bienvenido");
                    pri.Show();
                    this.Hide();
                }
                else
                {

                    if (count < 2)
                    {
                        count = count + 1;
                        MessageBox.Show("Contraseña Incorrecta");
                    }
                    else
                    {
                        MessageBox.Show("Acceso no permitido");
                        this.Close();
                    }
                }

            }
            else if (asd <= 0)
            {
                MessageBox.Show("No existe los Datos");
            }


        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }

       
    
}
