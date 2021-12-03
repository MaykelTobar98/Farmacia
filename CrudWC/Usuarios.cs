using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace CrudWC
{
    public partial class Usuarios : Form
    {
        //intancio mi clase negocio
        CN_Usuarios objetoCN = new CN_Usuarios();
        //declaro variables
        private string usu_id = null;
        private bool editar = false;
        public Usuarios()
        {
            InitializeComponent();
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            MostrarUsuarios();
        }
        //metodo mostrar
        private void MostrarUsuarios()
        {
            CN_Usuarios objeto = new CN_Usuarios();
            dgv_usuarios.DataSource = objeto.MostrarUsu();
        }
        //metodo para limpiar cajas de texto
        private void limpiar()
        {
            txt_password.Clear();
            txt_usuario.Clear();
        }
        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (dgv_usuarios.SelectedRows.Count > 0)
            {
                usu_id = dgv_usuarios.CurrentRow.Cells["usu_id"].Value.ToString();
                objetoCN.EliminarUsu(usu_id);
                MessageBox.Show("Eliminado correctamente");
                MostrarUsuarios();
            }
            else
            {
                MessageBox.Show("seleccione una fila");
            }
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            if (dgv_usuarios.SelectedRows.Count > 0)
            {
                editar = true;
                txt_usuario.Text = dgv_usuarios.CurrentRow.Cells["usu_nombre"].Value.ToString();
                txt_password.Text = dgv_usuarios.CurrentRow.Cells["usu_password"].Value.ToString();
                usu_id = dgv_usuarios.CurrentRow.Cells["usu_id"].Value.ToString();
                //limpiar();

            }
            else
            {
                MessageBox.Show("Seleccione una fila");
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (editar == false)
            {
                try
                {
                    objetoCN.InsertarUsu(txt_usuario.Text, txt_password.Text);
                    MessageBox.Show("Se inserto correctamente");
                    MostrarUsuarios();
                    limpiar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("no se pudo insertar" + ex);
                }
            }

            if (editar == true)
            {
                try
                {
                    objetoCN.EditarUsu(txt_usuario.Text, txt_password.Text, usu_id);
                    MessageBox.Show("Se edito correctamente");
                    MostrarUsuarios();
                    editar = false;
                    limpiar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("no se pudo editar" + ex);
                }
            }
        }
    }
}
