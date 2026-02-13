/*Ejercicio numero 25:Rotación de arreglo -
 Crear arreglo de N elementos. Implementar menú para: rotar K posiciones
a la izquierda, rotar K posiciones a la derecha, invertir el arreglo. */
using System;

namespace Ejercicios.Bloque3
{
    class Ejercicio_N25_RotacionArreglo
    {
        public static void Ejecutar()
        {
            Console.Clear();

            
            Console.Write("Ingrese el tamaño del arreglo: ");
            int n;
            while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            {
                Console.Write("Error. Ingrese un número válido: ");
            }

            int[] arreglo = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Ingrese el elemento #{i + 1}: ");
                while (!int.TryParse(Console.ReadLine(), out arreglo[i]))
                {
                    Console.Write("Error. Ingrese un número válido: ");
                }
            }

            int opcion;
            do
            {
                Console.Clear();
                Console.WriteLine("----- MENÚ ROTACIÓN -----");
                Console.WriteLine("1. Rotar K posiciones a la izquierda");
                Console.WriteLine("2. Rotar K posiciones a la derecha");
                Console.WriteLine("3. Invertir el arreglo");
                Console.WriteLine("4. Salir");
                Console.Write("Ingrese una opción: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Write("Ingrese K: ");
                        int kIzq = int.Parse(Console.ReadLine());
                        RotarIzquierda(arreglo, kIzq);
                        MostrarArreglo(arreglo);
                        break;

                    case 2:
                        Console.Write("Ingrese K: ");
                        int kDer = int.Parse(Console.ReadLine());
                        RotarDerecha(arreglo, kDer);
                        MostrarArreglo(arreglo);
                        break;

                    case 3:
                        Invertir(arreglo);
                        MostrarArreglo(arreglo);
                        break;
                }

                if (opcion != 4)
                {
                    Console.WriteLine("\nPresione una tecla para continuar...");
                    Console.ReadKey();
                }

            } while (opcion != 4);
        }

        static void RotarIzquierda(int[] arr, int k)
        {
            k = k % arr.Length;

            for (int r = 0; r < k; r++)
            {
                int primero = arr[0];
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    arr[i] = arr[i + 1];
                }
                arr[arr.Length - 1] = primero;
            }
        }

        static void RotarDerecha(int[] arr, int k)
        {
            k = k % arr.Length;

            for (int r = 0; r < k; r++)
            {
                int ultimo = arr[arr.Length - 1];
                for (int i = arr.Length - 1; i > 0; i--)
                {
                    arr[i] = arr[i - 1];
                }
                arr[0] = ultimo;
            }
        }

        static void Invertir(int[] arr)
        {
            for (int i = 0; i < arr.Length / 2; i++)
            {
                int temp = arr[i];
                arr[i] = arr[arr.Length - 1 - i];
                arr[arr.Length - 1 - i] = temp;
            }
        }

        static void MostrarArreglo(int[] arr)
        {
            Console.WriteLine("\nArreglo actual:");
            foreach (int x in arr)
                Console.Write(x + " ");
            Console.WriteLine();
        }
    }
}