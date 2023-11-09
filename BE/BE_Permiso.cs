using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
	public class BE_Permiso
	{
		private string _IdPermiso;

		public string IdPermiso
		{
			get { return _IdPermiso; }
			set { _IdPermiso = value; }
		}

		public BE_Rol BROL{get; set;}

		private string _NombreMenu;

		public string NombreMenu
        {
			get { return _NombreMenu; }
			set { _NombreMenu = value; }
		}

		private string _FechaRegistro;
        public string FechaRegistro
        {
            get { return _FechaRegistro; }
            set { _FechaRegistro = value; }
        }



    }
}
