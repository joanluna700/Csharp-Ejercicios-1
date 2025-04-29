using System;

namespace Multiplicacion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola, bienvenido a la calculadora de multiplicación");

            Console.WriteLine("Por favor, ingrese el primer número:");

            int numero1 = Convert.ToInt32(Console.ReadLine()); //Numero 1

            Console.WriteLine("Por favor, ingrese el segundo número:");

            int numero2 = Convert.ToInt32(Console.ReadLine()); //Numero 2

            int multiplicacion = numero1 * numero2; //Operación de multiplicación de ambos numeros

            Console.WriteLine($"El resultado de la multiplicación de {numero1} y {numero2} es: {multiplicacion}"); //Metodo para presentar en la consola.

            Console.WriteLine("Si desea realizar otra operación, por favor, presione la tecla 'R' para reiniciar o 'S' para salir.");

            ConsoleKeyInfo tecla = Console.ReadKey();

            if(tecla.Key == ConsoleKey.R)
            {
                Main(args); // Reinicia el programa
            }
            else if (tecla.Key == ConsoleKey.S)
            {
                Environment.Exit(0); // Salir del programa
            }
            else
            {
                Console.WriteLine("Opción no válida. Saliendo del programa.");
                Environment.Exit(0); // Salir del programa
            }

        }
    }
}
