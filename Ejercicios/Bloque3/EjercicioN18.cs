/*Ejercicio numero 18: Factorial y combinaciones - 
Calcular el factorial de N y luego calcular C(n,r) = n! / (r!(n-r)!) para
valores ingresados.*/

using System;
using System.Globalization;

namespace Ejercicios.Bloque3
{
    class Ejercicio_N18_FactorialCombinaciones
    {
        public static void Ejecutar()
        {
            Console.Clear();
            Console.WriteLine("Ingrese un numero N: ");
            long N;
            while (!long.TryParse(Console.ReadLine(), out N) || N < 0)
            {
                Console.WriteLine("Error. Ingrese un numero valido para N: ");
            }
            
            Console.WriteLine("Ingrese un numero r: ");
            long r;
            while (!long.TryParse(Console.ReadLine(), out r) || r < 0)
            {
                Console.WriteLine("Error. Ingrese un numero valido para r: ");
            }

             long factN = Factorial(N);
            long factR = Factorial(r);
            long factNR = Factorial(N - r);

            long combinacion = factN / (factR * factNR);

            Console.WriteLine($"\n{N}! = {factN}");
            Console.WriteLine($"C({N},{r}) = {combinacion}");

            Console.ReadKey();
        }

         static long Factorial(long num)
        {
            long resultado = 1;

            for (int i = 1; i <= num; i++)
            {
                resultado *= i;
            }

            return resultado;
        }
    }
}