using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class Acceso
    {

        SqlConnection CN = new SqlConnection();

        void conectar()
        {
            CN.ConnectionString = @"Data Source=.;Initial Catalog=Parcial;Integrated Security=True";
            CN.Open();
        }

        void desconectar()
        {
            CN.Close();
            CN.Dispose();
        }

        public int escribir(string st, SqlParameter[] parametros)
        {
            conectar();
            int fa = 0;

            SqlCommand CM = new SqlCommand();
            SqlTransaction TR;

            TR = CN.BeginTransaction();

            try
            {
                CM.Connection = CN;
                CM.CommandType = CommandType.StoredProcedure;
                CM.CommandText = st;
                CM.Parameters.AddRange(parametros);

                CM.Transaction = TR;

                fa = CM.ExecuteNonQuery();

                TR.Commit();

            }
            catch (Exception)
            {
                TR.Rollback();
                fa = 0;
            }

            desconectar();

            return fa;
        }

        public DataTable leer(string st, SqlParameter[] parametros)
        {

            conectar();

            DataTable datatable = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = new SqlCommand();

            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            adapter.SelectCommand.CommandText = st;

            if (parametros != null)
            {
                adapter.SelectCommand.Parameters.AddRange(parametros);
            }

            adapter.SelectCommand.Connection = CN;
            adapter.Fill(datatable);

            desconectar();

            return datatable;
        }

    }
}
