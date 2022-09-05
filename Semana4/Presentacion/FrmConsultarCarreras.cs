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
        }
        private void FrmConsultarCarreras_Load(object sender, EventArgs e)
        {
            CargarLista();
            CantidadCarreras();
            CargarAsignaturas();
            Habilitar(false);
            Editar(false);
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
                c.Estado = Convert.ToInt32(fila["estado"]);

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
                if (c.Estado > 0)
                {
                    lstCarreras.Items.Add(c);
                    lCarreras.Add(c);
                }
                
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

        private void Editar(bool x)
        {
            txtNombre.Enabled = x;
            txtTitulo.Enabled = x;
            dgvDetalle.Enabled = x;
            cboAsignaturas.Enabled = x;
            txtAnioCursado.Enabled = x;
            rbtPrimero.Enabled = x;
            rbtSegundo.Enabled = x;
            btnAceptar.Enabled = x;
            btnAgregar.Enabled = x;

            btnBorrarC.Enabled = !x;
            btnModificar.Enabled = !x;
            btnSalir.Enabled = !x;
        }
        private void Habilitar(bool x)
        {
            btnBorrarC.Enabled = x;
            btnModificar.Enabled = x;
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
            Editar(false);
            lstCarreras.SelectedIndex = -1;
        }
        private void Limpiar()
        {
            dgvDetalle.Rows.Clear();
            txtNombre.Text = "";
            txtTitulo.Text = "";
            cboAsignaturas.SelectedIndex = -1;
            rbtPrimero.Checked = false;
            rbtSegundo.Checked = false;
            txtAnioCursado.Text = "";
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
                dgvDetalle.Rows.Add(new object[] { id, asig, cuatr, anio });
            }
        }
        private void lblCantCarreras_Click(object sender, EventArgs e)
        {

        }

        private bool BajaCarrera()
        {
            bool result = true;
            SqlConnection conn = new SqlConnection(Properties.Resources.cnnString);
            SqlTransaction trs = null;
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SP_BAJA_CARRERA", conn);
                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.StoredProcedure;

                trs = conn.BeginTransaction();
                cmd.Transaction = trs;
                cmd.Parameters.AddWithValue("@id_carrera", lCarreras[lstCarreras.SelectedIndex].IdCarrera);
                cmd.Parameters.AddWithValue("@estado", 0);
                cmd.ExecuteNonQuery();

                int cDetalles = 1;
                foreach (DetalleCarrera det in lCarreras[lstCarreras.SelectedIndex].Detalles)
                {
                    SqlCommand cmdDet = new SqlCommand("SP_INSERTAR_DETALLE", conn);
                    cmdDet.CommandType = CommandType.StoredProcedure;
                    cmdDet.Transaction = trs;
                    cmdDet.Parameters.AddWithValue("@id_detalle", cDetalles);
                    cmdDet.Parameters.AddWithValue("@id_carrera", lCarreras[lstCarreras.SelectedIndex].IdCarrera);
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
        private void btnBorrarC_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("¿Está seguro que desea dar de baja la carrera " + lCarreras[lstCarreras.SelectedIndex].Nombre + "?", "Borrar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (BajaCarrera() == true)
                {
                    lstCarreras.SelectedIndex = -1;
                    Habilitar(false);
                    MessageBox.Show("La carrera se encuentra ahora dada de baja",
                    "Borrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarLista();
                    CantidadCarreras();
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error al borrar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
        }
        
        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (lstCarreras.SelectedIndex > -1)
            {
                Editar(true);                      
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (ModificarCarrera())
            {
                MessageBox.Show("Carrera actualizada", "Actualización", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Editar(false);
                Habilitar(false);
                CargarLista();
                Limpiar();
            }
            else
                MessageBox.Show("Ha ocurrido un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private bool ModificarCarrera()
        {
            bool result = false;
            if (ValidarCarrera())
            {
                foreach (Carrera c in lCarreras)
                {
                    if (c.IdCarrera == lCarreras[lstCarreras.SelectedIndex].IdCarrera)
                    {
                        c.Nombre = txtNombre.Text;
                        c.Titulo = txtTitulo.Text;

                        if (oBD.ModificarCarrera(c))
                        {
                            result = true;
                        }
                    }
                    
                }
            }
            else result=false;
            return result;
        }
        private bool ValidarCarrera()
        {
            bool valido = true;
            if (txtNombre.Text == "")
            {
                valido = false;
                MessageBox.Show("Debe ingresar un nombre de carrera", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNombre.Focus();
            }
            else try { txtNombre.Text.ToString(); }
                catch (Exception)
                {
                    valido = false;
                    MessageBox.Show("Debe ingresar un nombre de carrera válido", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtNombre.Focus();
                }
            if (txtTitulo.Text=="")
            {
                valido = false;
                MessageBox.Show("Debe ingresar un título", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtTitulo.Focus();
            }
            else try { txtTitulo.Text.ToString(); }
                catch (Exception)
                {
                    valido = false;
                    MessageBox.Show("Debe ingresar un título válido", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtTitulo.Focus();
                }
            if (dgvDetalle.Rows.Count == 0)
            {
                MessageBox.Show("Debe ingresar por lo menos una asignatura", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                valido = false;
            }
            return valido;
        }
        private void CargarAsignaturas()
        {
            DataTable tabla = oBD.LeerBD("pa_ver_asignaturas");
            cboAsignaturas.DataSource = tabla;
            cboAsignaturas.ValueMember = tabla.Columns[0].ColumnName;
            cboAsignaturas.DisplayMember = tabla.Columns[1].ColumnName;
            cboAsignaturas.SelectedIndex = -1;

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                foreach (Carrera c in lCarreras)
                {
                    if (c.IdCarrera == lCarreras[lstCarreras.SelectedIndex].IdCarrera)
                    {
                        DataRowView item = (DataRowView)cboAsignaturas.SelectedItem;
                        int id = Convert.ToInt32(item.Row.ItemArray[0]);
                        string asig = item.Row.ItemArray[1].ToString();
                        int cuatr;
                        if (rbtPrimero.Checked) cuatr = 1;
                        else cuatr = 2;
                        int anio = Convert.ToInt32(txtAnioCursado.Text);

                        Asignaturas a = new Asignaturas(id, asig);
                        DetalleCarrera dc = new DetalleCarrera(a, cuatr, anio);

                        c.AgregarDetalle(dc);

                        dgvDetalle.Rows.Add(new object[] { id, asig, cuatr, anio });
                    }

                }
            }
        }
        private bool Validar()
        {
            bool valido = true;
            if (cboAsignaturas.Text.Equals(string.Empty))
            {
                MessageBox.Show("Debe seleccionar una asignatura", "Control",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                valido = false;

            }
            if (rbtPrimero.Checked == false & rbtSegundo.Checked == false)
            {
                MessageBox.Show("Debe ingresar un cuatrimestre", "Control",
                      MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                valido = false;

            }
            if (txtAnioCursado.Text == "")
            {
                MessageBox.Show("Debe ingresar un año de cursado", "Control",
                      MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                valido = false;

            }
            else
                try 
                {
                    Convert.ToInt32(txtAnioCursado.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Debe ingresar un año de cursado válido", "Control",
                      MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    valido = false;
                }
            foreach (DataGridViewRow row in dgvDetalle.Rows)
            {
                if (row.Cells["ClmAsignatura"].Value.ToString().Equals(cboAsignaturas.Text))
                {
                    MessageBox.Show("Asignatura: " + cboAsignaturas.Text + " ya fue añadida",
                        "Control",
                      MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    valido = false; break;

                }
            }
            return valido;
        }

        private void dgvDetalle_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDetalle.CurrentCell.ColumnIndex == 4)
            {
                foreach(Carrera c in lCarreras)
                {
                    if (c.IdCarrera == lCarreras[lstCarreras.SelectedIndex].IdCarrera)
                    {
                        c.QuitarDetalle(dgvDetalle.CurrentRow.Index); //eliminar detalle de list<>
                        dgvDetalle.Rows.Remove(dgvDetalle.CurrentRow); //eliminar detalle del dgv
                    }
                }
            }
        }
    }
}

