using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using BE;
using DAL;

namespace DAL
{
    public class mp_Usuario
    {
        Acceso acceso = new Acceso();


        public int AgregarUsuario(BE_Usuario usu)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
               new SqlParameter("Documento", usu.Documento),
               new SqlParameter("Categoria", usu.Categoria),
               new SqlParameter("NombreCompleto", usu.NombreCompleto),
               new SqlParameter("email", usu.email),
               new SqlParameter("Contraseña", usu.Contraseña),
               new SqlParameter("FechaRegistro",DateTime.Now)
            };
            int resultado = acceso.escribir("AgregarUsuario", parameters);
            return resultado;
        }
        public int ModificarUsuario(BE_Usuario usu)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
               new SqlParameter("Documento", usu.Documento),
               new SqlParameter("Categoria", usu.Categoria),
               new SqlParameter("NombreCompleto", usu.NombreCompleto),
               new SqlParameter("email", usu.email),
               new SqlParameter("Contraseña", usu.Contraseña),
               new SqlParameter("FechaRegistro",DateTime.Now)
            };
            int resultado = acceso.escribir("ModificarUsuario", parameters);
            return resultado;
        }
        public int EliminarUsuario(BE_Usuario usu)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
               new SqlParameter("Documento", usu.Documento)
            };
            int resultado = acceso.escribir("EliminarUsuario", parameters);
            return resultado;
        }
        public List <BE_Usuario> Listar()
        {
            List<BE_Usuario> lista = new List<BE_Usuario>();
            DataTable tabla = new DataTable();
            tabla = acceso.Leer("LeerUsuario", null);

            foreach (DataRow row in tabla.Rows) 
            {
                BE_Usuario usu = new BE_Usuario();
                usu.Documento =Convert.ToInt32(row["Documento"].ToString());
                usu.Categoria = row["Categoria"].ToString();
                usu.NombreCompleto = row["NombreCompleto"].ToString();
                usu.email = row["email"].ToString();
                usu.Contraseña = row["Contraseña"].ToString();
                usu.FechaRegistro = DateTime.Parse(row["FechaRegistro"].ToString());
                lista.Add(usu);
            }
            return lista;

        }



    }
}
