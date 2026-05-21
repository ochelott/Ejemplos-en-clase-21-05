using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double promedio;
            #region Inicializacion opcion, acum y cout
            int opcion = 0;
            int acum = 0;
            int cout = 0;
            #endregion
            #region Iterar 20 zonas
            for (int n = 0; n < 20; n++)
            {
                #region Solicitar un num
                Console.WriteLine("Ingresar un numero");
                int num = Convert.ToInt32(Console.ReadLine());
                #endregion
                #region Actualizar acumulador
                acum = acum + num;
                #endregion
                #region Actualizar contador
                cout = cout + 1;
                #endregion
            }
            #endregion

            #region Calcular Promedio
            promedio = 1.0 * acum / cout;
            #endregion
            #region Mostrar Promedio
            Console.WriteLine($"Promedio : {promedio}");
            #endregion
            Console.WriteLine("Presione cualquier tecla");
            Console.ReadKey();
        }
    }
}

