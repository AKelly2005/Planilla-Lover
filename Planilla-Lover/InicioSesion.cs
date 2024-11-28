using Planilla_Lover;

namespace PLANILLA_LOVERS
{
    public partial class InicioSesion : Form
    {
        public InicioSesion()
        {
            InitializeComponent();
        }

        private void iniciobtn_Click(object sender, EventArgs e)
        {
            Menu GoMenu = new Menu();

            // Mostrar el segundo formulario
            GoMenu.Show();

            // Ocultar el formulario actual (Form1)
            this.Hide();
        }

        private void nuevousuariobtn_Click(object sender, EventArgs e)
        {
            // Crear una instancia del segundo formulario
            NuevoUsuario GoNuevoUser = new NuevoUsuario();

            // Mostrar el segundo formulario
            GoNuevoUser.Show();

            // Ocultar el formulario actual (Form1)
            this.Hide();
        }

        private void nuevoAdminbtn_Click(object sender, EventArgs e)
        {
            NuevoAdmin GonuevoAdmin = new NuevoAdmin();

            // Mostrar el segundo formulario
            GonuevoAdmin.Show();

            // Ocultar el formulario actual (Form1)
            this.Hide();
        }
    }
}
