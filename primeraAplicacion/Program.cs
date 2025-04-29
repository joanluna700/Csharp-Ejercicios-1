using System;

namespace primeraAplicacion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero1 = 30; //Numero 1
            int numero2 = 23; //Numero 2

            int division = numero1 / numero2; //Operación de división de ambos numeros

            Console.WriteLine($"El resultado de la división de {numero1} y {numero2} es: {division}"); //Metodo para presentar en la consola.
            Console.ReadKey(); //Metodo para esperar a una tecla.
        }
    }
}
