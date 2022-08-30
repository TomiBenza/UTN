namespace _1._1_Carreras.Presentacion
{
    partial class FrmConsultarCarreras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultarCarreras));
            this.lblCarreras = new System.Windows.Forms.Label();
            this.lstCarreras = new System.Windows.Forms.ListBox();
            this.dgvDetalle = new System.Windows.Forms.DataGridView();
            this.ClmID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmAsignatura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmAnioCursado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmCuatrimestre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.lblDetalles = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnBorrarC = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblCantCarreras = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCarreras
            // 
            this.lblCarreras.AutoSize = true;
            this.lblCarreras.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarreras.Location = new System.Drawing.Point(42, 21);
            this.lblCarreras.Name = "lblCarreras";
            this.lblCarreras.Size = new System.Drawing.Size(111, 26);
            this.lblCarreras.TabIndex = 0;
            this.lblCarreras.Text = "Carreras:";
            // 
            // lstCarreras
            // 
            this.lstCarreras.FormattingEnabled = true;
            this.lstCarreras.ItemHeight = 16;
            this.lstCarreras.Location = new System.Drawing.Point(47, 60);
            this.lstCarreras.Name = "lstCarreras";
            this.lstCarreras.Size = new System.Drawing.Size(230, 388);
            this.lstCarreras.TabIndex = 0;
            this.lstCarreras.SelectedIndexChanged += new System.EventHandler(this.lstCarreras_SelectedIndexChanged);
            // 
            // dgvDetalle
            // 
            this.dgvDetalle.AllowUserToAddRows = false;
            this.dgvDetalle.AllowUserToDeleteRows = false;
            this.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClmID,
            this.ClmAsignatura,
            this.ClmAnioCursado,
            this.ClmCuatrimestre});
            this.dgvDetalle.Location = new System.Drawing.Point(327, 215);
            this.dgvDetalle.Name = "dgvDetalle";
            this.dgvDetalle.ReadOnly = true;
            this.dgvDetalle.RowHeadersWidth = 51;
            this.dgvDetalle.RowTemplate.Height = 24;
            this.dgvDetalle.Size = new System.Drawing.Size(463, 233);
            this.dgvDetalle.TabIndex = 4;
            // 
            // ClmID
            // 
            this.ClmID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ClmID.HeaderText = "ID";
            this.ClmID.MinimumWidth = 6;
            this.ClmID.Name = "ClmID";
            this.ClmID.ReadOnly = true;
            this.ClmID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ClmID.Visible = false;
            // 
            // ClmAsignatura
            // 
            this.ClmAsignatura.HeaderText = "Asignatura";
            this.ClmAsignatura.MinimumWidth = 6;
            this.ClmAsignatura.Name = "ClmAsignatura";
            this.ClmAsignatura.ReadOnly = true;
            this.ClmAsignatura.Width = 125;
            // 
            // ClmAnioCursado
            // 
            this.ClmAnioCursado.HeaderText = "Año";
            this.ClmAnioCursado.MinimumWidth = 6;
            this.ClmAnioCursado.Name = "ClmAnioCursado";
            this.ClmAnioCursado.ReadOnly = true;
            this.ClmAnioCursado.Width = 60;
            // 
            // ClmCuatrimestre
            // 
            this.ClmCuatrimestre.HeaderText = "Cuatrimestre";
            this.ClmCuatrimestre.MinimumWidth = 6;
            this.ClmCuatrimestre.Name = "ClmCuatrimestre";
            this.ClmCuatrimestre.ReadOnly = true;
            this.ClmCuatrimestre.Width = 90;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(324, 90);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(59, 16);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(340, 126);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(43, 16);
            this.lblTitulo.TabIndex = 4;
            this.lblTitulo.Text = "Titulo:";
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Location = new System.Drawing.Point(389, 87);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(401, 22);
            this.txtNombre.TabIndex = 2;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Enabled = false;
            this.txtTitulo.Location = new System.Drawing.Point(389, 123);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(401, 22);
            this.txtTitulo.TabIndex = 3;
            // 
            // lblDetalles
            // 
            this.lblDetalles.AutoSize = true;
            this.lblDetalles.Location = new System.Drawing.Point(324, 196);
            this.lblDetalles.Name = "lblDetalles";
            this.lblDetalles.Size = new System.Drawing.Size(60, 16);
            this.lblDetalles.TabIndex = 7;
            this.lblDetalles.Text = "Detalles:";
            this.lblDetalles.Click += new System.EventHandler(this.lblDetalles_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(708, 486);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(82, 35);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnBorrarC
            // 
            this.btnBorrarC.Location = new System.Drawing.Point(327, 487);
            this.btnBorrarC.Name = "btnBorrarC";
            this.btnBorrarC.Size = new System.Drawing.Size(109, 35);
            this.btnBorrarC.TabIndex = 5;
            this.btnBorrarC.Text = "Borrar Carrera";
            this.btnBorrarC.UseVisualStyleBackColor = true;
            this.btnBorrarC.Click += new System.EventHandler(this.btnBorrarC_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(535, 487);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(82, 35);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblCantCarreras
            // 
            this.lblCantCarreras.AutoSize = true;
            this.lblCantCarreras.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantCarreras.Location = new System.Drawing.Point(44, 451);
            this.lblCantCarreras.Name = "lblCantCarreras";
            this.lblCantCarreras.Size = new System.Drawing.Size(103, 15);
            this.lblCantCarreras.TabIndex = 12;
            this.lblCantCarreras.Text = "Cant. de carreras:";
            this.lblCantCarreras.Click += new System.EventHandler(this.lblCantCarreras_Click);
            // 
            // FrmConsultarCarreras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 545);
            this.Controls.Add(this.lblCantCarreras);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnBorrarC);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblDetalles);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.dgvDetalle);
            this.Controls.Add(this.lstCarreras);
            this.Controls.Add(this.lblCarreras);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmConsultarCarreras";
            this.Text = "Carreras";
            this.Load += new System.EventHandler(this.FrmConsultarCarreras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCarreras;
        private System.Windows.Forms.ListBox lstCarreras;
        private System.Windows.Forms.DataGridView dgvDetalle;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label lblDetalles;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnBorrarC;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblCantCarreras;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmAsignatura;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmAnioCursado;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmCuatrimestre;
    }
}