using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Producto
    {
        DAL.MP_Producto maperProducto = new DAL.MP_Producto();

        public int AbmProducto(int valor, BE.Producto producto)
        {
            int fa;

            fa = maperProducto.AbmProducto(valor, producto);

            return fa;
        }

        public List<BE.Producto> Listar()
        {
            List<BE.Producto> LS = new List<BE.Producto>();

            LS = maperProducto.Listar();

            return LS;
        }

        public List<BE.Producto> ListarPVentas()
        {
            List<BE.Producto> LS = new List<BE.Producto>();

            LS = maperProducto.ListarPVentas();

            return LS;
        }

        public int RestarProducto(string id, int Cantidad)
        {
            int fa;

            fa = maperProducto.RestarProducto(id, Cantidad);

            return fa;
        }

    }
}
