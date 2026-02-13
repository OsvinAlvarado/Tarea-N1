/* Ejercicio Numero 3:
Desglose de billetes - Dado un monto en lempiras,
 mostrar la menor cantidad de billetes (500,
100, 50, 20, 10, 5, 2, 1) necesarios.
*/

using System;

namespace Ejercicios.Bloque1
{
    class Ejercicio_N3_DesgloseBilletes
    {
        public static void Ejecutar()
        {
            Console.WriteLine("Ingrese el monto en Lempiras: ");
            int monto;
            while (!int.TryParse(Console.ReadLine(), out monto) || monto <= 0)
            {
                Console.WriteLine("Error. Ingrese un valor valido para el monto: ");
            }

            int[] billetes = {500, 200, 100, 50, 20, 10, 5, 2, 1};



            foreach(int billete in billetes)
            {
                int cantidad = monto/billete;

                if(cantidad > 0)
                {
                    Console.WriteLine($"{cantidad} billete(s) de Lps. {billete}");
                    monto = monto % billete;
                    Console.Write("\nPresione enter para continuar... ");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }
    }
}