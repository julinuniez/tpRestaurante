using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BE_Ingrediente
    {
		private int _idIng;

		public int idIngrediente
		{
			get { return _idIng; }
			set { _idIng = value; }
		}

		private string _desc;

		public string descripcion
		{
			get { return _desc; }
			set { _desc = value; }
		}

		private string _cantDisponible;

		public string CantidadDisponible
		{
			get { return _cantDisponible; }
			set { _cantDisponible = value; }
		}




	}
}
