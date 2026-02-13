/*ejercicio numero 24: Búsqueda y ordenamiento - 
Llenar arreglo de 10 enteros. Implementar: búsqueda lineal,
encontrar el segundo mayor, ordenar de forma ascendente (burbuja) y mostrar elementos en
posiciones pares.*/

using System;

namespace Ejercicios.Bloque3
{
    class Ejercicio_N24_BusquedaOrdenamiento
    {
        public static void Ejecutar()
        {
            Console.Clear();

            int[] numeros = new int[10];

            // Aqui se llena el  arreglo
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write($"Ingrese el número #{i + 1}: ");
                while (!int.TryParse(Console.ReadLine(), out numeros[i]))
                {
                    Console.Write("Error. Ingrese un número válido: ");
                }
            }

            // Búsqueda lineal
            Console.Write("\nIngrese el número a buscar: ");
            int buscado;
            while (!int.TryParse(Console.ReadLine(), out buscado))
            {
                Console.Write("Error. Ingrese un número válido: ");
            }

            bool encontrado = false;
            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] == buscado)
                {
                    Console.WriteLine($"Número encontrado en la posición {i}");
                    encontrado = true;
                    break;
                }
            }

            if (!encontrado)
                Console.WriteLine("Número no encontrado.");

            // Encontrar el  segundo numero mayor
            int mayor = int.MinValue;
            int segundoMayor = int.MinValue;

            foreach (int num in numeros)
            {
                if (num > mayor)
                {
                    segundoMayor = mayor;
                    mayor = num;
                }
                else if (num > segundoMayor && num != mayor)
                {
                    segundoMayor = num;
                }
            }

            Console.WriteLine($"\nMayor: {mayor}");
            Console.WriteLine($"Segundo mayor: {segundoMayor}");

            // Ordenamiento burbuja que es ascendente
            for (int i = 0; i < numeros.Length - 1; i++)
            {
                for (int j = 0; j < numeros.Length - 1; j++)
                {
                    if (numeros[j] > numeros[j + 1])
                    {
                        int temp = numeros[j];
                        numeros[j] = numeros[j + 1];
                        numeros[j + 1] = temp;
                    }
                }
            }

            Console.WriteLine("\nArreglo ordenado:");
            foreach (int num in numeros)
                Console.Write(num + " ");

            // AQui se muestran los elementos en posiciones pares
            Console.WriteLine("\n\nElementos en posiciones pares:");
            for (int i = 0; i < numeros.Length; i++)
            {
                if (i % 2 == 0)
                    Console.WriteLine($"Posición {i}: {numeros[i]}");
            }

            Console.WriteLine("\nPresione una tecla para continuar...");
            Console.ReadKey();
        }
    }
}