using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Sucursal
    {

        private string idSucursal;

        public string IdSucursal
        {
            get { return idSucursal; }
            set { idSucursal = value; }
        }

        private string direccion;

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        private string localidad;

        public string Localidad
        {
            get { return localidad; }
            set { localidad = value; }
        }

        private string zona;

        public string Zona
        {
            get { return zona; }
            set { zona = value; }
        }



    }
}
