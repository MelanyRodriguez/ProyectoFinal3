namespace ProyectoFinal3.Formularios
{
    partial class FrmRegistrodeImportaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegistrodeImportaciones));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtMes = new System.Windows.Forms.TextBox();
            this.TxtDia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnBuscarProovedor = new System.Windows.Forms.Button();
            this.TxtProovedorNombre = new System.Windows.Forms.TextBox();
            this.NombreProovedor = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DgvLista = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BtnImportacionAgregar = new System.Windows.Forms.ToolStripButton();
            this.BtnModificarProducto = new System.Windows.Forms.ToolStripButton();
            this.BtnEliminarProducto = new System.Windows.Forms.ToolStripButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BtnCrearImportacion = new System.Windows.Forms.Button();
            this.TxtTotal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtTotalCantidad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CProductoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CProductoTamanio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CProductoNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCostoUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvLista)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtMes);
            this.groupBox1.Controls.Add(this.TxtDia);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.BtnBuscarProovedor);
            this.groupBox1.Controls.Add(this.TxtProovedorNombre);
            this.groupBox1.Controls.Add(this.NombreProovedor);
            this.groupBox1.Location = new System.Drawing.Point(50, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(697, 139);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Encabezado(Tabla Importacion)";
            // 
            // TxtMes
            // 
            this.TxtMes.Location = new System.Drawing.Point(59, 99);
            this.TxtMes.Name = "TxtMes";
            this.TxtMes.Size = new System.Drawing.Size(223, 20);
            this.TxtMes.TabIndex = 6;
            this.TxtMes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtDia
            // 
            this.TxtDia.Location = new System.Drawing.Point(59, 61);
            this.TxtDia.Name = "TxtDia";
            this.TxtDia.Size = new System.Drawing.Size(252, 20);
            this.TxtDia.TabIndex = 5;
            this.TxtDia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "mes:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "dia:";
            // 
            // BtnBuscarProovedor
            // 
            this.BtnBuscarProovedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscarProovedor.Location = new System.Drawing.Point(412, 27);
            this.BtnBuscarProovedor.Name = "BtnBuscarProovedor";
            this.BtnBuscarProovedor.Size = new System.Drawing.Size(75, 23);
            this.BtnBuscarProovedor.TabIndex = 2;
            this.BtnBuscarProovedor.Text = "Buscar";
            this.BtnBuscarProovedor.UseVisualStyleBackColor = true;
            this.BtnBuscarProovedor.Click += new System.EventHandler(this.BtnBuscarProovedor_Click);
            // 
            // TxtProovedorNombre
            // 
            this.TxtProovedorNombre.Location = new System.Drawing.Point(80, 27);
            this.TxtProovedorNombre.Name = "TxtProovedorNombre";
            this.TxtProovedorNombre.ReadOnly = true;
            this.TxtProovedorNombre.Size = new System.Drawing.Size(301, 20);
            this.TxtProovedorNombre.TabIndex = 1;
            // 
            // NombreProovedor
            // 
            this.NombreProovedor.AutoSize = true;
            this.NombreProovedor.Location = new System.Drawing.Point(18, 27);
            this.NombreProovedor.Name = "NombreProovedor";
            this.NombreProovedor.Size = new System.Drawing.Size(59, 13);
            this.NombreProovedor.TabIndex = 0;
            this.NombreProovedor.Text = "Proovedor:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DgvLista);
            this.groupBox2.Controls.Add(this.toolStrip1);
            this.groupBox2.Location = new System.Drawing.Point(50, 200);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(588, 238);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalle(TablaImportacionProducto)";
            // 
            // DgvLista
            // 
            this.DgvLista.AllowUserToAddRows = false;
            this.DgvLista.AllowUserToDeleteRows = false;
            this.DgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CProductoID,
            this.CProductoTamanio,
            this.CProductoNombre,
            this.CCantidad,
            this.CCostoUnitario});
            this.DgvLista.Location = new System.Drawing.Point(21, 64);
            this.DgvLista.Name = "DgvLista";
            this.DgvLista.ReadOnly = true;
            this.DgvLista.RowHeadersVisible = false;
            this.DgvLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvLista.Size = new System.Drawing.Size(516, 150);
            this.DgvLista.TabIndex = 1;
            this.DgvLista.VirtualMode = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnImportacionAgregar,
            this.BtnModificarProducto,
            this.BtnEliminarProducto});
            this.toolStrip1.Location = new System.Drawing.Point(3, 16);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(582, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // BtnImportacionAgregar
            // 
            this.BtnImportacionAgregar.BackColor = System.Drawing.Color.DarkSalmon;
            this.BtnImportacionAgregar.Image = ((System.Drawing.Image)(resources.GetObject("BtnImportacionAgregar.Image")));
            this.BtnImportacionAgregar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnImportacionAgregar.Name = "BtnImportacionAgregar";
            this.BtnImportacionAgregar.Size = new System.Drawing.Size(121, 22);
            this.BtnImportacionAgregar.Text = "Agregar Producto";
            this.BtnImportacionAgregar.Click += new System.EventHandler(this.BtnImportacionAgregar_Click);
            // 
            // BtnModificarProducto
            // 
            this.BtnModificarProducto.BackColor = System.Drawing.Color.LightGreen;
            this.BtnModificarProducto.Image = ((System.Drawing.Image)(resources.GetObject("BtnModificarProducto.Image")));
            this.BtnModificarProducto.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnModificarProducto.Name = "BtnModificarProducto";
            this.BtnModificarProducto.Size = new System.Drawing.Size(130, 22);
            this.BtnModificarProducto.Text = "Modificar Producto";
            // 
            // BtnEliminarProducto
            // 
            this.BtnEliminarProducto.BackColor = System.Drawing.Color.Cyan;
            this.BtnEliminarProducto.Image = ((System.Drawing.Image)(resources.GetObject("BtnEliminarProducto.Image")));
            this.BtnEliminarProducto.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnEliminarProducto.Name = "BtnEliminarProducto";
            this.BtnEliminarProducto.Size = new System.Drawing.Size(122, 22);
            this.BtnEliminarProducto.Text = "Eliminar Producto";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BtnCrearImportacion);
            this.groupBox3.Controls.Add(this.TxtTotal);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.TxtTotalCantidad);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(53, 472);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(694, 181);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "TOTALES";
            // 
            // BtnCrearImportacion
            // 
            this.BtnCrearImportacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnCrearImportacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCrearImportacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCrearImportacion.Location = new System.Drawing.Point(236, 115);
            this.BtnCrearImportacion.Name = "BtnCrearImportacion";
            this.BtnCrearImportacion.Size = new System.Drawing.Size(188, 41);
            this.BtnCrearImportacion.TabIndex = 4;
            this.BtnCrearImportacion.Text = "Crear Importacion";
            this.BtnCrearImportacion.UseVisualStyleBackColor = false;
            this.BtnCrearImportacion.Click += new System.EventHandler(this.BtnCrearImportacion_Click);
            // 
            // TxtTotal
            // 
            this.TxtTotal.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.TxtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTotal.Location = new System.Drawing.Point(291, 58);
            this.TxtTotal.Name = "TxtTotal";
            this.TxtTotal.Size = new System.Drawing.Size(174, 26);
            this.TxtTotal.TabIndex = 3;
            this.TxtTotal.Text = "0";
            this.TxtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(336, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "TOTAL";
            // 
            // TxtTotalCantidad
            // 
            this.TxtTotalCantidad.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.TxtTotalCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTotalCantidad.Location = new System.Drawing.Point(18, 58);
            this.TxtTotalCantidad.Name = "TxtTotalCantidad";
            this.TxtTotalCantidad.Size = new System.Drawing.Size(174, 26);
            this.TxtTotalCantidad.TabIndex = 1;
            this.TxtTotalCantidad.Text = "0";
            this.TxtTotalCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "CANTIDAD ITEMS";
            // 
            // CProductoID
            // 
            this.CProductoID.DataPropertyName = "ProductoID";
            this.CProductoID.HeaderText = "Codigo";
            this.CProductoID.Name = "CProductoID";
            this.CProductoID.ReadOnly = true;
            // 
            // CProductoTamanio
            // 
            this.CProductoTamanio.DataPropertyName = "ProductoTamanio";
            this.CProductoTamanio.HeaderText = "Tamanio";
            this.CProductoTamanio.Name = "CProductoTamanio";
            this.CProductoTamanio.ReadOnly = true;
            // 
            // CProductoNombre
            // 
            this.CProductoNombre.DataPropertyName = "ProductoNombre";
            this.CProductoNombre.HeaderText = "Nombre";
            this.CProductoNombre.Name = "CProductoNombre";
            this.CProductoNombre.ReadOnly = true;
            // 
            // CCantidad
            // 
            this.CCantidad.DataPropertyName = "Cantidad";
            this.CCantidad.HeaderText = "Cantidad";
            this.CCantidad.Name = "CCantidad";
            this.CCantidad.ReadOnly = true;
            // 
            // CCostoUnitario
            // 
            this.CCostoUnitario.DataPropertyName = "CostoUnitario";
            this.CCostoUnitario.HeaderText = "CostoUnitario";
            this.CCostoUnitario.Name = "CCostoUnitario";
            this.CCostoUnitario.ReadOnly = true;
            // 
            // FrmRegistrodeImportaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 665);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmRegistrodeImportaciones";
            this.Text = "RegistrodeImportaciones";
            this.Load += new System.EventHandler(this.FrmRegistrodeImportaciones_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvLista)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtMes;
        private System.Windows.Forms.TextBox TxtDia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnBuscarProovedor;
        private System.Windows.Forms.TextBox TxtProovedorNombre;
        private System.Windows.Forms.Label NombreProovedor;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton BtnImportacionAgregar;
        private System.Windows.Forms.DataGridView DgvLista;
        private System.Windows.Forms.ToolStripButton BtnModificarProducto;
        private System.Windows.Forms.ToolStripButton BtnEliminarProducto;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox TxtTotalCantidad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnCrearImportacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn CProductoID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CProductoTamanio;
        private System.Windows.Forms.DataGridViewTextBoxColumn CProductoNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCostoUnitario;
    }
}