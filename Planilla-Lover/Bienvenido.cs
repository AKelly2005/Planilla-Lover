using PLANILLA_LOVERS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace Planilla_Lover
{
    public partial class Bienvenido : Form
    {
        private GestorUsuarios gestorUsuarios;
        public Bienvenido()
        {
            InitializeComponent();
            gestorUsuarios = new GestorUsuarios();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Enviar al usuario a inicio de Sesion
            InicioSesion GoInicio = new InicioSesion(gestorUsuarios);

            // Mostrar Inicio de Sesion
            GoInicio.Show();

            // Ocultar el formulario actual
            this.Hide();
        }

        private void Bienvenido_Load(object sender, EventArgs e)
        {
            pbImagen.Image = Image.FromFile(@"C:\Users\aidan\source\repos\Planilla-Lover\Logo.png");
        }
    }
}
