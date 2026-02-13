/*Ejercicio numero 19: Juego de adivinanza -
 El programa genera un número aleatorio (1-100). El usuario tiene 7
intentos con pistas de "mayor" o "menor". Mostrar estadísticas al final.*/

using System;

namespace Ejercicios.Bloque3
{
    class Ejercicio_N19_JuegoAdivinanza
    {
        public static void Ejecutar()
        {
            Console.Clear();
            Random rnd = new Random();
            int aleatorio = rnd.Next(1,101);
            int intentos = 7;
            int intentoActual = 0;
            bool gano = false;

            while (intentoActual < intentos)
            {
                Console.Write($"Intento {intentoActual + 1}: ");
                int numeroUsuario;

                while (!int.TryParse(Console.ReadLine(), out numeroUsuario))
                {
                    Console.Write("Entrada inválida. Intente de nuevo: ");
                }

                intentoActual++;

                if (numeroUsuario == aleatorio)
                {
                    Console.WriteLine("¡Correcto! Adivinaste el número.");
                    gano = true;
                    break;
                }
                else if (numeroUsuario < aleatorio)
                {
                    Console.WriteLine("Pista: el número es MAYOR.");
                }
                else
                {
                    Console.WriteLine("Pista: el número es MENOR.");
                }
            }

            Console.WriteLine("\n--- ESTADÍSTICAS ---");
            Console.WriteLine($"Número secreto: {aleatorio}");
            Console.WriteLine($"Intentos usados: {intentoActual}");

            if (gano)
                Console.WriteLine("Resultado: GANASTE");
            else
                Console.WriteLine("Resultado: PERDISTE");

            Console.WriteLine("\nPresione una tecla para volver al menú...");
            Console.ReadKey();
            

            
           
        }
    }
}

    
