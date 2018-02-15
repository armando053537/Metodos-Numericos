using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Actividad_4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*   Programa 1
            // Este programa suma numeros ingresados por el usuario y realiza el promedio de la suma total.
            int numeros = 0, sumados = 0, contador = 0;

            //  ===========================================================================================================================  \\

            System.Console.WriteLine(" Dime un numero que sea menor que 100; si ingresas el numero 0, el programa terminara.");

            do {
                // La variables numeros ingresara los datos.
                System.Console.Write(" ");
                numeros = int.Parse(System.Console.ReadLine());

                if (numeros > 100) {
                    // Si el numero es más de 100, el programa no sumara la variable ingresada y se reiniciara el ciclo.
                    System.Console.WriteLine(" Este numero no esta permitido, favor de ingresar otro.");
                } else {

                    if (numeros != 0) {
                        // Si el numero es menor que 100, se sumara en la variable sumados y sumara un uno en la variable contador para saber cuantos numeros
                        // ha ingresado el usuario. Si es 0, el programa se saltara esta operación, no se sumará en el contador y se terminará el programa.
                        sumados += numeros;
                        contador++;
                    }
                    
                }

            } while (numeros != 0);

            // El programa mostrara la suma total con la variable sumados y el promedio con esta variable y con la variable contador.
            System.Console.WriteLine("\n=====================================================================\n");
            System.Console.WriteLine(" Los numeros que has ingresado en total son: " +contador);
            System.Console.WriteLine(" El total de la suma de todos los numeros ingresados es: " +sumados);
            System.Console.WriteLine(" El promedio en total es: " +(sumados/contador));

            System.Console.Write(" ");
            System.Console.ReadLine();
            //  Programa hecho por: Jesús Armando Ayala Silguero - 2706110
            */







            /*   Programa 2
            // Este programa realiza una operación de una fórmula.
            int n = 0;
            double resultado = 0;

            //  ===========================================================================================================================  \\

            // La variable n ingresa el dato del usuario.
            System.Console.Write(" Dime un numero: ");
            n = int.Parse(System.Console.ReadLine());
            // La operación se realiza en una variable diferente para guardar los datos y se utiliza la variable n.
            resultado = ((Math.Pow(n, 1.5))-1)/n;
            System.Console.WriteLine(" El resultado de la formula (n3/2)-1/n es: " +resultado);
            System.Console.Write(" ");
            System.Console.ReadLine();
            //  Programa hecho por: Jesús Armando Ayala Silguero - 2706110
            */








            /*   Programa 3
            // Este programa pedira un numero al usuario, si el número es múltiplo de 5 le debe sumar 2, sí es múltiplo de 7 le debe sumar 1 y en cualquier
            // otro caso le debe sumar 3. Este proceso seguirá repitiendo el proceso 1000 veces.
            int numero = 0;

            //  ===========================================================================================================================  \\

            // El usuario ingresa el número y se guarda en la variable numero.
            System.Console.Write(" Dime un numero: ");
            numero = int.Parse(System.Console.ReadLine());

            // Este ciclo repetirá la suma hasta que sea 1000 veces.
            for (int i = 1; i < 1000; i++) {

                if ((numero % 5) == 0) {
                    // Si el reciduo de 5 es igual a 0, quiere decir que es un multiplo de 5 y sumara 2 al numero ingresado por el usuario.
                    numero += 2;
                } else {

                    if ((numero % 7) == 0) {
                        // Si el reciduo de 7 es igual a 0, quiere decir que es un multiplo de 7 y sumara 1 al numero ingresado por el usuario.
                        numero += 1;
                    } else {
                        // Si no es nunguno de los residuos, sumara 3 al numero ingresado por el usuario.
                        numero += 3;
                    }

                }

            }

            // Mostramos el resultado final del ciclo de la suma.
            System.Console.WriteLine(" El resultado final es: " +numero);

            System.Console.Write(" ");
            System.Console.ReadLine();
            //  Programa hecho por: Jesús Armando Ayala Silguero - 2706110
            */
        }
    }
}
