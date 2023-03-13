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
    public partial class FmInicio : Form
    {
        public FmInicio()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void btnProducto_Click(object sender, EventArgs e)
        {
            FmProducto FP = new FmProducto();
            FP.Show();
            this.Hide();
        }

        private void btnVenta_Click(object sender, EventArgs e)
        {
            FmVenta FV = new FmVenta();
            FV.Show();
            this.Hide();
        }

        private void btnSucursales_Click(object sender, EventArgs e)
        {
            FmSucursal FS = new FmSucursal();
            FS.Show();
            this.Hide();
        }

        private void btnResumen_Click(object sender, EventArgs e)
        {
            FmResumen FR = new FmResumen();
            FR.Show();
            this.Hide();
        }
    }
}
