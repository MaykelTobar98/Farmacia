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
    public partial class Form1 : Form
    {
        //intancio mi clase negocio
        CN_Productos objetoCN = new CN_Productos();
        //declaro variables
        private string pro_id = null;
        private bool editar = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MostrarProductos();
            MostrarProductosCombo();
            comboBox1.Text = "seleccione";
        }

        //metodo mostrar
        private void MostrarProductos()
        {
            CN_Productos objeto = new CN_Productos();
            dataGridView1.DataSource = objeto.MostrarProd();
        }

        private void MostrarProductosCombo()
        {
            CN_Productos objeto = new CN_Productos();
            comboBox1.DataSource = objeto.MostrarProd();
            comboBox1.DisplayMember = "pro_nombre";
            comboBox1.ValueMember = "pro_id";
        }

        //metodo para limpiar cajas de texto
        private void limpiar()
        {
            Txt_nombre.Clear();
            Txt_cantidad.Clear();
        }
        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (editar == false)
            {
                try
                {
                    objetoCN.InsertarPro(Txt_nombre.Text, Txt_cantidad.Text);
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
                    objetoCN.EditarPro(Txt_nombre.Text, Txt_cantidad.Text, pro_id);
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

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                pro_id = dataGridView1.CurrentRow.Cells["pro_id"].Value.ToString();
                objetoCN.EliminarPro(pro_id);
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
                Txt_cantidad.Text = dataGridView1.CurrentRow.Cells["pro_cantidad"].Value.ToString();
                pro_id = dataGridView1.CurrentRow.Cells["pro_id"].Value.ToString();
                limpiar();

            }
            else
            {
                MessageBox.Show("Seleccione una fila");
            }
        }
    }
}
    