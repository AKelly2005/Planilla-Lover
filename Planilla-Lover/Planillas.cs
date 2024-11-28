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

    public abstract class Empleado
    {
        public string Nombre { get; set; }
        public string Cargo { get; set; }
        public double HorasTrabajadas { get; set; }
        public double TarifaPorHora { get; set; }
        public double IR { get; set; }
        public double INSS { get; set; }
        public double TotalDevengado {  get; set; }
        public double Neto_Obtenido { get; set; }

        public double CalcularDevengado()
        {
            TotalDevengado = HorasTrabajadas * TarifaPorHora;
            return TotalDevengado;
        }

        public virtual double CalcularINSS()
        {
            INSS = CalcularDevengado() * 0.07; // 7% INSS
            return INSS;
        }

        public abstract double CalcularIR();


        public double CalcularNeto()
        {
            Neto_Obtenido = CalcularDevengado() - CalcularINSS() - CalcularIR();
            return Neto_Obtenido;
                
        }
    }

    public class EmpleadoCompleto : Empleado
    {
        public override double CalcularIR()
        {
            {
                double total = CalcularDevengado() - CalcularINSS();
                double Anual = total * 12;
                double porcentaje = 0;
                double totalIR = 0;
                double sobreexceso = 0;
                if (Anual < 100001)
                {
                    IR = 0;
                }
                else
                {
                    if (Anual < 200001)
                    {
                        sobreexceso = Anual - 100000;
                        porcentaje = sobreexceso * 0.15;
                        totalIR = sobreexceso - porcentaje;
                        IR = totalIR;
                    }
                    else
                    {
                        if (Anual < 350000)
                        {
                            sobreexceso = Anual - 200000;
                            porcentaje = sobreexceso * 0.20;
                            totalIR = 15000 + (sobreexceso - porcentaje);
                            IR = totalIR;
                        }
                        else
                        {
                            if (Anual < 500000)
                            {
                                sobreexceso = Anual - 350000;
                                porcentaje = sobreexceso * 0.25;
                                totalIR = 45000 + (sobreexceso - porcentaje);
                                IR = totalIR;
                            }
                            else
                            {
                                if (Anual > 500001)
                                {
                                    sobreexceso = Anual - 500000;
                                    porcentaje = sobreexceso * 0.30;
                                    totalIR = 82500 + (sobreexceso - porcentaje);
                                    IR = totalIR;
                                }
                            }
                        }
                    }
                }

                return IR;
            }
        }
        public class Administrador : Planilla<Empleado>
        {

            public void GenerarReporte()
            {
                Console.WriteLine("Reporte de Empleados:");
                foreach (var empleado in items)
                {
                    Console.WriteLine($"Nombre: {empleado.Nombre}, Cargo: {empleado.Cargo}");
                }
            }
        }
    }
}
