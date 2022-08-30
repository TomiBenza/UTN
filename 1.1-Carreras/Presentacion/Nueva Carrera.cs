using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1._1_Carreras
{
    public partial class FrmNueva_Carrera : Form
    {
        DBHelper oBD = new DBHelper();
        Carrera c = new Carrera();
        public FrmNueva_Carrera()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void CargarAsignaturas()
        {
            DataTable tabla = oBD.LeerBD("pa_ver_asignaturas");
            cboAsignaturas.DataSource = tabla;
            cboAsignaturas.ValueMember = tabla.Columns[0].ColumnName;
            cboAsignaturas.DisplayMember = tabla.Columns[1].ColumnName;
            cboAsignaturas.SelectedIndex = -1;

        }
       

        private void FrmNueva_Carrera_Load(object sender, EventArgs e)
        {
            CargarAsignaturas();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (Validar())
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
                
                dgvDetalle.Rows.Add(new object[] { id,asig,cuatr,anio });
            }
        }
        private void GuardarCarrera()
        {
            c.Nombre=txtNombre.Text;
            c.Titulo=txtTitulo.Text;
            if (c.Confirmar())
            {
                MessageBox.Show("Carrera cargada", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Error, no se pudo registrar correctamente la carrera", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            if (txtTitulo.Text.Equals(string.Empty))
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
            if(dgvDetalle.Rows.Count == 0)
            {
                MessageBox.Show("Debe ingresar por lo menos una asignatura", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                valido = false;
            }
            return valido;
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
                try { Convert.ToInt32(txtAnioCursado.Text); }
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
                    valido=false; break;

                }
            }
            return valido;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (ValidarCarrera())
            {
                GuardarCarrera();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea cancelar y salir?\n\n Los cambios no se guardarán","Salir",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2)==DialogResult.Yes)
            {
                this.Dispose();
            }
            
        }

        private void dgvDetalle_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Al hacer click:
            if (dgvDetalle.CurrentCell.ColumnIndex == 4)
            {
                c.QuitarDetalle(dgvDetalle.CurrentRow.Index); //eliminar detalle de list<>
                dgvDetalle.Rows.Remove(dgvDetalle.CurrentRow); //eliminar detalle del dgv
            }
        }
    }
}
