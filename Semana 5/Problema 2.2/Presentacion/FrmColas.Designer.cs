namespace Problema_2._2
{
    partial class FrmCola
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstProductos = new System.Windows.Forms.ListBox();
            this.btnCheckear = new System.Windows.Forms.Button();
            this.btnExtraer = new System.Windows.Forms.Button();
            this.btnAniadir = new System.Windows.Forms.Button();
            this.btnPrimero = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstProductos
            // 
            this.lstProductos.FormattingEnabled = true;
            this.lstProductos.ItemHeight = 16;
            this.lstProductos.Location = new System.Drawing.Point(154, 22);
            this.lstProductos.Name = "lstProductos";
            this.lstProductos.Size = new System.Drawing.Size(201, 260);
            this.lstProductos.TabIndex = 0;
            // 
            // btnCheckear
            // 
            this.btnCheckear.Location = new System.Drawing.Point(32, 22);
            this.btnCheckear.Name = "btnCheckear";
            this.btnCheckear.Size = new System.Drawing.Size(93, 35);
            this.btnCheckear.TabIndex = 1;
            this.btnCheckear.Text = "Checkear";
            this.btnCheckear.UseVisualStyleBackColor = true;
            this.btnCheckear.Click += new System.EventHandler(this.btnCheckear_Click);
            // 
            // btnExtraer
            // 
            this.btnExtraer.Location = new System.Drawing.Point(32, 247);
            this.btnExtraer.Name = "btnExtraer";
            this.btnExtraer.Size = new System.Drawing.Size(93, 35);
            this.btnExtraer.TabIndex = 2;
            this.btnExtraer.Text = "Extraer";
            this.btnExtraer.UseVisualStyleBackColor = true;
            this.btnExtraer.Click += new System.EventHandler(this.btnExtraer_Click);
            // 
            // btnAniadir
            // 
            this.btnAniadir.Location = new System.Drawing.Point(32, 172);
            this.btnAniadir.Name = "btnAniadir";
            this.btnAniadir.Size = new System.Drawing.Size(93, 35);
            this.btnAniadir.TabIndex = 3;
            this.btnAniadir.Text = "Añadir";
            this.btnAniadir.UseVisualStyleBackColor = true;
            this.btnAniadir.Click += new System.EventHandler(this.btnAniadir_Click);
            // 
            // btnPrimero
            // 
            this.btnPrimero.Location = new System.Drawing.Point(32, 97);
            this.btnPrimero.Name = "btnPrimero";
            this.btnPrimero.Size = new System.Drawing.Size(93, 35);
            this.btnPrimero.TabIndex = 4;
            this.btnPrimero.Text = "Primero";
            this.btnPrimero.UseVisualStyleBackColor = true;
            this.btnPrimero.Click += new System.EventHandler(this.btnPrimero_Click);
            // 
            // FrmCola
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 294);
            this.Controls.Add(this.btnPrimero);
            this.Controls.Add(this.btnAniadir);
            this.Controls.Add(this.btnExtraer);
            this.Controls.Add(this.btnCheckear);
            this.Controls.Add(this.lstProductos);
            this.Name = "FrmCola";
            this.Text = "Colas";
            this.Load += new System.EventHandler(this.FrmCola_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstProductos;
        private System.Windows.Forms.Button btnCheckear;
        private System.Windows.Forms.Button btnExtraer;
        private System.Windows.Forms.Button btnAniadir;
        private System.Windows.Forms.Button btnPrimero;
    }
}

