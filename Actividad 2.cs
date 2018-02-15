using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Actividad_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  Programa 1
            // Variables \\
            int hora = 0;
            bool repetir = false;

            // Programa \\
            System.Console.WriteLine(" Este programa utilizara un horario de 24 horas");
            System.Console.WriteLine("-----------------------------------------------");

            do {
                System.Console.Write(" A que hora te duermes? : ");
                hora = int.Parse(System.Console.ReadLine());
                repetir = false;

                if (hora <= 23 && hora >= 0) {

                    if (hora == 0 || hora == 1) {
                        System.Console.WriteLine(" Duerme usted un poco tarde, trate de descansar más.");
                    } else {

                        if (hora >= 2 && hora <= 4) {
                            System.Console.WriteLine(" Usted duerme muy tarde, eso no es bueno para la salud.");
                        } else {

                            if (hora >= 5 && hora <= 10) {
                                System.Console.WriteLine(" Supongo que duerme a estas horas porque tiene un trabajo nocturno.");
                            } else {

                                if (hora >= 11 && hora <= 18) {
                                    System.Console.WriteLine(" Usted tiene un horario de sueño muy extraño.");
                                } else {

                                    if (hora == 19 || hora == 20) {
                                        System.Console.WriteLine(" Usted duerme muy temprano.");
                                    } else {

                                        if (hora >= 21 && hora <= 23) {
                                            System.Console.WriteLine(" Usted duerme a muy buena hora, felicidades.");
                                        }

                                    }

                                }

                            }
                        
                        }
                    
                    }
                
                } else {
                    System.Console.WriteLine("\n La hora no es correcta, por favor, ingresela nuevamente.");
                    System.Console.WriteLine("================================================================");
                    repetir = true;
                }

            } while (repetir != false);
            
            System.Console.ReadLine();
            */








            /*  Programa 2
            // Variables \\
            int resultado = 0;

            // Programa \\
            Console.WriteLine(" Este programa sumara del 1 hasta el 1000.");
            Console.WriteLine("---------------------------------------------");

            for (int i = 1; i <= 1000; i++) {
                resultado += i;

                if (i >= 1000) {
                    Console.WriteLine(" El resultado de la suma de todos los numeros es: " +resultado);
                }

            }

            System.Console.ReadLine();
            */








            /*  Programa 3
            // Variables \\
            int numero = 0, divicion = 0, contador = 0, prueba = 0;

            // Programa \\
            Console.Write(" Dime un numero: ");
            numero = int.Parse(Console.ReadLine());
            divicion = numero;
            prueba = numero % 2;

            if (prueba == 0) {

                for (int i = 1; divicion != 1; i++) {
                    divicion /= 2;
                    contador += 1;
                }

                Console.WriteLine(" El numero " +numero+ " puede dividirse " +contador+ " veces entre 2.");
            } else {
                Console.WriteLine(" El numero " +numero+ " es una potencia de 2");
            }

            Console.ReadLine();
            */
        }
    }
}
