
using ProyectoFinal3.Formularios;
using System;
using System.Windows.Forms;

namespace ProyectoFinal3
{
    public static class Globales
    {
        // Estas Propiedades se obtienen en la globalidad de la aplicacion y al permanecer en statica se auto instancian
        public static Form MiFormPrincipal = new Formularios.FrmMDI();
        public static Formularios.FrmGestionProductos MiFormGestionProductos = new Formularios.FrmGestionProductos();
        //Debemos tener un objeto de tipo Empleado que permita almacenar los datos del empleado
        //que se haya logeaado correctamente 
        public static Logica.Models.Empleado MiEmpleadoGlobal = new Logica.Models.Empleado();

        public static Formularios.FrmRegistrodeImportaciones MiFormRegistroDeImportaciones = new Formularios.FrmRegistrodeImportaciones();

        public static Formularios.FrmGestionProovedores MiFormGestionProovedores = new Formularios.FrmGestionProovedores();

        public static Formularios.FrmGestionEmpleados MiFormGestionEmpleados = new Formularios.FrmGestionEmpleados();
    }
}
