using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variables de inicialización
            int a = 0;
            int b = 1;

            int c = 0; //Variable de almacenamiento

            Console.WriteLine("Serie de Fibonacci del 1 al 50:");

            while (c <= 50)
            {
                if (c >= 1)
                {
                    Console.Write(c + " ");
                }

                c = a + b;
                a = b;
                b = c;
            }

            Console.WriteLine(); // Salto de línea al final
        }
    }
}
