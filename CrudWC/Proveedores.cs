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
    public partial class Proveedores : Form
    {
        //intancio mi clase negocio
        CN_Proveedor objetoCN = new CN_Proveedor();
        //declaro variables
        private string pro_id = null;
        private bool editar = false;
        public Proveedores()
        {
            InitializeComponent();
        }

        private void Proveedores_Load(object sender, EventArgs e)
        {

        }
        private void MostrarProductos()
        {
            CN_Proveedor objeto = new CN_Proveedor();
            dataGridView1.DataSource = objeto.MostrarPro();
        }
        private void limpiar()
        {
            Txt_nombre.Clear();
            Txt_cantidad.Clear();
        }
        private void btn_guardar_Click(object sender, EventArgs e)
        {

        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                pro_id = dataGridView1.CurrentRow.Cells["pro_id"].Value.ToString();
                objetoCN.EliminarProv(pro_id);
                MessageBox.Show("Eliminado correctamente");
                MostrarProductos();
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
                Txt_nombre.Text = dataGridView1.CurrentRow.Cells["pro_nombre"].Value.ToString();
                Txt_cantidad.Text = dataGridView1.CurrentRow.Cells["pro_detalle"].Value.ToString();
                pro_id = dataGridView1.CurrentRow.Cells["pro_id"].Value.ToString();
                limpiar();

            }
            else
            {
                MessageBox.Show("Seleccione una fila");
            }
        }

        private void btn_guardar_Click_1(object sender, EventArgs e)
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
                        objetoCN.InsertarProv(Txt_nombre.Text, Txt_cantidad.Text);
                        MessageBox.Show("Se inserto correctamente");
                        MostrarProductos();
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
                        objetoCN.EditarProv(Txt_nombre.Text, Txt_cantidad.Text, pro_id);
                        MessageBox.Show("Se edito correctamente");
                        MostrarProductos();
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

        private void button1_Click(object sender, EventArgs e)
        {
            Inicio n = new Inicio();
            n.Show();
            this.Hide();
        }
    }
}
