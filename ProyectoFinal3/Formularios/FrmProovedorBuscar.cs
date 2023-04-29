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
    public partial class FrmProovedorBuscar : Form
    {
       DataTable DtLista { get; set; }

        Proovedor MIProovedorLocal { get; set; }

        public FrmProovedorBuscar()
        {
            InitializeComponent();

            DtLista= new DataTable();
            MIProovedorLocal= new Proovedor();
        }

        private void FrmProovedorBuscar_Load(object sender, EventArgs e)
        {
            LlenarLista();
        }

       private void LlenarLista()
        {
            DtLista=new DataTable();
            DtLista = MIProovedorLocal.Listar(true, TxtBuscar.Text.Trim());
            DgvLista.DataSource= DtLista;

        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (TxtBuscar.Text.Count() > 2 || string.IsNullOrEmpty(TxtBuscar.Text.Trim()));
            {
                LlenarLista();
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult= DialogResult.Cancel;
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {

          if (DgvLista.SelectedRows.Count==1)

            {
                DataGridViewRow row = DgvLista.SelectedRows[0];
                int ProovedorID = Convert.ToInt32(row.Cells["CProovedorID"].Value);
                string NombreProovedor = Convert.ToString(row.Cells["CProovedorNombre"].Value);
                DialogResult = DialogResult.OK;

                //pasar las variables al formulario de registro de importaciones
                Globales.MiFormRegistroDeImportaciones.MiImportacionLocal.MiTipoProovedor.ProovedorNombre = NombreProovedor;
                Globales.MiFormRegistroDeImportaciones.MiImportacionLocal.MiTipoProovedor.ProovedorID = ProovedorID;

                DialogResult = DialogResult.OK;

            }

         

        }
    }
}
