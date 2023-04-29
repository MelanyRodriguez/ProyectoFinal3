using Logica.Models;
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
    public partial class FrmGestionEmpleados : Form
    {
        public FrmGestionEmpleados()
        {
            InitializeComponent();
        }

        private void FrmGestionEmpleados_Load(object sender, EventArgs e)
        {
            //Definimos el padre mdi

            MdiParent = Globales.MiFormPrincipal;
            CargarListaRoles();
        }

        private void CargarListaRoles()

        {
            Logica.Models.EmpleadoRol MiRol = new Logica.Models.EmpleadoRol();

            DataTable dt = new DataTable();
            dt = MiRol.Listar();

            if (dt != null && dt.Rows.Count > 0)
            {
                CbRolesEmpleado.ValueMember= "ID";
                CbRolesEmpleado.DisplayMember = "Descripcion";
                CbRolesEmpleado.DataSource = dt;
                CbRolesEmpleado.SelectedIndex = -1;
            }
        }
    }
    }

