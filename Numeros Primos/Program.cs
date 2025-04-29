using System;

namespace Numeros_Primos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite un numero para saber si es primo");

            //Obtenemos el numero
            int numero = Convert.ToInt32(Console.ReadLine());


            if(numero < 0)
            {
                Console.WriteLine($"Digite un numero entero.");
            }
            else if(numero == 1 || numero == 0)
            {

                Console.WriteLine($"El numero {numero} no es primo");
            }
            else
            {
                bool esPrimo = true;
                for (int i = 2; i <= Math.Sqrt(numero); i++)
                {
                    Console.WriteLine(i);


                    if (numero % i == 0)
                    {
                        esPrimo = false;
                        break;
                    }
                }

                if (esPrimo)
                {
                    Console.WriteLine($"{numero} es un número primo.");
                }
                else
                {
                    Console.WriteLine($"{numero} no es un número primo.");
                }
            }
        }
    }
}
