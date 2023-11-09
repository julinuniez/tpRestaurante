using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BE_Categoria
    {

		private int _IdCategoria;

		public int IdCategoria
        {
			get { return _IdCategoria; }
			set { _IdCategoria = value; }
		}

		private string _Descripcion;

		public string Descripcion
        {
			get { return _Descripcion; }
			set { _Descripcion = value; }
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
