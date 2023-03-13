using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Sucursal
    {
        DAL.MP_Sucursal maperSucursal = new DAL.MP_Sucursal();

        public int AbmSucursal(int valor, BE.Sucursal sucursal)
        {
            int fa;

            fa = maperSucursal.AbmSucursal(valor, sucursal);

            return fa;
        }

        public List<BE.Sucursal> Listar()
        {
            List<BE.Sucursal> LS = new List<BE.Sucursal>();

            LS = maperSucursal.Listar();

            return LS;
        }

    }
}
