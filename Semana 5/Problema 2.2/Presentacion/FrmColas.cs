using Problema_2._2.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Problema_2._2
{
    public partial class FrmCola : Form
    {
        private List<Producto> lProducto;
        private gestorProducto gst;
        public FrmCola()
        {
            InitializeComponent();
        }

        private void FrmCola_Load(object sender, EventArgs e)
        {
            lstProductos.Items.Clear();
            gst = new gestorProducto();
            lProducto = new List<Producto>();
        }

        private void btnCheckear_Click(object sender, EventArgs e)
        {
            if (gst.estaVacia(lProducto))
            {
                MessageBox.Show("La cola está vacía");
            }
            else MessageBox.Show("La cola NO está vacía");
        }

        private void btnPrimero_Click(object sender, EventArgs e)
        {
            if (gst.primero(lProducto) != null)
            {
                MessageBox.Show("El primer producto es el nro: "+ gst.primero(lProducto).Nro);
            }
            else MessageBox.Show("No existen productos en cola");
        }

        private void btnAniadir_Click(object sender, EventArgs e)
        {
            Producto p;
            p = new Producto(gst.Contar(lProducto) + 1);
            if (gst.añadir(lProducto,p))
            {
                lstProductos.Items.Add(p);
                MessageBox.Show("Se añadió un nuevo producto a la cola");
            }
            else MessageBox.Show("Ocurrió un error al agregar un nuevo producto");
        }

        private void btnExtraer_Click(object sender, EventArgs e)
        {
            Producto p = gst.extraer(lProducto);
            if (p != null)
            {
                lstProductos.Items.Remove(p);
                MessageBox.Show("Se extrajo de la cola el producto nro: " + p.Nro);
            }
            else MessageBox.Show("La cola está vacia, no se pueden extraer productos");
        }
    }
}
