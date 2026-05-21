using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo3
{
    internal class Program
    {
        static int acum = 0; 
        static int cont = 0;
        static void IngresarNumero(int num)
        {
            acum = acum + num;
            cont++;
        }
        static double CalcularPromedio()
        {
            double Promedio = 0;
            if (cont > 0)
            {
               Promedio = 1.0 * acum / cont;
                
            }
            return Promedio;
        }
        static int MostrarPantallaSolicitarOpcionMenu() 
        {
            Console.Clear();
            Console.WriteLine("Titulo 1");
            Console.WriteLine("1 - Ingrese nro");
            Console.WriteLine("2 - Calcular y Mostrar Promedio");
            Console.WriteLine("Otro - Salir");
            int opcion = Convert.ToInt32(Console.ReadLine());
            return opcion;
        }
        static void MostrarPantallaIngresarNumero() 
        {
            Console.Clear();
            Console.WriteLine("Ingrese el nro");
            int num = Convert.ToInt32(Console.ReadLine());
            Program.IngresarNumero (num);
        }
        static void MostrarPantallaCalcularYMostrarPromedio()
        {
            Console.Clear();
            Console.WriteLine("Titulo Pantalla 2");
            double promedio = Program.CalcularPromedio();
            Console.WriteLine($"Promedio: {promedio}");
            Console.WriteLine("Presione un tecla");
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            int opcion = 0;
            do
            {
                opcion = Program.MostrarPantallaSolicitarOpcionMenu();
                switch (opcion)
                {
                    case 1:
                        Program.MostrarPantallaIngresarNumero();
                        break;
                    case 2:
                        Program.MostrarPantallaCalcularYMostrarPromedio();
                        break;
                    default:
                        opcion = -1;
                        break;
                }   
            }while (opcion != 1) ;
                Console.WriteLine("Presione un tecla para finalizar");
                Console.ReadKey();
            }
        }
    }

