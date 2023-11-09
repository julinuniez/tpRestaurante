using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BE_Proveedor
    {
		private int _IdProveedor;

		public int IdProveedor
        {
			get { return _IdProveedor; }
			set { _IdProveedor = value; }
		}

		private string _Documento;

		public string Documento
        {
			get { return _Documento; }
			set { _Documento = value; }
		}

		private string _RazonSocial;

		public string RazonSocial
        {
			get { return _RazonSocial; }
			set { _RazonSocial = value; }
		}


		private string _email;

		public string email
        {
			get { return _email; }
			set { _email = value; }
		}
		private string _Telefono;

		public string Telefono
        {
			get { return _Telefono; }
			set { _Telefono = value; }
		}


        private bool _Estado;
        public bool Estado
        {
            get { return _Estado; }
            set { _Estado = value; }
        }

        private string _FechaRegistro;
        public string FechaRegistro
        {
            get { return _FechaRegistro; }
            set { _FechaRegistro = value; }
        }

    }
}
