using BE;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class mp_Producto
    {
        Acceso acceso = new Acceso();

        public int AgregarProducto(BE_Producto producto)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
               new SqlParameter("IdProducto", producto.IdProducto),
               new SqlParameter("NombreProducto", producto.NombreProducto),
               new SqlParameter("Descripcion", producto.Descripcion),
               new SqlParameter("Precio", producto.Precio),
               new SqlParameter("Valoración", producto.Valoracion),
               new SqlParameter("Imagen", producto.imagen)
            };
            int resultado = acceso.escribir("AgregarProductos", parameters);
            return resultado;

        }

        public int ModificarProducto(BE_Producto producto)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
              new SqlParameter("IdProducto", producto.IdProducto),
               new SqlParameter("NombreProducto", producto.NombreProducto),
               new SqlParameter("Descripcion", producto.Descripcion),
               new SqlParameter("Precio", producto.Precio),
               new SqlParameter("Valoración", producto.Valoracion),
               new SqlParameter("Imagen", producto.imagen)
            };
            int resultado = acceso.escribir("ModificarProducto", parameters);
            return resultado;

        }

        public int EliminarProducto(BE_Producto producto)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("IdProducto", producto.IdProducto)

            };
            int resultado = acceso.escribir("EliminarProducto", parameters);
            return resultado;

        }



    }
}
