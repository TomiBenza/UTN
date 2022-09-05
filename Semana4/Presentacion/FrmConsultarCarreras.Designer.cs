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
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.lblDetalles = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnBorrarC = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblCantCarreras = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.cboAsignaturas = new System.Windows.Forms.ComboBox();
            this.txtAnioCursado = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.rbtSegundo = new System.Windows.Forms.RadioButton();
            this.rbtPrimero = new System.Windows.Forms.RadioButton();
            this.LblAnio = new System.Windows.Forms.Label();
            this.LblCuatrimestre = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.ClmID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmAsignatura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmCuatrimestre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmAnioCursado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmQuitar = new System.Windows.Forms.DataGridViewButtonColumn();
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
            this.ClmCuatrimestre,
            this.ClmAnioCursado,
            this.ClmQuitar});
            this.dgvDetalle.Location = new System.Drawing.Point(327, 247);
            this.dgvDetalle.Name = "dgvDetalle";
            this.dgvDetalle.ReadOnly = true;
            this.dgvDetalle.RowHeadersWidth = 51;
            this.dgvDetalle.RowTemplate.Height = 24;
            this.dgvDetalle.Size = new System.Drawing.Size(608, 201);
            this.dgvDetalle.TabIndex = 11;
            this.dgvDetalle.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetalle_CellContentClick);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(325, 90);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(59, 16);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(341, 126);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(43, 16);
            this.lblTitulo.TabIndex = 4;
            this.lblTitulo.Text = "Titulo:";
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Location = new System.Drawing.Point(392, 87);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(291, 22);
            this.txtNombre.TabIndex = 4;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Enabled = false;
            this.txtTitulo.Location = new System.Drawing.Point(392, 123);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(291, 22);
            this.txtTitulo.TabIndex = 5;
            // 
            // lblDetalles
            // 
            this.lblDetalles.AutoSize = true;
            this.lblDetalles.Location = new System.Drawing.Point(324, 187);
            this.lblDetalles.Name = "lblDetalles";
            this.lblDetalles.Size = new System.Drawing.Size(60, 16);
            this.lblDetalles.TabIndex = 7;
            this.lblDetalles.Text = "Detalles:";
            this.lblDetalles.Click += new System.EventHandler(this.lblDetalles_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(847, 486);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(87, 35);
            this.btnSalir.TabIndex = 13;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnBorrarC
            // 
            this.btnBorrarC.Location = new System.Drawing.Point(158, 486);
            this.btnBorrarC.Name = "btnBorrarC";
            this.btnBorrarC.Size = new System.Drawing.Size(119, 35);
            this.btnBorrarC.TabIndex = 2;
            this.btnBorrarC.Text = "Borrar Carrera";
            this.btnBorrarC.UseVisualStyleBackColor = true;
            this.btnBorrarC.Click += new System.EventHandler(this.btnBorrarC_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(736, 486);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(87, 35);
            this.btnCancelar.TabIndex = 3;
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
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(47, 486);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(87, 35);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // cboAsignaturas
            // 
            this.cboAsignaturas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAsignaturas.FormattingEnabled = true;
            this.cboAsignaturas.Location = new System.Drawing.Point(327, 216);
            this.cboAsignaturas.Name = "cboAsignaturas";
            this.cboAsignaturas.Size = new System.Drawing.Size(176, 24);
            this.cboAsignaturas.TabIndex = 6;
            // 
            // txtAnioCursado
            // 
            this.txtAnioCursado.Location = new System.Drawing.Point(792, 217);
            this.txtAnioCursado.Name = "txtAnioCursado";
            this.txtAnioCursado.Size = new System.Drawing.Size(42, 22);
            this.txtAnioCursado.TabIndex = 9;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(840, 207);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(95, 33);
            this.btnAgregar.TabIndex = 10;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // rbtSegundo
            // 
            this.rbtSegundo.AutoSize = true;
            this.rbtSegundo.Location = new System.Drawing.Point(644, 218);
            this.rbtSegundo.Name = "rbtSegundo";
            this.rbtSegundo.Size = new System.Drawing.Size(39, 20);
            this.rbtSegundo.TabIndex = 8;
            this.rbtSegundo.Text = "2°";
            this.rbtSegundo.UseVisualStyleBackColor = true;
            // 
            // rbtPrimero
            // 
            this.rbtPrimero.AutoSize = true;
            this.rbtPrimero.Location = new System.Drawing.Point(599, 218);
            this.rbtPrimero.Name = "rbtPrimero";
            this.rbtPrimero.Size = new System.Drawing.Size(39, 20);
            this.rbtPrimero.TabIndex = 7;
            this.rbtPrimero.Text = "1°";
            this.rbtPrimero.UseVisualStyleBackColor = true;
            // 
            // LblAnio
            // 
            this.LblAnio.AutoSize = true;
            this.LblAnio.Location = new System.Drawing.Point(700, 220);
            this.LblAnio.Name = "LblAnio";
            this.LblAnio.Size = new System.Drawing.Size(86, 16);
            this.LblAnio.TabIndex = 21;
            this.LblAnio.Text = "Año cursado:";
            // 
            // LblCuatrimestre
            // 
            this.LblCuatrimestre.AutoSize = true;
            this.LblCuatrimestre.Location = new System.Drawing.Point(508, 220);
            this.LblCuatrimestre.Name = "LblCuatrimestre";
            this.LblCuatrimestre.Size = new System.Drawing.Size(85, 16);
            this.LblCuatrimestre.TabIndex = 20;
            this.LblCuatrimestre.Text = "Cuatrimestre:";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(625, 486);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(87, 35);
            this.btnAceptar.TabIndex = 12;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
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
            // ClmCuatrimestre
            // 
            this.ClmCuatrimestre.HeaderText = "Cuatrimestre";
            this.ClmCuatrimestre.MinimumWidth = 6;
            this.ClmCuatrimestre.Name = "ClmCuatrimestre";
            this.ClmCuatrimestre.ReadOnly = true;
            this.ClmCuatrimestre.Width = 90;
            // 
            // ClmAnioCursado
            // 
            this.ClmAnioCursado.HeaderText = "Año";
            this.ClmAnioCursado.MinimumWidth = 6;
            this.ClmAnioCursado.Name = "ClmAnioCursado";
            this.ClmAnioCursado.ReadOnly = true;
            this.ClmAnioCursado.Width = 60;
            // 
            // ClmQuitar
            // 
            this.ClmQuitar.HeaderText = "Acciones";
            this.ClmQuitar.MinimumWidth = 6;
            this.ClmQuitar.Name = "ClmQuitar";
            this.ClmQuitar.ReadOnly = true;
            this.ClmQuitar.Text = "Quitar";
            this.ClmQuitar.UseColumnTextForButtonValue = true;
            this.ClmQuitar.Width = 125;
            // 
            // FrmConsultarCarreras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 545);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtAnioCursado);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.rbtSegundo);
            this.Controls.Add(this.rbtPrimero);
            this.Controls.Add(this.LblAnio);
            this.Controls.Add(this.LblCuatrimestre);
            this.Controls.Add(this.cboAsignaturas);
            this.Controls.Add(this.btnModificar);
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
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.ComboBox cboAsignaturas;
        private System.Windows.Forms.TextBox txtAnioCursado;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.RadioButton rbtSegundo;
        private System.Windows.Forms.RadioButton rbtPrimero;
        private System.Windows.Forms.Label LblAnio;
        private System.Windows.Forms.Label LblCuatrimestre;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmAsignatura;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmCuatrimestre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmAnioCursado;
        private System.Windows.Forms.DataGridViewButtonColumn ClmQuitar;
    }
}