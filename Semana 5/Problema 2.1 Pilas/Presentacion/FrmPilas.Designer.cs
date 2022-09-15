namespace Problema_2._1_Pilas
{
    partial class FrmPilas
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
            this.btnCheck = new System.Windows.Forms.Button();
            this.btnExtraer = new System.Windows.Forms.Button();
            this.btnPrimero = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lstPilas = new System.Windows.Forms.ListBox();
            this.lblColeccion = new System.Windows.Forms.Label();
            this.lblTamanio = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(33, 29);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(99, 48);
            this.btnCheck.TabIndex = 1;
            this.btnCheck.Text = "Checkear";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnExtraer
            // 
            this.btnExtraer.Location = new System.Drawing.Point(181, 29);
            this.btnExtraer.Name = "btnExtraer";
            this.btnExtraer.Size = new System.Drawing.Size(99, 48);
            this.btnExtraer.TabIndex = 2;
            this.btnExtraer.Text = "Extraer";
            this.btnExtraer.UseVisualStyleBackColor = true;
            this.btnExtraer.Click += new System.EventHandler(this.btnExtraer_Click);
            // 
            // btnPrimero
            // 
            this.btnPrimero.Location = new System.Drawing.Point(329, 29);
            this.btnPrimero.Name = "btnPrimero";
            this.btnPrimero.Size = new System.Drawing.Size(99, 48);
            this.btnPrimero.TabIndex = 3;
            this.btnPrimero.Text = "Primera";
            this.btnPrimero.UseVisualStyleBackColor = true;
            this.btnPrimero.Click += new System.EventHandler(this.btnPrimero_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(477, 29);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(99, 48);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Añadir";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lstPilas
            // 
            this.lstPilas.FormattingEnabled = true;
            this.lstPilas.ItemHeight = 16;
            this.lstPilas.Location = new System.Drawing.Point(33, 118);
            this.lstPilas.Name = "lstPilas";
            this.lstPilas.Size = new System.Drawing.Size(545, 100);
            this.lstPilas.TabIndex = 5;
            // 
            // lblColeccion
            // 
            this.lblColeccion.AutoSize = true;
            this.lblColeccion.Location = new System.Drawing.Point(30, 99);
            this.lblColeccion.Name = "lblColeccion";
            this.lblColeccion.Size = new System.Drawing.Size(70, 16);
            this.lblColeccion.TabIndex = 6;
            this.lblColeccion.Text = "Coleccion:";
            // 
            // lblTamanio
            // 
            this.lblTamanio.AutoSize = true;
            this.lblTamanio.Location = new System.Drawing.Point(30, 221);
            this.lblTamanio.Name = "lblTamanio";
            this.lblTamanio.Size = new System.Drawing.Size(155, 16);
            this.lblTamanio.TabIndex = 7;
            this.lblTamanio.Text = "Max. de pilas permitidas:";
            this.lblTamanio.Click += new System.EventHandler(this.lblTamanio_Click);
            // 
            // FrmPilas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 243);
            this.Controls.Add(this.lblTamanio);
            this.Controls.Add(this.lblColeccion);
            this.Controls.Add(this.lstPilas);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnPrimero);
            this.Controls.Add(this.btnExtraer);
            this.Controls.Add(this.btnCheck);
            this.Name = "FrmPilas";
            this.Text = "Pilas";
            this.Load += new System.EventHandler(this.FrmPilas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button btnExtraer;
        private System.Windows.Forms.Button btnPrimero;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox lstPilas;
        private System.Windows.Forms.Label lblColeccion;
        private System.Windows.Forms.Label lblTamanio;
    }
}

