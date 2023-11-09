using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Usuarios_Producto : UserControl
    {
        private int idProdcuto = 0;
        private string descripción;



        public Usuarios_Producto()
        {
            InitializeComponent();
        }

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


        SqlConnection conn = new SqlConnection("Data Source=CANCXAN23\\SQLEXPRESS;Initial Catalog=DBSISTEMARESTAURANTE;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter adapter = new SqlDataAdapter();

        


        private void Usuarios_Producto_Load(object sender, EventArgs e)
        {

        }


    }
}
