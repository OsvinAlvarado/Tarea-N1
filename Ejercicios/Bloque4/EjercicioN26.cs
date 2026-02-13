/*Ejercicio numero 26: Frecuencia de elementos -
 Generar 20 números aleatorios (1-10). Mostrar la frecuencia de cada
número y cuál es el más y menos frecuente.*/

using System;

namespace Ejercicios.Bloque3
{
    class Ejercicio_N26_FrecuenciaElementos
    {
        public static void Ejecutar()
        {
            Console.Clear();

            int[] numeros = new int[20];
            int[] frecuencia = new int[11]; // índices 1 a 10

            Random rnd = new Random();

            // Generar números aleatorios
            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = rnd.Next(1, 11); // Se generan de 1 a 10
            }

            //Se Cuentan las frecuencias
            for (int i = 0; i < numeros.Length; i++)
            {
                frecuencia[numeros[i]]++;
            }

            Console.WriteLine("Números generados:");
            foreach (int n in numeros)
                Console.Write(n + " ");

            Console.WriteLine("\n\nFrecuencia de cada número:");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{i} → {frecuencia[i]} veces");
            }

            // Encontrar más y menos frecuente
            int maxFrecuencia = frecuencia[1];
            int minFrecuencia = frecuencia[1];
            int numMax = 1;
            int numMin = 1;

            for (int i = 2; i <= 10; i++)
            {
                if (frecuencia[i] > maxFrecuencia)
                {
                    maxFrecuencia = frecuencia[i];
                    numMax = i;
                }

                if (frecuencia[i] < minFrecuencia)
                {
                    minFrecuencia = frecuencia[i];
                    numMin = i;
                }
            }

            Console.WriteLine($"\nNúmero más frecuente: {numMax} (aparece {maxFrecuencia} veces)");
            Console.WriteLine($"Número menos frecuente: {numMin} (aparece {minFrecuencia} veces)");

            Console.WriteLine("\nPresione una tecla para continuar...");
            Console.ReadKey();
        }
    }
}