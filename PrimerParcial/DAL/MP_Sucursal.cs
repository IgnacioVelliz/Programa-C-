using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class MP_Sucursal
    {

        Acceso acceso = new Acceso();

        public int AbmSucursal(int valor, BE.Sucursal sucursal)
        {
            int fa;

            SqlParameter[] parametros = new SqlParameter[5];

            parametros[0] = new SqlParameter("@Seleccionar", valor);
            parametros[1] = new SqlParameter("@IdSucursal", sucursal.IdSucursal);
            parametros[2] = new SqlParameter("@Direccion", sucursal.Direccion);
            parametros[3] = new SqlParameter("@Localidad", sucursal.Localidad);
            parametros[4] = new SqlParameter("@Zona", sucursal.Zona);

            fa = acceso.escribir("AbmSucursal", parametros);

            return fa;
        }

        public List<BE.Sucursal> Listar()
        {
            List<BE.Sucursal> LS = new List<BE.Sucursal>();

            DataTable tabla = acceso.leer("ListarSucursal", null);

            foreach (DataRow registro in tabla.Rows)
            {
                BE.Sucursal sucursal = new BE.Sucursal();

                sucursal.IdSucursal = registro["IdSucursal"].ToString();
                sucursal.Direccion = registro["Direccion"].ToString();
                sucursal.Localidad = registro["Localidad"].ToString();
                sucursal.Zona = registro["Zona"].ToString();

                LS.Add(sucursal);

            }

            return LS;

        }

    }
}
