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
        public NuevoUsuario()
        {
            InitializeComponent();
        }

        private void Agregarbtn_Click(object sender, EventArgs e)
        {
            // Crear una instancia del segundo formulario
            InicioSesion GoInicio = new InicioSesion();

            // Mostrar el segundo formulario
            GoInicio.Show();

            // Ocultar el formulario actual (Form1)
            this.Hide();
        }
    }
}
