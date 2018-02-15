using System;

namespace Evidencia_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Este programa el usuario creara una matriz que sea menor de 10 lineas verticales y horizontales, y dependiendo si los datos son pares, los datos
             * se dividiran en 2; si los datos son nones, se multiplicaran por 3 y se sumara un 1.
            */
            int vertical = 0, horizontal = 0, numero = 0;
            int[,] matriz;
            bool sino = false;

            //  ============================================================================================================  \\
            // Se piden las medidas de la matriz.
            Console.Write(" Dime la cantidad vertical de la matriz: ");
            vertical = int.Parse(Console.ReadLine());
            Console.Write(" Dime la cantidad horizontal de la matriz: ");
            horizontal = int.Parse(Console.ReadLine());
            // En este bucle se compara si los datos ingresados son menos que 10.
            do {
                sino = false;

                if ((horizontal <= 10) && (vertical <= 10)) {
                    sino = true;
                } else {
                    Console.Write(" La matriz es muy grande, fabor de ingresar un nuevo numero vertical: ");
                    vertical = int.Parse(Console.ReadLine());
                    Console.Write(" Nuevo numero horizontal: ");
                    horizontal = int.Parse(Console.ReadLine());
                }

            } while (sino != true);
            // Se crea la matriz.
            matriz = new int [vertical,horizontal];
            // En este bucle se ingresaran los datos.
            for (int i = 0; i < vertical; i++) {
                Console.WriteLine(" ============================================ ");
                Console.WriteLine(" Dime los datos de la " +(i+1)+ " columna.");

                for (int j = 0; j < horizontal; j++) {
                    Console.Write(" ");
                    numero = int.Parse(Console.ReadLine());
                    // Este if se encargara de que no ingresen datos menos de 1000.
                    if (numero >= 1000) {
                        matriz[i,j] = numero;
                    } else {
                        Console.WriteLine(" Fabor de ingresar un numero más grande que 1000.");
                        j--;
                    }

                } // Cierre del j bucle.

            } // Cierre del i bucle.
            // En este bucle se realizaran las operaciones.
            for (int i = 0; i < vertical; i++) {
                numero = 0;

                for (int j = 0; j < horizontal; j++) {
                    numero = matriz[i,j];
                    // En este if se realizan las operaciones.
                    if ((numero%2) == 0) {
                        numero /= 2;
                        matriz[i,j] = numero;
                    } else {
                        numero *= 3 + 1;
                        matriz[i,j] = numero;
                    }

                } // Cierre del j bucle.

            } // Cierre del i bucle.
            // Este es un separador.
            Console.Write("\n ~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*\n\n ");
            // En este bucle se imprime toda la matriz.
            for (int i = 0; i < vertical; i++) {

                for (int j = 0; j < horizontal; j++) {
                    Console.Write(matriz[i,j]+ ", ");
                } // Cierre del j bucle.

                Console.Write(" \n ");
            } // Cierre del i bucle.

            Console.ReadLine();
            // Porgrama hecho por Jesús Armando Ayala Silguero - 2706110
        }
    }
}
