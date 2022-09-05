namespace _1._1_Carreras.Presentacion.Reportes
{
    partial class FrmReporteCarreras
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReporteCarreras));
            this.rptCarreras = new Microsoft.Reporting.WinForms.ReportViewer();
            this.carrerasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carrerasListado = new _1._1_Carreras.Presentacion.Reportes.CarrerasListado();
            this.carrerasTableAdapter = new _1._1_Carreras.Presentacion.Reportes.CarrerasListadoTableAdapters.CarrerasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.carrerasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carrerasListado)).BeginInit();
            this.SuspendLayout();
            // 
            // rptCarreras
            // 
            reportDataSource1.Name = "ListaCarreras";
            reportDataSource1.Value = this.carrerasBindingSource;
            this.rptCarreras.LocalReport.DataSources.Add(reportDataSource1);
            this.rptCarreras.LocalReport.ReportEmbeddedResource = "_1._1_Carreras.Presentacion.Reportes.RptCarreras.rdlc";
            this.rptCarreras.Location = new System.Drawing.Point(12, 12);
            this.rptCarreras.Name = "rptCarreras";
            this.rptCarreras.ServerReport.BearerToken = null;
            this.rptCarreras.Size = new System.Drawing.Size(823, 510);
            this.rptCarreras.TabIndex = 0;
            // 
            // carrerasBindingSource
            // 
            this.carrerasBindingSource.DataMember = "Carreras";
            this.carrerasBindingSource.DataSource = this.carrerasListado;
            // 
            // carrerasListado
            // 
            this.carrerasListado.DataSetName = "CarrerasListado";
            this.carrerasListado.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // carrerasTableAdapter
            // 
            this.carrerasTableAdapter.ClearBeforeFill = true;
            // 
            // FrmReporteCarreras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 529);
            this.Controls.Add(this.rptCarreras);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmReporteCarreras";
            this.Text = "Reporte de Carreras";
            this.Load += new System.EventHandler(this.FrmReporteCarreras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.carrerasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carrerasListado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Microsoft.Reporting.WinForms.ReportViewer rptCarreras;
        private CarrerasListado carrerasListado;
        private System.Windows.Forms.BindingSource carrerasBindingSource;
        private CarrerasListadoTableAdapters.CarrerasTableAdapter carrerasTableAdapter;
    }
}