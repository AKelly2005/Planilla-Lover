using Planilla_Lover;
using System;
using System.Linq;
using System.Windows.Forms;

namespace PLANILLA_LOVERS
{
    public partial class InicioSesion : Form
    {
        private GestorUsuarios gestorUsuarios; // Instancia del gestor de usuarios
        private Planilla<Empleado> planilla;

        public InicioSesion(GestorUsuarios gestorUsuarios)
        {
            InitializeComponent();
            this.gestorUsuarios = gestorUsuarios;
            planilla = new Planilla<Empleado>();
        }

        private void iniciobtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Verificar si gestorUsuarios está vacío o sin inicializar
                if (gestorUsuarios == null || !gestorUsuarios.ObtenerUsuarios().Any())
                {
                    throw new InvalidOperationException("La lista de usuarios está vacía. Por favor, agregue usuarios antes de iniciar sesión.");
                }

                // Pedir información del formulario
                string username = usuariotxt.Text;
                string password = contratxt.Text;

                // Verificar que los campos no estén vacíos
                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Por favor, ingrese ambos campos: usuario y contraseña.");
                    return;
                }

                // Buscar el usuario en la lista
                var usuarioEncontrado = gestorUsuarios.ObtenerUsuarios()
                    .FirstOrDefault(u => u.Nombre == username && u.Contraseña == password);

                // Verificar si el usuario es válido
                if (usuarioEncontrado != null)
                {
                    MessageBox.Show($"Bienvenido, {usuarioEncontrado.Nombre}!");

                    //Acceder aL Menu
                    Menu GoMenu = new Menu(gestorUsuarios, usuarioEncontrado, planilla);
                    GoMenu.Show();
                    // Ocultar el formulario actual
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos. Por favor, intente de nuevo.");
                }
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error inesperado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void nuevousuariobtn_Click(object sender, EventArgs e)
        {
            NuevoUsuario GoUser = new NuevoUsuario(gestorUsuarios);

            // Mostrar el formulario del Nuevo Usuario
            GoUser.Show();

            // Ocultar el formulario actual
            this.Hide();
        }

        private void nuevoAdminbtn_Click(object sender, EventArgs e)
        {
            Acces_Admincs GoAcces = new Acces_Admincs(gestorUsuarios);

            // Mostrar el formulario del Nuevo Usuario
            GoAcces.Show();

            // Ocultar el formulario actual
            this.Hide();
        }
    }
}
