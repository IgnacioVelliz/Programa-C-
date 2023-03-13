using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimerParcial
{
    public partial class FmResumen : Form
    {
        public FmResumen()
        {
            InitializeComponent();
        }

        BLL.Venta gestorVenta = new BLL.Venta();
        BLL.Sucursal gestorSucursal = new BLL.Sucursal();

        BE.Sucursal sucursal = new BE.Sucursal();

        private void FmResumen_Load(object sender, EventArgs e)
        {
            enlazar();  
        }

        void enlazar()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = gestorVenta.Listar();

            lblCantVenGen.Text = "Cantidad de Ventas General: " + gestorVenta.ContarVentas();
            lblImporteGen.Text = "Importe General: $" + gestorVenta.SumarVenGen();
            lblPromedioGen.Text = "Promedio de Vetnas General: $" + gestorVenta.PromedioVentaGen();

            dataGridView3.DataSource = null;
            dataGridView3.DataSource = gestorSucursal.Listar();

            lblSucMax.Text = gestorVenta.SucursalMax();
            lblSucMin.Text = gestorVenta.SucursalMin();
        }

        private void btnVer_Click(object sender, EventArgs e)
        {

            sucursal.IdSucursal = textBox1.Text;

            dataGridView2.DataSource = null;
            dataGridView2.DataSource = gestorVenta.ListarPorSucursal(sucursal);

            lblCantVenSuc.Text = "Cantidad de Ventas por Sucursal: " + gestorVenta.ContVenPorSucursal(sucursal);

            lblImporteSuc.Text = "Importe General por Sucursal: $" + gestorVenta.SumarVenSuc(sucursal);

            lblPromedioSuc.Text = "Promedio de Ventas por Sucursal: $" + gestorVenta.PromedioVentaSuc(sucursal);

        }

        BE.Sucursal temp;
        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            temp = (BE.Sucursal)dataGridView3.Rows[e.RowIndex].DataBoundItem;
            textBox1.Text = temp.IdSucursal;
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            FmInicio FI = new FmInicio();
            FI.Show();
            this.Close();
        }
    }
}
