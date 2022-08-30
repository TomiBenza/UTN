using _1._1_Carreras.Presentacion;
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
    public partial class FrmUTN : Form
    {
        public FrmUTN()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            
        }

        private void nuevaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNueva_Carrera frm= new FrmNueva_Carrera();
            frm.ShowDialog();
            frm.Dispose();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea cerrar la aplicación?","Salir",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void FrmUTN_Load(object sender, EventArgs e)
        {

            
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultarCarreras frmcarreras=new FrmConsultarCarreras();
            frmcarreras.ShowDialog();
            frmcarreras.Dispose();

        }
    }
}
