using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BE_Usuario
    {

		private int _Documento;

		public int Documento
        {
			get { return _Documento; }
			set { _Documento = value; }
		}

		private string _categoria;

		public string Categoria
		{
			get { return _categoria; }
			set { _categoria = value; }
		}

		private string _NombreCompleto;

		public string NombreCompleto
        {
			get { return _NombreCompleto; }
			set { _NombreCompleto = value; }
		}

		private string _email;

		public  string email
        {
			get { return _email; }
			set { _email = value; }
		}
		private string _Contraseña;

		public string Contraseña
        {
			get { return _Contraseña; }
			set { _Contraseña = value; }
		}

        private DateTime _FechaRegistro;
        public DateTime FechaRegistro
        {
            get { return _FechaRegistro; }
            set { _FechaRegistro = value; }
        }

    }
}
