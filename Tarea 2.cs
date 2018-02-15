using System;

namespace Tarea_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables \\
            double numero = 0, raiz = 0, parimpar = 0;

            // Programa \\
            Console.Write(" Dime cualquier numero (puede ser con punto decimal): ");
            numero = double.Parse(Console.ReadLine());
            parimpar = numero % 2;

            if (parimpar == 1) {
                Console.WriteLine(" El numero es par.");
            } else {
                Console.WriteLine(" El numero es un impar");
            }

            if ((numero % 1) == 0) {
                Console.WriteLine(" El numero que escogio es entero.");
            } else {
                Console.WriteLine(" El numero que escogio es una fraccion.");
            }

            raiz = Math.Sqrt(numero);
            Console.WriteLine(" La raiz cuadrada del numero " +numero+ " es: " +raiz);
            Console.ReadLine();
        }
    }
}
