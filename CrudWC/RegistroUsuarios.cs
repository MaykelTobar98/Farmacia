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
    public partial class RegistroUsuarios : Form
    {
        //intancio mi clase negocio
        CN_Usuarios objetoCN = new CN_Usuarios();
        //declaro variables
        private string usu_id = null;
        private bool editar = false;
        public RegistroUsuarios()
        {
            InitializeComponent();
        }

        private void RegistroUsuarios_Load(object sender, EventArgs e)
        {
            MostrarUsuarios();


        }

        private void MostrarUsuarios()
        {
            CN_Usuarios objeto = new CN_Usuarios();
            dataGridView1.DataSource = objeto.MostrarUsu();
        }
        private void limpiar()
        {
            Txt_nombre.Clear();
            Txt_cantidad.Clear();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (Txt_cantidad.Text == "" || Txt_nombre.Text == "")
            {
                MessageBox.Show("Campos Vacios");
            }
            else
            {

                if (editar == false)
                {
                    try
                    {
                        objetoCN.InsertarUsu(Txt_nombre.Text, Txt_cantidad.Text);
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
                        objetoCN.EditarUsu(Txt_nombre.Text, Txt_cantidad.Text, usu_id);
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

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                usu_id = dataGridView1.CurrentRow.Cells["usu_id"].Value.ToString();
                objetoCN.Eliminar(usu_id);
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
            if (dataGridView1.SelectedRows.Count > 0)
            {
                editar = true;
                Txt_nombre.Text = dataGridView1.CurrentRow.Cells["usu_nombre"].Value.ToString();
                Txt_cantidad.Text = dataGridView1.CurrentRow.Cells["usu_pass"].Value.ToString();
                usu_id = dataGridView1.CurrentRow.Cells["usu_id"].Value.ToString();
                //limpiar();

            }
            else
            {
                MessageBox.Show("Seleccione una fila");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Txt_nombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_cantidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Inicio n = new Inicio();
            n.Show();
            this.Hide();
        }
    }

      
    
}
