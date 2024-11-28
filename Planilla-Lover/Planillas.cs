using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planilla_Lover
{

    public interface UsPlanilla<T>
    {
        void Agregar(T item);
        void Eliminar(T item);
        List<T> ObtenerTodos();
        T BuscarPorUs(int Usuario);
    }

   
    public class Planilla<T> : UsPlanilla<T> where T : class
    {
        protected List<T> items = new List<T>();

        public void Agregar(T item)
        {
            items.Add(item);
        }

        public void Eliminar(T item)
        {
            items.Remove(item);
        }

        public List<T> ObtenerTodos()
        {
            return items;
        }

        public T BuscarPorUs(int usuario)
        {
            var property = typeof(T).GetProperty("Usuario");
            return items.FirstOrDefault(item => (int)property.GetValue(item) == usuario);
        }
    }

    public class Empleado
    {
        public int Usuario { get; set; }
        public string Nombre { get; set; }
        public string Cargo { get; set; }
    }

    
    public class Administrador : Planilla<Empleado>
    {
        
        public void GenerarReporte()
        {
            Console.WriteLine("Reporte de Empleados:");
            foreach (var empleado in items)
            {
                Console.WriteLine($"Usuario: {empleado.Usuario}, Nombre: {empleado.Nombre}, Cargo: {empleado.Cargo}");
            }
        }
    }

    // Clase Program para interactuar con el usuario
    public class Programa
    {
        public static void Main()
        {
            Administrador administrador = new Administrador();

            Console.WriteLine("¿Cuántos empleados deseas agregar?");
            int numeroEmpleados;

            // Validación de entrada para cantidad de empleados
            while (!int.TryParse(Console.ReadLine(), out numeroEmpleados) || numeroEmpleados <= 0)
            {
                Console.WriteLine("Por favor, ingresa un número válido de empleados.");
            }

            // Solicitar datos de cada empleado
            for (int i = 0; i < numeroEmpleados; i++)
            {
                Console.WriteLine($"\nIngrese los datos del empleado {i + 1}:");

                Empleado empleado = new Empleado();

                
                Console.Write("Usuario: ");
                while (!int.TryParse(Console.ReadLine(), out int usuario) || usuario <= 0)
                {
                    Console.WriteLine("Por favor, ingresa un Usuario válido.");
                }
                Empleado Usuario = new Empleado();

                
                Console.Write("Nombre: ");
                empleado.Nombre = Console.ReadLine();

                
                Console.Write("Cargo: ");
                empleado.Cargo = Console.ReadLine();

                
                administrador.Agregar(empleado);
            }

            
            Console.WriteLine("\n--- Reporte de Empleados ---");
            administrador.GenerarReporte();
        }
    }

}
