using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace _1._1_Carreras.Presentacion
{
    public partial class FrmConsultarCarreras : Form
    {
        DBHelper oBD=new DBHelper();
        List<Carrera> lCarreras=new List<Carrera>();
        public FrmConsultarCarreras()
        {
            InitializeComponent();
            CenterToScreen();
            CenterToParent();
            Habilitar(false);
        }
        private void FrmConsultarCarreras_Load(object sender, EventArgs e)
        {
            CargarLista();
            CantidadCarreras();
        }

        private void CargarLista()
        {
            lstCarreras.Items.Clear();
            lCarreras.Clear();
            
            DataTable Tcarrera = oBD.LeerBD("SP_VER_CARRERAS");        
            foreach (DataRow fila in Tcarrera.Rows)
            {
                Carrera c = new Carrera();
                c.Nombre = fila["nombre"].ToString();
                c.Titulo = fila["titulo"].ToString();       
                c.IdCarrera = Convert.ToInt32(fila["id_carrera"]);

                DataTable Tdetalle = oBD.Detalles(c.IdCarrera);
                foreach (DataRow Detallefila in Tdetalle.Rows)
                {
                    DetalleCarrera d = new DetalleCarrera();
                    d.AnioCursado = Convert.ToInt32(Detallefila["anioCursado"]);
                    d.Cuatrimestre = Convert.ToInt32(Detallefila["cuatrimestre"]);
                    int idAsig = Convert.ToInt32(Detallefila["id_asignatura"]);
                    string name = Detallefila["asignatura"].ToString();
                    Asignaturas a = new Asignaturas(idAsig,name);
                    d.Asignatura = a;
                    c.AgregarDetalle(d);
                }
                
                lstCarreras.Items.Add(c);
                lCarreras.Add(c);
            }
            
        }

        private void CantidadCarreras()
        {
            int cant = oBD.CantidadCarreras();
            if (cant > 0)
            {
                lblCantCarreras.Text = "Cant. Carreras: " + cant.ToString();
            }
            else
                MessageBox.Show("Error. No se puede obtener la cantidad de carreras","Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Habilitar(bool x)
        {
            btnBorrarC.Enabled = x;
           
            btnCancelar.Enabled = x;
            btnSalir.Enabled = !x;

        }

        private void lblDetalles_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Habilitar(false);
            lstCarreras.SelectedIndex = -1;
        }
        private void Limpiar()
        {
            dgvDetalle.Rows.Clear();
            txtNombre.Text = "";
            txtTitulo.Text = "";
        }
        private void lstCarreras_SelectedIndexChanged(object sender, EventArgs e)
        {
            Limpiar();
            
            if (lstCarreras.SelectedIndex > -1)
            {
                Habilitar(true);
                CargarDatos(lstCarreras.SelectedIndex);
            }
        }
        private void CargarDatos(int index)
        {
            foreach (Carrera c in lCarreras)
            {
                txtNombre.Text = lCarreras[index].Nombre;
                txtTitulo.Text=lCarreras[index].Titulo;
                
            }
            foreach (DetalleCarrera dc in lCarreras[index].Detalles)
            {
                int anio = dc.AnioCursado;
                int cuatr = dc.Cuatrimestre;
                string asig = dc.Asignatura.Name;
                int id = dc.Asignatura.Id;
                dgvDetalle.Rows.Add(new object[] { id, asig, anio, cuatr });
            }
        }
        private void lblCantCarreras_Click(object sender, EventArgs e)
        {

        }

        private void btnBorrarC_Click(object sender, EventArgs e)
        {
           if(MessageBox.Show("¿Está seguro que desea eliminar la carrera " + lCarreras[lstCarreras.SelectedIndex].Nombre + " ?\n\n El borrado de una carrera es irreversible", "Borrar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
           {
                if (oBD.BorrarCarrera("SP_BORRAR_CARRERA", lCarreras[lstCarreras.SelectedIndex]) > 0)
                {
                    lstCarreras.SelectedIndex = -1;
                    MessageBox.Show("Carrera eliminada", "Borrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarLista();
                    CantidadCarreras();
                }
                else
                    MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
              
                
           }
        }
    }
}
