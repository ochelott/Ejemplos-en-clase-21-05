using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int acum = 0; int cont = 0;
            #region Declaracion y definicion
            int[] vector = new int[20];
            #endregion
            #region Inicializacion 
            for (int n = 0; n < 20; n++)
            {
                Console.WriteLine("ingrese..");
                int valor = Convert.ToInt32(Console.ReadLine());
                vector[n] = valor;
            }
            #endregion
            #region CalcularPromedio
            for (int n = 0; n <= 20; n++)
            {
                acum += vector[n];
                cont++;
            }
            #endregion
            double Promedio = 1.0 * acum / cont;
            Console.WriteLine($"Promedio: {Promedio}");
            Console.ReadKey();
        }
    }
}
