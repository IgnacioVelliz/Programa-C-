using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class MP_Producto
    {

        Acceso acceso = new Acceso();

        public int AbmProducto(int valor, BE.Producto producto)
        {
            int fa;

            SqlParameter[] parametros = new SqlParameter[5];

            parametros[0] = new SqlParameter("@Seleccionar", valor);
            parametros[1] = new SqlParameter("@IdProducto", producto.IdProcuto);
            parametros[2] = new SqlParameter("@Descripcion", producto.Descripcion);
            parametros[3] = new SqlParameter("@Stock", producto.Stock);
            parametros[4] = new SqlParameter("@PrecioUni", producto.PrecioUni);

            fa = acceso.escribir("AbmProducto", parametros);

            return fa;
        }

        public List<BE.Producto> Listar()
        {
            List<BE.Producto> LS = new List<BE.Producto>();

            DataTable tabla = acceso.leer("ListarProducto", null);

            foreach(DataRow registro in tabla.Rows)
            {
                BE.Producto producto = new BE.Producto();

                producto.IdProcuto = registro["IdProducto"].ToString();
                producto.Descripcion = registro["Descripcion"].ToString();
                producto.Stock = int.Parse(registro["Stock"].ToString());
                producto.PrecioUni = int.Parse(registro["PrecioUni"].ToString());

                LS.Add(producto);

            }

            return LS;

        }

        public List<BE.Producto> ListarPVentas()
        {
            List<BE.Producto> LS = new List<BE.Producto>();

            DataTable tabla = acceso.leer("ListarPrVentas", null);

            foreach (DataRow registro in tabla.Rows)
            {
                BE.Producto producto = new BE.Producto();

                producto.IdProcuto = registro["IdProducto"].ToString();
                producto.Descripcion = registro["Descripcion"].ToString();
                producto.Stock = int.Parse(registro["Stock"].ToString());
                producto.PrecioUni = int.Parse(registro["PrecioUni"].ToString());

                LS.Add(producto);

            }

            return LS;

        }
            
        public int RestarProducto(string id, int Cantidad)
        {
            
            int R = 0;
            int fa = 0;

            SqlParameter[] parametros = new SqlParameter[3];

            parametros[0] = new SqlParameter("@Seleccionar", 1);
            parametros[1] = new SqlParameter("@IdProducto", id);
            parametros[2] = new SqlParameter("@Stock", R);

            DataTable tabla = acceso.leer("RestarStock", parametros);

            BE.Producto producto = new BE.Producto();

            foreach (DataRow registro in tabla.Rows)
            {

                producto.Stock = int.Parse(registro["Stock"].ToString());
            
            }

                R = producto.Stock - Cantidad;

                parametros[0] = new SqlParameter("@Seleccionar", 2);
                parametros[1] = new SqlParameter("@IdProducto", id);
                parametros[2] = new SqlParameter("@Stock", R);

                fa = acceso.escribir("RestarStock", parametros);
            

            return fa;

        }

    }
}
