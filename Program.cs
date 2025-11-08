using System;

namespace DatosYFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion;

            do
            {
                Console.Clear();
                Console.WriteLine("=== MENÚ PRINCIPAL ===");
                Console.WriteLine("1. Ingresar y mostrar datos personales");
                Console.WriteLine("2. Calcular factorial de un número");
                Console.WriteLine("3. Salir");
                Console.Write("Seleccione una opción: ");
                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        IngresarDatos();
                        break;

                    case 2:
                        CalcularFactorial();
                        break;

                    case 3:
                        Console.WriteLine("\nSaliendo del programa...");
                        break;

                    default:
                        Console.WriteLine("\nOpción no válida. Intente de nuevo.");
                        break;
                }

                if (opcion != 3)
                {
                    Console.WriteLine("\nPresione cualquier tecla para continuar...");
                    Console.ReadKey();
                }

            } while (opcion != 3);
        }

        static void IngresarDatos()
        {
            Console.Clear();
            Console.WriteLine("=== INGRESO DE DATOS PERSONALES ===");

            Console.Write("Ingrese su nombre: ");
            string nombre = Console.ReadLine();

            Console.Write("Ingrese su carné: ");
            string carné = Console.ReadLine();

            Console.Write("Ingrese su DPI: ");
            string dpi = Console.ReadLine();

            Console.Write("Ingrese su fecha de nacimiento (dd/mm/aaaa): ");
            string fechaNacimiento = Console.ReadLine();

            Console.WriteLine("\n=== DATOS INGRESADOS ===");
            Console.WriteLine($"Nombre: {nombre}");
            Console.WriteLine($"Carné: {carné}");
            Console.WriteLine($"DPI: {dpi}");
            Console.WriteLine($"Fecha de nacimiento: {fechaNacimiento}");
        }

        static void CalcularFactorial()
        {
            Console.Clear();
            Console.WriteLine("=== CÁLCULO DE FACTORIAL ===");

            Console.Write("Ingrese un número entero: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            long factorial = 1;
            for (int i = 1; i <= numero; i++)
            {
                factorial *= i;
            }

            Console.WriteLine($"\nEl factorial de {numero} es: {factorial}");
        }
    }
}
