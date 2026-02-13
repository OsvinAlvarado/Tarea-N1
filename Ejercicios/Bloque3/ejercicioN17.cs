/*Ejercicio numero 17 : Serie Fibonacci -
 Generar los primeros N términos de Fibonacci. Mostrar también la suma total
y el promedio.*/

using System;
using System.Globalization;

namespace Ejercicios.Bloque3
{
    class Ejercicio_N17_SerieFibonacci
    {
        public static void Ejecutar()
        {
            Console.Clear();
            Console.WriteLine("Ingrese un numero para generar la cantidad de terminos: ");
            int cantidad;
            while (!int.TryParse(Console.ReadLine(), out cantidad) || cantidad < 0)
            {
                Console.WriteLine("Error. Ingrese un numero valido: ");
            }

            long j = 0;
            long k = 1;
            long suma = 0;

            Console.WriteLine($"Los Primeros {cantidad} numeros son:");
            for (int i = 0; i < cantidad; i++)
            {
                 Console.Write(j + " ");
                suma += j;

                long siguiente = j + k;
                j = k;
                k = siguiente;
            }

            double promedio = (double)suma / cantidad;

            Console.WriteLine($"\n\nSuma total: {suma}");
            Console.WriteLine($"Promedio: {promedio}");
            Console.ReadKey();
        }
    }
}