using System;
using System.Runtime.Remoting.Contexts;

namespace Formula_General
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Solución a ecuaciones cuadráticas mediante la fórmula general");

            //Solicitar al usuario los coeficientes a, b, c
            Console.WriteLine("Ingrese el valor de a:");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese el valor de b:");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese el valor de c:");
            double c = Convert.ToDouble(Console.ReadLine());

            //Conprobar que a no es 0, ya que es una ecuacion cuadratica

            if(a == 0)
            {
                Console.WriteLine("El coeficiente 'a' no puede ser 0, ya que es una ecuacion cuadratica");
                return;
            }

            //Calculamos el discriminante
            double discriminante = b * b - 4 * a * c;


            //Determinar cual es la naturaleza de las raices

            if(discriminante > 0)
            {

                //Dos raices reales y distintas
                double x1 = (-b + Math.Sqrt(discriminante)) / (2 * a);
                double x2 = (-b - Math.Sqrt(discriminante)) / (2 * a);
                Console.WriteLine($"Las soluciones reales son: x1 = {Math.Round(x1, 3)}, x2 = {Math.Round(x2, 2)}");
            }
            else if(discriminante == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine($"La solucion real doble es: x = {x}");
            }
            else
            {
                // Raices complejas
                double parteReal = -b / (2 * a);
                double parteImaginaria = Math.Sqrt(-discriminante) / (2 * a);
                Console.WriteLine($"Las soluciones complejas son: x1 = {parteReal} + {parteImaginaria}i, x2 = {parteReal} - {parteImaginaria}i");
            }
        }
    }
}
