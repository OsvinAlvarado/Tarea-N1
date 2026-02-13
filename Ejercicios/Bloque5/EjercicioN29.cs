/*Ejercicio numero 29: Juego de Gato (Tic-Tac-Toe) -
 Implementar el juego para dos jugadores. Usar matriz 3×3, validar
movimientos, detectar ganador o empate y permitir reiniciar.*/

using System;

namespace Ejercicios.Bloque4
{
    class Ejercicio_N29_Gato
    {
        public static void Ejecutar()
        {
            char[,] tablero = new char[3, 3];
            bool jugarDeNuevo;

            do
            {
                Inicializar(tablero);
                char jugador = 'X';
                bool hayGanador = false;
                int movimientos = 0;

                while (!hayGanador && movimientos < 9)
                {
                    Console.Clear();
                    Mostrar(tablero);
                    Console.WriteLine($"\nTurno del jugador {jugador}");

                    int fila, columna;

                    Console.Write("Fila (1-3): ");
                    while (!int.TryParse(Console.ReadLine(), out fila) || fila < 1 || fila > 3)
                        Console.Write("Fila inválida. Ingrese 1-3: ");

                    Console.Write("Columna (1-3): ");
                    while (!int.TryParse(Console.ReadLine(), out columna) || columna < 1 || columna > 3)
                        Console.Write("Columna inválida. Ingrese 1-3: ");

                    fila--; 
                    columna--;

                    if (tablero[fila, columna] != ' ')
                    {
                        Console.WriteLine("Esa posición ya está ocupada.");
                        Console.ReadKey();
                        continue;
                    }

                    tablero[fila, columna] = jugador;
                    movimientos++;

                    if (HayGanador(tablero, jugador))
                    {
                        Console.Clear();
                        Mostrar(tablero);
                        Console.WriteLine($"\n¡Ganó el jugador {jugador}!");
                        hayGanador = true;
                    }
                    else
                    {
                        jugador = (jugador == 'X') ? 'O' : 'X';
                    }
                }

                if (!hayGanador)
                {
                    Console.Clear();
                    Mostrar(tablero);
                    Console.WriteLine("\nEmpate.");
                }

                Console.Write("\n¿Desea jugar de nuevo? (s/n): ");
                jugarDeNuevo = Console.ReadLine().ToLower() == "s";

            } while (jugarDeNuevo);
        }

        static void Inicializar(char[,] t)
        {
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    t[i, j] = ' ';
        }

        static void Mostrar(char[,] t)
        {
            Console.WriteLine("  1   2   3");
            for (int i = 0; i < 3; i++)
            {
                Console.Write((i + 1) + " ");
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(t[i, j]);
                    if (j < 2) Console.Write(" | ");
                }
                Console.WriteLine();
                if (i < 2) Console.WriteLine(" ---+---+---");
            }
        }

        static bool HayGanador(char[,] t, char j)
        {
            for (int i = 0; i < 3; i++)
            {
                if (t[i,0] == j && t[i,1] == j && t[i,2] == j) return true;
                if (t[0,i] == j && t[1,i] == j && t[2,i] == j) return true;
            }

            if (t[0,0] == j && t[1,1] == j && t[2,2] == j) return true;
            if (t[0,2] == j && t[1,1] == j && t[2,0] == j) return true;

            return false;
        }
    }
}