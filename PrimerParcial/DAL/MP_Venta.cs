using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class MP_Venta
    {

        Acceso acceso = new Acceso();


        public int Agregar(BE.Venta venta)
        {
            int fa;

            SqlParameter[] parametros = new SqlParameter[6];

            parametros[0] = new SqlParameter("@IdVentas", venta.IdVenta);
            parametros[1] = new SqlParameter("@IdSucursal", venta.IdSucursal);
            parametros[2]= new SqlParameter("@IdProducto", venta.IdProducto);
            parametros[3] = new SqlParameter("@Cantidad", venta.Cantidad);
            parametros[4] = new SqlParameter("@PrecioUni", venta.PrecioUni);
            parametros[5] = new SqlParameter("@Importe", venta.Importe);

            fa = acceso.escribir("AgregarVenta", parametros);

            return fa;
        }

        public int CargarImporte(string id)
        {
            int I = 0;

            SqlParameter[] parametros = new SqlParameter[1];

            parametros[0] = new SqlParameter("@IdVenta", id);

            DataTable tabla = acceso.leer("CargarImporte", parametros);

            foreach (DataRow registro in tabla.Rows)
            {
                BE.Venta venta = new BE.Venta();

                I = int.Parse(registro["Importe"].ToString());

            }

            return I;
        }


        public List<BE.Venta> Listar()
        {
            List<BE.Venta> LS = new List<BE.Venta>();

            DataTable tabla = acceso.leer("ListarVenta", null);

            foreach(DataRow registro in tabla.Rows)
            {
                BE.Venta venta = new BE.Venta();

                venta.IdVenta = registro["IdVenta"].ToString();
                venta.IdSucursal = registro["IdSucursal"].ToString();
                venta.IdProducto = registro["IdProducto"].ToString();
                venta.PrecioUni = int.Parse(registro["Cantidad"].ToString());
                venta.Cantidad = int.Parse(registro["PrecioUni"].ToString());
                venta.Importe = int.Parse(registro["Importe"].ToString());

                LS.Add(venta);
            }


            return LS;
        }

        public string ContarVentas()
        {
            string C;

            DataTable tabla = acceso.leer("ContarVentas", null);

            C = tabla.Rows[0][0].ToString();

            return C;
        }

        public List<BE.Venta> ListarPorSucursal(BE.Sucursal sucursal)
        {
            List<BE.Venta> LS = new List<BE.Venta>();

            SqlParameter[] parametros = new SqlParameter[1];

            parametros[0] = new SqlParameter("@Sucursal", sucursal.IdSucursal);

            DataTable tabla = acceso.leer("VentaPorSucursal", parametros);

            foreach (DataRow registro in tabla.Rows)
            {
                BE.Venta venta = new BE.Venta();

                venta.IdVenta = registro["IdVenta"].ToString();
                venta.IdSucursal = registro["IdSucursal"].ToString();
                venta.IdProducto = registro["IdProducto"].ToString();
                venta.PrecioUni = int.Parse(registro["Cantidad"].ToString());
                venta.Cantidad = int.Parse(registro["PrecioUni"].ToString());
                venta.Importe = int.Parse(registro["Importe"].ToString());

                LS.Add(venta);
            }

            return LS;
        }

        public string ContVenPorSucursal(BE.Sucursal sucursal)
        {
            string C;

            SqlParameter[] parametros = new SqlParameter[1];

            parametros[0] = new SqlParameter("@Sucursal", sucursal.IdSucursal);

            DataTable tabla = acceso.leer("ContVenPorSucursal", parametros);

            C = tabla.Rows[0][0].ToString();

            return C;
        }

        public string SumarVenGen()
        {
            string R;

            DataTable tabla = acceso.leer("SumarVenGen", null);

            R = tabla.Rows[0][0].ToString();

            return R;
        }

        public string SumarVenSuc(BE.Sucursal sucursal)
        {
            string R;

            SqlParameter[] parametros = new SqlParameter[1];

            parametros[0] = new SqlParameter("@Sucursal", sucursal.IdSucursal);

            DataTable tabla = acceso.leer("SumarVenSuc", parametros);

            R = tabla.Rows[0][0].ToString();

            return R;
        }

        public string PromedioVentaGen()
        {
            string P;

            DataTable tabla = acceso.leer("PromedioVentaGen", null);

            P = tabla.Rows[0][0].ToString();

            return P;
        }

        public string PromedioVentaSuc(BE.Sucursal sucursal)
        {
            string P;

            SqlParameter[] parametros = new SqlParameter[1];

            parametros[0] = new SqlParameter("@Sucursal", sucursal.IdSucursal);

            DataTable tabla = acceso.leer("PromedioVentaSuc", parametros);

            P = tabla.Rows[0][0].ToString();

            return P;
        }

        public string SucursalMax()
        {
            string M;

            DataTable tabla = acceso.leer("SucursalMax", null);
            try
            {
                M = tabla.Rows[0][0].ToString();
            }
            catch
            {
                M = "";
            }
            

            return M;
        }

        public string SucursalMin()
        {
            string M;

            DataTable tabla = acceso.leer("SucursalMin", null);

            try
            {
                M = tabla.Rows[0][0].ToString();
            }
            catch
            {
                M = "";
            }

            return M;
        }

    }
}
