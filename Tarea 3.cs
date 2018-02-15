using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tarea_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables \\
            int escuelas = 0, numaestros = 0;
            String nombres;
            String[][] maestros;

            // Porgrama \\
            System.Console.Write(" En cuantas escuelas has estado en primaria?: ");
            escuelas = int.Parse(System.Console.ReadLine());
            maestros = new String [escuelas][];

            for (int i = 0; i < maestros.Length; i++) {
                System.Console.Write(" Cuantos maestros has tenido en la " +(i+1)+ " escuela?: ");
                numaestros = int.Parse(System.Console.ReadLine());
                System.Console.WriteLine(" Dime los nombres de los maestros:");
                maestros[i] = new String [numaestros];

                for (int j = 0; j < maestros[i].Length; j++) {
                    System.Console.Write(" ");
                    nombres = System.Console.ReadLine();
                    maestros[i][j] = nombres;
                }

            }

            System.Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            for (int i = 0; i < maestros.Length; i++) {
                System.Console.WriteLine(" En la escuela " +(i+1)+ " tus maestros fueron: ");

                for (int j = 0; j < maestros[i].Length; j++) {
                    System.Console.WriteLine(" " +maestros[i][j]);
                }

                System.Console.WriteLine("====================================================");
            }

            System.Console.ReadLine();
        }
    }
}
