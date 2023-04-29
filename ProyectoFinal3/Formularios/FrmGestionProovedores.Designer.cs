namespace ProyectoFinal3.Formularios
{
    partial class FrmGestionProovedores
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
            this.CboxVerProovedoresActuales = new System.Windows.Forms.CheckBox();
            this.DgLista = new System.Windows.Forms.DataGridView();
            this.CProovedorID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CProovedorNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CProovedorCedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CProovedorEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CProovedorDireccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CProovedorTipoDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CProovedorTipoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CbTipoProovedor = new System.Windows.Forms.ComboBox();
            this.TxtProovedorDireccion = new System.Windows.Forms.TextBox();
            this.TxtProovedorEmail = new System.Windows.Forms.TextBox();
            this.TxtProovedorCedula = new System.Windows.Forms.TextBox();
            this.TxtProovedorNombre = new System.Windows.Forms.TextBox();
            this.TxtProovedorID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnAgregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgLista)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar: ";
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Location = new System.Drawing.Point(135, 46);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(350, 20);
            this.TxtBuscar.TabIndex = 1;
            // 
            // CboxVerProovedoresActuales
            // 
            this.CboxVerProovedoresActuales.AutoSize = true;
            this.CboxVerProovedoresActuales.Checked = true;
            this.CboxVerProovedoresActuales.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CboxVerProovedoresActuales.Location = new System.Drawing.Point(520, 49);
            this.CboxVerProovedoresActuales.Name = "CboxVerProovedoresActuales";
            this.CboxVerProovedoresActuales.Size = new System.Drawing.Size(149, 17);
            this.CboxVerProovedoresActuales.TabIndex = 2;
            this.CboxVerProovedoresActuales.Text = "Ver Proovedores Actuales";
            this.CboxVerProovedoresActuales.UseVisualStyleBackColor = true;
            // 
            // DgLista
            // 
            this.DgLista.AllowUserToAddRows = false;
            this.DgLista.AllowUserToDeleteRows = false;
            this.DgLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CProovedorID,
            this.CProovedorNombre,
            this.CProovedorCedula,
            this.CProovedorEmail,
            this.CProovedorDireccion,
            this.CProovedorTipoDescripcion,
            this.CProovedorTipoID});
            this.DgLista.Location = new System.Drawing.Point(55, 93);
            this.DgLista.MultiSelect = false;
            this.DgLista.Name = "DgLista";
            this.DgLista.ReadOnly = true;
            this.DgLista.RowHeadersVisible = false;
            this.DgLista.Size = new System.Drawing.Size(684, 172);
            this.DgLista.TabIndex = 3;
            this.DgLista.VirtualMode = true;
            // 
            // CProovedorID
            // 
            this.CProovedorID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CProovedorID.DataPropertyName = "ProovedorID";
            this.CProovedorID.HeaderText = "codigo";
            this.CProovedorID.Name = "CProovedorID";
            this.CProovedorID.ReadOnly = true;
            // 
            // CProovedorNombre
            // 
            this.CProovedorNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CProovedorNombre.DataPropertyName = "ProovedorNombre";
            this.CProovedorNombre.HeaderText = "Nombre";
            this.CProovedorNombre.Name = "CProovedorNombre";
            this.CProovedorNombre.ReadOnly = true;
            // 
            // CProovedorCedula
            // 
            this.CProovedorCedula.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CProovedorCedula.DataPropertyName = "ProovedorCedula";
            this.CProovedorCedula.HeaderText = "Cedula";
            this.CProovedorCedula.Name = "CProovedorCedula";
            this.CProovedorCedula.ReadOnly = true;
            // 
            // CProovedorEmail
            // 
            this.CProovedorEmail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CProovedorEmail.DataPropertyName = "ProovedorEmail";
            this.CProovedorEmail.HeaderText = "Correo";
            this.CProovedorEmail.Name = "CProovedorEmail";
            this.CProovedorEmail.ReadOnly = true;
            // 
            // CProovedorDireccion
            // 
            this.CProovedorDireccion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CProovedorDireccion.DataPropertyName = "ProovedorDireccion";
            this.CProovedorDireccion.HeaderText = "CProovedorDireccion";
            this.CProovedorDireccion.Name = "CProovedorDireccion";
            this.CProovedorDireccion.ReadOnly = true;
            // 
            // CProovedorTipoDescripcion
            // 
            this.CProovedorTipoDescripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CProovedorTipoDescripcion.DataPropertyName = "ProovedorTipoDescripcion";
            this.CProovedorTipoDescripcion.HeaderText = "Despripcion";
            this.CProovedorTipoDescripcion.Name = "CProovedorTipoDescripcion";
            this.CProovedorTipoDescripcion.ReadOnly = true;
            // 
            // CProovedorTipoID
            // 
            this.CProovedorTipoID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CProovedorTipoID.DataPropertyName = "ProovedorTipoID";
            this.CProovedorTipoID.HeaderText = "Tipo Proovedor";
            this.CProovedorTipoID.Name = "CProovedorTipoID";
            this.CProovedorTipoID.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CbTipoProovedor);
            this.groupBox1.Controls.Add(this.TxtProovedorDireccion);
            this.groupBox1.Controls.Add(this.TxtProovedorEmail);
            this.groupBox1.Controls.Add(this.TxtProovedorCedula);
            this.groupBox1.Controls.Add(this.TxtProovedorNombre);
            this.groupBox1.Controls.Add(this.TxtProovedorID);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(55, 286);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(721, 156);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalle de Proovedor";
            // 
            // CbTipoProovedor
            // 
            this.CbTipoProovedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbTipoProovedor.FormattingEnabled = true;
            this.CbTipoProovedor.Location = new System.Drawing.Point(496, 113);
            this.CbTipoProovedor.Name = "CbTipoProovedor";
            this.CbTipoProovedor.Size = new System.Drawing.Size(172, 21);
            this.CbTipoProovedor.TabIndex = 11;
            // 
            // TxtProovedorDireccion
            // 
            this.TxtProovedorDireccion.Location = new System.Drawing.Point(470, 69);
            this.TxtProovedorDireccion.Multiline = true;
            this.TxtProovedorDireccion.Name = "TxtProovedorDireccion";
            this.TxtProovedorDireccion.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TxtProovedorDireccion.Size = new System.Drawing.Size(198, 20);
            this.TxtProovedorDireccion.TabIndex = 10;
            // 
            // TxtProovedorEmail
            // 
            this.TxtProovedorEmail.Location = new System.Drawing.Point(465, 38);
            this.TxtProovedorEmail.Name = "TxtProovedorEmail";
            this.TxtProovedorEmail.Size = new System.Drawing.Size(203, 20);
            this.TxtProovedorEmail.TabIndex = 9;
            // 
            // TxtProovedorCedula
            // 
            this.TxtProovedorCedula.Location = new System.Drawing.Point(80, 113);
            this.TxtProovedorCedula.Name = "TxtProovedorCedula";
            this.TxtProovedorCedula.Size = new System.Drawing.Size(218, 20);
            this.TxtProovedorCedula.TabIndex = 8;
            // 
            // TxtProovedorNombre
            // 
            this.TxtProovedorNombre.Location = new System.Drawing.Point(96, 70);
            this.TxtProovedorNombre.Name = "TxtProovedorNombre";
            this.TxtProovedorNombre.Size = new System.Drawing.Size(202, 20);
            this.TxtProovedorNombre.TabIndex = 7;
            // 
            // TxtProovedorID
            // 
            this.TxtProovedorID.Location = new System.Drawing.Point(80, 37);
            this.TxtProovedorID.Name = "TxtProovedorID";
            this.TxtProovedorID.ReadOnly = true;
            this.TxtProovedorID.Size = new System.Drawing.Size(218, 20);
            this.TxtProovedorID.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(379, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 18);
            this.label7.TabIndex = 5;
            this.label7.Text = "Tipo Proovedor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(393, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 18);
            this.label6.TabIndex = 4;
            this.label6.Text = "Direccion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(393, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 18);
            this.label5.TabIndex = 3;
            this.label5.Text = "Correo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Cedula";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Codigo";
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.Location = new System.Drawing.Point(316, 448);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(142, 35);
            this.BtnAgregar.TabIndex = 5;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // FrmGestionProovedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 495);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DgLista);
            this.Controls.Add(this.CboxVerProovedoresActuales);
            this.Controls.Add(this.TxtBuscar);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmGestionProovedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion de Proovedores";
            this.Load += new System.EventHandler(this.FrmGestionProovedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgLista)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.CheckBox CboxVerProovedoresActuales;
        private System.Windows.Forms.DataGridView DgLista;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CbTipoProovedor;
        private System.Windows.Forms.TextBox TxtProovedorDireccion;
        private System.Windows.Forms.TextBox TxtProovedorEmail;
        private System.Windows.Forms.TextBox TxtProovedorCedula;
        private System.Windows.Forms.TextBox TxtProovedorNombre;
        private System.Windows.Forms.TextBox TxtProovedorID;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.DataGridViewTextBoxColumn CProovedorID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CProovedorNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn CProovedorCedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn CProovedorEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn CProovedorDireccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn CProovedorTipoDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn CProovedorTipoID;
    }
}