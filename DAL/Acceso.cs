using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Collections;


namespace DAL
{
    public class Acceso
    {

        SqlConnection cn = new SqlConnection("Data Source=CANCXAN23\\SQLEXPRESS;Initial Catalog=DBSISTEMARESTAURANTE;Integrated Security=True");

        void Conectar()
        {
            cn.Open();
        }
        void Desconectar()
        {
            cn.Close();
        }
        public int escribir(string StoredProcedure, SqlParameter[] parameters)
        {
            int result = 0;
            Conectar();
            SqlTransaction ts = cn.BeginTransaction();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = StoredProcedure;
                cmd.Parameters.AddRange(parameters);
                cmd.Connection = cn;
                cmd.Transaction = ts;
                result = cmd.ExecuteNonQuery();
                ts.Commit();
            }
            catch
            {
                ts.Rollback();
            }
            Desconectar();
            return result;
        }
        public int obtenerValorInt(string StoredProcedure, SqlParameter[] parameters)
        {
            int result = 0;
            Conectar();
            SqlTransaction ts = cn.BeginTransaction();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = StoredProcedure;
                cmd.Connection = cn;
                cmd.Transaction = ts;
                if (parameters != null)
                {
                    cmd.Parameters.AddRange(parameters);
                }
                result = (int)cmd.ExecuteScalar();
                ts.Commit();
            }
            catch
            {
                ts.Rollback();
            }
            Desconectar();
            return result;
        }

        public DataTable Leer(string StoredProcedure, SqlParameter[] parameters)
        {

            Conectar();
            DataTable tabla = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = new SqlCommand { Connection = cn, CommandType = CommandType.StoredProcedure, CommandText = StoredProcedure };
            if (parameters != null)
            {
                adapter.SelectCommand.Parameters.AddRange(parameters);
            }
            adapter.Fill(tabla);
            Desconectar();
            return tabla;
        }


    }
    
}
