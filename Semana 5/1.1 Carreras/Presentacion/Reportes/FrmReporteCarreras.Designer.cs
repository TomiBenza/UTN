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
            this.carrerasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carrerasListado = new _1._1_Carreras.Presentacion.Reportes.CarrerasListado();
            this.rptCarreras = new Microsoft.Reporting.WinForms.ReportViewer();
            this.carrerasTableAdapter = new _1._1_Carreras.Presentacion.Reportes.CarrerasListadoTableAdapters.CarrerasTableAdapter();
            this.lblOpciones = new System.Windows.Forms.Label();
            this.rbtBaja = new System.Windows.Forms.RadioButton();
            this.rbtActiva = new System.Windows.Forms.RadioButton();
            this.btnGenerar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.carrerasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carrerasListado)).BeginInit();
            this.SuspendLayout();
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
            // rptCarreras
            // 
            this.rptCarreras.BackColor = System.Drawing.Color.GhostWhite;
            this.rptCarreras.IsDocumentMapWidthFixed = true;
            reportDataSource1.Name = "ListaCarreras";
            reportDataSource1.Value = this.carrerasBindingSource;
            this.rptCarreras.LocalReport.DataSources.Add(reportDataSource1);
            this.rptCarreras.LocalReport.ReportEmbeddedResource = "_1._1_Carreras.Presentacion.Reportes.RptCarreras.rdlc";
            this.rptCarreras.Location = new System.Drawing.Point(12, 63);
            this.rptCarreras.Name = "rptCarreras";
            this.rptCarreras.ServerReport.BearerToken = null;
            this.rptCarreras.ShowBackButton = false;
            this.rptCarreras.ShowPageNavigationControls = false;
            this.rptCarreras.Size = new System.Drawing.Size(850, 511);
            this.rptCarreras.TabIndex = 3;
            // 
            // carrerasTableAdapter
            // 
            this.carrerasTableAdapter.ClearBeforeFill = true;
            // 
            // lblOpciones
            // 
            this.lblOpciones.AutoSize = true;
            this.lblOpciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpciones.Location = new System.Drawing.Point(12, 24);
            this.lblOpciones.Name = "lblOpciones";
            this.lblOpciones.Size = new System.Drawing.Size(130, 18);
            this.lblOpciones.TabIndex = 4;
            this.lblOpciones.Text = "Opciones Carrera:";
            // 
            // rbtBaja
            // 
            this.rbtBaja.AutoSize = true;
            this.rbtBaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtBaja.Location = new System.Drawing.Point(257, 24);
            this.rbtBaja.Name = "rbtBaja";
            this.rbtBaja.Size = new System.Drawing.Size(58, 22);
            this.rbtBaja.TabIndex = 1;
            this.rbtBaja.TabStop = true;
            this.rbtBaja.Text = "Baja";
            this.rbtBaja.UseVisualStyleBackColor = true;
            // 
            // rbtActiva
            // 
            this.rbtActiva.AutoSize = true;
            this.rbtActiva.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtActiva.Location = new System.Drawing.Point(168, 24);
            this.rbtActiva.Name = "rbtActiva";
            this.rbtActiva.Size = new System.Drawing.Size(68, 22);
            this.rbtActiva.TabIndex = 0;
            this.rbtActiva.TabStop = true;
            this.rbtActiva.Text = "Activa";
            this.rbtActiva.UseVisualStyleBackColor = true;
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(773, 24);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(89, 35);
            this.btnGenerar.TabIndex = 2;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            // 
            // FrmReporteCarreras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 580);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.rbtActiva);
            this.Controls.Add(this.rbtBaja);
            this.Controls.Add(this.lblOpciones);
            this.Controls.Add(this.rptCarreras);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmReporteCarreras";
            this.Text = "Reporte de Carreras";
            this.Load += new System.EventHandler(this.FrmReporteCarreras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.carrerasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carrerasListado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Microsoft.Reporting.WinForms.ReportViewer rptCarreras;
        private CarrerasListado carrerasListado;
        private System.Windows.Forms.BindingSource carrerasBindingSource;
        private CarrerasListadoTableAdapters.CarrerasTableAdapter carrerasTableAdapter;
        private System.Windows.Forms.Label lblOpciones;
        private System.Windows.Forms.RadioButton rbtBaja;
        private System.Windows.Forms.RadioButton rbtActiva;
        private System.Windows.Forms.Button btnGenerar;
    }
}