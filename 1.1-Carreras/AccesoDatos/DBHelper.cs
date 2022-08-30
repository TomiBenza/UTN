using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace _1._1_Carreras
{
    internal class DBHelper
    {
        SqlConnection conn = new SqlConnection(Properties.Resources.cnnString);
        SqlCommand cmd = new SqlCommand();

        private void Conectar()
        {
            conn.Open();
            cmd.Connection = conn;
        }
        public void Desconectar()
        {
            conn.Close();
        }

        public DataTable LeerBD(string SP)
        {
            cmd.Parameters.Clear();
            DataTable tabla=new DataTable();
            Conectar();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = SP;
            tabla.Load(cmd.ExecuteReader());
            Desconectar();
            return tabla;
        }
        public int CantidadCarreras()
        {
            Conectar();
            cmd.Parameters.Clear();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_CANTIDAD_CARRERAS";
            cmd.Parameters.Clear();
            SqlParameter cant = new SqlParameter();
            cant.ParameterName = "@cant";
            cant.DbType = DbType.Int32;
            cant.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(cant);
            
            cmd.ExecuteReader();
            Desconectar();
            
            return (int)cant.Value;
        }
        public DataTable Detalles(int idcarrera)
        {
            DataTable table = new DataTable();
            Conectar();
            cmd.Parameters.Clear();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idCarrera",idcarrera);
            cmd.CommandText = "SP_VER_DETALLES";
            table.Load(cmd.ExecuteReader());
            Desconectar();
            return table;
        }
        public int BorrarCarrera(string SP,Carrera c)
        {
            int filasAfectadas = 0;
            Conectar();
            cmd.Parameters.Clear();
            cmd.CommandType = CommandType.StoredProcedure;
            
            cmd.Parameters.AddWithValue("@id_carrera", c.IdCarrera);
            cmd.CommandText = SP;
            filasAfectadas=cmd.ExecuteNonQuery();
            
            Desconectar();
            return filasAfectadas;
        }
        
      
    }
}
