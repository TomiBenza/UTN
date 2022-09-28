using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using RecetasSLN.dominio;

namespace RecetasSLN.datos
{
    internal class HelperDAO
    {
        SqlConnection conn;
        SqlCommand cmd;
        private string stringConnection;
        private static HelperDAO instance;
        private HelperDAO()
        {
            stringConnection = Properties.Resources.cnnString;
            conn = new SqlConnection(stringConnection);
            cmd = new SqlCommand();
        }
        public static HelperDAO GetInstance()
        {
            if(instance== null)
            {
                instance = new HelperDAO();
            }
            return instance;
        }
        public DataTable ConsultaSQL(string SP)
        {
            
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = SP;
                cmd.CommandType = CommandType.StoredProcedure;
                dt.Load(cmd.ExecuteReader());
                return dt;
            }
            catch(Exception ex)
            {
                throw (ex);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }
        public int Proximo(string SP)
        {
            cmd.Parameters.Clear();
            cmd.Connection=conn;
            cmd.CommandText=SP;
            cmd.CommandType = CommandType.StoredProcedure;
            conn.Open();
            SqlParameter param = new SqlParameter();
            param.ParameterName = "@next";
            param.DbType = DbType.Int32;
            param.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(param);
            cmd.ExecuteReader();
            conn.Close();
            return (int)param.Value;
        }

    }
}
