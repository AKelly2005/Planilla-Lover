using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Planilla_Lover
{
    public partial class Menu : Form
    {
        private GestorUsuarios gestorUsuarios; // Instancia del gestor de usuarios
        private Usuario usuarioEncontrado; // El usuario que ha iniciado sesión

        // Constructor que recibe el gestor de usuarios y el usuario autenticado
        public Menu(GestorUsuarios gestorUsuarios, Usuario usuarioEncontrado)
        {
            InitializeComponent();
            this.gestorUsuarios = gestorUsuarios;
            this.usuarioEncontrado = usuarioEncontrado;
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
                    // Habilitar controles específicos para administradores
                }
                else if (usuarioFiltrado is UsuarioCorriente)
                {
                    lblUsuarioTipo.Text = "Bienvenido Usuario Corriente";
                    // Ajustar controles para usuarios comunes
                }
            }
            else
            {
                lblUsuarioTipo.Text = "Usuario no encontrado";
            }
        }
    }
}