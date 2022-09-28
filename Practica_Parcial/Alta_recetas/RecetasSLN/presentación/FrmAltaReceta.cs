using RecetasSLN.datos;
using RecetasSLN.dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecetasSLN.presentación
{
    public partial class FrmAltaReceta : Form
    {
        private Receta oReceta;
        private RecetasDAO recetasDAO;
        public FrmAltaReceta()
        {
            InitializeComponent();

        }

        private void FrmAltaReceta_Load(object sender, EventArgs e)
        {
            oReceta=new Receta();
            recetasDAO=new RecetasDAO();
            CargarIngredientes();
            CargarTiposRecetas();
            ProximaReceta();
            CantidadIngredientes();
            CenterToScreen();
        }

        private void CargarTiposRecetas()
        {
            DataTable dt = recetasDAO.CargarTiposRecetas();
            cboTipoRecetas.DataSource = dt;
            cboTipoRecetas.ValueMember = "id";
            cboTipoRecetas.DisplayMember = "nombre";
            cboTipoRecetas.SelectedIndex = -1;
            cboTipoRecetas.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void CantidadIngredientes()
        {
            lblCantidadIng.Text = "Cantidad de Ingredientes: " + dgvDetalles.Rows.Count;
        }

        private void ProximaReceta()
        {
            lblRecetaNro.Text = "Receta #" + recetasDAO.ProximaReceta();
        }

        private void CargarIngredientes()
        {
            //List<Ingrediente> list = recetasDAO.CargarIngredientes();
            DataTable table = recetasDAO.CargarIngredientesI();
            cboIngredientes.DataSource = table;
            cboIngredientes.DisplayMember = "n_ingrediente";
            cboIngredientes.ValueMember = "id_ingrediente";
            cboIngredientes.SelectedIndex = -1;
            cboIngredientes.DropDownStyle = ComboBoxStyle.DropDownList;
        }


        private void cboIngredientes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                DataRowView item = (DataRowView)cboIngredientes.SelectedItem;
                int id = (int)item.Row.ItemArray[0];
                string nom = item.Row.ItemArray[1].ToString();
                string unit=item.Row.ItemArray[2].ToString();
                int cant = (int)numericUDIngredientes.Value;
                
                Ingrediente ing = new Ingrediente(id,nom,unit);
                DetalleReceta detalle = new DetalleReceta(ing,cant);
                oReceta.AgregarDetalle(detalle);
                dgvDetalles.Rows.Add(new object[] { id, nom, cant });
                CantidadIngredientes();
            }
        }

        private bool Validar()
        {
            bool result = true;
            if (cboIngredientes.SelectedIndex == -1)
            {
                result = false;
                cboIngredientes.Focus();
                MessageBox.Show("Debe seleccionar un ingrediente","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
            else if (numericUDIngredientes.Value < 1)
            {
                result=false;
                numericUDIngredientes.Focus();
                MessageBox.Show("La cantidad debe ser por lo menos 1", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            foreach(DataGridViewRow row in dgvDetalles.Rows)
            {
                if(row.Cells["ClmIngrediente"].Value.ToString() == cboIngredientes.Text)
                {
                    result = false;
                    MessageBox.Show("El ingrediente "+cboIngredientes.Text+" ya se encuentra añadido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
                }
            }
            return result;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (ValidarReceta())
            {
                oReceta.Nombre = txtNombre.Text;
                oReceta.Cheff=txtCheff.Text;
                oReceta.TipoReceta = (int)cboTipoRecetas.SelectedValue;
                if (recetasDAO.NuevaReceta(oReceta))
                {
                    ProximaReceta();
                    MessageBox.Show("Receta cargada correctamente", "Nueva receta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else MessageBox.Show("Ha ocurrido un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidarReceta()
        {
            bool result = true;
            if (txtNombre.Text == "")
            {
                result = false;
                txtNombre.Focus();
                result = false;
                MessageBox.Show("Debe ingresar un nombre de Receta", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else try { txtNombre.Text.ToString(); }
                catch (Exception)
                {
                    txtNombre.Focus();
                    result = false;
                    MessageBox.Show("Debe ingresar un nombre de receta válido", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            if(txtCheff.Text == "")
            {
                result = false;
                txtCheff.Focus();
                MessageBox.Show("Debe ingresar un Cheff", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else try { txtCheff.Text.ToString(); }
                catch (Exception)
                {
                    txtCheff.Focus();
                    result = false;
                    MessageBox.Show("Debe ingresar un nombre de Cheff válido", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            if(cboTipoRecetas.SelectedIndex == -1)
            {
                cboTipoRecetas.Focus();
                result = false;
                MessageBox.Show("Debe seleccionar un tipo de receta", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            if(dgvDetalles.Rows.Count < 3)
            {
                result = false;
                cboIngredientes.Focus();
                MessageBox.Show("Debe seleccionar por lo menos 3 ingredientes", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return result;
        }

        private void dgvDetalles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvDetalles.CurrentCell.ColumnIndex == 3)
            {
                oReceta.QuitarDetalle(dgvDetalles.CurrentRow.Index);
                dgvDetalles.Rows.Remove(dgvDetalles.CurrentRow);
                CantidadIngredientes();
            }
        }
    }
}
