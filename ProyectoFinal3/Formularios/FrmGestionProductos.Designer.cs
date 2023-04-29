namespace ProyectoFinal3.Formularios
{
    partial class FrmGestionProductos
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
            this.label1 = new System.Windows.Forms.Label();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.CboxVerActivos = new System.Windows.Forms.CheckBox();
            this.DgLista = new System.Windows.Forms.DataGridView();
            this.CProductoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CProductoNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CProductoCostoUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCategoriaProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CActivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCategoriaDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CbcategoriaProducto = new System.Windows.Forms.ComboBox();
            this.TxtTamanio = new System.Windows.Forms.TextBox();
            this.TxtImportacionID = new System.Windows.Forms.TextBox();
            this.TxtProductoCosto = new System.Windows.Forms.TextBox();
            this.TxtProductoColor = new System.Windows.Forms.TextBox();
            this.TxtProductoNombre = new System.Windows.Forms.TextBox();
            this.TxtProductoID = new System.Windows.Forms.TextBox();
            this.lblmportacionID = new System.Windows.Forms.Label();
            this.TxtcategoriaProducto = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ProductoTamanio = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ProductoID = new System.Windows.Forms.Label();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnModifiar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgLista)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar";
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.ForeColor = System.Drawing.Color.Lime;
            this.TxtBuscar.Location = new System.Drawing.Point(116, 33);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(301, 20);
            this.TxtBuscar.TabIndex = 1;
            this.TxtBuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtBuscar.TextChanged += new System.EventHandler(this.TxtBuscar_TextChanged);
            // 
            // CboxVerActivos
            // 
            this.CboxVerActivos.AutoSize = true;
            this.CboxVerActivos.Checked = true;
            this.CboxVerActivos.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CboxVerActivos.Location = new System.Drawing.Point(500, 34);
            this.CboxVerActivos.Name = "CboxVerActivos";
            this.CboxVerActivos.Size = new System.Drawing.Size(131, 17);
            this.CboxVerActivos.TabIndex = 2;
            this.CboxVerActivos.Text = "Ver Productos Activos";
            this.CboxVerActivos.UseVisualStyleBackColor = true;
            this.CboxVerActivos.CheckedChanged += new System.EventHandler(this.CboxVerActivos_CheckedChanged);
            // 
            // DgLista
            // 
            this.DgLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CProductoID,
            this.CProductoNombre,
            this.CProductoCostoUnitario,
            this.CCategoriaProducto,
            this.CActivo,
            this.CCategoriaDescripcion});
            this.DgLista.Location = new System.Drawing.Point(27, 90);
            this.DgLista.MultiSelect = false;
            this.DgLista.Name = "DgLista";
            this.DgLista.RowHeadersVisible = false;
            this.DgLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgLista.Size = new System.Drawing.Size(673, 171);
            this.DgLista.TabIndex = 3;
            this.DgLista.VirtualMode = true;
            this.DgLista.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgLista_CellClick);
            this.DgLista.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DgLista_DataBindingComplete);
            // 
            // CProductoID
            // 
            this.CProductoID.DataPropertyName = "ProductoID";
            this.CProductoID.FillWeight = 180F;
            this.CProductoID.HeaderText = "Cod.Producto";
            this.CProductoID.Name = "CProductoID";
            this.CProductoID.Width = 180;
            // 
            // CProductoNombre
            // 
            this.CProductoNombre.DataPropertyName = "ProductoNombre";
            this.CProductoNombre.FillWeight = 150F;
            this.CProductoNombre.HeaderText = "Nombre";
            this.CProductoNombre.Name = "CProductoNombre";
            // 
            // CProductoCostoUnitario
            // 
            this.CProductoCostoUnitario.DataPropertyName = "ProductoCostoUnitario";
            this.CProductoCostoUnitario.HeaderText = "Costo";
            this.CProductoCostoUnitario.Name = "CProductoCostoUnitario";
            // 
            // CCategoriaProducto
            // 
            this.CCategoriaProducto.DataPropertyName = "CategoriaProducto";
            this.CCategoriaProducto.HeaderText = "Categoria";
            this.CCategoriaProducto.Name = "CCategoriaProducto";
            // 
            // CActivo
            // 
            this.CActivo.DataPropertyName = "Activo";
            this.CActivo.HeaderText = "Activo";
            this.CActivo.Name = "CActivo";
            // 
            // CCategoriaDescripcion
            // 
            this.CCategoriaDescripcion.DataPropertyName = "CategoriaDescripcion";
            this.CCategoriaDescripcion.HeaderText = "Descripcion";
            this.CCategoriaDescripcion.Name = "CCategoriaDescripcion";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CbcategoriaProducto);
            this.groupBox1.Controls.Add(this.TxtTamanio);
            this.groupBox1.Controls.Add(this.TxtImportacionID);
            this.groupBox1.Controls.Add(this.TxtProductoCosto);
            this.groupBox1.Controls.Add(this.TxtProductoColor);
            this.groupBox1.Controls.Add(this.TxtProductoNombre);
            this.groupBox1.Controls.Add(this.TxtProductoID);
            this.groupBox1.Controls.Add(this.lblmportacionID);
            this.groupBox1.Controls.Add(this.TxtcategoriaProducto);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.ProductoTamanio);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.ProductoID);
            this.groupBox1.Location = new System.Drawing.Point(45, 301);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(655, 193);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalle de Producto";
            // 
            // CbcategoriaProducto
            // 
            this.CbcategoriaProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbcategoriaProducto.FormattingEnabled = true;
            this.CbcategoriaProducto.Location = new System.Drawing.Point(509, 71);
            this.CbcategoriaProducto.Name = "CbcategoriaProducto";
            this.CbcategoriaProducto.Size = new System.Drawing.Size(121, 21);
            this.CbcategoriaProducto.TabIndex = 17;
            // 
            // TxtTamanio
            // 
            this.TxtTamanio.Location = new System.Drawing.Point(79, 155);
            this.TxtTamanio.Name = "TxtTamanio";
            this.TxtTamanio.Size = new System.Drawing.Size(152, 20);
            this.TxtTamanio.TabIndex = 16;
            this.TxtTamanio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tamanio_KeyPress);
            // 
            // TxtImportacionID
            // 
            this.TxtImportacionID.Location = new System.Drawing.Point(443, 123);
            this.TxtImportacionID.Name = "TxtImportacionID";
            this.TxtImportacionID.Size = new System.Drawing.Size(152, 20);
            this.TxtImportacionID.TabIndex = 13;
            this.TxtImportacionID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ImportacionID_KeyPress);
            // 
            // TxtProductoCosto
            // 
            this.TxtProductoCosto.Location = new System.Drawing.Point(394, 37);
            this.TxtProductoCosto.Name = "TxtProductoCosto";
            this.TxtProductoCosto.Size = new System.Drawing.Size(155, 20);
            this.TxtProductoCosto.TabIndex = 11;
            this.TxtProductoCosto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtProductoCosto_KeyPress);
            // 
            // TxtProductoColor
            // 
            this.TxtProductoColor.Location = new System.Drawing.Point(73, 112);
            this.TxtProductoColor.Name = "TxtProductoColor";
            this.TxtProductoColor.Size = new System.Drawing.Size(158, 20);
            this.TxtProductoColor.TabIndex = 9;
            this.TxtProductoColor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtProductoColor_KeyPress);
            // 
            // TxtProductoNombre
            // 
            this.TxtProductoNombre.Location = new System.Drawing.Point(92, 73);
            this.TxtProductoNombre.Name = "TxtProductoNombre";
            this.TxtProductoNombre.Size = new System.Drawing.Size(139, 20);
            this.TxtProductoNombre.TabIndex = 8;
            this.TxtProductoNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtProductoNombre_KeyPress);
            // 
            // TxtProductoID
            // 
            this.TxtProductoID.Location = new System.Drawing.Point(143, 29);
            this.TxtProductoID.Name = "TxtProductoID";
            this.TxtProductoID.ReadOnly = true;
            this.TxtProductoID.Size = new System.Drawing.Size(144, 20);
            this.TxtProductoID.TabIndex = 7;
            this.TxtProductoID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblmportacionID
            // 
            this.lblmportacionID.AutoSize = true;
            this.lblmportacionID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmportacionID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblmportacionID.Location = new System.Drawing.Point(323, 121);
            this.lblmportacionID.Name = "lblmportacionID";
            this.lblmportacionID.Size = new System.Drawing.Size(110, 20);
            this.lblmportacionID.TabIndex = 6;
            this.lblmportacionID.Text = "ImportacionID";
            this.lblmportacionID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtcategoriaProducto
            // 
            this.TxtcategoriaProducto.AutoSize = true;
            this.TxtcategoriaProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtcategoriaProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.TxtcategoriaProducto.Location = new System.Drawing.Point(333, 73);
            this.TxtcategoriaProducto.Name = "TxtcategoriaProducto";
            this.TxtcategoriaProducto.Size = new System.Drawing.Size(146, 20);
            this.TxtcategoriaProducto.TabIndex = 5;
            this.TxtcategoriaProducto.Text = "Categoria Producto";
            this.TxtcategoriaProducto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label6.Location = new System.Drawing.Point(337, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Costo";
            // 
            // ProductoTamanio
            // 
            this.ProductoTamanio.AutoSize = true;
            this.ProductoTamanio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductoTamanio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ProductoTamanio.Location = new System.Drawing.Point(6, 155);
            this.ProductoTamanio.Name = "ProductoTamanio";
            this.ProductoTamanio.Size = new System.Drawing.Size(67, 20);
            this.ProductoTamanio.TabIndex = 3;
            this.ProductoTamanio.Text = "Tamaño";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(21, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Color";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(21, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nombre";
            // 
            // ProductoID
            // 
            this.ProductoID.AutoSize = true;
            this.ProductoID.BackColor = System.Drawing.SystemColors.Control;
            this.ProductoID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductoID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ProductoID.Location = new System.Drawing.Point(6, 27);
            this.ProductoID.Name = "ProductoID";
            this.ProductoID.Size = new System.Drawing.Size(131, 20);
            this.ProductoID.TabIndex = 0;
            this.ProductoID.Text = "Codigo Producto:";
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackColor = System.Drawing.Color.Lime;
            this.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregar.ForeColor = System.Drawing.Color.White;
            this.BtnAgregar.Location = new System.Drawing.Point(124, 514);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(75, 33);
            this.BtnAgregar.TabIndex = 5;
            this.BtnAgregar.Text = "AGREGAR";
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // BtnModifiar
            // 
            this.BtnModifiar.BackColor = System.Drawing.Color.Coral;
            this.BtnModifiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnModifiar.ForeColor = System.Drawing.Color.White;
            this.BtnModifiar.Location = new System.Drawing.Point(218, 514);
            this.BtnModifiar.Name = "BtnModifiar";
            this.BtnModifiar.Size = new System.Drawing.Size(75, 33);
            this.BtnModifiar.TabIndex = 6;
            this.BtnModifiar.Text = "MODIFICAR";
            this.BtnModifiar.UseVisualStyleBackColor = false;
            this.BtnModifiar.Click += new System.EventHandler(this.BtnModifiar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.Red;
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminar.ForeColor = System.Drawing.Color.White;
            this.BtnEliminar.Location = new System.Drawing.Point(314, 514);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(75, 33);
            this.BtnEliminar.TabIndex = 7;
            this.BtnEliminar.Text = "ELIMINAR";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.BackColor = System.Drawing.Color.DarkOrange;
            this.BtnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLimpiar.ForeColor = System.Drawing.Color.White;
            this.BtnLimpiar.Location = new System.Drawing.Point(423, 514);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(75, 33);
            this.BtnLimpiar.TabIndex = 9;
            this.BtnLimpiar.Text = "LIMPIAR";
            this.BtnLimpiar.UseVisualStyleBackColor = false;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.ForeColor = System.Drawing.Color.White;
            this.BtnCancelar.Location = new System.Drawing.Point(530, 514);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(75, 33);
            this.BtnCancelar.TabIndex = 11;
            this.BtnCancelar.Text = "CANCELAR";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // FrmGestionProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 559);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnModifiar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DgLista);
            this.Controls.Add(this.CboxVerActivos);
            this.Controls.Add(this.TxtBuscar);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "FrmGestionProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.FrmGestionProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgLista)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.CheckBox CboxVerActivos;
        private System.Windows.Forms.DataGridView DgLista;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtImportacionID;
        private System.Windows.Forms.TextBox TxtProductoCosto;
        private System.Windows.Forms.TextBox TxtProductoColor;
        private System.Windows.Forms.TextBox TxtProductoNombre;
        private System.Windows.Forms.TextBox TxtProductoID;
        private System.Windows.Forms.Label lblmportacionID;
        private System.Windows.Forms.Label TxtcategoriaProducto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label ProductoTamanio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label ProductoID;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnModifiar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.TextBox TxtTamanio;
        private System.Windows.Forms.ComboBox CbcategoriaProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn CProductoID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CProductoNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn CProductoCostoUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCategoriaProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn CActivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCategoriaDescripcion;
    }
}