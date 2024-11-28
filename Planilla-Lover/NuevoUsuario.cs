using Planilla_Lover;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PLANILLA_LOVERS
{
    public partial class NuevoUsuario : Form
    {
        private GestorUsuarios gestorUsuarios;
        public NuevoUsuario()
        {
            InitializeComponent();
        }

        private void Agregarbtn_Click(object sender, EventArgs e)
        {
            string nombre = NewUsertxt.Text;
            string contraseña = NewContratxt.Text;
            string repetirContraseña = RepNewContratxt.Text;

            Usuario nuevoUsuario = new UsuarioCorriente(nombre, contraseña);


            // Agregar usuario al gestor
            if (repetirContraseña == contraseña)
            {
                gestorUsuarios.AgregarUsuario(nuevoUsuario);


                // Enviar al usuario a inicio de Sesion
                InicioSesion GoInicio = new InicioSesion();

                // Mostrar Inicio de Sesion
                GoInicio.Show();

                // Ocultar el formulario actual
                this.Hide();
            }
            else
            {
                MessageBox.Show("Contraseñas no coinciden");
            }
        }
    }
}
