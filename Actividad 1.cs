using System;

namespace Actividad_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables
            double dato1 = 0, dato2 = 0, dato3 = 0, resultado1 = 0, resultado2 = 0, resultado3 = 0, resultado4 = 0;
            bool compara1 = false, compara2 = false, compara3 = false, compara4 = false, compara5 = false, compara6 = false;
            // Programa
            Console.Write("Dime el primer dato: ");
            dato1 = int.Parse(Console.ReadLine());
            Console.Write("Dime el segundo dato: ");
            dato2 = int.Parse(Console.ReadLine());
            Console.Write("Dime el tercer dato: ");
            dato3 = int.Parse(Console.ReadLine());
            resultado1 = dato1 + dato2 + dato3;
            resultado2 = dato1 * dato2 * dato3;
            resultado3 = (dato1 / dato2) + dato3;
            resultado4 = resultado1 / resultado2;
            compara1 = dato1 == dato2;
            compara2 = dato2 != dato3;
            compara3 = dato1 > dato3;
            compara4 = dato2 < resultado4;
            compara5 = compara1 & compara2;
            compara6 = compara3 | compara4;
            Console.WriteLine(" ");
            Console.WriteLine("El primer resultado es: " +resultado1);
            Console.WriteLine("El segundo resultado es: " +resultado2);
            Console.WriteLine("El tercer resultado es: " +resultado3);
            Console.WriteLine("El cuarto resultado es: " +resultado4);
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("La primera comparacion es: " +compara1);
            Console.WriteLine("La segunda comparacion es: " +compara2);
            Console.WriteLine("La tercera comparacion es: "+ compara3);
            Console.WriteLine("La cuarta comparacion es: " +compara4);
            Console.WriteLine("La quinta comparacion es: " +compara5);
            Console.WriteLine("La sexta comparacion es: " +compara6);
            Console.ReadLine();

        }
    }
}
