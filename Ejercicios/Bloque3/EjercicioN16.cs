/*Ejercicio numero 16: 16. Números primos en rango - 
Dado un rango (inicio, fin), mostrar todos los números primos y
contar cuántos hay.*/

using System;

namespace Ejercicios.Bloque3
{
    class Ejercicio_N16_PrimosRango
    {
        public static void Ejecutar()
        {
            Console.Clear();
            Console.WriteLine("Ingrese un numero como primer limite: ");
            int limite1;
            while (!int.TryParse(Console.ReadLine(), out limite1) || limite1 < 0)
            {
                Console.WriteLine("Error. Ingrese un numero valido: ");
            }
            Console.WriteLine("Ingrese un numero como segundo limite: ");
            int limite2;
            while (!int.TryParse(Console.ReadLine(), out limite2) || limite2 <= limite1)
            {
                Console.WriteLine("Error. Ingrese un numero valido: ");
            }

            int contador = 0;

            for (int i = limite1; i <= limite2; i++)
            {
                if (EsPrimo(i))
                {
                    Console.WriteLine(i + "");
                    contador++;
                }
            }

            Console.WriteLine($"\n\nCantidad de números primos: {contador}");
            Console.ReadKey();
        }

        static bool EsPrimo(int n)
        {
            if (n <= 1)
                return false;

            for (int i = 2; i * i <= n; i++)
            {
                if (n % i == 0)
                    return false;
            }

            return true;
        }
    }
}