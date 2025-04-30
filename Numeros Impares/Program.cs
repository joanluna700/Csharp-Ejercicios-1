using System;

namespace Numeros_Impares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Los numeros impares del 1 al 30 son: ");

            for (int i = 1; i <= 30; i += 2)
            {
                Console.WriteLine(i + " ");
            }
        }
    }
}
