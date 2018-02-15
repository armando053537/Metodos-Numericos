using System;

namespace Tarea_4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*   Primer programa
            // Este programa mostrara en que numero n cambia el simbolo en la siguiente formula: n^2 - 100(n) + 900
            int n = 0, contador = 0;
            double numero = 0;

            // ============================================================================================================================================== \\

            Console.WriteLine(" En este programa mostrara en que numero n cambia el simbolo en la siguiente formula: n^2 - 100(n) + 900");
            // En este bucle empieza a buscar en que numero se transforma en negativo.
            do {
                n++;
                numero = Math.Pow(n, 2) - (100 * n) + 900;
                contador++;
            } while (numero >= -1);
            // Mostramos en cual numero la formula se vuelve negativa.
            System.Console.WriteLine(" El cambio de signo ocurre si el n es: " +contador);
            System.Console.ReadLine();
            //  Porgrama hecho por: Jesús Armando Ayala Silguero - 2706110
            */







            /*   Segundo programa
            // Este programa realiza una serie de fibonacci con datos ingresados por el usuario.
            int primero = 0, segundo = 0 , original = 0;

            // ============================================================================================================================================== \\

            // En este bucle se ingresaran los datos; El bucle terminara cuando el primero sea siempre menor que el segundo.
            do {
                System.Console.Write(" Dime el primer numero: ");
                primero = int.Parse(System.Console.ReadLine());
                System.Console.Write(" Dime el segundo numero: ");
                segundo = int.Parse(System.Console.ReadLine());
                // Si el segundo numero es menor que el primero, se mandará un error.
                if (primero > segundo) {
                    System.Console.WriteLine("\n El segundo numero no puede ser menor que el primero, fabor de ingresar nuevamente los numeros.\n");
                }

            } while (primero > segundo);

            System.Console.Write(" Serie de fibonacci. \n <" +primero+ ", " +segundo);
            // En este bucle se realiza la serie de fibonacci.
            for (int i = 0; i < 100; i++) {
                original = primero + segundo;
                segundo = primero;
                primero = original;
                System.Console.Write(", " +original);
            }
            
            System.Console.WriteLine(">");
            System.Console.ReadLine();
            //  Porgrama hecho por: Jesús Armando Ayala Silguero - 2706110
            */
        }
    }
}
