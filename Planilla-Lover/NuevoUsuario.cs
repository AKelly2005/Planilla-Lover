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

        public NuevoUsuario(GestorUsuarios gestorUsuarios)
        {
            InitializeComponent();
            this.gestorUsuarios = gestorUsuarios; 
        }

        private void Agregarbtn_Click(object sender, EventArgs e)
        {
            string nombre = NewUsertxt.Text;
            string contraseña = NewContratxt.Text;
            string repetirContraseña = RepNewContratxt.Text;

            // Validar si algún campo está vacío
            if (string.IsNullOrWhiteSpace(nombre))
            {
                MessageBox.Show("Por favor ingrese un nombre de usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Salir de la función si el nombre está vacío
            }

            if (string.IsNullOrWhiteSpace(contraseña))
            {
                MessageBox.Show("Por favor ingrese una contraseña.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Salir de la función si la contraseña está vacía
            }

            if (string.IsNullOrWhiteSpace(repetirContraseña))
            {
                MessageBox.Show("Por favor repita la contraseña.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Salir de la función si la repetición de la contraseña está vacía
            }

            // Validar que las contraseñas coincidan
            if (repetirContraseña != contraseña)
            {
                MessageBox.Show("Las contraseñas no coinciden.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Salir si las contraseñas no coinciden
            }

            // Si todos los campos son válidos, se procede a agregar el usuario
            Usuario nuevoUsuario = new UsuarioCorriente(nombre, contraseña);

            try
            {
                // Agregar usuario al gestor
                gestorUsuarios.AgregarUsuario(nuevoUsuario);

                // Enviar al usuario a inicio de sesión
                InicioSesion GoInicio = new InicioSesion(gestorUsuarios);

                // Mostrar inicio de sesión
                GoInicio.Show();

                // Ocultar el formulario actual
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar el usuario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InicioSesion nuevoInicio = new InicioSesion(gestorUsuarios);
            nuevoInicio.Show();
            this.Hide();
        }
    }
}