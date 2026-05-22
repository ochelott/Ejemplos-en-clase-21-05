using System;

namespace Ejemplos_en_clase
{
    class Program
    {
        private static int opcion;

        static void Main(string[] args)
        {
            

            do
            {
                int opcion = Calculos.MostrarPantallaSolicitarOpcionMenu();

                switch (opcion)
                {
                    case 1:
                        Calculos.MostrarPantallaIngresarNumero();
                        break;
                    case 2:
                        Calculos.MostrarPantallaCalcularYMostrarPromedio();

                        break;
                    default:
                        opcion = -1;
                        break;
                }
            } while (opcion != 1);
            Console.WriteLine("Presione un tecla para finalizar");
            Console.ReadKey();
        }
    }
}

