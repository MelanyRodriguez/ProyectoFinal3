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
    public partial class FrmGestionProovedores : Form

    {

        //objeto local para el proovedor
        private Logica.Models.Proovedor MiProovedorLocal { get; set; }
        //lista de proovedores que se visualizan en el data gridview
        private DataTable ListaProovedores { get; set; }
        public FrmGestionProovedores()
        {
            InitializeComponent();
            MiProovedorLocal = new Logica.Models.Proovedor();
            ListaProovedores = new DataTable();
        }

        private void FrmGestionProovedores_Load(object sender, EventArgs e)
        {
            //definimos el padre Mid
            MdiParent = Globales.MiFormPrincipal;
            CargarListaTipos();
            CargarListaDeProovedores();
            
        }


        private void CargarListaDeProovedores()
        {
            ListaProovedores = new DataTable();

            if (CboxVerProovedoresActuales.Checked)
            {
                ListaProovedores = MiProovedorLocal.ListarActivos();
            }
            else
            {
                ListaProovedores = MiProovedorLocal.ListarInActivos();
            }
            DgLista.DataSource = ListaProovedores;



        }


        private void CargarListaTipos()

        {
            Logica.Models.TipoProovedor MiTipo= new Logica.Models.TipoProovedor();
            DataTable dt = new DataTable();

            dt = MiTipo.Listar();

            if (dt !=null && dt.Rows.Count >0)
            {
                CbTipoProovedor.ValueMember = "ID";
                CbTipoProovedor.DisplayMember = "Descripcion";
                CbTipoProovedor.DataSource= dt;
                CbTipoProovedor.SelectedIndex = -1;
            }
        }
           private void LimpiarFormulario()
        {
            TxtProovedorNombre.Clear();
            TxtProovedorCedula.Clear();
            TxtProovedorEmail.Clear();
            TxtProovedorDireccion.Clear();
            CbTipoProovedor.SelectedIndex = -1;
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            MiProovedorLocal = new Logica.Models.Proovedor();

            MiProovedorLocal.ProovedorNombre = TxtProovedorNombre.Text.Trim();
            MiProovedorLocal.ProovedorCedula = TxtProovedorCedula.Text.Trim();
            MiProovedorLocal.ProovedorEmail = TxtProovedorEmail.Text.Trim();
            MiProovedorLocal.ProovedorDireccion = TxtProovedorDireccion.Text.Trim();
            MiProovedorLocal.MiTipoProovedor.TipoProovedorID = Convert.ToInt32(CbTipoProovedor.SelectedValue);

  
            string msg = string.Format("¿Esta seguro de guardar el proveedor {0}?", MiProovedorLocal.ProovedorNombre);

            DialogResult respuesta = MessageBox.Show(msg, "???", MessageBoxButtons.YesNo);

            if (respuesta == DialogResult.Yes)
            {
                bool ok = MiProovedorLocal.Agregar();

                if (ok)
                {
                    MessageBox.Show("Proovedor guardado correctamente!", "(:", MessageBoxButtons.OK);

                    LimpiarFormulario();
                    CargarListaDeProovedores();
                }

                else
                {
                    MessageBox.Show("Proovedor no guardado correctamente!", ":(", MessageBoxButtons.OK);
                }

            }
        }
    }
}
