namespace ProyectoFinal3.Formularios
{
    partial class FrmMDI
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
            this.mnuPrincipal = new System.Windows.Forms.MenuStrip();
            this.MnuGestiones = new System.Windows.Forms.ToolStripMenuItem();
            this.gESTIONDEPRODUCTOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gESTIONDEEMPLEADOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gESTIONDEPROOVEDORESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadoRolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoProovedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importacionTipoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuPROCESOS = new System.Windows.Forms.ToolStripMenuItem();
            this.rEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuREPORTES = new System.Windows.Forms.ToolStripMenuItem();
            this.importacionPorFeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importacionPorDiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importacionPorProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importacionPorProovedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuSALIR = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblEmpleado = new System.Windows.Forms.ToolStripStatusLabel();
            this.mnuPrincipal.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuPrincipal
            // 
            this.mnuPrincipal.BackColor = System.Drawing.Color.PaleGreen;
            this.mnuPrincipal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuPrincipal.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.mnuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuGestiones,
            this.MnuPROCESOS,
            this.MnuREPORTES,
            this.MnuSALIR});
            this.mnuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mnuPrincipal.Name = "mnuPrincipal";
            this.mnuPrincipal.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.mnuPrincipal.Size = new System.Drawing.Size(800, 29);
            this.mnuPrincipal.TabIndex = 1;
            this.mnuPrincipal.Text = "menuStrip1";
            // 
            // MnuGestiones
            // 
            this.MnuGestiones.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gESTIONDEPRODUCTOSToolStripMenuItem,
            this.gESTIONDEEMPLEADOSToolStripMenuItem,
            this.gESTIONDEPROOVEDORESToolStripMenuItem,
            this.toolStripSeparator1,
            this.cateToolStripMenuItem,
            this.empleadoRolToolStripMenuItem,
            this.tipoProovedorToolStripMenuItem,
            this.importacionTipoToolStripMenuItem});
            this.MnuGestiones.Name = "MnuGestiones";
            this.MnuGestiones.Size = new System.Drawing.Size(103, 25);
            this.MnuGestiones.Text = "GESTIONES";
            // 
            // gESTIONDEPRODUCTOSToolStripMenuItem
            // 
            this.gESTIONDEPRODUCTOSToolStripMenuItem.Name = "gESTIONDEPRODUCTOSToolStripMenuItem";
            this.gESTIONDEPRODUCTOSToolStripMenuItem.Size = new System.Drawing.Size(282, 26);
            this.gESTIONDEPRODUCTOSToolStripMenuItem.Text = "GESTION DE PRODUCTOS";
            this.gESTIONDEPRODUCTOSToolStripMenuItem.Click += new System.EventHandler(this.gESTIONDEPRODUCTOSToolStripMenuItem_Click);
            // 
            // gESTIONDEEMPLEADOSToolStripMenuItem
            // 
            this.gESTIONDEEMPLEADOSToolStripMenuItem.Name = "gESTIONDEEMPLEADOSToolStripMenuItem";
            this.gESTIONDEEMPLEADOSToolStripMenuItem.Size = new System.Drawing.Size(282, 26);
            this.gESTIONDEEMPLEADOSToolStripMenuItem.Text = "GESTION DE EMPLEADOS";
            this.gESTIONDEEMPLEADOSToolStripMenuItem.Click += new System.EventHandler(this.gESTIONDEEMPLEADOSToolStripMenuItem_Click);
            // 
            // gESTIONDEPROOVEDORESToolStripMenuItem
            // 
            this.gESTIONDEPROOVEDORESToolStripMenuItem.Name = "gESTIONDEPROOVEDORESToolStripMenuItem";
            this.gESTIONDEPROOVEDORESToolStripMenuItem.Size = new System.Drawing.Size(282, 26);
            this.gESTIONDEPROOVEDORESToolStripMenuItem.Text = "GESTION DE PROOVEDORES";
            this.gESTIONDEPROOVEDORESToolStripMenuItem.Click += new System.EventHandler(this.gESTIONDEPROOVEDORESToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(279, 6);
            // 
            // cateToolStripMenuItem
            // 
            this.cateToolStripMenuItem.Name = "cateToolStripMenuItem";
            this.cateToolStripMenuItem.Size = new System.Drawing.Size(282, 26);
            this.cateToolStripMenuItem.Text = "CategoriaProductos";
            // 
            // empleadoRolToolStripMenuItem
            // 
            this.empleadoRolToolStripMenuItem.Name = "empleadoRolToolStripMenuItem";
            this.empleadoRolToolStripMenuItem.Size = new System.Drawing.Size(282, 26);
            this.empleadoRolToolStripMenuItem.Text = "EmpleadoRol";
            // 
            // tipoProovedorToolStripMenuItem
            // 
            this.tipoProovedorToolStripMenuItem.Name = "tipoProovedorToolStripMenuItem";
            this.tipoProovedorToolStripMenuItem.Size = new System.Drawing.Size(282, 26);
            this.tipoProovedorToolStripMenuItem.Text = "TipoProovedor";
            // 
            // importacionTipoToolStripMenuItem
            // 
            this.importacionTipoToolStripMenuItem.Name = "importacionTipoToolStripMenuItem";
            this.importacionTipoToolStripMenuItem.Size = new System.Drawing.Size(282, 26);
            this.importacionTipoToolStripMenuItem.Text = "ImportacionTipo";
            // 
            // MnuPROCESOS
            // 
            this.MnuPROCESOS.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rEToolStripMenuItem});
            this.MnuPROCESOS.Name = "MnuPROCESOS";
            this.MnuPROCESOS.Size = new System.Drawing.Size(101, 25);
            this.MnuPROCESOS.Text = "PROCESOS";
            // 
            // rEToolStripMenuItem
            // 
            this.rEToolStripMenuItem.Name = "rEToolStripMenuItem";
            this.rEToolStripMenuItem.Size = new System.Drawing.Size(299, 26);
            this.rEToolStripMenuItem.Text = "REGISTRO DE IMPORTACIONES";
            this.rEToolStripMenuItem.Click += new System.EventHandler(this.rEToolStripMenuItem_Click);
            // 
            // MnuREPORTES
            // 
            this.MnuREPORTES.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importacionPorFeToolStripMenuItem,
            this.importacionPorDiaToolStripMenuItem,
            this.importacionPorProductoToolStripMenuItem,
            this.importacionPorProovedorToolStripMenuItem});
            this.MnuREPORTES.Name = "MnuREPORTES";
            this.MnuREPORTES.Size = new System.Drawing.Size(95, 25);
            this.MnuREPORTES.Text = "REPORTES";
            // 
            // importacionPorFeToolStripMenuItem
            // 
            this.importacionPorFeToolStripMenuItem.Name = "importacionPorFeToolStripMenuItem";
            this.importacionPorFeToolStripMenuItem.Size = new System.Drawing.Size(268, 26);
            this.importacionPorFeToolStripMenuItem.Text = "Importacion por Mes";
            // 
            // importacionPorDiaToolStripMenuItem
            // 
            this.importacionPorDiaToolStripMenuItem.Name = "importacionPorDiaToolStripMenuItem";
            this.importacionPorDiaToolStripMenuItem.Size = new System.Drawing.Size(268, 26);
            this.importacionPorDiaToolStripMenuItem.Text = "Importacion por Dia";
            // 
            // importacionPorProductoToolStripMenuItem
            // 
            this.importacionPorProductoToolStripMenuItem.Name = "importacionPorProductoToolStripMenuItem";
            this.importacionPorProductoToolStripMenuItem.Size = new System.Drawing.Size(268, 26);
            this.importacionPorProductoToolStripMenuItem.Text = "Importacion por Producto";
            // 
            // importacionPorProovedorToolStripMenuItem
            // 
            this.importacionPorProovedorToolStripMenuItem.Name = "importacionPorProovedorToolStripMenuItem";
            this.importacionPorProovedorToolStripMenuItem.Size = new System.Drawing.Size(268, 26);
            this.importacionPorProovedorToolStripMenuItem.Text = "Importacion Por Proovedor";
            // 
            // MnuSALIR
            // 
            this.MnuSALIR.Name = "MnuSALIR";
            this.MnuSALIR.Size = new System.Drawing.Size(63, 25);
            this.MnuSALIR.Text = "SALIR";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lblEmpleado});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(74, 17);
            this.toolStripStatusLabel1.Text = "EMPLEADO :";
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(73, 17);
            this.lblEmpleado.Text = "empleado:";
            // 
            // FrmMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.mnuPrincipal);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnuPrincipal;
            this.Name = "FrmMDI";
            this.Text = "SISTEMA DE GESTION DE INFORMACION";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMDI_FormClosed);
            this.Load += new System.EventHandler(this.FrmMDI_Load);
            this.mnuPrincipal.ResumeLayout(false);
            this.mnuPrincipal.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem MnuGestiones;
        private System.Windows.Forms.ToolStripMenuItem MnuPROCESOS;
        private System.Windows.Forms.ToolStripMenuItem MnuREPORTES;
        private System.Windows.Forms.ToolStripMenuItem MnuSALIR;
        private System.Windows.Forms.ToolStripMenuItem gESTIONDEPRODUCTOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gESTIONDEEMPLEADOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gESTIONDEPROOVEDORESToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem cateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empleadoRolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoProovedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importacionTipoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importacionPorFeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importacionPorDiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importacionPorProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importacionPorProovedorToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lblEmpleado;
    }
}