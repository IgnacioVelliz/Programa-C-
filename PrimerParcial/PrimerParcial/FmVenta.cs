using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace PrimerParcial
{
    public partial class FmVenta : Form
    {
        public FmVenta()
        {
            InitializeComponent();
        }

        BLL.Producto gestorProducto = new BLL.Producto();
        BLL.Sucursal gestorSucursal = new BLL.Sucursal();
        BLL.Venta gestorVenta = new BLL.Venta();

        BE.Venta venta = new BE.Venta();
        BE.Producto producto = new BE.Producto();

        private void FmVenta_Load(object sender, EventArgs e)
        {
            enlazar();
        }

    


        private void btnComprar_Click(object sender, EventArgs e)
        {
            agregar();

            enlazar();
        }


        void agregar()
        {
            try
            {

                if (txtIdVenta.Text =="" || txtIdPro.Text == "" || txtIdSuc.Text == "" || txtPrecioUni.Text == "" || txtPrecioUni.Text == "0" || txtCantidad.Text == "" || txtCantidad.Text == "0")
                {
                    throw new Exception();
                }

                venta.IdVenta = txtIdVenta.Text;
                venta.IdProducto = txtIdPro.Text;
                venta.IdSucursal = txtIdSuc.Text;
                venta.PrecioUni = int.Parse(txtPrecioUni.Text);
                venta.Cantidad = int.Parse(txtCantidad.Text);
                producto.Stock = int.Parse(txtStock.Text);

                lblImporte.Text = gestorVenta.Agregar(venta, producto.Stock);

            }
            catch (Exception)
            {

                MessageBox.Show("Revisar Datos");

            }
        }

        void enlazar()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = gestorProducto.ListarPVentas();

            dataGridView2.DataSource = null;
            dataGridView2.DataSource = gestorSucursal.Listar();
        }


        BE.Producto tempPro;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                tempPro = (BE.Producto)dataGridView1.Rows[e.RowIndex].DataBoundItem;

                txtIdPro.Text = tempPro.IdProcuto;
                txtPrecioUni.Text = tempPro.PrecioUni.ToString();
                txtStock.Text = tempPro.Stock.ToString();

            }
            catch (Exception)
            {

            }
            
        }


        BE.Sucursal tempSuc;
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                tempSuc = (BE.Sucursal)dataGridView2.Rows[e.RowIndex].DataBoundItem;

                txtIdSuc.Text = tempSuc.IdSucursal;
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
