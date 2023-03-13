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
    public partial class FmSucursal : Form
    {
        public FmSucursal()
        {
            InitializeComponent();
        }

        BLL.Sucursal gestorSucursal = new BLL.Sucursal();
        BE.Sucursal sucursal = new BE.Sucursal();

        private void FmSucursal_Load(object sender, EventArgs e)
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
                if (txtId.Text == "" || txtDireccion.Text == "" || txtLocalidad.Text == "" || txtZona.Text == "")
                {
                    throw new Exception();
                }

                sucursal.IdSucursal = txtId.Text;
                sucursal.Direccion = txtDireccion.Text;
                sucursal.Localidad = txtLocalidad.Text;
                sucursal.Zona = txtZona.Text;

                gestorSucursal.AbmSucursal(valor, sucursal);

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
            dataGridView1.DataSource = gestorSucursal.Listar();
        }


        BE.Sucursal temp;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                temp = (BE.Sucursal)dataGridView1.Rows[e.RowIndex].DataBoundItem;

                txtId.Text = temp.IdSucursal;
                txtDireccion.Text = temp.Direccion;
                txtLocalidad.Text = temp.Localidad;
                txtZona.Text = temp.Zona;
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
