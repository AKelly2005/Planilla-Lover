using Planilla_Lover;
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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Crear una instancia del segundo formulario
            Menu GoMenu = new Menu();

            // Mostrar el segundo formulario
            GoMenu.Show();

            // Ocultar el formulario actual (Form1)
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Captura de datos
            string nombre = txtNombre.Text;
            string Cargo = txtCargo.Text;
            double horas = double.Parse(txtHoras.Text);
            double tarifa = double.Parse(txtTarifa.Text);
            double horasExtra = double.Parse(txtHExtra.Text);

            // Creación del objeto según el tipo
            Empleado empleado = new EmpleadoCompleto();

            empleado.Nombre = nombre;
            empleado.Cargo = Cargo;
            empleado.HorasTrabajadas = horas;
            empleado.TarifaPorHora = tarifa;
            empleado.HorasExtras = horasExtra;

            // Cálculos
            double devengado = empleado.CalcularDevengado();
            double inss = empleado.CalcularINSS();
            double ir = empleado.CalcularIR();
            double neto = empleado.CalcularNeto();
                
            // Crear una instancia del segundo formulario
            Menu GoMenu = new Menu();

            // Mostrar el segundo formulario
            GoMenu.Show();

            // Ocultar el formulario actual (Form1)
            this.Hide();


        }
    }
}
