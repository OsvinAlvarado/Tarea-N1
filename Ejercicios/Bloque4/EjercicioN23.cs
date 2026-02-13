/*Ejercicio numero 23: Estadísticas de calificaciones -
 Ingresar N calificaciones en un arreglo. Calcular: promedio,
máxima, mínima, cantidad de aprobados/reprobados y desviación estándar.*/

using System;

namespace Ejercicios.Bloque3
{
    class Ejercicio_N23_EstadisticasCalificaciones
    {
        public static void Ejecutar()
        {
            Console.Clear();

            int n;
            Console.Write("Ingrese cuántas calificaciones desea ingresar: ");
            while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            {
                Console.Write("Error. Ingrese un número válido: ");
            }

            double[] notas = new double[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Ingrese la calificación #{i + 1}: ");
                while (!double.TryParse(Console.ReadLine(), out notas[i]) || notas[i] < 0 || notas[i] > 100)
                {
                    Console.Write("Error. Ingrese una nota entre 0 y 100: ");
                }
            }

            double suma = 0;
            double max = notas[0];
            double min = notas[0];
            int aprobados = 0;
            int reprobados = 0;

            for (int i = 0; i < n; i++)
            {
                suma += notas[i];

                if (notas[i] > max)
                    max = notas[i];

                if (notas[i] < min)
                    min = notas[i];

                if (notas[i] >= 60)
                    aprobados++;
                else
                    reprobados++;
            }

            double promedio = suma / n;

            // La Desviación estándar
            double sumaCuadrados = 0;
            for (int i = 0; i < n; i++)
            {
                sumaCuadrados += Math.Pow(notas[i] - promedio, 2);
            }

            double desviacion = Math.Sqrt(sumaCuadrados / n);

            Console.WriteLine("\n--- ESTADÍSTICAS ---");
            Console.WriteLine($"Promedio: {promedio:F2}");
            Console.WriteLine($"Nota máxima: {max}");
            Console.WriteLine($"Nota mínima: {min}");
            Console.WriteLine($"Aprobados: {aprobados}");
            Console.WriteLine($"Reprobados: {reprobados}");
            Console.WriteLine($"Desviación estándar: {desviacion:F2}");

            Console.WriteLine("\nPresione una tecla para continuar...");
            Console.ReadKey();
        }
    }
}