using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BE_DetalleCompra
    {

		private int _IdDetalleCompra;

		public int IdDetalleCompra
        {
			get { return _IdDetalleCompra; }
			set { _IdDetalleCompra = value; }
		}

		public BE_Producto produ { get; set; }


		private decimal _PrecioCompra;

		public decimal PrecioCompra
        {
			get { return _PrecioCompra; }
			set { _PrecioCompra = value; }
		}
		private int _Cantidad;

		public int Cantidad
        {
			get { return _Cantidad; }
			set { _Cantidad = value; }
		}

        private decimal _MontoTotal;

        public decimal MontoTotal
        {
            get { return _MontoTotal; }
            set { _MontoTotal = value; }
        }


        private DateTime _FechaCompra;
        public DateTime FechaCompra
        {
            get { return _FechaCompra; }
            set { _FechaCompra = value; }
        }

    }
}
