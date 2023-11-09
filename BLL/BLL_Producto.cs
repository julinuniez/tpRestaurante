using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public  class BLL_Producto
    {
        public mp_Producto objcd_Producto = new mp_Producto();

        public int AgregarProducto(BE_Producto producto)
        {
            return objcd_Producto.AgregarProducto(producto);
        }


    }
}
