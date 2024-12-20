using Planilla_Lover;
using System;
using System.Linq;
using System.Windows.Forms;

namespace PLANILLA_LOVERS
{
    public partial class InicioSesion : Form
    {
        private GestorUsuarios gestorUsuarios; 
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
                // Verificar si gestorUsuarios est� vac�o o sin inicializar
                if (gestorUsuarios == null || !gestorUsuarios.ObtenerUsuarios().Any())
                {
                    throw new InvalidOperationException("La lista de usuarios est� vac�a. Por favor, agregue usuarios antes de iniciar sesi�n.");
                }

                // Pedir informaci�n del formulario
                string username = usuariotxt.Text;
                string password = contratxt.Text;

                // Verificar que los campos no est�n vac�os
                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Por favor, ingrese ambos campos: usuario y contrase�a.");
                    return;
                }

                // Buscar el usuario en la lista
                var usuarioEncontrado = gestorUsuarios.ObtenerUsuarios()
                    .FirstOrDefault(u => u.Nombre == username && u.Contrase�a == password);

                // Verificar si el usuario es v�lido
                if (usuarioEncontrado != null)
                {
                    MessageBox.Show($"Bienvenido, {usuarioEncontrado.Nombre}!");
                    Menu GoMenu = new Menu(gestorUsuarios, usuarioEncontrado, planilla);
                    GoMenu.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario o contrase�a incorrectos. Por favor, intente de nuevo.");
                }
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurri� un error inesperado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void nuevousuariobtn_Click(object sender, EventArgs e)
        {
            NuevoUsuario GoUser = new NuevoUsuario(gestorUsuarios);
            GoUser.Show();
            this.Hide();
        }

        private void nuevoAdminbtn_Click(object sender, EventArgs e)
        {
            Acces_Admincs GoAcces = new Acces_Admincs(gestorUsuarios);
            GoAcces.Show();
            this.Hide();
        }
    }
}
