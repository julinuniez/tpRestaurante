using BE;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class mp_Ingrediente
    {

        Acceso acceso = new Acceso();

        public int AgregarIngrediente(BE_Ingrediente ingrediente)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
               new SqlParameter("idIngrediente", ingrediente.idIngrediente),
               new SqlParameter("Descripcion", ingrediente.descripcion),
               new SqlParameter("cantidadDisponible", ingrediente.CantidadDisponible),
            };
            int resultado = acceso.escribir("AgregarIngrediente", parameters);
            return resultado;

        }

        public int EliminarIngrediente(BE_Ingrediente ingrediente)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
               new SqlParameter("idIngrediente", ingrediente.idIngrediente),

            };
            int resultado = acceso.escribir("Ingrediente", parameters);
            return resultado;

        }

        public int ModificarIngrediente(BE_Ingrediente ingrediente)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
               new SqlParameter("idIngrediente", ingrediente.idIngrediente),
               new SqlParameter("Descripcion", ingrediente.descripcion),
               new SqlParameter("cantidadDisponible", ingrediente.CantidadDisponible),
            };
            int resultado = acceso.escribir("ModificarIngrediente", parameters);
            return resultado;

        }
    }
}
