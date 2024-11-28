using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planilla_Lover
{

    // Interfaz para Planilla
    public interface UsPlanilla<T>
    {
        void Agregar(T item);
        IEnumerable<T> ObtenerTodos();
    }

    // Clase Planilla que implementa UsPlanilla
    public class Planilla<T> : UsPlanilla<T> where T : class
    {
        private List<T> items = new List<T>();

        public void Agregar(T item)
        {
            items.Add(item);
        }

        // Cambiar el tipo de retorno a IEnumerable<T> o List<T>
        public IEnumerable<T> ObtenerTodos()
        {
            return items;
        }
    }

    public abstract class Empleado
    {
        public string Nombre { get; set; }
        public string Cargo { get; set; }
        public double HorasTrabajadas { get; set; }
        public double TarifaPorHora { get; set; }
        public double HorasExtras { get; set; }
        public double IR { get; set; }
        public double INSS { get; set; }
        public double TotalDevengado { get; set; }
        public double Neto_Obtenido { get; set; }

        // Calcula el devengado total
        public double CalcularDevengado()
        {
            TotalDevengado = HorasTrabajadas * TarifaPorHora + (HorasExtras * (2 * TarifaPorHora));
            return TotalDevengado;
        }

        // Calcula el INSS
        public virtual double CalcularINSS()
        {
            INSS = CalcularDevengado() * 0.07; // 7% INSS
            return INSS;
        }

        // Método abstracto para calcular el IR
        public abstract double CalcularIR();

        // Calcula el neto obtenido
        public double CalcularNeto()
        {
            Neto_Obtenido = CalcularDevengado() - CalcularINSS() - CalcularIR();
            return Neto_Obtenido;
        }
    }

    public class EmpleadoCompleto : Empleado
    {
        // Implementación del cálculo del IR para un empleado completo
        public override double CalcularIR()
        {
            double total = CalcularDevengado() - CalcularINSS();
            double anual = total * 12;
            double porcentaje = 0;
            double totalIR = 0;
            double sobreexceso = 0;

            if (anual < 100001)
            {
                IR = 0;
            }
            else if (anual < 200001)
            {
                sobreexceso = anual - 100000;
                porcentaje = sobreexceso * 0.15;
                totalIR = sobreexceso - porcentaje;
                IR = totalIR;
            }
            else if (anual < 350000)
            {
                sobreexceso = anual - 200000;
                porcentaje = sobreexceso * 0.20;
                totalIR = 15000 + (sobreexceso - porcentaje);
                IR = totalIR;
            }
            else if (anual < 500000)
            {
                sobreexceso = anual - 350000;
                porcentaje = sobreexceso * 0.25;
                totalIR = 45000 + (sobreexceso - porcentaje);
                IR = totalIR;
            }
            else
            {
                if (anual > 500001)
                {
                    sobreexceso = anual - 500000;
                    porcentaje = sobreexceso * 0.30;
                    totalIR = 82500 + (sobreexceso - porcentaje);
                    IR = totalIR;
                }
            }

            return IR;
        }
    }
}
