namespace RecetasSLN.presentación
{
    partial class FrmAltaReceta
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
            this.lblRecetaNro = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCheff = new System.Windows.Forms.Label();
            this.lblTipoReceta = new System.Windows.Forms.Label();
            this.lblCantidadIng = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCheff = new System.Windows.Forms.TextBox();
            this.cboTipoRecetas = new System.Windows.Forms.ComboBox();
            this.dgvDetalles = new System.Windows.Forms.DataGridView();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.cboIngredientes = new System.Windows.Forms.ComboBox();
            this.numericUDIngredientes = new System.Windows.Forms.NumericUpDown();
            this.ClmID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmIngrediente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmAcciones = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUDIngredientes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRecetaNro
            // 
            this.lblRecetaNro.AutoSize = true;
            this.lblRecetaNro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecetaNro.Location = new System.Drawing.Point(17, 28);
            this.lblRecetaNro.Name = "lblRecetaNro";
            this.lblRecetaNro.Size = new System.Drawing.Size(104, 25);
            this.lblRecetaNro.TabIndex = 0;
            this.lblRecetaNro.Text = "Receta #:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(48, 104);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(59, 16);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblCheff
            // 
            this.lblCheff.AutoSize = true;
            this.lblCheff.Location = new System.Drawing.Point(67, 134);
            this.lblCheff.Name = "lblCheff";
            this.lblCheff.Size = new System.Drawing.Size(40, 16);
            this.lblCheff.TabIndex = 2;
            this.lblCheff.Text = "Cheff:";
            // 
            // lblTipoReceta
            // 
            this.lblTipoReceta.AutoSize = true;
            this.lblTipoReceta.Location = new System.Drawing.Point(9, 166);
            this.lblTipoReceta.Name = "lblTipoReceta";
            this.lblTipoReceta.Size = new System.Drawing.Size(98, 16);
            this.lblTipoReceta.TabIndex = 3;
            this.lblTipoReceta.Text = "Tipo de receta:";
            // 
            // lblCantidadIng
            // 
            this.lblCantidadIng.AutoSize = true;
            this.lblCantidadIng.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadIng.Location = new System.Drawing.Point(326, 377);
            this.lblCantidadIng.Name = "lblCantidadIng";
            this.lblCantidadIng.Size = new System.Drawing.Size(137, 16);
            this.lblCantidadIng.TabIndex = 4;
            this.lblCantidadIng.Text = "Total de ingredientes:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(126, 101);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(353, 22);
            this.txtNombre.TabIndex = 0;
            // 
            // txtCheff
            // 
            this.txtCheff.Location = new System.Drawing.Point(126, 131);
            this.txtCheff.Name = "txtCheff";
            this.txtCheff.Size = new System.Drawing.Size(353, 22);
            this.txtCheff.TabIndex = 1;
            // 
            // cboTipoRecetas
            // 
            this.cboTipoRecetas.FormattingEnabled = true;
            this.cboTipoRecetas.Location = new System.Drawing.Point(126, 162);
            this.cboTipoRecetas.Name = "cboTipoRecetas";
            this.cboTipoRecetas.Size = new System.Drawing.Size(261, 24);
            this.cboTipoRecetas.TabIndex = 2;
            // 
            // dgvDetalles
            // 
            this.dgvDetalles.AllowUserToAddRows = false;
            this.dgvDetalles.AllowUserToDeleteRows = false;
            this.dgvDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClmID,
            this.ClmIngrediente,
            this.ClmCantidad,
            this.ClmAcciones});
            this.dgvDetalles.Location = new System.Drawing.Point(22, 232);
            this.dgvDetalles.Name = "dgvDetalles";
            this.dgvDetalles.ReadOnly = true;
            this.dgvDetalles.RowHeadersWidth = 51;
            this.dgvDetalles.RowTemplate.Height = 24;
            this.dgvDetalles.Size = new System.Drawing.Size(508, 142);
            this.dgvDetalles.TabIndex = 6;
            this.dgvDetalles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetalles_CellContentClick);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(160, 405);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(113, 33);
            this.btnAceptar.TabIndex = 8;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(298, 405);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(105, 33);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(450, 194);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(80, 27);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // cboIngredientes
            // 
            this.cboIngredientes.FormattingEnabled = true;
            this.cboIngredientes.Location = new System.Drawing.Point(22, 195);
            this.cboIngredientes.Name = "cboIngredientes";
            this.cboIngredientes.Size = new System.Drawing.Size(207, 24);
            this.cboIngredientes.TabIndex = 3;
            this.cboIngredientes.SelectedIndexChanged += new System.EventHandler(this.cboIngredientes_SelectedIndexChanged);
            // 
            // numericUDIngredientes
            // 
            this.numericUDIngredientes.Location = new System.Drawing.Point(255, 196);
            this.numericUDIngredientes.Name = "numericUDIngredientes";
            this.numericUDIngredientes.Size = new System.Drawing.Size(180, 22);
            this.numericUDIngredientes.TabIndex = 4;
            this.numericUDIngredientes.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ClmID
            // 
            this.ClmID.HeaderText = "ID";
            this.ClmID.MinimumWidth = 6;
            this.ClmID.Name = "ClmID";
            this.ClmID.ReadOnly = true;
            this.ClmID.Visible = false;
            this.ClmID.Width = 20;
            // 
            // ClmIngrediente
            // 
            this.ClmIngrediente.HeaderText = "Ingrediente";
            this.ClmIngrediente.MinimumWidth = 6;
            this.ClmIngrediente.Name = "ClmIngrediente";
            this.ClmIngrediente.ReadOnly = true;
            this.ClmIngrediente.Width = 125;
            // 
            // ClmCantidad
            // 
            this.ClmCantidad.HeaderText = "Cantidad";
            this.ClmCantidad.MinimumWidth = 6;
            this.ClmCantidad.Name = "ClmCantidad";
            this.ClmCantidad.ReadOnly = true;
            this.ClmCantidad.Width = 80;
            // 
            // ClmAcciones
            // 
            this.ClmAcciones.HeaderText = "Acciones";
            this.ClmAcciones.MinimumWidth = 6;
            this.ClmAcciones.Name = "ClmAcciones";
            this.ClmAcciones.ReadOnly = true;
            this.ClmAcciones.Text = "Quitar";
            this.ClmAcciones.UseColumnTextForButtonValue = true;
            this.ClmAcciones.Width = 125;
            // 
            // FrmAltaReceta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 450);
            this.Controls.Add(this.numericUDIngredientes);
            this.Controls.Add(this.cboIngredientes);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.dgvDetalles);
            this.Controls.Add(this.cboTipoRecetas);
            this.Controls.Add(this.txtCheff);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblCantidadIng);
            this.Controls.Add(this.lblTipoReceta);
            this.Controls.Add(this.lblCheff);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblRecetaNro);
            this.Name = "FrmAltaReceta";
            this.Text = "Alta Recetas";
            this.Load += new System.EventHandler(this.FrmAltaReceta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUDIngredientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRecetaNro;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCheff;
        private System.Windows.Forms.Label lblTipoReceta;
        private System.Windows.Forms.Label lblCantidadIng;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCheff;
        private System.Windows.Forms.ComboBox cboTipoRecetas;
        private System.Windows.Forms.DataGridView dgvDetalles;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ComboBox cboIngredientes;
        private System.Windows.Forms.NumericUpDown numericUDIngredientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmIngrediente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmCantidad;
        private System.Windows.Forms.DataGridViewButtonColumn ClmAcciones;
    }
}