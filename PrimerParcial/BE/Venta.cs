using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Venta
    {
        private string idVenta;

        public string IdVenta
        {
            get { return idVenta; }
            set { idVenta = value; }
        }

        private string idSucursal;

        public string IdSucursal
        {
            get { return idSucursal; }
            set { idSucursal = value; }
        }

        private string idProducto;

        public string IdProducto
        {
            get { return idProducto; }
            set { idProducto = value; }
        }

        private int cantidad;

        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }

        private int precioUni;

        public int PrecioUni
        {
            get { return precioUni; }
            set { precioUni = value; }
        }

        private int importe;

        public int Importe
        {
            get { return importe; }
            set { importe = value; }
        }

    }
}
