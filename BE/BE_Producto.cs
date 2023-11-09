using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
	public class BE_Producto
	{
		private int _IdProducto;

		public int IdProducto
		{
			get { return _IdProducto; }
			set { _IdProducto = value; }
		}



        private string _NombreProducto;

        public string NombreProducto
        {
            get { return _NombreProducto; }
            set { _NombreProducto = value; }
        }



        private string _Descripcion;

		public string Descripcion
		{
			get { return _Descripcion; }
			set { _Descripcion = value; }
		}


		private decimal _Precio;

		public decimal Precio
        {
			get { return _Precio; }
			set { _Precio = value; }
		}

		private decimal _Valoracion;

		public decimal Valoracion
        {
			get { return _Valoracion; }
			set { _Valoracion = value; }
		}

		private byte _imagen;

		public byte imagen
        {
			get { return _imagen; }
			set { _imagen = value; }
		}


		

	}
}
