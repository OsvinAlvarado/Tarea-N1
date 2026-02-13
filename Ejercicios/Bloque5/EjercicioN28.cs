/*Ejercicio numero 28: Matriz de notas por parcial -
 Matriz de N estudiantes × 3 parciales. Calcular: promedio por
estudiante, promedio por parcial, estudiante con mejor promedio y parcial más difícil.*/

using System;

namespace Ejercicios.Bloque4
{
    class Ejercicio_N28_MatrizNotasParcial
    {
        public static void Ejecutar()
        {
            Console.Clear();

            int n;
            Console.Write("Ingrese la cantidad de estudiantes: ");
            while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            {
                Console.Write("Error. Ingrese un número válido: ");
            }

            double[,] notas = new double[n, 3];

            // Ingreso de notas
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\nEstudiante {i + 1}:");
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"  Parcial {j + 1}: ");
                    while (!double.TryParse(Console.ReadLine(), out notas[i, j]) || notas[i, j] < 0 || notas[i, j] > 100)
                    {
                        Console.Write("  Error. Ingrese nota entre 0 y 100: ");
                    }
                }
            }

            double mejorPromedio = 0;
            int estudianteMejor = 0;

            double[] sumaParcial = new double[3];

            Console.WriteLine("\n--- PROMEDIO POR ESTUDIANTE ---");

            for (int i = 0; i < n; i++)
            {
                double suma = 0;
                for (int j = 0; j < 3; j++)
                {
                    suma += notas[i, j];
                    sumaParcial[j] += notas[i, j];
                }

                double promedio = suma / 3;
                Console.WriteLine($"Estudiante {i + 1}: {promedio:F2}");

                if (i == 0 || promedio > mejorPromedio)
                {
                    mejorPromedio = promedio;
                    estudianteMejor = i;
                }
            }

            Console.WriteLine("\n--- PROMEDIO POR PARCIAL ---");

            double parcialMasDificil = 0;
            int indiceParcialDificil = 0;

            for (int j = 0; j < 3; j++)
            {
                double promedioParcial = sumaParcial[j] / n;
                Console.WriteLine($"Parcial {j + 1}: {promedioParcial:F2}");

                if (j == 0 || promedioParcial < parcialMasDificil)
                {
                    parcialMasDificil = promedioParcial;
                    indiceParcialDificil = j;
                }
            }

            Console.WriteLine($"\nEstudiante con mejor promedio: Estudiante {estudianteMejor + 1} con {mejorPromedio:F2}");
            Console.WriteLine($"Parcial más difícil: Parcial {indiceParcialDificil + 1} con promedio {parcialMasDificil:F2}");

            Console.WriteLine("\nPresione una tecla para continuar...");
            Console.ReadKey();
        }
    }
}