using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1._1_Carreras.Presentacion.Reportes
{
    public partial class FrmReporteCarreras : Form
    {
        public FrmReporteCarreras()
        {
            InitializeComponent();
        }

        private void FrmReporteCarreras_Load(object sender, EventArgs e)
        {
            MaximizeBox=false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            // TODO: esta línea de código carga datos en la tabla 'carrerasListado.Carreras' Puede moverla o quitarla según sea necesario.
            this.carrerasTableAdapter.Fill(this.carrerasListado.Carreras);
            CenterToScreen();
            this.rptCarreras.RefreshReport();
        }
    }
}
