/*Ejercicio numero 21 Patrón de asteriscos -
 Menú para generar patrones: triángulo, triángulo invertido, rombo y
cuadrado hueco. El usuario define el tamaño.*/

using System;

namespace Ejercicios.Bloque3
{
    class Ejercicio_N21_PatronAsteriscos
    {
        public static void Ejecutar()
        {
            Console.Clear();
            Console.WriteLine("Ingrese el tamano de la figura: ");
            int tamano;
            while (!int.TryParse(Console.ReadLine(), out tamano) || tamano <= 0)
            {
                Console.WriteLine("Error. Ingrese un tamano correcto: ");
            }

            int opcion;
            do
            {
                Console.Clear();
                Console.WriteLine("-----Menu-----");
                Console.WriteLine("1. Triangulo.");
                Console.WriteLine("2. Triangulo invertido.");
                Console.WriteLine("3. Rombo.");
                Console.WriteLine("4. Cuadrado Vacio.");
                Console.WriteLine("5. Salir.");
                Console.WriteLine("Elija una opcion: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1: //Codigo que la fiera nos enseño a hacer😎
                           for (int i = 1; i <= tamano; i++)
                            {
                                for (int j = 1; j <= i; j++)
                                    Console.Write("*");
                                Console.WriteLine();
                            }

                           break;

                    case 2:
                             for (int i = tamano; i >= 1; i--)
                            {
                                for (int j = 1; j <= i; j++)
                                    Console.Write("*");
                                Console.WriteLine();
                            }
                          break; 

                    case 3: 
                                // Rombo
                            // Parte superior
                            for (int i = 1; i <= tamano; i++)
                            {
                                for (int e = 1; e <= tamano - i; e++)
                                    Console.Write(" ");
                                for (int a = 1; a <= (2 * i - 1); a++)
                                    Console.Write("*");
                                Console.WriteLine();
                            }

                            // Parte inferior
                            for (int i = tamano - 1; i >= 1; i--)
                            {
                                for (int e = 1; e <= tamano - i; e++)
                                    Console.Write(" ");
                                for (int a = 1; a <= (2 * i - 1); a++)
                                    Console.Write("*");
                                Console.WriteLine();
                            }
                          break; 

                    case 4: 
                            for (int i = 1; i <= tamano; i++)
                        {
                            for (int j = 1; j <= tamano; j++)
                            {
                                if (i == 1 || i == tamano || j == 1 || j == tamano)
                                    Console.Write("*");
                                else
                                    Console.Write(" ");
                            }
                            Console.WriteLine();
                        }
                          break;

                }

                 Console.WriteLine("\nPresione una tecla para continuar...");
                 Console.ReadKey();

            } while (opcion != 5);
        }

       
    }
}