using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BE_Venta
    {
		private int _IdVenta;

		public int IdVenta
        {
			get { return _IdVenta; }
			set { _IdVenta = value; }
		}
		public BE_Usuario usu { get; set; }

		private string _TipoDocumento;

		public string TipoDocumento
        {
			get { return _TipoDocumento; }
			set { _TipoDocumento = value; }
		}

		private string _NumeroDocumento;

		public  string NumeroDocumento
        {
			get { return _NumeroDocumento; }
			set { _NumeroDocumento = value; }
		}

		private string _NombreCompleto;

		public string NombreCompleto
        {
			get { return _NombreCompleto; }
			set { _NombreCompleto = value; }
		}

		private decimal _MontoPago;

		public decimal MontoPago
        {
			get { return _MontoPago; }
			set { _MontoPago = value; }
		}


		private decimal _MontoCambio;

		public decimal MontoCambio
        {
			get { return _MontoCambio; }
			set { _MontoCambio = value; }
		}


        private decimal _MontoTotal;

        public decimal MontoTotal
        {
            get { return _MontoTotal; }
            set { _MontoTotal = value; }
        }


        private string _FechaRegistro;
        public string FechaRegistro
        {
            get { return _FechaRegistro; }
            set { _FechaRegistro = value; }
        }


    }
}
