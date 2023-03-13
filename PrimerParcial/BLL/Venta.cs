using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Venta
    {

        DAL.MP_Venta maperVenta = new DAL.MP_Venta();
        Producto gestorProducto = new Producto();

        public string Agregar(BE.Venta venta, int stock)
        {
            string fa;
            if(stock >= venta.Cantidad)
            {
                venta.Importe = venta.Cantidad * venta.PrecioUni;

                if (1 == maperVenta.Agregar(venta))
                {
                    gestorProducto.RestarProducto(venta.IdProducto, venta.Cantidad);

                    fa = "Importe: $ " + maperVenta.CargarImporte(venta.IdVenta).ToString();
                }
                else
                {
                    fa = "Este Id ya esta registrado";
                }
            }
            else
            {
                fa = "Revise la cantidad de stock disponible";
            }
                
            return fa;
        }


        public List<BE.Venta> Listar()
        {
            List<BE.Venta> LS = new List<BE.Venta>();

            LS = maperVenta.Listar();

            return LS;
        }

        public string ContarVentas()
        {
            string C;

            C = maperVenta.ContarVentas();

            return C;
        }

        public List<BE.Venta> ListarPorSucursal(BE.Sucursal sucursal)
        {
            List<BE.Venta> LS = new List<BE.Venta>();

            LS = maperVenta.ListarPorSucursal(sucursal);

            return LS;

        }


        public string ContVenPorSucursal(BE.Sucursal sucursal)
        {
            string C;

            C = maperVenta.ContVenPorSucursal(sucursal);

            return C;
        }

        public string SumarVenGen()
        {
            string R;

            R = maperVenta.SumarVenGen();

            return R;
        }

        public string SumarVenSuc(BE.Sucursal sucursal)
        {
            string R;

            R = maperVenta.SumarVenSuc(sucursal);

            return R;
        }

        public string PromedioVentaGen()
        {
            string P;

            P = maperVenta.PromedioVentaGen();

            return P;
        }

        public string PromedioVentaSuc(BE.Sucursal sucursal)
        {
            string P;

            P = maperVenta.PromedioVentaSuc(sucursal);

            return P;
        }

        public string SucursalMax()
        {
            string M;

            M = "Sucursal que mas vendio: " + maperVenta.SucursalMax();

            return M;
        }

        public string SucursalMin()
        {
            string M;

            M = "Sucursal que menos vendio: " + maperVenta.SucursalMax();

            return M;
        }


    }
}
