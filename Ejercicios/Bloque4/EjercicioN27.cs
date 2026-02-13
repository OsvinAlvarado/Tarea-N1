/*Ejercicio numero 27: Arreglo de temperaturas -
 Registrar temperaturas de 7 días. Mostrar: promedio semanal, días
sobre el promedio, día más caluroso, día más frío y variación entre días consecutivos.*/

using System;

namespace Ejercicios.Bloque3
{
    class Ejercicio_N27_TemperaturasSemana
    {
        public static void Ejecutar()
        {
            Console.Clear();

            double[] temp = new double[7];

            // Se ingresan las temperaturas
            for (int i = 0; i < 7; i++)
            {
                Console.Write($"Ingrese la temperatura del día {i + 1}: ");
                while (!double.TryParse(Console.ReadLine(), out temp[i]))
                {
                    Console.Write("Error. Ingrese una temperatura válida: ");
                }
            }

            double suma = 0;
            for (int i = 0; i < 7; i++)
            {
                suma += temp[i];
            }

            double promedio = suma / 7;

            int diasSobrePromedio = 0;
            int diaMax = 0;
            int diaMin = 0;

            for (int i = 0; i < 7; i++)
            {
                if (temp[i] > promedio)
                    diasSobrePromedio++;

                if (temp[i] > temp[diaMax])
                    diaMax = i;

                if (temp[i] < temp[diaMin])
                    diaMin = i;
            }

            Console.WriteLine("\n--- RESULTADOS ---");
            Console.WriteLine($"Promedio semanal: {promedio:F2}");
            Console.WriteLine($"Días sobre el promedio: {diasSobrePromedio}");
            Console.WriteLine($"Día más caluroso: Día {diaMax + 1} con {temp[diaMax]}°");
            Console.WriteLine($"Día más frío: Día {diaMin + 1} con {temp[diaMin]}°");

            Console.WriteLine("\nVariación entre días consecutivos:");
            for (int i = 1; i < 7; i++)
            {
                double variacion = temp[i] - temp[i - 1];
                Console.WriteLine($"Día {i} → Día {i + 1}: {variacion:+0.##;-0.##;0}°");
            }

            Console.WriteLine("\nPresione una tecla para continuar...");
            Console.ReadKey();
        }
    }
}