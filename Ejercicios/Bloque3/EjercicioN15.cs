/*Ejercicio numero 15: Tabla de multiplicar extendida -
 Solicitar un número y mostrar su tabla del 1 al 12 con formato
alineado.*/

using System;
using System.Globalization;

namespace Ejercicios.Bloque3
{
    class Ejercicio_N15_TablaMultiplicar
    {
        public static void Ejecutar()
        {
            Console.Clear();
            Console.WriteLine("Ingrese un numero para mostrar su tabla: ");
            long numero;
            while (!long.TryParse(Console.ReadLine(), out numero) || numero <= 0)
            {
                Console.WriteLine("Error.  Ingrese un numero valido: ");
            }

            int j = 1;
            Console.WriteLine($"Tabla del {numero}");
            for (int i = 0; j < 13; i++)
            {
                
                Console.WriteLine($"{i + 1}. {numero} x {j} = {numero*j}");
                j++;
            }
            Console.WriteLine("Presione enter para continuar...");
            Console.ReadKey();
        }
    }
}