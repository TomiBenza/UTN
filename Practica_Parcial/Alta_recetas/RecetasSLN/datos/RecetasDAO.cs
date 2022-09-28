using RecetasSLN.dominio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace RecetasSLN.datos
{
    internal class RecetasDAO : IRecetasDAO
    {
        SqlConnection conn;
        public List<Ingrediente> CargarIngredientes()
        {
            List<Ingrediente> list = new List<Ingrediente>();
            DataTable tabla = HelperDAO.GetInstance().ConsultaSQL("SP_CONSULTAR_INGREDIENTES");
            foreach (DataRow dr in tabla.Rows)
            {
                int id = Convert.ToInt32(dr["id_ingrediente"]);
                string nom=dr["n_ingrediente"].ToString();
                string unidad = (dr["unidad_medida"]).ToString();
                Ingrediente i = new Ingrediente(id,nom,unidad);
                list.Add(i);
            }
            return list;
        }
        public DataTable CargarIngredientesI()
        {
            DataTable tabla = HelperDAO.GetInstance().ConsultaSQL("SP_CONSULTAR_INGREDIENTES");
            return tabla;
        }

        internal DataTable CargarTiposRecetas()
        {
            DataTable tabla = HelperDAO.GetInstance().ConsultaSQL("SP_CONSULTAR_TIPORECETA");
            return tabla;
        }

        public int ProximaReceta()
        {
            int nro;
            nro=HelperDAO.GetInstance().Proximo("SP_PROXIMO_ID");
            return nro;
        }
        public bool NuevaReceta(Receta r)
        {
            bool result;
            SqlTransaction trans = null;
            try
            {
                conn = new SqlConnection(Properties.Resources.cnnString);
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SP_INSERTAR_RECETA";
                cmd.CommandType = CommandType.StoredProcedure;
                conn.Open();
                trans = conn.BeginTransaction();
                cmd.Transaction = trans;


                cmd.Parameters.AddWithValue("@nombre", r.Nombre);
                cmd.Parameters.AddWithValue("@cheff", r.Cheff);
                cmd.Parameters.AddWithValue("@tipo_receta", r.TipoReceta);
                SqlParameter param = new SqlParameter();
                param.ParameterName = "@id_receta";
                param.Direction = ParameterDirection.Output;
                param.DbType = DbType.Int32;
                cmd.Parameters.Add(param);
                cmd.ExecuteNonQuery();

                int id_receta = (int)param.Value;
                foreach (DetalleReceta detalle in r.Detalle)
                {

                    SqlCommand cmdDetalle = new SqlCommand();
                    cmdDetalle.Connection = conn;
                    cmdDetalle.CommandText = "SP_INSERTAR_DETALLES";
                    cmdDetalle.CommandType = CommandType.StoredProcedure;
                    cmdDetalle.Parameters.Clear();
                    cmdDetalle.Transaction = trans;

                    cmdDetalle.Parameters.AddWithValue("@id_receta", id_receta);
                    cmdDetalle.Parameters.AddWithValue("@id_ingrediente", detalle.Ingrediente.IngredienteId);
                    cmdDetalle.Parameters.AddWithValue("@cantidad", detalle.Cantidad);
                    cmdDetalle.ExecuteNonQuery();
                }

                trans.Commit();
                result = true;
        }
            catch (Exception)
            {
                result = false;
                trans.Rollback();
            }
            finally
            {
                if (conn.State == ConnectionState.Open & conn != null)
                {
                    conn.Close();
                }
            }
            return result;
        }

    }
}
