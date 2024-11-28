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
        private Planilla<Empleado> planilla;
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
            // Verificar que los campos no estén vacíos
            string nombre = txtNombre.Text;
            string Cargo = txtCargo.Text;
            string horasText = txtHoras.Text;
            string tarifaText = txtTarifa.Text;
            string horasExtraText = txtHExtra.Text;

            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(Cargo) ||
                string.IsNullOrWhiteSpace(horasText) || string.IsNullOrWhiteSpace(tarifaText) ||
                string.IsNullOrWhiteSpace(horasExtraText))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double horas, tarifa, horasExtra;

            // Intentar convertir los valores numéricos
            if (!double.TryParse(horasText, out horas))
            {
                MessageBox.Show("Por favor, ingrese un valor numérico válido para las horas trabajadas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!double.TryParse(tarifaText, out tarifa))
            {
                MessageBox.Show("Por favor, ingrese un valor numérico válido para la tarifa por hora.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!double.TryParse(horasExtraText, out horasExtra))
            {
                MessageBox.Show("Por favor, ingrese un valor numérico válido para las horas extras.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

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

            // Agregar el empleado a la planilla
            planilla.Agregar(empleado);

            // Crear una instancia del segundo formulario
            Menu GoMenu = new Menu();

            // Mostrar el segundo formulario
            GoMenu.Show();

            // Ocultar el formulario actual (Form1)
            this.Hide();
        }
    }
}