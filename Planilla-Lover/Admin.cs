﻿using Planilla_Lover;
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
        private GestorUsuarios gestorUsuarios;
        private Usuario usuarioEncontrado;
        private Planilla<Empleado> planilla;

        public Admin(GestorUsuarios gestorUsuarios, Usuario usuarioEncontrado,Planilla<Empleado> planilla)
        {
            InitializeComponent();
            this.gestorUsuarios = gestorUsuarios;
            this.usuarioEncontrado = usuarioEncontrado;
            // Inicialización de la planilla
            this.planilla = planilla;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Crear una instancia del segundo formulario
            Menu GoMenu = new Menu(gestorUsuarios, usuarioEncontrado, planilla);
            // Mostrar el segundo formulario
            GoMenu.Show();
            // Ocultar el formulario actual
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

            // Creación del objeto empleado
            Empleado empleado = new EmpleadoCompleto
            {
                Nombre = nombre,
                Cargo = Cargo,
                HorasTrabajadas = horas,
                TarifaPorHora = tarifa,
                HorasExtras = horasExtra
            };

            // Cálculos de los valores
            empleado.CalcularDevengado();
            empleado.CalcularINSS();
            empleado.CalcularIR();
            empleado.CalcularNeto();

            /// Agregar a la planilla
            planilla.Agregar(empleado);

            // Verificar si los empleados están siendo agregados correctamente
            MostrarEmpleadosEnPlanilla();

            // Mostrar mensaje de éxito
            MessageBox.Show("Empleado agregado a la planilla correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // Mostrar formulario Menu
            Menu GoMenu = new Menu(gestorUsuarios, usuarioEncontrado, planilla);
            GoMenu.Show();
            this.Hide();
        }
        private void MostrarEmpleadosEnPlanilla()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var empleado in planilla.ObtenerTodos()) // Asumiendo que tienes un método ObtenerTodos() en Planilla
            {
                sb.AppendLine($"Nombre: {empleado.Nombre}, Cargo: {empleado.Cargo}, Horas Trabajadas: {empleado.HorasTrabajadas}, Tarifa por Hora: {empleado.TarifaPorHora}, Horas Extras: {empleado.HorasExtras}, INSS: {empleado.INSS}, IR: {empleado.IR}, Neto: {empleado.Neto_Obtenido}");
            }

            MessageBox.Show(sb.ToString(), "Empleados en Planilla", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}