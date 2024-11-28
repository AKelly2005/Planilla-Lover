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

namespace Planilla_Lover
{

    public partial class Acces_Admincs : Form
    {

        private GestorUsuarios gestorUsuarios;
        // Código predefinido
        private const string CodigoCorrecto = "12345";

        public Acces_Admincs(GestorUsuarios gestorUsuarios)
        {
            InitializeComponent();
            this.gestorUsuarios = gestorUsuarios;
        }

        // Evento del botón para verificar el código
        private void btnVerificar_Click(object sender, EventArgs e)
        {
            // Obtener el código ingresado en el TextBox
            string codigoIngresado = txtCodigo.Text.Trim();

            // Verificar si el código ingresado es igual al código predefinido
            if (codigoIngresado == CodigoCorrecto)
            {
                NuevoAdmin nuevoAdminForm = new NuevoAdmin(gestorUsuarios); 
                nuevoAdminForm.Show();
                this.Hide(); 
            }
            else
            {
                // Si el código es incorrecto, mostrar un mensaje de error
                MessageBox.Show("Código incorrecto. Intente nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            InicioSesion nuevoInicio = new InicioSesion(gestorUsuarios);
            nuevoInicio.Show();
            this.Hide();
        }
    }
}