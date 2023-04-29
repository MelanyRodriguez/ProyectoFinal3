namespace ProyectoFinal3.Formularios
{
    partial class FrmGestionEmpleados
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
            this.CboxVerEmpleadosActuales = new System.Windows.Forms.CheckBox();
            this.DgLista = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtEmpleadoID = new System.Windows.Forms.TextBox();
            this.TxtEmpleadoNombre = new System.Windows.Forms.TextBox();
            this.TxtEmpleadoCedula = new System.Windows.Forms.TextBox();
            this.TxtEmpleadoCorreo = new System.Windows.Forms.TextBox();
            this.TxtEmpleadoDireccion = new System.Windows.Forms.TextBox();
            this.CbRolesEmpleado = new System.Windows.Forms.ComboBox();
            this.BtnAgregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgLista)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar:";
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Location = new System.Drawing.Point(123, 37);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(333, 20);
            this.TxtBuscar.TabIndex = 1;
            // 
            // CboxVerEmpleadosActuales
            // 
            this.CboxVerEmpleadosActuales.AutoSize = true;
            this.CboxVerEmpleadosActuales.Checked = true;
            this.CboxVerEmpleadosActuales.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CboxVerEmpleadosActuales.Location = new System.Drawing.Point(507, 34);
            this.CboxVerEmpleadosActuales.Name = "CboxVerEmpleadosActuales";
            this.CboxVerEmpleadosActuales.Size = new System.Drawing.Size(122, 17);
            this.CboxVerEmpleadosActuales.TabIndex = 2;
            this.CboxVerEmpleadosActuales.Text = "Empleados Actuales";
            this.CboxVerEmpleadosActuales.UseVisualStyleBackColor = true;
            // 
            // DgLista
            // 
            this.DgLista.AllowUserToAddRows = false;
            this.DgLista.AllowUserToDeleteRows = false;
            this.DgLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgLista.Location = new System.Drawing.Point(38, 86);
            this.DgLista.MultiSelect = false;
            this.DgLista.Name = "DgLista";
            this.DgLista.ReadOnly = true;
            this.DgLista.RowHeadersVisible = false;
            this.DgLista.Size = new System.Drawing.Size(720, 174);
            this.DgLista.TabIndex = 3;
            this.DgLista.VirtualMode = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CbRolesEmpleado);
            this.groupBox1.Controls.Add(this.TxtEmpleadoDireccion);
            this.groupBox1.Controls.Add(this.TxtEmpleadoCorreo);
            this.groupBox1.Controls.Add(this.TxtEmpleadoCedula);
            this.groupBox1.Controls.Add(this.TxtEmpleadoNombre);
            this.groupBox1.Controls.Add(this.TxtEmpleadoID);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(36, 301);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(707, 152);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalle de Empleados";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Codigo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Cedula";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(418, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 18);
            this.label5.TabIndex = 3;
            this.label5.Text = "Correo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(402, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 18);
            this.label6.TabIndex = 4;
            this.label6.Text = "Direccion";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(402, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 18);
            this.label7.TabIndex = 5;
            this.label7.Text = "Empleado Rol";
            // 
            // TxtEmpleadoID
            // 
            this.TxtEmpleadoID.Location = new System.Drawing.Point(97, 34);
            this.TxtEmpleadoID.Name = "TxtEmpleadoID";
            this.TxtEmpleadoID.ReadOnly = true;
            this.TxtEmpleadoID.Size = new System.Drawing.Size(231, 20);
            this.TxtEmpleadoID.TabIndex = 6;
            this.TxtEmpleadoID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtEmpleadoNombre
            // 
            this.TxtEmpleadoNombre.Location = new System.Drawing.Point(97, 81);
            this.TxtEmpleadoNombre.Name = "TxtEmpleadoNombre";
            this.TxtEmpleadoNombre.Size = new System.Drawing.Size(231, 20);
            this.TxtEmpleadoNombre.TabIndex = 7;
            // 
            // TxtEmpleadoCedula
            // 
            this.TxtEmpleadoCedula.Location = new System.Drawing.Point(87, 121);
            this.TxtEmpleadoCedula.Name = "TxtEmpleadoCedula";
            this.TxtEmpleadoCedula.Size = new System.Drawing.Size(241, 20);
            this.TxtEmpleadoCedula.TabIndex = 8;
            // 
            // TxtEmpleadoCorreo
            // 
            this.TxtEmpleadoCorreo.Location = new System.Drawing.Point(479, 33);
            this.TxtEmpleadoCorreo.Name = "TxtEmpleadoCorreo";
            this.TxtEmpleadoCorreo.Size = new System.Drawing.Size(194, 20);
            this.TxtEmpleadoCorreo.TabIndex = 9;
            // 
            // TxtEmpleadoDireccion
            // 
            this.TxtEmpleadoDireccion.Location = new System.Drawing.Point(479, 78);
            this.TxtEmpleadoDireccion.Multiline = true;
            this.TxtEmpleadoDireccion.Name = "TxtEmpleadoDireccion";
            this.TxtEmpleadoDireccion.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TxtEmpleadoDireccion.Size = new System.Drawing.Size(194, 20);
            this.TxtEmpleadoDireccion.TabIndex = 10;
            // 
            // CbRolesEmpleado
            // 
            this.CbRolesEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbRolesEmpleado.FormattingEnabled = true;
            this.CbRolesEmpleado.Location = new System.Drawing.Point(522, 118);
            this.CbRolesEmpleado.Name = "CbRolesEmpleado";
            this.CbRolesEmpleado.Size = new System.Drawing.Size(151, 21);
            this.CbRolesEmpleado.TabIndex = 11;
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.Location = new System.Drawing.Point(302, 459);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(133, 39);
            this.BtnAgregar.TabIndex = 5;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = false;
            // 
            // FrmGestionEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 510);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DgLista);
            this.Controls.Add(this.CboxVerEmpleadosActuales);
            this.Controls.Add(this.TxtBuscar);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmGestionEmpleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion de Empleados";
            this.Load += new System.EventHandler(this.FrmGestionEmpleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgLista)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.CheckBox CboxVerEmpleadosActuales;
        private System.Windows.Forms.DataGridView DgLista;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtEmpleadoID;
        private System.Windows.Forms.ComboBox CbRolesEmpleado;
        private System.Windows.Forms.TextBox TxtEmpleadoDireccion;
        private System.Windows.Forms.TextBox TxtEmpleadoCorreo;
        private System.Windows.Forms.TextBox TxtEmpleadoCedula;
        private System.Windows.Forms.TextBox TxtEmpleadoNombre;
        private System.Windows.Forms.Button BtnAgregar;
    }
}