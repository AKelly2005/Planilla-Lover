using Planilla_Lover;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Planilla_Lover
{
    public partial class Filtrado1 : Form
    {
        private Planilla<Empleado> empleados;

        // Modificamos el constructor para recibir la lista de empleados
        public Filtrado1(Planilla<Empleado> empleados)
        {
            InitializeComponent();
            this.empleados = empleados; // Asignamos la lista de empleados
            ConfigurarListView1();
            ConfigurarListView2();
            MostrarEmpleadosConIRMayor(); // Mostrar los empleados con IR mayor que 0
            MostrarEmpleadosSinIR(); // Mostrar los empleados sin IR
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

            // Filtrar empleados con IR mayor
            var empleadosConIR = empleados.ObtenerTodos().Where(e => e.IR > 0);
            foreach (var empleado in empleadosConIR)
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

        private void MostrarEmpleadosSinIR()
        {
            // Limpiar el ListView
            listView2.Items.Clear();

            // Filtrar empleados sin IR
            var empleadosSinIR = empleados.ObtenerTodos().Where(e => e.IR < 1);
            foreach (var empleado in empleadosSinIR)
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
    }
}