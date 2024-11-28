using Planilla_Lover;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Planilla_Lover
{
    public partial class Filtrado1 : Form
    {
        private GestorUsuarios gestorUsuarios;
        private Usuario usuarioEncontrado;
        private Planilla<Empleado> planilla;

        public Filtrado1(GestorUsuarios gestorUsuarios, Usuario usuarioEncontrado, Planilla<Empleado> planilla)
        {
            InitializeComponent();
            this.planilla = planilla; 
            this.gestorUsuarios = gestorUsuarios;
            this.usuarioEncontrado = usuarioEncontrado;
            ConfigurarListView1();
            ConfigurarListView2();
        }

        private void ConfigurarListView1()
        {
            // Configuración inicial del ListView
            listView1.View = View.Details;
            listView1.Columns.Add("Nombre", 150);
            listView1.Columns.Add("Cargo", 100);
            listView1.Columns.Add("Horas Trabajadas", 120);
            listView1.Columns.Add("Tarifa por Hora", 100);
            listView1.Columns.Add("Horas Extras", 100);
            listView1.Columns.Add("INSS", 100);
            listView1.Columns.Add("IR", 100);
            listView1.Columns.Add("Neto Obtenido", 100);
        }

        private void ConfigurarListView2()
        {
            // Configuración inicial del ListView
            listView2.View = View.Details;
            listView2.Columns.Add("Nombre", 150);
            listView2.Columns.Add("Cargo", 100);
            listView2.Columns.Add("Horas Trabajadas", 120);
            listView2.Columns.Add("Tarifa por Hora", 100);
            listView2.Columns.Add("Horas Extras", 100);
            listView2.Columns.Add("INSS", 100);
            listView2.Columns.Add("IR", 100);
            listView2.Columns.Add("Neto Obtenido", 100);
        }

        private void MostrarEmpleadosConIRMayor()
        {
            // Limpiar el ListView
            listView1.Items.Clear();

            try
            {
                // Verificar si la lista de empleados está vacía
                var empleadosConIR = planilla.ObtenerTodos().Cast<Empleado>().ToList();
                if (empleadosConIR.Count == 0)
                {
                    MessageBox.Show("No hay empleados disponibles en la lista.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Salir si la lista está vacía
                }

                // Filtrar empleados con IR mayor a 0
                var empleadosConIRFiltrados = empleadosConIR.Where(e => e.IR > 0).ToList();
                if (!empleadosConIRFiltrados.Any())
                {
                    MessageBox.Show("No hay empleados con IR mayor a 0.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return; // Salir si no hay empleados con IR
                }

                foreach (var empleado in empleadosConIRFiltrados)
                {
                    var item = new ListViewItem(new[]
                    {
                empleado.Nombre,
                empleado.Cargo,
                empleado.HorasTrabajadas.ToString(),
                empleado.TarifaPorHora.ToString("C"),
                empleado.HorasExtras.ToString(),
                empleado.INSS.ToString("C"),
                empleado.IR.ToString("C"),
                empleado.Neto_Obtenido.ToString("C")
            });
                    listView1.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al mostrar empleados con IR mayor: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MostrarEmpleadosSinIR()
        {
            // Limpiar el ListView
            listView2.Items.Clear();

            try
            {
                // Verificar si la lista de empleados está vacía
                var empleadosSinIR = planilla.ObtenerTodos().ToList();
                if (empleadosSinIR.Count == 0)
                {
                    MessageBox.Show("No hay empleados disponibles en la lista.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Salir si la lista está vacía
                }

                // Filtrar empleados sin IR
                var empleadosSinIRFiltrados = empleadosSinIR.Where(e => e.IR <= 0).ToList();
                if (!empleadosSinIRFiltrados.Any())
                {
                    MessageBox.Show("No hay empleados sin IR.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return; // Salir si no hay empleados sin IR
                }

                foreach (var empleado in empleadosSinIRFiltrados)
                {
                    var item = new ListViewItem(new[]
                    {
                        empleado.Nombre,
                        empleado.Cargo,
                        empleado.HorasTrabajadas.ToString(),
                        empleado.TarifaPorHora.ToString("C"),
                        empleado.HorasExtras.ToString(),
                        empleado.INSS.ToString("C"),
                        empleado.IR.ToString("C"),
                        empleado.Neto_Obtenido.ToString("C")
                    });
                    listView2.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al mostrar empleados sin IR: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btmMostrarEmpleado1_Click(object sender, EventArgs e)
        {
            MostrarEmpleadosConIRMayor();
        }

        private void btnMostrarEmpleado2_Click(object sender, EventArgs e)
        {
            MostrarEmpleadosSinIR();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu GoMenu = new Menu(gestorUsuarios, usuarioEncontrado, planilla);
            GoMenu.Show();
            this.Hide();
        }
    }
}