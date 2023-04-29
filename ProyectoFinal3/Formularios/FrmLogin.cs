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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            //CIERRA LA APP
            Application.Exit();
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            //Validar que se halla dijitado un correo y una contraseña
            if (!string.IsNullOrEmpty(TxtEmail.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtContrasennia.Text.Trim()))


            {
                string correoElectronico=TxtEmail.Text.Trim();
                string contrasennia= TxtContrasennia.Text.Trim();

                //tratar de validar que los datos digitados sean correctos, en caso de que 
                //los datos sean correctos aplicamos los valores del empleado global
                Globales.MiEmpleadoGlobal = Globales.MiEmpleadoGlobal.ValidarEmpleado(correoElectronico, contrasennia);


                if (Globales.MiEmpleadoGlobal.EmpleadoID > 0)

                {
                    //si la validacion es correcta el ID es mayor que 0
                    Globales.MiFormPrincipal.Show();
                    this.Hide();
                }

                else
                {
                    MessageBox.Show("Correo o contrasennia incorrectas", "Error en Validacion", MessageBoxButtons.OK);
                    TxtContrasennia.Focus();
                    TxtContrasennia.SelectAll();
                }





            }
            else
            {
                MessageBox.Show("Faltan datos requeridos", "Error en la validacion", MessageBoxButtons.OK);
            }

            


        }

        private void FrmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            //al presionar ciertas teclas el boton de ingreso directo aparece 

            if (e.Shift & e.Alt & e.KeyCode== Keys.A)
            {
                BtnIngresoDirecto.Visible = true;
            }

        }

        private void BtnIngresoDirecto_Click(object sender, EventArgs e)
        {
            Globales.MiFormPrincipal.Show();
            this.Hide();
        }
    }
}
