using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_Ingrediente
    {
        public mp_Ingrediente mapper = new mp_Ingrediente();

        public int AgregarIngrediente (BE_Ingrediente ingrediente)
        {
            return mapper.AgregarIngrediente(ingrediente);
        }
        public int EliminarIngrediente(BE_Ingrediente ingrediente)
        {
            return mapper.EliminarIngrediente(ingrediente);
        }
       public int ModificarIngrediente(BE_Ingrediente ingrediente)
        {
            return mapper.ModificarIngrediente(ingrediente);
        }
       
        
    }
}
