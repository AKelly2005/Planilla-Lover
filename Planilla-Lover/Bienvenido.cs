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
        public Bienvenido()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
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
