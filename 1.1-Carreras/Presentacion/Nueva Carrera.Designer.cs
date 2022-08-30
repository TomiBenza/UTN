namespace _1._1_Carreras
{
    partial class FrmNueva_Carrera
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNueva_Carrera));
            this.LblNuevaCarrera = new System.Windows.Forms.Label();
            this.LblNombre = new System.Windows.Forms.Label();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.LblCuatrimestre = new System.Windows.Forms.Label();
            this.LblAsignaturas = new System.Windows.Forms.Label();
            this.LblAnio = new System.Windows.Forms.Label();
            this.rbtPrimero = new System.Windows.Forms.RadioButton();
            this.rbtSegundo = new System.Windows.Forms.RadioButton();
            this.cboAsignaturas = new System.Windows.Forms.ComboBox();
            this.dgvDetalle = new System.Windows.Forms.DataGridView();
            this.ClmID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmAsignatura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmCuatrimestre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmAnio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmAcciones = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtAnioCursado = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // LblNuevaCarrera
            // 
            this.LblNuevaCarrera.AutoSize = true;
            this.LblNuevaCarrera.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNuevaCarrera.Location = new System.Drawing.Point(40, 35);
            this.LblNuevaCarrera.Name = "LblNuevaCarrera";
            this.LblNuevaCarrera.Size = new System.Drawing.Size(148, 25);
            this.LblNuevaCarrera.TabIndex = 10;
            this.LblNuevaCarrera.Text = "Nueva carrera";
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Location = new System.Drawing.Point(65, 87);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(56, 16);
            this.LblNombre.TabIndex = 11;
            this.LblNombre.Text = "Nombre";
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Location = new System.Drawing.Point(65, 131);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(40, 16);
            this.LblTitulo.TabIndex = 12;
            this.LblTitulo.Text = "Titulo";
            // 
            // LblCuatrimestre
            // 
            this.LblCuatrimestre.AutoSize = true;
            this.LblCuatrimestre.Location = new System.Drawing.Point(318, 207);
            this.LblCuatrimestre.Name = "LblCuatrimestre";
            this.LblCuatrimestre.Size = new System.Drawing.Size(85, 16);
            this.LblCuatrimestre.TabIndex = 14;
            this.LblCuatrimestre.Text = "Cuatrimestre:";
            // 
            // LblAsignaturas
            // 
            this.LblAsignaturas.AutoSize = true;
            this.LblAsignaturas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAsignaturas.Location = new System.Drawing.Point(49, 176);
            this.LblAsignaturas.Name = "LblAsignaturas";
            this.LblAsignaturas.Size = new System.Drawing.Size(101, 18);
            this.LblAsignaturas.TabIndex = 13;
            this.LblAsignaturas.Text = "Asignaturas:";
            // 
            // LblAnio
            // 
            this.LblAnio.AutoSize = true;
            this.LblAnio.Location = new System.Drawing.Point(509, 209);
            this.LblAnio.Name = "LblAnio";
            this.LblAnio.Size = new System.Drawing.Size(86, 16);
            this.LblAnio.TabIndex = 15;
            this.LblAnio.Text = "Año cursado:";
            // 
            // rbtPrimero
            // 
            this.rbtPrimero.AutoSize = true;
            this.rbtPrimero.Location = new System.Drawing.Point(409, 206);
            this.rbtPrimero.Name = "rbtPrimero";
            this.rbtPrimero.Size = new System.Drawing.Size(39, 20);
            this.rbtPrimero.TabIndex = 3;
            this.rbtPrimero.Text = "1°";
            this.rbtPrimero.UseVisualStyleBackColor = true;
            // 
            // rbtSegundo
            // 
            this.rbtSegundo.AutoSize = true;
            this.rbtSegundo.Location = new System.Drawing.Point(454, 207);
            this.rbtSegundo.Name = "rbtSegundo";
            this.rbtSegundo.Size = new System.Drawing.Size(39, 20);
            this.rbtSegundo.TabIndex = 4;
            this.rbtSegundo.Text = "2°";
            this.rbtSegundo.UseVisualStyleBackColor = true;
            // 
            // cboAsignaturas
            // 
            this.cboAsignaturas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAsignaturas.FormattingEnabled = true;
            this.cboAsignaturas.Location = new System.Drawing.Point(52, 204);
            this.cboAsignaturas.Name = "cboAsignaturas";
            this.cboAsignaturas.Size = new System.Drawing.Size(260, 24);
            this.cboAsignaturas.TabIndex = 0;
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
            this.ClmAnio,
            this.ClmAcciones});
            this.dgvDetalle.Location = new System.Drawing.Point(52, 238);
            this.dgvDetalle.Name = "dgvDetalle";
            this.dgvDetalle.ReadOnly = true;
            this.dgvDetalle.RowHeadersWidth = 51;
            this.dgvDetalle.RowTemplate.Height = 24;
            this.dgvDetalle.Size = new System.Drawing.Size(683, 150);
            this.dgvDetalle.TabIndex = 7;
            this.dgvDetalle.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetalle_CellContentClick);
            // 
            // ClmID
            // 
            this.ClmID.Frozen = true;
            this.ClmID.HeaderText = "ID";
            this.ClmID.MinimumWidth = 6;
            this.ClmID.Name = "ClmID";
            this.ClmID.ReadOnly = true;
            this.ClmID.Visible = false;
            this.ClmID.Width = 125;
            // 
            // ClmAsignatura
            // 
            this.ClmAsignatura.Frozen = true;
            this.ClmAsignatura.HeaderText = "Asignatura";
            this.ClmAsignatura.MinimumWidth = 6;
            this.ClmAsignatura.Name = "ClmAsignatura";
            this.ClmAsignatura.ReadOnly = true;
            this.ClmAsignatura.Width = 125;
            // 
            // ClmCuatrimestre
            // 
            this.ClmCuatrimestre.Frozen = true;
            this.ClmCuatrimestre.HeaderText = "Cuatrimestre";
            this.ClmCuatrimestre.MinimumWidth = 6;
            this.ClmCuatrimestre.Name = "ClmCuatrimestre";
            this.ClmCuatrimestre.ReadOnly = true;
            this.ClmCuatrimestre.Width = 125;
            // 
            // ClmAnio
            // 
            this.ClmAnio.Frozen = true;
            this.ClmAnio.HeaderText = "Año";
            this.ClmAnio.MinimumWidth = 6;
            this.ClmAnio.Name = "ClmAnio";
            this.ClmAnio.ReadOnly = true;
            this.ClmAnio.Width = 125;
            // 
            // ClmAcciones
            // 
            this.ClmAcciones.Frozen = true;
            this.ClmAcciones.HeaderText = "Acciones";
            this.ClmAcciones.MinimumWidth = 6;
            this.ClmAcciones.Name = "ClmAcciones";
            this.ClmAcciones.ReadOnly = true;
            this.ClmAcciones.Text = "Eliminar";
            this.ClmAcciones.UseColumnTextForButtonValue = true;
            this.ClmAcciones.Width = 125;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(640, 198);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(95, 34);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(442, 394);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(98, 44);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(127, 87);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(276, 22);
            this.txtNombre.TabIndex = 1;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(127, 128);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(276, 22);
            this.txtTitulo.TabIndex = 2;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(286, 394);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(98, 44);
            this.btnAceptar.TabIndex = 8;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtAnioCursado
            // 
            this.txtAnioCursado.Location = new System.Drawing.Point(595, 207);
            this.txtAnioCursado.Name = "txtAnioCursado";
            this.txtAnioCursado.Size = new System.Drawing.Size(39, 22);
            this.txtAnioCursado.TabIndex = 5;
            // 
            // FrmNueva_Carrera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtAnioCursado);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvDetalle);
            this.Controls.Add(this.cboAsignaturas);
            this.Controls.Add(this.rbtSegundo);
            this.Controls.Add(this.rbtPrimero);
            this.Controls.Add(this.LblAnio);
            this.Controls.Add(this.LblAsignaturas);
            this.Controls.Add(this.LblCuatrimestre);
            this.Controls.Add(this.LblTitulo);
            this.Controls.Add(this.LblNombre);
            this.Controls.Add(this.LblNuevaCarrera);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmNueva_Carrera";
            this.Text = "Nueva Carrera";
            this.Load += new System.EventHandler(this.FrmNueva_Carrera_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblNuevaCarrera;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.Label LblCuatrimestre;
        private System.Windows.Forms.Label LblAsignaturas;
        private System.Windows.Forms.Label LblAnio;
        private System.Windows.Forms.RadioButton rbtPrimero;
        private System.Windows.Forms.RadioButton rbtSegundo;
        private System.Windows.Forms.ComboBox cboAsignaturas;
        private System.Windows.Forms.DataGridView dgvDetalle;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox txtAnioCursado;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmAsignatura;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmCuatrimestre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmAnio;
        private System.Windows.Forms.DataGridViewButtonColumn ClmAcciones;
    }
}