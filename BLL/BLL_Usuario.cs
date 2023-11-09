using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;


namespace BLL
{
    public class BLL_Usuario
    {

        

        public mp_Usuario objcd_Usuario = new mp_Usuario();

        public List<BE_Usuario> Listar()
        {
            return objcd_Usuario.Listar();
        }

        public int agregarUsuario(BE_Usuario usu)
        {
            return objcd_Usuario.AgregarUsuario(usu);
        }

        public int EliminarUsuario(BE_Usuario usu)
        {
            return objcd_Usuario.EliminarUsuario(usu);
        }


    }
}
