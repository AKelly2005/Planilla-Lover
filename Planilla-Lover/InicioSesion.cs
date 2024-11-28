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
            //Pedir información del formulario
            //Verificar que no esten vacios
            //compararla con la listas de usuarios ya ingresados
            //si existe continuar con lo el GoMenu


            // Crear una instancia del Menu
            Menu GoMenu = new Menu();
            // Mostrar el Menu
            GoMenu.Show();

            // Ocultar el Inicio de Sesión
            this.Hide();
        }

        private void nuevousuariobtn_Click(object sender, EventArgs e)
        {
            // Crear una instancia del Nuevo Usuario
            NuevoUsuario GoNuevoUser = new NuevoUsuario();

            // Mostrar el formulario del Nuevo Usuario
            GoNuevoUser.Show();

            // Ocultar el Inicio de Sesión
            this.Hide();
        }

        private void nuevoAdminbtn_Click(object sender, EventArgs e)
        {

            // Crear una instancia del Nuevo Admin
            NuevoAdmin GonuevoAdmin = new NuevoAdmin();

            // Mostrar el formulario del Nuevo Admin
            GonuevoAdmin.Show();

            // Ocultar el Inicio de Sesión
            this.Hide();
        }
    }
}
