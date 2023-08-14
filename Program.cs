using System;

namespace EcuacionRaizCuadrada
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Resolución de Ecuaciones Cuadráticas");
            Console.WriteLine("====================================");

            Console.Write("Ingrese el coeficiente a: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Ingrese el coeficiente b: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Ingrese el coeficiente c: ");
            double c = double.Parse(Console.ReadLine());

            double discriminante = b * b - 4 * a * c;

            if (discriminante >= 0)
            {
                double x1 = (-b + Math.Sqrt(discriminante)) / (2 * a);
                double x2 = (-b - Math.Sqrt(discriminante)) / (2 * a);

                Console.WriteLine($"Solución x1: {x1}");
                Console.WriteLine($"Solución x2: {x2}");
            }
            else
            {
                Console.WriteLine("La ecuación no tiene soluciones reales.");
            }
        }
    }
}