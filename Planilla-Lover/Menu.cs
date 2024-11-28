using Microsoft.VisualBasic.Logging;
using PLANILLA_LOVERS;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Planilla_Lover
{
    public partial class Menu : Form
    {
        private GestorUsuarios gestorUsuarios;
        private Usuario usuarioEncontrado;
        private Planilla<Empleado> planilla;

        public Menu(GestorUsuarios gestorUsuarios, Usuario usuarioEncontrado, Planilla<Empleado> planilla)
        {
            InitializeComponent();
            this.gestorUsuarios = gestorUsuarios;
            this.usuarioEncontrado = usuarioEncontrado;
            this.planilla = planilla;
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");

            // Verificar si el usuario actual es un Administrador o UsuarioCorriente usando LINQ
            var usuarioFiltrado = gestorUsuarios.ObtenerUsuarios()
                .Where(u => u.Nombre == usuarioEncontrado.Nombre)
                .FirstOrDefault(); // Filtramos para encontrar el usuario por su nombre

            if (usuarioFiltrado != null)
            {
                // Verificamos el tipo de usuario con LINQ
                if (usuarioFiltrado is Administrador)
                {
                    lblUsuarioTipo.Text = "Bienvenido Administrador";
                    lblVerPlanilla.Visible = true;
                    btnIr2.Visible = true;
                    btnIr1.Visible = true; // Asegúrate de que el botón esté visible
                    lblIngresarPlanilla.Visible = true;
                }
                else if (usuarioFiltrado is UsuarioCorriente)
                {
                    lblUsuarioTipo.Text = "Bienvenido Usuario Corriente";
                    lblVerPlanilla.Visible = true;
                    btnIr2.Visible = true; // Este botón es visible solo para usuarios corrientes
                    btnIr1.Visible = false; // Si es usuario corriente, deshabilitamos el botón para Admin
                }
            }
            else
            {
                lblUsuarioTipo.Text = "Usuario no encontrado";
            }
        }

        private void btnIr1_Click(object sender, EventArgs e)
        {
            Admin GoAdmin = new Admin(gestorUsuarios, usuarioEncontrado, planilla);
            GoAdmin.Show();
            this.Hide();
        }

        private void btnIr2_Click(object sender, EventArgs e)
        {
            Filtrado1 GoFil = new Filtrado1(gestorUsuarios, usuarioEncontrado, planilla); // Aquí también se pasa la planilla
            GoFil.Show();
            this.Hide();
        }

        // Evento para cerrar sesión
        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            // Confirmación de cierre de sesión
            var result = MessageBox.Show("¿Está seguro de que desea cerrar sesión?", "Cerrar sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Limpiar la instancia del usuario encontrado 
                usuarioEncontrado = null;

                // Mostrar el formulario de inicio de sesión 
                InicioSesion GoLogin = new InicioSesion(gestorUsuarios);
                GoLogin.Show();

                // Cerrar el formulario actual (Menu)
                this.Close();
            }
        }
    }
}