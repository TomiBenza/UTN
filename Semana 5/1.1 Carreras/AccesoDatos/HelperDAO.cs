using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace _1._1_Carreras.AccesoDatos
{
    internal class HelperDAO : IDAO
    {
        private static HelperDAO instance;
        private string cnnString;
        SqlConnection conn;
        SqlCommand cmd;
        SqlTransaction trs = null;
        private HelperDAO()
        {
            cnnString = Properties.Resources.cnnString;
            conn = new SqlConnection(cnnString);
            cmd = new SqlCommand();
        }
        public static HelperDAO GetInstance()
        {
            if (instance == null)
            {
                instance = new HelperDAO();
            }
            return instance;
        }
        private void Conectar()
        {
            conn.Open();
            cmd.Connection = conn;
        }
        public DataTable Read(string SP)
        {
            cmd.Parameters.Clear();
            DataTable dt = new DataTable();
            Conectar();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = SP;
            dt.Load(cmd.ExecuteReader());
            conn.Close();
            return dt;
        }
        public DataTable ReadDetalles(int idcarrera,string SP)
        {
            DataTable table = new DataTable();
            Conectar();
            cmd.Parameters.Clear();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idCarrera", idcarrera);
            cmd.CommandText = SP;
            table.Load(cmd.ExecuteReader());
            conn.Close();
            return table;
        }
        public bool Update(Carrera c)
        {
            bool result = true;
            try
            {
                Conectar();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_MODIFICAR_CARRERAS";
                cmd.Parameters.Clear();
                trs = conn.BeginTransaction();
                cmd.Transaction = trs;
                cmd.Parameters.AddWithValue("@id_Carrera", c.IdCarrera);
                cmd.Parameters.AddWithValue("@nombre", c.Nombre);
                cmd.Parameters.AddWithValue("@titulo", c.Titulo);

                cmd.ExecuteNonQuery();

                int cDetalles = 1;
                foreach (DetalleCarrera det in c.Detalles)
                {
                    SqlCommand cmdDet = new SqlCommand("SP_INSERTAR_DETALLE", conn);
                    cmdDet.CommandType = CommandType.StoredProcedure;

                    cmdDet.Transaction = trs;
                    cmdDet.Parameters.Clear();
                    cmdDet.Parameters.AddWithValue("@id_detalle", cDetalles);
                    cmdDet.Parameters.AddWithValue("id_carrera", c.IdCarrera);
                    cmdDet.Parameters.AddWithValue("@anioCursado", det.AnioCursado);
                    cmdDet.Parameters.AddWithValue("@cuatrimestre", det.Cuatrimestre);
                    cmdDet.Parameters.AddWithValue("@id_asignatura", det.Asignatura.Id);
                    cmdDet.ExecuteNonQuery();
                    cDetalles++;

                }
                trs.Commit();
            }
            catch (Exception)
            {
                trs.Rollback();
                result = false;
            }
            finally
            {
                if (conn != null && conn.State == ConnectionState.Open)
                    conn.Close();
            }
            return result;
        }
        public bool Delete(Carrera c)
        {
            bool result = true;
            try
            {
                Conectar();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_BAJA_CARRERA";

                trs = conn.BeginTransaction();
                cmd.Transaction = trs;

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id_carrera", c.IdCarrera);
                cmd.Parameters.AddWithValue("@estado", 0);
                cmd.ExecuteNonQuery();

                int cDetalles = 1;
                foreach (DetalleCarrera det in c.Detalles)
                {
                    SqlCommand cmdDet = new SqlCommand("SP_INSERTAR_DETALLE", conn);
                    cmdDet.CommandType = CommandType.StoredProcedure;
                    cmdDet.Transaction = trs;
                    cmdDet.Parameters.AddWithValue("@id_detalle", cDetalles);
                    cmdDet.Parameters.AddWithValue("@id_carrera", c.IdCarrera);
                    cmdDet.Parameters.AddWithValue("@anioCursado", det.AnioCursado);
                    cmdDet.Parameters.AddWithValue("@cuatrimestre", det.Cuatrimestre);
                    cmdDet.Parameters.AddWithValue("@id_asignatura", det.Asignatura.Id);
                    cmdDet.ExecuteNonQuery();
                    cDetalles++;
                }
                trs.Commit();

            }
            catch (Exception)
            {
                trs.Rollback();
                result = false;
            }
            finally
            {
                if (conn != null && conn.State == ConnectionState.Open)
                    conn.Close();
            }
            return result;
        }
        public bool Create(string nombre,string titulo, List<DetalleCarrera> detalle)
        {
            bool result = true;
            try
            {
                Conectar();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_INSERTAR_MAESTRO";
                trs = conn.BeginTransaction();
                cmd.Transaction = trs;

                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@titulo", titulo);

                //parametro de salida
                SqlParameter param = new SqlParameter("id_carrera", SqlDbType.Int);
                param.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(param);
                cmd.ExecuteNonQuery();

                int id_carrera = Convert.ToInt32(param.Value);
                int cDetalles = 1;

                foreach (DetalleCarrera det in detalle)
                {
                    SqlCommand cmdDet = new SqlCommand("SP_INSERTAR_DETALLE", conn);
                    cmdDet.CommandType = CommandType.StoredProcedure;

                    cmdDet.Transaction = trs;
                    cmdDet.Parameters.AddWithValue("@id_detalle", cDetalles);
                    cmdDet.Parameters.AddWithValue("id_carrera", id_carrera);
                    cmdDet.Parameters.AddWithValue("@anioCursado", det.AnioCursado);
                    cmdDet.Parameters.AddWithValue("@cuatrimestre", det.Cuatrimestre);
                    cmdDet.Parameters.AddWithValue("@id_asignatura", det.Asignatura.Id);
                    cmdDet.ExecuteNonQuery();
                    cDetalles++;

                }
                trs.Commit();
            }
            catch (Exception)
            {
                result = false;
                trs.Rollback();
            }
            finally
            {
                if (conn != null && conn.State == ConnectionState.Open)
                    conn.Close();
            }
            return result;
        }
        public int CantidadCarreras()
        {
            Conectar();
            cmd.Parameters.Clear();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_CANTIDAD_CARRERAS";

            SqlParameter cant = new SqlParameter();
            cant.ParameterName = "@cant";
            cant.DbType = DbType.Int32;
            cant.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(cant);

            cmd.ExecuteReader();
            conn.Close();

            return (int)cant.Value;
        }

    }
}
