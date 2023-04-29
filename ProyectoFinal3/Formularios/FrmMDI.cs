using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal3.Formularios
{
    public partial class FrmMDI : Form
    {
        public FrmMDI()
        {
            InitializeComponent();
        }

        private void FrmMDI_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        //Control para que el formulario de gestion de productos
        //se muestre solo una vez
        private void gESTIONDEPRODUCTOSToolStripMenuItem_Click(object sender, EventArgs e)
        
        {
         
            if(!Globales.MiFormGestionProductos.Visible)
            {
                Globales.MiFormGestionProductos = new FrmGestionProductos();
                Globales.MiFormGestionProductos.Show();
            }




        }

        private void FrmMDI_Load(object sender, EventArgs e)
        {

            //mostrar el empleado gloeado
            string InfoEmpleado = string.Format("{0}-{1} ({2})",
                Globales.MiEmpleadoGlobal.EmpleadoNombre,
                Globales.MiEmpleadoGlobal.EmpleadoCorreo,
                Globales.MiEmpleadoGlobal.MiRolTipo.EmpleadoRolDescripcion);



            lblEmpleado.Text = InfoEmpleado;

            switch (Globales.MiEmpleadoGlobal.MiRolTipo.EmpleadoRolID)

            {
                case 1:
                    // seria admin no se oculta nada
                    break;
                case 2:
                    //seria usuario normal, se deben ocultar varias opciones 
                    gESTIONDEEMPLEADOSToolStripMenuItem.Visible = false;
                    empleadoRolToolStripMenuItem.Visible = false;
                    tipoProovedorToolStripMenuItem.Visible = false;
                    importacionTipoToolStripMenuItem.Visible = false;
                    break;
            }

        }

        private void rEToolStripMenuItem_Click(object sender, EventArgs e)
        {


            if (!Globales.MiFormRegistroDeImportaciones.Visible)
            {
                Globales.MiFormRegistroDeImportaciones = new FrmRegistrodeImportaciones();
                Globales.MiFormRegistroDeImportaciones.Show();
            }





        }

        private void gESTIONDEEMPLEADOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Globales.MiFormGestionEmpleados.Visible)
            {
                Globales.MiFormGestionEmpleados = new FrmGestionEmpleados();
                Globales.MiFormGestionEmpleados.Show();
            }

        }

        private void gESTIONDEPROOVEDORESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Globales.MiFormGestionProovedores.Visible)
            {
                Globales.MiFormGestionProovedores = new FrmGestionProovedores();
                Globales.MiFormGestionProovedores.Show();
            }
        }
    }



    }

