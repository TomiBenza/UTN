using _1._1_Carreras.AccesoDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1._1_Carreras.Dominio
{
    internal class gestorConsultarCarreras
    {
        HelperDAO dao = HelperDAO.GetInstance();

        public void ListaCarreras(List<Carrera> lst, ListBox lstBox)
        {
            lstBox.Items.Clear();
            lst.Clear();
            DataTable Tcarrera = dao.Read("SP_VER_CARRERAS");
            foreach (DataRow fila in Tcarrera.Rows)
            {
                Carrera c = new Carrera();
                c.Nombre = fila["nombre"].ToString();
                c.Titulo = fila["titulo"].ToString();
                c.IdCarrera = Convert.ToInt32(fila["id_carrera"]);
                c.Estado = Convert.ToInt32(fila["estado"]);

                DataTable Tdetalle = dao.ReadDetalles(c.IdCarrera, "SP_VER_DETALLES");
                foreach (DataRow Detallefila in Tdetalle.Rows)
                {
                    DetalleCarrera d = new DetalleCarrera();
                    d.AnioCursado = Convert.ToInt32(Detallefila["anioCursado"]);
                    d.Cuatrimestre = Convert.ToInt32(Detallefila["cuatrimestre"]);
                    int idAsig = Convert.ToInt32(Detallefila["id_asignatura"]);
                    string name = Detallefila["asignatura"].ToString();
                    Asignaturas a = new Asignaturas(idAsig, name);
                    d.Asignatura = a;
                    c.AgregarDetalle(d);
                }
                if (c.Estado > 0)
                {
                    lstBox.Items.Add(c);
                    lst.Add(c);
                }
            }
        }
        public void CargarAsignaturas(ComboBox cbo)
        {
            DataTable tabla = dao.Read("pa_ver_asignaturas");
            cbo.DataSource = tabla;
            cbo.ValueMember = tabla.Columns[0].ColumnName;
            cbo.DisplayMember = tabla.Columns[1].ColumnName;
            cbo.SelectedIndex = -1;
        }
        public int CantidadCarreras()
        {
            int c=dao.CantidadCarreras();
            return c;   
        }
        public bool BajaCarrera(Carrera c)
        {
            bool result = false;
            if (dao.Delete(c))
            {
                result = true;
            }
            return result;
        }
        public bool ModificarCarrera(Carrera c)
        {
            bool result=false;
            if (dao.Update(c))
            {
                result=true;
            }
            return result;
        }
    }
}
