using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimerParcial
{
    public partial class FmProducto : Form
    {
        public FmProducto()
        {
            InitializeComponent();
        }

        BE.Producto producto = new BE.Producto();
        BLL.Producto gestorProducto = new BLL.Producto();


        private void FmProducto_Load(object sender, EventArgs e)
        {
            enlazar();
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            abm(1);
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            abm(2);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            abm(3);
        }

        void abm(int valor)
        {
            try
            {
                if (txtId.Text == "" || txtDescripcion.Text == "" || txtStock.Text == "" || txtPrecioU.Text == "" || txtStock.Text == "0" || txtPrecioU.Text == "0")
                {
                    throw new Exception();
                }

                producto.IdProcuto = txtId.Text;
                producto.Descripcion = txtDescripcion.Text;
                producto.Stock = int.Parse(txtStock.Text);
                producto.PrecioUni = int.Parse(txtPrecioU.Text);

                gestorProducto.AbmProducto(valor, producto);

                enlazar();
            }
            catch (Exception)
            {
                MessageBox.Show("Revisar Datos");
            }
        }

        void enlazar()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = gestorProducto.Listar();
        }

        BE.Producto temp;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                temp = (BE.Producto)dataGridView1.Rows[e.RowIndex].DataBoundItem;

                txtId.Text = temp.IdProcuto;
                txtDescripcion.Text = temp.Descripcion;
                txtStock.Text = temp.Stock.ToString();
                txtPrecioU.Text = temp.PrecioUni.ToString();
            }
            catch (Exception)
            {

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FmInicio FI = new FmInicio();
            FI.Show();
            this.Close();
        }
    }
}
