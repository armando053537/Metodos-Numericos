using System;

namespace Tarea_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables //
            int dato1 = 0, dato2 = 0, resultado1 = 0, resultado2 = 0, resultado3 = 0;
            bool comparacion1 = false, comparacion2 = false, comparacion3 = false;
            // Programa //
            Console.Write("Dime un numero: ");
            dato1 = int.Parse(Console.ReadLine());
            Console.Write("Dime otro numero: ");
            dato2 = int.Parse(Console.ReadLine());
            resultado1 = dato1 + dato2;
            resultado2 = dato1 * dato2;
            resultado3 = resultado1 % resultado2;
            comparacion1 = dato1 == dato2;
            comparacion2 = dato1 > dato2;
            comparacion3 = comparacion1 & comparacion2;
            Console.WriteLine(" ");
            Console.WriteLine("El primer resultado es: " +resultado1);
            Console.WriteLine("El segundo resultado es: " +resultado2);
            Console.WriteLine("El tercer resultado es: " +resultado3);
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("La primera comparacion es: " +comparacion1);
            Console.WriteLine("La segunda comparacion es: " +comparacion2);
            Console.WriteLine("La tercera comparacion es: " +comparacion3);
            Console.ReadLine();

        }
    }
}
