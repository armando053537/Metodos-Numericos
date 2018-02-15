using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Actividad_3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  Programa 1
            //  Variables  \\
            int renglones = 0, columnas = 0, numeros = 0;
            int[,] matriz;

            //  Programa  \\
            System.Console.WriteLine(" Este es un programa que multiplica los datos de una matriz.");
            System.Console.WriteLine("-----------------------------------------------------------------");
            System.Console.Write(" Dime cuantos renglones quieres: ");
            renglones = int.Parse(System.Console.ReadLine());
            System.Console.Write(" Dime cuantas columnas quieres: ");
            columnas = int.Parse(System.Console.ReadLine());
            matriz = new int [columnas, renglones];

            for (int i = 0; i < columnas; i++) {
                System.Console.WriteLine(" Estas en la " +(i+1)+ " columna.");

                for (int j = 0; j < renglones; j++) {

                    if (j == 0) {
                        System.Console.WriteLine(" Introduce los datos del renglon:");
                    }
                    System.Console.Write(" ");
                    numeros = int.Parse(System.Console.ReadLine());
                    matriz[i, j] = numeros;
                }

            }

            System.Console.Write(" Por cual numero quieres multiplicar toda la matriz?: ");
            numeros = int.Parse(System.Console.ReadLine());

            for (int i = 0; i < columnas; i++) {

                for (int j = 0; j < renglones; j++) {
                    matriz[i, j] *= numeros;
                }

            }

            System.Console.WriteLine(" Esta seria tu matriz multiplicada.");
            System.Console.WriteLine("=============================================");

            for (int i = 0; i < columnas; i++)
            {

                for (int j = 0; j < renglones; j++)
                {
                    System.Console.Write(" " +matriz[i,j]);
                }

                System.Console.WriteLine(" ");
            }

            System.Console.ReadLine();
            */








            /*  Programa 2
            // Variables \\
            int materias = 0, calificacion = 0, promedio = 0;
            int[] calificaciones;

            //  Programa \\
            System.Console.Write(" Cuantas materias tienes en total?: ");
            materias = int.Parse(System.Console.ReadLine());
            calificaciones = new int [materias];

            for (int i = 0; i < materias; i++) {
                System.Console.Write(" Dime la calificacion de la " +(i+1)+ " materia: ");
                calificacion = int.Parse(System.Console.ReadLine());
                calificaciones[i] = calificacion;
            }

            for (int i = 0; i < materias; i++) {
                promedio += calificaciones[i];
            }

            System.Console.WriteLine(" Tu promedio general es de: " +(promedio/materias));
            System.Console.ReadLine();
            */
        }
    }
}
