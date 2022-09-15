using Problema_2._1_Pilas.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Problema_2._1_Pilas
{
    public partial class FrmPilas : Form
    {
        public int tam = 6;
        private PilaInt arrayPila;
        public FrmPilas()
        {
            InitializeComponent();
        }

        private void FrmPilas_Load(object sender, EventArgs e)
        {
            arrayPila= new PilaInt(tam);
            CenterToScreen();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            lblTamanio.Text = "Max. de pilas permitidas: " + tam;

        }

        private void button1_Click(object sender, EventArgs e) //Checkear
        {
            
            if (arrayPila.estaVacia())
            {
                MessageBox.Show("No se encuentran pilas en la coleccion");
            }
            else MessageBox.Show("La colección contiene " + arrayPila.Libre().ToString() + " pilas");
        }

        private void btnExtraer_Click(object sender, EventArgs e)
        {
            
            if (!arrayPila.estaVacia())
            {
                Pila p = arrayPila.extraer();
                lstPilas.Items.Remove(p);
                MessageBox.Show("Se extrajo la "+p.ToString());
            }
            else MessageBox.Show("La colección está vacia");
        }
        

        private void btnPrimero_Click(object sender, EventArgs e)
        {
            
            if (!arrayPila.estaVacia())
            {
                Pila p=arrayPila.primero();
                MessageBox.Show("La primera pila de la colección es "+p.ToString());
            }
            else MessageBox.Show("La colección está vacia");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (arrayPila.Libre() > -1)
            {
                Pila p = new Pila(arrayPila.Libre());
                if (arrayPila.añadir(p))
                {
                    MessageBox.Show("Se cargó una nueva pila a la colección");
                    lstPilas.Items.Add(p);
                }
            }
            else MessageBox.Show("La coleccion esta llena");
        }

        private void lblTamanio_Click(object sender, EventArgs e)
        {

        }
    }
}
