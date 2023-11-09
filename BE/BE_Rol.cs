using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public  class BE_Rol
    {
		private int _IdRol;

		public int IdRol
        {
			get { return _IdRol; }
			set { _IdRol = value; }
		}

		private string _Descripción;

		public string Descripción
        {
			get { return _Descripción; }
			set { _Descripción = value; }
		}

		private string _FechaRegistro;

		public string FechaRegistro
        {
			get { return _FechaRegistro; }
			set { _FechaRegistro = value; }
		}






	}
}
