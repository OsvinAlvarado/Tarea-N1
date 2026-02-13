/* Ejercicio numero 5: Tiempo transcurrido 
- Dadas dos horas en formato 24h (hora:minuto:segundo), calcular la
diferencia en horas, minutos y segundos.
*/

using System;

namespace Ejercicios.Bloque1
{
    class Ejercicio_N5_tiempoTranscurrido
    {
        public static void Ejecutar()
        {
            Console.WriteLine("Ingrese la Primer hora en formato (HH:MM:SS): ");
            string? hora1 = Console.ReadLine();

            Console.WriteLine("Ingrese la Segunda hora en formato (HH:MM:SS): ");
            string? hora2 = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(hora1) || string.IsNullOrWhiteSpace(hora2))//Valida si se dejo en blanco
            {
                Console.WriteLine("Error: Las horas no pueden estar vacías.");
                return;
            }

            string[] parte1 = hora1.Split(":");
            string[] parte2 = hora2.Split(":");

            int hora_parte1 = int.Parse(parte1[0]);
            int minutos_parte1 = int.Parse(parte1[1]);
            int segundos_parte1 = int.Parse(parte1[2]);

            int hora_parte2 = int.Parse(parte2[0]);
            int minutos_parte2 = int.Parse(parte2[1]);
            int segundos_parte2 = int.Parse(parte2[2]);

            //Ahora vamos a comvertir todo a segundos
            int segundos_totales1 = (hora_parte1 * 3600) + (minutos_parte1 * 60) + segundos_parte1;
            int segundos_totales2 = (hora_parte2 * 3600) + (minutos_parte2 * 60) + segundos_parte2;

            //Encontramos la diferencia de horas
            int diferencia = segundos_totales2 - segundos_totales1;

            int horas = diferencia / 3600;
            int resto = diferencia % 3600;
            int minutos = resto / 60;
            int segundos = resto % 60;

            Console.WriteLine($"La diferencia de horas es de : {horas} horas, {minutos} minutos, {segundos} segundos");
            Console.WriteLine("Presione enter para continuar...");
            Console.ReadKey();

        }
    }
}