using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BE_DetalleVenta
    {

		private int _IdDetalleVenta;

		public int IdDetalleVenta
        {
			get { return _IdDetalleVenta; }
			set { _IdDetalleVenta = value; }
		}

		public BE_Venta vent { get;set; }
		public BE_Producto produ { get;set; }

		private decimal _PrecioVenta;

		public decimal PrecioVenta
        {
			get { return _PrecioVenta; }
			set { _PrecioVenta = value; }
		}

		private decimal _SubTotal;

		public decimal SubTotal
        {
			get { return _SubTotal; }
			set { _SubTotal = value; }
		}

        private DateTime _FechaRegistro;
        public DateTime FechaRegistro
        {
            get { return _FechaRegistro; }
            set { _FechaRegistro = value; }
        }

    }
}
