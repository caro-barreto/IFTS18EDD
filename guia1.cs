using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1) Escribir un programa que diga el resultado de sumar 200 y 56.
            int suma1 = 200 + 56;
            

            //2) Hacer un programa que calcule el producto de los números 13 y 12.
            int producto1 = 13 * 12;
            

            //3) Desarrollar un programa que calcule la diferencia (resta) entre 321 y 213
            int resta1 = 321 - 213;


            //4) Calcular el resultado de (20+5) % 6 mostrando el resultado en la consola.
            Console.WriteLine("Ejercicio 4");
            int res1 = (20 + 5) % 6;

            Console.WriteLine(res1);

            //5) Crear un programa que calcule el producto de los números 12 y 102, usando  variables.  
            int n1 = 12;
            int n2 = 102;
            int producto2 = n1 * n2;

            // 6) Crear un programa que calcule la suma de 200 y 1111, usando variables.
            int n3 = 200;
            int n4 = 1111;
            int suma2 = n3 + n4;

            //7) Crea un programa que calcule el producto de los números 10 y 25, usando  variables llamadas "numero1" y "numero2"
            int numero1 = 10;
            int numero2 = 25;
            int producto3 = numero1 * numero2;

            // 8) Crear un programa que calcule el producto de dos números n y m
            int n = 3;
            int m = 4;
            int producto4 = n * m;

            // 9) Escribir un programa que muestre el estado de un alumno segun su nota. Ej: 1-3 reprobado, 
            // 4-6 debe rendir final, 7-10 promocionado. Probar para los tres casos  usando If-Else 
            Console.WriteLine("Ejercicio 9");
            Console.WriteLine("Ingrese nota para mostrar la condición del alumno:");
            int nota = Convert.ToInt32(Console.ReadLine());
            if (nota >= 1 && nota <= 3)
                {
                Console.WriteLine("El alumno está reprobado");
                }
            else if (nota >= 4 && nota <= 6) 
                { 
                Console.WriteLine("El alumno debe rendir final");
                }
            else if (nota >= 7 && nota <= 10 )
            {
                Console.WriteLine("El alumno promocionó la materia");
            }
            else
            {
                Console.WriteLine("Ingresó una nota no válida. Las notas son entre 1 y 10");
            }

            //Parte B

            // 10) Crea un programa que pida al usuario un número entero y diga si es par 
            //(pista: habrá que comprobar si el resto que se obtiene al dividir entre dos es cero: if (x % 2 == 0) …). 
            Console.WriteLine("Ejercicio 10");
            Console.WriteLine("Ingrese un número, el programa le dirá si es par o no :) ");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("El número es par");
            }

            else
            {
                Console.WriteLine("El número es impar");
            }

            //11) Crea un programa que pida al usuario dos números enteros y diga cuál es el  mayor de ellos.  
            Console.WriteLine("Ejercicio 11");
            Console.WriteLine("Ingrese un número entero");
            int numero3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese un número entero");
            int numero4 = Convert.ToInt32(Console.ReadLine());

            if (numero3 > numero4)
            {
                Console.WriteLine($"{numero3} es mayor que {numero4}");
            }

            else 
            {
                Console.WriteLine($"{numero4} es mayor que {numero3}");

            }


            // 12) Crea un programa que pida al usuario dos números enteros. Si el segundo no es  cero, mostrará el 
            //resultado de dividir entre el primero y el segundo. 
            //Por el contrario, si el  segundo número es cero, escribirá "Error: No se puede dividir entre cero"

            Console.WriteLine("Ejercicio 12");
            Console.WriteLine("Ingrese un número entero");
            int numero5 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese un número entero");
            int numero6 = Convert.ToInt32(Console.ReadLine());

            if (numero6 != 0)
            {
                int division1 = numero5 / numero6;
                Console.WriteLine($"El resultado de la división entre {numero5} y {numero6} es {division1}");

            }
            else
            {
                Console.WriteLine("Error, no se puede dividir entre cero");
            }


            // 13) Crea un programa que pida un número del 1 al 5 al usuario, y escriba el nombre  de ese número, 
            //usando "switch" (por ejemplo, si introduce "1", el programa escribirá  "uno"). 
            Console.WriteLine("Ejercicio 13");
            Console.WriteLine("Ingrese un número del 1 al 5");
            int numero7 = Convert.ToInt32(Console.ReadLine());
            switch(numero7)
            {
                case 1:
                    Console.WriteLine("Uno");
                    break;

                case 2:
                    Console.WriteLine("Dos");
                    break;

                case 3:
                    Console.WriteLine("Tres");
                    break;

                case 4:
                    Console.WriteLine("Cuatro");
                    break;

                case 5:
                    Console.WriteLine("Cinco");
                    break;
            }
            // 14) Crea un programa que escriba en pantalla los números del 1 al 10, usando  "while". 
            Console.WriteLine("Ejercicio 14");
            int i = 0;
            while (i <= 10)
            {
                Console.WriteLine(i);
                i++;
            }


            //15) Crea un programa que escriba en pantalla los números del 1 al 10, usando  "do..while".   
            Console.WriteLine("Ejercicio 15");
            int o = 0;
            do
            {
                Console.WriteLine(o);
                o ++;

            }

            while (o <= 10);
        }
    }
}
